using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001354 RID: 4948
	public class IWordArtResourceType
	{
		// Token: 0x06006F4F RID: 28495 RVA: 0x001080A4 File Offset: 0x001062A4
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

		// Token: 0x06006F50 RID: 28496 RVA: 0x001080DC File Offset: 0x001062DC
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

		// Token: 0x06006F51 RID: 28497 RVA: 0x001080EF File Offset: 0x001062EF
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

		// Token: 0x06006F52 RID: 28498 RVA: 0x00108102 File Offset: 0x00106302
		public IWordArtResourceType_SetValue ToSetValue()
		{
			return new IWordArtResourceType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170023A9 RID: 9129
		// (get) Token: 0x06006F53 RID: 28499 RVA: 0x00108115 File Offset: 0x00106315
		// (set) Token: 0x06006F54 RID: 28500 RVA: 0x00108140 File Offset: 0x00106340
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

		// Token: 0x04004241 RID: 16961
		[Nullable(2)]
		protected IWordArtResourceType FbInstance;

		// Token: 0x04004242 RID: 16962
		[Nullable(2)]
		protected IWordArtResourceType_SetValue PocoInterface;
	}
}
