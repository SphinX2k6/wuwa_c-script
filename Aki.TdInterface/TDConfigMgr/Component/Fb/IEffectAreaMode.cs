using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D0B RID: 3339
	public class IEffectAreaMode
	{
		// Token: 0x06004C3F RID: 19519 RVA: 0x000BE13A File Offset: 0x000BC33A
		[NullableContext(1)]
		public static IEffectAreaMode Create(IEffectAreaMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEffectAreaMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x06004C40 RID: 19520 RVA: 0x000BE159 File Offset: 0x000BC359
		public virtual EEffectAreaType Type
		{
			get
			{
				return (EEffectAreaType)this.Instance.Type;
			}
		}

		// Token: 0x04002BA4 RID: 11172
		private IEffectAreaMode Instance;
	}
}
