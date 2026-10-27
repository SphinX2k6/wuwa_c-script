using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005600 RID: 22016
	public class INoiseRemovalBoarderBase_UnionUnion
	{
		// Token: 0x1700A2E5 RID: 41701
		// (get) Token: 0x06024871 RID: 149617 RVA: 0x0050A79D File Offset: 0x0050899D
		// (set) Token: 0x06024872 RID: 149618 RVA: 0x0050A7A5 File Offset: 0x005089A5
		public INoiseRemovalBoarderBase_Union Type { get; set; }

		// Token: 0x1700A2E6 RID: 41702
		// (get) Token: 0x06024873 RID: 149619 RVA: 0x0050A7AE File Offset: 0x005089AE
		// (set) Token: 0x06024874 RID: 149620 RVA: 0x0050A7B6 File Offset: 0x005089B6
		public object Value { get; set; }

		// Token: 0x06024875 RID: 149621 RVA: 0x0050A7BF File Offset: 0x005089BF
		public INoiseRemovalBoarderBase_UnionUnion()
		{
			this.Type = INoiseRemovalBoarderBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06024876 RID: 149622 RVA: 0x0050A7D5 File Offset: 0x005089D5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06024877 RID: 149623 RVA: 0x0050A7E7 File Offset: 0x005089E7
		public INoiseRemovalBoarderBaseT AsINoiseRemovalBoarderBase()
		{
			return this.As<INoiseRemovalBoarderBaseT>();
		}

		// Token: 0x06024878 RID: 149624 RVA: 0x0050A7EF File Offset: 0x005089EF
		public static INoiseRemovalBoarderBase_UnionUnion FromINoiseRemovalBoarderBase(INoiseRemovalBoarderBaseT _inoiseremovalboarderbase)
		{
			return new INoiseRemovalBoarderBase_UnionUnion
			{
				Type = INoiseRemovalBoarderBase_Union.INoiseRemovalBoarderBase,
				Value = _inoiseremovalboarderbase
			};
		}

		// Token: 0x06024879 RID: 149625 RVA: 0x0050A804 File Offset: 0x00508A04
		public INoiseRemovalBoxBoarderT AsINoiseRemovalBoxBoarder()
		{
			return this.As<INoiseRemovalBoxBoarderT>();
		}

		// Token: 0x0602487A RID: 149626 RVA: 0x0050A80C File Offset: 0x00508A0C
		public static INoiseRemovalBoarderBase_UnionUnion FromINoiseRemovalBoxBoarder(INoiseRemovalBoxBoarderT _inoiseremovalboxboarder)
		{
			return new INoiseRemovalBoarderBase_UnionUnion
			{
				Type = INoiseRemovalBoarderBase_Union.INoiseRemovalBoxBoarder,
				Value = _inoiseremovalboxboarder
			};
		}

		// Token: 0x0602487B RID: 149627 RVA: 0x0050A821 File Offset: 0x00508A21
		public INoiseRemovalSphereBoarderT AsINoiseRemovalSphereBoarder()
		{
			return this.As<INoiseRemovalSphereBoarderT>();
		}

		// Token: 0x0602487C RID: 149628 RVA: 0x0050A829 File Offset: 0x00508A29
		public static INoiseRemovalBoarderBase_UnionUnion FromINoiseRemovalSphereBoarder(INoiseRemovalSphereBoarderT _inoiseremovalsphereboarder)
		{
			return new INoiseRemovalBoarderBase_UnionUnion
			{
				Type = INoiseRemovalBoarderBase_Union.INoiseRemovalSphereBoarder,
				Value = _inoiseremovalsphereboarder
			};
		}

		// Token: 0x0602487D RID: 149629 RVA: 0x0050A840 File Offset: 0x00508A40
		public static int Pack(FlatBufferBuilder builder, INoiseRemovalBoarderBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case INoiseRemovalBoarderBase_Union.INoiseRemovalBoarderBase:
				return INoiseRemovalBoarderBase.Pack(builder, _o.AsINoiseRemovalBoarderBase()).Value;
			case INoiseRemovalBoarderBase_Union.INoiseRemovalBoxBoarder:
				return INoiseRemovalBoxBoarder.Pack(builder, _o.AsINoiseRemovalBoxBoarder()).Value;
			case INoiseRemovalBoarderBase_Union.INoiseRemovalSphereBoarder:
				return INoiseRemovalSphereBoarder.Pack(builder, _o.AsINoiseRemovalSphereBoarder()).Value;
			default:
				return 0;
			}
		}
	}
}
