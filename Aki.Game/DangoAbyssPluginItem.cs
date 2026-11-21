using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Dango;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F08 RID: 3848
[NullableContext(2)]
[Nullable(0)]
public class DangoAbyssPluginItem : UiPanelBase
{
	// Token: 0x06009A1B RID: 39451 RVA: 0x002DAF7B File Offset: 0x002D917B
	public DangoAbyssPluginItem(int index, bool isEquipView)
	{
		this.Index = index;
		this.IsEquipView = isEquipView;
	}

	// Token: 0x06009A1C RID: 39452 RVA: 0x002DAFA0 File Offset: 0x002D91A0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009A1D RID: 39453 RVA: 0x002DB0CA File Offset: 0x002D92CA
	protected override void OnStart()
	{
		this.Sequence = new LevelSequencePlayer(this.RootItem);
		base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnUndeterminedClicked));
	}

	// Token: 0x06009A1E RID: 39454 RVA: 0x002DB0FA File Offset: 0x002D92FA
	protected override void OnBeforeDestroy()
	{
		base.GetExtendToggle(0).OnUndeterminedClicked.Clear();
	}

	// Token: 0x06009A1F RID: 39455 RVA: 0x002DB10D File Offset: 0x002D930D
	public void Refresh(AbyssDangoRoleSlotData data)
	{
		if (data == null)
		{
			this.SetDangoLock();
			return;
		}
		this.RefreshEffect(this.CurrentData, data);
		this.CurrentData = data;
		this.RefreshState();
		this.RefreshTexture();
		this.RefreshSpriteBg(false);
	}

	// Token: 0x06009A20 RID: 39456 RVA: 0x002DB140 File Offset: 0x002D9340
	private void SetDangoLock()
	{
		int dangoId = this.ViewModel.GetDangoId();
		int slotUnlockLevel = DangoAbyssModel.Instance.GetSlotUnlockLevel(dangoId, this.Index);
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
		base.GetText(2).SetText(StringUtils.Format("Lv.{0}", new string[]
		{
			slotUnlockLevel.ToString()
		}), true);
		base.GetText(2).SetUIActive(true);
		base.GetTexture(1).SetUIActive(false);
		base.GetTexture(5).SetUIActive(false);
		base.GetSprite(3).SetUIActive(true);
		base.GetSprite(4).SetUIActive(false);
	}

	// Token: 0x06009A21 RID: 39457 RVA: 0x002DB1E4 File Offset: 0x002D93E4
	private void RefreshEffect(AbyssDangoRoleSlotData oldData, AbyssDangoRoleSlotData newData)
	{
		int dangoId = (newData != null) ? newData.GetDangoId() : 0;
		if (DangoAbyssModel.Instance.GetSlotLockState(dangoId, this.Index))
		{
			return;
		}
		switch (DangoAbyssModel.Instance.GetSlotSwitchTypeByData(oldData, newData))
		{
		case DangoAbyssDefine.ESlotSwitchType.TakeOff:
			this.PlaySequence("MoveAway");
			return;
		case DangoAbyssDefine.ESlotSwitchType.Replace:
			this.PlaySequence("Replace");
			return;
		case DangoAbyssDefine.ESlotSwitchType.PutOn:
			this.PlaySequence("DropIn");
			return;
		default:
			return;
		}
	}

	// Token: 0x06009A22 RID: 39458 RVA: 0x002DB25C File Offset: 0x002D945C
	[NullableContext(1)]
	public UniTask PlaySequence(string name)
	{
		DangoAbyssPluginItem.<PlaySequence>d__13 <PlaySequence>d__;
		<PlaySequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaySequence>d__.<>4__this = this;
		<PlaySequence>d__.name = name;
		<PlaySequence>d__.<>1__state = -1;
		<PlaySequence>d__.<>t__builder.Start<DangoAbyssPluginItem.<PlaySequence>d__13>(ref <PlaySequence>d__);
		return <PlaySequence>d__.<>t__builder.Task;
	}

	// Token: 0x06009A23 RID: 39459 RVA: 0x002DB2A8 File Offset: 0x002D94A8
	private void RefreshState()
	{
		int dangoId = this.CurrentData.GetDangoId();
		int slotUnlockLevel = DangoAbyssModel.Instance.GetSlotUnlockLevel(dangoId, this.Index);
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		int slotIndex = this.ViewModel.GetSlotIndex();
		bool slotLockState = DangoAbyssModel.Instance.GetSlotLockState(dangoId, this.Index);
		bool flag = slotIndex == this.Index;
		base.GetText(2).SetText(StringUtils.Format("Lv.{0}", new string[]
		{
			slotUnlockLevel.ToString()
		}), true);
		base.GetText(2).SetUIActive(slotLockState);
		if (flag && !slotLockState && this.IsEquipView)
		{
			extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			return;
		}
		if (!slotLockState)
		{
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
	}

	// Token: 0x06009A24 RID: 39460 RVA: 0x002DB36C File Offset: 0x002D956C
	private void RefreshTexture()
	{
		int equipId = this.CurrentData.GetEquipId();
		AbyssItem? dangoItemById = DangoAbyssConfig.Instance.GetDangoItemById(equipId);
		if (equipId <= 0 || dangoItemById == null || dangoItemById.Value.IconMiddle == "")
		{
			base.GetTexture(1).SetUIActive(false);
			base.GetTexture(5).SetUIActive(false);
			return;
		}
		string pluginItemQualityIcon = DangoAbyssModel.Instance.GetPluginItemQualityIcon(equipId);
		base.SetTextureByPath(dangoItemById.Value.IconMiddle, base.GetTexture(1), null, null);
		base.SetTextureByPath(pluginItemQualityIcon, base.GetTexture(5), null, null);
		base.GetTexture(1).SetUIActive(true);
		base.GetTexture(5).SetUIActive(true);
		DangoAbyssDefine.ESlotType slotTypeByIndex = DangoAbyssConfig.Instance.GetSlotTypeByIndex(this.Index);
		UUITexture texture = base.GetTexture(1);
		int num;
		DangoAbyssDefine.iconSizeBySlotType.TryGetValue(slotTypeByIndex, out num);
		texture.SetWidth((float)num);
		texture.SetHeight((float)num);
	}

	// Token: 0x06009A25 RID: 39461 RVA: 0x002DB474 File Offset: 0x002D9674
	private void RefreshSpriteBg(bool newState)
	{
		AbyssDangoRoleSlotData currentData = this.CurrentData;
		AbyssItem? dangoItemById = DangoAbyssConfig.Instance.GetDangoItemById(currentData.GetEquipId());
		bool flag = (currentData.GetEquipId() != 0 && dangoItemById != null && !(dangoItemById.Value.Icon == "")) || !newState;
		base.GetSprite(3).SetUIActive(flag);
		base.GetSprite(4).SetUIActive(!flag);
	}

	// Token: 0x06009A26 RID: 39462 RVA: 0x002DB4ED File Offset: 0x002D96ED
	private void OnToggleClick(EToggleState toggleState)
	{
		this.OnUndeterminedClicked();
	}

	// Token: 0x06009A27 RID: 39463 RVA: 0x002DB4F8 File Offset: 0x002D96F8
	private void OnUndeterminedClicked()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Activity;
		ELogAuthor author = ELogAuthor.WDX;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
		defaultInterpolatedStringHandler.AppendLiteral("OnToggleClick, ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.Index);
		instance.Info(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		int dangoId = this.ViewModel.GetDangoId();
		if (DangoAbyssModel.Instance.GetDangoIfLock(dangoId))
		{
			return;
		}
		if (DangoAbyssModel.Instance.GetSlotLockState(dangoId, this.Index))
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DangoAbyssLockSlotToLevelUp);
			confirmBoxDataNew.FunctionMap.Add(2, new Action(this.OnClickLevelUpConfirm));
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		this.ViewModel.SetSlotIndex(this.Index, false);
		if (!this.IsEquipView)
		{
			UiManager.Instance.OpenView(EUiViewName.DangoAbyssPluginEquipView, this.ViewModel, null);
		}
	}

	// Token: 0x06009A28 RID: 39464 RVA: 0x002DB5D8 File Offset: 0x002D97D8
	private void OnClickLevelUpConfirm()
	{
		int dangoId = this.ViewModel.GetDangoId();
		UiManager.Instance.OpenView(EUiViewName.DangoAbyssLevelUpView, dangoId, null);
	}

	// Token: 0x04005C15 RID: 23573
	private readonly int Index = -1;

	// Token: 0x04005C16 RID: 23574
	private readonly bool IsEquipView = true;

	// Token: 0x04005C17 RID: 23575
	private AbyssDangoRoleSlotData CurrentData;

	// Token: 0x04005C18 RID: 23576
	public PluginEquipViewModel ViewModel;

	// Token: 0x04005C19 RID: 23577
	public LevelSequencePlayer Sequence;

	// Token: 0x0200711E RID: 28958
	[NullableContext(0)]
	private class EPluginComponent
	{
		// Token: 0x04024D97 RID: 150935
		public const int Toggle = 0;

		// Token: 0x04024D98 RID: 150936
		public const int Texture = 1;

		// Token: 0x04024D99 RID: 150937
		public const int LevelText = 2;

		// Token: 0x04024D9A RID: 150938
		public const int SpriteBg = 3;

		// Token: 0x04024D9B RID: 150939
		public const int SpriteNew = 4;

		// Token: 0x04024D9C RID: 150940
		public const int TextureQuality = 5;
	}
}
