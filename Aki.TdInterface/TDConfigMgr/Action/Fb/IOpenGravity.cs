using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029B0 RID: 10672
	public class IOpenGravity : ISetTeleControlConfig
	{
		// Token: 0x0600EC18 RID: 60440 RVA: 0x00227EA8 File Offset: 0x002260A8
		[NullableContext(1)]
		public static IOpenGravity Create(IOpenGravity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenGravity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A7A RID: 19066
		// (get) Token: 0x0600EC19 RID: 60441 RVA: 0x00227EC7 File Offset: 0x002260C7
		public override ESetTeleControlType Type
		{
			get
			{
				return (ESetTeleControlType)this.Instance.Type;
			}
		}

		// Token: 0x17004A7B RID: 19067
		// (get) Token: 0x0600EC1A RID: 60442 RVA: 0x00227ED4 File Offset: 0x002260D4
		public override int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004A7C RID: 19068
		// (get) Token: 0x0600EC1B RID: 60443 RVA: 0x00227EE4 File Offset: 0x002260E4
		public virtual int? PositionEntityId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.PositionEntityId);
			}
		}

		// Token: 0x04008202 RID: 33282
		private IOpenGravity Instance;
	}
}
