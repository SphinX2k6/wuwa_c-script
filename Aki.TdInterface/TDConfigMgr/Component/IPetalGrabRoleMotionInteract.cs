using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000693 RID: 1683
	[NullableContext(2)]
	[Nullable(0)]
	public class IPetalGrabRoleMotionInteract : IRoleMotionInteractType
	{
		// Token: 0x0600236A RID: 9066 RVA: 0x00060FE4 File Offset: 0x0005F1E4
		[NullableContext(0)]
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

		// Token: 0x0600236B RID: 9067 RVA: 0x0006101C File Offset: 0x0005F21C
		[NullableContext(0)]
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

		// Token: 0x0600236C RID: 9068 RVA: 0x0006102F File Offset: 0x0005F22F
		[NullableContext(0)]
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

		// Token: 0x0600236D RID: 9069 RVA: 0x00061044 File Offset: 0x0005F244
		[NullableContext(0)]
		public new IPetalGrabRoleMotionInteract_SetValue ToSetValue()
		{
			return new IPetalGrabRoleMotionInteract_SetValue
			{
				Type = this.Type,
				HandOption = this.HandOption,
				GrabPointOffset = this.GrabPointOffset,
				GrabEvents = this.GrabEvents,
				NextPointEntityId = this.NextPointEntityId,
				FlightSplineId = this.FlightSplineId,
				FlightSplineMovePattern = this.FlightSplineMovePattern
			};
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x0600236E RID: 9070 RVA: 0x000610AA File Offset: 0x0005F2AA
		// (set) Token: 0x0600236F RID: 9071 RVA: 0x000610D5 File Offset: 0x0005F2D5
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

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06002370 RID: 9072 RVA: 0x000610E3 File Offset: 0x0005F2E3
		// (set) Token: 0x06002371 RID: 9073 RVA: 0x0006110E File Offset: 0x0005F30E
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

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06002372 RID: 9074 RVA: 0x0006111C File Offset: 0x0005F31C
		// (set) Token: 0x06002373 RID: 9075 RVA: 0x0006117D File Offset: 0x0005F37D
		public virtual PosAndRot GrabPointOffset
		{
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
			set
			{
				this.GetOrCreatePoco().GrabPointOffset = value;
				this._GrabPointOffsetInited = false;
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06002374 RID: 9076 RVA: 0x00061194 File Offset: 0x0005F394
		// (set) Token: 0x06002375 RID: 9077 RVA: 0x00061227 File Offset: 0x0005F427
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IPetalGrabEvent> GrabEvents
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().GrabEvents = value;
				this._GrabEventsInited = false;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06002376 RID: 9078 RVA: 0x0006123C File Offset: 0x0005F43C
		// (set) Token: 0x06002377 RID: 9079 RVA: 0x00061276 File Offset: 0x0005F476
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

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06002378 RID: 9080 RVA: 0x00061284 File Offset: 0x0005F484
		// (set) Token: 0x06002379 RID: 9081 RVA: 0x000612BE File Offset: 0x0005F4BE
		public virtual int? FlightSplineId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FlightSplineId;
				}
				IPetalGrabRoleMotionInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FlightSplineId;
			}
			set
			{
				this.GetOrCreatePoco().FlightSplineId = value;
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x0600237A RID: 9082 RVA: 0x000612CC File Offset: 0x0005F4CC
		// (set) Token: 0x0600237B RID: 9083 RVA: 0x000612F3 File Offset: 0x0005F4F3
		public virtual ISplineMovePattern FlightSplineMovePattern
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FlightSplineMovePattern;
				}
				IPetalGrabRoleMotionInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FlightSplineMovePattern;
			}
			set
			{
				this.GetOrCreatePoco().FlightSplineMovePattern = value;
			}
		}

		// Token: 0x040018AA RID: 6314
		protected new IPetalGrabRoleMotionInteract FbInstance;

		// Token: 0x040018AB RID: 6315
		protected new IPetalGrabRoleMotionInteract_SetValue PocoInterface;

		// Token: 0x040018AC RID: 6316
		[Nullable(0)]
		private PosAndRot _GrabPointOffsetCache;

		// Token: 0x040018AD RID: 6317
		private bool _GrabPointOffsetInited;

		// Token: 0x040018AE RID: 6318
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IPetalGrabEvent> _GrabEventsCache;

		// Token: 0x040018AF RID: 6319
		private bool _GrabEventsInited;
	}
}
