using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AC1 RID: 2753
	public class IEntityBatchType
	{
		// Token: 0x06003F6C RID: 16236 RVA: 0x000A204E File Offset: 0x000A024E
		[NullableContext(1)]
		public static IEntityBatchType Create(IEntityBatchType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityBatchType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06003F6D RID: 16237 RVA: 0x000A206D File Offset: 0x000A026D
		public virtual EEntityBatchType Type
		{
			get
			{
				return (EEntityBatchType)this.Instance.Type;
			}
		}

		// Token: 0x0400233C RID: 9020
		private IEntityBatchType Instance;
	}
}
