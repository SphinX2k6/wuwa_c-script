using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053F6 RID: 21494
	public class IIndependentSystemRewardType_UnionUnion
	{
		// Token: 0x17009E2C RID: 40492
		// (get) Token: 0x060234BB RID: 144571 RVA: 0x004E2F71 File Offset: 0x004E1171
		// (set) Token: 0x060234BC RID: 144572 RVA: 0x004E2F79 File Offset: 0x004E1179
		public IIndependentSystemRewardType_Union Type { get; set; }

		// Token: 0x17009E2D RID: 40493
		// (get) Token: 0x060234BD RID: 144573 RVA: 0x004E2F82 File Offset: 0x004E1182
		// (set) Token: 0x060234BE RID: 144574 RVA: 0x004E2F8A File Offset: 0x004E118A
		public object Value { get; set; }

		// Token: 0x060234BF RID: 144575 RVA: 0x004E2F93 File Offset: 0x004E1193
		public IIndependentSystemRewardType_UnionUnion()
		{
			this.Type = IIndependentSystemRewardType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060234C0 RID: 144576 RVA: 0x004E2FA9 File Offset: 0x004E11A9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060234C1 RID: 144577 RVA: 0x004E2FBB File Offset: 0x004E11BB
		public IIndependentSystemRewardTypeT AsIIndependentSystemRewardType()
		{
			return this.As<IIndependentSystemRewardTypeT>();
		}

		// Token: 0x060234C2 RID: 144578 RVA: 0x004E2FC3 File Offset: 0x004E11C3
		public static IIndependentSystemRewardType_UnionUnion FromIIndependentSystemRewardType(IIndependentSystemRewardTypeT _iindependentsystemrewardtype)
		{
			return new IIndependentSystemRewardType_UnionUnion
			{
				Type = IIndependentSystemRewardType_Union.IIndependentSystemRewardType,
				Value = _iindependentsystemrewardtype
			};
		}

		// Token: 0x060234C3 RID: 144579 RVA: 0x004E2FD8 File Offset: 0x004E11D8
		public IDarkTideIndependentSystemRewardT AsIDarkTideIndependentSystemReward()
		{
			return this.As<IDarkTideIndependentSystemRewardT>();
		}

		// Token: 0x060234C4 RID: 144580 RVA: 0x004E2FE0 File Offset: 0x004E11E0
		public static IIndependentSystemRewardType_UnionUnion FromIDarkTideIndependentSystemReward(IDarkTideIndependentSystemRewardT _idarktideindependentsystemreward)
		{
			return new IIndependentSystemRewardType_UnionUnion
			{
				Type = IIndependentSystemRewardType_Union.IDarkTideIndependentSystemReward,
				Value = _idarktideindependentsystemreward
			};
		}

		// Token: 0x060234C5 RID: 144581 RVA: 0x004E2FF8 File Offset: 0x004E11F8
		public static int Pack(FlatBufferBuilder builder, IIndependentSystemRewardType_UnionUnion _o)
		{
			IIndependentSystemRewardType_Union type = _o.Type;
			if (type == IIndependentSystemRewardType_Union.IIndependentSystemRewardType)
			{
				return IIndependentSystemRewardType.Pack(builder, _o.AsIIndependentSystemRewardType()).Value;
			}
			if (type != IIndependentSystemRewardType_Union.IDarkTideIndependentSystemReward)
			{
				return 0;
			}
			return IDarkTideIndependentSystemReward.Pack(builder, _o.AsIDarkTideIndependentSystemReward()).Value;
		}
	}
}
