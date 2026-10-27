using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BF0 RID: 7152
	[NullableContext(1)]
	[Nullable(0)]
	public class IModifyTipText : IInteractEffect
	{
		// Token: 0x0600992B RID: 39211 RVA: 0x001609C0 File Offset: 0x0015EBC0
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

		// Token: 0x0600992C RID: 39212 RVA: 0x001609F8 File Offset: 0x0015EBF8
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

		// Token: 0x0600992D RID: 39213 RVA: 0x00160A0B File Offset: 0x0015EC0B
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

		// Token: 0x0600992E RID: 39214 RVA: 0x00160A1E File Offset: 0x0015EC1E
		public new IModifyTipText_SetValue ToSetValue()
		{
			return new IModifyTipText_SetValue
			{
				Type = this.Type,
				DelayTime = this.DelayTime,
				TipText = this.TipText
			};
		}

		// Token: 0x17003004 RID: 12292
		// (get) Token: 0x0600992F RID: 39215 RVA: 0x00160A49 File Offset: 0x0015EC49
		// (set) Token: 0x06009930 RID: 39216 RVA: 0x00160A74 File Offset: 0x0015EC74
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

		// Token: 0x17003005 RID: 12293
		// (get) Token: 0x06009931 RID: 39217 RVA: 0x00160A84 File Offset: 0x0015EC84
		// (set) Token: 0x06009932 RID: 39218 RVA: 0x00160ABE File Offset: 0x0015ECBE
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

		// Token: 0x17003006 RID: 12294
		// (get) Token: 0x06009933 RID: 39219 RVA: 0x00160ACC File Offset: 0x0015ECCC
		// (set) Token: 0x06009934 RID: 39220 RVA: 0x00160AF7 File Offset: 0x0015ECF7
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

		// Token: 0x04005D4B RID: 23883
		[Nullable(2)]
		protected new IModifyTipText FbInstance;

		// Token: 0x04005D4C RID: 23884
		[Nullable(2)]
		protected new IModifyTipText_SetValue PocoInterface;
	}
}
