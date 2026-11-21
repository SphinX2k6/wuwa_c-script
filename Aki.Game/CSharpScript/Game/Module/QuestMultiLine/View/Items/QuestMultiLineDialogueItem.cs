using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuestMultiLine.View.Items
{
	// Token: 0x02003F7E RID: 16254
	public class QuestMultiLineDialogueItem : UiPanelBase
	{
		// Token: 0x0602922D RID: 168493 RVA: 0x00B8C9B5 File Offset: 0x00B8ABB5
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUISprite))
			};
		}

		// Token: 0x0602922E RID: 168494 RVA: 0x00B8C9EE File Offset: 0x00B8ABEE
		[NullableContext(1)]
		public void RefreshDialogue(QuestMultiLineComponentData componentData)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), componentData.OnGoingDesc, Array.Empty<object>());
		}

		// Token: 0x0602922F RID: 168495 RVA: 0x00B8CA0C File Offset: 0x00B8AC0C
		public void SetDialogueActive(bool active)
		{
			base.SetUiActive(active);
		}
	}
}
