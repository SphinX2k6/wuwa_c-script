using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CD8 RID: 27864
	public class IEnableFunction_UnionUnion
	{
		// Token: 0x1700CC5E RID: 52318
		// (get) Token: 0x0603006C RID: 196716 RVA: 0x00688F25 File Offset: 0x00687125
		// (set) Token: 0x0603006D RID: 196717 RVA: 0x00688F2D File Offset: 0x0068712D
		public IEnableFunction_Union Type { get; set; }

		// Token: 0x1700CC5F RID: 52319
		// (get) Token: 0x0603006E RID: 196718 RVA: 0x00688F36 File Offset: 0x00687136
		// (set) Token: 0x0603006F RID: 196719 RVA: 0x00688F3E File Offset: 0x0068713E
		public object Value { get; set; }

		// Token: 0x06030070 RID: 196720 RVA: 0x00688F47 File Offset: 0x00687147
		public IEnableFunction_UnionUnion()
		{
			this.Type = IEnableFunction_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06030071 RID: 196721 RVA: 0x00688F5D File Offset: 0x0068715D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06030072 RID: 196722 RVA: 0x00688F6F File Offset: 0x0068716F
		public IEnableFunctionT AsIEnableFunction()
		{
			return this.As<IEnableFunctionT>();
		}

		// Token: 0x06030073 RID: 196723 RVA: 0x00688F77 File Offset: 0x00687177
		public static IEnableFunction_UnionUnion FromIEnableFunction(IEnableFunctionT _ienablefunction)
		{
			return new IEnableFunction_UnionUnion
			{
				Type = IEnableFunction_Union.IEnableFunction,
				Value = _ienablefunction
			};
		}

		// Token: 0x06030074 RID: 196724 RVA: 0x00688F8C File Offset: 0x0068718C
		public ITeleportDungeonFunctionT AsITeleportDungeonFunction()
		{
			return this.As<ITeleportDungeonFunctionT>();
		}

		// Token: 0x06030075 RID: 196725 RVA: 0x00688F94 File Offset: 0x00687194
		public static IEnableFunction_UnionUnion FromITeleportDungeonFunction(ITeleportDungeonFunctionT _iteleportdungeonfunction)
		{
			return new IEnableFunction_UnionUnion
			{
				Type = IEnableFunction_Union.ITeleportDungeonFunction,
				Value = _iteleportdungeonfunction
			};
		}

		// Token: 0x06030076 RID: 196726 RVA: 0x00688FA9 File Offset: 0x006871A9
		public IMotorRadioUiFunctionT AsIMotorRadioUiFunction()
		{
			return this.As<IMotorRadioUiFunctionT>();
		}

		// Token: 0x06030077 RID: 196727 RVA: 0x00688FB1 File Offset: 0x006871B1
		public static IEnableFunction_UnionUnion FromIMotorRadioUiFunction(IMotorRadioUiFunctionT _imotorradiouifunction)
		{
			return new IEnableFunction_UnionUnion
			{
				Type = IEnableFunction_Union.IMotorRadioUiFunction,
				Value = _imotorradiouifunction
			};
		}

		// Token: 0x06030078 RID: 196728 RVA: 0x00688FC6 File Offset: 0x006871C6
		public IInteractiveItemsFunctionT AsIInteractiveItemsFunction()
		{
			return this.As<IInteractiveItemsFunctionT>();
		}

		// Token: 0x06030079 RID: 196729 RVA: 0x00688FCE File Offset: 0x006871CE
		public static IEnableFunction_UnionUnion FromIInteractiveItemsFunction(IInteractiveItemsFunctionT _iinteractiveitemsfunction)
		{
			return new IEnableFunction_UnionUnion
			{
				Type = IEnableFunction_Union.IInteractiveItemsFunction,
				Value = _iinteractiveitemsfunction
			};
		}

		// Token: 0x0603007A RID: 196730 RVA: 0x00688FE4 File Offset: 0x006871E4
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
