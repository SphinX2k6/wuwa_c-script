using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F49 RID: 8009
	public class IPostAkEventMap : IPostAkEventType
	{
		// Token: 0x0600AA69 RID: 43625 RVA: 0x001825D8 File Offset: 0x001807D8
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

		// Token: 0x0600AA6A RID: 43626 RVA: 0x00182610 File Offset: 0x00180810
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

		// Token: 0x0600AA6B RID: 43627 RVA: 0x00182623 File Offset: 0x00180823
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

		// Token: 0x0600AA6C RID: 43628 RVA: 0x00182636 File Offset: 0x00180836
		public new IPostAkEventMap_SetValue ToSetValue()
		{
			return new IPostAkEventMap_SetValue
			{
				Type = this.Type,
				MapEventType = this.MapEventType,
				AkEvent = this.AkEvent
			};
		}

		// Token: 0x17003455 RID: 13397
		// (get) Token: 0x0600AA6D RID: 43629 RVA: 0x00182661 File Offset: 0x00180861
		// (set) Token: 0x0600AA6E RID: 43630 RVA: 0x0018268C File Offset: 0x0018088C
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

		// Token: 0x17003456 RID: 13398
		// (get) Token: 0x0600AA6F RID: 43631 RVA: 0x0018269C File Offset: 0x0018089C
		// (set) Token: 0x0600AA70 RID: 43632 RVA: 0x001826FD File Offset: 0x001808FD
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

		// Token: 0x17003457 RID: 13399
		// (get) Token: 0x0600AA71 RID: 43633 RVA: 0x00182712 File Offset: 0x00180912
		// (set) Token: 0x0600AA72 RID: 43634 RVA: 0x0018273D File Offset: 0x0018093D
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

		// Token: 0x04006634 RID: 26164
		[Nullable(2)]
		protected new IPostAkEventMap FbInstance;

		// Token: 0x04006635 RID: 26165
		[Nullable(2)]
		protected new IPostAkEventMap_SetValue PocoInterface;

		// Token: 0x04006636 RID: 26166
		private IPlayMapMusic _MapEventTypeCache;

		// Token: 0x04006637 RID: 26167
		private bool _MapEventTypeInited;
	}
}
