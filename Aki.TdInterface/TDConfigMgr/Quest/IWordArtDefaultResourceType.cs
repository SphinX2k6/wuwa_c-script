using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001350 RID: 4944
	public class IWordArtDefaultResourceType : IWordArtResourceType
	{
		// Token: 0x06006F3D RID: 28477 RVA: 0x00107ED8 File Offset: 0x001060D8
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

		// Token: 0x06006F3E RID: 28478 RVA: 0x00107F10 File Offset: 0x00106110
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

		// Token: 0x06006F3F RID: 28479 RVA: 0x00107F23 File Offset: 0x00106123
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

		// Token: 0x06006F40 RID: 28480 RVA: 0x00107F36 File Offset: 0x00106136
		public new IWordArtDefaultResourceType_SetValue ToSetValue()
		{
			return new IWordArtDefaultResourceType_SetValue
			{
				Type = this.Type,
				Scale = this.Scale
			};
		}

		// Token: 0x170023A6 RID: 9126
		// (get) Token: 0x06006F41 RID: 28481 RVA: 0x00107F55 File Offset: 0x00106155
		// (set) Token: 0x06006F42 RID: 28482 RVA: 0x00107F80 File Offset: 0x00106180
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

		// Token: 0x170023A7 RID: 9127
		// (get) Token: 0x06006F43 RID: 28483 RVA: 0x00107F90 File Offset: 0x00106190
		// (set) Token: 0x06006F44 RID: 28484 RVA: 0x00107FCA File Offset: 0x001061CA
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

		// Token: 0x0400423A RID: 16954
		[Nullable(2)]
		protected new IWordArtDefaultResourceType FbInstance;

		// Token: 0x0400423B RID: 16955
		[Nullable(2)]
		protected new IWordArtDefaultResourceType_SetValue PocoInterface;
	}
}
