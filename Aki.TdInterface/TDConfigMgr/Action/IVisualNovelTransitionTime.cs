using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020AF RID: 8367
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelTransitionTime : IVisualNovelTransitionConfigBase
	{
		// Token: 0x0600B802 RID: 47106 RVA: 0x001AA17C File Offset: 0x001A837C
		private IVisualNovelTransitionTime_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelTransitionTime 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelTransitionTime_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelTransitionTime_SetValue());
			}
			return result;
		}

		// Token: 0x0600B803 RID: 47107 RVA: 0x001AA1B4 File Offset: 0x001A83B4
		public static IVisualNovelTransitionTime Create([Nullable(2)] IVisualNovelTransitionTime instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelTransitionTime
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B804 RID: 47108 RVA: 0x001AA1C7 File Offset: 0x001A83C7
		public static IVisualNovelTransitionTime CreateFromSetValue([Nullable(2)] IVisualNovelTransitionTime_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelTransitionTime
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B805 RID: 47109 RVA: 0x001AA1DA File Offset: 0x001A83DA
		public new IVisualNovelTransitionTime_SetValue ToSetValue()
		{
			return new IVisualNovelTransitionTime_SetValue
			{
				Type = this.Type,
				EndDate = this.EndDate,
				EndPeriodId = this.EndPeriodId,
				IsFullScreen = this.IsFullScreen
			};
		}

		// Token: 0x17003853 RID: 14419
		// (get) Token: 0x0600B806 RID: 47110 RVA: 0x001AA211 File Offset: 0x001A8411
		// (set) Token: 0x0600B807 RID: 47111 RVA: 0x001AA23C File Offset: 0x001A843C
		public override EVisualNovelTransitionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelTransitionType.Location;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003854 RID: 14420
		// (get) Token: 0x0600B808 RID: 47112 RVA: 0x001AA24C File Offset: 0x001A844C
		// (set) Token: 0x0600B809 RID: 47113 RVA: 0x001AA2AD File Offset: 0x001A84AD
		public virtual IVisualNovelDate EndDate
		{
			get
			{
				if (this._EndDateInited)
				{
					return this._EndDateCache;
				}
				this._EndDateInited = true;
				if (this.FbInstance != null)
				{
					this._EndDateCache = IVisualNovelDate.Create(this.FbInstance.EndDate);
				}
				else
				{
					IVisualNovelTransitionTime_SetValue pocoInterface = this.PocoInterface;
					this._EndDateCache = ((pocoInterface != null) ? pocoInterface.EndDate : null);
				}
				return this._EndDateCache;
			}
			set
			{
				this.GetOrCreatePoco().EndDate = value;
				this._EndDateInited = false;
			}
		}

		// Token: 0x17003855 RID: 14421
		// (get) Token: 0x0600B80A RID: 47114 RVA: 0x001AA2C2 File Offset: 0x001A84C2
		// (set) Token: 0x0600B80B RID: 47115 RVA: 0x001AA2ED File Offset: 0x001A84ED
		public virtual int EndPeriodId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EndPeriodId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EndPeriodId;
			}
			set
			{
				this.GetOrCreatePoco().EndPeriodId = value;
			}
		}

		// Token: 0x17003856 RID: 14422
		// (get) Token: 0x0600B80C RID: 47116 RVA: 0x001AA2FC File Offset: 0x001A84FC
		// (set) Token: 0x0600B80D RID: 47117 RVA: 0x001AA336 File Offset: 0x001A8536
		public virtual bool? IsFullScreen
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsFullScreen;
				}
				IVisualNovelTransitionTime_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsFullScreen;
			}
			set
			{
				this.GetOrCreatePoco().IsFullScreen = value;
			}
		}

		// Token: 0x04006E5E RID: 28254
		[Nullable(2)]
		protected new IVisualNovelTransitionTime FbInstance;

		// Token: 0x04006E5F RID: 28255
		[Nullable(2)]
		protected new IVisualNovelTransitionTime_SetValue PocoInterface;

		// Token: 0x04006E60 RID: 28256
		private IVisualNovelDate _EndDateCache;

		// Token: 0x04006E61 RID: 28257
		private bool _EndDateInited;
	}
}
