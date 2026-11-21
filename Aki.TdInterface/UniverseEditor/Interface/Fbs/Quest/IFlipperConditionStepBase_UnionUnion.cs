using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200429C RID: 17052
	public class IFlipperConditionStepBase_UnionUnion
	{
		// Token: 0x1700749C RID: 29852
		// (get) Token: 0x06017DD3 RID: 97747 RVA: 0x00368A5D File Offset: 0x00366C5D
		// (set) Token: 0x06017DD4 RID: 97748 RVA: 0x00368A65 File Offset: 0x00366C65
		public IFlipperConditionStepBase_Union Type { get; set; }

		// Token: 0x1700749D RID: 29853
		// (get) Token: 0x06017DD5 RID: 97749 RVA: 0x00368A6E File Offset: 0x00366C6E
		// (set) Token: 0x06017DD6 RID: 97750 RVA: 0x00368A76 File Offset: 0x00366C76
		public object Value { get; set; }

		// Token: 0x06017DD7 RID: 97751 RVA: 0x00368A7F File Offset: 0x00366C7F
		public IFlipperConditionStepBase_UnionUnion()
		{
			this.Type = IFlipperConditionStepBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06017DD8 RID: 97752 RVA: 0x00368A95 File Offset: 0x00366C95
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06017DD9 RID: 97753 RVA: 0x00368AA7 File Offset: 0x00366CA7
		public IFlipperConditionStepBaseT AsIFlipperConditionStepBase()
		{
			return this.As<IFlipperConditionStepBaseT>();
		}

		// Token: 0x06017DDA RID: 97754 RVA: 0x00368AAF File Offset: 0x00366CAF
		public static IFlipperConditionStepBase_UnionUnion FromIFlipperConditionStepBase(IFlipperConditionStepBaseT _iflipperconditionstepbase)
		{
			return new IFlipperConditionStepBase_UnionUnion
			{
				Type = IFlipperConditionStepBase_Union.IFlipperConditionStepBase,
				Value = _iflipperconditionstepbase
			};
		}

		// Token: 0x06017DDB RID: 97755 RVA: 0x00368AC4 File Offset: 0x00366CC4
		public IFlipperConditionStepFightT AsIFlipperConditionStepFight()
		{
			return this.As<IFlipperConditionStepFightT>();
		}

		// Token: 0x06017DDC RID: 97756 RVA: 0x00368ACC File Offset: 0x00366CCC
		public static IFlipperConditionStepBase_UnionUnion FromIFlipperConditionStepFight(IFlipperConditionStepFightT _iflipperconditionstepfight)
		{
			return new IFlipperConditionStepBase_UnionUnion
			{
				Type = IFlipperConditionStepBase_Union.IFlipperConditionStepFight,
				Value = _iflipperconditionstepfight
			};
		}

		// Token: 0x06017DDD RID: 97757 RVA: 0x00368AE4 File Offset: 0x00366CE4
		public static int Pack(FlatBufferBuilder builder, IFlipperConditionStepBase_UnionUnion _o)
		{
			IFlipperConditionStepBase_Union type = _o.Type;
			if (type == IFlipperConditionStepBase_Union.IFlipperConditionStepBase)
			{
				return IFlipperConditionStepBase.Pack(builder, _o.AsIFlipperConditionStepBase()).Value;
			}
			if (type != IFlipperConditionStepBase_Union.IFlipperConditionStepFight)
			{
				return 0;
			}
			return IFlipperConditionStepFight.Pack(builder, _o.AsIFlipperConditionStepFight()).Value;
		}
	}
}
