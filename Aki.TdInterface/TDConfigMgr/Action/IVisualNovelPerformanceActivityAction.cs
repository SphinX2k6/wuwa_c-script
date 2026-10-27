using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002079 RID: 8313
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelPerformanceActivityAction : IVisualNovelPerformanceBase
	{
		// Token: 0x0600B692 RID: 46738 RVA: 0x001A729C File Offset: 0x001A549C
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

		// Token: 0x0600B693 RID: 46739 RVA: 0x001A72D4 File Offset: 0x001A54D4
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

		// Token: 0x0600B694 RID: 46740 RVA: 0x001A72E7 File Offset: 0x001A54E7
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

		// Token: 0x0600B695 RID: 46741 RVA: 0x001A72FA File Offset: 0x001A54FA
		public new IVisualNovelPerformanceActivityAction_SetValue ToSetValue()
		{
			return new IVisualNovelPerformanceActivityAction_SetValue
			{
				Type = this.Type,
				StartTime = this.StartTime,
				ActivityActionConfig = this.ActivityActionConfig
			};
		}

		// Token: 0x170037EC RID: 14316
		// (get) Token: 0x0600B696 RID: 46742 RVA: 0x001A7325 File Offset: 0x001A5525
		// (set) Token: 0x0600B697 RID: 46743 RVA: 0x001A7350 File Offset: 0x001A5550
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

		// Token: 0x170037ED RID: 14317
		// (get) Token: 0x0600B698 RID: 46744 RVA: 0x001A7360 File Offset: 0x001A5560
		// (set) Token: 0x0600B699 RID: 46745 RVA: 0x001A739A File Offset: 0x001A559A
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

		// Token: 0x170037EE RID: 14318
		// (get) Token: 0x0600B69A RID: 46746 RVA: 0x001A73A8 File Offset: 0x001A55A8
		// (set) Token: 0x0600B69B RID: 46747 RVA: 0x001A7409 File Offset: 0x001A5609
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

		// Token: 0x04006DA3 RID: 28067
		[Nullable(2)]
		protected new IVisualNovelPerformanceActivityAction FbInstance;

		// Token: 0x04006DA4 RID: 28068
		[Nullable(2)]
		protected new IVisualNovelPerformanceActivityAction_SetValue PocoInterface;

		// Token: 0x04006DA5 RID: 28069
		private IVisualNovelActivityActionSolarSchool _ActivityActionConfigCache;

		// Token: 0x04006DA6 RID: 28070
		private bool _ActivityActionConfigInited;
	}
}
