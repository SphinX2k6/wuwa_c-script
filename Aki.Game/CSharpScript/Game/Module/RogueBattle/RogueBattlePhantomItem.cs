using System;
using System.Collections.Generic;
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
	// Token: 0x02003E4F RID: 15951
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattlePhantomItem : GridProxyAbstract<RogueResGainData>
	{
		// Token: 0x060289C7 RID: 166343 RVA: 0x00B65FEC File Offset: 0x00B641EC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.OnClick))
			};
		}

		// Token: 0x060289C8 RID: 166344 RVA: 0x00B66104 File Offset: 0x00B64304
		private void OnClick(EToggleState state)
		{
			if (this.SelectCallBack == null)
			{
				return;
			}
			if (base.GetExtendToggle(5).GetToggleState() == EToggleState.ETT_Checked)
			{
				this.SelectCallBack(new int?(base.GridIndex));
				return;
			}
			this.SelectCallBack(null);
		}

		// Token: 0x060289C9 RID: 166345 RVA: 0x00B66154 File Offset: 0x00B64354
		private RogueBattlePhantomAffix CreateAffixItem()
		{
			return new RogueBattlePhantomAffix();
		}

		// Token: 0x060289CA RID: 166346 RVA: 0x00B6615C File Offset: 0x00B6435C
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattlePhantomItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattlePhantomItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060289CB RID: 166347 RVA: 0x00B661A0 File Offset: 0x00B643A0
		public override void Refresh(RogueResGainData data, bool isSelected, int gridIndex)
		{
			RogueBattlePhantomItem.<>c__DisplayClass7_0 CS$<>8__locals1 = new RogueBattlePhantomItem.<>c__DisplayClass7_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.data = data;
			if (CS$<>8__locals1.data.RogueResPhantom == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RogueBattle;
				ELogAuthor author = ELogAuthor.LPH;
				string message = "不是声骸类型的数据";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", CS$<>8__locals1.data.RogueResDataType);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.Data = CS$<>8__locals1.data;
			RogueResPokemon? rogueResPokemon = RogueBattleConfig.Instance.GetRogueResPokemon(CS$<>8__locals1.data.RogueResPhantom.ConfigId);
			if (rogueResPokemon == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), rogueResPokemon.Value.PokemonName, Array.Empty<object>());
			base.SetTextureByPath(rogueResPokemon.Value.PokemonIcon, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), rogueResPokemon.Value.PokemonSkillDesc, Array.Empty<object>());
			base.GetText(2).SetUIActive(RogueBattleModel.Instance.DescMode == EDescModel.DETAIL);
			RogueResQualityConfig? rogueResQualityConfig = RogueBattleConfig.Instance.GetRogueResQualityConfig(rogueResPokemon.Value.Quality);
			if (rogueResQualityConfig != null)
			{
				base.SetTextureByPath(rogueResQualityConfig.Value.PhantomBgA, base.GetTexture(6), null, null);
				base.SetTextureByPath(rogueResQualityConfig.Value.PhantomBgB, base.GetTexture(7), null, null);
			}
			UiAsyncTask task = new UiAsyncTask("RogueBattlePhantomItem.Refresh", delegate()
			{
				RogueBattlePhantomItem.<>c__DisplayClass7_0.<<Refresh>b__0>d <<Refresh>b__0>d;
				<<Refresh>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<Refresh>b__0>d.<>4__this = CS$<>8__locals1;
				<<Refresh>b__0>d.<>1__state = -1;
				<<Refresh>b__0>d.<>t__builder.Start<RogueBattlePhantomItem.<>c__DisplayClass7_0.<<Refresh>b__0>d>(ref <<Refresh>b__0>d);
				return <<Refresh>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x060289CC RID: 166348 RVA: 0x00B6635A File Offset: 0x00B6455A
		public override void OnSelected(bool fireEvent)
		{
			RogueBattleModel.Instance.SelectGainData = this.Data;
		}

		// Token: 0x060289CD RID: 166349 RVA: 0x00B6636C File Offset: 0x00B6456C
		public override void OnDeselected(bool fireEvent)
		{
			RogueBattleModel.Instance.SelectGainData = null;
		}

		// Token: 0x0401610D RID: 90381
		[Nullable(2)]
		public Action<int?> SelectCallBack;

		// Token: 0x0401610E RID: 90382
		[Nullable(2)]
		public RogueResGainData Data;

		// Token: 0x0401610F RID: 90383
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<RogueBattlePhantomAffix, PhantomAffixInfo> AffixLayout;
	}
}
