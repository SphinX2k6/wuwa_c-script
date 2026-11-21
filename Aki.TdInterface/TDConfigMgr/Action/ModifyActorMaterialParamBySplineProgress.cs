using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002332 RID: 9010
	public class ModifyActorMaterialParamBySplineProgress : ActionParams
	{
		// Token: 0x0600C428 RID: 50216 RVA: 0x001C2248 File Offset: 0x001C0448
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

		// Token: 0x0600C429 RID: 50217 RVA: 0x001C2280 File Offset: 0x001C0480
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

		// Token: 0x0600C42A RID: 50218 RVA: 0x001C2293 File Offset: 0x001C0493
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

		// Token: 0x0600C42B RID: 50219 RVA: 0x001C22A6 File Offset: 0x001C04A6
		public ModifyActorMaterialParamBySplineProgress_SetValue ToSetValue()
		{
			return new ModifyActorMaterialParamBySplineProgress_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x17003B59 RID: 15193
		// (get) Token: 0x0600C42C RID: 50220 RVA: 0x001C22B9 File Offset: 0x001C04B9
		// (set) Token: 0x0600C42D RID: 50221 RVA: 0x001C22E0 File Offset: 0x001C04E0
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

		// Token: 0x040074D0 RID: 29904
		[Nullable(2)]
		protected new ModifyActorMaterialParamBySplineProgress FbInstance;

		// Token: 0x040074D1 RID: 29905
		[Nullable(2)]
		protected ModifyActorMaterialParamBySplineProgress_SetValue PocoInterface;
	}
}
