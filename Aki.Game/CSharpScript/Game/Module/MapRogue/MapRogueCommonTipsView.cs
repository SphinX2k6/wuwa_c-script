using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055EF RID: 21999
	public class MapRogueCommonTipsView : UiViewBase
	{
		// Token: 0x06038057 RID: 229463 RVA: 0x00D44C5B File Offset: 0x00D42E5B
		[NullableContext(1)]
		public MapRogueCommonTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06038058 RID: 229464 RVA: 0x00D44C64 File Offset: 0x00D42E64
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

		// Token: 0x06038059 RID: 229465 RVA: 0x00D44CB5 File Offset: 0x00D42EB5
		private void OnMaskButtonClick()
		{
			if (this.UiViewSequence.HasSequenceNameInPlaying(this.UiViewSequence.StartSequenceName))
			{
				this.UiViewSequence.StopSequenceByKey(this.UiViewSequence.StartSequenceName, true, true);
			}
		}

		// Token: 0x0603805A RID: 229466 RVA: 0x00D44CE7 File Offset: 0x00D42EE7
		protected override void OnAfterShow()
		{
			base.CloseMe(delegate(bool _)
			{
				MapRogueModel.Instance.ExecuteOpData(this.OpIncId, null);
			});
		}

		// Token: 0x0603805B RID: 229467 RVA: 0x00D44CFB File Offset: 0x00D42EFB
		protected override void OnStart()
		{
			this.OpIncId = (int)this.OpenParam;
		}

		// Token: 0x0603805C RID: 229468 RVA: 0x00D44D0E File Offset: 0x00D42F0E
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x0401D6FC RID: 120572
		private int OpIncId;
	}
}
