using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A39 RID: 6713
	public class IClientEventPianoUpdateSubtitle : IClientEventPianoEvent
	{
		// Token: 0x06008EC3 RID: 36547 RVA: 0x00150DC4 File Offset: 0x0014EFC4
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

		// Token: 0x06008EC4 RID: 36548 RVA: 0x00150DFC File Offset: 0x0014EFFC
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

		// Token: 0x06008EC5 RID: 36549 RVA: 0x00150E0F File Offset: 0x0014F00F
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

		// Token: 0x06008EC6 RID: 36550 RVA: 0x00150E22 File Offset: 0x0014F022
		public new IClientEventPianoUpdateSubtitle_SetValue ToSetValue()
		{
			return new IClientEventPianoUpdateSubtitle_SetValue
			{
				Type = this.Type,
				Flow = this.Flow,
				DisableMove = this.DisableMove
			};
		}

		// Token: 0x17002E18 RID: 11800
		// (get) Token: 0x06008EC7 RID: 36551 RVA: 0x00150E4D File Offset: 0x0014F04D
		// (set) Token: 0x06008EC8 RID: 36552 RVA: 0x00150E78 File Offset: 0x0014F078
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

		// Token: 0x17002E19 RID: 11801
		// (get) Token: 0x06008EC9 RID: 36553 RVA: 0x00150E88 File Offset: 0x0014F088
		// (set) Token: 0x06008ECA RID: 36554 RVA: 0x00150EE9 File Offset: 0x0014F0E9
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

		// Token: 0x17002E1A RID: 11802
		// (get) Token: 0x06008ECB RID: 36555 RVA: 0x00150EFE File Offset: 0x0014F0FE
		// (set) Token: 0x06008ECC RID: 36556 RVA: 0x00150F29 File Offset: 0x0014F129
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

		// Token: 0x0400599D RID: 22941
		[Nullable(2)]
		protected new IClientEventPianoUpdateSubtitle FbInstance;

		// Token: 0x0400599E RID: 22942
		[Nullable(2)]
		protected new IClientEventPianoUpdateSubtitle_SetValue PocoInterface;

		// Token: 0x0400599F RID: 22943
		private PlayFlow _FlowCache;

		// Token: 0x040059A0 RID: 22944
		private bool _FlowInited;
	}
}
