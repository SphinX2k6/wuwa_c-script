using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F4F RID: 8015
	public class IPostAkEventType
	{
		// Token: 0x0600AA91 RID: 43665 RVA: 0x00182A9C File Offset: 0x00180C9C
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

		// Token: 0x0600AA92 RID: 43666 RVA: 0x00182AD4 File Offset: 0x00180CD4
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

		// Token: 0x0600AA93 RID: 43667 RVA: 0x00182AE7 File Offset: 0x00180CE7
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

		// Token: 0x0600AA94 RID: 43668 RVA: 0x00182AFA File Offset: 0x00180CFA
		public IPostAkEventType_SetValue ToSetValue()
		{
			return new IPostAkEventType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003460 RID: 13408
		// (get) Token: 0x0600AA95 RID: 43669 RVA: 0x00182B0D File Offset: 0x00180D0D
		// (set) Token: 0x0600AA96 RID: 43670 RVA: 0x00182B38 File Offset: 0x00180D38
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

		// Token: 0x04006647 RID: 26183
		[Nullable(2)]
		protected IPostAkEventType FbInstance;

		// Token: 0x04006648 RID: 26184
		[Nullable(2)]
		protected IPostAkEventType_SetValue PocoInterface;
	}
}
