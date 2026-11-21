using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02001DE5 RID: 7653
public class RoleFavorBaseInfoComponent : RoleFavorViewComponentBase
{
	// Token: 0x06012ECC RID: 77516 RVA: 0x0058C010 File Offset: 0x0058A210
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

	// Token: 0x06012ECD RID: 77517 RVA: 0x0058C0D8 File Offset: 0x0058A2D8
	[NullableContext(1)]
	protected override void OnSetData(RoleFavorContentDataBase contentData)
	{
		this.RoleId = new int?(contentData.RoleId);
	}

	// Token: 0x06012ECE RID: 77518 RVA: 0x0058C0EC File Offset: 0x0058A2EC
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

	// Token: 0x06012ECF RID: 77519 RVA: 0x0058C1FC File Offset: 0x0058A3FC
	protected override void OnStart()
	{
		UUIText text = base.GetText(6);
		if (!TermExplanationController.Instance.IsUiTextRegistered(text))
		{
			TermExplanationController.Instance.RegisterTextHyperlink(text, ETermExplanationViewType.Side, ETermExplanationReportType.RoleInfo, ETermExplanationViewAttachDirection.Left, null, null, null, ETermExplanationGroup.Default, 0, ETermExplanationViewStyle.Default);
		}
	}

	// Token: 0x06012ED0 RID: 77520 RVA: 0x0058C23C File Offset: 0x0058A43C
	protected override void OnBeforeDestroy()
	{
		this.RoleId = null;
		UUIText text = base.GetText(6);
		if (TermExplanationController.Instance.IsUiTextRegistered(text))
		{
			TermExplanationController.Instance.UnRegisterTextHyperlink(text);
		}
	}

	// Token: 0x0400A310 RID: 41744
	private int? RoleId = new int?(0);
}
