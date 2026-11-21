using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002304 RID: 8964
	public class IVisualNovelTransitionTime : IVisualNovelTransitionConfigBase
	{
		// Token: 0x0600C35A RID: 50010 RVA: 0x001C0DC4 File Offset: 0x001BEFC4
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

		// Token: 0x0600C35B RID: 50011 RVA: 0x001C0DFC File Offset: 0x001BEFFC
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

		// Token: 0x0600C35C RID: 50012 RVA: 0x001C0E0F File Offset: 0x001BF00F
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

		// Token: 0x0600C35D RID: 50013 RVA: 0x001C0E22 File Offset: 0x001BF022
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

		// Token: 0x17003B37 RID: 15159
		// (get) Token: 0x0600C35E RID: 50014 RVA: 0x001C0E59 File Offset: 0x001BF059
		// (set) Token: 0x0600C35F RID: 50015 RVA: 0x001C0E84 File Offset: 0x001BF084
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

		// Token: 0x17003B38 RID: 15160
		// (get) Token: 0x0600C360 RID: 50016 RVA: 0x001C0E94 File Offset: 0x001BF094
		// (set) Token: 0x0600C361 RID: 50017 RVA: 0x001C0EF5 File Offset: 0x001BF0F5
		[Nullable(2)]
		public virtual IVisualNovelDate EndDate
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EndDate = value;
				this._EndDateInited = false;
			}
		}

		// Token: 0x17003B39 RID: 15161
		// (get) Token: 0x0600C362 RID: 50018 RVA: 0x001C0F0A File Offset: 0x001BF10A
		// (set) Token: 0x0600C363 RID: 50019 RVA: 0x001C0F35 File Offset: 0x001BF135
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

		// Token: 0x17003B3A RID: 15162
		// (get) Token: 0x0600C364 RID: 50020 RVA: 0x001C0F44 File Offset: 0x001BF144
		// (set) Token: 0x0600C365 RID: 50021 RVA: 0x001C0F7E File Offset: 0x001BF17E
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

		// Token: 0x0400747C RID: 29820
		[Nullable(2)]
		protected new IVisualNovelTransitionTime FbInstance;

		// Token: 0x0400747D RID: 29821
		[Nullable(2)]
		protected new IVisualNovelTransitionTime_SetValue PocoInterface;

		// Token: 0x0400747E RID: 29822
		private IVisualNovelDate _EndDateCache;

		// Token: 0x0400747F RID: 29823
		private bool _EndDateInited;
	}
}
