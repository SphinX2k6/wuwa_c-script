using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018F3 RID: 6387
	public class IActorFxEmoteStopSubType
	{
		// Token: 0x06008607 RID: 34311 RVA: 0x0013F2AC File Offset: 0x0013D4AC
		private IActorFxEmoteStopSubType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorFxEmoteStopSubType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorFxEmoteStopSubType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorFxEmoteStopSubType_SetValue());
			}
			return result;
		}

		// Token: 0x06008608 RID: 34312 RVA: 0x0013F2E4 File Offset: 0x0013D4E4
		public static IActorFxEmoteStopSubType Create([Nullable(2)] IActorFxEmoteStopSubType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFxEmoteStopSubType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008609 RID: 34313 RVA: 0x0013F2F7 File Offset: 0x0013D4F7
		public static IActorFxEmoteStopSubType CreateFromSetValue([Nullable(2)] IActorFxEmoteStopSubType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorFxEmoteStopSubType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600860A RID: 34314 RVA: 0x0013F30A File Offset: 0x0013D50A
		public IActorFxEmoteStopSubType_SetValue ToSetValue()
		{
			return new IActorFxEmoteStopSubType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002BA3 RID: 11171
		// (get) Token: 0x0600860B RID: 34315 RVA: 0x0013F31D File Offset: 0x0013D51D
		// (set) Token: 0x0600860C RID: 34316 RVA: 0x0013F348 File Offset: 0x0013D548
		public virtual EActorFxEmoteStopSubType Type
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

		// Token: 0x0400550E RID: 21774
		[Nullable(2)]
		protected IActorFxEmoteStopSubType FbInstance;

		// Token: 0x0400550F RID: 21775
		[Nullable(2)]
		protected IActorFxEmoteStopSubType_SetValue PocoInterface;
	}
}
