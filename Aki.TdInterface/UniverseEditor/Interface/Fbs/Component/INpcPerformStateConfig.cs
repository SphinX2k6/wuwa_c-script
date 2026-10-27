using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200563E RID: 22078
	public struct INpcPerformStateConfig : IFlatbufferObject
	{
		// Token: 0x1700A38D RID: 41869
		// (get) Token: 0x06024B21 RID: 150305 RVA: 0x00510A7F File Offset: 0x0050EC7F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024B22 RID: 150306 RVA: 0x00510A8C File Offset: 0x0050EC8C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024B23 RID: 150307 RVA: 0x00510A94 File Offset: 0x0050EC94
		public static INpcPerformStateConfig GetRootAsINpcPerformStateConfig(ByteBuffer _bb)
		{
			return INpcPerformStateConfig.GetRootAsINpcPerformStateConfig(_bb, default(INpcPerformStateConfig));
		}

		// Token: 0x06024B24 RID: 150308 RVA: 0x00510AB0 File Offset: 0x0050ECB0
		public static INpcPerformStateConfig GetRootAsINpcPerformStateConfig(ByteBuffer _bb, INpcPerformStateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024B25 RID: 150309 RVA: 0x00510ACD File Offset: 0x0050ECCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024B26 RID: 150310 RVA: 0x00510ADC File Offset: 0x0050ECDC
		public INpcPerformStateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A38E RID: 41870
		// (get) Token: 0x06024B27 RID: 150311 RVA: 0x00510AEC File Offset: 0x0050ECEC
		public string State
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024B28 RID: 150312 RVA: 0x00510B23 File Offset: 0x0050ED23
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06024B29 RID: 150313 RVA: 0x00510B32 File Offset: 0x0050ED32
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A38F RID: 41871
		// (get) Token: 0x06024B2A RID: 150314 RVA: 0x00510B40 File Offset: 0x0050ED40
		public string MaterialDa
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

		// Token: 0x06024B2B RID: 150315 RVA: 0x00510B77 File Offset: 0x0050ED77
		public Span<byte> GetMaterialDaBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06024B2C RID: 150316 RVA: 0x00510B86 File Offset: 0x0050ED86
		public byte[] GetMaterialDaArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06024B2D RID: 150317 RVA: 0x00510B94 File Offset: 0x0050ED94
		public int BuffEffectIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A390 RID: 41872
		// (get) Token: 0x06024B2E RID: 150318 RVA: 0x00510BD4 File Offset: 0x0050EDD4
		public int BuffEffectIdsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06024B2F RID: 150319 RVA: 0x00510BFF File Offset: 0x0050EDFF
		public Span<int> GetBuffEffectIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06024B30 RID: 150320 RVA: 0x00510C0E File Offset: 0x0050EE0E
		public int[] GetBuffEffectIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700A391 RID: 41873
		// (get) Token: 0x06024B31 RID: 150321 RVA: 0x00510C1C File Offset: 0x0050EE1C
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

		// Token: 0x06024B32 RID: 150322 RVA: 0x00510C59 File Offset: 0x0050EE59
		public static Offset<INpcPerformStateConfig> CreateINpcPerformStateConfig(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset), StringOffset MaterialDaOffset = default(StringOffset), VectorOffset BuffEffectIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			INpcPerformStateConfig.AddBuffEffectIds(builder, BuffEffectIdsOffset);
			INpcPerformStateConfig.AddMaterialDa(builder, MaterialDaOffset);
			INpcPerformStateConfig.AddState(builder, StateOffset);
			INpcPerformStateConfig.AddNullMask(builder, NullMask);
			return INpcPerformStateConfig.EndINpcPerformStateConfig(builder);
		}

		// Token: 0x06024B33 RID: 150323 RVA: 0x00510C85 File Offset: 0x0050EE85
		public static void StartINpcPerformStateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06024B34 RID: 150324 RVA: 0x00510C8E File Offset: 0x0050EE8E
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x06024B35 RID: 150325 RVA: 0x00510C9E File Offset: 0x0050EE9E
		public static void AddMaterialDa(FlatBufferBuilder builder, StringOffset materialDaOffset)
		{
			builder.AddOffset(1, materialDaOffset.Value, 0);
		}

		// Token: 0x06024B36 RID: 150326 RVA: 0x00510CAE File Offset: 0x0050EEAE
		public static void AddBuffEffectIds(FlatBufferBuilder builder, VectorOffset buffEffectIdsOffset)
		{
			builder.AddOffset(2, buffEffectIdsOffset.Value, 0);
		}

		// Token: 0x06024B37 RID: 150327 RVA: 0x00510CC0 File Offset: 0x0050EEC0
		public static VectorOffset CreateBuffEffectIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06024B38 RID: 150328 RVA: 0x00510CF7 File Offset: 0x0050EEF7
		public static VectorOffset CreateBuffEffectIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024B39 RID: 150329 RVA: 0x00510D11 File Offset: 0x0050EF11
		public static VectorOffset CreateBuffEffectIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024B3A RID: 150330 RVA: 0x00510D2F File Offset: 0x0050EF2F
		public static VectorOffset CreateBuffEffectIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024B3B RID: 150331 RVA: 0x00510D48 File Offset: 0x0050EF48
		public static void StartBuffEffectIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024B3C RID: 150332 RVA: 0x00510D53 File Offset: 0x0050EF53
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06024B3D RID: 150333 RVA: 0x00510D5E File Offset: 0x0050EF5E
		public static Offset<INpcPerformStateConfig> EndINpcPerformStateConfig(FlatBufferBuilder builder)
		{
			return new Offset<INpcPerformStateConfig>(builder.EndTable());
		}

		// Token: 0x06024B3E RID: 150334 RVA: 0x00510D6C File Offset: 0x0050EF6C
		public INpcPerformStateConfigT UnPack()
		{
			INpcPerformStateConfigT npcPerformStateConfigT = new INpcPerformStateConfigT();
			this.UnPackTo(npcPerformStateConfigT);
			return npcPerformStateConfigT;
		}

		// Token: 0x06024B3F RID: 150335 RVA: 0x00510D88 File Offset: 0x0050EF88
		public void UnPackTo(INpcPerformStateConfigT _o)
		{
			_o.State = this.State;
			_o.MaterialDa = this.MaterialDa;
			_o.BuffEffectIds = new List<int>();
			for (int i = 0; i < this.BuffEffectIdsLength; i++)
			{
				_o.BuffEffectIds.Add(this.BuffEffectIds(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024B40 RID: 150336 RVA: 0x00510DE8 File Offset: 0x0050EFE8
		public static Offset<INpcPerformStateConfig> Pack(FlatBufferBuilder builder, INpcPerformStateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcPerformStateConfig>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			StringOffset materialDaOffset = (_o.MaterialDa == null) ? default(StringOffset) : builder.CreateString(_o.MaterialDa);
			VectorOffset buffEffectIdsOffset = default(VectorOffset);
			if (_o.BuffEffectIds != null)
			{
				int[] data = _o.BuffEffectIds.ToArray();
				buffEffectIdsOffset = INpcPerformStateConfig.CreateBuffEffectIdsVector(builder, data);
			}
			return INpcPerformStateConfig.CreateINpcPerformStateConfig(builder, stateOffset, materialDaOffset, buffEffectIdsOffset, _o.NullMask);
		}

		// Token: 0x0400E9E3 RID: 59875
		private Table __p;
	}
}
