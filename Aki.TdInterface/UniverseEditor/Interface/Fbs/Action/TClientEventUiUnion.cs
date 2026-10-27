using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007675 RID: 30325
	public class TClientEventUiUnion
	{
		// Token: 0x1700E5E1 RID: 58849
		// (get) Token: 0x06037302 RID: 226050 RVA: 0x0077B1AE File Offset: 0x007793AE
		// (set) Token: 0x06037303 RID: 226051 RVA: 0x0077B1B6 File Offset: 0x007793B6
		public TClientEventUi Type { get; set; }

		// Token: 0x1700E5E2 RID: 58850
		// (get) Token: 0x06037304 RID: 226052 RVA: 0x0077B1BF File Offset: 0x007793BF
		// (set) Token: 0x06037305 RID: 226053 RVA: 0x0077B1C7 File Offset: 0x007793C7
		public object Value { get; set; }

		// Token: 0x06037306 RID: 226054 RVA: 0x0077B1D0 File Offset: 0x007793D0
		public TClientEventUiUnion()
		{
			this.Type = TClientEventUi.NONE;
			this.Value = null;
		}

		// Token: 0x06037307 RID: 226055 RVA: 0x0077B1E6 File Offset: 0x007793E6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037308 RID: 226056 RVA: 0x0077B1F8 File Offset: 0x007793F8
		public IClientEventUiFlyingFlowerT AsIClientEventUiFlyingFlower()
		{
			return this.As<IClientEventUiFlyingFlowerT>();
		}

		// Token: 0x06037309 RID: 226057 RVA: 0x0077B200 File Offset: 0x00779400
		public static TClientEventUiUnion FromIClientEventUiFlyingFlower(IClientEventUiFlyingFlowerT _iclienteventuiflyingflower)
		{
			return new TClientEventUiUnion
			{
				Type = TClientEventUi.IClientEventUiFlyingFlower,
				Value = _iclienteventuiflyingflower
			};
		}

		// Token: 0x0603730A RID: 226058 RVA: 0x0077B215 File Offset: 0x00779415
		public IClientEventUiPlayPianoT AsIClientEventUiPlayPiano()
		{
			return this.As<IClientEventUiPlayPianoT>();
		}

		// Token: 0x0603730B RID: 226059 RVA: 0x0077B21D File Offset: 0x0077941D
		public static TClientEventUiUnion FromIClientEventUiPlayPiano(IClientEventUiPlayPianoT _iclienteventuiplaypiano)
		{
			return new TClientEventUiUnion
			{
				Type = TClientEventUi.IClientEventUiPlayPiano,
				Value = _iclienteventuiplaypiano
			};
		}

		// Token: 0x0603730C RID: 226060 RVA: 0x0077B234 File Offset: 0x00779434
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
