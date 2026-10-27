using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200123B RID: 4667
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyGridInfoPanel : UiPanelBase
{
	// Token: 0x06007E2D RID: 32301 RVA: 0x001AB2F0 File Offset: 0x001A94F0
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

	// Token: 0x06007E2E RID: 32302 RVA: 0x001AB343 File Offset: 0x001A9543
	public void UpdateGridData(DangoMonopolyGridData gridData)
	{
		this.GridData = gridData;
		this.UpdateData();
		this.CheckCompletedStateToEnd();
	}

	// Token: 0x06007E2F RID: 32303 RVA: 0x001AB358 File Offset: 0x001A9558
	protected override void OnBeforeCreate()
	{
	}

	// Token: 0x06007E30 RID: 32304 RVA: 0x001AB35C File Offset: 0x001A955C
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

	// Token: 0x06007E31 RID: 32305 RVA: 0x001AB424 File Offset: 0x001A9624
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyGridInfoPanel.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyGridInfoPanel.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007E32 RID: 32306 RVA: 0x001AB467 File Offset: 0x001A9667
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

	// Token: 0x06007E33 RID: 32307 RVA: 0x001AB495 File Offset: 0x001A9695
	protected override void OnBeforeShow()
	{
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.TimerUpdate), 20f, 1f, null, null, true);
	}

	// Token: 0x06007E34 RID: 32308 RVA: 0x001AB4C0 File Offset: 0x001A96C0
	protected override void OnBeforeHide()
	{
		this.ClearTimerHandle();
	}

	// Token: 0x06007E35 RID: 32309 RVA: 0x001AB4C8 File Offset: 0x001A96C8
	protected override void OnBeforeDestroy()
	{
		this.ClearTimerHandle();
	}

	// Token: 0x06007E36 RID: 32310 RVA: 0x001AB4D0 File Offset: 0x001A96D0
	public void ClearTimerHandle()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x06007E37 RID: 32311 RVA: 0x001AB4F4 File Offset: 0x001A96F4
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

	// Token: 0x06007E38 RID: 32312 RVA: 0x001AB52C File Offset: 0x001A972C
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

	// Token: 0x06007E39 RID: 32313 RVA: 0x001AB57C File Offset: 0x001A977C
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

	// Token: 0x06007E3A RID: 32314 RVA: 0x001AB666 File Offset: 0x001A9866
	public void UpdateDangoInfo()
	{
		this.SetActive(false);
	}

	// Token: 0x06007E3B RID: 32315 RVA: 0x001AB66F File Offset: 0x001A986F
	public void UpdateEmptyInfo()
	{
		this.SetActive(false);
	}

	// Token: 0x06007E3C RID: 32316 RVA: 0x001AB678 File Offset: 0x001A9878
	public UniTask EnterStartGridUpdate()
	{
		DangoMonopolyGridInfoPanel.<EnterStartGridUpdate>d__22 <EnterStartGridUpdate>d__;
		<EnterStartGridUpdate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<EnterStartGridUpdate>d__.<>4__this = this;
		<EnterStartGridUpdate>d__.<>1__state = -1;
		<EnterStartGridUpdate>d__.<>t__builder.Start<DangoMonopolyGridInfoPanel.<EnterStartGridUpdate>d__22>(ref <EnterStartGridUpdate>d__);
		return <EnterStartGridUpdate>d__.<>t__builder.Task;
	}

	// Token: 0x06007E3D RID: 32317 RVA: 0x001AB6BC File Offset: 0x001A98BC
	public UniTask EnterEndGirdUpdate()
	{
		DangoMonopolyGridInfoPanel.<EnterEndGirdUpdate>d__23 <EnterEndGirdUpdate>d__;
		<EnterEndGirdUpdate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<EnterEndGirdUpdate>d__.<>4__this = this;
		<EnterEndGirdUpdate>d__.<>1__state = -1;
		<EnterEndGirdUpdate>d__.<>t__builder.Start<DangoMonopolyGridInfoPanel.<EnterEndGirdUpdate>d__23>(ref <EnterEndGirdUpdate>d__);
		return <EnterEndGirdUpdate>d__.<>t__builder.Task;
	}

	// Token: 0x06007E3E RID: 32318 RVA: 0x001AB700 File Offset: 0x001A9900
	public UniTask OutBeforeGridUpdate()
	{
		DangoMonopolyGridInfoPanel.<OutBeforeGridUpdate>d__24 <OutBeforeGridUpdate>d__;
		<OutBeforeGridUpdate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OutBeforeGridUpdate>d__.<>4__this = this;
		<OutBeforeGridUpdate>d__.<>1__state = -1;
		<OutBeforeGridUpdate>d__.<>t__builder.Start<DangoMonopolyGridInfoPanel.<OutBeforeGridUpdate>d__24>(ref <OutBeforeGridUpdate>d__);
		return <OutBeforeGridUpdate>d__.<>t__builder.Task;
	}

	// Token: 0x06007E3F RID: 32319 RVA: 0x001AB744 File Offset: 0x001A9944
	public UniTask OutStartGridUpdate()
	{
		DangoMonopolyGridInfoPanel.<OutStartGridUpdate>d__25 <OutStartGridUpdate>d__;
		<OutStartGridUpdate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OutStartGridUpdate>d__.<>4__this = this;
		<OutStartGridUpdate>d__.<>1__state = -1;
		<OutStartGridUpdate>d__.<>t__builder.Start<DangoMonopolyGridInfoPanel.<OutStartGridUpdate>d__25>(ref <OutStartGridUpdate>d__);
		return <OutStartGridUpdate>d__.<>t__builder.Task;
	}

	// Token: 0x06007E40 RID: 32320 RVA: 0x001AB788 File Offset: 0x001A9988
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

	// Token: 0x06007E41 RID: 32321 RVA: 0x001AB7D4 File Offset: 0x001A99D4
	public UniTask PlayActiveSequence()
	{
		DangoMonopolyGridInfoPanel.<PlayActiveSequence>d__27 <PlayActiveSequence>d__;
		<PlayActiveSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayActiveSequence>d__.<>4__this = this;
		<PlayActiveSequence>d__.<>1__state = -1;
		<PlayActiveSequence>d__.<>t__builder.Start<DangoMonopolyGridInfoPanel.<PlayActiveSequence>d__27>(ref <PlayActiveSequence>d__);
		return <PlayActiveSequence>d__.<>t__builder.Task;
	}

	// Token: 0x06007E42 RID: 32322 RVA: 0x001AB818 File Offset: 0x001A9A18
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

	// Token: 0x06007E43 RID: 32323 RVA: 0x001AB8CC File Offset: 0x001A9ACC
	public void UpdateCameraFace()
	{
		Rotator cameraRotator = CameraController.Instance.MainModel.CameraRotator;
		if (cameraRotator != null)
		{
			this.UpdateRotation(cameraRotator.Yaw, cameraRotator.Pitch);
		}
	}

	// Token: 0x06007E44 RID: 32324 RVA: 0x001AB8FE File Offset: 0x001A9AFE
	public void TimerUpdate(float _)
	{
		this.UpdateCameraFace();
	}

	// Token: 0x06007E45 RID: 32325 RVA: 0x001AB908 File Offset: 0x001A9B08
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

	// Token: 0x06007E46 RID: 32326 RVA: 0x001AB988 File Offset: 0x001A9B88
	public FVector2D GetCursorPosition()
	{
		UUIItem item = base.GetItem(7);
		return UiModelUtil.Instance.GetActorLguiPos(item.GetOwner(), null);
	}

	// Token: 0x0400398B RID: 14731
	public DangoMonopolyGridData GridData;

	// Token: 0x0400398C RID: 14732
	[Nullable(2)]
	public CustomPromise<bool> Promise;

	// Token: 0x0400398D RID: 14733
	protected FRotator? RootActorRotation;

	// Token: 0x0400398E RID: 14734
	[Nullable(2)]
	public TimerHandle TimerHandle;

	// Token: 0x0400398F RID: 14735
	[Nullable(2)]
	public LevelSequencePlayer Sequence;

	// Token: 0x04003990 RID: 14736
	public ActivityDangoMonopolyData ActivityData;

	// Token: 0x02007823 RID: 30755
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402797C RID: 162172
		ItemTag,
		// Token: 0x0402797D RID: 162173
		TxtTitle,
		// Token: 0x0402797E RID: 162174
		ItemCompleted,
		// Token: 0x0402797F RID: 162175
		TextureIcon,
		// Token: 0x04027980 RID: 162176
		ItemEffectNormal,
		// Token: 0x04027981 RID: 162177
		ItemEffectDouble,
		// Token: 0x04027982 RID: 162178
		TxtTag,
		// Token: 0x04027983 RID: 162179
		ItemCursor
	}
}
