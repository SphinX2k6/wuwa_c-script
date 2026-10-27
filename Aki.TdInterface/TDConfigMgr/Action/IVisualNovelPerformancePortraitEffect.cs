using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200208F RID: 8335
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelPerformancePortraitEffect : IVisualNovelPerformanceBase
	{
		// Token: 0x0600B740 RID: 46912 RVA: 0x001A8AC8 File Offset: 0x001A6CC8
		private IVisualNovelPerformancePortraitEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelPerformancePortraitEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelPerformancePortraitEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelPerformancePortraitEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600B741 RID: 46913 RVA: 0x001A8B00 File Offset: 0x001A6D00
		public static IVisualNovelPerformancePortraitEffect Create([Nullable(2)] IVisualNovelPerformancePortraitEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformancePortraitEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B742 RID: 46914 RVA: 0x001A8B13 File Offset: 0x001A6D13
		public static IVisualNovelPerformancePortraitEffect CreateFromSetValue([Nullable(2)] IVisualNovelPerformancePortraitEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelPerformancePortraitEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B743 RID: 46915 RVA: 0x001A8B28 File Offset: 0x001A6D28
		public new IVisualNovelPerformancePortraitEffect_SetValue ToSetValue()
		{
			return new IVisualNovelPerformancePortraitEffect_SetValue
			{
				Type = this.Type,
				StartTime = this.StartTime,
				WhoId = this.WhoId,
				EffectType = this.EffectType,
				Amplitude = this.Amplitude
			};
		}

		// Token: 0x17003822 RID: 14370
		// (get) Token: 0x0600B744 RID: 46916 RVA: 0x001A8B76 File Offset: 0x001A6D76
		// (set) Token: 0x0600B745 RID: 46917 RVA: 0x001A8BA1 File Offset: 0x001A6DA1
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

		// Token: 0x17003823 RID: 14371
		// (get) Token: 0x0600B746 RID: 46918 RVA: 0x001A8BB0 File Offset: 0x001A6DB0
		// (set) Token: 0x0600B747 RID: 46919 RVA: 0x001A8BEA File Offset: 0x001A6DEA
		public override float? StartTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartTime;
				}
				IVisualNovelPerformancePortraitEffect_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003824 RID: 14372
		// (get) Token: 0x0600B748 RID: 46920 RVA: 0x001A8BF8 File Offset: 0x001A6DF8
		// (set) Token: 0x0600B749 RID: 46921 RVA: 0x001A8C23 File Offset: 0x001A6E23
		public virtual int WhoId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WhoId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.WhoId;
			}
			set
			{
				this.GetOrCreatePoco().WhoId = value;
			}
		}

		// Token: 0x17003825 RID: 14373
		// (get) Token: 0x0600B74A RID: 46922 RVA: 0x001A8C31 File Offset: 0x001A6E31
		// (set) Token: 0x0600B74B RID: 46923 RVA: 0x001A8C5C File Offset: 0x001A6E5C
		public virtual EVisualNovelPortraitEffectType EffectType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EffectType;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelPortraitEffectType.Jump;
				}
				return this.PocoInterface.EffectType;
			}
			set
			{
				this.GetOrCreatePoco().EffectType = value;
			}
		}

		// Token: 0x17003826 RID: 14374
		// (get) Token: 0x0600B74C RID: 46924 RVA: 0x001A8C6C File Offset: 0x001A6E6C
		// (set) Token: 0x0600B74D RID: 46925 RVA: 0x001A8CA6 File Offset: 0x001A6EA6
		public virtual EVisualNovelAmplitude? Amplitude
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Amplitude;
				}
				IVisualNovelPerformancePortraitEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Amplitude;
			}
			set
			{
				this.GetOrCreatePoco().Amplitude = value;
			}
		}

		// Token: 0x04006E07 RID: 28167
		[Nullable(2)]
		protected new IVisualNovelPerformancePortraitEffect FbInstance;

		// Token: 0x04006E08 RID: 28168
		[Nullable(2)]
		protected new IVisualNovelPerformancePortraitEffect_SetValue PocoInterface;
	}
}
