using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022B0 RID: 8880
	public class IVisualNovelConfig
	{
		// Token: 0x0600C15E RID: 49502 RVA: 0x001BD068 File Offset: 0x001BB268
		private IVisualNovelConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600C15F RID: 49503 RVA: 0x001BD0A0 File Offset: 0x001BB2A0
		public static IVisualNovelConfig Create([Nullable(2)] IVisualNovelConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C160 RID: 49504 RVA: 0x001BD0B3 File Offset: 0x001BB2B3
		public static IVisualNovelConfig CreateFromSetValue([Nullable(2)] IVisualNovelConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C161 RID: 49505 RVA: 0x001BD0C8 File Offset: 0x001BB2C8
		public IVisualNovelConfig_SetValue ToSetValue()
		{
			return new IVisualNovelConfig_SetValue
			{
				VisualNovelSubType = this.VisualNovelSubType,
				EnableReadRecord = this.EnableReadRecord,
				EnableFastForward = this.EnableFastForward,
				HideControlUi = this.HideControlUi,
				InitialBackgroundId = this.InitialBackgroundId,
				InitialAudioEvents = this.InitialAudioEvents,
				InitialTime = this.InitialTime,
				EndFadeOutTime = this.EndFadeOutTime
			};
		}

		// Token: 0x17003AB7 RID: 15031
		// (get) Token: 0x0600C162 RID: 49506 RVA: 0x001BD13C File Offset: 0x001BB33C
		// (set) Token: 0x0600C163 RID: 49507 RVA: 0x001BD176 File Offset: 0x001BB376
		public virtual EVisualNovelSubType? VisualNovelSubType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VisualNovelSubType;
				}
				IVisualNovelConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.VisualNovelSubType;
			}
			set
			{
				this.GetOrCreatePoco().VisualNovelSubType = value;
			}
		}

		// Token: 0x17003AB8 RID: 15032
		// (get) Token: 0x0600C164 RID: 49508 RVA: 0x001BD184 File Offset: 0x001BB384
		// (set) Token: 0x0600C165 RID: 49509 RVA: 0x001BD1BE File Offset: 0x001BB3BE
		public virtual bool? EnableReadRecord
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnableReadRecord;
				}
				IVisualNovelConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EnableReadRecord;
			}
			set
			{
				this.GetOrCreatePoco().EnableReadRecord = value;
			}
		}

		// Token: 0x17003AB9 RID: 15033
		// (get) Token: 0x0600C166 RID: 49510 RVA: 0x001BD1CC File Offset: 0x001BB3CC
		// (set) Token: 0x0600C167 RID: 49511 RVA: 0x001BD206 File Offset: 0x001BB406
		public virtual bool? EnableFastForward
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnableFastForward;
				}
				IVisualNovelConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EnableFastForward;
			}
			set
			{
				this.GetOrCreatePoco().EnableFastForward = value;
			}
		}

		// Token: 0x17003ABA RID: 15034
		// (get) Token: 0x0600C168 RID: 49512 RVA: 0x001BD214 File Offset: 0x001BB414
		// (set) Token: 0x0600C169 RID: 49513 RVA: 0x001BD24E File Offset: 0x001BB44E
		public virtual bool? HideControlUi
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HideControlUi;
				}
				IVisualNovelConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HideControlUi;
			}
			set
			{
				this.GetOrCreatePoco().HideControlUi = value;
			}
		}

		// Token: 0x17003ABB RID: 15035
		// (get) Token: 0x0600C16A RID: 49514 RVA: 0x001BD25C File Offset: 0x001BB45C
		// (set) Token: 0x0600C16B RID: 49515 RVA: 0x001BD296 File Offset: 0x001BB496
		public virtual int? InitialBackgroundId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitialBackgroundId;
				}
				IVisualNovelConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InitialBackgroundId;
			}
			set
			{
				this.GetOrCreatePoco().InitialBackgroundId = value;
			}
		}

		// Token: 0x17003ABC RID: 15036
		// (get) Token: 0x0600C16C RID: 49516 RVA: 0x001BD2A4 File Offset: 0x001BB4A4
		// (set) Token: 0x0600C16D RID: 49517 RVA: 0x001BD2CB File Offset: 0x001BB4CB
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> InitialAudioEvents
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitialAudioEvents;
				}
				IVisualNovelConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InitialAudioEvents;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().InitialAudioEvents = value;
			}
		}

		// Token: 0x17003ABD RID: 15037
		// (get) Token: 0x0600C16E RID: 49518 RVA: 0x001BD2DC File Offset: 0x001BB4DC
		// (set) Token: 0x0600C16F RID: 49519 RVA: 0x001BD33D File Offset: 0x001BB53D
		[Nullable(2)]
		public virtual ISolarSchoolTime InitialTime
		{
			[NullableContext(2)]
			get
			{
				if (this._InitialTimeInited)
				{
					return this._InitialTimeCache;
				}
				this._InitialTimeInited = true;
				if (this.FbInstance != null)
				{
					this._InitialTimeCache = ISolarSchoolTime.Create(this.FbInstance.InitialTime);
				}
				else
				{
					IVisualNovelConfig_SetValue pocoInterface = this.PocoInterface;
					this._InitialTimeCache = ((pocoInterface != null) ? pocoInterface.InitialTime : null);
				}
				return this._InitialTimeCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().InitialTime = value;
				this._InitialTimeInited = false;
			}
		}

		// Token: 0x17003ABE RID: 15038
		// (get) Token: 0x0600C170 RID: 49520 RVA: 0x001BD354 File Offset: 0x001BB554
		// (set) Token: 0x0600C171 RID: 49521 RVA: 0x001BD38E File Offset: 0x001BB58E
		public virtual float? EndFadeOutTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EndFadeOutTime;
				}
				IVisualNovelConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04007386 RID: 29574
		[Nullable(2)]
		protected IVisualNovelConfig FbInstance;

		// Token: 0x04007387 RID: 29575
		[Nullable(2)]
		protected IVisualNovelConfig_SetValue PocoInterface;

		// Token: 0x04007388 RID: 29576
		private ISolarSchoolTime _InitialTimeCache;

		// Token: 0x04007389 RID: 29577
		private bool _InitialTimeInited;
	}
}
