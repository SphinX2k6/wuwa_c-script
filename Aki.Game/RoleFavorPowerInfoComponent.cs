using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02001DEB RID: 7659
public class RoleFavorPowerInfoComponent : RoleFavorViewComponentBase
{
	// Token: 0x06012EE5 RID: 77541 RVA: 0x0058C774 File Offset: 0x0058A974
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUINiagara)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText))
		};
	}

	// Token: 0x06012EE6 RID: 77542 RVA: 0x0058C810 File Offset: 0x0058AA10
	[NullableContext(1)]
	protected override void OnSetData(RoleFavorContentDataBase contentData)
	{
		if (contentData.FavorContentType != EFavorContentType.ExperienceFile)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "不支持的好感度类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("favorTabType", contentData.FavorContentType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.FavorRoleInfoConfig = new FavorRoleInfo?(((RoleFavorRoleInfoContentData)contentData).ConfigData);
	}

	// Token: 0x06012EE7 RID: 77543 RVA: 0x0058C870 File Offset: 0x0058AA70
	protected override void OnRefreshView()
	{
		if (this.FavorRoleInfoConfig == null)
		{
			return;
		}
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalText(text, "FavorPowerFile", Array.Empty<object>());
		UUIText text2 = base.GetText(3);
		if (text2 != null)
		{
			text2.ShowTextNew(this.FavorRoleInfoConfig.Value.TalentName);
		}
		UUIText text3 = base.GetText(4);
		if (text3 != null)
		{
			text3.ShowTextNew(this.FavorRoleInfoConfig.Value.TalentDoc);
		}
		UUIText text4 = base.GetText(5);
		if (text4 == null)
		{
			return;
		}
		text4.ShowTextNew(this.FavorRoleInfoConfig.Value.TalentCertification);
	}

	// Token: 0x06012EE8 RID: 77544 RVA: 0x0058C918 File Offset: 0x0058AB18
	protected override void OnStart()
	{
		UUIText text = base.GetText(3);
		if (!TermExplanationController.Instance.IsUiTextRegistered(text))
		{
			TermExplanationController.Instance.RegisterTextHyperlink(text, ETermExplanationViewType.Side, ETermExplanationReportType.RoleInfo, ETermExplanationViewAttachDirection.Left, null, null, null, ETermExplanationGroup.Default, 0, ETermExplanationViewStyle.Default);
		}
		UUIText text2 = base.GetText(4);
		if (!TermExplanationController.Instance.IsUiTextRegistered(text2))
		{
			TermExplanationController.Instance.RegisterTextHyperlink(text2, ETermExplanationViewType.Side, ETermExplanationReportType.RoleInfo, ETermExplanationViewAttachDirection.Left, null, null, null, ETermExplanationGroup.Default, 0, ETermExplanationViewStyle.Default);
		}
		UUIText text3 = base.GetText(5);
		if (!TermExplanationController.Instance.IsUiTextRegistered(text3))
		{
			TermExplanationController.Instance.RegisterTextHyperlink(text3, ETermExplanationViewType.Side, ETermExplanationReportType.RoleInfo, ETermExplanationViewAttachDirection.Left, null, null, null, ETermExplanationGroup.Default, 0, ETermExplanationViewStyle.Default);
		}
	}

	// Token: 0x06012EE9 RID: 77545 RVA: 0x0058C9BC File Offset: 0x0058ABBC
	protected override void OnBeforeDestroy()
	{
		this.FavorRoleInfoConfig = null;
		UUIText text = base.GetText(3);
		if (TermExplanationController.Instance.IsUiTextRegistered(text))
		{
			TermExplanationController.Instance.UnRegisterTextHyperlink(text);
		}
		UUIText text2 = base.GetText(4);
		if (TermExplanationController.Instance.IsUiTextRegistered(text2))
		{
			TermExplanationController.Instance.UnRegisterTextHyperlink(text2);
		}
		UUIText text3 = base.GetText(5);
		if (TermExplanationController.Instance.IsUiTextRegistered(text3))
		{
			TermExplanationController.Instance.UnRegisterTextHyperlink(text3);
		}
	}

	// Token: 0x0400A325 RID: 41765
	private FavorRoleInfo? FavorRoleInfoConfig;
}
