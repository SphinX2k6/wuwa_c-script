using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054C0 RID: 21696
	public struct ICheckGearHit : IFlatbufferObject
	{
		// Token: 0x17009AD5 RID: 39637
		// (get) Token: 0x0602233D RID: 140093 RVA: 0x004B6EC8 File Offset: 0x004B50C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602233E RID: 140094 RVA: 0x004B6ED5 File Offset: 0x004B50D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602233F RID: 140095 RVA: 0x004B6EDC File Offset: 0x004B50DC
		public static ICheckGearHit GetRootAsICheckGearHit(ByteBuffer _bb)
		{
			return ICheckGearHit.GetRootAsICheckGearHit(_bb, default(ICheckGearHit));
		}

		// Token: 0x06022340 RID: 140096 RVA: 0x004B6EF8 File Offset: 0x004B50F8
		public static ICheckGearHit GetRootAsICheckGearHit(ByteBuffer _bb, ICheckGearHit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022341 RID: 140097 RVA: 0x004B6F15 File Offset: 0x004B5115
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022342 RID: 140098 RVA: 0x004B6F24 File Offset: 0x004B5124
		public ICheckGearHit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009AD6 RID: 39638
		// (get) Token: 0x06022343 RID: 140099 RVA: 0x004B6F34 File Offset: 0x004B5134
		public int HitIndex
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022344 RID: 140100 RVA: 0x004B6F70 File Offset: 0x004B5170
		public int AffectIndex(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009AD7 RID: 39639
		// (get) Token: 0x06022345 RID: 140101 RVA: 0x004B6FB0 File Offset: 0x004B51B0
		public int AffectIndexLength
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

		// Token: 0x06022346 RID: 140102 RVA: 0x004B6FDB File Offset: 0x004B51DB
		public Span<int> GetAffectIndexBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06022347 RID: 140103 RVA: 0x004B6FEA File Offset: 0x004B51EA
		public int[] GetAffectIndexArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17009AD8 RID: 39640
		// (get) Token: 0x06022348 RID: 140104 RVA: 0x004B6FF8 File Offset: 0x004B51F8
		public EGearHitAffectType AffectType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EGearHitAffectType.ChangeNextState;
				}
				return (EGearHitAffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022349 RID: 140105 RVA: 0x004B7034 File Offset: 0x004B5234
		public static Offset<ICheckGearHit> CreateICheckGearHit(FlatBufferBuilder builder, int HitIndex = 0, VectorOffset AffectIndexOffset = default(VectorOffset), EGearHitAffectType AffectType = EGearHitAffectType.ChangeNextState)
		{
			builder.StartTable(3);
			ICheckGearHit.AddAffectIndex(builder, AffectIndexOffset);
			ICheckGearHit.AddHitIndex(builder, HitIndex);
			ICheckGearHit.AddAffectType(builder, AffectType);
			return ICheckGearHit.EndICheckGearHit(builder);
		}

		// Token: 0x0602234A RID: 140106 RVA: 0x004B7058 File Offset: 0x004B5258
		public static void StartICheckGearHit(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602234B RID: 140107 RVA: 0x004B7061 File Offset: 0x004B5261
		public static void AddHitIndex(FlatBufferBuilder builder, int hitIndex)
		{
			builder.AddInt(0, hitIndex, 0);
		}

		// Token: 0x0602234C RID: 140108 RVA: 0x004B706C File Offset: 0x004B526C
		public static void AddAffectIndex(FlatBufferBuilder builder, VectorOffset affectIndexOffset)
		{
			builder.AddOffset(1, affectIndexOffset.Value, 0);
		}

		// Token: 0x0602234D RID: 140109 RVA: 0x004B707C File Offset: 0x004B527C
		public static VectorOffset CreateAffectIndexVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602234E RID: 140110 RVA: 0x004B70B3 File Offset: 0x004B52B3
		public static VectorOffset CreateAffectIndexVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602234F RID: 140111 RVA: 0x004B70CD File Offset: 0x004B52CD
		public static VectorOffset CreateAffectIndexVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06022350 RID: 140112 RVA: 0x004B70EB File Offset: 0x004B52EB
		public static VectorOffset CreateAffectIndexVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022351 RID: 140113 RVA: 0x004B7104 File Offset: 0x004B5304
		public static void StartAffectIndexVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022352 RID: 140114 RVA: 0x004B710F File Offset: 0x004B530F
		public static void AddAffectType(FlatBufferBuilder builder, EGearHitAffectType affectType)
		{
			builder.AddByte(2, (byte)affectType, 0);
		}

		// Token: 0x06022353 RID: 140115 RVA: 0x004B711A File Offset: 0x004B531A
		public static Offset<ICheckGearHit> EndICheckGearHit(FlatBufferBuilder builder)
		{
			return new Offset<ICheckGearHit>(builder.EndTable());
		}

		// Token: 0x06022354 RID: 140116 RVA: 0x004B7128 File Offset: 0x004B5328
		public ICheckGearHitT UnPack()
		{
			ICheckGearHitT checkGearHitT = new ICheckGearHitT();
			this.UnPackTo(checkGearHitT);
			return checkGearHitT;
		}

		// Token: 0x06022355 RID: 140117 RVA: 0x004B7144 File Offset: 0x004B5344
		public void UnPackTo(ICheckGearHitT _o)
		{
			_o.HitIndex = this.HitIndex;
			_o.AffectIndex = new List<int>();
			for (int i = 0; i < this.AffectIndexLength; i++)
			{
				_o.AffectIndex.Add(this.AffectIndex(i));
			}
			_o.AffectType = this.AffectType;
		}

		// Token: 0x06022356 RID: 140118 RVA: 0x004B7198 File Offset: 0x004B5398
		public static Offset<ICheckGearHit> Pack(FlatBufferBuilder builder, ICheckGearHitT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckGearHit>);
			}
			VectorOffset affectIndexOffset = default(VectorOffset);
			if (_o.AffectIndex != null)
			{
				int[] data = _o.AffectIndex.ToArray();
				affectIndexOffset = ICheckGearHit.CreateAffectIndexVector(builder, data);
			}
			return ICheckGearHit.CreateICheckGearHit(builder, _o.HitIndex, affectIndexOffset, _o.AffectType);
		}

		// Token: 0x0400E9FC RID: 59900
		private Table __p;
	}
}
