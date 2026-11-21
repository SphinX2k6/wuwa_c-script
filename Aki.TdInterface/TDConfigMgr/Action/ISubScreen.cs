using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200210A RID: 8458
	public class ISubScreen : IScreenType
	{
		// Token: 0x0600B3A0 RID: 45984 RVA: 0x00192ECC File Offset: 0x001910CC
		private ISubScreen_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISubScreen 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISubScreen_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISubScreen_SetValue());
			}
			return result;
		}

		// Token: 0x0600B3A1 RID: 45985 RVA: 0x00192F04 File Offset: 0x00191104
		public static ISubScreen Create([Nullable(2)] ISubScreen instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreen
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B3A2 RID: 45986 RVA: 0x00192F17 File Offset: 0x00191117
		public static ISubScreen CreateFromSetValue([Nullable(2)] ISubScreen_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISubScreen
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B3A3 RID: 45987 RVA: 0x00192F2A File Offset: 0x0019112A
		public new ISubScreen_SetValue ToSetValue()
		{
			return new ISubScreen_SetValue
			{
				Type = this.Type,
				SubScreenKey = this.SubScreenKey
			};
		}

		// Token: 0x17003650 RID: 13904
		// (get) Token: 0x0600B3A4 RID: 45988 RVA: 0x00192F49 File Offset: 0x00191149
		// (set) Token: 0x0600B3A5 RID: 45989 RVA: 0x00192F74 File Offset: 0x00191174
		public override EScreenType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EScreenType.Main;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003651 RID: 13905
		// (get) Token: 0x0600B3A6 RID: 45990 RVA: 0x00192F82 File Offset: 0x00191182
		// (set) Token: 0x0600B3A7 RID: 45991 RVA: 0x00192FAD File Offset: 0x001911AD
		public virtual string SubScreenKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SubScreenKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SubScreenKey;
			}
			set
			{
				this.GetOrCreatePoco().SubScreenKey = value;
			}
		}

		// Token: 0x04006A71 RID: 27249
		[Nullable(2)]
		protected new ISubScreen FbInstance;

		// Token: 0x04006A72 RID: 27250
		[Nullable(2)]
		protected new ISubScreen_SetValue PocoInterface;
	}
}
