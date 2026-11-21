using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003EB7 RID: 16055
	public class RogueBattleMapSummaryGridEffectTabView : UiTabViewBase
	{
		// Token: 0x06028BEB RID: 166891 RVA: 0x00B6E480 File Offset: 0x00B6C680
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIArtText)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIArtText)),
				new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(6, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(2, new Action(this.OnClickedMore))
			};
		}

		// Token: 0x06028BEC RID: 166892 RVA: 0x00B6E555 File Offset: 0x00B6C755
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<RogueBattleMapGridEffectTabItem, IRogueBattleMapGridEffectInfo>(base.GetVerticalLayout(5), new Func<RogueBattleMapGridEffectTabItem>(this.InitItem), null, false, true);
		}

		// Token: 0x06028BED RID: 166893 RVA: 0x00B6E578 File Offset: 0x00B6C778
		protected override void OnBeforeShow()
		{
			this.OnClickedTeam();
		}

		// Token: 0x06028BEE RID: 166894 RVA: 0x00B6E580 File Offset: 0x00B6C780
		protected override void OnAfterShow()
		{
			this.UiViewSequence.PlaySequence("Start", false, null);
		}

		// Token: 0x06028BEF RID: 166895 RVA: 0x00B6E5A7 File Offset: 0x00B6C7A7
		protected override void OnBeforeDestroy()
		{
			this.Layout = null;
		}

		// Token: 0x06028BF0 RID: 166896 RVA: 0x00B6E5B0 File Offset: 0x00B6C7B0
		private void OnClickedTeam()
		{
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			List<IRogueBattleMapGridEffectInfo> effectList = RogueBattleModel.Instance.GetEffectList();
			GenericLayout<RogueBattleMapGridEffectTabItem, IRogueBattleMapGridEffectInfo> layout = this.Layout;
			if (layout != null)
			{
				layout.RefreshByData(effectList, null, true);
			}
			int teamLv = MapRogueModel.Instance.GameInfo.TeamLv;
			string text;
			if (teamLv <= 10)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("0");
				defaultInterpolatedStringHandler.AppendFormatted<int>(teamLv);
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				text = teamLv.ToString();
			}
			string text2 = text;
			base.GetArtText(1).SetText(text2);
		}

		// Token: 0x06028BF1 RID: 166897 RVA: 0x00B6E652 File Offset: 0x00B6C852
		[NullableContext(1)]
		private RogueBattleMapGridEffectTabItem InitItem()
		{
			return new RogueBattleMapGridEffectTabItem();
		}

		// Token: 0x06028BF2 RID: 166898 RVA: 0x00B6E659 File Offset: 0x00B6C859
		private void OnClickedMore()
		{
			HelpController.Instance.OpenHelpById(260);
		}

		// Token: 0x04016289 RID: 90761
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RogueBattleMapGridEffectTabItem, IRogueBattleMapGridEffectInfo> Layout;

		// Token: 0x0401628A RID: 90762
		private const int MORE_HELPID = 260;
	}
}
