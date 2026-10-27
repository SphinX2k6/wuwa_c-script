using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F61 RID: 20321
	public struct ICategoryMatchingCondition : IFlatbufferObject
	{
		// Token: 0x170092B5 RID: 37557
		// (get) Token: 0x06020399 RID: 131993 RVA: 0x0047BDFE File Offset: 0x00479FFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602039A RID: 131994 RVA: 0x0047BE0B File Offset: 0x0047A00B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602039B RID: 131995 RVA: 0x0047BE14 File Offset: 0x0047A014
		public static ICategoryMatchingCondition GetRootAsICategoryMatchingCondition(ByteBuffer _bb)
		{
			return ICategoryMatchingCondition.GetRootAsICategoryMatchingCondition(_bb, default(ICategoryMatchingCondition));
		}

		// Token: 0x0602039C RID: 131996 RVA: 0x0047BE30 File Offset: 0x0047A030
		public static ICategoryMatchingCondition GetRootAsICategoryMatchingCondition(ByteBuffer _bb, ICategoryMatchingCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602039D RID: 131997 RVA: 0x0047BE4D File Offset: 0x0047A04D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602039E RID: 131998 RVA: 0x0047BE5C File Offset: 0x0047A05C
		public ICategoryMatchingCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092B6 RID: 37558
		// (get) Token: 0x0602039F RID: 131999 RVA: 0x0047BE6C File Offset: 0x0047A06C
		public IDynamicEntityMatch? EntityMatch
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IDynamicEntityMatch?(default(IDynamicEntityMatch).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170092B7 RID: 37559
		// (get) Token: 0x060203A0 RID: 132000 RVA: 0x0047BECC File Offset: 0x0047A0CC
		public string SelfState
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060203A1 RID: 132001 RVA: 0x0047BF03 File Offset: 0x0047A103
		public Span<byte> GetSelfStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060203A2 RID: 132002 RVA: 0x0047BF12 File Offset: 0x0047A112
		public byte[] GetSelfStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060203A3 RID: 132003 RVA: 0x0047BF20 File Offset: 0x0047A120
		public static Offset<ICategoryMatchingCondition> CreateICategoryMatchingCondition(FlatBufferBuilder builder, Offset<IDynamicEntityMatch> EntityMatchOffset = default(Offset<IDynamicEntityMatch>), StringOffset SelfStateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICategoryMatchingCondition.AddSelfState(builder, SelfStateOffset);
			ICategoryMatchingCondition.AddEntityMatch(builder, EntityMatchOffset);
			return ICategoryMatchingCondition.EndICategoryMatchingCondition(builder);
		}

		// Token: 0x060203A4 RID: 132004 RVA: 0x0047BF3D File Offset: 0x0047A13D
		public static void StartICategoryMatchingCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060203A5 RID: 132005 RVA: 0x0047BF46 File Offset: 0x0047A146
		public static void AddEntityMatch(FlatBufferBuilder builder, Offset<IDynamicEntityMatch> entityMatchOffset)
		{
			builder.AddOffset(0, entityMatchOffset.Value, 0);
		}

		// Token: 0x060203A6 RID: 132006 RVA: 0x0047BF56 File Offset: 0x0047A156
		public static void AddSelfState(FlatBufferBuilder builder, StringOffset selfStateOffset)
		{
			builder.AddOffset(1, selfStateOffset.Value, 0);
		}

		// Token: 0x060203A7 RID: 132007 RVA: 0x0047BF66 File Offset: 0x0047A166
		public static Offset<ICategoryMatchingCondition> EndICategoryMatchingCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICategoryMatchingCondition>(builder.EndTable());
		}

		// Token: 0x060203A8 RID: 132008 RVA: 0x0047BF74 File Offset: 0x0047A174
		public ICategoryMatchingConditionT UnPack()
		{
			ICategoryMatchingConditionT categoryMatchingConditionT = new ICategoryMatchingConditionT();
			this.UnPackTo(categoryMatchingConditionT);
			return categoryMatchingConditionT;
		}

		// Token: 0x060203A9 RID: 132009 RVA: 0x0047BF90 File Offset: 0x0047A190
		public void UnPackTo(ICategoryMatchingConditionT _o)
		{
			_o.EntityMatch = ((this.EntityMatch != null) ? this.EntityMatch.Value.UnPack() : null);
			_o.SelfState = this.SelfState;
		}

		// Token: 0x060203AA RID: 132010 RVA: 0x0047BFD8 File Offset: 0x0047A1D8
		public static Offset<ICategoryMatchingCondition> Pack(FlatBufferBuilder builder, ICategoryMatchingConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICategoryMatchingCondition>);
			}
			Offset<IDynamicEntityMatch> entityMatchOffset = (_o.EntityMatch == null) ? default(Offset<IDynamicEntityMatch>) : IDynamicEntityMatch.Pack(builder, _o.EntityMatch);
			StringOffset selfStateOffset = (_o.SelfState == null) ? default(StringOffset) : builder.CreateString(_o.SelfState);
			return ICategoryMatchingCondition.CreateICategoryMatchingCondition(builder, entityMatchOffset, selfStateOffset);
		}

		// Token: 0x0400DDF2 RID: 56818
		private Table __p;
	}
}
