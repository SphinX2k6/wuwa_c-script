using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200225E RID: 8798
	public class IUiStyleGiantSubtitleOfLevelD : IUiStyleBaseOfLevelD
	{
		// Token: 0x0600BFB6 RID: 49078 RVA: 0x001BA41C File Offset: 0x001B861C
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

		// Token: 0x0600BFB7 RID: 49079 RVA: 0x001BA454 File Offset: 0x001B8654
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

		// Token: 0x0600BFB8 RID: 49080 RVA: 0x001BA467 File Offset: 0x001B8667
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

		// Token: 0x0600BFB9 RID: 49081 RVA: 0x001BA47A File Offset: 0x001B867A
		public new IUiStyleGiantSubtitleOfLevelD_SetValue ToSetValue()
		{
			return new IUiStyleGiantSubtitleOfLevelD_SetValue
			{
				Type = this.Type,
				Style = this.Style
			};
		}

		// Token: 0x17003A5E RID: 14942
		// (get) Token: 0x0600BFBA RID: 49082 RVA: 0x001BA499 File Offset: 0x001B8699
		// (set) Token: 0x0600BFBB RID: 49083 RVA: 0x001BA4C4 File Offset: 0x001B86C4
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

		// Token: 0x17003A5F RID: 14943
		// (get) Token: 0x0600BFBC RID: 49084 RVA: 0x001BA4D2 File Offset: 0x001B86D2
		// (set) Token: 0x0600BFBD RID: 49085 RVA: 0x001BA4FD File Offset: 0x001B86FD
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

		// Token: 0x040072D3 RID: 29395
		[Nullable(2)]
		protected new IUiStyleGiantSubtitleOfLevelD FbInstance;

		// Token: 0x040072D4 RID: 29396
		[Nullable(2)]
		protected new IUiStyleGiantSubtitleOfLevelD_SetValue PocoInterface;
	}
}
