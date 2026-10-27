using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006446 RID: 25670
	public class ICloseUiGame_UnionUnion
	{
		// Token: 0x1700BF1D RID: 48925
		// (get) Token: 0x0602C6D2 RID: 181970 RVA: 0x006183A1 File Offset: 0x006165A1
		// (set) Token: 0x0602C6D3 RID: 181971 RVA: 0x006183A9 File Offset: 0x006165A9
		public ICloseUiGame_Union Type { get; set; }

		// Token: 0x1700BF1E RID: 48926
		// (get) Token: 0x0602C6D4 RID: 181972 RVA: 0x006183B2 File Offset: 0x006165B2
		// (set) Token: 0x0602C6D5 RID: 181973 RVA: 0x006183BA File Offset: 0x006165BA
		public object Value { get; set; }

		// Token: 0x0602C6D6 RID: 181974 RVA: 0x006183C3 File Offset: 0x006165C3
		public ICloseUiGame_UnionUnion()
		{
			this.Type = ICloseUiGame_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602C6D7 RID: 181975 RVA: 0x006183D9 File Offset: 0x006165D9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602C6D8 RID: 181976 RVA: 0x006183EB File Offset: 0x006165EB
		public ICloseUiGameT AsICloseUiGame()
		{
			return this.As<ICloseUiGameT>();
		}

		// Token: 0x0602C6D9 RID: 181977 RVA: 0x006183F3 File Offset: 0x006165F3
		public static ICloseUiGame_UnionUnion FromICloseUiGame(ICloseUiGameT _icloseuigame)
		{
			return new ICloseUiGame_UnionUnion
			{
				Type = ICloseUiGame_Union.ICloseUiGame,
				Value = _icloseuigame
			};
		}

		// Token: 0x0602C6DA RID: 181978 RVA: 0x00618408 File Offset: 0x00616608
		public ICloseDragActorT AsICloseDragActor()
		{
			return this.As<ICloseDragActorT>();
		}

		// Token: 0x0602C6DB RID: 181979 RVA: 0x00618410 File Offset: 0x00616610
		public static ICloseUiGame_UnionUnion FromICloseDragActor(ICloseDragActorT _iclosedragactor)
		{
			return new ICloseUiGame_UnionUnion
			{
				Type = ICloseUiGame_Union.ICloseDragActor,
				Value = _iclosedragactor
			};
		}

		// Token: 0x0602C6DC RID: 181980 RVA: 0x00618425 File Offset: 0x00616625
		public ICloseBrokenRockT AsICloseBrokenRock()
		{
			return this.As<ICloseBrokenRockT>();
		}

		// Token: 0x0602C6DD RID: 181981 RVA: 0x0061842D File Offset: 0x0061662D
		public static ICloseUiGame_UnionUnion FromICloseBrokenRock(ICloseBrokenRockT _iclosebrokenrock)
		{
			return new ICloseUiGame_UnionUnion
			{
				Type = ICloseUiGame_Union.ICloseBrokenRock,
				Value = _iclosebrokenrock
			};
		}

		// Token: 0x0602C6DE RID: 181982 RVA: 0x00618442 File Offset: 0x00616642
		public ICloseRideFlyingCarT AsICloseRideFlyingCar()
		{
			return this.As<ICloseRideFlyingCarT>();
		}

		// Token: 0x0602C6DF RID: 181983 RVA: 0x0061844A File Offset: 0x0061664A
		public static ICloseUiGame_UnionUnion FromICloseRideFlyingCar(ICloseRideFlyingCarT _icloserideflyingcar)
		{
			return new ICloseUiGame_UnionUnion
			{
				Type = ICloseUiGame_Union.ICloseRideFlyingCar,
				Value = _icloserideflyingcar
			};
		}

		// Token: 0x0602C6E0 RID: 181984 RVA: 0x00618460 File Offset: 0x00616660
		public static int Pack(FlatBufferBuilder builder, ICloseUiGame_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICloseUiGame_Union.ICloseUiGame:
				return ICloseUiGame.Pack(builder, _o.AsICloseUiGame()).Value;
			case ICloseUiGame_Union.ICloseDragActor:
				return ICloseDragActor.Pack(builder, _o.AsICloseDragActor()).Value;
			case ICloseUiGame_Union.ICloseBrokenRock:
				return ICloseBrokenRock.Pack(builder, _o.AsICloseBrokenRock()).Value;
			case ICloseUiGame_Union.ICloseRideFlyingCar:
				return ICloseRideFlyingCar.Pack(builder, _o.AsICloseRideFlyingCar()).Value;
			default:
				return 0;
			}
		}
	}
}
