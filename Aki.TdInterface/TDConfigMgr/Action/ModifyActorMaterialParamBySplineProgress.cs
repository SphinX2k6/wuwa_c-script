using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020D5 RID: 8405
	[NullableContext(1)]
	[Nullable(0)]
	public class ModifyActorMaterialParamBySplineProgress : ActionParams
	{
		// Token: 0x0600B8B0 RID: 47280 RVA: 0x001AB320 File Offset: 0x001A9520
		private ModifyActorMaterialParamBySplineProgress_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ModifyActorMaterialParamBySplineProgress 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ModifyActorMaterialParamBySplineProgress_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ModifyActorMaterialParamBySplineProgress_SetValue());
			}
			return result;
		}

		// Token: 0x0600B8B1 RID: 47281 RVA: 0x001AB358 File Offset: 0x001A9558
		public static ModifyActorMaterialParamBySplineProgress Create([Nullable(2)] ModifyActorMaterialParamBySplineProgress instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ModifyActorMaterialParamBySplineProgress
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B8B2 RID: 47282 RVA: 0x001AB36B File Offset: 0x001A956B
		public static ModifyActorMaterialParamBySplineProgress CreateFromSetValue([Nullable(2)] ModifyActorMaterialParamBySplineProgress_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ModifyActorMaterialParamBySplineProgress
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B8B3 RID: 47283 RVA: 0x001AB37E File Offset: 0x001A957E
		public ModifyActorMaterialParamBySplineProgress_SetValue ToSetValue()
		{
			return new ModifyActorMaterialParamBySplineProgress_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x17003871 RID: 14449
		// (get) Token: 0x0600B8B4 RID: 47284 RVA: 0x001AB391 File Offset: 0x001A9591
		// (set) Token: 0x0600B8B5 RID: 47285 RVA: 0x001AB3B8 File Offset: 0x001A95B8
		public virtual IModifyActorMaterialParamBySplineProgressConfig Config
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Config;
				}
				ModifyActorMaterialParamBySplineProgress_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Config;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
			}
		}

		// Token: 0x04006EA6 RID: 28326
		[Nullable(2)]
		protected new ModifyActorMaterialParamBySplineProgress FbInstance;

		// Token: 0x04006EA7 RID: 28327
		[Nullable(2)]
		protected ModifyActorMaterialParamBySplineProgress_SetValue PocoInterface;
	}
}
