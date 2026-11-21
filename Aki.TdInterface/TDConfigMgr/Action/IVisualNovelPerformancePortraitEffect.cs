using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022DA RID: 8922
	public class IVisualNovelPerformancePortraitEffect : IVisualNovelPerformanceBase
	{
		// Token: 0x0600C26E RID: 49774 RVA: 0x001BF2E8 File Offset: 0x001BD4E8
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

		// Token: 0x0600C26F RID: 49775 RVA: 0x001BF320 File Offset: 0x001BD520
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

		// Token: 0x0600C270 RID: 49776 RVA: 0x001BF333 File Offset: 0x001BD533
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

		// Token: 0x0600C271 RID: 49777 RVA: 0x001BF348 File Offset: 0x001BD548
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

		// Token: 0x17003B00 RID: 15104
		// (get) Token: 0x0600C272 RID: 49778 RVA: 0x001BF396 File Offset: 0x001BD596
		// (set) Token: 0x0600C273 RID: 49779 RVA: 0x001BF3C1 File Offset: 0x001BD5C1
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

		// Token: 0x17003B01 RID: 15105
		// (get) Token: 0x0600C274 RID: 49780 RVA: 0x001BF3D0 File Offset: 0x001BD5D0
		// (set) Token: 0x0600C275 RID: 49781 RVA: 0x001BF40A File Offset: 0x001BD60A
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

		// Token: 0x17003B02 RID: 15106
		// (get) Token: 0x0600C276 RID: 49782 RVA: 0x001BF418 File Offset: 0x001BD618
		// (set) Token: 0x0600C277 RID: 49783 RVA: 0x001BF443 File Offset: 0x001BD643
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

		// Token: 0x17003B03 RID: 15107
		// (get) Token: 0x0600C278 RID: 49784 RVA: 0x001BF451 File Offset: 0x001BD651
		// (set) Token: 0x0600C279 RID: 49785 RVA: 0x001BF47C File Offset: 0x001BD67C
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

		// Token: 0x17003B04 RID: 15108
		// (get) Token: 0x0600C27A RID: 49786 RVA: 0x001BF48C File Offset: 0x001BD68C
		// (set) Token: 0x0600C27B RID: 49787 RVA: 0x001BF4C6 File Offset: 0x001BD6C6
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

		// Token: 0x04007413 RID: 29715
		[Nullable(2)]
		protected new IVisualNovelPerformancePortraitEffect FbInstance;

		// Token: 0x04007414 RID: 29716
		[Nullable(2)]
		protected new IVisualNovelPerformancePortraitEffect_SetValue PocoInterface;
	}
}
