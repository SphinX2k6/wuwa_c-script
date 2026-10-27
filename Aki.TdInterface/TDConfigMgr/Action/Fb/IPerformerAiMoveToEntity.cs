using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200298E RID: 10638
	public class IPerformerAiMoveToEntity : IPerformerAiMoveConfig
	{
		// Token: 0x0600EB8D RID: 60301 RVA: 0x0022731E File Offset: 0x0022551E
		[NullableContext(1)]
		public static IPerformerAiMoveToEntity Create(IPerformerAiMoveToEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPerformerAiMoveToEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A33 RID: 18995
		// (get) Token: 0x0600EB8E RID: 60302 RVA: 0x0022733D File Offset: 0x0022553D
		public override EPerformerAiMoveToType Type
		{
			get
			{
				return (EPerformerAiMoveToType)this.Instance.Type;
			}
		}

		// Token: 0x17004A34 RID: 18996
		// (get) Token: 0x0600EB8F RID: 60303 RVA: 0x0022734A File Offset: 0x0022554A
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x040081BA RID: 33210
		private IPerformerAiMoveToEntity Instance;
	}
}
