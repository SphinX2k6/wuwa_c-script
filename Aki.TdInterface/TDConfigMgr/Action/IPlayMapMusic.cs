using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F27 RID: 7975
	public class IPlayMapMusic : IAkEventMapType
	{
		// Token: 0x0600A9A7 RID: 43431 RVA: 0x00180F60 File Offset: 0x0017F160
		private IPlayMapMusic_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayMapMusic 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayMapMusic_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayMapMusic_SetValue());
			}
			return result;
		}

		// Token: 0x0600A9A8 RID: 43432 RVA: 0x00180F98 File Offset: 0x0017F198
		public static IPlayMapMusic Create([Nullable(2)] IPlayMapMusic instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayMapMusic
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A9A9 RID: 43433 RVA: 0x00180FAB File Offset: 0x0017F1AB
		public static IPlayMapMusic CreateFromSetValue([Nullable(2)] IPlayMapMusic_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayMapMusic
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A9AA RID: 43434 RVA: 0x00180FBE File Offset: 0x0017F1BE
		public new IPlayMapMusic_SetValue ToSetValue()
		{
			return new IPlayMapMusic_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003427 RID: 13351
		// (get) Token: 0x0600A9AB RID: 43435 RVA: 0x00180FD1 File Offset: 0x0017F1D1
		// (set) Token: 0x0600A9AC RID: 43436 RVA: 0x00180FFC File Offset: 0x0017F1FC
		public override EAkEventMap Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAkEventMap.PlayMapMusic;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040065D8 RID: 26072
		[Nullable(2)]
		protected new IPlayMapMusic FbInstance;

		// Token: 0x040065D9 RID: 26073
		[Nullable(2)]
		protected new IPlayMapMusic_SetValue PocoInterface;
	}
}
