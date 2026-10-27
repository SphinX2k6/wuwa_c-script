using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FC8 RID: 8136
	[NullableContext(1)]
	[Nullable(0)]
	public class IToggleAirWallType
	{
		// Token: 0x0600B2F6 RID: 45814 RVA: 0x001A0D94 File Offset: 0x0019EF94
		private IToggleAirWallType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IToggleAirWallType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IToggleAirWallType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IToggleAirWallType_SetValue());
			}
			return result;
		}

		// Token: 0x0600B2F7 RID: 45815 RVA: 0x001A0DCC File Offset: 0x0019EFCC
		public static IToggleAirWallType Create([Nullable(2)] IToggleAirWallType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IToggleAirWallType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B2F8 RID: 45816 RVA: 0x001A0DDF File Offset: 0x0019EFDF
		public static IToggleAirWallType CreateFromSetValue([Nullable(2)] IToggleAirWallType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IToggleAirWallType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B2F9 RID: 45817 RVA: 0x001A0DF2 File Offset: 0x0019EFF2
		public IToggleAirWallType_SetValue ToSetValue()
		{
			return new IToggleAirWallType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003727 RID: 14119
		// (get) Token: 0x0600B2FA RID: 45818 RVA: 0x001A0E05 File Offset: 0x0019F005
		// (set) Token: 0x0600B2FB RID: 45819 RVA: 0x001A0E30 File Offset: 0x0019F030
		public virtual EToggleAirWall Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EToggleAirWall.Open;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006C06 RID: 27654
		[Nullable(2)]
		protected IToggleAirWallType FbInstance;

		// Token: 0x04006C07 RID: 27655
		[Nullable(2)]
		protected IToggleAirWallType_SetValue PocoInterface;
	}
}
