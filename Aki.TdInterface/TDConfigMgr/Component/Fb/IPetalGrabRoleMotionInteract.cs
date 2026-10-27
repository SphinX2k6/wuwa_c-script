using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B1F RID: 2847
	[NullableContext(2)]
	[Nullable(0)]
	public class IPetalGrabRoleMotionInteract : IRoleMotionInteractType
	{
		// Token: 0x060041C0 RID: 16832 RVA: 0x000A8ABB File Offset: 0x000A6CBB
		[NullableContext(1)]
		public static IPetalGrabRoleMotionInteract Create(IPetalGrabRoleMotionInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPetalGrabRoleMotionInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x060041C1 RID: 16833 RVA: 0x000A8ADA File Offset: 0x000A6CDA
		public override ERoleMotionInteractType Type
		{
			get
			{
				return (ERoleMotionInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x060041C2 RID: 16834 RVA: 0x000A8AE7 File Offset: 0x000A6CE7
		public virtual EPetalGrabHandType HandOption
		{
			get
			{
				return (EPetalGrabHandType)this.Instance.HandOption;
			}
		}

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x060041C3 RID: 16835 RVA: 0x000A8AF4 File Offset: 0x000A6CF4
		public virtual PosAndRot GrabPointOffset
		{
			get
			{
				if (this._GrabPointOffsetInited)
				{
					return this._GrabPointOffsetCache;
				}
				this._GrabPointOffsetInited = true;
				this._GrabPointOffsetCache = PosAndRot.Create(this.Instance.GrabPointOffset);
				return this._GrabPointOffsetCache;
			}
		}

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x060041C4 RID: 16836 RVA: 0x000A8B28 File Offset: 0x000A6D28
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
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int grabEventsLength = this.Instance.GrabEventsLength;
				this._GrabEventsCache = new List<IPetalGrabEvent>(grabEventsLength);
				for (int i = 0; i < grabEventsLength; i++)
				{
					this._GrabEventsCache.Add(IPetalGrabEvent.Create(this.Instance.GrabEvents(i)));
				}
				return this._GrabEventsCache;
			}
		}

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x060041C5 RID: 16837 RVA: 0x000A8BA4 File Offset: 0x000A6DA4
		public virtual int? NextPointEntityId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.NextPointEntityId);
			}
		}

		// Token: 0x04002512 RID: 9490
		private IPetalGrabRoleMotionInteract Instance;

		// Token: 0x04002513 RID: 9491
		private PosAndRot _GrabPointOffsetCache;

		// Token: 0x04002514 RID: 9492
		private bool _GrabPointOffsetInited;

		// Token: 0x04002515 RID: 9493
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IPetalGrabEvent> _GrabEventsCache;

		// Token: 0x04002516 RID: 9494
		private bool _GrabEventsInited;
	}
}
