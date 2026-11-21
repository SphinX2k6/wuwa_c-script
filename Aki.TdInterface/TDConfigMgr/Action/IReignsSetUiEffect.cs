using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FA3 RID: 8099
	public class IReignsSetUiEffect : ActionParams
	{
		// Token: 0x0600AC31 RID: 44081 RVA: 0x001856DC File Offset: 0x001838DC
		private IReignsSetUiEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IReignsSetUiEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IReignsSetUiEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IReignsSetUiEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600AC32 RID: 44082 RVA: 0x00185714 File Offset: 0x00183914
		public static IReignsSetUiEffect Create([Nullable(2)] IReignsSetUiEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IReignsSetUiEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AC33 RID: 44083 RVA: 0x00185727 File Offset: 0x00183927
		public static IReignsSetUiEffect CreateFromSetValue([Nullable(2)] IReignsSetUiEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IReignsSetUiEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AC34 RID: 44084 RVA: 0x0018573A File Offset: 0x0018393A
		public IReignsSetUiEffect_SetValue ToSetValue()
		{
			return new IReignsSetUiEffect_SetValue
			{
				Effect = this.Effect,
				IsVisible = this.IsVisible
			};
		}

		// Token: 0x170034B2 RID: 13490
		// (get) Token: 0x0600AC35 RID: 44085 RVA: 0x00185759 File Offset: 0x00183959
		// (set) Token: 0x0600AC36 RID: 44086 RVA: 0x00185784 File Offset: 0x00183984
		public virtual string Effect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Effect;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Effect;
			}
			set
			{
				this.GetOrCreatePoco().Effect = value;
			}
		}

		// Token: 0x170034B3 RID: 13491
		// (get) Token: 0x0600AC37 RID: 44087 RVA: 0x00185792 File Offset: 0x00183992
		// (set) Token: 0x0600AC38 RID: 44088 RVA: 0x001857BD File Offset: 0x001839BD
		public virtual bool IsVisible
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsVisible;
				}
				return this.PocoInterface != null && this.PocoInterface.IsVisible;
			}
			set
			{
				this.GetOrCreatePoco().IsVisible = value;
			}
		}

		// Token: 0x040066F9 RID: 26361
		[Nullable(2)]
		protected new IReignsSetUiEffect FbInstance;

		// Token: 0x040066FA RID: 26362
		[Nullable(2)]
		protected IReignsSetUiEffect_SetValue PocoInterface;
	}
}
