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

// Token: 0x02001A49 RID: 6729
[NullableContext(2)]
[Nullable(0)]
public class DangoAbyssPluginItem : UiPanelBase
{
	// Token: 0x0600C60B RID: 50699 RVA: 0x002CFE7F File Offset: 0x002CE07F
	public DangoAbyssPluginItem(int index, bool isEquipView)
	{
		this.Index = index;
		this.IsEquipView = isEquipView;
	}

	// Token: 0x0600C60C RID: 50700 RVA: 0x002CFEA4 File Offset: 0x002CE0A4
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

	// Token: 0x0600C60D RID: 50701 RVA: 0x002CFFCE File Offset: 0x002CE1CE
	protected override void OnStart()
	{
		this.Sequence = new LevelSequencePlayer(this.RootItem);
		base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnUndeterminedClicked));
	}

	// Token: 0x0600C60E RID: 50702 RVA: 0x002CFFFE File Offset: 0x002CE1FE
	protected override void OnBeforeDestroy()
	{
		base.GetExtendToggle(0).OnUndeterminedClicked.Clear();
	}

	// Token: 0x0600C60F RID: 50703 RVA: 0x002D0011 File Offset: 0x002CE211
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

	// Token: 0x0600C610 RID: 50704 RVA: 0x002D0044 File Offset: 0x002CE244
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

	// Token: 0x0600C611 RID: 50705 RVA: 0x002D00E8 File Offset: 0x002CE2E8
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

	// Token: 0x0600C612 RID: 50706 RVA: 0x002D0160 File Offset: 0x002CE360
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

	// Token: 0x0600C613 RID: 50707 RVA: 0x002D01AC File Offset: 0x002CE3AC
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

	// Token: 0x0600C614 RID: 50708 RVA: 0x002D0270 File Offset: 0x002CE470
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

	// Token: 0x0600C615 RID: 50709 RVA: 0x002D0378 File Offset: 0x002CE578
	private void RefreshSpriteBg(bool newState)
	{
		AbyssDangoRoleSlotData currentData = this.CurrentData;
		AbyssItem? dangoItemById = DangoAbyssConfig.Instance.GetDangoItemById(currentData.GetEquipId());
		bool flag = (currentData.GetEquipId() != 0 && dangoItemById != null && !(dangoItemById.Value.Icon == "")) || !newState;
		base.GetSprite(3).SetUIActive(flag);
		base.GetSprite(4).SetUIActive(!flag);
	}

	// Token: 0x0600C616 RID: 50710 RVA: 0x002D03F1 File Offset: 0x002CE5F1
	private void OnToggleClick(EToggleState toggleState)
	{
		this.OnUndeterminedClicked();
	}

	// Token: 0x0600C617 RID: 50711 RVA: 0x002D03FC File Offset: 0x002CE5FC
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

	// Token: 0x0600C618 RID: 50712 RVA: 0x002D04DC File Offset: 0x002CE6DC
	private void OnClickLevelUpConfirm()
	{
		int dangoId = this.ViewModel.GetDangoId();
		UiManager.Instance.OpenView(EUiViewName.DangoAbyssLevelUpView, dangoId, null);
	}

	// Token: 0x04005B46 RID: 23366
	private readonly int Index = -1;

	// Token: 0x04005B47 RID: 23367
	private readonly bool IsEquipView = true;

	// Token: 0x04005B48 RID: 23368
	private AbyssDangoRoleSlotData CurrentData;

	// Token: 0x04005B49 RID: 23369
	public PluginEquipViewModel ViewModel;

	// Token: 0x04005B4A RID: 23370
	public LevelSequencePlayer Sequence;

	// Token: 0x02007F8F RID: 32655
	[NullableContext(0)]
	private class EPluginComponent
	{
		// Token: 0x04029A5A RID: 170586
		public const int Toggle = 0;

		// Token: 0x04029A5B RID: 170587
		public const int Texture = 1;

		// Token: 0x04029A5C RID: 170588
		public const int LevelText = 2;

		// Token: 0x04029A5D RID: 170589
		public const int SpriteBg = 3;

		// Token: 0x04029A5E RID: 170590
		public const int SpriteNew = 4;

		// Token: 0x04029A5F RID: 170591
		public const int TextureQuality = 5;
	}
}
