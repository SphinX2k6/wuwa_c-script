using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076B4 RID: 30388
	public class TEnableFunctionRestrictionUnion
	{
		// Token: 0x1700E611 RID: 58897
		// (get) Token: 0x0603746C RID: 226412 RVA: 0x0077D83A File Offset: 0x0077BA3A
		// (set) Token: 0x0603746D RID: 226413 RVA: 0x0077D842 File Offset: 0x0077BA42
		public TEnableFunctionRestriction Type { get; set; }

		// Token: 0x1700E612 RID: 58898
		// (get) Token: 0x0603746E RID: 226414 RVA: 0x0077D84B File Offset: 0x0077BA4B
		// (set) Token: 0x0603746F RID: 226415 RVA: 0x0077D853 File Offset: 0x0077BA53
		public object Value { get; set; }

		// Token: 0x06037470 RID: 226416 RVA: 0x0077D85C File Offset: 0x0077BA5C
		public TEnableFunctionRestrictionUnion()
		{
			this.Type = TEnableFunctionRestriction.NONE;
			this.Value = null;
		}

		// Token: 0x06037471 RID: 226417 RVA: 0x0077D872 File Offset: 0x0077BA72
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037472 RID: 226418 RVA: 0x0077D884 File Offset: 0x0077BA84
		public IInteractiveItemsFunctionT AsIInteractiveItemsFunction()
		{
			return this.As<IInteractiveItemsFunctionT>();
		}

		// Token: 0x06037473 RID: 226419 RVA: 0x0077D88C File Offset: 0x0077BA8C
		public static TEnableFunctionRestrictionUnion FromIInteractiveItemsFunction(IInteractiveItemsFunctionT _iinteractiveitemsfunction)
		{
			return new TEnableFunctionRestrictionUnion
			{
				Type = TEnableFunctionRestriction.IInteractiveItemsFunction,
				Value = _iinteractiveitemsfunction
			};
		}

		// Token: 0x06037474 RID: 226420 RVA: 0x0077D8A1 File Offset: 0x0077BAA1
		public IMotorRadioUiFunctionT AsIMotorRadioUiFunction()
		{
			return this.As<IMotorRadioUiFunctionT>();
		}

		// Token: 0x06037475 RID: 226421 RVA: 0x0077D8A9 File Offset: 0x0077BAA9
		public static TEnableFunctionRestrictionUnion FromIMotorRadioUiFunction(IMotorRadioUiFunctionT _imotorradiouifunction)
		{
			return new TEnableFunctionRestrictionUnion
			{
				Type = TEnableFunctionRestriction.IMotorRadioUiFunction,
				Value = _imotorradiouifunction
			};
		}

		// Token: 0x06037476 RID: 226422 RVA: 0x0077D8BE File Offset: 0x0077BABE
		public ITeleportDungeonFunctionT AsITeleportDungeonFunction()
		{
			return this.As<ITeleportDungeonFunctionT>();
		}

		// Token: 0x06037477 RID: 226423 RVA: 0x0077D8C6 File Offset: 0x0077BAC6
		public static TEnableFunctionRestrictionUnion FromITeleportDungeonFunction(ITeleportDungeonFunctionT _iteleportdungeonfunction)
		{
			return new TEnableFunctionRestrictionUnion
			{
				Type = TEnableFunctionRestriction.ITeleportDungeonFunction,
				Value = _iteleportdungeonfunction
			};
		}

		// Token: 0x06037478 RID: 226424 RVA: 0x0077D8DC File Offset: 0x0077BADC
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
