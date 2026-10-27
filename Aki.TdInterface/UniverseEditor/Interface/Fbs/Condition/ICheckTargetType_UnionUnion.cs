using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B57 RID: 19287
	public class ICheckTargetType_UnionUnion
	{
		// Token: 0x17008BEA RID: 35818
		// (get) Token: 0x0601E5FB RID: 124411 RVA: 0x00441605 File Offset: 0x0043F805
		// (set) Token: 0x0601E5FC RID: 124412 RVA: 0x0044160D File Offset: 0x0043F80D
		public ICheckTargetType_Union Type { get; set; }

		// Token: 0x17008BEB RID: 35819
		// (get) Token: 0x0601E5FD RID: 124413 RVA: 0x00441616 File Offset: 0x0043F816
		// (set) Token: 0x0601E5FE RID: 124414 RVA: 0x0044161E File Offset: 0x0043F81E
		public object Value { get; set; }

		// Token: 0x0601E5FF RID: 124415 RVA: 0x00441627 File Offset: 0x0043F827
		public ICheckTargetType_UnionUnion()
		{
			this.Type = ICheckTargetType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601E600 RID: 124416 RVA: 0x0044163D File Offset: 0x0043F83D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601E601 RID: 124417 RVA: 0x0044164F File Offset: 0x0043F84F
		public ICheckTargetTypeT AsICheckTargetType()
		{
			return this.As<ICheckTargetTypeT>();
		}

		// Token: 0x0601E602 RID: 124418 RVA: 0x00441657 File Offset: 0x0043F857
		public static ICheckTargetType_UnionUnion FromICheckTargetType(ICheckTargetTypeT _ichecktargettype)
		{
			return new ICheckTargetType_UnionUnion
			{
				Type = ICheckTargetType_Union.ICheckTargetType,
				Value = _ichecktargettype
			};
		}

		// Token: 0x0601E603 RID: 124419 RVA: 0x0044166C File Offset: 0x0043F86C
		public IAllPlayerTypeT AsIAllPlayerType()
		{
			return this.As<IAllPlayerTypeT>();
		}

		// Token: 0x0601E604 RID: 124420 RVA: 0x00441674 File Offset: 0x0043F874
		public static ICheckTargetType_UnionUnion FromIAllPlayerType(IAllPlayerTypeT _iallplayertype)
		{
			return new ICheckTargetType_UnionUnion
			{
				Type = ICheckTargetType_Union.IAllPlayerType,
				Value = _iallplayertype
			};
		}

		// Token: 0x0601E605 RID: 124421 RVA: 0x0044168C File Offset: 0x0043F88C
		public static int Pack(FlatBufferBuilder builder, ICheckTargetType_UnionUnion _o)
		{
			ICheckTargetType_Union type = _o.Type;
			if (type == ICheckTargetType_Union.ICheckTargetType)
			{
				return ICheckTargetType.Pack(builder, _o.AsICheckTargetType()).Value;
			}
			if (type != ICheckTargetType_Union.IAllPlayerType)
			{
				return 0;
			}
			return IAllPlayerType.Pack(builder, _o.AsIAllPlayerType()).Value;
		}
	}
}
