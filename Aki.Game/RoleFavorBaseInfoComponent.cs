using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x0200286A RID: 10346
public class RoleFavorBaseInfoComponent : RoleFavorViewComponentBase
{
	// Token: 0x060154CE RID: 87246 RVA: 0x005612B4 File Offset: 0x0055F4B4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUINiagara))
		};
	}

	// Token: 0x060154CF RID: 87247 RVA: 0x0056137C File Offset: 0x0055F57C
	[NullableContext(1)]
	protected override void OnSetData(RoleFavorContentDataBase contentData)
	{
		this.RoleId = new int?(contentData.RoleId);
	}

	// Token: 0x060154D0 RID: 87248 RVA: 0x00561390 File Offset: 0x0055F590
	protected override void OnRefreshView()
	{
		if (this.RoleId != null)
		{
			int? roleId = this.RoleId;
			int num = 0;
			if (!(roleId.GetValueOrDefault() == num & roleId != null))
			{
				UUIText text = base.GetText(0);
				FavorRoleInfo? favorRoleInfoConfig = RoleFavorConfig.Instance.GetFavorRoleInfoConfig(this.RoleId.Value);
				if (favorRoleInfoConfig == null)
				{
					return;
				}
				LguiUtil.Instance.SetLocalText(text, "FavorBaseInfo", Array.Empty<object>());
				UUIText text2 = base.GetText(2);
				if (text2 != null)
				{
					text2.SetUIActive(false);
				}
				UUIText text3 = base.GetText(3);
				if (text3 != null)
				{
					text3.ShowTextNew(favorRoleInfoConfig.Value.Sex);
				}
				UUIText text4 = base.GetText(4);
				if (text4 != null)
				{
					text4.ShowTextNew(favorRoleInfoConfig.Value.Country);
				}
				UUIText text5 = base.GetText(5);
				if (text5 != null)
				{
					text5.ShowTextNew(favorRoleInfoConfig.Value.Influence);
				}
				UUIText text6 = base.GetText(6);
				if (text6 == null)
				{
					return;
				}
				text6.ShowTextNew(favorRoleInfoConfig.Value.Info);
				return;
			}
		}
	}

	// Token: 0x060154D1 RID: 87249 RVA: 0x005614A0 File Offset: 0x0055F6A0
	protected override void OnStart()
	{
		UUIText text = base.GetText(6);
		if (!TermExplanationController.Instance.IsUiTextRegistered(text))
		{
			TermExplanationController.Instance.RegisterTextHyperlink(text, ETermExplanationViewType.Side, ETermExplanationReportType.RoleInfo, ETermExplanationViewAttachDirection.Left, null, null, null, ETermExplanationGroup.Default, 0, ETermExplanationViewStyle.Default);
		}
	}

	// Token: 0x060154D2 RID: 87250 RVA: 0x005614E0 File Offset: 0x0055F6E0
	protected override void OnBeforeDestroy()
	{
		this.RoleId = null;
		UUIText text = base.GetText(6);
		if (TermExplanationController.Instance.IsUiTextRegistered(text))
		{
			TermExplanationController.Instance.UnRegisterTextHyperlink(text);
		}
	}

	// Token: 0x04009F27 RID: 40743
	private int? RoleId = new int?(0);
}
