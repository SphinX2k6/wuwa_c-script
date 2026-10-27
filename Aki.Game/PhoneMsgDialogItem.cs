using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002520 RID: 9504
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhoneMsgDialogItem : SyncGridProxyAbstract<PhoneMsgDialogItemData>
{
	// Token: 0x060131D9 RID: 78297 RVA: 0x004BEE28 File Offset: 0x004BD028
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x060131DA RID: 78298 RVA: 0x004BEEFD File Offset: 0x004BD0FD
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.PhoneMsgDialogBgThemeCharmUpdate, new Action(this.OnRedDotUpdate));
	}

	// Token: 0x060131DB RID: 78299 RVA: 0x004BEF1B File Offset: 0x004BD11B
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.PhoneMsgDialogBgThemeCharmUpdate, new Action(this.OnRedDotUpdate));
	}

	// Token: 0x060131DC RID: 78300 RVA: 0x004BEF39 File Offset: 0x004BD139
	private void OnRedDotUpdate()
	{
		this.RefreshRedDot();
	}

	// Token: 0x060131DD RID: 78301 RVA: 0x004BEF41 File Offset: 0x004BD141
	public void RefreshRedDot()
	{
		UUIItem item = base.GetItem(6);
		PhoneMsgDialogItemData phoneMsgDialogData = this.PhoneMsgDialogData;
		item.SetUIActive(phoneMsgDialogData != null && phoneMsgDialogData.IsHasRedDot());
	}

	// Token: 0x060131DE RID: 78302 RVA: 0x004BEF61 File Offset: 0x004BD161
	public void HideRedDot()
	{
		base.GetItem(6).SetUIActive(false);
	}

	// Token: 0x060131DF RID: 78303 RVA: 0x004BEF70 File Offset: 0x004BD170
	[NullableContext(1)]
	public override void Refresh(PhoneMsgDialogItemData data)
	{
		if (data == null)
		{
			return;
		}
		this.PhoneMsgDialogData = data;
		ChatDialog? chatDialogConfig = PhoneMsgConfig.Instance.GetChatDialogConfig(data.DialogId);
		if (chatDialogConfig != null)
		{
			this.SetSpriteByPath(chatDialogConfig.Value.BgPath, base.GetSprite(1), false, null, null);
		}
		this.TryLoadDynamicDialogNode(chatDialogConfig.Value.SpineItemPath);
		base.GetText(4).SetColor(FColor.FromHex(chatDialogConfig.Value.TextColor));
		base.GetSprite(2).SetUIActive(data.IsUsing);
		base.GetItem(3).SetUIActive(!data.IsUnlocked);
		base.GetItem(6).SetUIActive(data.IsHasRedDot());
		this.SetToggleState(data.IsSelected, true);
	}

	// Token: 0x060131E0 RID: 78304 RVA: 0x004BF044 File Offset: 0x004BD244
	private void TryLoadDynamicDialogNode(string path)
	{
		PhoneMsgDialogItem.<>c__DisplayClass11_0 CS$<>8__locals1 = new PhoneMsgDialogItem.<>c__DisplayClass11_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.path = path;
		UiAsyncTask task = new UiAsyncTask("PhoneMsgDialogItem.TryLoadDynamicDialogNode", delegate()
		{
			PhoneMsgDialogItem.<>c__DisplayClass11_0.<<TryLoadDynamicDialogNode>b__0>d <<TryLoadDynamicDialogNode>b__0>d;
			<<TryLoadDynamicDialogNode>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<TryLoadDynamicDialogNode>b__0>d.<>4__this = CS$<>8__locals1;
			<<TryLoadDynamicDialogNode>b__0>d.<>1__state = -1;
			<<TryLoadDynamicDialogNode>b__0>d.<>t__builder.Start<PhoneMsgDialogItem.<>c__DisplayClass11_0.<<TryLoadDynamicDialogNode>b__0>d>(ref <<TryLoadDynamicDialogNode>b__0>d);
			return <<TryLoadDynamicDialogNode>b__0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task).Forget();
	}

	// Token: 0x060131E1 RID: 78305 RVA: 0x004BF08C File Offset: 0x004BD28C
	private UniTask TryLoadDynamicDialogNodeAsync(string path)
	{
		PhoneMsgDialogItem.<TryLoadDynamicDialogNodeAsync>d__12 <TryLoadDynamicDialogNodeAsync>d__;
		<TryLoadDynamicDialogNodeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TryLoadDynamicDialogNodeAsync>d__.<>4__this = this;
		<TryLoadDynamicDialogNodeAsync>d__.path = path;
		<TryLoadDynamicDialogNodeAsync>d__.<>1__state = -1;
		<TryLoadDynamicDialogNodeAsync>d__.<>t__builder.Start<PhoneMsgDialogItem.<TryLoadDynamicDialogNodeAsync>d__12>(ref <TryLoadDynamicDialogNodeAsync>d__);
		return <TryLoadDynamicDialogNodeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060131E2 RID: 78306 RVA: 0x004BF0D7 File Offset: 0x004BD2D7
	private void DestroyDynamicDialogActor()
	{
		if (this.DynamicDialogActor != null && this.DynamicDialogActor.IsValid())
		{
			ULGUIBPLibrary.DestroyActorWithHierarchy(this.DynamicDialogActor, true);
			this.DynamicDialogActor = null;
		}
	}

	// Token: 0x060131E3 RID: 78307 RVA: 0x004BF104 File Offset: 0x004BD304
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.OnToggleCallBack != null && this.PhoneMsgDialogData != null)
		{
			this.OnToggleCallBack(base.GridIndex, this.PhoneMsgDialogData);
		}
		PhoneMsgDialogItemData phoneMsgDialogData = this.PhoneMsgDialogData;
		if (phoneMsgDialogData != null && phoneMsgDialogData.IsHasRedDot())
		{
			PhoneMsgModel.Instance.RemoveChatShowRedDotById(this.PhoneMsgDialogData.DialogId);
			base.GetItem(6).SetUIActive(false);
		}
	}

	// Token: 0x060131E4 RID: 78308 RVA: 0x004BF170 File Offset: 0x004BD370
	public void SetToggleState(bool state, bool isFirstRefresh = false)
	{
		if (this.PhoneMsgDialogData == null)
		{
			return;
		}
		this.PhoneMsgDialogData.IsSelected = state;
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state2, false, isFirstRefresh, isFirstRefresh);
	}

	// Token: 0x04009051 RID: 36945
	private PhoneMsgDialogItemData PhoneMsgDialogData;

	// Token: 0x04009052 RID: 36946
	private AActor DynamicDialogActor;

	// Token: 0x04009053 RID: 36947
	private LevelSequencePlayer DialogSequencePlayer;

	// Token: 0x04009054 RID: 36948
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, PhoneMsgDialogItemData> OnToggleCallBack;
}
