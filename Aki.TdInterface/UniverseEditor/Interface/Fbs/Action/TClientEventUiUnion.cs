using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E83 RID: 32387
	public class TClientEventUiUnion
	{
		// Token: 0x1700F21F RID: 61983
		// (get) Token: 0x0603A7A7 RID: 239527 RVA: 0x007DF2AA File Offset: 0x007DD4AA
		// (set) Token: 0x0603A7A8 RID: 239528 RVA: 0x007DF2B2 File Offset: 0x007DD4B2
		public TClientEventUi Type { get; set; }

		// Token: 0x1700F220 RID: 61984
		// (get) Token: 0x0603A7A9 RID: 239529 RVA: 0x007DF2BB File Offset: 0x007DD4BB
		// (set) Token: 0x0603A7AA RID: 239530 RVA: 0x007DF2C3 File Offset: 0x007DD4C3
		public object Value { get; set; }

		// Token: 0x0603A7AB RID: 239531 RVA: 0x007DF2CC File Offset: 0x007DD4CC
		public TClientEventUiUnion()
		{
			this.Type = TClientEventUi.NONE;
			this.Value = null;
		}

		// Token: 0x0603A7AC RID: 239532 RVA: 0x007DF2E2 File Offset: 0x007DD4E2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A7AD RID: 239533 RVA: 0x007DF2F4 File Offset: 0x007DD4F4
		public IClientEventUiFlyingFlowerT AsIClientEventUiFlyingFlower()
		{
			return this.As<IClientEventUiFlyingFlowerT>();
		}

		// Token: 0x0603A7AE RID: 239534 RVA: 0x007DF2FC File Offset: 0x007DD4FC
		public static TClientEventUiUnion FromIClientEventUiFlyingFlower(IClientEventUiFlyingFlowerT _iclienteventuiflyingflower)
		{
			return new TClientEventUiUnion
			{
				Type = TClientEventUi.IClientEventUiFlyingFlower,
				Value = _iclienteventuiflyingflower
			};
		}

		// Token: 0x0603A7AF RID: 239535 RVA: 0x007DF311 File Offset: 0x007DD511
		public IClientEventUiPlayPianoT AsIClientEventUiPlayPiano()
		{
			return this.As<IClientEventUiPlayPianoT>();
		}

		// Token: 0x0603A7B0 RID: 239536 RVA: 0x007DF319 File Offset: 0x007DD519
		public static TClientEventUiUnion FromIClientEventUiPlayPiano(IClientEventUiPlayPianoT _iclienteventuiplaypiano)
		{
			return new TClientEventUiUnion
			{
				Type = TClientEventUi.IClientEventUiPlayPiano,
				Value = _iclienteventuiplaypiano
			};
		}

		// Token: 0x0603A7B1 RID: 239537 RVA: 0x007DF330 File Offset: 0x007DD530
		public static int Pack(FlatBufferBuilder builder, TClientEventUiUnion _o)
		{
			TClientEventUi type = _o.Type;
			if (type == TClientEventUi.IClientEventUiFlyingFlower)
			{
				return IClientEventUiFlyingFlower.Pack(builder, _o.AsIClientEventUiFlyingFlower()).Value;
			}
			if (type != TClientEventUi.IClientEventUiPlayPiano)
			{
				return 0;
			}
			return IClientEventUiPlayPiano.Pack(builder, _o.AsIClientEventUiPlayPiano()).Value;
		}
	}
}
