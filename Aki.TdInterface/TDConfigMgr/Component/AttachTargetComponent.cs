using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000024 RID: 36
	[NullableContext(2)]
	[Nullable(0)]
	public class AttachTargetComponent : IComponentBase
	{
		// Token: 0x060000D4 RID: 212 RVA: 0x000157E8 File Offset: 0x000139E8
		[NullableContext(1)]
		private AttachTargetComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AttachTargetComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AttachTargetComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AttachTargetComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00015820 File Offset: 0x00013A20
		[NullableContext(1)]
		public static AttachTargetComponent Create([Nullable(2)] AttachTargetComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AttachTargetComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00015833 File Offset: 0x00013A33
		[NullableContext(1)]
		public static AttachTargetComponent CreateFromSetValue([Nullable(2)] AttachTargetComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AttachTargetComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00015848 File Offset: 0x00013A48
		[NullableContext(1)]
		public new AttachTargetComponent_SetValue ToSetValue()
		{
			return new AttachTargetComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				AttachTarget = this.AttachTarget,
				PosRule = this.PosRule,
				RotRule = this.RotRule,
				AttachTiming = this.AttachTiming
			};
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x000158A4 File Offset: 0x00013AA4
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x000158DE File Offset: 0x00013ADE
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				AttachTargetComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000DA RID: 218 RVA: 0x000158EC File Offset: 0x00013AEC
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00015916 File Offset: 0x00013B16
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00015924 File Offset: 0x00013B24
		// (set) Token: 0x060000DD RID: 221 RVA: 0x0001594B File Offset: 0x00013B4B
		public virtual IAttachTarget AttachTarget
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AttachTarget;
				}
				AttachTargetComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AttachTarget;
			}
			set
			{
				this.GetOrCreatePoco().AttachTarget = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0001595C File Offset: 0x00013B5C
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00015996 File Offset: 0x00013B96
		public virtual EAttachRuleType? PosRule
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PosRule;
				}
				AttachTargetComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PosRule;
			}
			set
			{
				this.GetOrCreatePoco().PosRule = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x000159A4 File Offset: 0x00013BA4
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x000159DE File Offset: 0x00013BDE
		public virtual EAttachRuleType? RotRule
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RotRule;
				}
				AttachTargetComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RotRule;
			}
			set
			{
				this.GetOrCreatePoco().RotRule = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000159EC File Offset: 0x00013BEC
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00015A13 File Offset: 0x00013C13
		public virtual IAttachTiming AttachTiming
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AttachTiming;
				}
				AttachTargetComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AttachTiming;
			}
			set
			{
				this.GetOrCreatePoco().AttachTiming = value;
			}
		}

		// Token: 0x0400008B RID: 139
		protected new AttachTargetComponent FbInstance;

		// Token: 0x0400008C RID: 140
		protected new AttachTargetComponent_SetValue PocoInterface;
	}
}
