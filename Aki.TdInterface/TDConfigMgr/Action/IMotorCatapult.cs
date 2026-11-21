using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E01 RID: 7681
	public class IMotorCatapult : ILeisureInteractType
	{
		// Token: 0x0600A341 RID: 41793 RVA: 0x00175628 File Offset: 0x00173828
		private IMotorCatapult_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorCatapult 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorCatapult_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorCatapult_SetValue());
			}
			return result;
		}

		// Token: 0x0600A342 RID: 41794 RVA: 0x00175660 File Offset: 0x00173860
		public static IMotorCatapult Create([Nullable(2)] IMotorCatapult instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorCatapult
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A343 RID: 41795 RVA: 0x00175673 File Offset: 0x00173873
		public static IMotorCatapult CreateFromSetValue([Nullable(2)] IMotorCatapult_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorCatapult
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A344 RID: 41796 RVA: 0x00175686 File Offset: 0x00173886
		public new IMotorCatapult_SetValue ToSetValue()
		{
			return new IMotorCatapult_SetValue
			{
				Type = this.Type,
				Param = this.Param,
				SkillType = this.SkillType
			};
		}

		// Token: 0x170032AD RID: 12973
		// (get) Token: 0x0600A345 RID: 41797 RVA: 0x001756B1 File Offset: 0x001738B1
		// (set) Token: 0x0600A346 RID: 41798 RVA: 0x001756DC File Offset: 0x001738DC
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170032AE RID: 12974
		// (get) Token: 0x0600A347 RID: 41799 RVA: 0x001756EC File Offset: 0x001738EC
		// (set) Token: 0x0600A348 RID: 41800 RVA: 0x0017574D File Offset: 0x0017394D
		public virtual IMotorCatapultParam Param
		{
			get
			{
				if (this._ParamInited)
				{
					return this._ParamCache;
				}
				this._ParamInited = true;
				if (this.FbInstance != null)
				{
					this._ParamCache = IMotorCatapultParam.Create(this.FbInstance.Param);
				}
				else
				{
					IMotorCatapult_SetValue pocoInterface = this.PocoInterface;
					this._ParamCache = ((pocoInterface != null) ? pocoInterface.Param : null);
				}
				return this._ParamCache;
			}
			set
			{
				this.GetOrCreatePoco().Param = value;
				this._ParamInited = false;
			}
		}

		// Token: 0x170032AF RID: 12975
		// (get) Token: 0x0600A349 RID: 41801 RVA: 0x00175764 File Offset: 0x00173964
		// (set) Token: 0x0600A34A RID: 41802 RVA: 0x0017579E File Offset: 0x0017399E
		public virtual EMotorCatapultSkillType? SkillType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkillType;
				}
				IMotorCatapult_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SkillType;
			}
			set
			{
				this.GetOrCreatePoco().SkillType = value;
			}
		}

		// Token: 0x040062E4 RID: 25316
		[Nullable(2)]
		protected new IMotorCatapult FbInstance;

		// Token: 0x040062E5 RID: 25317
		[Nullable(2)]
		protected new IMotorCatapult_SetValue PocoInterface;

		// Token: 0x040062E6 RID: 25318
		private IMotorCatapultParam _ParamCache;

		// Token: 0x040062E7 RID: 25319
		private bool _ParamInited;
	}
}
