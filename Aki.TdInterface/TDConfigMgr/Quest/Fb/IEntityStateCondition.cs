using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200135C RID: 4956
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityStateCondition
	{
		// Token: 0x06007178 RID: 29048 RVA: 0x00111749 File Offset: 0x0010F949
		public static IEntityStateCondition Create(IEntityStateCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityStateCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002493 RID: 9363
		// (get) Token: 0x06007179 RID: 29049 RVA: 0x00111768 File Offset: 0x0010F968
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17002494 RID: 9364
		// (get) Token: 0x0600717A RID: 29050 RVA: 0x00111775 File Offset: 0x0010F975
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x0400418C RID: 16780
		private IEntityStateCondition Instance;
	}
}
