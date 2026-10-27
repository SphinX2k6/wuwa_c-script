using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.MapRogue;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E79 RID: 20089
	public class MediumItemGridRogueRoleLevelComponent : MediumItemGridComponent
	{
		// Token: 0x06033B2A RID: 211754 RVA: 0x00C1B84C File Offset: 0x00C19A4C
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

		// Token: 0x06033B2B RID: 211755 RVA: 0x00C1B8BC File Offset: 0x00C19ABC
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_ItemRoleInfo";
		}

		// Token: 0x06033B2C RID: 211756 RVA: 0x00C1B8C4 File Offset: 0x00C19AC4
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
