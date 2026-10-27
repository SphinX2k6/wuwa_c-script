using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D38 RID: 7480
	[NullableContext(1)]
	[Nullable(0)]
	public class IPostAkEventMap : IPostAkEventType
	{
		// Token: 0x0600A07D RID: 41085 RVA: 0x0016E1B4 File Offset: 0x0016C3B4
		private IPostAkEventMap_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPostAkEventMap 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPostAkEventMap_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPostAkEventMap_SetValue());
			}
			return result;
		}

		// Token: 0x0600A07E RID: 41086 RVA: 0x0016E1EC File Offset: 0x0016C3EC
		public static IPostAkEventMap Create([Nullable(2)] IPostAkEventMap instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPostAkEventMap
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A07F RID: 41087 RVA: 0x0016E1FF File Offset: 0x0016C3FF
		public static IPostAkEventMap CreateFromSetValue([Nullable(2)] IPostAkEventMap_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPostAkEventMap
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A080 RID: 41088 RVA: 0x0016E212 File Offset: 0x0016C412
		public new IPostAkEventMap_SetValue ToSetValue()
		{
			return new IPostAkEventMap_SetValue
			{
				Type = this.Type,
				MapEventType = this.MapEventType,
				AkEvent = this.AkEvent
			};
		}

		// Token: 0x170031C1 RID: 12737
		// (get) Token: 0x0600A081 RID: 41089 RVA: 0x0016E23D File Offset: 0x0016C43D
		// (set) Token: 0x0600A082 RID: 41090 RVA: 0x0016E268 File Offset: 0x0016C468
		public override EPostAkEvent Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPostAkEvent.Global;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170031C2 RID: 12738
		// (get) Token: 0x0600A083 RID: 41091 RVA: 0x0016E278 File Offset: 0x0016C478
		// (set) Token: 0x0600A084 RID: 41092 RVA: 0x0016E2D9 File Offset: 0x0016C4D9
		public virtual IPlayMapMusic MapEventType
		{
			get
			{
				if (this._MapEventTypeInited)
				{
					return this._MapEventTypeCache;
				}
				this._MapEventTypeInited = true;
				if (this.FbInstance != null)
				{
					this._MapEventTypeCache = IPlayMapMusic.Create(this.FbInstance.MapEventType);
				}
				else
				{
					IPostAkEventMap_SetValue pocoInterface = this.PocoInterface;
					this._MapEventTypeCache = ((pocoInterface != null) ? pocoInterface.MapEventType : null);
				}
				return this._MapEventTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().MapEventType = value;
				this._MapEventTypeInited = false;
			}
		}

		// Token: 0x170031C3 RID: 12739
		// (get) Token: 0x0600A085 RID: 41093 RVA: 0x0016E2EE File Offset: 0x0016C4EE
		// (set) Token: 0x0600A086 RID: 41094 RVA: 0x0016E319 File Offset: 0x0016C519
		public virtual string AkEvent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AkEvent;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.AkEvent;
			}
			set
			{
				this.GetOrCreatePoco().AkEvent = value;
			}
		}

		// Token: 0x040060B8 RID: 24760
		[Nullable(2)]
		protected new IPostAkEventMap FbInstance;

		// Token: 0x040060B9 RID: 24761
		[Nullable(2)]
		protected new IPostAkEventMap_SetValue PocoInterface;

		// Token: 0x040060BA RID: 24762
		private IPlayMapMusic _MapEventTypeCache;

		// Token: 0x040060BB RID: 24763
		private bool _MapEventTypeInited;
	}
}
