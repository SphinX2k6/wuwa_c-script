using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060A8 RID: 24744
	public class IActorFaceExpressionType_UnionUnion
	{
		// Token: 0x1700B653 RID: 46675
		// (get) Token: 0x0602A3C6 RID: 172998 RVA: 0x005D28D1 File Offset: 0x005D0AD1
		// (set) Token: 0x0602A3C7 RID: 172999 RVA: 0x005D28D9 File Offset: 0x005D0AD9
		public IActorFaceExpressionType_Union Type { get; set; }

		// Token: 0x1700B654 RID: 46676
		// (get) Token: 0x0602A3C8 RID: 173000 RVA: 0x005D28E2 File Offset: 0x005D0AE2
		// (set) Token: 0x0602A3C9 RID: 173001 RVA: 0x005D28EA File Offset: 0x005D0AEA
		public object Value { get; set; }

		// Token: 0x0602A3CA RID: 173002 RVA: 0x005D28F3 File Offset: 0x005D0AF3
		public IActorFaceExpressionType_UnionUnion()
		{
			this.Type = IActorFaceExpressionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602A3CB RID: 173003 RVA: 0x005D2909 File Offset: 0x005D0B09
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602A3CC RID: 173004 RVA: 0x005D291B File Offset: 0x005D0B1B
		public IActorFaceExpressionTypeT AsIActorFaceExpressionType()
		{
			return this.As<IActorFaceExpressionTypeT>();
		}

		// Token: 0x0602A3CD RID: 173005 RVA: 0x005D2923 File Offset: 0x005D0B23
		public static IActorFaceExpressionType_UnionUnion FromIActorFaceExpressionType(IActorFaceExpressionTypeT _iactorfaceexpressiontype)
		{
			return new IActorFaceExpressionType_UnionUnion
			{
				Type = IActorFaceExpressionType_Union.IActorFaceExpressionType,
				Value = _iactorfaceexpressiontype
			};
		}

		// Token: 0x0602A3CE RID: 173006 RVA: 0x005D2938 File Offset: 0x005D0B38
		public IActorFaceExpressionPlayT AsIActorFaceExpressionPlay()
		{
			return this.As<IActorFaceExpressionPlayT>();
		}

		// Token: 0x0602A3CF RID: 173007 RVA: 0x005D2940 File Offset: 0x005D0B40
		public static IActorFaceExpressionType_UnionUnion FromIActorFaceExpressionPlay(IActorFaceExpressionPlayT _iactorfaceexpressionplay)
		{
			return new IActorFaceExpressionType_UnionUnion
			{
				Type = IActorFaceExpressionType_Union.IActorFaceExpressionPlay,
				Value = _iactorfaceexpressionplay
			};
		}

		// Token: 0x0602A3D0 RID: 173008 RVA: 0x005D2955 File Offset: 0x005D0B55
		public IActorFaceExpressionStopT AsIActorFaceExpressionStop()
		{
			return this.As<IActorFaceExpressionStopT>();
		}

		// Token: 0x0602A3D1 RID: 173009 RVA: 0x005D295D File Offset: 0x005D0B5D
		public static IActorFaceExpressionType_UnionUnion FromIActorFaceExpressionStop(IActorFaceExpressionStopT _iactorfaceexpressionstop)
		{
			return new IActorFaceExpressionType_UnionUnion
			{
				Type = IActorFaceExpressionType_Union.IActorFaceExpressionStop,
				Value = _iactorfaceexpressionstop
			};
		}

		// Token: 0x0602A3D2 RID: 173010 RVA: 0x005D2974 File Offset: 0x005D0B74
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
