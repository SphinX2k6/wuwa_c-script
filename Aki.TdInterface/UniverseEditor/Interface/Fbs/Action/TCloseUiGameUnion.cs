using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200768A RID: 30346
	public class TCloseUiGameUnion
	{
		// Token: 0x1700E5EF RID: 58863
		// (get) Token: 0x0603735E RID: 226142 RVA: 0x0077B9B0 File Offset: 0x00779BB0
		// (set) Token: 0x0603735F RID: 226143 RVA: 0x0077B9B8 File Offset: 0x00779BB8
		public TCloseUiGame Type { get; set; }

		// Token: 0x1700E5F0 RID: 58864
		// (get) Token: 0x06037360 RID: 226144 RVA: 0x0077B9C1 File Offset: 0x00779BC1
		// (set) Token: 0x06037361 RID: 226145 RVA: 0x0077B9C9 File Offset: 0x00779BC9
		public object Value { get; set; }

		// Token: 0x06037362 RID: 226146 RVA: 0x0077B9D2 File Offset: 0x00779BD2
		public TCloseUiGameUnion()
		{
			this.Type = TCloseUiGame.NONE;
			this.Value = null;
		}

		// Token: 0x06037363 RID: 226147 RVA: 0x0077B9E8 File Offset: 0x00779BE8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037364 RID: 226148 RVA: 0x0077B9FA File Offset: 0x00779BFA
		public ICloseBrokenRockT AsICloseBrokenRock()
		{
			return this.As<ICloseBrokenRockT>();
		}

		// Token: 0x06037365 RID: 226149 RVA: 0x0077BA02 File Offset: 0x00779C02
		public static TCloseUiGameUnion FromICloseBrokenRock(ICloseBrokenRockT _iclosebrokenrock)
		{
			return new TCloseUiGameUnion
			{
				Type = TCloseUiGame.ICloseBrokenRock,
				Value = _iclosebrokenrock
			};
		}

		// Token: 0x06037366 RID: 226150 RVA: 0x0077BA17 File Offset: 0x00779C17
		public ICloseDragActorT AsICloseDragActor()
		{
			return this.As<ICloseDragActorT>();
		}

		// Token: 0x06037367 RID: 226151 RVA: 0x0077BA1F File Offset: 0x00779C1F
		public static TCloseUiGameUnion FromICloseDragActor(ICloseDragActorT _iclosedragactor)
		{
			return new TCloseUiGameUnion
			{
				Type = TCloseUiGame.ICloseDragActor,
				Value = _iclosedragactor
			};
		}

		// Token: 0x06037368 RID: 226152 RVA: 0x0077BA34 File Offset: 0x00779C34
		public ICloseRideFlyingCarT AsICloseRideFlyingCar()
		{
			return this.As<ICloseRideFlyingCarT>();
		}

		// Token: 0x06037369 RID: 226153 RVA: 0x0077BA3C File Offset: 0x00779C3C
		public static TCloseUiGameUnion FromICloseRideFlyingCar(ICloseRideFlyingCarT _icloserideflyingcar)
		{
			return new TCloseUiGameUnion
			{
				Type = TCloseUiGame.ICloseRideFlyingCar,
				Value = _icloserideflyingcar
			};
		}

		// Token: 0x0603736A RID: 226154 RVA: 0x0077BA54 File Offset: 0x00779C54
		public static int Pack(FlatBufferBuilder builder, TCloseUiGameUnion _o)
		{
			switch (_o.Type)
			{
			case TCloseUiGame.ICloseBrokenRock:
				return ICloseBrokenRock.Pack(builder, _o.AsICloseBrokenRock()).Value;
			case TCloseUiGame.ICloseDragActor:
				return ICloseDragActor.Pack(builder, _o.AsICloseDragActor()).Value;
			case TCloseUiGame.ICloseRideFlyingCar:
				return ICloseRideFlyingCar.Pack(builder, _o.AsICloseRideFlyingCar()).Value;
			default:
				return 0;
			}
		}
	}
}
