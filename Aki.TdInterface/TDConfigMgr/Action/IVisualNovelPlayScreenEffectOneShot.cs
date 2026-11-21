using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022EA RID: 8938
	public class IVisualNovelPlayScreenEffectOneShot : IVisualNovelPlayScreenEffectConfigBase
	{
		// Token: 0x0600C2D2 RID: 49874 RVA: 0x001BFF50 File Offset: 0x001BE150
		private IVisualNovelPlayScreenEffectOneShot_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelPlayScreenEffectOneShot 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelPlayScreenEffectOneShot_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelPlayScreenEffectOneShot_SetValue());
			}
			return result;
		}

		// Token: 0x0600C2D3 RID: 49875 RVA: 0x001BFF88 File Offset: 0x001BE188
		public static IVisualNovelPlayScreenEffectOneShot Create([Nullable(2)] IVisualNovelPlayScreenEffectOneShot instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPlayScreenEffectOneShot
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C2D4 RID: 49876 RVA: 0x001BFF9B File Offset: 0x001BE19B
		public static IVisualNovelPlayScreenEffectOneShot CreateFromSetValue([Nullable(2)] IVisualNovelPlayScreenEffectOneShot_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelPlayScreenEffectOneShot
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C2D5 RID: 49877 RVA: 0x001BFFAE File Offset: 0x001BE1AE
		public new IVisualNovelPlayScreenEffectOneShot_SetValue ToSetValue()
		{
			return new IVisualNovelPlayScreenEffectOneShot_SetValue
			{
				Type = this.Type,
				OneShotEffectPath = this.OneShotEffectPath
			};
		}

		// Token: 0x17003B1A RID: 15130
		// (get) Token: 0x0600C2D6 RID: 49878 RVA: 0x001BFFCD File Offset: 0x001BE1CD
		// (set) Token: 0x0600C2D7 RID: 49879 RVA: 0x001BFFF8 File Offset: 0x001BE1F8
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

		// Token: 0x17003B1B RID: 15131
		// (get) Token: 0x0600C2D8 RID: 49880 RVA: 0x001C0006 File Offset: 0x001BE206
		// (set) Token: 0x0600C2D9 RID: 49881 RVA: 0x001C0031 File Offset: 0x001BE231
		public virtual string OneShotEffectPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OneShotEffectPath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.OneShotEffectPath;
			}
			set
			{
				this.GetOrCreatePoco().OneShotEffectPath = value;
			}
		}

		// Token: 0x04007445 RID: 29765
		[Nullable(2)]
		protected new IVisualNovelPlayScreenEffectOneShot FbInstance;

		// Token: 0x04007446 RID: 29766
		[Nullable(2)]
		protected new IVisualNovelPlayScreenEffectOneShot_SetValue PocoInterface;
	}
}
