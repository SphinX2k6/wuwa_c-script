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

// Token: 0x02001A07 RID: 6663
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhoneMsgDialogItem : SyncGridProxyAbstract<PhoneMsgDialogItemData>
{
	// Token: 0x06010699 RID: 67225 RVA: 0x004CCB34 File Offset: 0x004CAD34
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

	// Token: 0x0601069A RID: 67226 RVA: 0x004CCC09 File Offset: 0x004CAE09
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.PhoneMsgDialogBgThemeCharmUpdate, new Action(this.OnRedDotUpdate));
	}

	// Token: 0x0601069B RID: 67227 RVA: 0x004CCC27 File Offset: 0x004CAE27
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.PhoneMsgDialogBgThemeCharmUpdate, new Action(this.OnRedDotUpdate));
	}

	// Token: 0x0601069C RID: 67228 RVA: 0x004CCC45 File Offset: 0x004CAE45
	private void OnRedDotUpdate()
	{
		this.RefreshRedDot();
	}

	// Token: 0x0601069D RID: 67229 RVA: 0x004CCC4D File Offset: 0x004CAE4D
	public void RefreshRedDot()
	{
		UUIItem item = base.GetItem(6);
		PhoneMsgDialogItemData phoneMsgDialogData = this.PhoneMsgDialogData;
		item.SetUIActive(phoneMsgDialogData != null && phoneMsgDialogData.IsHasRedDot());
	}

	// Token: 0x0601069E RID: 67230 RVA: 0x004CCC6D File Offset: 0x004CAE6D
	public void HideRedDot()
	{
		base.GetItem(6).SetUIActive(false);
	}

	// Token: 0x0601069F RID: 67231 RVA: 0x004CCC7C File Offset: 0x004CAE7C
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

	// Token: 0x060106A0 RID: 67232 RVA: 0x004CCD50 File Offset: 0x004CAF50
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

	// Token: 0x060106A1 RID: 67233 RVA: 0x004CCD98 File Offset: 0x004CAF98
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

	// Token: 0x060106A2 RID: 67234 RVA: 0x004CCDE3 File Offset: 0x004CAFE3
	private void DestroyDynamicDialogActor()
	{
		if (this.DynamicDialogActor != null && this.DynamicDialogActor.IsValid())
		{
			ULGUIBPLibrary.DestroyActorWithHierarchy(this.DynamicDialogActor, true);
			this.DynamicDialogActor = null;
		}
	}

	// Token: 0x060106A3 RID: 67235 RVA: 0x004CCE10 File Offset: 0x004CB010
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

	// Token: 0x060106A4 RID: 67236 RVA: 0x004CCE7C File Offset: 0x004CB07C
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

	// Token: 0x040091A6 RID: 37286
	private PhoneMsgDialogItemData PhoneMsgDialogData;

	// Token: 0x040091A7 RID: 37287
	private AActor DynamicDialogActor;

	// Token: 0x040091A8 RID: 37288
	private LevelSequencePlayer DialogSequencePlayer;

	// Token: 0x040091A9 RID: 37289
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, PhoneMsgDialogItemData> OnToggleCallBack;
}
