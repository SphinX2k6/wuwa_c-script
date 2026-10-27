using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006667 RID: 26215
	public class IEnableFunction_UnionUnion
	{
		// Token: 0x1700C2C0 RID: 49856
		// (get) Token: 0x0602D89B RID: 186523 RVA: 0x0063C3BD File Offset: 0x0063A5BD
		// (set) Token: 0x0602D89C RID: 186524 RVA: 0x0063C3C5 File Offset: 0x0063A5C5
		public IEnableFunction_Union Type { get; set; }

		// Token: 0x1700C2C1 RID: 49857
		// (get) Token: 0x0602D89D RID: 186525 RVA: 0x0063C3CE File Offset: 0x0063A5CE
		// (set) Token: 0x0602D89E RID: 186526 RVA: 0x0063C3D6 File Offset: 0x0063A5D6
		public object Value { get; set; }

		// Token: 0x0602D89F RID: 186527 RVA: 0x0063C3DF File Offset: 0x0063A5DF
		public IEnableFunction_UnionUnion()
		{
			this.Type = IEnableFunction_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602D8A0 RID: 186528 RVA: 0x0063C3F5 File Offset: 0x0063A5F5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602D8A1 RID: 186529 RVA: 0x0063C407 File Offset: 0x0063A607
		public IEnableFunctionT AsIEnableFunction()
		{
			return this.As<IEnableFunctionT>();
		}

		// Token: 0x0602D8A2 RID: 186530 RVA: 0x0063C40F File Offset: 0x0063A60F
		public static IEnableFunction_UnionUnion FromIEnableFunction(IEnableFunctionT _ienablefunction)
		{
			return new IEnableFunction_UnionUnion
			{
				Type = IEnableFunction_Union.IEnableFunction,
				Value = _ienablefunction
			};
		}

		// Token: 0x0602D8A3 RID: 186531 RVA: 0x0063C424 File Offset: 0x0063A624
		public ITeleportDungeonFunctionT AsITeleportDungeonFunction()
		{
			return this.As<ITeleportDungeonFunctionT>();
		}

		// Token: 0x0602D8A4 RID: 186532 RVA: 0x0063C42C File Offset: 0x0063A62C
		public static IEnableFunction_UnionUnion FromITeleportDungeonFunction(ITeleportDungeonFunctionT _iteleportdungeonfunction)
		{
			return new IEnableFunction_UnionUnion
			{
				Type = IEnableFunction_Union.ITeleportDungeonFunction,
				Value = _iteleportdungeonfunction
			};
		}

		// Token: 0x0602D8A5 RID: 186533 RVA: 0x0063C441 File Offset: 0x0063A641
		public IMotorRadioUiFunctionT AsIMotorRadioUiFunction()
		{
			return this.As<IMotorRadioUiFunctionT>();
		}

		// Token: 0x0602D8A6 RID: 186534 RVA: 0x0063C449 File Offset: 0x0063A649
		public static IEnableFunction_UnionUnion FromIMotorRadioUiFunction(IMotorRadioUiFunctionT _imotorradiouifunction)
		{
			return new IEnableFunction_UnionUnion
			{
				Type = IEnableFunction_Union.IMotorRadioUiFunction,
				Value = _imotorradiouifunction
			};
		}

		// Token: 0x0602D8A7 RID: 186535 RVA: 0x0063C45E File Offset: 0x0063A65E
		public IInteractiveItemsFunctionT AsIInteractiveItemsFunction()
		{
			return this.As<IInteractiveItemsFunctionT>();
		}

		// Token: 0x0602D8A8 RID: 186536 RVA: 0x0063C466 File Offset: 0x0063A666
		public static IEnableFunction_UnionUnion FromIInteractiveItemsFunction(IInteractiveItemsFunctionT _iinteractiveitemsfunction)
		{
			return new IEnableFunction_UnionUnion
			{
				Type = IEnableFunction_Union.IInteractiveItemsFunction,
				Value = _iinteractiveitemsfunction
			};
		}

		// Token: 0x0602D8A9 RID: 186537 RVA: 0x0063C47C File Offset: 0x0063A67C
		public static int Pack(FlatBufferBuilder builder, IEnableFunction_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IEnableFunction_Union.IEnableFunction:
				return IEnableFunction.Pack(builder, _o.AsIEnableFunction()).Value;
			case IEnableFunction_Union.ITeleportDungeonFunction:
				return ITeleportDungeonFunction.Pack(builder, _o.AsITeleportDungeonFunction()).Value;
			case IEnableFunction_Union.IMotorRadioUiFunction:
				return IMotorRadioUiFunction.Pack(builder, _o.AsIMotorRadioUiFunction()).Value;
			case IEnableFunction_Union.IInteractiveItemsFunction:
				return IInteractiveItemsFunction.Pack(builder, _o.AsIInteractiveItemsFunction()).Value;
			default:
				return 0;
			}
		}
	}
}
