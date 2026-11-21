using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045C5 RID: 17861
	public class MapRogueCommonTipsView : UiViewBase
	{
		// Token: 0x0602CF55 RID: 184149 RVA: 0x00C929A3 File Offset: 0x00C90BA3
		[NullableContext(1)]
		public MapRogueCommonTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602CF56 RID: 184150 RVA: 0x00C929AC File Offset: 0x00C90BAC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnMaskButtonClick))
			};
		}

		// Token: 0x0602CF57 RID: 184151 RVA: 0x00C929FD File Offset: 0x00C90BFD
		private void OnMaskButtonClick()
		{
			if (this.UiViewSequence.HasSequenceNameInPlaying(this.UiViewSequence.StartSequenceName))
			{
				this.UiViewSequence.StopSequenceByKey(this.UiViewSequence.StartSequenceName, true, true);
			}
		}

		// Token: 0x0602CF58 RID: 184152 RVA: 0x00C92A2F File Offset: 0x00C90C2F
		protected override void OnAfterShow()
		{
			base.CloseMe(delegate(bool _)
			{
				MapRogueModel.Instance.ExecuteOpData(this.OpIncId, null);
			});
		}

		// Token: 0x0602CF59 RID: 184153 RVA: 0x00C92A43 File Offset: 0x00C90C43
		protected override void OnStart()
		{
			this.OpIncId = (int)this.OpenParam;
		}

		// Token: 0x0602CF5A RID: 184154 RVA: 0x00C92A56 File Offset: 0x00C90C56
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x04018187 RID: 98695
		private int OpIncId;
	}
}
