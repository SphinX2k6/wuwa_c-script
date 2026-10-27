using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuestMultiLine.View.Items
{
	// Token: 0x02004FCA RID: 20426
	public class QuestMultiLineTipsHeadItem : UiPanelBase
	{
		// Token: 0x0603443C RID: 214076 RVA: 0x00C46150 File Offset: 0x00C44350
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x0603443D RID: 214077 RVA: 0x00C461E4 File Offset: 0x00C443E4
		[NullableContext(1)]
		public void RefreshHead(QuestMultiLineComponentData componentData)
		{
			this.ComponentData = componentData;
			base.SetTextureByPath(QuestMultiLineUtils.GetComponentIconTexture(this.ComponentData), base.GetTexture(0), null, null);
		}

		// Token: 0x0401BCD3 RID: 113875
		[Nullable(2)]
		private QuestMultiLineComponentData ComponentData;
	}
}
