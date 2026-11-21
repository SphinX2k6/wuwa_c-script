using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A2D RID: 27181
	public class IClientEventUi_UnionUnion
	{
		// Token: 0x1700C7C8 RID: 51144
		// (get) Token: 0x0602EA03 RID: 190979 RVA: 0x0065B7B0 File Offset: 0x006599B0
		// (set) Token: 0x0602EA04 RID: 190980 RVA: 0x0065B7B8 File Offset: 0x006599B8
		public IClientEventUi_Union Type { get; set; }

		// Token: 0x1700C7C9 RID: 51145
		// (get) Token: 0x0602EA05 RID: 190981 RVA: 0x0065B7C1 File Offset: 0x006599C1
		// (set) Token: 0x0602EA06 RID: 190982 RVA: 0x0065B7C9 File Offset: 0x006599C9
		public object Value { get; set; }

		// Token: 0x0602EA07 RID: 190983 RVA: 0x0065B7D2 File Offset: 0x006599D2
		public IClientEventUi_UnionUnion()
		{
			this.Type = IClientEventUi_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602EA08 RID: 190984 RVA: 0x0065B7E8 File Offset: 0x006599E8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602EA09 RID: 190985 RVA: 0x0065B7FA File Offset: 0x006599FA
		public IClientEventUiT AsIClientEventUi()
		{
			return this.As<IClientEventUiT>();
		}

		// Token: 0x0602EA0A RID: 190986 RVA: 0x0065B802 File Offset: 0x00659A02
		public static IClientEventUi_UnionUnion FromIClientEventUi(IClientEventUiT _iclienteventui)
		{
			return new IClientEventUi_UnionUnion
			{
				Type = IClientEventUi_Union.IClientEventUi,
				Value = _iclienteventui
			};
		}

		// Token: 0x0602EA0B RID: 190987 RVA: 0x0065B817 File Offset: 0x00659A17
		public IClientEventUiPlayPianoT AsIClientEventUiPlayPiano()
		{
			return this.As<IClientEventUiPlayPianoT>();
		}

		// Token: 0x0602EA0C RID: 190988 RVA: 0x0065B81F File Offset: 0x00659A1F
		public static IClientEventUi_UnionUnion FromIClientEventUiPlayPiano(IClientEventUiPlayPianoT _iclienteventuiplaypiano)
		{
			return new IClientEventUi_UnionUnion
			{
				Type = IClientEventUi_Union.IClientEventUiPlayPiano,
				Value = _iclienteventuiplaypiano
			};
		}

		// Token: 0x0602EA0D RID: 190989 RVA: 0x0065B834 File Offset: 0x00659A34
		public IClientEventUiFlyingFlowerT AsIClientEventUiFlyingFlower()
		{
			return this.As<IClientEventUiFlyingFlowerT>();
		}

		// Token: 0x0602EA0E RID: 190990 RVA: 0x0065B83C File Offset: 0x00659A3C
		public static IClientEventUi_UnionUnion FromIClientEventUiFlyingFlower(IClientEventUiFlyingFlowerT _iclienteventuiflyingflower)
		{
			return new IClientEventUi_UnionUnion
			{
				Type = IClientEventUi_Union.IClientEventUiFlyingFlower,
				Value = _iclienteventuiflyingflower
			};
		}

		// Token: 0x0602EA0F RID: 190991 RVA: 0x0065B854 File Offset: 0x00659A54
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
