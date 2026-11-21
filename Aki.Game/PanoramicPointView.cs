using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020017F5 RID: 6133
[NullableContext(1)]
[Nullable(0)]
public class PanoramicPointView : UiPanelBase
{
	// Token: 0x0600F062 RID: 61538 RVA: 0x0046A05C File Offset: 0x0046825C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		if (!Info.Instance.IsInTouch())
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUIItem)));
		}
	}

	// Token: 0x0600F063 RID: 61539 RVA: 0x0046A0EC File Offset: 0x004682EC
	protected override void OnStart()
	{
		UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
		this.LimitA = Math.Min(1176f, (((uiRootItem != null) ? uiRootItem.GetWidth() : 0f) - 1008f) / 2f);
		this.LimitB = Math.Min(712.5f, (((uiRootItem != null) ? uiRootItem.GetHeight() : 0f) - 495f) / 2f);
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetUIActive(true);
		}
		this.SprArrow = base.GetItem(1);
		UUIItem sprArrow = this.SprArrow;
		if (sprArrow != null)
		{
			sprArrow.SetUIActive(false);
		}
		InputMultiKeyItem keyItem = this.KeyItem;
		if (keyItem != null)
		{
			keyItem.SetUiActive(false);
		}
		this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		this.LastScreenPosition.Reset();
		this.ScreenPosition.Reset();
		UUIItem rootItem2 = this.RootItem;
		if (rootItem2 != null)
		{
			rootItem2.ResetRelativeTransform();
		}
		UUIItem rootItem3 = this.RootItem;
		if (rootItem3 != null)
		{
			rootItem3.SetAnchorOffset(new FVector2D(0f, 0f));
		}
		if (!Info.Instance.IsInTouch())
		{
			UUIItem rootItem4 = this.RootItem;
			if (rootItem4 != null)
			{
				UUIItem parentAsUIItem = rootItem4.GetParentAsUIItem();
				if (parentAsUIItem != null)
				{
					FRotator frotator = new FRotator(0f, 0f, 0f);
					parentAsUIItem.SetUIRelativeRotation(frotator);
				}
			}
		}
		this.ViewType = EPanoramicType.Default;
	}

	// Token: 0x0600F064 RID: 61540 RVA: 0x0046A240 File Offset: 0x00468440
	protected override UniTask OnBeforeStartAsync()
	{
		PanoramicPointView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PanoramicPointView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F065 RID: 61541 RVA: 0x0046A283 File Offset: 0x00468483
	protected override void OnAfterShow()
	{
	}

	// Token: 0x0600F066 RID: 61542 RVA: 0x0046A285 File Offset: 0x00468485
	[NullableContext(2)]
	public void DestroySelf(Action callback)
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.StopCurrentSequence(false, false);
		}
		if (callback != null)
		{
			callback();
		}
	}

	// Token: 0x0600F067 RID: 61543 RVA: 0x0046A2A4 File Offset: 0x004684A4
	public void Update()
	{
		TsCharacterController characterController = Global.CharacterController;
		FVectorDouble fvectorDouble = this.TargetPos.ToUeVector(false);
		FVector2D screenPositionRef = this.ScreenPositionRef;
		bool flag = UGameplayStatics.D_ProjectWorldToScreen(characterController, fvectorDouble, ref screenPositionRef, false);
		if (!flag)
		{
			FTransformDouble? cameraTransform = CameraModel.Instance.MainModel.CameraTransform;
			if (cameraTransform != null)
			{
				FVectorDouble fvectorDouble2 = cameraTransform.Value.InverseTransformPositionNoScale(fvectorDouble);
				fvectorDouble2.X = -fvectorDouble2.X;
				FVectorDouble fvectorDouble3 = cameraTransform.Value.TransformPositionNoScale(fvectorDouble2);
				UGameplayStatics.D_ProjectWorldToScreen(characterController, fvectorDouble3, ref screenPositionRef, false);
			}
		}
		FVector2D fvector2D = screenPositionRef;
		this.ScreenPosition.Set((double)fvector2D.X, (double)fvector2D.Y);
		if (!this.LastScreenPosition.Equals(this.ScreenPosition, 1.0))
		{
			this.LastScreenPosition.DeepCopy(this.ScreenPosition);
			BattleUiModel instance = BattleUiModel.Instance;
			this.ScreenPosition.MultiplyEqual((double)((instance != null) ? instance.ScreenPositionScale : 0f)).AdditionEqual(((instance != null) ? instance.ScreenPositionOffset : null) ?? null).MultiplyEqual(this.PointTransport);
			this.InRange = this.ClampToEllipse(this.ScreenPosition, flag);
			Vector2D vector2D = this.ScreenPosition.AdditionEqual(this.center);
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetAnchorOffset(vector2D.ToUeVector2D(false));
			}
			if (!this.InRange)
			{
				if (PanoramicController.Instance.CheckDisablePanoramic())
				{
					if (this.RootItem.bIsUIActive)
					{
						this.RootItem.SetUIActive(false);
					}
				}
				else if (!this.RootItem.bIsUIActive)
				{
					this.RootItem.SetUIActive(true);
				}
				this.TempRotator.Reset();
				this.TempRotator.Yaw = (float)Math.Atan2(this.ScreenPosition.Y, this.ScreenPosition.X) * 57.295776f;
				if (this.SprArrow != null)
				{
					UUIItem sprArrow = this.SprArrow;
					FRotator frotator = this.TempRotator.ToUeRotator();
					sprArrow.SetUIRelativeRotation(frotator);
					this.SprArrow.SetUIActive(true);
					return;
				}
			}
			else
			{
				if (!this.RootItem.bIsUIActive)
				{
					this.RootItem.SetUIActive(true);
				}
				UUIItem sprArrow2 = this.SprArrow;
				if (sprArrow2 == null)
				{
					return;
				}
				sprArrow2.SetUIActive(false);
			}
		}
	}

	// Token: 0x0600F068 RID: 61544 RVA: 0x0046A4EC File Offset: 0x004686EC
	[NullableContext(2)]
	public void SetTargetPos(Vector offset)
	{
		this.TargetPos.X = ((offset != null) ? offset.X : 0.0);
		this.TargetPos.Y = ((offset != null) ? offset.Y : 0.0);
		this.TargetPos.Z = ((offset != null) ? offset.Z : 0.0);
	}

	// Token: 0x0600F069 RID: 61545 RVA: 0x0046A558 File Offset: 0x00468758
	protected bool ClampToEllipse(Vector2D vector, bool inFront)
	{
		double x = vector.X;
		double y = vector.Y;
		float limitA = this.LimitA;
		float limitB = this.LimitB;
		if (inFront && x * x / (double)(limitA * limitA) + y * y / (double)(limitB * limitB) <= 1.0)
		{
			return true;
		}
		double inB = (double)(limitA * limitB) / Math.Sqrt((double)(limitB * limitB) * x * x + (double)(limitA * limitA) * y * y);
		vector.MultiplyEqual(inB);
		return false;
	}

	// Token: 0x0600F06A RID: 61546 RVA: 0x0046A5CC File Offset: 0x004687CC
	public void ChangePointType(EPanoramicType type)
	{
		if (this.ViewType == type)
		{
			if (!Info.Instance.IsInTouch())
			{
				if (this.ViewType == EPanoramicType.Active)
				{
					InputMultiKeyItem keyItem = this.KeyItem;
					if (keyItem == null || !keyItem.GetActive())
					{
						InputMultiKeyItem keyItem2 = this.KeyItem;
						if (keyItem2 == null)
						{
							return;
						}
						keyItem2.SetUiActive(true);
						return;
					}
				}
				else
				{
					InputMultiKeyItem keyItem3 = this.KeyItem;
					if (keyItem3 != null && keyItem3.GetActive())
					{
						InputMultiKeyItem keyItem4 = this.KeyItem;
						if (keyItem4 == null)
						{
							return;
						}
						keyItem4.SetUiActive(false);
					}
				}
			}
			return;
		}
		switch (type)
		{
		case EPanoramicType.Default:
			switch (this.ViewType)
			{
			case EPanoramicType.Active:
			{
				LevelSequencePlayer seqPlayer = this.SeqPlayer;
				if (seqPlayer != null)
				{
					seqPlayer.StopCurrentSequence(false, false);
				}
				LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
				if (seqPlayer2 != null)
				{
					seqPlayer2.PlayLevelSequenceByName("AtoB", false, null, false);
				}
				break;
			}
			case EPanoramicType.Ban:
			{
				LevelSequencePlayer seqPlayer3 = this.SeqPlayer;
				if (seqPlayer3 != null)
				{
					seqPlayer3.StopCurrentSequence(false, false);
				}
				LevelSequencePlayer seqPlayer4 = this.SeqPlayer;
				if (seqPlayer4 != null)
				{
					seqPlayer4.PlayLevelSequenceByName("DtoB", false, null, false);
				}
				break;
			}
			}
			break;
		case EPanoramicType.Active:
			switch (this.ViewType)
			{
			case EPanoramicType.Default:
			{
				LevelSequencePlayer seqPlayer5 = this.SeqPlayer;
				if (seqPlayer5 != null)
				{
					seqPlayer5.StopCurrentSequence(false, false);
				}
				LevelSequencePlayer seqPlayer6 = this.SeqPlayer;
				if (seqPlayer6 != null)
				{
					seqPlayer6.PlayLevelSequenceByName("BtoA", false, null, false);
				}
				break;
			}
			case EPanoramicType.Ban:
			{
				LevelSequencePlayer seqPlayer7 = this.SeqPlayer;
				if (seqPlayer7 != null)
				{
					seqPlayer7.StopCurrentSequence(false, false);
				}
				LevelSequencePlayer seqPlayer8 = this.SeqPlayer;
				if (seqPlayer8 != null)
				{
					seqPlayer8.PlayLevelSequenceByName("DtoA", false, null, false);
				}
				break;
			}
			}
			break;
		case EPanoramicType.Ban:
			switch (this.ViewType)
			{
			case EPanoramicType.Default:
			{
				LevelSequencePlayer seqPlayer9 = this.SeqPlayer;
				if (seqPlayer9 != null)
				{
					seqPlayer9.StopCurrentSequence(false, false);
				}
				LevelSequencePlayer seqPlayer10 = this.SeqPlayer;
				if (seqPlayer10 != null)
				{
					seqPlayer10.PlayLevelSequenceByName("BtoD", false, null, false);
				}
				break;
			}
			case EPanoramicType.Active:
			{
				LevelSequencePlayer seqPlayer11 = this.SeqPlayer;
				if (seqPlayer11 != null)
				{
					seqPlayer11.StopCurrentSequence(false, false);
				}
				LevelSequencePlayer seqPlayer12 = this.SeqPlayer;
				if (seqPlayer12 != null)
				{
					seqPlayer12.PlayLevelSequenceByName("AtoD", false, null, false);
				}
				break;
			}
			}
			break;
		}
		this.ViewType = type;
		if (!Info.Instance.IsInTouch())
		{
			if (this.ViewType == EPanoramicType.Active)
			{
				InputMultiKeyItem keyItem5 = this.KeyItem;
				if (keyItem5 == null)
				{
					return;
				}
				keyItem5.SetUiActive(true);
				return;
			}
			else
			{
				InputMultiKeyItem keyItem6 = this.KeyItem;
				if (keyItem6 == null)
				{
					return;
				}
				keyItem6.SetUiActive(false);
			}
		}
	}

	// Token: 0x040087CF RID: 34767
	private const float CENTER_Y = 62.5f;

	// Token: 0x040087D0 RID: 34768
	private Vector2D center = Vector2D.Create(0.0, 62.5);

	// Token: 0x040087D1 RID: 34769
	[Nullable(2)]
	private UUIItem SprArrow;

	// Token: 0x040087D2 RID: 34770
	[Nullable(2)]
	private InputMultiKeyItem KeyItem;

	// Token: 0x040087D3 RID: 34771
	protected readonly FVector2D ScreenPositionRef = new FVector2D();

	// Token: 0x040087D4 RID: 34772
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x040087D5 RID: 34773
	private readonly Vector TargetPos = Vector.Create();

	// Token: 0x040087D6 RID: 34774
	protected readonly Vector2D ScreenPosition = Vector2D.Create();

	// Token: 0x040087D7 RID: 34775
	private readonly Vector2D LastScreenPosition = Vector2D.Create();

	// Token: 0x040087D8 RID: 34776
	private readonly Rotator TempRotator = Rotator.Create();

	// Token: 0x040087D9 RID: 34777
	private float LimitA;

	// Token: 0x040087DA RID: 34778
	private float LimitB;

	// Token: 0x040087DB RID: 34779
	private bool InRange;

	// Token: 0x040087DC RID: 34780
	private readonly Vector2D PointTransport = Vector2D.Create(1.0, -1.0);

	// Token: 0x040087DD RID: 34781
	private EPanoramicType ViewType;

	// Token: 0x040087DE RID: 34782
	public int Id = -1;

	// Token: 0x02007A15 RID: 31253
	[NullableContext(0)]
	private class EPanoramicViewDefine
	{
		// Token: 0x04027940 RID: 162112
		public const int PanelOffset = 0;

		// Token: 0x04027941 RID: 162113
		public const int SprArrow = 1;

		// Token: 0x04027942 RID: 162114
		public const int KeyPanel = 2;
	}
}
