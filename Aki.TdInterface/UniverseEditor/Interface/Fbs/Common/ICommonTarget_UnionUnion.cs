using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063AE RID: 25518
	public class ICommonTarget_UnionUnion
	{
		// Token: 0x1700BC90 RID: 48272
		// (get) Token: 0x0602B542 RID: 177474 RVA: 0x005E7CE9 File Offset: 0x005E5EE9
		// (set) Token: 0x0602B543 RID: 177475 RVA: 0x005E7CF1 File Offset: 0x005E5EF1
		public ICommonTarget_Union Type { get; set; }

		// Token: 0x1700BC91 RID: 48273
		// (get) Token: 0x0602B544 RID: 177476 RVA: 0x005E7CFA File Offset: 0x005E5EFA
		// (set) Token: 0x0602B545 RID: 177477 RVA: 0x005E7D02 File Offset: 0x005E5F02
		public object Value { get; set; }

		// Token: 0x0602B546 RID: 177478 RVA: 0x005E7D0B File Offset: 0x005E5F0B
		public ICommonTarget_UnionUnion()
		{
			this.Type = ICommonTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B547 RID: 177479 RVA: 0x005E7D21 File Offset: 0x005E5F21
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B548 RID: 177480 RVA: 0x005E7D33 File Offset: 0x005E5F33
		public ICommonTargetT AsICommonTarget()
		{
			return this.As<ICommonTargetT>();
		}

		// Token: 0x0602B549 RID: 177481 RVA: 0x005E7D3B File Offset: 0x005E5F3B
		public static ICommonTarget_UnionUnion FromICommonTarget(ICommonTargetT _icommontarget)
		{
			return new ICommonTarget_UnionUnion
			{
				Type = ICommonTarget_Union.ICommonTarget,
				Value = _icommontarget
			};
		}

		// Token: 0x0602B54A RID: 177482 RVA: 0x005E7D50 File Offset: 0x005E5F50
		public IPlayerTargetT AsIPlayerTarget()
		{
			return this.As<IPlayerTargetT>();
		}

		// Token: 0x0602B54B RID: 177483 RVA: 0x005E7D58 File Offset: 0x005E5F58
		public static ICommonTarget_UnionUnion FromIPlayerTarget(IPlayerTargetT _iplayertarget)
		{
			return new ICommonTarget_UnionUnion
			{
				Type = ICommonTarget_Union.IPlayerTarget,
				Value = _iplayertarget
			};
		}

		// Token: 0x0602B54C RID: 177484 RVA: 0x005E7D6D File Offset: 0x005E5F6D
		public IAssistCharacterTargetT AsIAssistCharacterTarget()
		{
			return this.As<IAssistCharacterTargetT>();
		}

		// Token: 0x0602B54D RID: 177485 RVA: 0x005E7D75 File Offset: 0x005E5F75
		public static ICommonTarget_UnionUnion FromIAssistCharacterTarget(IAssistCharacterTargetT _iassistcharactertarget)
		{
			return new ICommonTarget_UnionUnion
			{
				Type = ICommonTarget_Union.IAssistCharacterTarget,
				Value = _iassistcharactertarget
			};
		}

		// Token: 0x0602B54E RID: 177486 RVA: 0x005E7D8C File Offset: 0x005E5F8C
		public static int Pack(FlatBufferBuilder builder, ICommonTarget_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICommonTarget_Union.ICommonTarget:
				return ICommonTarget.Pack(builder, _o.AsICommonTarget()).Value;
			case ICommonTarget_Union.IPlayerTarget:
				return IPlayerTarget.Pack(builder, _o.AsIPlayerTarget()).Value;
			case ICommonTarget_Union.IAssistCharacterTarget:
				return IAssistCharacterTarget.Pack(builder, _o.AsIAssistCharacterTarget()).Value;
			default:
				return 0;
			}
		}
	}
}
