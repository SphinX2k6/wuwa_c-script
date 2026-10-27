using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200209B RID: 8347
	[NullableContext(2)]
	[Nullable(0)]
	public class IVisualNovelPerformanceUiShake : IVisualNovelPerformanceBase
	{
		// Token: 0x0600B790 RID: 46992 RVA: 0x001A94E4 File Offset: 0x001A76E4
		[NullableContext(1)]
		private IVisualNovelPerformanceUiShake_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelPerformanceUiShake 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelPerformanceUiShake_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelPerformanceUiShake_SetValue());
			}
			return result;
		}

		// Token: 0x0600B791 RID: 46993 RVA: 0x001A951C File Offset: 0x001A771C
		[NullableContext(1)]
		public static IVisualNovelPerformanceUiShake Create([Nullable(2)] IVisualNovelPerformanceUiShake instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceUiShake
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B792 RID: 46994 RVA: 0x001A952F File Offset: 0x001A772F
		[NullableContext(1)]
		public static IVisualNovelPerformanceUiShake CreateFromSetValue([Nullable(2)] IVisualNovelPerformanceUiShake_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceUiShake
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B793 RID: 46995 RVA: 0x001A9544 File Offset: 0x001A7744
		[NullableContext(1)]
		public new IVisualNovelPerformanceUiShake_SetValue ToSetValue()
		{
			return new IVisualNovelPerformanceUiShake_SetValue
			{
				Type = this.Type,
				StartTime = this.StartTime,
				ShakeType = this.ShakeType,
				Intensity = this.Intensity,
				Duration = this.Duration,
				ScreenEffectDa = this.ScreenEffectDa
			};
		}

		// Token: 0x17003838 RID: 14392
		// (get) Token: 0x0600B794 RID: 46996 RVA: 0x001A959E File Offset: 0x001A779E
		// (set) Token: 0x0600B795 RID: 46997 RVA: 0x001A95C9 File Offset: 0x001A77C9
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

		// Token: 0x17003839 RID: 14393
		// (get) Token: 0x0600B796 RID: 46998 RVA: 0x001A95D8 File Offset: 0x001A77D8
		// (set) Token: 0x0600B797 RID: 46999 RVA: 0x001A9612 File Offset: 0x001A7812
		public override float? StartTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartTime;
				}
				IVisualNovelPerformanceUiShake_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700383A RID: 14394
		// (get) Token: 0x0600B798 RID: 47000 RVA: 0x001A9620 File Offset: 0x001A7820
		// (set) Token: 0x0600B799 RID: 47001 RVA: 0x001A964B File Offset: 0x001A784B
		public virtual EVisualNovelUiShakeType ShakeType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShakeType;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelUiShakeType.Random;
				}
				return this.PocoInterface.ShakeType;
			}
			set
			{
				this.GetOrCreatePoco().ShakeType = value;
			}
		}

		// Token: 0x1700383B RID: 14395
		// (get) Token: 0x0600B79A RID: 47002 RVA: 0x001A9659 File Offset: 0x001A7859
		// (set) Token: 0x0600B79B RID: 47003 RVA: 0x001A9684 File Offset: 0x001A7884
		public virtual EVisualNovelShakeIntensity Intensity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Intensity;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelShakeIntensity.Weak;
				}
				return this.PocoInterface.Intensity;
			}
			set
			{
				this.GetOrCreatePoco().Intensity = value;
			}
		}

		// Token: 0x1700383C RID: 14396
		// (get) Token: 0x0600B79C RID: 47004 RVA: 0x001A9694 File Offset: 0x001A7894
		// (set) Token: 0x0600B79D RID: 47005 RVA: 0x001A96CE File Offset: 0x001A78CE
		public virtual float? Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				IVisualNovelPerformanceUiShake_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x1700383D RID: 14397
		// (get) Token: 0x0600B79E RID: 47006 RVA: 0x001A96DC File Offset: 0x001A78DC
		// (set) Token: 0x0600B79F RID: 47007 RVA: 0x001A9703 File Offset: 0x001A7903
		public virtual string ScreenEffectDa
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ScreenEffectDa;
				}
				IVisualNovelPerformanceUiShake_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ScreenEffectDa;
			}
			set
			{
				this.GetOrCreatePoco().ScreenEffectDa = value;
			}
		}

		// Token: 0x04006E2F RID: 28207
		protected new IVisualNovelPerformanceUiShake FbInstance;

		// Token: 0x04006E30 RID: 28208
		protected new IVisualNovelPerformanceUiShake_SetValue PocoInterface;
	}
}
