using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020006EF RID: 1775
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyGridInfoPanel : UiPanelBase
{
	// Token: 0x060051C4 RID: 20932 RVA: 0x001B3FB0 File Offset: 0x001B21B0
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<DangoMonopolyGridInfoPanel> Init(DangoMonopolyGridData gridData, ActivityDangoMonopolyData data)
	{
		DangoMonopolyGridInfoPanel.<Init>d__7 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder<DangoMonopolyGridInfoPanel>.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.gridData = gridData;
		<Init>d__.data = data;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<DangoMonopolyGridInfoPanel.<Init>d__7>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x060051C5 RID: 20933 RVA: 0x001B4003 File Offset: 0x001B2203
	public void UpdateGridData(DangoMonopolyGridData gridData)
	{
		this.GridData = gridData;
		this.UpdateData();
		this.CheckCompletedStateToEnd();
	}

	// Token: 0x060051C6 RID: 20934 RVA: 0x001B4018 File Offset: 0x001B2218
	protected override void OnBeforeCreate()
	{
	}

	// Token: 0x060051C7 RID: 20935 RVA: 0x001B401C File Offset: 0x001B221C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
	}

	// Token: 0x060051C8 RID: 20936 RVA: 0x001B40E4 File Offset: 0x001B22E4
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyGridInfoPanel.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyGridInfoPanel.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060051C9 RID: 20937 RVA: 0x001B4127 File Offset: 0x001B2327
	protected override void OnStart()
	{
		this.RootActorRotation = new FRotator?(this.RootActor.K2_GetActorRotation());
		UUIText text = base.GetText(6);
		if (text == null)
		{
			return;
		}
		text.ShowTextNew("DangoMonopoly_title_19");
	}

	// Token: 0x060051CA RID: 20938 RVA: 0x001B4155 File Offset: 0x001B2355
	protected override void OnBeforeShow()
	{
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.TimerUpdate), 20f, 1f, null, null, true);
	}

	// Token: 0x060051CB RID: 20939 RVA: 0x001B4180 File Offset: 0x001B2380
	protected override void OnBeforeHide()
	{
		this.ClearTimerHandle();
	}

	// Token: 0x060051CC RID: 20940 RVA: 0x001B4188 File Offset: 0x001B2388
	protected override void OnBeforeDestroy()
	{
		this.ClearTimerHandle();
	}

	// Token: 0x060051CD RID: 20941 RVA: 0x001B4190 File Offset: 0x001B2390
	public void ClearTimerHandle()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x060051CE RID: 20942 RVA: 0x001B41B4 File Offset: 0x001B23B4
	public void UpdateData()
	{
		DangoMonopolyGridData gridData = this.GridData;
		if (gridData.IsExistItem())
		{
			this.UpdateItemInfo();
			return;
		}
		if (gridData.IsExistDango())
		{
			this.UpdateDangoInfo();
			return;
		}
		this.UpdateEmptyInfo();
	}

	// Token: 0x060051CF RID: 20943 RVA: 0x001B41EC File Offset: 0x001B23EC
	public void CheckCompletedStateToEnd()
	{
		if (this.GridData.IsFinish())
		{
			LevelSequencePlayer sequence = this.Sequence;
			if (sequence != null)
			{
				sequence.PlayLevelSequenceByName("Done", false, null, false);
			}
			LevelSequencePlayer sequence2 = this.Sequence;
			if (sequence2 == null)
			{
				return;
			}
			sequence2.EndSequenceLastFrame("Done");
		}
	}

	// Token: 0x060051D0 RID: 20944 RVA: 0x001B423C File Offset: 0x001B243C
	public void UpdateItemInfo()
	{
		DangoMonopolyGridData gridData = this.GridData;
		bool flag = gridData.IsActiveDouble();
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIItem item2 = base.GetItem(5);
		if (item2 != null)
		{
			item2.SetUIActive(flag);
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("X");
		defaultInterpolatedStringHandler.AppendFormatted<int>(flag ? (gridData.ItemCount * 2) : gridData.ItemCount);
		string newText = defaultInterpolatedStringHandler.ToStringAndClear();
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.SetText(newText, true);
		}
		bool uiactive = gridData.IsFinish();
		UUIItem item3 = base.GetItem(2);
		if (item3 != null)
		{
			item3.SetUIActive(uiactive);
		}
		int itemId = gridData.ItemId;
		InventoryConfig instance = InventoryConfig.Instance;
		ItemConfig itemConfig = (instance != null) ? instance.GetItemConfigData(itemId) : null;
		if (itemConfig != null)
		{
			string icon = itemConfig.Icon;
			base.SetTextureByPath(icon, base.GetTexture(3), null, null);
		}
	}

	// Token: 0x060051D1 RID: 20945 RVA: 0x001B4326 File Offset: 0x001B2526
	public void UpdateDangoInfo()
	{
		this.SetActive(false);
	}

	// Token: 0x060051D2 RID: 20946 RVA: 0x001B432F File Offset: 0x001B252F
	public void UpdateEmptyInfo()
	{
		this.SetActive(false);
	}

	// Token: 0x060051D3 RID: 20947 RVA: 0x001B4338 File Offset: 0x001B2538
	public UniTask EnterStartGridUpdate()
	{
		DangoMonopolyGridInfoPanel.<EnterStartGridUpdate>d__22 <EnterStartGridUpdate>d__;
		<EnterStartGridUpdate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<EnterStartGridUpdate>d__.<>4__this = this;
		<EnterStartGridUpdate>d__.<>1__state = -1;
		<EnterStartGridUpdate>d__.<>t__builder.Start<DangoMonopolyGridInfoPanel.<EnterStartGridUpdate>d__22>(ref <EnterStartGridUpdate>d__);
		return <EnterStartGridUpdate>d__.<>t__builder.Task;
	}

	// Token: 0x060051D4 RID: 20948 RVA: 0x001B437C File Offset: 0x001B257C
	public UniTask EnterEndGirdUpdate()
	{
		DangoMonopolyGridInfoPanel.<EnterEndGirdUpdate>d__23 <EnterEndGirdUpdate>d__;
		<EnterEndGirdUpdate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<EnterEndGirdUpdate>d__.<>4__this = this;
		<EnterEndGirdUpdate>d__.<>1__state = -1;
		<EnterEndGirdUpdate>d__.<>t__builder.Start<DangoMonopolyGridInfoPanel.<EnterEndGirdUpdate>d__23>(ref <EnterEndGirdUpdate>d__);
		return <EnterEndGirdUpdate>d__.<>t__builder.Task;
	}

	// Token: 0x060051D5 RID: 20949 RVA: 0x001B43C0 File Offset: 0x001B25C0
	public UniTask OutBeforeGridUpdate()
	{
		DangoMonopolyGridInfoPanel.<OutBeforeGridUpdate>d__24 <OutBeforeGridUpdate>d__;
		<OutBeforeGridUpdate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OutBeforeGridUpdate>d__.<>4__this = this;
		<OutBeforeGridUpdate>d__.<>1__state = -1;
		<OutBeforeGridUpdate>d__.<>t__builder.Start<DangoMonopolyGridInfoPanel.<OutBeforeGridUpdate>d__24>(ref <OutBeforeGridUpdate>d__);
		return <OutBeforeGridUpdate>d__.<>t__builder.Task;
	}

	// Token: 0x060051D6 RID: 20950 RVA: 0x001B4404 File Offset: 0x001B2604
	public UniTask OutStartGridUpdate()
	{
		DangoMonopolyGridInfoPanel.<OutStartGridUpdate>d__25 <OutStartGridUpdate>d__;
		<OutStartGridUpdate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OutStartGridUpdate>d__.<>4__this = this;
		<OutStartGridUpdate>d__.<>1__state = -1;
		<OutStartGridUpdate>d__.<>t__builder.Start<DangoMonopolyGridInfoPanel.<OutStartGridUpdate>d__25>(ref <OutStartGridUpdate>d__);
		return <OutStartGridUpdate>d__.<>t__builder.Task;
	}

	// Token: 0x060051D7 RID: 20951 RVA: 0x001B4448 File Offset: 0x001B2648
	public UniTask PlaySequence(string name)
	{
		DangoMonopolyGridInfoPanel.<PlaySequence>d__26 <PlaySequence>d__;
		<PlaySequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaySequence>d__.<>4__this = this;
		<PlaySequence>d__.name = name;
		<PlaySequence>d__.<>1__state = -1;
		<PlaySequence>d__.<>t__builder.Start<DangoMonopolyGridInfoPanel.<PlaySequence>d__26>(ref <PlaySequence>d__);
		return <PlaySequence>d__.<>t__builder.Task;
	}

	// Token: 0x060051D8 RID: 20952 RVA: 0x001B4494 File Offset: 0x001B2694
	public UniTask PlayActiveSequence()
	{
		DangoMonopolyGridInfoPanel.<PlayActiveSequence>d__27 <PlayActiveSequence>d__;
		<PlayActiveSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayActiveSequence>d__.<>4__this = this;
		<PlayActiveSequence>d__.<>1__state = -1;
		<PlayActiveSequence>d__.<>t__builder.Start<DangoMonopolyGridInfoPanel.<PlayActiveSequence>d__27>(ref <PlayActiveSequence>d__);
		return <PlayActiveSequence>d__.<>t__builder.Task;
	}

	// Token: 0x060051D9 RID: 20953 RVA: 0x001B44D8 File Offset: 0x001B26D8
	public void UpdateRotation(float yaw, float pitch)
	{
		if (this.RootActorRotation == null)
		{
			return;
		}
		float num = pitch - 90f;
		float num2 = yaw + 90f;
		double value = 0.001;
		bool flag = MathUtils.Instance.IsNearlyEqual((double)this.RootActorRotation.Value.Roll, (double)num, new double?(value));
		bool flag2 = MathUtils.Instance.IsNearlyEqual((double)this.RootActorRotation.Value.Yaw, (double)num2, new double?(value));
		if (flag && flag2)
		{
			return;
		}
		this.RootActorRotation = new FRotator?(new FRotator(0f, num2, num));
		UUIItem rootItem = this.RootItem;
		FRotator value2 = this.RootActorRotation.Value;
		rootItem.SetUIWorldRotation(value2);
	}

	// Token: 0x060051DA RID: 20954 RVA: 0x001B458C File Offset: 0x001B278C
	public void UpdateCameraFace()
	{
		Rotator cameraRotator = CameraController.Instance.MainModel.CameraRotator;
		if (cameraRotator != null)
		{
			this.UpdateRotation(cameraRotator.Yaw, cameraRotator.Pitch);
		}
	}

	// Token: 0x060051DB RID: 20955 RVA: 0x001B45BE File Offset: 0x001B27BE
	public void TimerUpdate(float _)
	{
		this.UpdateCameraFace();
	}

	// Token: 0x060051DC RID: 20956 RVA: 0x001B45C8 File Offset: 0x001B27C8
	public void UpdateHeight()
	{
		int id = this.GridData.Id;
		IChessboardPointParams chessboardPointParams;
		if (!this.ActivityData.ChessPointParamsMap.TryGetValue(id, out chessboardPointParams))
		{
			return;
		}
		FVectorDouble newLocation = Vector.Create(chessboardPointParams.Location.X, chessboardPointParams.Location.Y, (double)this.ActivityData.GetGridEntityInfoAddHeight(id, (float)chessboardPointParams.Location.Z)).ToUeVector(false);
		FHitResult fhitResult = new FHitResult();
		base.GetRootItem().D_K2_SetWorldLocation(newLocation, true, ref fhitResult, false);
	}

	// Token: 0x060051DD RID: 20957 RVA: 0x001B4648 File Offset: 0x001B2848
	public FVector2D GetCursorPosition()
	{
		UUIItem item = base.GetItem(7);
		return UiModelUtil.Instance.GetActorLguiPos(item.GetOwner(), null);
	}

	// Token: 0x04003A23 RID: 14883
	public DangoMonopolyGridData GridData;

	// Token: 0x04003A24 RID: 14884
	[Nullable(2)]
	public CustomPromise<bool> Promise;

	// Token: 0x04003A25 RID: 14885
	protected FRotator? RootActorRotation;

	// Token: 0x04003A26 RID: 14886
	[Nullable(2)]
	public TimerHandle TimerHandle;

	// Token: 0x04003A27 RID: 14887
	[Nullable(2)]
	public LevelSequencePlayer Sequence;

	// Token: 0x04003A28 RID: 14888
	public ActivityDangoMonopolyData ActivityData;

	// Token: 0x020069AE RID: 27054
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04022CAD RID: 142509
		ItemTag,
		// Token: 0x04022CAE RID: 142510
		TxtTitle,
		// Token: 0x04022CAF RID: 142511
		ItemCompleted,
		// Token: 0x04022CB0 RID: 142512
		TextureIcon,
		// Token: 0x04022CB1 RID: 142513
		ItemEffectNormal,
		// Token: 0x04022CB2 RID: 142514
		ItemEffectDouble,
		// Token: 0x04022CB3 RID: 142515
		TxtTag,
		// Token: 0x04022CB4 RID: 142516
		ItemCursor
	}
}
