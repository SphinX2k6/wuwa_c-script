using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002073 RID: 8307
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelMainRoleActionConfigBase
	{
		// Token: 0x0600B676 RID: 46710 RVA: 0x001A6FCC File Offset: 0x001A51CC
		private IVisualNovelMainRoleActionConfigBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelMainRoleActionConfigBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelMainRoleActionConfigBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelMainRoleActionConfigBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600B677 RID: 46711 RVA: 0x001A7004 File Offset: 0x001A5204
		public static IVisualNovelMainRoleActionConfigBase Create([Nullable(2)] IVisualNovelMainRoleActionConfigBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelMainRoleActionConfigBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B678 RID: 46712 RVA: 0x001A7017 File Offset: 0x001A5217
		public static IVisualNovelMainRoleActionConfigBase CreateFromSetValue([Nullable(2)] IVisualNovelMainRoleActionConfigBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelMainRoleActionConfigBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B679 RID: 46713 RVA: 0x001A702A File Offset: 0x001A522A
		public IVisualNovelMainRoleActionConfigBase_SetValue ToSetValue()
		{
			return new IVisualNovelMainRoleActionConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170037E7 RID: 14311
		// (get) Token: 0x0600B67A RID: 46714 RVA: 0x001A703D File Offset: 0x001A523D
		// (set) Token: 0x0600B67B RID: 46715 RVA: 0x001A7068 File Offset: 0x001A5268
		public virtual EVisualNovelSubType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelSubType.SolarSchool;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006D98 RID: 28056
		[Nullable(2)]
		protected IVisualNovelMainRoleActionConfigBase FbInstance;

		// Token: 0x04006D99 RID: 28057
		[Nullable(2)]
		protected IVisualNovelMainRoleActionConfigBase_SetValue PocoInterface;
	}
}
