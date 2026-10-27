using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006703 RID: 26371
	public class IExecBpActorFuncT
	{
		// Token: 0x1700C3F2 RID: 50162
		// (get) Token: 0x0602DDDB RID: 187867 RVA: 0x00645A35 File Offset: 0x00643C35
		// (set) Token: 0x0602DDDC RID: 187868 RVA: 0x00645A3D File Offset: 0x00643C3D
		public TBpActorFuncTypeUnion ExecFuncType { get; set; }

		// Token: 0x0602DDDD RID: 187869 RVA: 0x00645A46 File Offset: 0x00643C46
		public IExecBpActorFuncT()
		{
			this.ExecFuncType = null;
		}
	}
}
