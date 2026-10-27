using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018AE RID: 6318
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientEventPianoUpdateSubtitle : IClientEventPianoEvent
	{
		// Token: 0x0600879B RID: 34715 RVA: 0x00141590 File Offset: 0x0013F790
		private IClientEventPianoUpdateSubtitle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientEventPianoUpdateSubtitle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientEventPianoUpdateSubtitle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientEventPianoUpdateSubtitle_SetValue());
			}
			return result;
		}

		// Token: 0x0600879C RID: 34716 RVA: 0x001415C8 File Offset: 0x0013F7C8
		public static IClientEventPianoUpdateSubtitle Create([Nullable(2)] IClientEventPianoUpdateSubtitle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEventPianoUpdateSubtitle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600879D RID: 34717 RVA: 0x001415DB File Offset: 0x0013F7DB
		public static IClientEventPianoUpdateSubtitle CreateFromSetValue([Nullable(2)] IClientEventPianoUpdateSubtitle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientEventPianoUpdateSubtitle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600879E RID: 34718 RVA: 0x001415EE File Offset: 0x0013F7EE
		public new IClientEventPianoUpdateSubtitle_SetValue ToSetValue()
		{
			return new IClientEventPianoUpdateSubtitle_SetValue
			{
				Type = this.Type,
				Flow = this.Flow,
				DisableMove = this.DisableMove
			};
		}

		// Token: 0x17002C1D RID: 11293
		// (get) Token: 0x0600879F RID: 34719 RVA: 0x00141619 File Offset: 0x0013F819
		// (set) Token: 0x060087A0 RID: 34720 RVA: 0x00141644 File Offset: 0x0013F844
		public override EClientEventPianoEventType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientEventPianoEventType.UpdateSubtitle;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002C1E RID: 11294
		// (get) Token: 0x060087A1 RID: 34721 RVA: 0x00141654 File Offset: 0x0013F854
		// (set) Token: 0x060087A2 RID: 34722 RVA: 0x001416B5 File Offset: 0x0013F8B5
		public virtual PlayFlow Flow
		{
			get
			{
				if (this._FlowInited)
				{
					return this._FlowCache;
				}
				this._FlowInited = true;
				if (this.FbInstance != null)
				{
					this._FlowCache = PlayFlow.Create(this.FbInstance.Flow);
				}
				else
				{
					IClientEventPianoUpdateSubtitle_SetValue pocoInterface = this.PocoInterface;
					this._FlowCache = ((pocoInterface != null) ? pocoInterface.Flow : null);
				}
				return this._FlowCache;
			}
			set
			{
				this.GetOrCreatePoco().Flow = value;
				this._FlowInited = false;
			}
		}

		// Token: 0x17002C1F RID: 11295
		// (get) Token: 0x060087A3 RID: 34723 RVA: 0x001416CA File Offset: 0x0013F8CA
		// (set) Token: 0x060087A4 RID: 34724 RVA: 0x001416F5 File Offset: 0x0013F8F5
		public virtual bool DisableMove
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableMove;
				}
				return this.PocoInterface != null && this.PocoInterface.DisableMove;
			}
			set
			{
				this.GetOrCreatePoco().DisableMove = value;
			}
		}

		// Token: 0x04005550 RID: 21840
		[Nullable(2)]
		protected new IClientEventPianoUpdateSubtitle FbInstance;

		// Token: 0x04005551 RID: 21841
		[Nullable(2)]
		protected new IClientEventPianoUpdateSubtitle_SetValue PocoInterface;

		// Token: 0x04005552 RID: 21842
		private PlayFlow _FlowCache;

		// Token: 0x04005553 RID: 21843
		private bool _FlowInited;
	}
}
