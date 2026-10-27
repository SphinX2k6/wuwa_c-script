using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200690C RID: 26892
	public struct IHideWorldEntityAndLevelPlay : IFlatbufferObject
	{
		// Token: 0x1700C784 RID: 51076
		// (get) Token: 0x0602EED6 RID: 192214 RVA: 0x0066674C File Offset: 0x0066494C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EED7 RID: 192215 RVA: 0x00666759 File Offset: 0x00664959
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EED8 RID: 192216 RVA: 0x00666760 File Offset: 0x00664960
		public static IHideWorldEntityAndLevelPlay GetRootAsIHideWorldEntityAndLevelPlay(ByteBuffer _bb)
		{
			return IHideWorldEntityAndLevelPlay.GetRootAsIHideWorldEntityAndLevelPlay(_bb, default(IHideWorldEntityAndLevelPlay));
		}

		// Token: 0x0602EED9 RID: 192217 RVA: 0x0066677C File Offset: 0x0066497C
		public static IHideWorldEntityAndLevelPlay GetRootAsIHideWorldEntityAndLevelPlay(ByteBuffer _bb, IHideWorldEntityAndLevelPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EEDA RID: 192218 RVA: 0x00666799 File Offset: 0x00664999
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EEDB RID: 192219 RVA: 0x006667A8 File Offset: 0x006649A8
		public IHideWorldEntityAndLevelPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C785 RID: 51077
		// (get) Token: 0x0602EEDC RID: 192220 RVA: 0x006667B8 File Offset: 0x006649B8
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

		// Token: 0x0602EEDD RID: 192221 RVA: 0x006667F4 File Offset: 0x006649F4
		public int ExcludeEntities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C786 RID: 51078
		// (get) Token: 0x0602EEDE RID: 192222 RVA: 0x00666834 File Offset: 0x00664A34
		public int ExcludeEntitiesLength
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

		// Token: 0x0602EEDF RID: 192223 RVA: 0x0066685F File Offset: 0x00664A5F
		public Span<int> GetExcludeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602EEE0 RID: 192224 RVA: 0x0066686E File Offset: 0x00664A6E
		public int[] GetExcludeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700C787 RID: 51079
		// (get) Token: 0x0602EEE1 RID: 192225 RVA: 0x0066687C File Offset: 0x00664A7C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EEE2 RID: 192226 RVA: 0x006668B8 File Offset: 0x00664AB8
		public static Offset<IHideWorldEntityAndLevelPlay> CreateIHideWorldEntityAndLevelPlay(FlatBufferBuilder builder, EHideType Type = EHideType.WorldMonsterAndMonsterTreasure, VectorOffset ExcludeEntitiesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IHideWorldEntityAndLevelPlay.AddExcludeEntities(builder, ExcludeEntitiesOffset);
			IHideWorldEntityAndLevelPlay.AddNullMask(builder, NullMask);
			IHideWorldEntityAndLevelPlay.AddType(builder, Type);
			return IHideWorldEntityAndLevelPlay.EndIHideWorldEntityAndLevelPlay(builder);
		}

		// Token: 0x0602EEE3 RID: 192227 RVA: 0x006668DC File Offset: 0x00664ADC
		public static void StartIHideWorldEntityAndLevelPlay(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602EEE4 RID: 192228 RVA: 0x006668E5 File Offset: 0x00664AE5
		public static void AddType(FlatBufferBuilder builder, EHideType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EEE5 RID: 192229 RVA: 0x006668F0 File Offset: 0x00664AF0
		public static void AddExcludeEntities(FlatBufferBuilder builder, VectorOffset excludeEntitiesOffset)
		{
			builder.AddOffset(1, excludeEntitiesOffset.Value, 0);
		}

		// Token: 0x0602EEE6 RID: 192230 RVA: 0x00666900 File Offset: 0x00664B00
		public static VectorOffset CreateExcludeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EEE7 RID: 192231 RVA: 0x00666937 File Offset: 0x00664B37
		public static VectorOffset CreateExcludeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EEE8 RID: 192232 RVA: 0x00666951 File Offset: 0x00664B51
		public static VectorOffset CreateExcludeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EEE9 RID: 192233 RVA: 0x0066696F File Offset: 0x00664B6F
		public static VectorOffset CreateExcludeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EEEA RID: 192234 RVA: 0x00666988 File Offset: 0x00664B88
		public static void StartExcludeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602EEEB RID: 192235 RVA: 0x00666993 File Offset: 0x00664B93
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602EEEC RID: 192236 RVA: 0x0066699E File Offset: 0x00664B9E
		public static Offset<IHideWorldEntityAndLevelPlay> EndIHideWorldEntityAndLevelPlay(FlatBufferBuilder builder)
		{
			return new Offset<IHideWorldEntityAndLevelPlay>(builder.EndTable());
		}

		// Token: 0x0602EEED RID: 192237 RVA: 0x006669AC File Offset: 0x00664BAC
		public IHideWorldEntityAndLevelPlayT UnPack()
		{
			IHideWorldEntityAndLevelPlayT hideWorldEntityAndLevelPlayT = new IHideWorldEntityAndLevelPlayT();
			this.UnPackTo(hideWorldEntityAndLevelPlayT);
			return hideWorldEntityAndLevelPlayT;
		}

		// Token: 0x0602EEEE RID: 192238 RVA: 0x006669C8 File Offset: 0x00664BC8
		public void UnPackTo(IHideWorldEntityAndLevelPlayT _o)
		{
			_o.Type = this.Type;
			_o.ExcludeEntities = new List<int>();
			for (int i = 0; i < this.ExcludeEntitiesLength; i++)
			{
				_o.ExcludeEntities.Add(this.ExcludeEntities(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602EEEF RID: 192239 RVA: 0x00666A1C File Offset: 0x00664C1C
		public static Offset<IHideWorldEntityAndLevelPlay> Pack(FlatBufferBuilder builder, IHideWorldEntityAndLevelPlayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideWorldEntityAndLevelPlay>);
			}
			VectorOffset excludeEntitiesOffset = default(VectorOffset);
			if (_o.ExcludeEntities != null)
			{
				int[] data = _o.ExcludeEntities.ToArray();
				excludeEntitiesOffset = IHideWorldEntityAndLevelPlay.CreateExcludeEntitiesVector(builder, data);
			}
			return IHideWorldEntityAndLevelPlay.CreateIHideWorldEntityAndLevelPlay(builder, _o.Type, excludeEntitiesOffset, _o.NullMask);
		}

		// Token: 0x04011084 RID: 69764
		private Table __p;
	}
}
