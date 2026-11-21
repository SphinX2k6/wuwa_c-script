using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AD5 RID: 6869
	public class ICustomScreenBackgroundImage : ICustomScreenTypeBase
	{
		// Token: 0x060091EF RID: 37359 RVA: 0x0015634C File Offset: 0x0015454C
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

		// Token: 0x060091F0 RID: 37360 RVA: 0x00156384 File Offset: 0x00154584
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

		// Token: 0x060091F1 RID: 37361 RVA: 0x00156397 File Offset: 0x00154597
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

		// Token: 0x060091F2 RID: 37362 RVA: 0x001563AA File Offset: 0x001545AA
		public new ICustomScreenBackgroundImage_SetValue ToSetValue()
		{
			return new ICustomScreenBackgroundImage_SetValue
			{
				Type = this.Type,
				BackgroundImagePath = this.BackgroundImagePath
			};
		}

		// Token: 0x17002EC4 RID: 11972
		// (get) Token: 0x060091F3 RID: 37363 RVA: 0x001563C9 File Offset: 0x001545C9
		// (set) Token: 0x060091F4 RID: 37364 RVA: 0x001563F4 File Offset: 0x001545F4
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

		// Token: 0x17002EC5 RID: 11973
		// (get) Token: 0x060091F5 RID: 37365 RVA: 0x00156402 File Offset: 0x00154602
		// (set) Token: 0x060091F6 RID: 37366 RVA: 0x0015642D File Offset: 0x0015462D
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

		// Token: 0x04005AFB RID: 23291
		[Nullable(2)]
		protected new ICustomScreenBackgroundImage FbInstance;

		// Token: 0x04005AFC RID: 23292
		[Nullable(2)]
		protected new ICustomScreenBackgroundImage_SetValue PocoInterface;
	}
}
