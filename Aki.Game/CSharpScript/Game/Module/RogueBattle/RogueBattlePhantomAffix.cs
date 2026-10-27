using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E80 RID: 20096
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattlePhantomAffix : GridProxyAbstract<PhantomAffixInfo>
	{
		// Token: 0x06033B46 RID: 211782 RVA: 0x00C1C188 File Offset: 0x00C1A388
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout))
			};
		}

		// Token: 0x06033B47 RID: 211783 RVA: 0x00C1C268 File Offset: 0x00C1A468
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattlePhantomAffix.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattlePhantomAffix.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033B48 RID: 211784 RVA: 0x00C1C2AB File Offset: 0x00C1A4AB
		private RogueBattleTokenElementWithCount CreateElementItem()
		{
			return new RogueBattleTokenElementWithCount();
		}

		// Token: 0x06033B49 RID: 211785 RVA: 0x00C1C2B2 File Offset: 0x00C1A4B2
		public override void Refresh(PhantomAffixInfo data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RefreshLayout();
			this.RefreshElement();
			this.RefreshUnlock();
			this.RefreshAttrText();
		}

		// Token: 0x06033B4A RID: 211786 RVA: 0x00C1C2D4 File Offset: 0x00C1A4D4
		public void RefreshAttrText()
		{
			if (this.Data == null)
			{
				return;
			}
			RogueResAffix? rogueResAffix = RogueBattleConfig.Instance.GetRogueResAffix(this.Data.ConfigId);
			if (rogueResAffix == null)
			{
				return;
			}
			bool descMode = RogueBattleModel.Instance.DescMode != EDescModel.SIMPLE;
			UUIText text = base.GetText(0);
			UUIText text2 = base.GetText(7);
			FColor fcolor = FColor.FromHex("BEFE58FF");
			FColor fcolor2 = FColor.FromHex("ECE5D8FF");
			FColor color = this.Data.Isunlock ? fcolor : fcolor2;
			if (text2 != null)
			{
				text2.SetColor(color);
			}
			if (text != null)
			{
				text.SetColor(color);
			}
			if (!descMode)
			{
				LguiUtil.Instance.SetLocalTextNew(text, rogueResAffix.Value.AffixDescSimple, Array.Empty<object>());
				LguiUtil.Instance.SetLocalTextNew(text2, rogueResAffix.Value.AffixDescSimple, Array.Empty<object>());
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(text, rogueResAffix.Value.AffixDesc, rogueResAffix.Value.AffixDescParam());
			LguiUtil.Instance.SetLocalTextNew(text2, rogueResAffix.Value.AffixDesc, rogueResAffix.Value.AffixDescParam());
		}

		// Token: 0x06033B4B RID: 211787 RVA: 0x00C1C3FE File Offset: 0x00C1A5FE
		public void RefreshUnlock()
		{
			if (this.Data == null)
			{
				return;
			}
			base.GetSprite(3).SetUIActive(this.Data.Isunlock);
			base.GetSprite(4).SetUIActive(!this.Data.Isunlock);
		}

		// Token: 0x06033B4C RID: 211788 RVA: 0x00C1C43C File Offset: 0x00C1A63C
		public void RefreshLayout()
		{
			UUIText text = base.GetText(0);
			bool flag = text.GetTextRenderSize().X < text.Width;
			UUIItem parentAsUIItem = base.GetHorizontalLayout(1).GetRootComponent().GetParentAsUIItem();
			UUIItem item = base.GetItem(6);
			UUISizeControlByOther uuisizeControlByOther = base.GetItem(5).GetOwner().GetComponentByClass(UUISizeControlByOther.StaticClass()) as UUISizeControlByOther;
			AUIBaseActor targetActor = (flag ? parentAsUIItem.GetOwner() : item.GetOwner()) as AUIBaseActor;
			if (uuisizeControlByOther != null)
			{
				uuisizeControlByOther.SetTargetActor(targetActor);
			}
			parentAsUIItem.SetUIActive(flag);
			item.SetUIActive(!flag);
		}

		// Token: 0x06033B4D RID: 211789 RVA: 0x00C1C4D8 File Offset: 0x00C1A6D8
		public void RefreshElement()
		{
			RogueBattlePhantomAffix.<>c__DisplayClass12_0 CS$<>8__locals1 = new RogueBattlePhantomAffix.<>c__DisplayClass12_0();
			CS$<>8__locals1.<>4__this = this;
			if (this.Data == null)
			{
				return;
			}
			CS$<>8__locals1.elementList = RogueBattleUtils.ConvertElementUnitsToElementInfo(this.Data.ElementUnits.ToArray<ElementUnit>());
			this.ElementLayout.RefreshByData(CS$<>8__locals1.elementList, null, false);
			this.AdaptationElementLayout.RefreshByData(CS$<>8__locals1.elementList, null, false);
			UiAsyncTask task = new UiAsyncTask("RogueBattlePhantomAffix.RefreshElement", delegate()
			{
				RogueBattlePhantomAffix.<>c__DisplayClass12_0.<<RefreshElement>b__0>d <<RefreshElement>b__0>d;
				<<RefreshElement>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<RefreshElement>b__0>d.<>4__this = CS$<>8__locals1;
				<<RefreshElement>b__0>d.<>1__state = -1;
				<<RefreshElement>b__0>d.<>t__builder.Start<RogueBattlePhantomAffix.<>c__DisplayClass12_0.<<RefreshElement>b__0>d>(ref <<RefreshElement>b__0>d);
				return <<RefreshElement>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x06033B4E RID: 211790 RVA: 0x00C1C55C File Offset: 0x00C1A75C
		public void PlayComplete()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Complete", false, null, false);
		}

		// Token: 0x0401B717 RID: 112407
		private const string COMPLETE = "Complete";

		// Token: 0x0401B718 RID: 112408
		[Nullable(2)]
		public PhantomAffixInfo Data;

		// Token: 0x0401B719 RID: 112409
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<RogueBattleTokenElementWithCount, IRogueBattleElementInfo> ElementLayout;

		// Token: 0x0401B71A RID: 112410
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<RogueBattleTokenElementWithCount, IRogueBattleElementInfo> AdaptationElementLayout;

		// Token: 0x0401B71B RID: 112411
		[Nullable(2)]
		public LevelSequencePlayer LevelSequencePlayer;
	}
}
