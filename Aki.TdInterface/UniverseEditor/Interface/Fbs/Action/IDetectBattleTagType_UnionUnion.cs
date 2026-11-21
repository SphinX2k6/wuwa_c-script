using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C27 RID: 27687
	public class IDetectBattleTagType_UnionUnion
	{
		// Token: 0x1700CAE9 RID: 51945
		// (get) Token: 0x0602FA57 RID: 195159 RVA: 0x0067DC5D File Offset: 0x0067BE5D
		// (set) Token: 0x0602FA58 RID: 195160 RVA: 0x0067DC65 File Offset: 0x0067BE65
		public IDetectBattleTagType_Union Type { get; set; }

		// Token: 0x1700CAEA RID: 51946
		// (get) Token: 0x0602FA59 RID: 195161 RVA: 0x0067DC6E File Offset: 0x0067BE6E
		// (set) Token: 0x0602FA5A RID: 195162 RVA: 0x0067DC76 File Offset: 0x0067BE76
		public object Value { get; set; }

		// Token: 0x0602FA5B RID: 195163 RVA: 0x0067DC7F File Offset: 0x0067BE7F
		public IDetectBattleTagType_UnionUnion()
		{
			this.Type = IDetectBattleTagType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602FA5C RID: 195164 RVA: 0x0067DC95 File Offset: 0x0067BE95
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602FA5D RID: 195165 RVA: 0x0067DCA7 File Offset: 0x0067BEA7
		public IDetectBattleTagTypeT AsIDetectBattleTagType()
		{
			return this.As<IDetectBattleTagTypeT>();
		}

		// Token: 0x0602FA5E RID: 195166 RVA: 0x0067DCAF File Offset: 0x0067BEAF
		public static IDetectBattleTagType_UnionUnion FromIDetectBattleTagType(IDetectBattleTagTypeT _idetectbattletagtype)
		{
			return new IDetectBattleTagType_UnionUnion
			{
				Type = IDetectBattleTagType_Union.IDetectBattleTagType,
				Value = _idetectbattletagtype
			};
		}

		// Token: 0x0602FA5F RID: 195167 RVA: 0x0067DCC4 File Offset: 0x0067BEC4
		public IDetectBattleMonsterOnGroundT AsIDetectBattleMonsterOnGround()
		{
			return this.As<IDetectBattleMonsterOnGroundT>();
		}

		// Token: 0x0602FA60 RID: 195168 RVA: 0x0067DCCC File Offset: 0x0067BECC
		public static IDetectBattleTagType_UnionUnion FromIDetectBattleMonsterOnGround(IDetectBattleMonsterOnGroundT _idetectbattlemonsteronground)
		{
			return new IDetectBattleTagType_UnionUnion
			{
				Type = IDetectBattleTagType_Union.IDetectBattleMonsterOnGround,
				Value = _idetectbattlemonsteronground
			};
		}

		// Token: 0x0602FA61 RID: 195169 RVA: 0x0067DCE4 File Offset: 0x0067BEE4
		public static int Pack(FlatBufferBuilder builder, IDetectBattleTagType_UnionUnion _o)
		{
			IDetectBattleTagType_Union type = _o.Type;
			if (type == IDetectBattleTagType_Union.IDetectBattleTagType)
			{
				return IDetectBattleTagType.Pack(builder, _o.AsIDetectBattleTagType()).Value;
			}
			if (type != IDetectBattleTagType_Union.IDetectBattleMonsterOnGround)
			{
				return 0;
			}
			return IDetectBattleMonsterOnGround.Pack(builder, _o.AsIDetectBattleMonsterOnGround()).Value;
		}
	}
}
