using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200140B RID: 5131
	public class IAtomicProcessBase
	{
		// Token: 0x060074B2 RID: 29874 RVA: 0x00117093 File Offset: 0x00115293
		[NullableContext(1)]
		public static IAtomicProcessBase Create(IAtomicProcessBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAtomicProcessBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700266F RID: 9839
		// (get) Token: 0x060074B3 RID: 29875 RVA: 0x001170B2 File Offset: 0x001152B2
		public virtual EAtomicProcess Type
		{
			get
			{
				return (EAtomicProcess)this.Instance.Type;
			}
		}

		// Token: 0x0400438F RID: 17295
		private IAtomicProcessBase Instance;
	}
}
