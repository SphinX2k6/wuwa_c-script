using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E3D RID: 7741
	public class IMp4BackgroundColor
	{
		// Token: 0x0600A49F RID: 42143 RVA: 0x00177EB4 File Offset: 0x001760B4
		private IMp4BackgroundColor_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMp4BackgroundColor 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMp4BackgroundColor_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMp4BackgroundColor_SetValue());
			}
			return result;
		}

		// Token: 0x0600A4A0 RID: 42144 RVA: 0x00177EEC File Offset: 0x001760EC
		public static IMp4BackgroundColor Create([Nullable(2)] IMp4BackgroundColor instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMp4BackgroundColor
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A4A1 RID: 42145 RVA: 0x00177EFF File Offset: 0x001760FF
		public static IMp4BackgroundColor CreateFromSetValue([Nullable(2)] IMp4BackgroundColor_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMp4BackgroundColor
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A4A2 RID: 42146 RVA: 0x00177F12 File Offset: 0x00176112
		public IMp4BackgroundColor_SetValue ToSetValue()
		{
			return new IMp4BackgroundColor_SetValue
			{
				FadeIn = this.FadeIn,
				FadeOut = this.FadeOut
			};
		}

		// Token: 0x17003302 RID: 13058
		// (get) Token: 0x0600A4A3 RID: 42147 RVA: 0x00177F31 File Offset: 0x00176131
		// (set) Token: 0x0600A4A4 RID: 42148 RVA: 0x00177F5C File Offset: 0x0017615C
		public virtual EMp4BackgroundColor FadeIn
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeIn;
				}
				if (this.PocoInterface == null)
				{
					return EMp4BackgroundColor.Black;
				}
				return this.PocoInterface.FadeIn;
			}
			set
			{
				this.GetOrCreatePoco().FadeIn = value;
			}
		}

		// Token: 0x17003303 RID: 13059
		// (get) Token: 0x0600A4A5 RID: 42149 RVA: 0x00177F6A File Offset: 0x0017616A
		// (set) Token: 0x0600A4A6 RID: 42150 RVA: 0x00177F95 File Offset: 0x00176195
		public virtual EMp4BackgroundColor FadeOut
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeOut;
				}
				if (this.PocoInterface == null)
				{
					return EMp4BackgroundColor.Black;
				}
				return this.PocoInterface.FadeOut;
			}
			set
			{
				this.GetOrCreatePoco().FadeOut = value;
			}
		}

		// Token: 0x0400638B RID: 25483
		[Nullable(2)]
		protected IMp4BackgroundColor FbInstance;

		// Token: 0x0400638C RID: 25484
		[Nullable(2)]
		protected IMp4BackgroundColor_SetValue PocoInterface;
	}
}
