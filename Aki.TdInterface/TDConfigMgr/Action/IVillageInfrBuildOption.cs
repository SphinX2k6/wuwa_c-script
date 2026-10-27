using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200204B RID: 8267
	[NullableContext(1)]
	[Nullable(0)]
	public class IVillageInfrBuildOption
	{
		// Token: 0x0600B5AA RID: 46506 RVA: 0x001A5AE8 File Offset: 0x001A3CE8
		private IVillageInfrBuildOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVillageInfrBuildOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVillageInfrBuildOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVillageInfrBuildOption_SetValue());
			}
			return result;
		}

		// Token: 0x0600B5AB RID: 46507 RVA: 0x001A5B20 File Offset: 0x001A3D20
		public static IVillageInfrBuildOption Create([Nullable(2)] IVillageInfrBuildOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVillageInfrBuildOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B5AC RID: 46508 RVA: 0x001A5B33 File Offset: 0x001A3D33
		public static IVillageInfrBuildOption CreateFromSetValue([Nullable(2)] IVillageInfrBuildOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVillageInfrBuildOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B5AD RID: 46509 RVA: 0x001A5B46 File Offset: 0x001A3D46
		public IVillageInfrBuildOption_SetValue ToSetValue()
		{
			return new IVillageInfrBuildOption_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170037BD RID: 14269
		// (get) Token: 0x0600B5AE RID: 46510 RVA: 0x001A5B59 File Offset: 0x001A3D59
		// (set) Token: 0x0600B5AF RID: 46511 RVA: 0x001A5B84 File Offset: 0x001A3D84
		public virtual EVillageInfrBuildType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVillageInfrBuildType.Village;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006D44 RID: 27972
		[Nullable(2)]
		protected IVillageInfrBuildOption FbInstance;

		// Token: 0x04006D45 RID: 27973
		[Nullable(2)]
		protected IVillageInfrBuildOption_SetValue PocoInterface;
	}
}
