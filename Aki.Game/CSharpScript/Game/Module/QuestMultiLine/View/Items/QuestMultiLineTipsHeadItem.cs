using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuestMultiLine.View.Items
{
	// Token: 0x02003F93 RID: 16275
	public class QuestMultiLineTipsHeadItem : UiPanelBase
	{
		// Token: 0x060292AA RID: 168618 RVA: 0x00B8F908 File Offset: 0x00B8DB08
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

		// Token: 0x060292AB RID: 168619 RVA: 0x00B8F99C File Offset: 0x00B8DB9C
		[NullableContext(1)]
		public void RefreshHead(QuestMultiLineComponentData componentData)
		{
			this.ComponentData = componentData;
			base.SetTextureByPath(QuestMultiLineUtils.GetComponentIconTexture(this.ComponentData), base.GetTexture(0), null, null);
		}

		// Token: 0x040166A8 RID: 91816
		[Nullable(2)]
		private QuestMultiLineComponentData ComponentData;
	}
}
