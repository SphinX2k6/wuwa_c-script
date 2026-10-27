using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D90 RID: 7568
	[NullableContext(1)]
	[Nullable(0)]
	public class IReignsSetUiEffect : ActionParams
	{
		// Token: 0x0600A239 RID: 41529 RVA: 0x00171170 File Offset: 0x0016F370
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

		// Token: 0x0600A23A RID: 41530 RVA: 0x001711A8 File Offset: 0x0016F3A8
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

		// Token: 0x0600A23B RID: 41531 RVA: 0x001711BB File Offset: 0x0016F3BB
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

		// Token: 0x0600A23C RID: 41532 RVA: 0x001711CE File Offset: 0x0016F3CE
		public IReignsSetUiEffect_SetValue ToSetValue()
		{
			return new IReignsSetUiEffect_SetValue
			{
				Effect = this.Effect,
				IsVisible = this.IsVisible
			};
		}

		// Token: 0x1700321B RID: 12827
		// (get) Token: 0x0600A23D RID: 41533 RVA: 0x001711ED File Offset: 0x0016F3ED
		// (set) Token: 0x0600A23E RID: 41534 RVA: 0x00171218 File Offset: 0x0016F418
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

		// Token: 0x1700321C RID: 12828
		// (get) Token: 0x0600A23F RID: 41535 RVA: 0x00171226 File Offset: 0x0016F426
		// (set) Token: 0x0600A240 RID: 41536 RVA: 0x00171251 File Offset: 0x0016F451
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

		// Token: 0x04006178 RID: 24952
		[Nullable(2)]
		protected new IReignsSetUiEffect FbInstance;

		// Token: 0x04006179 RID: 24953
		[Nullable(2)]
		protected IReignsSetUiEffect_SetValue PocoInterface;
	}
}
