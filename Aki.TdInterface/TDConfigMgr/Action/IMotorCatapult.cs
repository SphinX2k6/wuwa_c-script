using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C12 RID: 7186
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorCatapult : ILeisureInteractType
	{
		// Token: 0x06009A11 RID: 39441 RVA: 0x001626DC File Offset: 0x001608DC
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

		// Token: 0x06009A12 RID: 39442 RVA: 0x00162714 File Offset: 0x00160914
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

		// Token: 0x06009A13 RID: 39443 RVA: 0x00162727 File Offset: 0x00160927
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

		// Token: 0x06009A14 RID: 39444 RVA: 0x0016273A File Offset: 0x0016093A
		public new IMotorCatapult_SetValue ToSetValue()
		{
			return new IMotorCatapult_SetValue
			{
				Type = this.Type,
				Param = this.Param,
				SkillType = this.SkillType
			};
		}

		// Token: 0x17003044 RID: 12356
		// (get) Token: 0x06009A15 RID: 39445 RVA: 0x00162765 File Offset: 0x00160965
		// (set) Token: 0x06009A16 RID: 39446 RVA: 0x00162790 File Offset: 0x00160990
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

		// Token: 0x17003045 RID: 12357
		// (get) Token: 0x06009A17 RID: 39447 RVA: 0x001627A0 File Offset: 0x001609A0
		// (set) Token: 0x06009A18 RID: 39448 RVA: 0x00162801 File Offset: 0x00160A01
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

		// Token: 0x17003046 RID: 12358
		// (get) Token: 0x06009A19 RID: 39449 RVA: 0x00162818 File Offset: 0x00160A18
		// (set) Token: 0x06009A1A RID: 39450 RVA: 0x00162852 File Offset: 0x00160A52
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

		// Token: 0x04005DBD RID: 23997
		[Nullable(2)]
		protected new IMotorCatapult FbInstance;

		// Token: 0x04005DBE RID: 23998
		[Nullable(2)]
		protected new IMotorCatapult_SetValue PocoInterface;

		// Token: 0x04005DBF RID: 23999
		private IMotorCatapultParam _ParamCache;

		// Token: 0x04005DC0 RID: 24000
		private bool _ParamInited;
	}
}
