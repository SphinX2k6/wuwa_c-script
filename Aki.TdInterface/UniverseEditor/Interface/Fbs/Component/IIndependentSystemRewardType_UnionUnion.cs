using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200597C RID: 22908
	public class IIndependentSystemRewardType_UnionUnion
	{
		// Token: 0x1700A666 RID: 42598
		// (get) Token: 0x06025573 RID: 152947 RVA: 0x0051FF9D File Offset: 0x0051E19D
		// (set) Token: 0x06025574 RID: 152948 RVA: 0x0051FFA5 File Offset: 0x0051E1A5
		public IIndependentSystemRewardType_Union Type { get; set; }

		// Token: 0x1700A667 RID: 42599
		// (get) Token: 0x06025575 RID: 152949 RVA: 0x0051FFAE File Offset: 0x0051E1AE
		// (set) Token: 0x06025576 RID: 152950 RVA: 0x0051FFB6 File Offset: 0x0051E1B6
		public object Value { get; set; }

		// Token: 0x06025577 RID: 152951 RVA: 0x0051FFBF File Offset: 0x0051E1BF
		public IIndependentSystemRewardType_UnionUnion()
		{
			this.Type = IIndependentSystemRewardType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025578 RID: 152952 RVA: 0x0051FFD5 File Offset: 0x0051E1D5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025579 RID: 152953 RVA: 0x0051FFE7 File Offset: 0x0051E1E7
		public IIndependentSystemRewardTypeT AsIIndependentSystemRewardType()
		{
			return this.As<IIndependentSystemRewardTypeT>();
		}

		// Token: 0x0602557A RID: 152954 RVA: 0x0051FFEF File Offset: 0x0051E1EF
		public static IIndependentSystemRewardType_UnionUnion FromIIndependentSystemRewardType(IIndependentSystemRewardTypeT _iindependentsystemrewardtype)
		{
			return new IIndependentSystemRewardType_UnionUnion
			{
				Type = IIndependentSystemRewardType_Union.IIndependentSystemRewardType,
				Value = _iindependentsystemrewardtype
			};
		}

		// Token: 0x0602557B RID: 152955 RVA: 0x00520004 File Offset: 0x0051E204
		public IDarkTideIndependentSystemRewardT AsIDarkTideIndependentSystemReward()
		{
			return this.As<IDarkTideIndependentSystemRewardT>();
		}

		// Token: 0x0602557C RID: 152956 RVA: 0x0052000C File Offset: 0x0051E20C
		public static IIndependentSystemRewardType_UnionUnion FromIDarkTideIndependentSystemReward(IDarkTideIndependentSystemRewardT _idarktideindependentsystemreward)
		{
			return new IIndependentSystemRewardType_UnionUnion
			{
				Type = IIndependentSystemRewardType_Union.IDarkTideIndependentSystemReward,
				Value = _idarktideindependentsystemreward
			};
		}

		// Token: 0x0602557D RID: 152957 RVA: 0x00520024 File Offset: 0x0051E224
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
