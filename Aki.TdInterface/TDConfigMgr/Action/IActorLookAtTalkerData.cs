using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200178C RID: 6028
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorLookAtTalkerData : IActorLookAtLockable
	{
		// Token: 0x06007F9F RID: 32671 RVA: 0x00130FA0 File Offset: 0x0012F1A0
		private IActorLookAtTalkerData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorLookAtTalkerData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorLookAtTalkerData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorLookAtTalkerData_SetValue());
			}
			return result;
		}

		// Token: 0x06007FA0 RID: 32672 RVA: 0x00130FD8 File Offset: 0x0012F1D8
		public static IActorLookAtTalkerData Create([Nullable(2)] IActorLookAtTalkerData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAtTalkerData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007FA1 RID: 32673 RVA: 0x00130FEB File Offset: 0x0012F1EB
		public static IActorLookAtTalkerData CreateFromSetValue([Nullable(2)] IActorLookAtTalkerData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorLookAtTalkerData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007FA2 RID: 32674 RVA: 0x00130FFE File Offset: 0x0012F1FE
		public new IActorLookAtTalkerData_SetValue ToSetValue()
		{
			return new IActorLookAtTalkerData_SetValue
			{
				Type = this.Type,
				Lock = this.Lock
			};
		}

		// Token: 0x170029D2 RID: 10706
		// (get) Token: 0x06007FA3 RID: 32675 RVA: 0x0013101D File Offset: 0x0012F21D
		// (set) Token: 0x06007FA4 RID: 32676 RVA: 0x00131048 File Offset: 0x0012F248
		public override EActorLookAtMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EActorLookAtMode.Talker;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170029D3 RID: 10707
		// (get) Token: 0x06007FA5 RID: 32677 RVA: 0x00131058 File Offset: 0x0012F258
		// (set) Token: 0x06007FA6 RID: 32678 RVA: 0x00131092 File Offset: 0x0012F292
		public override bool? Lock
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Lock;
				}
				IActorLookAtTalkerData_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Lock;
			}
			set
			{
				this.GetOrCreatePoco().Lock = value;
			}
		}

		// Token: 0x04005117 RID: 20759
		[Nullable(2)]
		protected new IActorLookAtTalkerData FbInstance;

		// Token: 0x04005118 RID: 20760
		[Nullable(2)]
		protected new IActorLookAtTalkerData_SetValue PocoInterface;
	}
}
