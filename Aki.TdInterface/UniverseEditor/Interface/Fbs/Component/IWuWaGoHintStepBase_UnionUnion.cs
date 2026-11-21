using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061CC RID: 25036
	public class IWuWaGoHintStepBase_UnionUnion
	{
		// Token: 0x1700BAAE RID: 47790
		// (get) Token: 0x0602A90D RID: 174349 RVA: 0x005CDF9D File Offset: 0x005CC19D
		// (set) Token: 0x0602A90E RID: 174350 RVA: 0x005CDFA5 File Offset: 0x005CC1A5
		public IWuWaGoHintStepBase_Union Type { get; set; }

		// Token: 0x1700BAAF RID: 47791
		// (get) Token: 0x0602A90F RID: 174351 RVA: 0x005CDFAE File Offset: 0x005CC1AE
		// (set) Token: 0x0602A910 RID: 174352 RVA: 0x005CDFB6 File Offset: 0x005CC1B6
		public object Value { get; set; }

		// Token: 0x0602A911 RID: 174353 RVA: 0x005CDFBF File Offset: 0x005CC1BF
		public IWuWaGoHintStepBase_UnionUnion()
		{
			this.Type = IWuWaGoHintStepBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602A912 RID: 174354 RVA: 0x005CDFD5 File Offset: 0x005CC1D5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602A913 RID: 174355 RVA: 0x005CDFE7 File Offset: 0x005CC1E7
		public IWuWaGoHintStepBaseT AsIWuWaGoHintStepBase()
		{
			return this.As<IWuWaGoHintStepBaseT>();
		}

		// Token: 0x0602A914 RID: 174356 RVA: 0x005CDFEF File Offset: 0x005CC1EF
		public static IWuWaGoHintStepBase_UnionUnion FromIWuWaGoHintStepBase(IWuWaGoHintStepBaseT _iwuwagohintstepbase)
		{
			return new IWuWaGoHintStepBase_UnionUnion
			{
				Type = IWuWaGoHintStepBase_Union.IWuWaGoHintStepBase,
				Value = _iwuwagohintstepbase
			};
		}

		// Token: 0x0602A915 RID: 174357 RVA: 0x005CE004 File Offset: 0x005CC204
		public IWuWaGoHintStepMoveT AsIWuWaGoHintStepMove()
		{
			return this.As<IWuWaGoHintStepMoveT>();
		}

		// Token: 0x0602A916 RID: 174358 RVA: 0x005CE00C File Offset: 0x005CC20C
		public static IWuWaGoHintStepBase_UnionUnion FromIWuWaGoHintStepMove(IWuWaGoHintStepMoveT _iwuwagohintstepmove)
		{
			return new IWuWaGoHintStepBase_UnionUnion
			{
				Type = IWuWaGoHintStepBase_Union.IWuWaGoHintStepMove,
				Value = _iwuwagohintstepmove
			};
		}

		// Token: 0x0602A917 RID: 174359 RVA: 0x005CE021 File Offset: 0x005CC221
		public IWuWaGoHintStepInteractT AsIWuWaGoHintStepInteract()
		{
			return this.As<IWuWaGoHintStepInteractT>();
		}

		// Token: 0x0602A918 RID: 174360 RVA: 0x005CE029 File Offset: 0x005CC229
		public static IWuWaGoHintStepBase_UnionUnion FromIWuWaGoHintStepInteract(IWuWaGoHintStepInteractT _iwuwagohintstepinteract)
		{
			return new IWuWaGoHintStepBase_UnionUnion
			{
				Type = IWuWaGoHintStepBase_Union.IWuWaGoHintStepInteract,
				Value = _iwuwagohintstepinteract
			};
		}

		// Token: 0x0602A919 RID: 174361 RVA: 0x005CE040 File Offset: 0x005CC240
		public static int Pack(FlatBufferBuilder builder, IWuWaGoHintStepBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IWuWaGoHintStepBase_Union.IWuWaGoHintStepBase:
				return IWuWaGoHintStepBase.Pack(builder, _o.AsIWuWaGoHintStepBase()).Value;
			case IWuWaGoHintStepBase_Union.IWuWaGoHintStepMove:
				return IWuWaGoHintStepMove.Pack(builder, _o.AsIWuWaGoHintStepMove()).Value;
			case IWuWaGoHintStepBase_Union.IWuWaGoHintStepInteract:
				return IWuWaGoHintStepInteract.Pack(builder, _o.AsIWuWaGoHintStepInteract()).Value;
			default:
				return 0;
			}
		}
	}
}
