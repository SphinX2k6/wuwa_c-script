using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BE0 RID: 7136
	[NullableContext(1)]
	[Nullable(0)]
	public class IModifyActorMaterialParamBySplineProgressConfig
	{
		// Token: 0x060098D3 RID: 39123 RVA: 0x0016004C File Offset: 0x0015E24C
		private IModifyActorMaterialParamBySplineProgressConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IModifyActorMaterialParamBySplineProgressConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IModifyActorMaterialParamBySplineProgressConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IModifyActorMaterialParamBySplineProgressConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060098D4 RID: 39124 RVA: 0x00160084 File Offset: 0x0015E284
		public static IModifyActorMaterialParamBySplineProgressConfig Create([Nullable(2)] IModifyActorMaterialParamBySplineProgressConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyActorMaterialParamBySplineProgressConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060098D5 RID: 39125 RVA: 0x00160097 File Offset: 0x0015E297
		public static IModifyActorMaterialParamBySplineProgressConfig CreateFromSetValue([Nullable(2)] IModifyActorMaterialParamBySplineProgressConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IModifyActorMaterialParamBySplineProgressConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060098D6 RID: 39126 RVA: 0x001600AA File Offset: 0x0015E2AA
		public IModifyActorMaterialParamBySplineProgressConfig_SetValue ToSetValue()
		{
			return new IModifyActorMaterialParamBySplineProgressConfig_SetValue
			{
				Type = this.Type,
				SplineEntityId = this.SplineEntityId
			};
		}

		// Token: 0x17002FF0 RID: 12272
		// (get) Token: 0x060098D7 RID: 39127 RVA: 0x001600C9 File Offset: 0x0015E2C9
		// (set) Token: 0x060098D8 RID: 39128 RVA: 0x001600F4 File Offset: 0x0015E2F4
		public virtual EModifyActorMaterialParamBySplineProgressType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EModifyActorMaterialParamBySplineProgressType.EnterSpline;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002FF1 RID: 12273
		// (get) Token: 0x060098D9 RID: 39129 RVA: 0x00160102 File Offset: 0x0015E302
		// (set) Token: 0x060098DA RID: 39130 RVA: 0x0016012D File Offset: 0x0015E32D
		public virtual int SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x04005D25 RID: 23845
		[Nullable(2)]
		protected IModifyActorMaterialParamBySplineProgressConfig FbInstance;

		// Token: 0x04005D26 RID: 23846
		[Nullable(2)]
		protected IModifyActorMaterialParamBySplineProgressConfig_SetValue PocoInterface;
	}
}
