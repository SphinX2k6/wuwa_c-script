using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200670A RID: 26378
	public class IActorFaceExpressionType_UnionUnion
	{
		// Token: 0x1700BFBE RID: 49086
		// (get) Token: 0x0602CAA7 RID: 182951 RVA: 0x0061C879 File Offset: 0x0061AA79
		// (set) Token: 0x0602CAA8 RID: 182952 RVA: 0x0061C881 File Offset: 0x0061AA81
		public IActorFaceExpressionType_Union Type { get; set; }

		// Token: 0x1700BFBF RID: 49087
		// (get) Token: 0x0602CAA9 RID: 182953 RVA: 0x0061C88A File Offset: 0x0061AA8A
		// (set) Token: 0x0602CAAA RID: 182954 RVA: 0x0061C892 File Offset: 0x0061AA92
		public object Value { get; set; }

		// Token: 0x0602CAAB RID: 182955 RVA: 0x0061C89B File Offset: 0x0061AA9B
		public IActorFaceExpressionType_UnionUnion()
		{
			this.Type = IActorFaceExpressionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602CAAC RID: 182956 RVA: 0x0061C8B1 File Offset: 0x0061AAB1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602CAAD RID: 182957 RVA: 0x0061C8C3 File Offset: 0x0061AAC3
		public IActorFaceExpressionTypeT AsIActorFaceExpressionType()
		{
			return this.As<IActorFaceExpressionTypeT>();
		}

		// Token: 0x0602CAAE RID: 182958 RVA: 0x0061C8CB File Offset: 0x0061AACB
		public static IActorFaceExpressionType_UnionUnion FromIActorFaceExpressionType(IActorFaceExpressionTypeT _iactorfaceexpressiontype)
		{
			return new IActorFaceExpressionType_UnionUnion
			{
				Type = IActorFaceExpressionType_Union.IActorFaceExpressionType,
				Value = _iactorfaceexpressiontype
			};
		}

		// Token: 0x0602CAAF RID: 182959 RVA: 0x0061C8E0 File Offset: 0x0061AAE0
		public IActorFaceExpressionPlayT AsIActorFaceExpressionPlay()
		{
			return this.As<IActorFaceExpressionPlayT>();
		}

		// Token: 0x0602CAB0 RID: 182960 RVA: 0x0061C8E8 File Offset: 0x0061AAE8
		public static IActorFaceExpressionType_UnionUnion FromIActorFaceExpressionPlay(IActorFaceExpressionPlayT _iactorfaceexpressionplay)
		{
			return new IActorFaceExpressionType_UnionUnion
			{
				Type = IActorFaceExpressionType_Union.IActorFaceExpressionPlay,
				Value = _iactorfaceexpressionplay
			};
		}

		// Token: 0x0602CAB1 RID: 182961 RVA: 0x0061C8FD File Offset: 0x0061AAFD
		public IActorFaceExpressionStopT AsIActorFaceExpressionStop()
		{
			return this.As<IActorFaceExpressionStopT>();
		}

		// Token: 0x0602CAB2 RID: 182962 RVA: 0x0061C905 File Offset: 0x0061AB05
		public static IActorFaceExpressionType_UnionUnion FromIActorFaceExpressionStop(IActorFaceExpressionStopT _iactorfaceexpressionstop)
		{
			return new IActorFaceExpressionType_UnionUnion
			{
				Type = IActorFaceExpressionType_Union.IActorFaceExpressionStop,
				Value = _iactorfaceexpressionstop
			};
		}

		// Token: 0x0602CAB3 RID: 182963 RVA: 0x0061C91C File Offset: 0x0061AB1C
		public static int Pack(FlatBufferBuilder builder, IActorFaceExpressionType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IActorFaceExpressionType_Union.IActorFaceExpressionType:
				return IActorFaceExpressionType.Pack(builder, _o.AsIActorFaceExpressionType()).Value;
			case IActorFaceExpressionType_Union.IActorFaceExpressionPlay:
				return IActorFaceExpressionPlay.Pack(builder, _o.AsIActorFaceExpressionPlay()).Value;
			case IActorFaceExpressionType_Union.IActorFaceExpressionStop:
				return IActorFaceExpressionStop.Pack(builder, _o.AsIActorFaceExpressionStop()).Value;
			default:
				return 0;
			}
		}
	}
}
