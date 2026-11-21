using System;

namespace System.Threading.Tasks
{
	// Token: 0x020004BF RID: 1215
	internal interface ITaskCompletionAction
	{
		// Token: 0x06004670 RID: 18032
		void Invoke(Task completingTask);

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06004671 RID: 18033
		bool InvokeMayRunArbitraryCode { get; }
	}
}
