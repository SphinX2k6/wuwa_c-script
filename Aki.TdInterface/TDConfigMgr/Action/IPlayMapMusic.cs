using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D16 RID: 7446
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayMapMusic : IAkEventMapType
	{
		// Token: 0x06009FBB RID: 40891 RVA: 0x0016CB3C File Offset: 0x0016AD3C
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

		// Token: 0x06009FBC RID: 40892 RVA: 0x0016CB74 File Offset: 0x0016AD74
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

		// Token: 0x06009FBD RID: 40893 RVA: 0x0016CB87 File Offset: 0x0016AD87
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

		// Token: 0x06009FBE RID: 40894 RVA: 0x0016CB9A File Offset: 0x0016AD9A
		public new IPlayMapMusic_SetValue ToSetValue()
		{
			return new IPlayMapMusic_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003193 RID: 12691
		// (get) Token: 0x06009FBF RID: 40895 RVA: 0x0016CBAD File Offset: 0x0016ADAD
		// (set) Token: 0x06009FC0 RID: 40896 RVA: 0x0016CBD8 File Offset: 0x0016ADD8
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

		// Token: 0x0400605C RID: 24668
		[Nullable(2)]
		protected new IPlayMapMusic FbInstance;

		// Token: 0x0400605D RID: 24669
		[Nullable(2)]
		protected new IPlayMapMusic_SetValue PocoInterface;
	}
}
