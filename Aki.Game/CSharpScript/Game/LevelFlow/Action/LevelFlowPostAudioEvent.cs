using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006115 RID: 24853
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowPostAudioEvent : LevelFlowActionBase
	{
		// Token: 0x0603B8F2 RID: 243954 RVA: 0x010E3DAD File Offset: 0x010E1FAD
		public LevelFlowPostAudioEvent Init(string audioEventName)
		{
			this.AudioEventName = audioEventName;
			return this;
		}

		// Token: 0x0603B8F3 RID: 243955 RVA: 0x010E3DB7 File Offset: 0x010E1FB7
		protected override void OnExecute()
		{
			AudioSystem.Instance.PostEvent(this.AudioEventName);
			base.FinishExecute(true);
		}

		// Token: 0x0401F68E RID: 128654
		private string AudioEventName = string.Empty;
	}
}
