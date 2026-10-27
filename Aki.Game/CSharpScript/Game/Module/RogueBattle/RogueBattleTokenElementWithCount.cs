using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EB6 RID: 20150
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleTokenElementWithCount : GridProxyAbstract<IRogueBattleElementInfo>
	{
		// Token: 0x06033BFC RID: 211964 RVA: 0x00C1FDD3 File Offset: 0x00C1DFD3
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x06033BFD RID: 211965 RVA: 0x00C1FE0C File Offset: 0x00C1E00C
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleTokenElementWithCount.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleTokenElementWithCount.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033BFE RID: 211966 RVA: 0x00C1FE50 File Offset: 0x00C1E050
		public override void Refresh(IRogueBattleElementInfo elementInfo, bool isSelected, int gridIndex)
		{
			RogueBattleTokenElement elementItem = this.ElementItem;
			if (elementItem != null)
			{
				elementItem.Refresh(elementInfo.ElementId, isSelected, gridIndex);
			}
			UUIText text = base.GetText(1);
			text.SetText(elementInfo.Count.ToString(), true);
			bool isPreview = elementInfo.IsPreview;
			FColor? fcolor = null;
			text.SetChangeColor(isPreview, fcolor);
		}

		// Token: 0x0401B7F7 RID: 112631
		[Nullable(2)]
		public RogueBattleTokenElement ElementItem;
	}
}
