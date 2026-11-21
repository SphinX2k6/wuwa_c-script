using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200507F RID: 20607
	public struct ICompareEntityGroupStateCondition : IFlatbufferObject
	{
		// Token: 0x17009381 RID: 37761
		// (get) Token: 0x060203A8 RID: 132008 RVA: 0x00477864 File Offset: 0x00475A64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060203A9 RID: 132009 RVA: 0x00477871 File Offset: 0x00475A71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060203AA RID: 132010 RVA: 0x00477878 File Offset: 0x00475A78
		public static ICompareEntityGroupStateCondition GetRootAsICompareEntityGroupStateCondition(ByteBuffer _bb)
		{
			return ICompareEntityGroupStateCondition.GetRootAsICompareEntityGroupStateCondition(_bb, default(ICompareEntityGroupStateCondition));
		}

		// Token: 0x060203AB RID: 132011 RVA: 0x00477894 File Offset: 0x00475A94
		public static ICompareEntityGroupStateCondition GetRootAsICompareEntityGroupStateCondition(ByteBuffer _bb, ICompareEntityGroupStateCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060203AC RID: 132012 RVA: 0x004778B1 File Offset: 0x00475AB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060203AD RID: 132013 RVA: 0x004778C0 File Offset: 0x00475AC0
		public ICompareEntityGroupStateCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009382 RID: 37762
		// (get) Token: 0x060203AE RID: 132014 RVA: 0x004778D0 File Offset: 0x00475AD0
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009383 RID: 37763
		// (get) Token: 0x060203AF RID: 132015 RVA: 0x0047790C File Offset: 0x00475B0C
		public IEntityGroupCondition? GroupCondition
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IEntityGroupCondition?(default(IEntityGroupCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060203B0 RID: 132016 RVA: 0x00477969 File Offset: 0x00475B69
		public static Offset<ICompareEntityGroupStateCondition> CreateICompareEntityGroupStateCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, Offset<IEntityGroupCondition> GroupConditionOffset = default(Offset<IEntityGroupCondition>))
		{
			builder.StartTable(2);
			ICompareEntityGroupStateCondition.AddGroupCondition(builder, GroupConditionOffset);
			ICompareEntityGroupStateCondition.AddType(builder, Type);
			return ICompareEntityGroupStateCondition.EndICompareEntityGroupStateCondition(builder);
		}

		// Token: 0x060203B1 RID: 132017 RVA: 0x00477986 File Offset: 0x00475B86
		public static void StartICompareEntityGroupStateCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060203B2 RID: 132018 RVA: 0x0047798F File Offset: 0x00475B8F
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060203B3 RID: 132019 RVA: 0x0047799A File Offset: 0x00475B9A
		public static void AddGroupCondition(FlatBufferBuilder builder, Offset<IEntityGroupCondition> groupConditionOffset)
		{
			builder.AddOffset(1, groupConditionOffset.Value, 0);
		}

		// Token: 0x060203B4 RID: 132020 RVA: 0x004779AA File Offset: 0x00475BAA
		public static Offset<ICompareEntityGroupStateCondition> EndICompareEntityGroupStateCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICompareEntityGroupStateCondition>(builder.EndTable());
		}

		// Token: 0x060203B5 RID: 132021 RVA: 0x004779B8 File Offset: 0x00475BB8
		public ICompareEntityGroupStateConditionT UnPack()
		{
			ICompareEntityGroupStateConditionT compareEntityGroupStateConditionT = new ICompareEntityGroupStateConditionT();
			this.UnPackTo(compareEntityGroupStateConditionT);
			return compareEntityGroupStateConditionT;
		}

		// Token: 0x060203B6 RID: 132022 RVA: 0x004779D4 File Offset: 0x00475BD4
		public void UnPackTo(ICompareEntityGroupStateConditionT _o)
		{
			_o.Type = this.Type;
			_o.GroupCondition = ((this.GroupCondition != null) ? this.GroupCondition.Value.UnPack() : null);
		}

		// Token: 0x060203B7 RID: 132023 RVA: 0x00477A1C File Offset: 0x00475C1C
		public static Offset<ICompareEntityGroupStateCondition> Pack(FlatBufferBuilder builder, ICompareEntityGroupStateConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareEntityGroupStateCondition>);
			}
			Offset<IEntityGroupCondition> groupConditionOffset = (_o.GroupCondition == null) ? default(Offset<IEntityGroupCondition>) : IEntityGroupCondition.Pack(builder, _o.GroupCondition);
			return ICompareEntityGroupStateCondition.CreateICompareEntityGroupStateCondition(builder, _o.Type, groupConditionOffset);
		}

		// Token: 0x0400DF72 RID: 57202
		private Table __p;
	}
}
