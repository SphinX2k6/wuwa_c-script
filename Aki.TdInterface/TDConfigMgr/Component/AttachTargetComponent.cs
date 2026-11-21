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
		// Token: 0x060000D8 RID: 216 RVA: 0x0001615C File Offset: 0x0001435C
		[NullableContext(0)]
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

		// Token: 0x060000D9 RID: 217 RVA: 0x00016194 File Offset: 0x00014394
		[NullableContext(0)]
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

		// Token: 0x060000DA RID: 218 RVA: 0x000161A7 File Offset: 0x000143A7
		[NullableContext(0)]
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

		// Token: 0x060000DB RID: 219 RVA: 0x000161BC File Offset: 0x000143BC
		[NullableContext(0)]
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

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00016218 File Offset: 0x00014418
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00016252 File Offset: 0x00014452
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

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00016260 File Offset: 0x00014460
		// (set) Token: 0x060000DF RID: 223 RVA: 0x0001628A File Offset: 0x0001448A
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

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00016298 File Offset: 0x00014498
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x000162BF File Offset: 0x000144BF
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

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000162D0 File Offset: 0x000144D0
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x0001630A File Offset: 0x0001450A
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

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00016318 File Offset: 0x00014518
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x00016352 File Offset: 0x00014552
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

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00016360 File Offset: 0x00014560
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00016387 File Offset: 0x00014587
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

		// Token: 0x04000090 RID: 144
		protected new AttachTargetComponent FbInstance;

		// Token: 0x04000091 RID: 145
		protected new AttachTargetComponent_SetValue PocoInterface;
	}
}
