using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EE1 RID: 24289
	public class ISceneItemSeqEventCbType_UnionUnion
	{
		// Token: 0x1700B37D RID: 45949
		// (get) Token: 0x06028B7E RID: 166782 RVA: 0x00590D17 File Offset: 0x0058EF17
		// (set) Token: 0x06028B7F RID: 166783 RVA: 0x00590D1F File Offset: 0x0058EF1F
		public ISceneItemSeqEventCbType_Union Type { get; set; }

		// Token: 0x1700B37E RID: 45950
		// (get) Token: 0x06028B80 RID: 166784 RVA: 0x00590D28 File Offset: 0x0058EF28
		// (set) Token: 0x06028B81 RID: 166785 RVA: 0x00590D30 File Offset: 0x0058EF30
		public object Value { get; set; }

		// Token: 0x06028B82 RID: 166786 RVA: 0x00590D39 File Offset: 0x0058EF39
		public ISceneItemSeqEventCbType_UnionUnion()
		{
			this.Type = ISceneItemSeqEventCbType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06028B83 RID: 166787 RVA: 0x00590D4F File Offset: 0x0058EF4F
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028B84 RID: 166788 RVA: 0x00590D61 File Offset: 0x0058EF61
		public ISceneItemSeqEventCbTypeT AsISceneItemSeqEventCbType()
		{
			return this.As<ISceneItemSeqEventCbTypeT>();
		}

		// Token: 0x06028B85 RID: 166789 RVA: 0x00590D69 File Offset: 0x0058EF69
		public static ISceneItemSeqEventCbType_UnionUnion FromISceneItemSeqEventCbType(ISceneItemSeqEventCbTypeT _isceneitemseqeventcbtype)
		{
			return new ISceneItemSeqEventCbType_UnionUnion
			{
				Type = ISceneItemSeqEventCbType_Union.ISceneItemSeqEventCbType,
				Value = _isceneitemseqeventcbtype
			};
		}

		// Token: 0x06028B86 RID: 166790 RVA: 0x00590D7E File Offset: 0x0058EF7E
		public IAnsEventT AsIAnsEvent()
		{
			return this.As<IAnsEventT>();
		}

		// Token: 0x06028B87 RID: 166791 RVA: 0x00590D86 File Offset: 0x0058EF86
		public static ISceneItemSeqEventCbType_UnionUnion FromIAnsEvent(IAnsEventT _iansevent)
		{
			return new ISceneItemSeqEventCbType_UnionUnion
			{
				Type = ISceneItemSeqEventCbType_Union.IAnsEvent,
				Value = _iansevent
			};
		}

		// Token: 0x06028B88 RID: 166792 RVA: 0x00590D9B File Offset: 0x0058EF9B
		public IAnEventT AsIAnEvent()
		{
			return this.As<IAnEventT>();
		}

		// Token: 0x06028B89 RID: 166793 RVA: 0x00590DA3 File Offset: 0x0058EFA3
		public static ISceneItemSeqEventCbType_UnionUnion FromIAnEvent(IAnEventT _ianevent)
		{
			return new ISceneItemSeqEventCbType_UnionUnion
			{
				Type = ISceneItemSeqEventCbType_Union.IAnEvent,
				Value = _ianevent
			};
		}

		// Token: 0x06028B8A RID: 166794 RVA: 0x00590DB8 File Offset: 0x0058EFB8
		public static int Pack(FlatBufferBuilder builder, ISceneItemSeqEventCbType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISceneItemSeqEventCbType_Union.ISceneItemSeqEventCbType:
				return ISceneItemSeqEventCbType.Pack(builder, _o.AsISceneItemSeqEventCbType()).Value;
			case ISceneItemSeqEventCbType_Union.IAnsEvent:
				return IAnsEvent.Pack(builder, _o.AsIAnsEvent()).Value;
			case ISceneItemSeqEventCbType_Union.IAnEvent:
				return IAnEvent.Pack(builder, _o.AsIAnEvent()).Value;
			default:
				return 0;
			}
		}
	}
}
