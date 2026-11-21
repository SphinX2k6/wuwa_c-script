using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BED RID: 3053
	public class IPetalGrabRoleMotionInteract : IRoleMotionInteractType
	{
		// Token: 0x06004617 RID: 17943 RVA: 0x000B2B1B File Offset: 0x000B0D1B
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

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x06004618 RID: 17944 RVA: 0x000B2B3A File Offset: 0x000B0D3A
		public override ERoleMotionInteractType Type
		{
			get
			{
				return (ERoleMotionInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x06004619 RID: 17945 RVA: 0x000B2B47 File Offset: 0x000B0D47
		public virtual EPetalGrabHandType HandOption
		{
			get
			{
				return (EPetalGrabHandType)this.Instance.HandOption;
			}
		}

		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x0600461A RID: 17946 RVA: 0x000B2B54 File Offset: 0x000B0D54
		[Nullable(2)]
		public virtual Aki.TDConfigMgr.Action.Fb.PosAndRot GrabPointOffset
		{
			[NullableContext(2)]
			get
			{
				if (this._GrabPointOffsetInited)
				{
					return this._GrabPointOffsetCache;
				}
				this._GrabPointOffsetInited = true;
				this._GrabPointOffsetCache = Aki.TDConfigMgr.Action.Fb.PosAndRot.Create(this.Instance.GrabPointOffset);
				return this._GrabPointOffsetCache;
			}
		}

		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x0600461B RID: 17947 RVA: 0x000B2B88 File Offset: 0x000B0D88
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

		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x0600461C RID: 17948 RVA: 0x000B2C04 File Offset: 0x000B0E04
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

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x0600461D RID: 17949 RVA: 0x000B2C3C File Offset: 0x000B0E3C
		public virtual int? FlightSplineId
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new int?(this.Instance.FlightSplineId);
			}
		}

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x0600461E RID: 17950 RVA: 0x000B2C72 File Offset: 0x000B0E72
		public virtual Aki.TDConfigMgr.Action.ISplineMovePattern FlightSplineMovePattern
		{
			get
			{
				if (this._FlightSplineMovePatternInited)
				{
					return this._FlightSplineMovePatternCache;
				}
				this._FlightSplineMovePatternInited = true;
				this._FlightSplineMovePatternCache = ComponentReadHelper.ReadIPetalGrabRoleMotionInteract_FlightSplineMovePattern(this.Instance);
				return this._FlightSplineMovePatternCache;
			}
		}

		// Token: 0x04002758 RID: 10072
		private IPetalGrabRoleMotionInteract Instance;

		// Token: 0x04002759 RID: 10073
		[Nullable(2)]
		private Aki.TDConfigMgr.Action.Fb.PosAndRot _GrabPointOffsetCache;

		// Token: 0x0400275A RID: 10074
		private bool _GrabPointOffsetInited;

		// Token: 0x0400275B RID: 10075
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IPetalGrabEvent> _GrabEventsCache;

		// Token: 0x0400275C RID: 10076
		private bool _GrabEventsInited;

		// Token: 0x0400275D RID: 10077
		private Aki.TDConfigMgr.Action.ISplineMovePattern _FlightSplineMovePatternCache;

		// Token: 0x0400275E RID: 10078
		private bool _FlightSplineMovePatternInited;
	}
}
