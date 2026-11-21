using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.MapRogue;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E42 RID: 15938
	public class MediumItemGridRogueRoleLevelComponent : MediumItemGridComponent
	{
		// Token: 0x06028995 RID: 166293 RVA: 0x00B64D70 File Offset: 0x00B62F70
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText))
			};
		}

		// Token: 0x06028996 RID: 166294 RVA: 0x00B64DE0 File Offset: 0x00B62FE0
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_ItemRoleInfo";
		}

		// Token: 0x06028997 RID: 166295 RVA: 0x00B64DE8 File Offset: 0x00B62FE8
		[NullableContext(2)]
		protected override void OnRefresh(object data = null)
		{
			IRogueBattleMapRoleGridInfo rogueBattleMapRoleGridInfo = (IRogueBattleMapRoleGridInfo)data;
			int configId = rogueBattleMapRoleGridInfo.ConfigId;
			bool flag = RogueBattleModel.Instance.IsRoleGot(configId);
			this.SetActive(flag);
			if (!flag)
			{
				return;
			}
			int incIdByRoleId = RogueBattleModel.Instance.GetIncIdByRoleId(configId);
			RogueResRole roleInfoById = RogueBattleModel.Instance.GetRoleInfoById(incIdByRoleId);
			if (rogueBattleMapRoleGridInfo.NeedLevel)
			{
				UUIText text = base.GetText(0);
				if (text != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Lv.");
					defaultInterpolatedStringHandler.AppendFormatted<int>(MapRogueModel.Instance.GetRogueRoleLevel());
					text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				}
			}
			else
			{
				UUIText text2 = base.GetText(0);
				if (text2 != null)
				{
					text2.SetText(string.Empty, true);
				}
			}
			UUIText text3 = base.GetText(3);
			if (text3 == null)
			{
				return;
			}
			text3.SetText(roleInfoById.Level.ToString(), true);
		}
	}
}
