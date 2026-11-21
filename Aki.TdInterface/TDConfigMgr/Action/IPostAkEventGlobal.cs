using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F47 RID: 8007
	public class IPostAkEventGlobal : IPostAkEventType
	{
		// Token: 0x0600AA5F RID: 43615 RVA: 0x001824D8 File Offset: 0x001806D8
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

		// Token: 0x0600AA60 RID: 43616 RVA: 0x00182510 File Offset: 0x00180710
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

		// Token: 0x0600AA61 RID: 43617 RVA: 0x00182523 File Offset: 0x00180723
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

		// Token: 0x0600AA62 RID: 43618 RVA: 0x00182536 File Offset: 0x00180736
		public new IPostAkEventGlobal_SetValue ToSetValue()
		{
			return new IPostAkEventGlobal_SetValue
			{
				Type = this.Type,
				AkEvent = this.AkEvent
			};
		}

		// Token: 0x17003453 RID: 13395
		// (get) Token: 0x0600AA63 RID: 43619 RVA: 0x00182555 File Offset: 0x00180755
		// (set) Token: 0x0600AA64 RID: 43620 RVA: 0x00182580 File Offset: 0x00180780
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

		// Token: 0x17003454 RID: 13396
		// (get) Token: 0x0600AA65 RID: 43621 RVA: 0x0018258E File Offset: 0x0018078E
		// (set) Token: 0x0600AA66 RID: 43622 RVA: 0x001825B9 File Offset: 0x001807B9
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

		// Token: 0x04006630 RID: 26160
		[Nullable(2)]
		protected new IPostAkEventGlobal FbInstance;

		// Token: 0x04006631 RID: 26161
		[Nullable(2)]
		protected new IPostAkEventGlobal_SetValue PocoInterface;
	}
}
