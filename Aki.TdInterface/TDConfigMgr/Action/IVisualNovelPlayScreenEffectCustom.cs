using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022E8 RID: 8936
	public class IVisualNovelPlayScreenEffectCustom : IVisualNovelPlayScreenEffectConfigBase
	{
		// Token: 0x0600C2C8 RID: 49864 RVA: 0x001BFE50 File Offset: 0x001BE050
		private IVisualNovelPlayScreenEffectCustom_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelPlayScreenEffectCustom 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelPlayScreenEffectCustom_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelPlayScreenEffectCustom_SetValue());
			}
			return result;
		}

		// Token: 0x0600C2C9 RID: 49865 RVA: 0x001BFE88 File Offset: 0x001BE088
		public static IVisualNovelPlayScreenEffectCustom Create([Nullable(2)] IVisualNovelPlayScreenEffectCustom instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPlayScreenEffectCustom
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C2CA RID: 49866 RVA: 0x001BFE9B File Offset: 0x001BE09B
		public static IVisualNovelPlayScreenEffectCustom CreateFromSetValue([Nullable(2)] IVisualNovelPlayScreenEffectCustom_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelPlayScreenEffectCustom
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C2CB RID: 49867 RVA: 0x001BFEAE File Offset: 0x001BE0AE
		public new IVisualNovelPlayScreenEffectCustom_SetValue ToSetValue()
		{
			return new IVisualNovelPlayScreenEffectCustom_SetValue
			{
				Type = this.Type,
				CustomType = this.CustomType
			};
		}

		// Token: 0x17003B18 RID: 15128
		// (get) Token: 0x0600C2CC RID: 49868 RVA: 0x001BFECD File Offset: 0x001BE0CD
		// (set) Token: 0x0600C2CD RID: 49869 RVA: 0x001BFEF8 File Offset: 0x001BE0F8
		public override EVisualNovelScreenEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelScreenEffectType.OneShot;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003B19 RID: 15129
		// (get) Token: 0x0600C2CE RID: 49870 RVA: 0x001BFF06 File Offset: 0x001BE106
		// (set) Token: 0x0600C2CF RID: 49871 RVA: 0x001BFF31 File Offset: 0x001BE131
		public virtual EVisualNovelScreenEffectCustomType CustomType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CustomType;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelScreenEffectCustomType.BurstEye;
				}
				return this.PocoInterface.CustomType;
			}
			set
			{
				this.GetOrCreatePoco().CustomType = value;
			}
		}

		// Token: 0x04007441 RID: 29761
		[Nullable(2)]
		protected new IVisualNovelPlayScreenEffectCustom FbInstance;

		// Token: 0x04007442 RID: 29762
		[Nullable(2)]
		protected new IVisualNovelPlayScreenEffectCustom_SetValue PocoInterface;
	}
}
