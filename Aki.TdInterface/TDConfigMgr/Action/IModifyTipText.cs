using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DDF RID: 7647
	public class IModifyTipText : IInteractEffect
	{
		// Token: 0x0600A259 RID: 41561 RVA: 0x001738B8 File Offset: 0x00171AB8
		private IModifyTipText_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IModifyTipText 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IModifyTipText_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IModifyTipText_SetValue());
			}
			return result;
		}

		// Token: 0x0600A25A RID: 41562 RVA: 0x001738F0 File Offset: 0x00171AF0
		public static IModifyTipText Create([Nullable(2)] IModifyTipText instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyTipText
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A25B RID: 41563 RVA: 0x00173903 File Offset: 0x00171B03
		public static IModifyTipText CreateFromSetValue([Nullable(2)] IModifyTipText_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IModifyTipText
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A25C RID: 41564 RVA: 0x00173916 File Offset: 0x00171B16
		public new IModifyTipText_SetValue ToSetValue()
		{
			return new IModifyTipText_SetValue
			{
				Type = this.Type,
				DelayTime = this.DelayTime,
				TipText = this.TipText
			};
		}

		// Token: 0x1700326C RID: 12908
		// (get) Token: 0x0600A25D RID: 41565 RVA: 0x00173941 File Offset: 0x00171B41
		// (set) Token: 0x0600A25E RID: 41566 RVA: 0x0017396C File Offset: 0x00171B6C
		public override EInteractEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractEffectType.ModifyTipText;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700326D RID: 12909
		// (get) Token: 0x0600A25F RID: 41567 RVA: 0x0017397C File Offset: 0x00171B7C
		// (set) Token: 0x0600A260 RID: 41568 RVA: 0x001739B6 File Offset: 0x00171BB6
		public override float? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				IModifyTipText_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x1700326E RID: 12910
		// (get) Token: 0x0600A261 RID: 41569 RVA: 0x001739C4 File Offset: 0x00171BC4
		// (set) Token: 0x0600A262 RID: 41570 RVA: 0x001739EF File Offset: 0x00171BEF
		public virtual string TipText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TipText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TipText;
			}
			set
			{
				this.GetOrCreatePoco().TipText = value;
			}
		}

		// Token: 0x04006271 RID: 25201
		[Nullable(2)]
		protected new IModifyTipText FbInstance;

		// Token: 0x04006272 RID: 25202
		[Nullable(2)]
		protected new IModifyTipText_SetValue PocoInterface;
	}
}
