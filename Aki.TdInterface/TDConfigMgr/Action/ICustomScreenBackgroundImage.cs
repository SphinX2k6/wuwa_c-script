using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200194A RID: 6474
	[NullableContext(1)]
	[Nullable(0)]
	public class ICustomScreenBackgroundImage : ICustomScreenTypeBase
	{
		// Token: 0x06008ABB RID: 35515 RVA: 0x00146950 File Offset: 0x00144B50
		private ICustomScreenBackgroundImage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomScreenBackgroundImage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomScreenBackgroundImage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomScreenBackgroundImage_SetValue());
			}
			return result;
		}

		// Token: 0x06008ABC RID: 35516 RVA: 0x00146988 File Offset: 0x00144B88
		public static ICustomScreenBackgroundImage Create([Nullable(2)] ICustomScreenBackgroundImage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomScreenBackgroundImage
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008ABD RID: 35517 RVA: 0x0014699B File Offset: 0x00144B9B
		public static ICustomScreenBackgroundImage CreateFromSetValue([Nullable(2)] ICustomScreenBackgroundImage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomScreenBackgroundImage
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008ABE RID: 35518 RVA: 0x001469AE File Offset: 0x00144BAE
		public new ICustomScreenBackgroundImage_SetValue ToSetValue()
		{
			return new ICustomScreenBackgroundImage_SetValue
			{
				Type = this.Type,
				BackgroundImagePath = this.BackgroundImagePath
			};
		}

		// Token: 0x17002CC3 RID: 11459
		// (get) Token: 0x06008ABF RID: 35519 RVA: 0x001469CD File Offset: 0x00144BCD
		// (set) Token: 0x06008AC0 RID: 35520 RVA: 0x001469F8 File Offset: 0x00144BF8
		public override ECustomScreenType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECustomScreenType.Spine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002CC4 RID: 11460
		// (get) Token: 0x06008AC1 RID: 35521 RVA: 0x00146A06 File Offset: 0x00144C06
		// (set) Token: 0x06008AC2 RID: 35522 RVA: 0x00146A31 File Offset: 0x00144C31
		public virtual string BackgroundImagePath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BackgroundImagePath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.BackgroundImagePath;
			}
			set
			{
				this.GetOrCreatePoco().BackgroundImagePath = value;
			}
		}

		// Token: 0x040056A8 RID: 22184
		[Nullable(2)]
		protected new ICustomScreenBackgroundImage FbInstance;

		// Token: 0x040056A9 RID: 22185
		[Nullable(2)]
		protected new ICustomScreenBackgroundImage_SetValue PocoInterface;
	}
}
