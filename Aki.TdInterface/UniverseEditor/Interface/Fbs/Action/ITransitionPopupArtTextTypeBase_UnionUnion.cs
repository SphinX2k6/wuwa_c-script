using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C36 RID: 31798
	public class ITransitionPopupArtTextTypeBase_UnionUnion
	{
		// Token: 0x1700EE13 RID: 60947
		// (get) Token: 0x060394FD RID: 234749 RVA: 0x007BD58D File Offset: 0x007BB78D
		// (set) Token: 0x060394FE RID: 234750 RVA: 0x007BD595 File Offset: 0x007BB795
		public ITransitionPopupArtTextTypeBase_Union Type { get; set; }

		// Token: 0x1700EE14 RID: 60948
		// (get) Token: 0x060394FF RID: 234751 RVA: 0x007BD59E File Offset: 0x007BB79E
		// (set) Token: 0x06039500 RID: 234752 RVA: 0x007BD5A6 File Offset: 0x007BB7A6
		public object Value { get; set; }

		// Token: 0x06039501 RID: 234753 RVA: 0x007BD5AF File Offset: 0x007BB7AF
		public ITransitionPopupArtTextTypeBase_UnionUnion()
		{
			this.Type = ITransitionPopupArtTextTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06039502 RID: 234754 RVA: 0x007BD5C5 File Offset: 0x007BB7C5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06039503 RID: 234755 RVA: 0x007BD5D7 File Offset: 0x007BB7D7
		public ITransitionPopupArtTextTypeBaseT AsITransitionPopupArtTextTypeBase()
		{
			return this.As<ITransitionPopupArtTextTypeBaseT>();
		}

		// Token: 0x06039504 RID: 234756 RVA: 0x007BD5DF File Offset: 0x007BB7DF
		public static ITransitionPopupArtTextTypeBase_UnionUnion FromITransitionPopupArtTextTypeBase(ITransitionPopupArtTextTypeBaseT _itransitionpopuparttexttypebase)
		{
			return new ITransitionPopupArtTextTypeBase_UnionUnion
			{
				Type = ITransitionPopupArtTextTypeBase_Union.ITransitionPopupArtTextTypeBase,
				Value = _itransitionpopuparttexttypebase
			};
		}

		// Token: 0x06039505 RID: 234757 RVA: 0x007BD5F4 File Offset: 0x007BB7F4
		public ITransitionPopupYuanChengArtTextT AsITransitionPopupYuanChengArtText()
		{
			return this.As<ITransitionPopupYuanChengArtTextT>();
		}

		// Token: 0x06039506 RID: 234758 RVA: 0x007BD5FC File Offset: 0x007BB7FC
		public static ITransitionPopupArtTextTypeBase_UnionUnion FromITransitionPopupYuanChengArtText(ITransitionPopupYuanChengArtTextT _itransitionpopupyuanchengarttext)
		{
			return new ITransitionPopupArtTextTypeBase_UnionUnion
			{
				Type = ITransitionPopupArtTextTypeBase_Union.ITransitionPopupYuanChengArtText,
				Value = _itransitionpopupyuanchengarttext
			};
		}

		// Token: 0x06039507 RID: 234759 RVA: 0x007BD614 File Offset: 0x007BB814
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
