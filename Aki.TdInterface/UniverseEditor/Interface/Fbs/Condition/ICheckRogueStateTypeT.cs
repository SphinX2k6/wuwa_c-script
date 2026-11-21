using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FFF RID: 20479
	public class ICheckRogueStateTypeT
	{
		// Token: 0x17009285 RID: 37509
		// (get) Token: 0x0601FF5F RID: 130911 RVA: 0x0046FB82 File Offset: 0x0046DD82
		// (set) Token: 0x0601FF60 RID: 130912 RVA: 0x0046FB8A File Offset: 0x0046DD8A
		public ERogueStateType Type { get; set; }

		// Token: 0x0601FF61 RID: 130913 RVA: 0x0046FB93 File Offset: 0x0046DD93
		public ICheckRogueStateTypeT()
		{
			this.Type = ERogueStateType.Talent;
		}
	}
}
