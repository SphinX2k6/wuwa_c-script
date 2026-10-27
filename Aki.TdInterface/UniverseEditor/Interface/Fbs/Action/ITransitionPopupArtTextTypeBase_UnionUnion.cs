using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007443 RID: 29763
	public class ITransitionPopupArtTextTypeBase_UnionUnion
	{
		// Token: 0x1700E1F6 RID: 57846
		// (get) Token: 0x06036114 RID: 221460 RVA: 0x0075A861 File Offset: 0x00758A61
		// (set) Token: 0x06036115 RID: 221461 RVA: 0x0075A869 File Offset: 0x00758A69
		public ITransitionPopupArtTextTypeBase_Union Type { get; set; }

		// Token: 0x1700E1F7 RID: 57847
		// (get) Token: 0x06036116 RID: 221462 RVA: 0x0075A872 File Offset: 0x00758A72
		// (set) Token: 0x06036117 RID: 221463 RVA: 0x0075A87A File Offset: 0x00758A7A
		public object Value { get; set; }

		// Token: 0x06036118 RID: 221464 RVA: 0x0075A883 File Offset: 0x00758A83
		public ITransitionPopupArtTextTypeBase_UnionUnion()
		{
			this.Type = ITransitionPopupArtTextTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036119 RID: 221465 RVA: 0x0075A899 File Offset: 0x00758A99
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603611A RID: 221466 RVA: 0x0075A8AB File Offset: 0x00758AAB
		public ITransitionPopupArtTextTypeBaseT AsITransitionPopupArtTextTypeBase()
		{
			return this.As<ITransitionPopupArtTextTypeBaseT>();
		}

		// Token: 0x0603611B RID: 221467 RVA: 0x0075A8B3 File Offset: 0x00758AB3
		public static ITransitionPopupArtTextTypeBase_UnionUnion FromITransitionPopupArtTextTypeBase(ITransitionPopupArtTextTypeBaseT _itransitionpopuparttexttypebase)
		{
			return new ITransitionPopupArtTextTypeBase_UnionUnion
			{
				Type = ITransitionPopupArtTextTypeBase_Union.ITransitionPopupArtTextTypeBase,
				Value = _itransitionpopuparttexttypebase
			};
		}

		// Token: 0x0603611C RID: 221468 RVA: 0x0075A8C8 File Offset: 0x00758AC8
		public ITransitionPopupYuanChengArtTextT AsITransitionPopupYuanChengArtText()
		{
			return this.As<ITransitionPopupYuanChengArtTextT>();
		}

		// Token: 0x0603611D RID: 221469 RVA: 0x0075A8D0 File Offset: 0x00758AD0
		public static ITransitionPopupArtTextTypeBase_UnionUnion FromITransitionPopupYuanChengArtText(ITransitionPopupYuanChengArtTextT _itransitionpopupyuanchengarttext)
		{
			return new ITransitionPopupArtTextTypeBase_UnionUnion
			{
				Type = ITransitionPopupArtTextTypeBase_Union.ITransitionPopupYuanChengArtText,
				Value = _itransitionpopupyuanchengarttext
			};
		}

		// Token: 0x0603611E RID: 221470 RVA: 0x0075A8E8 File Offset: 0x00758AE8
		public static int Pack(FlatBufferBuilder builder, ITransitionPopupArtTextTypeBase_UnionUnion _o)
		{
			ITransitionPopupArtTextTypeBase_Union type = _o.Type;
			if (type == ITransitionPopupArtTextTypeBase_Union.ITransitionPopupArtTextTypeBase)
			{
				return ITransitionPopupArtTextTypeBase.Pack(builder, _o.AsITransitionPopupArtTextTypeBase()).Value;
			}
			if (type != ITransitionPopupArtTextTypeBase_Union.ITransitionPopupYuanChengArtText)
			{
				return 0;
			}
			return ITransitionPopupYuanChengArtText.Pack(builder, _o.AsITransitionPopupYuanChengArtText()).Value;
		}
	}
}
