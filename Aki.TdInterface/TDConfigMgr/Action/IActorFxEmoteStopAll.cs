using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018EF RID: 6383
	public class IActorFxEmoteStopAll : IActorFxEmoteStopSubType
	{
		// Token: 0x060085F5 RID: 34293 RVA: 0x0013F0F4 File Offset: 0x0013D2F4
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

		// Token: 0x060085F6 RID: 34294 RVA: 0x0013F12C File Offset: 0x0013D32C
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

		// Token: 0x060085F7 RID: 34295 RVA: 0x0013F13F File Offset: 0x0013D33F
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

		// Token: 0x060085F8 RID: 34296 RVA: 0x0013F152 File Offset: 0x0013D352
		public new IActorFxEmoteStopAll_SetValue ToSetValue()
		{
			return new IActorFxEmoteStopAll_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002BA0 RID: 11168
		// (get) Token: 0x060085F9 RID: 34297 RVA: 0x0013F165 File Offset: 0x0013D365
		// (set) Token: 0x060085FA RID: 34298 RVA: 0x0013F190 File Offset: 0x0013D390
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

		// Token: 0x04005507 RID: 21767
		[Nullable(2)]
		protected new IActorFxEmoteStopAll FbInstance;

		// Token: 0x04005508 RID: 21768
		[Nullable(2)]
		protected new IActorFxEmoteStopAll_SetValue PocoInterface;
	}
}
