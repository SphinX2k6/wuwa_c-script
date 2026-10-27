using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E1C RID: 3612
	public class IPathDrivenActorSpawnBase
	{
		// Token: 0x060051BD RID: 20925 RVA: 0x000C9912 File Offset: 0x000C7B12
		[NullableContext(1)]
		public static IPathDrivenActorSpawnBase Create(IPathDrivenActorSpawnBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPathDrivenActorSpawnBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B42 RID: 6978
		// (get) Token: 0x060051BE RID: 20926 RVA: 0x000C9931 File Offset: 0x000C7B31
		public virtual EPathDrivenActorSpawnType Type
		{
			get
			{
				return (EPathDrivenActorSpawnType)this.Instance.Type;
			}
		}

		// Token: 0x04002F13 RID: 12051
		private IPathDrivenActorSpawnBase Instance;
	}
}
