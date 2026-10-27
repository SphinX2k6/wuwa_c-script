using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060C8 RID: 24776
	public struct IActorInitialEffect : IFlatbufferObject
	{
		// Token: 0x1700B68D RID: 46733
		// (get) Token: 0x0602A4C8 RID: 173256 RVA: 0x005D46C0 File Offset: 0x005D28C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A4C9 RID: 173257 RVA: 0x005D46CD File Offset: 0x005D28CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A4CA RID: 173258 RVA: 0x005D46D4 File Offset: 0x005D28D4
		public static IActorInitialEffect GetRootAsIActorInitialEffect(ByteBuffer _bb)
		{
			return IActorInitialEffect.GetRootAsIActorInitialEffect(_bb, default(IActorInitialEffect));
		}

		// Token: 0x0602A4CB RID: 173259 RVA: 0x005D46F0 File Offset: 0x005D28F0
		public static IActorInitialEffect GetRootAsIActorInitialEffect(ByteBuffer _bb, IActorInitialEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A4CC RID: 173260 RVA: 0x005D470D File Offset: 0x005D290D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A4CD RID: 173261 RVA: 0x005D471C File Offset: 0x005D291C
		public IActorInitialEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602A4CE RID: 173262 RVA: 0x005D472C File Offset: 0x005D292C
		public int EffectIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B68E RID: 46734
		// (get) Token: 0x0602A4CF RID: 173263 RVA: 0x005D476C File Offset: 0x005D296C
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

		// Token: 0x0602A4D0 RID: 173264 RVA: 0x005D4797 File Offset: 0x005D2997
		public Span<int> GetEffectIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0602A4D1 RID: 173265 RVA: 0x005D47A6 File Offset: 0x005D29A6
		public int[] GetEffectIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x0602A4D2 RID: 173266 RVA: 0x005D47B4 File Offset: 0x005D29B4
		public int EffectIdsMaleVariant(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B68F RID: 46735
		// (get) Token: 0x0602A4D3 RID: 173267 RVA: 0x005D47F4 File Offset: 0x005D29F4
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

		// Token: 0x0602A4D4 RID: 173268 RVA: 0x005D481F File Offset: 0x005D2A1F
		public Span<int> GetEffectIdsMaleVariantBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602A4D5 RID: 173269 RVA: 0x005D482E File Offset: 0x005D2A2E
		public int[] GetEffectIdsMaleVariantArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700B690 RID: 46736
		// (get) Token: 0x0602A4D6 RID: 173270 RVA: 0x005D483C File Offset: 0x005D2A3C
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

		// Token: 0x0602A4D7 RID: 173271 RVA: 0x005D4878 File Offset: 0x005D2A78
		public static Offset<IActorInitialEffect> CreateIActorInitialEffect(FlatBufferBuilder builder, VectorOffset EffectIdsOffset = default(VectorOffset), VectorOffset EffectIdsMaleVariantOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IActorInitialEffect.AddEffectIdsMaleVariant(builder, EffectIdsMaleVariantOffset);
			IActorInitialEffect.AddEffectIds(builder, EffectIdsOffset);
			IActorInitialEffect.AddNullMask(builder, NullMask);
			return IActorInitialEffect.EndIActorInitialEffect(builder);
		}

		// Token: 0x0602A4D8 RID: 173272 RVA: 0x005D489C File Offset: 0x005D2A9C
		public static void StartIActorInitialEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A4D9 RID: 173273 RVA: 0x005D48A5 File Offset: 0x005D2AA5
		public static void AddEffectIds(FlatBufferBuilder builder, VectorOffset effectIdsOffset)
		{
			builder.AddOffset(0, effectIdsOffset.Value, 0);
		}

		// Token: 0x0602A4DA RID: 173274 RVA: 0x005D48B8 File Offset: 0x005D2AB8
		public static VectorOffset CreateEffectIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A4DB RID: 173275 RVA: 0x005D48EF File Offset: 0x005D2AEF
		public static VectorOffset CreateEffectIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A4DC RID: 173276 RVA: 0x005D4909 File Offset: 0x005D2B09
		public static VectorOffset CreateEffectIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A4DD RID: 173277 RVA: 0x005D4927 File Offset: 0x005D2B27
		public static VectorOffset CreateEffectIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A4DE RID: 173278 RVA: 0x005D4940 File Offset: 0x005D2B40
		public static void StartEffectIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A4DF RID: 173279 RVA: 0x005D494B File Offset: 0x005D2B4B
		public static void AddEffectIdsMaleVariant(FlatBufferBuilder builder, VectorOffset effectIdsMaleVariantOffset)
		{
			builder.AddOffset(1, effectIdsMaleVariantOffset.Value, 0);
		}

		// Token: 0x0602A4E0 RID: 173280 RVA: 0x005D495C File Offset: 0x005D2B5C
		public static VectorOffset CreateEffectIdsMaleVariantVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A4E1 RID: 173281 RVA: 0x005D4993 File Offset: 0x005D2B93
		public static VectorOffset CreateEffectIdsMaleVariantVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A4E2 RID: 173282 RVA: 0x005D49AD File Offset: 0x005D2BAD
		public static VectorOffset CreateEffectIdsMaleVariantVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A4E3 RID: 173283 RVA: 0x005D49CB File Offset: 0x005D2BCB
		public static VectorOffset CreateEffectIdsMaleVariantVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A4E4 RID: 173284 RVA: 0x005D49E4 File Offset: 0x005D2BE4
		public static void StartEffectIdsMaleVariantVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A4E5 RID: 173285 RVA: 0x005D49EF File Offset: 0x005D2BEF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602A4E6 RID: 173286 RVA: 0x005D49FA File Offset: 0x005D2BFA
		public static Offset<IActorInitialEffect> EndIActorInitialEffect(FlatBufferBuilder builder)
		{
			return new Offset<IActorInitialEffect>(builder.EndTable());
		}

		// Token: 0x0602A4E7 RID: 173287 RVA: 0x005D4A08 File Offset: 0x005D2C08
		public IActorInitialEffectT UnPack()
		{
			IActorInitialEffectT actorInitialEffectT = new IActorInitialEffectT();
			this.UnPackTo(actorInitialEffectT);
			return actorInitialEffectT;
		}

		// Token: 0x0602A4E8 RID: 173288 RVA: 0x005D4A24 File Offset: 0x005D2C24
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

		// Token: 0x0602A4E9 RID: 173289 RVA: 0x005D4A9C File Offset: 0x005D2C9C
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

		// Token: 0x04010472 RID: 66674
		private Table __p;
	}
}
