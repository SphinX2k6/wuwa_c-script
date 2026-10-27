using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002782 RID: 10114
	[NullableContext(2)]
	[Nullable(0)]
	public class IFlowActorIndexData
	{
		// Token: 0x0600E12D RID: 57645 RVA: 0x00214541 File Offset: 0x00212741
		[NullableContext(1)]
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

		// Token: 0x170043EB RID: 17387
		// (get) Token: 0x0600E12E RID: 57646 RVA: 0x00214560 File Offset: 0x00212760
		public virtual int Index
		{
			get
			{
				return this.Instance.Index;
			}
		}

		// Token: 0x170043EC RID: 17388
		// (get) Token: 0x0600E12F RID: 57647 RVA: 0x0021456D File Offset: 0x0021276D
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

		// Token: 0x170043ED RID: 17389
		// (get) Token: 0x0600E130 RID: 57648 RVA: 0x002145A4 File Offset: 0x002127A4
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

		// Token: 0x04007CC2 RID: 31938
		private IFlowActorIndexData Instance;

		// Token: 0x04007CC3 RID: 31939
		private PosAndRot _OffsetCache;

		// Token: 0x04007CC4 RID: 31940
		private bool _OffsetInited;
	}
}
