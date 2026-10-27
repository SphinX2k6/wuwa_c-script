using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F1C RID: 7964
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkBackgroundImage : ITalkBackground
	{
		// Token: 0x0600AA44 RID: 43588 RVA: 0x0017F744 File Offset: 0x0017D944
		private ITalkBackgroundImage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkBackgroundImage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkBackgroundImage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkBackgroundImage_SetValue());
			}
			return result;
		}

		// Token: 0x0600AA45 RID: 43589 RVA: 0x0017F77C File Offset: 0x0017D97C
		public static ITalkBackgroundImage Create([Nullable(2)] ITalkBackgroundImage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkBackgroundImage
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AA46 RID: 43590 RVA: 0x0017F78F File Offset: 0x0017D98F
		public static ITalkBackgroundImage CreateFromSetValue([Nullable(2)] ITalkBackgroundImage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkBackgroundImage
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AA47 RID: 43591 RVA: 0x0017F7A2 File Offset: 0x0017D9A2
		public new ITalkBackgroundImage_SetValue ToSetValue()
		{
			return new ITalkBackgroundImage_SetValue
			{
				Type = this.Type,
				ImageAsset = this.ImageAsset
			};
		}

		// Token: 0x170033D0 RID: 13264
		// (get) Token: 0x0600AA48 RID: 43592 RVA: 0x0017F7C1 File Offset: 0x0017D9C1
		// (set) Token: 0x0600AA49 RID: 43593 RVA: 0x0017F7EC File Offset: 0x0017D9EC
		public override ETalkBackgroundType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkBackgroundType.Clean;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170033D1 RID: 13265
		// (get) Token: 0x0600AA4A RID: 43594 RVA: 0x0017F7FA File Offset: 0x0017D9FA
		// (set) Token: 0x0600AA4B RID: 43595 RVA: 0x0017F825 File Offset: 0x0017DA25
		public virtual string ImageAsset
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ImageAsset;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ImageAsset;
			}
			set
			{
				this.GetOrCreatePoco().ImageAsset = value;
			}
		}

		// Token: 0x04006528 RID: 25896
		[Nullable(2)]
		protected new ITalkBackgroundImage FbInstance;

		// Token: 0x04006529 RID: 25897
		[Nullable(2)]
		protected new ITalkBackgroundImage_SetValue PocoInterface;
	}
}
