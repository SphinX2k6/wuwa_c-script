using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuestMultiLine.View.Items
{
	// Token: 0x02004FC8 RID: 20424
	public class QuestMultiLineTipsFinishItem : UiPanelBase
	{
		// Token: 0x06034439 RID: 214073 RVA: 0x00C4607C File Offset: 0x00C4427C
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

		// Token: 0x0603443A RID: 214074 RVA: 0x00C46110 File Offset: 0x00C44310
		[NullableContext(1)]
		public void RefreshHead(QuestMultiLineComponentData componentData)
		{
			this.ComponentData = componentData;
			base.SetTextureByPath(QuestMultiLineUtils.GetComponentIconTexture(this.ComponentData), base.GetTexture(0), null, null);
		}

		// Token: 0x0401BCCC RID: 113868
		[Nullable(2)]
		private QuestMultiLineComponentData ComponentData;
	}
}
