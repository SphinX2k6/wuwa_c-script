using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002067 RID: 8295
	[NullableContext(2)]
	[Nullable(0)]
	public class IVisualNovelConfig
	{
		// Token: 0x0600B636 RID: 46646 RVA: 0x001A68B8 File Offset: 0x001A4AB8
		[NullableContext(1)]
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

		// Token: 0x0600B637 RID: 46647 RVA: 0x001A68F0 File Offset: 0x001A4AF0
		[NullableContext(1)]
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

		// Token: 0x0600B638 RID: 46648 RVA: 0x001A6903 File Offset: 0x001A4B03
		[NullableContext(1)]
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

		// Token: 0x0600B639 RID: 46649 RVA: 0x001A6918 File Offset: 0x001A4B18
		[NullableContext(1)]
		public IVisualNovelConfig_SetValue ToSetValue()
		{
			return new IVisualNovelConfig_SetValue
			{
				VisualNovelSubType = this.VisualNovelSubType,
				EnableReadRecord = this.EnableReadRecord,
				HideControlUi = this.HideControlUi,
				InitialBackgroundId = this.InitialBackgroundId,
				InitialAudioEvent = this.InitialAudioEvent,
				InitialTime = this.InitialTime
			};
		}

		// Token: 0x170037D9 RID: 14297
		// (get) Token: 0x0600B63A RID: 46650 RVA: 0x001A6974 File Offset: 0x001A4B74
		// (set) Token: 0x0600B63B RID: 46651 RVA: 0x001A69AE File Offset: 0x001A4BAE
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

		// Token: 0x170037DA RID: 14298
		// (get) Token: 0x0600B63C RID: 46652 RVA: 0x001A69BC File Offset: 0x001A4BBC
		// (set) Token: 0x0600B63D RID: 46653 RVA: 0x001A69F6 File Offset: 0x001A4BF6
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

		// Token: 0x170037DB RID: 14299
		// (get) Token: 0x0600B63E RID: 46654 RVA: 0x001A6A04 File Offset: 0x001A4C04
		// (set) Token: 0x0600B63F RID: 46655 RVA: 0x001A6A3E File Offset: 0x001A4C3E
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

		// Token: 0x170037DC RID: 14300
		// (get) Token: 0x0600B640 RID: 46656 RVA: 0x001A6A4C File Offset: 0x001A4C4C
		// (set) Token: 0x0600B641 RID: 46657 RVA: 0x001A6A86 File Offset: 0x001A4C86
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

		// Token: 0x170037DD RID: 14301
		// (get) Token: 0x0600B642 RID: 46658 RVA: 0x001A6A94 File Offset: 0x001A4C94
		// (set) Token: 0x0600B643 RID: 46659 RVA: 0x001A6ABB File Offset: 0x001A4CBB
		public virtual string InitialAudioEvent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitialAudioEvent;
				}
				IVisualNovelConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InitialAudioEvent;
			}
			set
			{
				this.GetOrCreatePoco().InitialAudioEvent = value;
			}
		}

		// Token: 0x170037DE RID: 14302
		// (get) Token: 0x0600B644 RID: 46660 RVA: 0x001A6ACC File Offset: 0x001A4CCC
		// (set) Token: 0x0600B645 RID: 46661 RVA: 0x001A6B2D File Offset: 0x001A4D2D
		public virtual ISolarSchoolTime InitialTime
		{
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
			set
			{
				this.GetOrCreatePoco().InitialTime = value;
				this._InitialTimeInited = false;
			}
		}

		// Token: 0x04006D7C RID: 28028
		protected IVisualNovelConfig FbInstance;

		// Token: 0x04006D7D RID: 28029
		protected IVisualNovelConfig_SetValue PocoInterface;

		// Token: 0x04006D7E RID: 28030
		[Nullable(1)]
		private ISolarSchoolTime _InitialTimeCache;

		// Token: 0x04006D7F RID: 28031
		private bool _InitialTimeInited;
	}
}
