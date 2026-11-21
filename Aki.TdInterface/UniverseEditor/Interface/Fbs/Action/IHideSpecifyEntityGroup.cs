using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FB6 RID: 28598
	public struct IHideSpecifyEntityGroup : IFlatbufferObject
	{
		// Token: 0x1700D16E RID: 53614
		// (get) Token: 0x0603183B RID: 202811 RVA: 0x006B5F2B File Offset: 0x006B412B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603183C RID: 202812 RVA: 0x006B5F38 File Offset: 0x006B4138
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603183D RID: 202813 RVA: 0x006B5F40 File Offset: 0x006B4140
		public static IHideSpecifyEntityGroup GetRootAsIHideSpecifyEntityGroup(ByteBuffer _bb)
		{
			return IHideSpecifyEntityGroup.GetRootAsIHideSpecifyEntityGroup(_bb, default(IHideSpecifyEntityGroup));
		}

		// Token: 0x0603183E RID: 202814 RVA: 0x006B5F5C File Offset: 0x006B415C
		public static IHideSpecifyEntityGroup GetRootAsIHideSpecifyEntityGroup(ByteBuffer _bb, IHideSpecifyEntityGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603183F RID: 202815 RVA: 0x006B5F79 File Offset: 0x006B4179
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031840 RID: 202816 RVA: 0x006B5F88 File Offset: 0x006B4188
		public IHideSpecifyEntityGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D16F RID: 53615
		// (get) Token: 0x06031841 RID: 202817 RVA: 0x006B5F98 File Offset: 0x006B4198
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

		// Token: 0x06031842 RID: 202818 RVA: 0x006B5FD4 File Offset: 0x006B41D4
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D170 RID: 53616
		// (get) Token: 0x06031843 RID: 202819 RVA: 0x006B6014 File Offset: 0x006B4214
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

		// Token: 0x06031844 RID: 202820 RVA: 0x006B603F File Offset: 0x006B423F
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06031845 RID: 202821 RVA: 0x006B604E File Offset: 0x006B424E
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700D171 RID: 53617
		// (get) Token: 0x06031846 RID: 202822 RVA: 0x006B605C File Offset: 0x006B425C
		public bool ForceClean
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D172 RID: 53618
		// (get) Token: 0x06031847 RID: 202823 RVA: 0x006B609C File Offset: 0x006B429C
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

		// Token: 0x06031848 RID: 202824 RVA: 0x006B60D9 File Offset: 0x006B42D9
		public static Offset<IHideSpecifyEntityGroup> CreateIHideSpecifyEntityGroup(FlatBufferBuilder builder, EHideType Type = EHideType.WorldMonsterAndMonsterTreasure, VectorOffset EntityIdsOffset = default(VectorOffset), bool ForceClean = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IHideSpecifyEntityGroup.AddEntityIds(builder, EntityIdsOffset);
			IHideSpecifyEntityGroup.AddNullMask(builder, NullMask);
			IHideSpecifyEntityGroup.AddForceClean(builder, ForceClean);
			IHideSpecifyEntityGroup.AddType(builder, Type);
			return IHideSpecifyEntityGroup.EndIHideSpecifyEntityGroup(builder);
		}

		// Token: 0x06031849 RID: 202825 RVA: 0x006B6105 File Offset: 0x006B4305
		public static void StartIHideSpecifyEntityGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603184A RID: 202826 RVA: 0x006B610E File Offset: 0x006B430E
		public static void AddType(FlatBufferBuilder builder, EHideType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603184B RID: 202827 RVA: 0x006B6119 File Offset: 0x006B4319
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x0603184C RID: 202828 RVA: 0x006B612C File Offset: 0x006B432C
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603184D RID: 202829 RVA: 0x006B6163 File Offset: 0x006B4363
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603184E RID: 202830 RVA: 0x006B617D File Offset: 0x006B437D
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603184F RID: 202831 RVA: 0x006B619B File Offset: 0x006B439B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031850 RID: 202832 RVA: 0x006B61B4 File Offset: 0x006B43B4
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031851 RID: 202833 RVA: 0x006B61BF File Offset: 0x006B43BF
		public static void AddForceClean(FlatBufferBuilder builder, bool forceClean)
		{
			builder.AddBool(2, forceClean, false);
		}

		// Token: 0x06031852 RID: 202834 RVA: 0x006B61CA File Offset: 0x006B43CA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06031853 RID: 202835 RVA: 0x006B61D5 File Offset: 0x006B43D5
		public static Offset<IHideSpecifyEntityGroup> EndIHideSpecifyEntityGroup(FlatBufferBuilder builder)
		{
			return new Offset<IHideSpecifyEntityGroup>(builder.EndTable());
		}

		// Token: 0x06031854 RID: 202836 RVA: 0x006B61E4 File Offset: 0x006B43E4
		public IHideSpecifyEntityGroupT UnPack()
		{
			IHideSpecifyEntityGroupT hideSpecifyEntityGroupT = new IHideSpecifyEntityGroupT();
			this.UnPackTo(hideSpecifyEntityGroupT);
			return hideSpecifyEntityGroupT;
		}

		// Token: 0x06031855 RID: 202837 RVA: 0x006B6200 File Offset: 0x006B4400
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

		// Token: 0x06031856 RID: 202838 RVA: 0x006B6260 File Offset: 0x006B4460
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

		// Token: 0x04011EE2 RID: 73442
		private Table __p;
	}
}
