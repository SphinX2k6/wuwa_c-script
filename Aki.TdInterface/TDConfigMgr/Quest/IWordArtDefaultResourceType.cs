using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001214 RID: 4628
	[NullableContext(1)]
	[Nullable(0)]
	public class IWordArtDefaultResourceType : IWordArtResourceType
	{
		// Token: 0x060068FC RID: 26876 RVA: 0x000FA5CC File Offset: 0x000F87CC
		private IWordArtDefaultResourceType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWordArtDefaultResourceType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWordArtDefaultResourceType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWordArtDefaultResourceType_SetValue());
			}
			return result;
		}

		// Token: 0x060068FD RID: 26877 RVA: 0x000FA604 File Offset: 0x000F8804
		public static IWordArtDefaultResourceType Create([Nullable(2)] IWordArtDefaultResourceType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWordArtDefaultResourceType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060068FE RID: 26878 RVA: 0x000FA617 File Offset: 0x000F8817
		public static IWordArtDefaultResourceType CreateFromSetValue([Nullable(2)] IWordArtDefaultResourceType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWordArtDefaultResourceType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060068FF RID: 26879 RVA: 0x000FA62A File Offset: 0x000F882A
		public new IWordArtDefaultResourceType_SetValue ToSetValue()
		{
			return new IWordArtDefaultResourceType_SetValue
			{
				Type = this.Type,
				Scale = this.Scale
			};
		}

		// Token: 0x170021E5 RID: 8677
		// (get) Token: 0x06006900 RID: 26880 RVA: 0x000FA649 File Offset: 0x000F8849
		// (set) Token: 0x06006901 RID: 26881 RVA: 0x000FA674 File Offset: 0x000F8874
		public override EWordArtResourceType Type
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

		// Token: 0x170021E6 RID: 8678
		// (get) Token: 0x06006902 RID: 26882 RVA: 0x000FA684 File Offset: 0x000F8884
		// (set) Token: 0x06006903 RID: 26883 RVA: 0x000FA6BE File Offset: 0x000F88BE
		public virtual float? Scale
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Scale;
				}
				IWordArtDefaultResourceType_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Scale;
			}
			set
			{
				this.GetOrCreatePoco().Scale = value;
			}
		}

		// Token: 0x04003ECC RID: 16076
		[Nullable(2)]
		protected new IWordArtDefaultResourceType FbInstance;

		// Token: 0x04003ECD RID: 16077
		[Nullable(2)]
		protected new IWordArtDefaultResourceType_SetValue PocoInterface;
	}
}
