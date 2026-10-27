using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D86 RID: 3462
	public class ISpawnConfigType
	{
		// Token: 0x06004EC2 RID: 20162 RVA: 0x000C3499 File Offset: 0x000C1699
		[NullableContext(1)]
		public static ISpawnConfigType Create(ISpawnConfigType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawnConfigType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x06004EC3 RID: 20163 RVA: 0x000C34B8 File Offset: 0x000C16B8
		public virtual ESpawnConfigType Type
		{
			get
			{
				return (ESpawnConfigType)this.Instance.Type;
			}
		}

		// Token: 0x04002D33 RID: 11571
		private ISpawnConfigType Instance;
	}
}
