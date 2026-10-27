using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029A6 RID: 10662
	public class IVillageInfrTreeProcess : IVillageInfrBuildOption
	{
		// Token: 0x0600EBF2 RID: 60402 RVA: 0x00227B67 File Offset: 0x00225D67
		[NullableContext(1)]
		public static IVillageInfrTreeProcess Create(IVillageInfrTreeProcess? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVillageInfrTreeProcess
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A68 RID: 19048
		// (get) Token: 0x0600EBF3 RID: 60403 RVA: 0x00227B86 File Offset: 0x00225D86
		public override EVillageInfrBuildType Type
		{
			get
			{
				return (EVillageInfrBuildType)this.Instance.Type;
			}
		}

		// Token: 0x17004A69 RID: 19049
		// (get) Token: 0x0600EBF4 RID: 60404 RVA: 0x00227B93 File Offset: 0x00225D93
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x040081EC RID: 33260
		private IVillageInfrTreeProcess Instance;
	}
}
