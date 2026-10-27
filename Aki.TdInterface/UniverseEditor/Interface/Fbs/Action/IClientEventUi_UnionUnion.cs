using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063BC RID: 25532
	public class IClientEventUi_UnionUnion
	{
		// Token: 0x1700BE44 RID: 48708
		// (get) Token: 0x0602C2A1 RID: 180897 RVA: 0x00610778 File Offset: 0x0060E978
		// (set) Token: 0x0602C2A2 RID: 180898 RVA: 0x00610780 File Offset: 0x0060E980
		public IClientEventUi_Union Type { get; set; }

		// Token: 0x1700BE45 RID: 48709
		// (get) Token: 0x0602C2A3 RID: 180899 RVA: 0x00610789 File Offset: 0x0060E989
		// (set) Token: 0x0602C2A4 RID: 180900 RVA: 0x00610791 File Offset: 0x0060E991
		public object Value { get; set; }

		// Token: 0x0602C2A5 RID: 180901 RVA: 0x0061079A File Offset: 0x0060E99A
		public IClientEventUi_UnionUnion()
		{
			this.Type = IClientEventUi_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602C2A6 RID: 180902 RVA: 0x006107B0 File Offset: 0x0060E9B0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602C2A7 RID: 180903 RVA: 0x006107C2 File Offset: 0x0060E9C2
		public IClientEventUiT AsIClientEventUi()
		{
			return this.As<IClientEventUiT>();
		}

		// Token: 0x0602C2A8 RID: 180904 RVA: 0x006107CA File Offset: 0x0060E9CA
		public static IClientEventUi_UnionUnion FromIClientEventUi(IClientEventUiT _iclienteventui)
		{
			return new IClientEventUi_UnionUnion
			{
				Type = IClientEventUi_Union.IClientEventUi,
				Value = _iclienteventui
			};
		}

		// Token: 0x0602C2A9 RID: 180905 RVA: 0x006107DF File Offset: 0x0060E9DF
		public IClientEventUiPlayPianoT AsIClientEventUiPlayPiano()
		{
			return this.As<IClientEventUiPlayPianoT>();
		}

		// Token: 0x0602C2AA RID: 180906 RVA: 0x006107E7 File Offset: 0x0060E9E7
		public static IClientEventUi_UnionUnion FromIClientEventUiPlayPiano(IClientEventUiPlayPianoT _iclienteventuiplaypiano)
		{
			return new IClientEventUi_UnionUnion
			{
				Type = IClientEventUi_Union.IClientEventUiPlayPiano,
				Value = _iclienteventuiplaypiano
			};
		}

		// Token: 0x0602C2AB RID: 180907 RVA: 0x006107FC File Offset: 0x0060E9FC
		public IClientEventUiFlyingFlowerT AsIClientEventUiFlyingFlower()
		{
			return this.As<IClientEventUiFlyingFlowerT>();
		}

		// Token: 0x0602C2AC RID: 180908 RVA: 0x00610804 File Offset: 0x0060EA04
		public static IClientEventUi_UnionUnion FromIClientEventUiFlyingFlower(IClientEventUiFlyingFlowerT _iclienteventuiflyingflower)
		{
			return new IClientEventUi_UnionUnion
			{
				Type = IClientEventUi_Union.IClientEventUiFlyingFlower,
				Value = _iclienteventuiflyingflower
			};
		}

		// Token: 0x0602C2AD RID: 180909 RVA: 0x0061081C File Offset: 0x0060EA1C
		public static int Pack(FlatBufferBuilder builder, IClientEventUi_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IClientEventUi_Union.IClientEventUi:
				return IClientEventUi.Pack(builder, _o.AsIClientEventUi()).Value;
			case IClientEventUi_Union.IClientEventUiPlayPiano:
				return IClientEventUiPlayPiano.Pack(builder, _o.AsIClientEventUiPlayPiano()).Value;
			case IClientEventUi_Union.IClientEventUiFlyingFlower:
				return IClientEventUiFlyingFlower.Pack(builder, _o.AsIClientEventUiFlyingFlower()).Value;
			default:
				return 0;
			}
		}
	}
}
