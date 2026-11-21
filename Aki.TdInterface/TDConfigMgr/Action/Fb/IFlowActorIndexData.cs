using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A54 RID: 10836
	[NullableContext(2)]
	[Nullable(0)]
	public class IFlowActorIndexData
	{
		// Token: 0x0600EF4B RID: 61259 RVA: 0x002312D5 File Offset: 0x0022F4D5
		[NullableContext(0)]
		public static IFlowActorIndexData Create(IFlowActorIndexData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowActorIndexData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004751 RID: 18257
		// (get) Token: 0x0600EF4C RID: 61260 RVA: 0x002312F4 File Offset: 0x0022F4F4
		public virtual int Index
		{
			get
			{
				return this.Instance.Index;
			}
		}

		// Token: 0x17004752 RID: 18258
		// (get) Token: 0x0600EF4D RID: 61261 RVA: 0x00231301 File Offset: 0x0022F501
		public virtual PosAndRot Offset
		{
			get
			{
				if (this._OffsetInited)
				{
					return this._OffsetCache;
				}
				this._OffsetInited = true;
				this._OffsetCache = PosAndRot.Create(this.Instance.Offset);
				return this._OffsetCache;
			}
		}

		// Token: 0x17004753 RID: 18259
		// (get) Token: 0x0600EF4E RID: 61262 RVA: 0x00231338 File Offset: 0x0022F538
		public virtual bool? IsUseFixedPosition
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsUseFixedPosition);
			}
		}

		// Token: 0x04008378 RID: 33656
		private IFlowActorIndexData Instance;

		// Token: 0x04008379 RID: 33657
		private PosAndRot _OffsetCache;

		// Token: 0x0400837A RID: 33658
		private bool _OffsetInited;
	}
}
