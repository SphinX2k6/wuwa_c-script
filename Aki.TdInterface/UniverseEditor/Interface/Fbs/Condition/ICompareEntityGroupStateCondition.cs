using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B95 RID: 19349
	public struct ICompareEntityGroupStateCondition : IFlatbufferObject
	{
		// Token: 0x17008C68 RID: 35944
		// (get) Token: 0x0601E7FC RID: 124924 RVA: 0x00444D00 File Offset: 0x00442F00
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E7FD RID: 124925 RVA: 0x00444D0D File Offset: 0x00442F0D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E7FE RID: 124926 RVA: 0x00444D14 File Offset: 0x00442F14
		public static ICompareEntityGroupStateCondition GetRootAsICompareEntityGroupStateCondition(ByteBuffer _bb)
		{
			return ICompareEntityGroupStateCondition.GetRootAsICompareEntityGroupStateCondition(_bb, default(ICompareEntityGroupStateCondition));
		}

		// Token: 0x0601E7FF RID: 124927 RVA: 0x00444D30 File Offset: 0x00442F30
		public static ICompareEntityGroupStateCondition GetRootAsICompareEntityGroupStateCondition(ByteBuffer _bb, ICompareEntityGroupStateCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E800 RID: 124928 RVA: 0x00444D4D File Offset: 0x00442F4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E801 RID: 124929 RVA: 0x00444D5C File Offset: 0x00442F5C
		public ICompareEntityGroupStateCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C69 RID: 35945
		// (get) Token: 0x0601E802 RID: 124930 RVA: 0x00444D6C File Offset: 0x00442F6C
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

		// Token: 0x17008C6A RID: 35946
		// (get) Token: 0x0601E803 RID: 124931 RVA: 0x00444DA8 File Offset: 0x00442FA8
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

		// Token: 0x0601E804 RID: 124932 RVA: 0x00444E05 File Offset: 0x00443005
		public static Offset<ICompareEntityGroupStateCondition> CreateICompareEntityGroupStateCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, Offset<IEntityGroupCondition> GroupConditionOffset = default(Offset<IEntityGroupCondition>))
		{
			builder.StartTable(2);
			ICompareEntityGroupStateCondition.AddGroupCondition(builder, GroupConditionOffset);
			ICompareEntityGroupStateCondition.AddType(builder, Type);
			return ICompareEntityGroupStateCondition.EndICompareEntityGroupStateCondition(builder);
		}

		// Token: 0x0601E805 RID: 124933 RVA: 0x00444E22 File Offset: 0x00443022
		public static void StartICompareEntityGroupStateCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E806 RID: 124934 RVA: 0x00444E2B File Offset: 0x0044302B
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E807 RID: 124935 RVA: 0x00444E36 File Offset: 0x00443036
		public static void AddGroupCondition(FlatBufferBuilder builder, Offset<IEntityGroupCondition> groupConditionOffset)
		{
			builder.AddOffset(1, groupConditionOffset.Value, 0);
		}

		// Token: 0x0601E808 RID: 124936 RVA: 0x00444E46 File Offset: 0x00443046
		public static Offset<ICompareEntityGroupStateCondition> EndICompareEntityGroupStateCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICompareEntityGroupStateCondition>(builder.EndTable());
		}

		// Token: 0x0601E809 RID: 124937 RVA: 0x00444E54 File Offset: 0x00443054
		public ICompareEntityGroupStateConditionT UnPack()
		{
			ICompareEntityGroupStateConditionT compareEntityGroupStateConditionT = new ICompareEntityGroupStateConditionT();
			this.UnPackTo(compareEntityGroupStateConditionT);
			return compareEntityGroupStateConditionT;
		}

		// Token: 0x0601E80A RID: 124938 RVA: 0x00444E70 File Offset: 0x00443070
		public void UnPackTo(ICompareEntityGroupStateConditionT _o)
		{
			_o.Type = this.Type;
			_o.GroupCondition = ((this.GroupCondition != null) ? this.GroupCondition.Value.UnPack() : null);
		}

		// Token: 0x0601E80B RID: 124939 RVA: 0x00444EB8 File Offset: 0x004430B8
		public static Offset<ICompareEntityGroupStateCondition> Pack(FlatBufferBuilder builder, ICompareEntityGroupStateConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareEntityGroupStateCondition>);
			}
			Offset<IEntityGroupCondition> groupConditionOffset = (_o.GroupCondition == null) ? default(Offset<IEntityGroupCondition>) : IEntityGroupCondition.Pack(builder, _o.GroupCondition);
			return ICompareEntityGroupStateCondition.CreateICompareEntityGroupStateCondition(builder, _o.Type, groupConditionOffset);
		}

		// Token: 0x0400D46D RID: 54381
		private Table __p;
	}
}
