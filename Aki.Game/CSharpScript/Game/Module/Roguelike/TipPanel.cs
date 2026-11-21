using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D9D RID: 15773
	public class TipPanel : UiPanelBase
	{
		// Token: 0x0602853F RID: 165183 RVA: 0x00B4BBBC File Offset: 0x00B49DBC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06028540 RID: 165184 RVA: 0x00B4BC48 File Offset: 0x00B49E48
		public void UpdateNum(int totalNum)
		{
			base.GetText(1).SetText(totalNum.ToString(), true);
			if (totalNum == 0)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Roguelike_Yuansu_Empty", Array.Empty<object>());
				return;
			}
			ElementLevel? elementLevelConfigById = RoguelikeConfig.Instance.GetElementLevelConfigById(4);
			if (elementLevelConfigById == null)
			{
				base.GetText(2).SetText("", true);
				return;
			}
			List<string> list = new List<string>();
			foreach (long p0Id in elementLevelConfigById.Value.AddBuffsIter())
			{
				Buff? config = ConfigBuffById.GetConfig(p0Id, true);
				if (config != null)
				{
					list.Add(((double)(config.Value.ModifierMagnitude(0) * totalNum) / 100.0).ToString("F1"));
				}
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), elementLevelConfigById.Value.TextId, list.ToArray());
		}

		// Token: 0x02009982 RID: 39298
		private class ETipCom
		{
			// Token: 0x0402FDDD RID: 196061
			public const int IconSprite = 0;

			// Token: 0x0402FDDE RID: 196062
			public const int NumText = 1;

			// Token: 0x0402FDDF RID: 196063
			public const int DescText = 2;
		}
	}
}
