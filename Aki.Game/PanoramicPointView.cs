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

// Token: 0x02002311 RID: 8977
[NullableContext(1)]
[Nullable(0)]
public class PanoramicPointView : UiPanelBase
{
	// Token: 0x06011BC5 RID: 72645 RVA: 0x0045D380 File Offset: 0x0045B580
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

	// Token: 0x06011BC6 RID: 72646 RVA: 0x0045D410 File Offset: 0x0045B610
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

	// Token: 0x06011BC7 RID: 72647 RVA: 0x0045D564 File Offset: 0x0045B764
	protected override UniTask OnBeforeStartAsync()
	{
		PanoramicPointView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PanoramicPointView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011BC8 RID: 72648 RVA: 0x0045D5A7 File Offset: 0x0045B7A7
	protected override void OnAfterShow()
	{
	}

	// Token: 0x06011BC9 RID: 72649 RVA: 0x0045D5A9 File Offset: 0x0045B7A9
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

	// Token: 0x06011BCA RID: 72650 RVA: 0x0045D5C8 File Offset: 0x0045B7C8
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

	// Token: 0x06011BCB RID: 72651 RVA: 0x0045D810 File Offset: 0x0045BA10
	[NullableContext(2)]
	public void SetTargetPos(Vector offset)
	{
		this.TargetPos.X = ((offset != null) ? offset.X : 0.0);
		this.TargetPos.Y = ((offset != null) ? offset.Y : 0.0);
		this.TargetPos.Z = ((offset != null) ? offset.Z : 0.0);
	}

	// Token: 0x06011BCC RID: 72652 RVA: 0x0045D87C File Offset: 0x0045BA7C
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

	// Token: 0x06011BCD RID: 72653 RVA: 0x0045D8F0 File Offset: 0x0045BAF0
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

	// Token: 0x0400868F RID: 34447
	private const float CENTER_Y = 62.5f;

	// Token: 0x04008690 RID: 34448
	private Vector2D center = Vector2D.Create(0.0, 62.5);

	// Token: 0x04008691 RID: 34449
	[Nullable(2)]
	private UUIItem SprArrow;

	// Token: 0x04008692 RID: 34450
	[Nullable(2)]
	private InputMultiKeyItem KeyItem;

	// Token: 0x04008693 RID: 34451
	protected readonly FVector2D ScreenPositionRef = new FVector2D();

	// Token: 0x04008694 RID: 34452
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04008695 RID: 34453
	private readonly Vector TargetPos = Vector.Create();

	// Token: 0x04008696 RID: 34454
	protected readonly Vector2D ScreenPosition = Vector2D.Create();

	// Token: 0x04008697 RID: 34455
	private readonly Vector2D LastScreenPosition = Vector2D.Create();

	// Token: 0x04008698 RID: 34456
	private readonly Rotator TempRotator = Rotator.Create();

	// Token: 0x04008699 RID: 34457
	private float LimitA;

	// Token: 0x0400869A RID: 34458
	private float LimitB;

	// Token: 0x0400869B RID: 34459
	private bool InRange;

	// Token: 0x0400869C RID: 34460
	private readonly Vector2D PointTransport = Vector2D.Create(1.0, -1.0);

	// Token: 0x0400869D RID: 34461
	private EPanoramicType ViewType;

	// Token: 0x0400869E RID: 34462
	public int Id = -1;

	// Token: 0x0200888F RID: 34959
	[NullableContext(0)]
	private class EPanoramicViewDefine
	{
		// Token: 0x0402C632 RID: 181810
		public const int PanelOffset = 0;

		// Token: 0x0402C633 RID: 181811
		public const int SprArrow = 1;

		// Token: 0x0402C634 RID: 181812
		public const int KeyPanel = 2;
	}
}
