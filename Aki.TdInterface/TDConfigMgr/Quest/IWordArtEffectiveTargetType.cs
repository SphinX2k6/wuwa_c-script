using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001352 RID: 4946
	public class IWordArtEffectiveTargetType
	{
		// Token: 0x06006F47 RID: 28487 RVA: 0x00107FE8 File Offset: 0x001061E8
		private IWordArtEffectiveTargetType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWordArtEffectiveTargetType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWordArtEffectiveTargetType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWordArtEffectiveTargetType_SetValue());
			}
			return result;
		}

		// Token: 0x06006F48 RID: 28488 RVA: 0x00108020 File Offset: 0x00106220
		public static IWordArtEffectiveTargetType Create([Nullable(2)] IWordArtEffectiveTargetType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWordArtEffectiveTargetType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006F49 RID: 28489 RVA: 0x00108033 File Offset: 0x00106233
		public static IWordArtEffectiveTargetType CreateFromSetValue([Nullable(2)] IWordArtEffectiveTargetType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWordArtEffectiveTargetType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006F4A RID: 28490 RVA: 0x00108046 File Offset: 0x00106246
		public IWordArtEffectiveTargetType_SetValue ToSetValue()
		{
			return new IWordArtEffectiveTargetType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170023A8 RID: 9128
		// (get) Token: 0x06006F4B RID: 28491 RVA: 0x00108059 File Offset: 0x00106259
		// (set) Token: 0x06006F4C RID: 28492 RVA: 0x00108084 File Offset: 0x00106284
		public virtual EWordArtEffectiveTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EWordArtEffectiveTargetType.Number;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400423E RID: 16958
		[Nullable(2)]
		protected IWordArtEffectiveTargetType FbInstance;

		// Token: 0x0400423F RID: 16959
		[Nullable(2)]
		protected IWordArtEffectiveTargetType_SetValue PocoInterface;
	}
}
