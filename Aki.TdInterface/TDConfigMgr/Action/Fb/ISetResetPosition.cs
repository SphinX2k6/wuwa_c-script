using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029B1 RID: 10673
	public class ISetResetPosition : ISetTeleControlConfig
	{
		// Token: 0x0600EC1D RID: 60445 RVA: 0x00227F22 File Offset: 0x00226122
		[NullableContext(1)]
		public static ISetResetPosition Create(ISetResetPosition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetResetPosition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A7D RID: 19069
		// (get) Token: 0x0600EC1E RID: 60446 RVA: 0x00227F41 File Offset: 0x00226141
		public override ESetTeleControlType Type
		{
			get
			{
				return (ESetTeleControlType)this.Instance.Type;
			}
		}

		// Token: 0x17004A7E RID: 19070
		// (get) Token: 0x0600EC1F RID: 60447 RVA: 0x00227F4E File Offset: 0x0022614E
		public override int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004A7F RID: 19071
		// (get) Token: 0x0600EC20 RID: 60448 RVA: 0x00227F5B File Offset: 0x0022615B
		public virtual int PositionEntityId
		{
			get
			{
				return this.Instance.PositionEntityId;
			}
		}

		// Token: 0x04008203 RID: 33283
		private ISetResetPosition Instance;
	}
}
