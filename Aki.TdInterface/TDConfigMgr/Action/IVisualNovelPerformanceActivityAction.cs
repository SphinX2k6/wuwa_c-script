using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022C4 RID: 8900
	public class IVisualNovelPerformanceActivityAction : IVisualNovelPerformanceBase
	{
		// Token: 0x0600C1C2 RID: 49602 RVA: 0x001BDB14 File Offset: 0x001BBD14
		private IVisualNovelPerformanceActivityAction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelPerformanceActivityAction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelPerformanceActivityAction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelPerformanceActivityAction_SetValue());
			}
			return result;
		}

		// Token: 0x0600C1C3 RID: 49603 RVA: 0x001BDB4C File Offset: 0x001BBD4C
		public static IVisualNovelPerformanceActivityAction Create([Nullable(2)] IVisualNovelPerformanceActivityAction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceActivityAction
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C1C4 RID: 49604 RVA: 0x001BDB5F File Offset: 0x001BBD5F
		public static IVisualNovelPerformanceActivityAction CreateFromSetValue([Nullable(2)] IVisualNovelPerformanceActivityAction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceActivityAction
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C1C5 RID: 49605 RVA: 0x001BDB72 File Offset: 0x001BBD72
		public new IVisualNovelPerformanceActivityAction_SetValue ToSetValue()
		{
			return new IVisualNovelPerformanceActivityAction_SetValue
			{
				Type = this.Type,
				StartTime = this.StartTime,
				ActivityActionConfig = this.ActivityActionConfig
			};
		}

		// Token: 0x17003ACB RID: 15051
		// (get) Token: 0x0600C1C6 RID: 49606 RVA: 0x001BDB9D File Offset: 0x001BBD9D
		// (set) Token: 0x0600C1C7 RID: 49607 RVA: 0x001BDBC8 File Offset: 0x001BBDC8
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

		// Token: 0x17003ACC RID: 15052
		// (get) Token: 0x0600C1C8 RID: 49608 RVA: 0x001BDBD8 File Offset: 0x001BBDD8
		// (set) Token: 0x0600C1C9 RID: 49609 RVA: 0x001BDC12 File Offset: 0x001BBE12
		public override float? StartTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartTime;
				}
				IVisualNovelPerformanceActivityAction_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003ACD RID: 15053
		// (get) Token: 0x0600C1CA RID: 49610 RVA: 0x001BDC20 File Offset: 0x001BBE20
		// (set) Token: 0x0600C1CB RID: 49611 RVA: 0x001BDC81 File Offset: 0x001BBE81
		public virtual IVisualNovelActivityActionSolarSchool ActivityActionConfig
		{
			get
			{
				if (this._ActivityActionConfigInited)
				{
					return this._ActivityActionConfigCache;
				}
				this._ActivityActionConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ActivityActionConfigCache = IVisualNovelActivityActionSolarSchool.Create(this.FbInstance.ActivityActionConfig);
				}
				else
				{
					IVisualNovelPerformanceActivityAction_SetValue pocoInterface = this.PocoInterface;
					this._ActivityActionConfigCache = ((pocoInterface != null) ? pocoInterface.ActivityActionConfig : null);
				}
				return this._ActivityActionConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().ActivityActionConfig = value;
				this._ActivityActionConfigInited = false;
			}
		}

		// Token: 0x040073B0 RID: 29616
		[Nullable(2)]
		protected new IVisualNovelPerformanceActivityAction FbInstance;

		// Token: 0x040073B1 RID: 29617
		[Nullable(2)]
		protected new IVisualNovelPerformanceActivityAction_SetValue PocoInterface;

		// Token: 0x040073B2 RID: 29618
		private IVisualNovelActivityActionSolarSchool _ActivityActionConfigCache;

		// Token: 0x040073B3 RID: 29619
		private bool _ActivityActionConfigInited;
	}
}
