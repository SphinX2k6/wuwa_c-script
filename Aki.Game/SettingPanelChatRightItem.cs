using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200251D RID: 9501
[NullableContext(2)]
[Nullable(0)]
public class SettingPanelChatRightItem : UiPanelBase
{
	// Token: 0x060131CB RID: 78283 RVA: 0x004BE8DC File Offset: 0x004BCADC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUITexture)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUITexture)),
			new ValueTuple<int, Type>(10, typeof(UUISprite)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(21, typeof(UUIItem))
		};
	}

	// Token: 0x060131CC RID: 78284 RVA: 0x004BEA16 File Offset: 0x004BCC16
	public void InitView()
	{
		this.RefreshSpeakerInfo();
	}

	// Token: 0x060131CD RID: 78285 RVA: 0x004BEA20 File Offset: 0x004BCC20
	private void RefreshSpeakerInfo()
	{
		int value = RoleModel.Instance.GetCurSelectMainRoleId().Value;
		int roleSkinIdByRoleId = RoleSkinModel.Instance.GetRoleSkinIdByRoleId(value);
		string roleHeadIconCircle = SkinConfig.Instance.GetRoleSkinConfig(roleSkinIdByRoleId).Value.RoleHeadIconCircle;
		string newText = FunctionModel.Instance.GetPlayerName() ?? "";
		base.GetText(2).SetText(newText, true);
		base.GetText(11).SetText(newText, true);
		this.RefreshSpeakerNameTextColor(PhoneMsgModel.Instance.CurrentUsingChatBgId);
		base.SetTextureShowUntilLoaded(roleHeadIconCircle, base.GetTexture(1), null);
	}

	// Token: 0x060131CE RID: 78286 RVA: 0x004BEAC0 File Offset: 0x004BCCC0
	public void OnNameChange()
	{
		string text = FunctionModel.Instance.GetPlayerName() ?? "";
		if (!string.IsNullOrEmpty(text))
		{
			base.GetText(2).SetText(text, true);
			UUIText text2 = base.GetText(11);
			if (text2 != null)
			{
				text2.SetText(text, true);
			}
		}
	}

	// Token: 0x060131CF RID: 78287 RVA: 0x004BEB0C File Offset: 0x004BCD0C
	public void RefreshDialog(int dialogId)
	{
		ChatDialog? chatDialogConfig = PhoneMsgConfig.Instance.GetChatDialogConfig(dialogId);
		if (chatDialogConfig == null)
		{
			return;
		}
		this.SetSpriteByPath(chatDialogConfig.Value.BgPath, base.GetSprite(10), false, null, null);
		this.TryLoadDynamicDialogNode(chatDialogConfig.Value.SpineItemPath);
		base.GetText(4).SetColor(FColor.FromHex(chatDialogConfig.Value.TextColor));
	}

	// Token: 0x060131D0 RID: 78288 RVA: 0x004BEB8C File Offset: 0x004BCD8C
	private void TryLoadDynamicDialogNode(string path)
	{
		SettingPanelChatRightItem.<>c__DisplayClass7_0 CS$<>8__locals1 = new SettingPanelChatRightItem.<>c__DisplayClass7_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.path = path;
		UiAsyncTask task = new UiAsyncTask("SettingPanelChatRightItem.TryLoadDynamicDialogNode", delegate()
		{
			SettingPanelChatRightItem.<>c__DisplayClass7_0.<<TryLoadDynamicDialogNode>b__0>d <<TryLoadDynamicDialogNode>b__0>d;
			<<TryLoadDynamicDialogNode>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<TryLoadDynamicDialogNode>b__0>d.<>4__this = CS$<>8__locals1;
			<<TryLoadDynamicDialogNode>b__0>d.<>1__state = -1;
			<<TryLoadDynamicDialogNode>b__0>d.<>t__builder.Start<SettingPanelChatRightItem.<>c__DisplayClass7_0.<<TryLoadDynamicDialogNode>b__0>d>(ref <<TryLoadDynamicDialogNode>b__0>d);
			return <<TryLoadDynamicDialogNode>b__0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task).Forget();
	}

	// Token: 0x060131D1 RID: 78289 RVA: 0x004BEBD4 File Offset: 0x004BCDD4
	private UniTask TryLoadDynamicDialogNodeAsync(string path)
	{
		SettingPanelChatRightItem.<TryLoadDynamicDialogNodeAsync>d__8 <TryLoadDynamicDialogNodeAsync>d__;
		<TryLoadDynamicDialogNodeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TryLoadDynamicDialogNodeAsync>d__.<>4__this = this;
		<TryLoadDynamicDialogNodeAsync>d__.path = path;
		<TryLoadDynamicDialogNodeAsync>d__.<>1__state = -1;
		<TryLoadDynamicDialogNodeAsync>d__.<>t__builder.Start<SettingPanelChatRightItem.<TryLoadDynamicDialogNodeAsync>d__8>(ref <TryLoadDynamicDialogNodeAsync>d__);
		return <TryLoadDynamicDialogNodeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060131D2 RID: 78290 RVA: 0x004BEC20 File Offset: 0x004BCE20
	public void RefreshSpeakerNameTextColor(int bgId)
	{
		bool flag = PhoneMsgModel.Instance.IsDefaultChatBg(bgId);
		base.GetText(2).SetUIActive(flag);
		UUIText text = base.GetText(11);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(!flag);
	}

	// Token: 0x060131D3 RID: 78291 RVA: 0x004BEC5C File Offset: 0x004BCE5C
	public void HideRedDot()
	{
		base.GetItem(6).SetUIActive(false);
	}

	// Token: 0x04009047 RID: 36935
	private AActor DynamicDialogActor;

	// Token: 0x04009048 RID: 36936
	private LevelSequencePlayer DialogSequencePlayer;
}
