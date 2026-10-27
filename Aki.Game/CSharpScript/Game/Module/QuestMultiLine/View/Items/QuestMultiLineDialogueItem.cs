using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuestMultiLine.View.Items
{
	// Token: 0x02004FB5 RID: 20405
	public class QuestMultiLineDialogueItem : UiPanelBase
	{
		// Token: 0x060343BF RID: 213951 RVA: 0x00C43209 File Offset: 0x00C41409
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUISprite))
			};
		}

		// Token: 0x060343C0 RID: 213952 RVA: 0x00C43242 File Offset: 0x00C41442
		[NullableContext(1)]
		public void RefreshDialogue(QuestMultiLineComponentData componentData)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), componentData.OnGoingDesc, Array.Empty<object>());
		}

		// Token: 0x060343C1 RID: 213953 RVA: 0x00C43260 File Offset: 0x00C41460
		public void SetDialogueActive(bool active)
		{
			base.SetUiActive(active);
		}
	}
}
