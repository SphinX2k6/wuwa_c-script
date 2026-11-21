using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D51 RID: 7505
	public class ILiveDanmakuTrackCountParam : ILiveParamConfig
	{
		// Token: 0x06009F5B RID: 40795 RVA: 0x0016E00C File Offset: 0x0016C20C
		private ILiveDanmakuTrackCountParam_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveDanmakuTrackCountParam 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveDanmakuTrackCountParam_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveDanmakuTrackCountParam_SetValue());
			}
			return result;
		}

		// Token: 0x06009F5C RID: 40796 RVA: 0x0016E044 File Offset: 0x0016C244
		public static ILiveDanmakuTrackCountParam Create([Nullable(2)] ILiveDanmakuTrackCountParam instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveDanmakuTrackCountParam
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009F5D RID: 40797 RVA: 0x0016E057 File Offset: 0x0016C257
		public static ILiveDanmakuTrackCountParam CreateFromSetValue([Nullable(2)] ILiveDanmakuTrackCountParam_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveDanmakuTrackCountParam
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009F5E RID: 40798 RVA: 0x0016E06A File Offset: 0x0016C26A
		public new ILiveDanmakuTrackCountParam_SetValue ToSetValue()
		{
			return new ILiveDanmakuTrackCountParam_SetValue
			{
				Type = this.Type,
				TrackCount = this.TrackCount
			};
		}

		// Token: 0x170031C2 RID: 12738
		// (get) Token: 0x06009F5F RID: 40799 RVA: 0x0016E089 File Offset: 0x0016C289
		// (set) Token: 0x06009F60 RID: 40800 RVA: 0x0016E0B4 File Offset: 0x0016C2B4
		public override ELiveParamType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELiveParamType.Heat;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170031C3 RID: 12739
		// (get) Token: 0x06009F61 RID: 40801 RVA: 0x0016E0C2 File Offset: 0x0016C2C2
		// (set) Token: 0x06009F62 RID: 40802 RVA: 0x0016E0ED File Offset: 0x0016C2ED
		public virtual int TrackCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TrackCount;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TrackCount;
			}
			set
			{
				this.GetOrCreatePoco().TrackCount = value;
			}
		}

		// Token: 0x04006105 RID: 24837
		[Nullable(2)]
		protected new ILiveDanmakuTrackCountParam FbInstance;

		// Token: 0x04006106 RID: 24838
		[Nullable(2)]
		protected new ILiveDanmakuTrackCountParam_SetValue PocoInterface;
	}
}
