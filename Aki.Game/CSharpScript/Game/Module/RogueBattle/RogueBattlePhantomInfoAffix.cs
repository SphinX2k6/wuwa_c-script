using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E4D RID: 15949
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattlePhantomInfoAffix : GridProxyAbstract<PhantomAffixInfo>
	{
		// Token: 0x060289BF RID: 166335 RVA: 0x00B65BB4 File Offset: 0x00B63DB4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText))
			};
		}

		// Token: 0x060289C0 RID: 166336 RVA: 0x00B65C3C File Offset: 0x00B63E3C
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattlePhantomInfoAffix.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattlePhantomInfoAffix.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060289C1 RID: 166337 RVA: 0x00B65C7F File Offset: 0x00B63E7F
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			EventSystem.Instance.Add(EEventName.RogueBattleSelectOptionPreview, new Action(this.RefreshSelectGainData));
		}

		// Token: 0x060289C2 RID: 166338 RVA: 0x00B65CA3 File Offset: 0x00B63EA3
		protected override void OnBeforeHide()
		{
			base.OnBeforeHide();
			EventSystem.Instance.Remove(EEventName.RogueBattleSelectOptionPreview, new Action(this.RefreshSelectGainData));
		}

		// Token: 0x060289C3 RID: 166339 RVA: 0x00B65CC7 File Offset: 0x00B63EC7
		private RogueBattleTokenElementWithCount CreateElementItem()
		{
			return new RogueBattleTokenElementWithCount();
		}

		// Token: 0x060289C4 RID: 166340 RVA: 0x00B65CD0 File Offset: 0x00B63ED0
		public override void Refresh(PhantomAffixInfo data, bool isSelected, int gridIndex)
		{
			RogueBattlePhantomInfoAffix.<>c__DisplayClass9_0 CS$<>8__locals1 = new RogueBattlePhantomInfoAffix.<>c__DisplayClass9_0();
			CS$<>8__locals1.<>4__this = this;
			this.Data = data;
			RogueResAffix? rogueResAffix = RogueBattleConfig.Instance.GetRogueResAffix(data.ConfigId);
			if (rogueResAffix == null)
			{
				return;
			}
			if (RogueBattleModel.Instance.DescMode == EDescModel.SIMPLE)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(3), rogueResAffix.Value.AffixDescSimple, Array.Empty<object>());
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(3), rogueResAffix.Value.AffixDesc, rogueResAffix.Value.AffixDescParam());
			}
			CS$<>8__locals1.elementInfo = RogueBattleUtils.ConvertElementUnitsToElementInfo(data.ElementUnits);
			UiAsyncTask task = new UiAsyncTask("RogueBattlePhantomInfoAffix.Refresh", delegate()
			{
				RogueBattlePhantomInfoAffix.<>c__DisplayClass9_0.<<Refresh>b__0>d <<Refresh>b__0>d;
				<<Refresh>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<Refresh>b__0>d.<>4__this = CS$<>8__locals1;
				<<Refresh>b__0>d.<>1__state = -1;
				<<Refresh>b__0>d.<>t__builder.Start<RogueBattlePhantomInfoAffix.<>c__DisplayClass9_0.<<Refresh>b__0>d>(ref <<Refresh>b__0>d);
				return <<Refresh>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x060289C5 RID: 166341 RVA: 0x00B65DA0 File Offset: 0x00B63FA0
		public void RefreshSelectGainData()
		{
			bool flag = true;
			RogueResGainData selectGainData = RogueBattleModel.Instance.SelectGainData;
			if (selectGainData == null)
			{
				if (this.UnlockState)
				{
					LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
					if (levelSequencePlayer != null)
					{
						levelSequencePlayer.PlayLevelSequenceByName("Disappear", false, null, false);
					}
					this.UnlockState = false;
				}
				return;
			}
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			if (this.Data != null)
			{
				foreach (ElementUnit elementUnit in this.Data.ElementUnits)
				{
					dictionary[elementUnit.ElementId] = elementUnit.Count;
				}
			}
			Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
			foreach (ElementUnit elementUnit2 in selectGainData.RogueResToken.ElementUnits)
			{
				IRogueBattleElementInfo elementInfoById = RogueBattleModel.Instance.GetElementInfoById(elementUnit2.ElementId);
				int num = (elementInfoById != null) ? elementInfoById.Count : 0;
				dictionary2[elementUnit2.ElementId] = elementUnit2.Count + num;
			}
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				if (!dictionary2.ContainsKey(key) || dictionary2[key] < value)
				{
					flag = false;
				}
			}
			bool flag2 = flag && this.Data != null && !this.Data.Isunlock;
			base.GetItem(2).SetUIActive(flag2);
			UUIText text = base.GetText(3);
			if (text != null)
			{
				UUIItem uuiitem = text;
				bool bUseChangeColor = flag2;
				FColor? fcolor = new FColor?(text.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			}
			if (flag2)
			{
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 != null)
				{
					levelSequencePlayer2.PlayLevelSequenceByName("Complete", false, null, false);
				}
				this.UnlockState = true;
				return;
			}
			if (this.UnlockState)
			{
				LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
				if (levelSequencePlayer3 != null)
				{
					levelSequencePlayer3.PlayLevelSequenceByName("Disappear", false, null, false);
				}
				this.UnlockState = false;
			}
		}

		// Token: 0x040160FE RID: 90366
		[Nullable(2)]
		public PhantomAffixInfo Data;

		// Token: 0x040160FF RID: 90367
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<RogueBattleTokenElementWithCount, IRogueBattleElementInfo> ElementLayout;

		// Token: 0x04016100 RID: 90368
		[Nullable(2)]
		public LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04016101 RID: 90369
		public bool UnlockState;
	}
}
