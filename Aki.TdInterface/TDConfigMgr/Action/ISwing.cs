using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EF7 RID: 7927
	[NullableContext(1)]
	[Nullable(0)]
	public class ISwing : ILeisureInteractType
	{
		// Token: 0x0600A986 RID: 43398 RVA: 0x0017E2F8 File Offset: 0x0017C4F8
		private ISwing_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISwing 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISwing_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISwing_SetValue());
			}
			return result;
		}

		// Token: 0x0600A987 RID: 43399 RVA: 0x0017E330 File Offset: 0x0017C530
		public static ISwing Create([Nullable(2)] ISwing instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwing
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A988 RID: 43400 RVA: 0x0017E343 File Offset: 0x0017C543
		public static ISwing CreateFromSetValue([Nullable(2)] ISwing_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISwing
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A989 RID: 43401 RVA: 0x0017E356 File Offset: 0x0017C556
		public new ISwing_SetValue ToSetValue()
		{
			return new ISwing_SetValue
			{
				Type = this.Type,
				SwingDa = this.SwingDa,
				EntityId = this.EntityId
			};
		}

		// Token: 0x170033A8 RID: 13224
		// (get) Token: 0x0600A98A RID: 43402 RVA: 0x0017E381 File Offset: 0x0017C581
		// (set) Token: 0x0600A98B RID: 43403 RVA: 0x0017E3AC File Offset: 0x0017C5AC
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170033A9 RID: 13225
		// (get) Token: 0x0600A98C RID: 43404 RVA: 0x0017E3BA File Offset: 0x0017C5BA
		// (set) Token: 0x0600A98D RID: 43405 RVA: 0x0017E3E5 File Offset: 0x0017C5E5
		public virtual string SwingDa
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SwingDa;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SwingDa;
			}
			set
			{
				this.GetOrCreatePoco().SwingDa = value;
			}
		}

		// Token: 0x170033AA RID: 13226
		// (get) Token: 0x0600A98E RID: 43406 RVA: 0x0017E3F3 File Offset: 0x0017C5F3
		// (set) Token: 0x0600A98F RID: 43407 RVA: 0x0017E41E File Offset: 0x0017C61E
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x040064D7 RID: 25815
		[Nullable(2)]
		protected new ISwing FbInstance;

		// Token: 0x040064D8 RID: 25816
		[Nullable(2)]
		protected new ISwing_SetValue PocoInterface;
	}
}
