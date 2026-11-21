using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D05 RID: 7429
	public class IInteractPointInteraction
	{
		// Token: 0x06009DC5 RID: 40389 RVA: 0x0016B2DC File Offset: 0x001694DC
		private IInteractPointInteraction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractPointInteraction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractPointInteraction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractPointInteraction_SetValue());
			}
			return result;
		}

		// Token: 0x06009DC6 RID: 40390 RVA: 0x0016B314 File Offset: 0x00169514
		public static IInteractPointInteraction Create([Nullable(2)] IInteractPointInteraction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractPointInteraction
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009DC7 RID: 40391 RVA: 0x0016B327 File Offset: 0x00169527
		public static IInteractPointInteraction CreateFromSetValue([Nullable(2)] IInteractPointInteraction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractPointInteraction
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009DC8 RID: 40392 RVA: 0x0016B33A File Offset: 0x0016953A
		public IInteractPointInteraction_SetValue ToSetValue()
		{
			return new IInteractPointInteraction_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003169 RID: 12649
		// (get) Token: 0x06009DC9 RID: 40393 RVA: 0x0016B34D File Offset: 0x0016954D
		// (set) Token: 0x06009DCA RID: 40394 RVA: 0x0016B378 File Offset: 0x00169578
		public virtual EInteractPointInteractionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractPointInteractionType.Drag;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400604E RID: 24654
		[Nullable(2)]
		protected IInteractPointInteraction FbInstance;

		// Token: 0x0400604F RID: 24655
		[Nullable(2)]
		protected IInteractPointInteraction_SetValue PocoInterface;
	}
}
