using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D36 RID: 7478
	[NullableContext(1)]
	[Nullable(0)]
	public class IPostAkEventGlobal : IPostAkEventType
	{
		// Token: 0x0600A073 RID: 41075 RVA: 0x0016E0B4 File Offset: 0x0016C2B4
		private IPostAkEventGlobal_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPostAkEventGlobal 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPostAkEventGlobal_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPostAkEventGlobal_SetValue());
			}
			return result;
		}

		// Token: 0x0600A074 RID: 41076 RVA: 0x0016E0EC File Offset: 0x0016C2EC
		public static IPostAkEventGlobal Create([Nullable(2)] IPostAkEventGlobal instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPostAkEventGlobal
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A075 RID: 41077 RVA: 0x0016E0FF File Offset: 0x0016C2FF
		public static IPostAkEventGlobal CreateFromSetValue([Nullable(2)] IPostAkEventGlobal_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPostAkEventGlobal
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A076 RID: 41078 RVA: 0x0016E112 File Offset: 0x0016C312
		public new IPostAkEventGlobal_SetValue ToSetValue()
		{
			return new IPostAkEventGlobal_SetValue
			{
				Type = this.Type,
				AkEvent = this.AkEvent
			};
		}

		// Token: 0x170031BF RID: 12735
		// (get) Token: 0x0600A077 RID: 41079 RVA: 0x0016E131 File Offset: 0x0016C331
		// (set) Token: 0x0600A078 RID: 41080 RVA: 0x0016E15C File Offset: 0x0016C35C
		public override EPostAkEvent Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPostAkEvent.Global;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170031C0 RID: 12736
		// (get) Token: 0x0600A079 RID: 41081 RVA: 0x0016E16A File Offset: 0x0016C36A
		// (set) Token: 0x0600A07A RID: 41082 RVA: 0x0016E195 File Offset: 0x0016C395
		public virtual string AkEvent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AkEvent;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.AkEvent;
			}
			set
			{
				this.GetOrCreatePoco().AkEvent = value;
			}
		}

		// Token: 0x040060B4 RID: 24756
		[Nullable(2)]
		protected new IPostAkEventGlobal FbInstance;

		// Token: 0x040060B5 RID: 24757
		[Nullable(2)]
		protected new IPostAkEventGlobal_SetValue PocoInterface;
	}
}
