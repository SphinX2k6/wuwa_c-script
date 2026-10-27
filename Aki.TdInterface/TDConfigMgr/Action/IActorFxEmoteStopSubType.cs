using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001772 RID: 6002
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorFxEmoteStopSubType
	{
		// Token: 0x06007F17 RID: 32535 RVA: 0x0013004C File Offset: 0x0012E24C
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

		// Token: 0x06007F18 RID: 32536 RVA: 0x00130084 File Offset: 0x0012E284
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

		// Token: 0x06007F19 RID: 32537 RVA: 0x00130097 File Offset: 0x0012E297
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

		// Token: 0x06007F1A RID: 32538 RVA: 0x001300AA File Offset: 0x0012E2AA
		public IActorFxEmoteStopSubType_SetValue ToSetValue()
		{
			return new IActorFxEmoteStopSubType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170029B5 RID: 10677
		// (get) Token: 0x06007F1B RID: 32539 RVA: 0x001300BD File Offset: 0x0012E2BD
		// (set) Token: 0x06007F1C RID: 32540 RVA: 0x001300E8 File Offset: 0x0012E2E8
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

		// Token: 0x040050D8 RID: 20696
		[Nullable(2)]
		protected IActorFxEmoteStopSubType FbInstance;

		// Token: 0x040050D9 RID: 20697
		[Nullable(2)]
		protected IActorFxEmoteStopSubType_SetValue PocoInterface;
	}
}
