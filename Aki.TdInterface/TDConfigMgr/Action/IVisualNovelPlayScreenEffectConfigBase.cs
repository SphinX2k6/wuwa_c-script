using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022E6 RID: 8934
	public class IVisualNovelPlayScreenEffectConfigBase
	{
		// Token: 0x0600C2C0 RID: 49856 RVA: 0x001BFD94 File Offset: 0x001BDF94
		private IVisualNovelPlayScreenEffectConfigBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelPlayScreenEffectConfigBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelPlayScreenEffectConfigBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelPlayScreenEffectConfigBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600C2C1 RID: 49857 RVA: 0x001BFDCC File Offset: 0x001BDFCC
		public static IVisualNovelPlayScreenEffectConfigBase Create([Nullable(2)] IVisualNovelPlayScreenEffectConfigBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPlayScreenEffectConfigBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C2C2 RID: 49858 RVA: 0x001BFDDF File Offset: 0x001BDFDF
		public static IVisualNovelPlayScreenEffectConfigBase CreateFromSetValue([Nullable(2)] IVisualNovelPlayScreenEffectConfigBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelPlayScreenEffectConfigBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C2C3 RID: 49859 RVA: 0x001BFDF2 File Offset: 0x001BDFF2
		public IVisualNovelPlayScreenEffectConfigBase_SetValue ToSetValue()
		{
			return new IVisualNovelPlayScreenEffectConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003B17 RID: 15127
		// (get) Token: 0x0600C2C4 RID: 49860 RVA: 0x001BFE05 File Offset: 0x001BE005
		// (set) Token: 0x0600C2C5 RID: 49861 RVA: 0x001BFE30 File Offset: 0x001BE030
		public virtual EVisualNovelScreenEffectType Type
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

		// Token: 0x0400743E RID: 29758
		[Nullable(2)]
		protected IVisualNovelPlayScreenEffectConfigBase FbInstance;

		// Token: 0x0400743F RID: 29759
		[Nullable(2)]
		protected IVisualNovelPlayScreenEffectConfigBase_SetValue PocoInterface;
	}
}
