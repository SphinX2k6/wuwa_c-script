using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200042C RID: 1068
	[NullableContext(1)]
	[Nullable(0)]
	public class IHitLogicType
	{
		// Token: 0x06001587 RID: 5511 RVA: 0x00043620 File Offset: 0x00041820
		private IHitLogicType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHitLogicType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHitLogicType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHitLogicType_SetValue());
			}
			return result;
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x00043658 File Offset: 0x00041858
		public static IHitLogicType Create([Nullable(2)] IHitLogicType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitLogicType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x0004366B File Offset: 0x0004186B
		public static IHitLogicType CreateFromSetValue([Nullable(2)] IHitLogicType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHitLogicType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x0004367E File Offset: 0x0004187E
		public IHitLogicType_SetValue ToSetValue()
		{
			return new IHitLogicType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x0600158B RID: 5515 RVA: 0x00043691 File Offset: 0x00041891
		// (set) Token: 0x0600158C RID: 5516 RVA: 0x000436BC File Offset: 0x000418BC
		public virtual EHitLogicType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHitLogicType.ChangeNextState;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040010A0 RID: 4256
		[Nullable(2)]
		protected IHitLogicType FbInstance;

		// Token: 0x040010A1 RID: 4257
		[Nullable(2)]
		protected IHitLogicType_SetValue PocoInterface;
	}
}
