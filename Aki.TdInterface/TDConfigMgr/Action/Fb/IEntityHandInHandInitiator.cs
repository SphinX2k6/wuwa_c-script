using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A58 RID: 10840
	public class IEntityHandInHandInitiator : IHandInHandInitiatorType
	{
		// Token: 0x0600EE7A RID: 61050 RVA: 0x0022B606 File Offset: 0x00229806
		[NullableContext(1)]
		public static IEntityHandInHandInitiator Create(IEntityHandInHandInitiator? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityHandInHandInitiator
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B8C RID: 19340
		// (get) Token: 0x0600EE7B RID: 61051 RVA: 0x0022B625 File Offset: 0x00229825
		public override EHandInHandInitiatorType Type
		{
			get
			{
				return (EHandInHandInitiatorType)this.Instance.Type;
			}
		}

		// Token: 0x17004B8D RID: 19341
		// (get) Token: 0x0600EE7C RID: 61052 RVA: 0x0022B632 File Offset: 0x00229832
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04008334 RID: 33588
		private IEntityHandInHandInitiator Instance;
	}
}
