using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005490 RID: 21648
	public struct ICategoryMatchingCondition : IFlatbufferObject
	{
		// Token: 0x17009A2E RID: 39470
		// (get) Token: 0x060220EB RID: 139499 RVA: 0x004B1DEE File Offset: 0x004AFFEE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060220EC RID: 139500 RVA: 0x004B1DFB File Offset: 0x004AFFFB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060220ED RID: 139501 RVA: 0x004B1E04 File Offset: 0x004B0004
		public static ICategoryMatchingCondition GetRootAsICategoryMatchingCondition(ByteBuffer _bb)
		{
			return ICategoryMatchingCondition.GetRootAsICategoryMatchingCondition(_bb, default(ICategoryMatchingCondition));
		}

		// Token: 0x060220EE RID: 139502 RVA: 0x004B1E20 File Offset: 0x004B0020
		public static ICategoryMatchingCondition GetRootAsICategoryMatchingCondition(ByteBuffer _bb, ICategoryMatchingCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060220EF RID: 139503 RVA: 0x004B1E3D File Offset: 0x004B003D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060220F0 RID: 139504 RVA: 0x004B1E4C File Offset: 0x004B004C
		public ICategoryMatchingCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A2F RID: 39471
		// (get) Token: 0x060220F1 RID: 139505 RVA: 0x004B1E5C File Offset: 0x004B005C
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

		// Token: 0x17009A30 RID: 39472
		// (get) Token: 0x060220F2 RID: 139506 RVA: 0x004B1EBC File Offset: 0x004B00BC
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

		// Token: 0x060220F3 RID: 139507 RVA: 0x004B1EF3 File Offset: 0x004B00F3
		public Span<byte> GetSelfStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060220F4 RID: 139508 RVA: 0x004B1F02 File Offset: 0x004B0102
		public byte[] GetSelfStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060220F5 RID: 139509 RVA: 0x004B1F10 File Offset: 0x004B0110
		public static Offset<ICategoryMatchingCondition> CreateICategoryMatchingCondition(FlatBufferBuilder builder, Offset<IDynamicEntityMatch> EntityMatchOffset = default(Offset<IDynamicEntityMatch>), StringOffset SelfStateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICategoryMatchingCondition.AddSelfState(builder, SelfStateOffset);
			ICategoryMatchingCondition.AddEntityMatch(builder, EntityMatchOffset);
			return ICategoryMatchingCondition.EndICategoryMatchingCondition(builder);
		}

		// Token: 0x060220F6 RID: 139510 RVA: 0x004B1F2D File Offset: 0x004B012D
		public static void StartICategoryMatchingCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060220F7 RID: 139511 RVA: 0x004B1F36 File Offset: 0x004B0136
		public static void AddEntityMatch(FlatBufferBuilder builder, Offset<IDynamicEntityMatch> entityMatchOffset)
		{
			builder.AddOffset(0, entityMatchOffset.Value, 0);
		}

		// Token: 0x060220F8 RID: 139512 RVA: 0x004B1F46 File Offset: 0x004B0146
		public static void AddSelfState(FlatBufferBuilder builder, StringOffset selfStateOffset)
		{
			builder.AddOffset(1, selfStateOffset.Value, 0);
		}

		// Token: 0x060220F9 RID: 139513 RVA: 0x004B1F56 File Offset: 0x004B0156
		public static Offset<ICategoryMatchingCondition> EndICategoryMatchingCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICategoryMatchingCondition>(builder.EndTable());
		}

		// Token: 0x060220FA RID: 139514 RVA: 0x004B1F64 File Offset: 0x004B0164
		public ICategoryMatchingConditionT UnPack()
		{
			ICategoryMatchingConditionT categoryMatchingConditionT = new ICategoryMatchingConditionT();
			this.UnPackTo(categoryMatchingConditionT);
			return categoryMatchingConditionT;
		}

		// Token: 0x060220FB RID: 139515 RVA: 0x004B1F80 File Offset: 0x004B0180
		public void UnPackTo(ICategoryMatchingConditionT _o)
		{
			_o.EntityMatch = ((this.EntityMatch != null) ? this.EntityMatch.Value.UnPack() : null);
			_o.SelfState = this.SelfState;
		}

		// Token: 0x060220FC RID: 139516 RVA: 0x004B1FC8 File Offset: 0x004B01C8
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

		// Token: 0x0400E99C RID: 59804
		private Table __p;
	}
}
