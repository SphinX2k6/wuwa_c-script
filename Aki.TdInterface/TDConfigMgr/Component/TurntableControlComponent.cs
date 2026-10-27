using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008D2 RID: 2258
	[NullableContext(1)]
	[Nullable(0)]
	public class TurntableControlComponent : IComponentBase
	{
		// Token: 0x06003311 RID: 13073 RVA: 0x00082FC0 File Offset: 0x000811C0
		private TurntableControlComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TurntableControlComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TurntableControlComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TurntableControlComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x00082FF8 File Offset: 0x000811F8
		public static TurntableControlComponent Create([Nullable(2)] TurntableControlComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TurntableControlComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x0008300B File Offset: 0x0008120B
		public static TurntableControlComponent CreateFromSetValue([Nullable(2)] TurntableControlComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TurntableControlComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x0008301E File Offset: 0x0008121E
		public new TurntableControlComponent_SetValue ToSetValue()
		{
			return new TurntableControlComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Config = this.Config
			};
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x06003315 RID: 13077 RVA: 0x0008304C File Offset: 0x0008124C
		// (set) Token: 0x06003316 RID: 13078 RVA: 0x00083086 File Offset: 0x00081286
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				TurntableControlComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x06003317 RID: 13079 RVA: 0x00083094 File Offset: 0x00081294
		// (set) Token: 0x06003318 RID: 13080 RVA: 0x000830BE File Offset: 0x000812BE
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

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06003319 RID: 13081 RVA: 0x000830CC File Offset: 0x000812CC
		// (set) Token: 0x0600331A RID: 13082 RVA: 0x000830F3 File Offset: 0x000812F3
		public virtual ITurntableControlType Config
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Config;
				}
				TurntableControlComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04002186 RID: 8582
		[Nullable(2)]
		protected new TurntableControlComponent FbInstance;

		// Token: 0x04002187 RID: 8583
		[Nullable(2)]
		protected new TurntableControlComponent_SetValue PocoInterface;
	}
}
