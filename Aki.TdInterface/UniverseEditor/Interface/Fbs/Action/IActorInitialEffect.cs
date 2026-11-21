using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200672A RID: 26410
	public struct IActorInitialEffect : IFlatbufferObject
	{
		// Token: 0x1700BFF8 RID: 49144
		// (get) Token: 0x0602CBA9 RID: 183209 RVA: 0x0061E668 File Offset: 0x0061C868
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CBAA RID: 183210 RVA: 0x0061E675 File Offset: 0x0061C875
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CBAB RID: 183211 RVA: 0x0061E67C File Offset: 0x0061C87C
		public static IActorInitialEffect GetRootAsIActorInitialEffect(ByteBuffer _bb)
		{
			return IActorInitialEffect.GetRootAsIActorInitialEffect(_bb, default(IActorInitialEffect));
		}

		// Token: 0x0602CBAC RID: 183212 RVA: 0x0061E698 File Offset: 0x0061C898
		public static IActorInitialEffect GetRootAsIActorInitialEffect(ByteBuffer _bb, IActorInitialEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CBAD RID: 183213 RVA: 0x0061E6B5 File Offset: 0x0061C8B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CBAE RID: 183214 RVA: 0x0061E6C4 File Offset: 0x0061C8C4
		public IActorInitialEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602CBAF RID: 183215 RVA: 0x0061E6D4 File Offset: 0x0061C8D4
		public int EffectIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BFF9 RID: 49145
		// (get) Token: 0x0602CBB0 RID: 183216 RVA: 0x0061E714 File Offset: 0x0061C914
		public int EffectIdsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602CBB1 RID: 183217 RVA: 0x0061E73F File Offset: 0x0061C93F
		public Span<int> GetEffectIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0602CBB2 RID: 183218 RVA: 0x0061E74E File Offset: 0x0061C94E
		public int[] GetEffectIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x0602CBB3 RID: 183219 RVA: 0x0061E75C File Offset: 0x0061C95C
		public int EffectIdsMaleVariant(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BFFA RID: 49146
		// (get) Token: 0x0602CBB4 RID: 183220 RVA: 0x0061E79C File Offset: 0x0061C99C
		public int EffectIdsMaleVariantLength
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

		// Token: 0x0602CBB5 RID: 183221 RVA: 0x0061E7C7 File Offset: 0x0061C9C7
		public Span<int> GetEffectIdsMaleVariantBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602CBB6 RID: 183222 RVA: 0x0061E7D6 File Offset: 0x0061C9D6
		public int[] GetEffectIdsMaleVariantArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700BFFB RID: 49147
		// (get) Token: 0x0602CBB7 RID: 183223 RVA: 0x0061E7E4 File Offset: 0x0061C9E4
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

		// Token: 0x0602CBB8 RID: 183224 RVA: 0x0061E820 File Offset: 0x0061CA20
		public static Offset<IActorInitialEffect> CreateIActorInitialEffect(FlatBufferBuilder builder, VectorOffset EffectIdsOffset = default(VectorOffset), VectorOffset EffectIdsMaleVariantOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IActorInitialEffect.AddEffectIdsMaleVariant(builder, EffectIdsMaleVariantOffset);
			IActorInitialEffect.AddEffectIds(builder, EffectIdsOffset);
			IActorInitialEffect.AddNullMask(builder, NullMask);
			return IActorInitialEffect.EndIActorInitialEffect(builder);
		}

		// Token: 0x0602CBB9 RID: 183225 RVA: 0x0061E844 File Offset: 0x0061CA44
		public static void StartIActorInitialEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602CBBA RID: 183226 RVA: 0x0061E84D File Offset: 0x0061CA4D
		public static void AddEffectIds(FlatBufferBuilder builder, VectorOffset effectIdsOffset)
		{
			builder.AddOffset(0, effectIdsOffset.Value, 0);
		}

		// Token: 0x0602CBBB RID: 183227 RVA: 0x0061E860 File Offset: 0x0061CA60
		public static VectorOffset CreateEffectIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602CBBC RID: 183228 RVA: 0x0061E897 File Offset: 0x0061CA97
		public static VectorOffset CreateEffectIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CBBD RID: 183229 RVA: 0x0061E8B1 File Offset: 0x0061CAB1
		public static VectorOffset CreateEffectIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CBBE RID: 183230 RVA: 0x0061E8CF File Offset: 0x0061CACF
		public static VectorOffset CreateEffectIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602CBBF RID: 183231 RVA: 0x0061E8E8 File Offset: 0x0061CAE8
		public static void StartEffectIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602CBC0 RID: 183232 RVA: 0x0061E8F3 File Offset: 0x0061CAF3
		public static void AddEffectIdsMaleVariant(FlatBufferBuilder builder, VectorOffset effectIdsMaleVariantOffset)
		{
			builder.AddOffset(1, effectIdsMaleVariantOffset.Value, 0);
		}

		// Token: 0x0602CBC1 RID: 183233 RVA: 0x0061E904 File Offset: 0x0061CB04
		public static VectorOffset CreateEffectIdsMaleVariantVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602CBC2 RID: 183234 RVA: 0x0061E93B File Offset: 0x0061CB3B
		public static VectorOffset CreateEffectIdsMaleVariantVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CBC3 RID: 183235 RVA: 0x0061E955 File Offset: 0x0061CB55
		public static VectorOffset CreateEffectIdsMaleVariantVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CBC4 RID: 183236 RVA: 0x0061E973 File Offset: 0x0061CB73
		public static VectorOffset CreateEffectIdsMaleVariantVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602CBC5 RID: 183237 RVA: 0x0061E98C File Offset: 0x0061CB8C
		public static void StartEffectIdsMaleVariantVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602CBC6 RID: 183238 RVA: 0x0061E997 File Offset: 0x0061CB97
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602CBC7 RID: 183239 RVA: 0x0061E9A2 File Offset: 0x0061CBA2
		public static Offset<IActorInitialEffect> EndIActorInitialEffect(FlatBufferBuilder builder)
		{
			return new Offset<IActorInitialEffect>(builder.EndTable());
		}

		// Token: 0x0602CBC8 RID: 183240 RVA: 0x0061E9B0 File Offset: 0x0061CBB0
		public IActorInitialEffectT UnPack()
		{
			IActorInitialEffectT actorInitialEffectT = new IActorInitialEffectT();
			this.UnPackTo(actorInitialEffectT);
			return actorInitialEffectT;
		}

		// Token: 0x0602CBC9 RID: 183241 RVA: 0x0061E9CC File Offset: 0x0061CBCC
		public void UnPackTo(IActorInitialEffectT _o)
		{
			_o.EffectIds = new List<int>();
			for (int i = 0; i < this.EffectIdsLength; i++)
			{
				_o.EffectIds.Add(this.EffectIds(i));
			}
			_o.EffectIdsMaleVariant = new List<int>();
			for (int j = 0; j < this.EffectIdsMaleVariantLength; j++)
			{
				_o.EffectIdsMaleVariant.Add(this.EffectIdsMaleVariant(j));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CBCA RID: 183242 RVA: 0x0061EA44 File Offset: 0x0061CC44
		public static Offset<IActorInitialEffect> Pack(FlatBufferBuilder builder, IActorInitialEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorInitialEffect>);
			}
			VectorOffset effectIdsOffset = default(VectorOffset);
			if (_o.EffectIds != null)
			{
				int[] data = _o.EffectIds.ToArray();
				effectIdsOffset = IActorInitialEffect.CreateEffectIdsVector(builder, data);
			}
			VectorOffset effectIdsMaleVariantOffset = default(VectorOffset);
			if (_o.EffectIdsMaleVariant != null)
			{
				int[] data2 = _o.EffectIdsMaleVariant.ToArray();
				effectIdsMaleVariantOffset = IActorInitialEffect.CreateEffectIdsMaleVariantVector(builder, data2);
			}
			return IActorInitialEffect.CreateIActorInitialEffect(builder, effectIdsOffset, effectIdsMaleVariantOffset, _o.NullMask);
		}

		// Token: 0x04011276 RID: 70262
		private Table __p;
	}
}
