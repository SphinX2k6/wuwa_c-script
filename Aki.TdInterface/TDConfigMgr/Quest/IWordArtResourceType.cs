using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001218 RID: 4632
	[NullableContext(1)]
	[Nullable(0)]
	public class IWordArtResourceType
	{
		// Token: 0x0600690E RID: 26894 RVA: 0x000FA798 File Offset: 0x000F8998
		private IWordArtResourceType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWordArtResourceType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWordArtResourceType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWordArtResourceType_SetValue());
			}
			return result;
		}

		// Token: 0x0600690F RID: 26895 RVA: 0x000FA7D0 File Offset: 0x000F89D0
		public static IWordArtResourceType Create([Nullable(2)] IWordArtResourceType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWordArtResourceType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006910 RID: 26896 RVA: 0x000FA7E3 File Offset: 0x000F89E3
		public static IWordArtResourceType CreateFromSetValue([Nullable(2)] IWordArtResourceType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWordArtResourceType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006911 RID: 26897 RVA: 0x000FA7F6 File Offset: 0x000F89F6
		public IWordArtResourceType_SetValue ToSetValue()
		{
			return new IWordArtResourceType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021E8 RID: 8680
		// (get) Token: 0x06006912 RID: 26898 RVA: 0x000FA809 File Offset: 0x000F8A09
		// (set) Token: 0x06006913 RID: 26899 RVA: 0x000FA834 File Offset: 0x000F8A34
		public virtual EWordArtResourceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EWordArtResourceType.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003ED3 RID: 16083
		[Nullable(2)]
		protected IWordArtResourceType FbInstance;

		// Token: 0x04003ED4 RID: 16084
		[Nullable(2)]
		protected IWordArtResourceType_SetValue PocoInterface;
	}
}
