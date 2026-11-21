using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E16 RID: 15894
	public class RogueBattleElementPanel : UiPanelBase
	{
		// Token: 0x06028918 RID: 166168 RVA: 0x00B62234 File Offset: 0x00B60434
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIExtendToggle))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.ToggleElementInfo)),
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleElementInfo))
			};
		}

		// Token: 0x06028919 RID: 166169 RVA: 0x00B6230B File Offset: 0x00B6050B
		private void ToggleElementInfo(EToggleState state)
		{
			if (state != EToggleState.ETT_UnChecked)
			{
				if (state == EToggleState.ETT_Checked)
				{
					RogueBattleElementTipPanel tipPanel = this.TipPanel;
					if (tipPanel == null)
					{
						return;
					}
					tipPanel.SetActive(true);
					return;
				}
			}
			else
			{
				RogueBattleElementTipPanel tipPanel2 = this.TipPanel;
				if (tipPanel2 == null)
				{
					return;
				}
				tipPanel2.SetActive(false);
			}
		}

		// Token: 0x0602891A RID: 166170 RVA: 0x00B62337 File Offset: 0x00B60537
		[NullableContext(1)]
		private RogueBattleTokenElementWithCount CreateElementItem()
		{
			return new RogueBattleTokenElementWithCount();
		}

		// Token: 0x0602891B RID: 166171 RVA: 0x00B62340 File Offset: 0x00B60540
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleElementPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleElementPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602891C RID: 166172 RVA: 0x00B62384 File Offset: 0x00B60584
		public void UpdateElementLayout([Nullable(new byte[]
		{
			2,
			1
		})] List<ElementUnit> addElement = null)
		{
			RogueBattleElementPanel.<>c__DisplayClass6_0 CS$<>8__locals1 = new RogueBattleElementPanel.<>c__DisplayClass6_0();
			CS$<>8__locals1.<>4__this = this;
			ElementUnit[] collection = ((addElement != null) ? addElement.ToArray() : null) ?? Array.Empty<ElementUnit>();
			CS$<>8__locals1.elementInfos = RogueBattleModel.Instance.GetTotalElementInfo(new List<ElementUnit>(collection));
			UiAsyncTask task = new UiAsyncTask("RogueBattleElementPanel.UpdateElementLayout", delegate()
			{
				RogueBattleElementPanel.<>c__DisplayClass6_0.<<UpdateElementLayout>b__0>d <<UpdateElementLayout>b__0>d;
				<<UpdateElementLayout>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<UpdateElementLayout>b__0>d.<>4__this = CS$<>8__locals1;
				<<UpdateElementLayout>b__0>d.<>1__state = -1;
				<<UpdateElementLayout>b__0>d.<>t__builder.Start<RogueBattleElementPanel.<>c__DisplayClass6_0.<<UpdateElementLayout>b__0>d>(ref <<UpdateElementLayout>b__0>d);
				return <<UpdateElementLayout>b__0>d.<>t__builder.Task;
			}, null);
			int totalElementCount = RogueBattleModel.Instance.GetTotalElementCount();
			UUIText text = base.GetText(1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(totalElementCount);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			base.RunAsyncTask(task);
		}

		// Token: 0x04016039 RID: 90169
		[Nullable(2)]
		public RogueBattleElementTipPanel TipPanel;

		// Token: 0x0401603A RID: 90170
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<RogueBattleTokenElementWithCount, IRogueBattleElementInfo> ElementLayout;
	}
}
