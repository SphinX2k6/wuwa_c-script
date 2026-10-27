using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B3A RID: 2874
	public class ITriggerCountConfig
	{
		// Token: 0x06004251 RID: 16977 RVA: 0x000A9C90 File Offset: 0x000A7E90
		[NullableContext(1)]
		public static ITriggerCountConfig Create(ITriggerCountConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggerCountConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x06004252 RID: 16978 RVA: 0x000A9CAF File Offset: 0x000A7EAF
		public virtual int TriggerCount
		{
			get
			{
				return this.Instance.TriggerCount;
			}
		}

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x06004253 RID: 16979 RVA: 0x000A9CBC File Offset: 0x000A7EBC
		public virtual float TriggerInterval
		{
			get
			{
				return this.Instance.TriggerInterval;
			}
		}

		// Token: 0x04002563 RID: 9571
		private ITriggerCountConfig Instance;
	}
}
