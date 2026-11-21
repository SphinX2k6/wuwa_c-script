using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002130 RID: 8496
	public class ISwing : ILeisureInteractType
	{
		// Token: 0x0600B458 RID: 46168 RVA: 0x001942F0 File Offset: 0x001924F0
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

		// Token: 0x0600B459 RID: 46169 RVA: 0x00194328 File Offset: 0x00192528
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

		// Token: 0x0600B45A RID: 46170 RVA: 0x0019433B File Offset: 0x0019253B
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

		// Token: 0x0600B45B RID: 46171 RVA: 0x0019434E File Offset: 0x0019254E
		public new ISwing_SetValue ToSetValue()
		{
			return new ISwing_SetValue
			{
				Type = this.Type,
				SwingDa = this.SwingDa,
				EntityId = this.EntityId
			};
		}

		// Token: 0x17003673 RID: 13939
		// (get) Token: 0x0600B45C RID: 46172 RVA: 0x00194379 File Offset: 0x00192579
		// (set) Token: 0x0600B45D RID: 46173 RVA: 0x001943A4 File Offset: 0x001925A4
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

		// Token: 0x17003674 RID: 13940
		// (get) Token: 0x0600B45E RID: 46174 RVA: 0x001943B2 File Offset: 0x001925B2
		// (set) Token: 0x0600B45F RID: 46175 RVA: 0x001943DD File Offset: 0x001925DD
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

		// Token: 0x17003675 RID: 13941
		// (get) Token: 0x0600B460 RID: 46176 RVA: 0x001943EB File Offset: 0x001925EB
		// (set) Token: 0x0600B461 RID: 46177 RVA: 0x00194416 File Offset: 0x00192616
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

		// Token: 0x04006AC6 RID: 27334
		[Nullable(2)]
		protected new ISwing FbInstance;

		// Token: 0x04006AC7 RID: 27335
		[Nullable(2)]
		protected new ISwing_SetValue PocoInterface;
	}
}
