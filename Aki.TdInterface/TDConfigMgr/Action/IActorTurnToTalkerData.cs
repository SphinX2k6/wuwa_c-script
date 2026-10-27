using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017A0 RID: 6048
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorTurnToTalkerData : IActorTurnToData
	{
		// Token: 0x06008001 RID: 32769 RVA: 0x00131AA4 File Offset: 0x0012FCA4
		private IActorTurnToTalkerData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorTurnToTalkerData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorTurnToTalkerData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorTurnToTalkerData_SetValue());
			}
			return result;
		}

		// Token: 0x06008002 RID: 32770 RVA: 0x00131ADC File Offset: 0x0012FCDC
		public static IActorTurnToTalkerData Create([Nullable(2)] IActorTurnToTalkerData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorTurnToTalkerData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008003 RID: 32771 RVA: 0x00131AEF File Offset: 0x0012FCEF
		public static IActorTurnToTalkerData CreateFromSetValue([Nullable(2)] IActorTurnToTalkerData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorTurnToTalkerData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008004 RID: 32772 RVA: 0x00131B02 File Offset: 0x0012FD02
		public new IActorTurnToTalkerData_SetValue ToSetValue()
		{
			return new IActorTurnToTalkerData_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170029E5 RID: 10725
		// (get) Token: 0x06008005 RID: 32773 RVA: 0x00131B15 File Offset: 0x0012FD15
		// (set) Token: 0x06008006 RID: 32774 RVA: 0x00131B40 File Offset: 0x0012FD40
		public override EActorTurnToMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EActorTurnToMode.Talker;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005146 RID: 20806
		[Nullable(2)]
		protected new IActorTurnToTalkerData FbInstance;

		// Token: 0x04005147 RID: 20807
		[Nullable(2)]
		protected new IActorTurnToTalkerData_SetValue PocoInterface;
	}
}
