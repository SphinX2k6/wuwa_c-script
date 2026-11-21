using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E40 RID: 15936
	public class RogueBattleMapRoleAttributeNameItem : UiPanelBase
	{
		// Token: 0x0602898F RID: 166287 RVA: 0x00B649EC File Offset: 0x00B62BEC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
		}

		// Token: 0x06028990 RID: 166288 RVA: 0x00B64A88 File Offset: 0x00B62C88
		protected override void OnStart()
		{
			this.StarLayout = new GenericLayout<RougeBattleAttributeStarItem, bool>(base.GetHorizontalLayout(4), new Func<RougeBattleAttributeStarItem>(this.CreateElement), null, false, true);
		}

		// Token: 0x06028991 RID: 166289 RVA: 0x00B64AAB File Offset: 0x00B62CAB
		[NullableContext(1)]
		private RougeBattleAttributeStarItem CreateElement()
		{
			return new RougeBattleAttributeStarItem();
		}

		// Token: 0x06028992 RID: 166290 RVA: 0x00B64AB2 File Offset: 0x00B62CB2
		protected override void OnBeforeDestroy()
		{
			this.StarLayout = null;
		}

		// Token: 0x06028993 RID: 166291 RVA: 0x00B64ABC File Offset: 0x00B62CBC
		public void Refresh(int roleId)
		{
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
			if (roleDataById == null)
			{
				RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
				if (roleConfig == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.RogueBattle;
					ELogAuthor author = ELogAuthor.WHJ;
					string message = "没有角色数据";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleId);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				base.GetText(0).SetText(RoleConfig.Instance.GetRoleName(roleConfig.Value.Name), true);
				ElementInfo? elementInfo = ElementInfoConfig.Instance.GetElementInfo(roleConfig.Value.ElementId);
				string elementInfoLocalName = ElementInfoConfig.Instance.GetElementInfoLocalName(elementInfo.Value.Name);
				base.GetText(3).SetText(elementInfoLocalName, true);
				base.SetElementIcon(elementInfo.Value.Icon, base.GetTexture(2), roleConfig.Value.ElementId, null);
				UUIText text = base.GetText(1);
				if (text != null)
				{
					text.SetUIActive(false);
				}
				UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(4);
				if (horizontalLayout == null)
				{
					return;
				}
				horizontalLayout.RootUIComp.Get().SetUIActive(false);
				return;
			}
			else
			{
				base.GetText(0).SetText(roleDataById.GetName(null), true);
				ElementInfo? elementInfo2 = roleDataById.GetElementInfo();
				string elementInfoLocalName2 = ElementInfoConfig.Instance.GetElementInfoLocalName(elementInfo2.Value.Name);
				base.GetText(3).SetText(elementInfoLocalName2, true);
				base.SetElementIcon(elementInfo2.Value.Icon, base.GetTexture(2), roleDataById.GetRoleConfig().ElementId, null);
				bool flag = RogueBattleModel.Instance.IsRoleGot(roleId);
				UUIText text2 = base.GetText(1);
				if (text2 != null)
				{
					text2.SetUIActive(flag);
				}
				UUIHorizontalLayout horizontalLayout2 = base.GetHorizontalLayout(4);
				if (horizontalLayout2 != null)
				{
					horizontalLayout2.RootUIComp.Get().SetUIActive(flag);
				}
				if (!flag)
				{
					return;
				}
				int incIdByRoleId = RogueBattleModel.Instance.GetIncIdByRoleId(roleId);
				RogueResRole roleInfoById = RogueBattleModel.Instance.GetRoleInfoById(incIdByRoleId);
				int rogueRoleLevel = MapRogueModel.Instance.GetRogueRoleLevel();
				UUIText text3 = base.GetText(1);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Lv.");
				defaultInterpolatedStringHandler.AppendFormatted<int>(rogueRoleLevel);
				text3.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				int rogueRoleMaxStar = MapRogueModel.Instance.GetRogueRoleMaxStar();
				int level = roleInfoById.Level;
				List<bool> list = new List<bool>(rogueRoleMaxStar);
				for (int i = 0; i < rogueRoleMaxStar; i++)
				{
					list.Add(i < level);
				}
				GenericLayout<RougeBattleAttributeStarItem, bool> starLayout = this.StarLayout;
				if (starLayout == null)
				{
					return;
				}
				starLayout.RefreshByData(list, null, false);
				return;
			}
		}

		// Token: 0x040160CB RID: 90315
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RougeBattleAttributeStarItem, bool> StarLayout;
	}
}
