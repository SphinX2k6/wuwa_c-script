using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002015 RID: 8213
	[NullableContext(1)]
	[Nullable(0)]
	public class IUiStyleGiantSubtitleOfLevelD : IUiStyleBaseOfLevelD
	{
		// Token: 0x0600B494 RID: 46228 RVA: 0x001A3D58 File Offset: 0x001A1F58
		private IUiStyleGiantSubtitleOfLevelD_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUiStyleGiantSubtitleOfLevelD 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUiStyleGiantSubtitleOfLevelD_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUiStyleGiantSubtitleOfLevelD_SetValue());
			}
			return result;
		}

		// Token: 0x0600B495 RID: 46229 RVA: 0x001A3D90 File Offset: 0x001A1F90
		public static IUiStyleGiantSubtitleOfLevelD Create([Nullable(2)] IUiStyleGiantSubtitleOfLevelD instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUiStyleGiantSubtitleOfLevelD
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B496 RID: 46230 RVA: 0x001A3DA3 File Offset: 0x001A1FA3
		public static IUiStyleGiantSubtitleOfLevelD CreateFromSetValue([Nullable(2)] IUiStyleGiantSubtitleOfLevelD_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUiStyleGiantSubtitleOfLevelD
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B497 RID: 46231 RVA: 0x001A3DB6 File Offset: 0x001A1FB6
		public new IUiStyleGiantSubtitleOfLevelD_SetValue ToSetValue()
		{
			return new IUiStyleGiantSubtitleOfLevelD_SetValue
			{
				Type = this.Type,
				Style = this.Style
			};
		}

		// Token: 0x17003783 RID: 14211
		// (get) Token: 0x0600B498 RID: 46232 RVA: 0x001A3DD5 File Offset: 0x001A1FD5
		// (set) Token: 0x0600B499 RID: 46233 RVA: 0x001A3E00 File Offset: 0x001A2000
		public override EUiStyleTypeOfLevelD Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EUiStyleTypeOfLevelD.GiantSubtitle;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003784 RID: 14212
		// (get) Token: 0x0600B49A RID: 46234 RVA: 0x001A3E0E File Offset: 0x001A200E
		// (set) Token: 0x0600B49B RID: 46235 RVA: 0x001A3E39 File Offset: 0x001A2039
		public virtual EGiantSubtitleStyle Style
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Style;
				}
				if (this.PocoInterface == null)
				{
					return EGiantSubtitleStyle.Neutral;
				}
				return this.PocoInterface.Style;
			}
			set
			{
				this.GetOrCreatePoco().Style = value;
			}
		}

		// Token: 0x04006CCC RID: 27852
		[Nullable(2)]
		protected new IUiStyleGiantSubtitleOfLevelD FbInstance;

		// Token: 0x04006CCD RID: 27853
		[Nullable(2)]
		protected new IUiStyleGiantSubtitleOfLevelD_SetValue PocoInterface;
	}
}
