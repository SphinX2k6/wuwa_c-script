using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DCE RID: 15822
	public class RoguelikeActivityTabItem : UiPanelBase
	{
		// Token: 0x060286F2 RID: 165618 RVA: 0x00B54406 File Offset: 0x00B52606
		public RoguelikeActivityTabItem(int seasonId, int index)
		{
			this.SeasonId = seasonId;
			this.Index = index;
		}

		// Token: 0x060286F3 RID: 165619 RVA: 0x00B5441C File Offset: 0x00B5261C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060286F4 RID: 165620 RVA: 0x00B544E3 File Offset: 0x00B526E3
		protected override void OnStart()
		{
			this.Update(this.SeasonId);
		}

		// Token: 0x060286F5 RID: 165621 RVA: 0x00B544F1 File Offset: 0x00B526F1
		protected void OnClickToggle(EToggleState _)
		{
			EventSystem.Instance.Emit<int, int>(EEventName.RoguelikeSelectSeason, this.SeasonId, this.Index);
		}

		// Token: 0x060286F6 RID: 165622 RVA: 0x00B5450F File Offset: 0x00B5270F
		public void SetToggleState(EToggleState state)
		{
			base.GetExtendToggle(0).SetToggleState(state, false, false, false);
		}

		// Token: 0x060286F7 RID: 165623 RVA: 0x00B54524 File Offset: 0x00B52724
		protected void Update(int seasonId)
		{
			this.SeasonId = seasonId;
			RogueSeason? rogueSeasonConfigById = RoguelikeConfig.Instance.GetRogueSeasonConfigById(seasonId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), rogueSeasonConfigById.Value.SeasonName, Array.Empty<object>());
			this.SetSpriteByPath(rogueSeasonConfigById.Value.TabIcon, base.GetSprite(2), false, null, null);
		}

		// Token: 0x04015F3F RID: 89919
		public int SeasonId;

		// Token: 0x04015F40 RID: 89920
		public int Index;

		// Token: 0x020099CA RID: 39370
		private class ERoguelikeActivityTabItemDefine
		{
			// Token: 0x0402FF20 RID: 196384
			public const int Toggle = 0;

			// Token: 0x0402FF21 RID: 196385
			public const int TxtName = 1;

			// Token: 0x0402FF22 RID: 196386
			public const int SpriteIcon = 2;
		}
	}
}
