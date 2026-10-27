using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F91 RID: 20369
	public struct ICheckGearHit : IFlatbufferObject
	{
		// Token: 0x1700935C RID: 37724
		// (get) Token: 0x060205EB RID: 132587 RVA: 0x00480ED8 File Offset: 0x0047F0D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060205EC RID: 132588 RVA: 0x00480EE5 File Offset: 0x0047F0E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060205ED RID: 132589 RVA: 0x00480EEC File Offset: 0x0047F0EC
		public static ICheckGearHit GetRootAsICheckGearHit(ByteBuffer _bb)
		{
			return ICheckGearHit.GetRootAsICheckGearHit(_bb, default(ICheckGearHit));
		}

		// Token: 0x060205EE RID: 132590 RVA: 0x00480F08 File Offset: 0x0047F108
		public static ICheckGearHit GetRootAsICheckGearHit(ByteBuffer _bb, ICheckGearHit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060205EF RID: 132591 RVA: 0x00480F25 File Offset: 0x0047F125
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060205F0 RID: 132592 RVA: 0x00480F34 File Offset: 0x0047F134
		public ICheckGearHit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700935D RID: 37725
		// (get) Token: 0x060205F1 RID: 132593 RVA: 0x00480F44 File Offset: 0x0047F144
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

		// Token: 0x060205F2 RID: 132594 RVA: 0x00480F80 File Offset: 0x0047F180
		public int AffectIndex(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700935E RID: 37726
		// (get) Token: 0x060205F3 RID: 132595 RVA: 0x00480FC0 File Offset: 0x0047F1C0
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

		// Token: 0x060205F4 RID: 132596 RVA: 0x00480FEB File Offset: 0x0047F1EB
		public Span<int> GetAffectIndexBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060205F5 RID: 132597 RVA: 0x00480FFA File Offset: 0x0047F1FA
		public int[] GetAffectIndexArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700935F RID: 37727
		// (get) Token: 0x060205F6 RID: 132598 RVA: 0x00481008 File Offset: 0x0047F208
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

		// Token: 0x060205F7 RID: 132599 RVA: 0x00481044 File Offset: 0x0047F244
		public static Offset<ICheckGearHit> CreateICheckGearHit(FlatBufferBuilder builder, int HitIndex = 0, VectorOffset AffectIndexOffset = default(VectorOffset), EGearHitAffectType AffectType = EGearHitAffectType.ChangeNextState)
		{
			builder.StartTable(3);
			ICheckGearHit.AddAffectIndex(builder, AffectIndexOffset);
			ICheckGearHit.AddHitIndex(builder, HitIndex);
			ICheckGearHit.AddAffectType(builder, AffectType);
			return ICheckGearHit.EndICheckGearHit(builder);
		}

		// Token: 0x060205F8 RID: 132600 RVA: 0x00481068 File Offset: 0x0047F268
		public static void StartICheckGearHit(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060205F9 RID: 132601 RVA: 0x00481071 File Offset: 0x0047F271
		public static void AddHitIndex(FlatBufferBuilder builder, int hitIndex)
		{
			builder.AddInt(0, hitIndex, 0);
		}

		// Token: 0x060205FA RID: 132602 RVA: 0x0048107C File Offset: 0x0047F27C
		public static void AddAffectIndex(FlatBufferBuilder builder, VectorOffset affectIndexOffset)
		{
			builder.AddOffset(1, affectIndexOffset.Value, 0);
		}

		// Token: 0x060205FB RID: 132603 RVA: 0x0048108C File Offset: 0x0047F28C
		public static VectorOffset CreateAffectIndexVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060205FC RID: 132604 RVA: 0x004810C3 File Offset: 0x0047F2C3
		public static VectorOffset CreateAffectIndexVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060205FD RID: 132605 RVA: 0x004810DD File Offset: 0x0047F2DD
		public static VectorOffset CreateAffectIndexVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060205FE RID: 132606 RVA: 0x004810FB File Offset: 0x0047F2FB
		public static VectorOffset CreateAffectIndexVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060205FF RID: 132607 RVA: 0x00481114 File Offset: 0x0047F314
		public static void StartAffectIndexVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020600 RID: 132608 RVA: 0x0048111F File Offset: 0x0047F31F
		public static void AddAffectType(FlatBufferBuilder builder, EGearHitAffectType affectType)
		{
			builder.AddByte(2, (byte)affectType, 0);
		}

		// Token: 0x06020601 RID: 132609 RVA: 0x0048112A File Offset: 0x0047F32A
		public static Offset<ICheckGearHit> EndICheckGearHit(FlatBufferBuilder builder)
		{
			return new Offset<ICheckGearHit>(builder.EndTable());
		}

		// Token: 0x06020602 RID: 132610 RVA: 0x00481138 File Offset: 0x0047F338
		public ICheckGearHitT UnPack()
		{
			ICheckGearHitT checkGearHitT = new ICheckGearHitT();
			this.UnPackTo(checkGearHitT);
			return checkGearHitT;
		}

		// Token: 0x06020603 RID: 132611 RVA: 0x00481154 File Offset: 0x0047F354
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

		// Token: 0x06020604 RID: 132612 RVA: 0x004811A8 File Offset: 0x0047F3A8
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

		// Token: 0x0400DE52 RID: 56914
		private Table __p;
	}
}
