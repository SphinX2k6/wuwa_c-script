using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005F6 RID: 1526
	[NullableContext(1)]
	[Nullable(0)]
	public class IPetalGrabRoleMotionInteract : IRoleMotionInteractType
	{
		// Token: 0x06002068 RID: 8296 RVA: 0x0005A368 File Offset: 0x00058568
		private IPetalGrabRoleMotionInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPetalGrabRoleMotionInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPetalGrabRoleMotionInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPetalGrabRoleMotionInteract_SetValue());
			}
			return result;
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x0005A3A0 File Offset: 0x000585A0
		public static IPetalGrabRoleMotionInteract Create([Nullable(2)] IPetalGrabRoleMotionInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPetalGrabRoleMotionInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x0005A3B3 File Offset: 0x000585B3
		public static IPetalGrabRoleMotionInteract CreateFromSetValue([Nullable(2)] IPetalGrabRoleMotionInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPetalGrabRoleMotionInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x0005A3C8 File Offset: 0x000585C8
		public new IPetalGrabRoleMotionInteract_SetValue ToSetValue()
		{
			return new IPetalGrabRoleMotionInteract_SetValue
			{
				Type = this.Type,
				HandOption = this.HandOption,
				GrabPointOffset = this.GrabPointOffset,
				GrabEvents = this.GrabEvents,
				NextPointEntityId = this.NextPointEntityId
			};
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x0600206C RID: 8300 RVA: 0x0005A416 File Offset: 0x00058616
		// (set) Token: 0x0600206D RID: 8301 RVA: 0x0005A441 File Offset: 0x00058641
		public override ERoleMotionInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERoleMotionInteractType.PetalGrab;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x0005A44F File Offset: 0x0005864F
		// (set) Token: 0x0600206F RID: 8303 RVA: 0x0005A47A File Offset: 0x0005867A
		public virtual EPetalGrabHandType HandOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HandOption;
				}
				if (this.PocoInterface == null)
				{
					return EPetalGrabHandType.LeftHand;
				}
				return this.PocoInterface.HandOption;
			}
			set
			{
				this.GetOrCreatePoco().HandOption = value;
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06002070 RID: 8304 RVA: 0x0005A488 File Offset: 0x00058688
		// (set) Token: 0x06002071 RID: 8305 RVA: 0x0005A4E9 File Offset: 0x000586E9
		[Nullable(2)]
		public virtual PosAndRot GrabPointOffset
		{
			[NullableContext(2)]
			get
			{
				if (this._GrabPointOffsetInited)
				{
					return this._GrabPointOffsetCache;
				}
				this._GrabPointOffsetInited = true;
				if (this.FbInstance != null)
				{
					this._GrabPointOffsetCache = PosAndRot.Create(this.FbInstance.GrabPointOffset);
				}
				else
				{
					IPetalGrabRoleMotionInteract_SetValue pocoInterface = this.PocoInterface;
					this._GrabPointOffsetCache = ((pocoInterface != null) ? pocoInterface.GrabPointOffset : null);
				}
				return this._GrabPointOffsetCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().GrabPointOffset = value;
				this._GrabPointOffsetInited = false;
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06002072 RID: 8306 RVA: 0x0005A500 File Offset: 0x00058700
		// (set) Token: 0x06002073 RID: 8307 RVA: 0x0005A593 File Offset: 0x00058793
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IPetalGrabEvent> GrabEvents
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._GrabEventsInited)
				{
					return this._GrabEventsCache;
				}
				this._GrabEventsInited = true;
				if (this.FbInstance != null)
				{
					List<IPetalGrabEvent> grabEvents = this.FbInstance.GrabEvents;
					if (grabEvents != null)
					{
						this._GrabEventsCache = new List<IPetalGrabEvent>(grabEvents.Count);
						for (int i = 0; i < grabEvents.Count; i++)
						{
							this._GrabEventsCache.Add(IPetalGrabEvent.Create(grabEvents[i]));
						}
					}
				}
				else
				{
					IPetalGrabRoleMotionInteract_SetValue pocoInterface = this.PocoInterface;
					this._GrabEventsCache = ((pocoInterface != null) ? pocoInterface.GrabEvents : null);
				}
				return this._GrabEventsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().GrabEvents = value;
				this._GrabEventsInited = false;
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06002074 RID: 8308 RVA: 0x0005A5A8 File Offset: 0x000587A8
		// (set) Token: 0x06002075 RID: 8309 RVA: 0x0005A5E2 File Offset: 0x000587E2
		public virtual int? NextPointEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NextPointEntityId;
				}
				IPetalGrabRoleMotionInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.NextPointEntityId;
			}
			set
			{
				this.GetOrCreatePoco().NextPointEntityId = value;
			}
		}

		// Token: 0x040016BA RID: 5818
		[Nullable(2)]
		protected new IPetalGrabRoleMotionInteract FbInstance;

		// Token: 0x040016BB RID: 5819
		[Nullable(2)]
		protected new IPetalGrabRoleMotionInteract_SetValue PocoInterface;

		// Token: 0x040016BC RID: 5820
		private PosAndRot _GrabPointOffsetCache;

		// Token: 0x040016BD RID: 5821
		private bool _GrabPointOffsetInited;

		// Token: 0x040016BE RID: 5822
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IPetalGrabEvent> _GrabEventsCache;

		// Token: 0x040016BF RID: 5823
		private bool _GrabEventsInited;
	}
}
