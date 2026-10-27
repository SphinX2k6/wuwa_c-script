using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006903 RID: 26883
	public struct IHideSpecifyEntityGroup : IFlatbufferObject
	{
		// Token: 0x1700C76B RID: 51051
		// (get) Token: 0x0602EE6B RID: 192107 RVA: 0x00665A43 File Offset: 0x00663C43
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EE6C RID: 192108 RVA: 0x00665A50 File Offset: 0x00663C50
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EE6D RID: 192109 RVA: 0x00665A58 File Offset: 0x00663C58
		public static IHideSpecifyEntityGroup GetRootAsIHideSpecifyEntityGroup(ByteBuffer _bb)
		{
			return IHideSpecifyEntityGroup.GetRootAsIHideSpecifyEntityGroup(_bb, default(IHideSpecifyEntityGroup));
		}

		// Token: 0x0602EE6E RID: 192110 RVA: 0x00665A74 File Offset: 0x00663C74
		public static IHideSpecifyEntityGroup GetRootAsIHideSpecifyEntityGroup(ByteBuffer _bb, IHideSpecifyEntityGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EE6F RID: 192111 RVA: 0x00665A91 File Offset: 0x00663C91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EE70 RID: 192112 RVA: 0x00665AA0 File Offset: 0x00663CA0
		public IHideSpecifyEntityGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C76C RID: 51052
		// (get) Token: 0x0602EE71 RID: 192113 RVA: 0x00665AB0 File Offset: 0x00663CB0
		public EHideType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHideType.WorldMonsterAndMonsterTreasure;
				}
				return (EHideType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EE72 RID: 192114 RVA: 0x00665AEC File Offset: 0x00663CEC
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C76D RID: 51053
		// (get) Token: 0x0602EE73 RID: 192115 RVA: 0x00665B2C File Offset: 0x00663D2C
		public int EntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602EE74 RID: 192116 RVA: 0x00665B57 File Offset: 0x00663D57
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602EE75 RID: 192117 RVA: 0x00665B66 File Offset: 0x00663D66
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700C76E RID: 51054
		// (get) Token: 0x0602EE76 RID: 192118 RVA: 0x00665B74 File Offset: 0x00663D74
		public bool ForceClean
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C76F RID: 51055
		// (get) Token: 0x0602EE77 RID: 192119 RVA: 0x00665BB4 File Offset: 0x00663DB4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EE78 RID: 192120 RVA: 0x00665BF1 File Offset: 0x00663DF1
		public static Offset<IHideSpecifyEntityGroup> CreateIHideSpecifyEntityGroup(FlatBufferBuilder builder, EHideType Type = EHideType.WorldMonsterAndMonsterTreasure, VectorOffset EntityIdsOffset = default(VectorOffset), bool ForceClean = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IHideSpecifyEntityGroup.AddEntityIds(builder, EntityIdsOffset);
			IHideSpecifyEntityGroup.AddNullMask(builder, NullMask);
			IHideSpecifyEntityGroup.AddForceClean(builder, ForceClean);
			IHideSpecifyEntityGroup.AddType(builder, Type);
			return IHideSpecifyEntityGroup.EndIHideSpecifyEntityGroup(builder);
		}

		// Token: 0x0602EE79 RID: 192121 RVA: 0x00665C1D File Offset: 0x00663E1D
		public static void StartIHideSpecifyEntityGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602EE7A RID: 192122 RVA: 0x00665C26 File Offset: 0x00663E26
		public static void AddType(FlatBufferBuilder builder, EHideType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EE7B RID: 192123 RVA: 0x00665C31 File Offset: 0x00663E31
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602EE7C RID: 192124 RVA: 0x00665C44 File Offset: 0x00663E44
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EE7D RID: 192125 RVA: 0x00665C7B File Offset: 0x00663E7B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EE7E RID: 192126 RVA: 0x00665C95 File Offset: 0x00663E95
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EE7F RID: 192127 RVA: 0x00665CB3 File Offset: 0x00663EB3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EE80 RID: 192128 RVA: 0x00665CCC File Offset: 0x00663ECC
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602EE81 RID: 192129 RVA: 0x00665CD7 File Offset: 0x00663ED7
		public static void AddForceClean(FlatBufferBuilder builder, bool forceClean)
		{
			builder.AddBool(2, forceClean, false);
		}

		// Token: 0x0602EE82 RID: 192130 RVA: 0x00665CE2 File Offset: 0x00663EE2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602EE83 RID: 192131 RVA: 0x00665CED File Offset: 0x00663EED
		public static Offset<IHideSpecifyEntityGroup> EndIHideSpecifyEntityGroup(FlatBufferBuilder builder)
		{
			return new Offset<IHideSpecifyEntityGroup>(builder.EndTable());
		}

		// Token: 0x0602EE84 RID: 192132 RVA: 0x00665CFC File Offset: 0x00663EFC
		public IHideSpecifyEntityGroupT UnPack()
		{
			IHideSpecifyEntityGroupT hideSpecifyEntityGroupT = new IHideSpecifyEntityGroupT();
			this.UnPackTo(hideSpecifyEntityGroupT);
			return hideSpecifyEntityGroupT;
		}

		// Token: 0x0602EE85 RID: 192133 RVA: 0x00665D18 File Offset: 0x00663F18
		public void UnPackTo(IHideSpecifyEntityGroupT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.ForceClean = this.ForceClean;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602EE86 RID: 192134 RVA: 0x00665D78 File Offset: 0x00663F78
		public static Offset<IHideSpecifyEntityGroup> Pack(FlatBufferBuilder builder, IHideSpecifyEntityGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideSpecifyEntityGroup>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IHideSpecifyEntityGroup.CreateEntityIdsVector(builder, data);
			}
			return IHideSpecifyEntityGroup.CreateIHideSpecifyEntityGroup(builder, _o.Type, entityIdsOffset, _o.ForceClean, _o.NullMask);
		}

		// Token: 0x04011076 RID: 69750
		private Table __p;
	}
}
