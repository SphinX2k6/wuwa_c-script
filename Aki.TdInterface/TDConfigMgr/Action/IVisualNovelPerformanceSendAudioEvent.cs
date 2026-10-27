using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002093 RID: 8339
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelPerformanceSendAudioEvent : IVisualNovelPerformanceBase
	{
		// Token: 0x0600B75C RID: 46940 RVA: 0x001A8E58 File Offset: 0x001A7058
		private IVisualNovelPerformanceSendAudioEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelPerformanceSendAudioEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelPerformanceSendAudioEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelPerformanceSendAudioEvent_SetValue());
			}
			return result;
		}

		// Token: 0x0600B75D RID: 46941 RVA: 0x001A8E90 File Offset: 0x001A7090
		public static IVisualNovelPerformanceSendAudioEvent Create([Nullable(2)] IVisualNovelPerformanceSendAudioEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceSendAudioEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B75E RID: 46942 RVA: 0x001A8EA3 File Offset: 0x001A70A3
		public static IVisualNovelPerformanceSendAudioEvent CreateFromSetValue([Nullable(2)] IVisualNovelPerformanceSendAudioEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceSendAudioEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B75F RID: 46943 RVA: 0x001A8EB8 File Offset: 0x001A70B8
		public new IVisualNovelPerformanceSendAudioEvent_SetValue ToSetValue()
		{
			return new IVisualNovelPerformanceSendAudioEvent_SetValue
			{
				Type = this.Type,
				StartTime = this.StartTime,
				AudioEvent = this.AudioEvent,
				EndFadeOutTime = this.EndFadeOutTime,
				IsNotCountTimeAndNotInterrupted = this.IsNotCountTimeAndNotInterrupted
			};
		}

		// Token: 0x1700382A RID: 14378
		// (get) Token: 0x0600B760 RID: 46944 RVA: 0x001A8F06 File Offset: 0x001A7106
		// (set) Token: 0x0600B761 RID: 46945 RVA: 0x001A8F31 File Offset: 0x001A7131
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelPerformanceType.Enter;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700382B RID: 14379
		// (get) Token: 0x0600B762 RID: 46946 RVA: 0x001A8F40 File Offset: 0x001A7140
		// (set) Token: 0x0600B763 RID: 46947 RVA: 0x001A8F7A File Offset: 0x001A717A
		public override float? StartTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartTime;
				}
				IVisualNovelPerformanceSendAudioEvent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StartTime;
			}
			set
			{
				this.GetOrCreatePoco().StartTime = value;
			}
		}

		// Token: 0x1700382C RID: 14380
		// (get) Token: 0x0600B764 RID: 46948 RVA: 0x001A8F88 File Offset: 0x001A7188
		// (set) Token: 0x0600B765 RID: 46949 RVA: 0x001A8FB3 File Offset: 0x001A71B3
		public virtual string AudioEvent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AudioEvent;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.AudioEvent;
			}
			set
			{
				this.GetOrCreatePoco().AudioEvent = value;
			}
		}

		// Token: 0x1700382D RID: 14381
		// (get) Token: 0x0600B766 RID: 46950 RVA: 0x001A8FC4 File Offset: 0x001A71C4
		// (set) Token: 0x0600B767 RID: 46951 RVA: 0x001A8FFE File Offset: 0x001A71FE
		public virtual float? EndFadeOutTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EndFadeOutTime;
				}
				IVisualNovelPerformanceSendAudioEvent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EndFadeOutTime;
			}
			set
			{
				this.GetOrCreatePoco().EndFadeOutTime = value;
			}
		}

		// Token: 0x1700382E RID: 14382
		// (get) Token: 0x0600B768 RID: 46952 RVA: 0x001A900C File Offset: 0x001A720C
		// (set) Token: 0x0600B769 RID: 46953 RVA: 0x001A9046 File Offset: 0x001A7246
		public virtual bool? IsNotCountTimeAndNotInterrupted
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsNotCountTimeAndNotInterrupted;
				}
				IVisualNovelPerformanceSendAudioEvent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsNotCountTimeAndNotInterrupted;
			}
			set
			{
				this.GetOrCreatePoco().IsNotCountTimeAndNotInterrupted = value;
			}
		}

		// Token: 0x04006E15 RID: 28181
		[Nullable(2)]
		protected new IVisualNovelPerformanceSendAudioEvent FbInstance;

		// Token: 0x04006E16 RID: 28182
		[Nullable(2)]
		protected new IVisualNovelPerformanceSendAudioEvent_SetValue PocoInterface;
	}
}
