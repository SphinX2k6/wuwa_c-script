using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C46 RID: 7238
	[NullableContext(1)]
	[Nullable(0)]
	public class IMp4BackgroundColor
	{
		// Token: 0x06009B47 RID: 39751 RVA: 0x00164B74 File Offset: 0x00162D74
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

		// Token: 0x06009B48 RID: 39752 RVA: 0x00164BAC File Offset: 0x00162DAC
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

		// Token: 0x06009B49 RID: 39753 RVA: 0x00164BBF File Offset: 0x00162DBF
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

		// Token: 0x06009B4A RID: 39754 RVA: 0x00164BD2 File Offset: 0x00162DD2
		public IMp4BackgroundColor_SetValue ToSetValue()
		{
			return new IMp4BackgroundColor_SetValue
			{
				FadeIn = this.FadeIn,
				FadeOut = this.FadeOut
			};
		}

		// Token: 0x17003091 RID: 12433
		// (get) Token: 0x06009B4B RID: 39755 RVA: 0x00164BF1 File Offset: 0x00162DF1
		// (set) Token: 0x06009B4C RID: 39756 RVA: 0x00164C1C File Offset: 0x00162E1C
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

		// Token: 0x17003092 RID: 12434
		// (get) Token: 0x06009B4D RID: 39757 RVA: 0x00164C2A File Offset: 0x00162E2A
		// (set) Token: 0x06009B4E RID: 39758 RVA: 0x00164C55 File Offset: 0x00162E55
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

		// Token: 0x04005E54 RID: 24148
		[Nullable(2)]
		protected IMp4BackgroundColor FbInstance;

		// Token: 0x04005E55 RID: 24149
		[Nullable(2)]
		protected IMp4BackgroundColor_SetValue PocoInterface;
	}
}
