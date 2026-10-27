using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058D4 RID: 22740
	public class ISceneItemSeqEventCbType_UnionUnion
	{
		// Token: 0x1700AA4D RID: 43597
		// (get) Token: 0x0602661C RID: 157212 RVA: 0x0054A1CB File Offset: 0x005483CB
		// (set) Token: 0x0602661D RID: 157213 RVA: 0x0054A1D3 File Offset: 0x005483D3
		public ISceneItemSeqEventCbType_Union Type { get; set; }

		// Token: 0x1700AA4E RID: 43598
		// (get) Token: 0x0602661E RID: 157214 RVA: 0x0054A1DC File Offset: 0x005483DC
		// (set) Token: 0x0602661F RID: 157215 RVA: 0x0054A1E4 File Offset: 0x005483E4
		public object Value { get; set; }

		// Token: 0x06026620 RID: 157216 RVA: 0x0054A1ED File Offset: 0x005483ED
		public ISceneItemSeqEventCbType_UnionUnion()
		{
			this.Type = ISceneItemSeqEventCbType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06026621 RID: 157217 RVA: 0x0054A203 File Offset: 0x00548403
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06026622 RID: 157218 RVA: 0x0054A215 File Offset: 0x00548415
		public ISceneItemSeqEventCbTypeT AsISceneItemSeqEventCbType()
		{
			return this.As<ISceneItemSeqEventCbTypeT>();
		}

		// Token: 0x06026623 RID: 157219 RVA: 0x0054A21D File Offset: 0x0054841D
		public static ISceneItemSeqEventCbType_UnionUnion FromISceneItemSeqEventCbType(ISceneItemSeqEventCbTypeT _isceneitemseqeventcbtype)
		{
			return new ISceneItemSeqEventCbType_UnionUnion
			{
				Type = ISceneItemSeqEventCbType_Union.ISceneItemSeqEventCbType,
				Value = _isceneitemseqeventcbtype
			};
		}

		// Token: 0x06026624 RID: 157220 RVA: 0x0054A232 File Offset: 0x00548432
		public IAnsEventT AsIAnsEvent()
		{
			return this.As<IAnsEventT>();
		}

		// Token: 0x06026625 RID: 157221 RVA: 0x0054A23A File Offset: 0x0054843A
		public static ISceneItemSeqEventCbType_UnionUnion FromIAnsEvent(IAnsEventT _iansevent)
		{
			return new ISceneItemSeqEventCbType_UnionUnion
			{
				Type = ISceneItemSeqEventCbType_Union.IAnsEvent,
				Value = _iansevent
			};
		}

		// Token: 0x06026626 RID: 157222 RVA: 0x0054A24F File Offset: 0x0054844F
		public IAnEventT AsIAnEvent()
		{
			return this.As<IAnEventT>();
		}

		// Token: 0x06026627 RID: 157223 RVA: 0x0054A257 File Offset: 0x00548457
		public static ISceneItemSeqEventCbType_UnionUnion FromIAnEvent(IAnEventT _ianevent)
		{
			return new ISceneItemSeqEventCbType_UnionUnion
			{
				Type = ISceneItemSeqEventCbType_Union.IAnEvent,
				Value = _ianevent
			};
		}

		// Token: 0x06026628 RID: 157224 RVA: 0x0054A26C File Offset: 0x0054846C
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
