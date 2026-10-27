using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200176E RID: 5998
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorFxEmoteStopAll : IActorFxEmoteStopSubType
	{
		// Token: 0x06007F05 RID: 32517 RVA: 0x0012FE94 File Offset: 0x0012E094
		private IActorFxEmoteStopAll_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorFxEmoteStopAll 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorFxEmoteStopAll_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorFxEmoteStopAll_SetValue());
			}
			return result;
		}

		// Token: 0x06007F06 RID: 32518 RVA: 0x0012FECC File Offset: 0x0012E0CC
		public static IActorFxEmoteStopAll Create([Nullable(2)] IActorFxEmoteStopAll instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFxEmoteStopAll
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007F07 RID: 32519 RVA: 0x0012FEDF File Offset: 0x0012E0DF
		public static IActorFxEmoteStopAll CreateFromSetValue([Nullable(2)] IActorFxEmoteStopAll_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorFxEmoteStopAll
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007F08 RID: 32520 RVA: 0x0012FEF2 File Offset: 0x0012E0F2
		public new IActorFxEmoteStopAll_SetValue ToSetValue()
		{
			return new IActorFxEmoteStopAll_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170029B2 RID: 10674
		// (get) Token: 0x06007F09 RID: 32521 RVA: 0x0012FF05 File Offset: 0x0012E105
		// (set) Token: 0x06007F0A RID: 32522 RVA: 0x0012FF30 File Offset: 0x0012E130
		public override EActorFxEmoteStopSubType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EActorFxEmoteStopSubType.StopAll;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040050D1 RID: 20689
		[Nullable(2)]
		protected new IActorFxEmoteStopAll FbInstance;

		// Token: 0x040050D2 RID: 20690
		[Nullable(2)]
		protected new IActorFxEmoteStopAll_SetValue PocoInterface;
	}
}
