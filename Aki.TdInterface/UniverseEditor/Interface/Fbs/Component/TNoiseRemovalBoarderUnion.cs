using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C6D RID: 23661
	public class TNoiseRemovalBoarderUnion
	{
		// Token: 0x1700B226 RID: 45606
		// (get) Token: 0x060288B1 RID: 166065 RVA: 0x0059348E File Offset: 0x0059168E
		// (set) Token: 0x060288B2 RID: 166066 RVA: 0x00593496 File Offset: 0x00591696
		public TNoiseRemovalBoarder Type { get; set; }

		// Token: 0x1700B227 RID: 45607
		// (get) Token: 0x060288B3 RID: 166067 RVA: 0x0059349F File Offset: 0x0059169F
		// (set) Token: 0x060288B4 RID: 166068 RVA: 0x005934A7 File Offset: 0x005916A7
		public object Value { get; set; }

		// Token: 0x060288B5 RID: 166069 RVA: 0x005934B0 File Offset: 0x005916B0
		public TNoiseRemovalBoarderUnion()
		{
			this.Type = TNoiseRemovalBoarder.NONE;
			this.Value = null;
		}

		// Token: 0x060288B6 RID: 166070 RVA: 0x005934C6 File Offset: 0x005916C6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060288B7 RID: 166071 RVA: 0x005934D8 File Offset: 0x005916D8
		public INoiseRemovalBoxBoarderT AsINoiseRemovalBoxBoarder()
		{
			return this.As<INoiseRemovalBoxBoarderT>();
		}

		// Token: 0x060288B8 RID: 166072 RVA: 0x005934E0 File Offset: 0x005916E0
		public static TNoiseRemovalBoarderUnion FromINoiseRemovalBoxBoarder(INoiseRemovalBoxBoarderT _inoiseremovalboxboarder)
		{
			return new TNoiseRemovalBoarderUnion
			{
				Type = TNoiseRemovalBoarder.INoiseRemovalBoxBoarder,
				Value = _inoiseremovalboxboarder
			};
		}

		// Token: 0x060288B9 RID: 166073 RVA: 0x005934F5 File Offset: 0x005916F5
		public INoiseRemovalSphereBoarderT AsINoiseRemovalSphereBoarder()
		{
			return this.As<INoiseRemovalSphereBoarderT>();
		}

		// Token: 0x060288BA RID: 166074 RVA: 0x005934FD File Offset: 0x005916FD
		public static TNoiseRemovalBoarderUnion FromINoiseRemovalSphereBoarder(INoiseRemovalSphereBoarderT _inoiseremovalsphereboarder)
		{
			return new TNoiseRemovalBoarderUnion
			{
				Type = TNoiseRemovalBoarder.INoiseRemovalSphereBoarder,
				Value = _inoiseremovalsphereboarder
			};
		}

		// Token: 0x060288BB RID: 166075 RVA: 0x00593514 File Offset: 0x00591714
		public static int Pack(FlatBufferBuilder builder, TNoiseRemovalBoarderUnion _o)
		{
			TNoiseRemovalBoarder type = _o.Type;
			if (type == TNoiseRemovalBoarder.INoiseRemovalBoxBoarder)
			{
				return INoiseRemovalBoxBoarder.Pack(builder, _o.AsINoiseRemovalBoxBoarder()).Value;
			}
			if (type != TNoiseRemovalBoarder.INoiseRemovalSphereBoarder)
			{
				return 0;
			}
			return INoiseRemovalSphereBoarder.Pack(builder, _o.AsINoiseRemovalSphereBoarder()).Value;
		}
	}
}
