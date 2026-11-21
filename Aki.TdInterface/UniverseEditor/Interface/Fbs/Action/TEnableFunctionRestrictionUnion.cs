using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EBF RID: 32447
	public class TEnableFunctionRestrictionUnion
	{
		// Token: 0x1700F24D RID: 62029
		// (get) Token: 0x0603A90F RID: 239887 RVA: 0x007E198E File Offset: 0x007DFB8E
		// (set) Token: 0x0603A910 RID: 239888 RVA: 0x007E1996 File Offset: 0x007DFB96
		public TEnableFunctionRestriction Type { get; set; }

		// Token: 0x1700F24E RID: 62030
		// (get) Token: 0x0603A911 RID: 239889 RVA: 0x007E199F File Offset: 0x007DFB9F
		// (set) Token: 0x0603A912 RID: 239890 RVA: 0x007E19A7 File Offset: 0x007DFBA7
		public object Value { get; set; }

		// Token: 0x0603A913 RID: 239891 RVA: 0x007E19B0 File Offset: 0x007DFBB0
		public TEnableFunctionRestrictionUnion()
		{
			this.Type = TEnableFunctionRestriction.NONE;
			this.Value = null;
		}

		// Token: 0x0603A914 RID: 239892 RVA: 0x007E19C6 File Offset: 0x007DFBC6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A915 RID: 239893 RVA: 0x007E19D8 File Offset: 0x007DFBD8
		public IInteractiveItemsFunctionT AsIInteractiveItemsFunction()
		{
			return this.As<IInteractiveItemsFunctionT>();
		}

		// Token: 0x0603A916 RID: 239894 RVA: 0x007E19E0 File Offset: 0x007DFBE0
		public static TEnableFunctionRestrictionUnion FromIInteractiveItemsFunction(IInteractiveItemsFunctionT _iinteractiveitemsfunction)
		{
			return new TEnableFunctionRestrictionUnion
			{
				Type = TEnableFunctionRestriction.IInteractiveItemsFunction,
				Value = _iinteractiveitemsfunction
			};
		}

		// Token: 0x0603A917 RID: 239895 RVA: 0x007E19F5 File Offset: 0x007DFBF5
		public IMotorRadioUiFunctionT AsIMotorRadioUiFunction()
		{
			return this.As<IMotorRadioUiFunctionT>();
		}

		// Token: 0x0603A918 RID: 239896 RVA: 0x007E19FD File Offset: 0x007DFBFD
		public static TEnableFunctionRestrictionUnion FromIMotorRadioUiFunction(IMotorRadioUiFunctionT _imotorradiouifunction)
		{
			return new TEnableFunctionRestrictionUnion
			{
				Type = TEnableFunctionRestriction.IMotorRadioUiFunction,
				Value = _imotorradiouifunction
			};
		}

		// Token: 0x0603A919 RID: 239897 RVA: 0x007E1A12 File Offset: 0x007DFC12
		public ITeleportDungeonFunctionT AsITeleportDungeonFunction()
		{
			return this.As<ITeleportDungeonFunctionT>();
		}

		// Token: 0x0603A91A RID: 239898 RVA: 0x007E1A1A File Offset: 0x007DFC1A
		public static TEnableFunctionRestrictionUnion FromITeleportDungeonFunction(ITeleportDungeonFunctionT _iteleportdungeonfunction)
		{
			return new TEnableFunctionRestrictionUnion
			{
				Type = TEnableFunctionRestriction.ITeleportDungeonFunction,
				Value = _iteleportdungeonfunction
			};
		}

		// Token: 0x0603A91B RID: 239899 RVA: 0x007E1A30 File Offset: 0x007DFC30
		public static int Pack(FlatBufferBuilder builder, TEnableFunctionRestrictionUnion _o)
		{
			switch (_o.Type)
			{
			case TEnableFunctionRestriction.IInteractiveItemsFunction:
				return IInteractiveItemsFunction.Pack(builder, _o.AsIInteractiveItemsFunction()).Value;
			case TEnableFunctionRestriction.IMotorRadioUiFunction:
				return IMotorRadioUiFunction.Pack(builder, _o.AsIMotorRadioUiFunction()).Value;
			case TEnableFunctionRestriction.ITeleportDungeonFunction:
				return ITeleportDungeonFunction.Pack(builder, _o.AsITeleportDungeonFunction()).Value;
			default:
				return 0;
			}
		}
	}
}
