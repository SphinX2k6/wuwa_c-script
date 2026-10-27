using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D3E RID: 7486
	[NullableContext(1)]
	[Nullable(0)]
	public class IPostAkEventType
	{
		// Token: 0x0600A0A5 RID: 41125 RVA: 0x0016E678 File Offset: 0x0016C878
		private IPostAkEventType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPostAkEventType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPostAkEventType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPostAkEventType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A0A6 RID: 41126 RVA: 0x0016E6B0 File Offset: 0x0016C8B0
		public static IPostAkEventType Create([Nullable(2)] IPostAkEventType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPostAkEventType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A0A7 RID: 41127 RVA: 0x0016E6C3 File Offset: 0x0016C8C3
		public static IPostAkEventType CreateFromSetValue([Nullable(2)] IPostAkEventType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPostAkEventType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A0A8 RID: 41128 RVA: 0x0016E6D6 File Offset: 0x0016C8D6
		public IPostAkEventType_SetValue ToSetValue()
		{
			return new IPostAkEventType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031CC RID: 12748
		// (get) Token: 0x0600A0A9 RID: 41129 RVA: 0x0016E6E9 File Offset: 0x0016C8E9
		// (set) Token: 0x0600A0AA RID: 41130 RVA: 0x0016E714 File Offset: 0x0016C914
		public virtual EPostAkEvent Type
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

		// Token: 0x040060CB RID: 24779
		[Nullable(2)]
		protected IPostAkEventType FbInstance;

		// Token: 0x040060CC RID: 24780
		[Nullable(2)]
		protected IPostAkEventType_SetValue PocoInterface;
	}
}
