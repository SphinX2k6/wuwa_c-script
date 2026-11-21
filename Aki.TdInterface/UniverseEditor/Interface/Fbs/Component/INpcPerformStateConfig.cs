using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BDC RID: 23516
	public struct INpcPerformStateConfig : IFlatbufferObject
	{
		// Token: 0x1700AC17 RID: 44055
		// (get) Token: 0x06026D40 RID: 159040 RVA: 0x005513A3 File Offset: 0x0054F5A3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026D41 RID: 159041 RVA: 0x005513B0 File Offset: 0x0054F5B0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026D42 RID: 159042 RVA: 0x005513B8 File Offset: 0x0054F5B8
		public static INpcPerformStateConfig GetRootAsINpcPerformStateConfig(ByteBuffer _bb)
		{
			return INpcPerformStateConfig.GetRootAsINpcPerformStateConfig(_bb, default(INpcPerformStateConfig));
		}

		// Token: 0x06026D43 RID: 159043 RVA: 0x005513D4 File Offset: 0x0054F5D4
		public static INpcPerformStateConfig GetRootAsINpcPerformStateConfig(ByteBuffer _bb, INpcPerformStateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026D44 RID: 159044 RVA: 0x005513F1 File Offset: 0x0054F5F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026D45 RID: 159045 RVA: 0x00551400 File Offset: 0x0054F600
		public INpcPerformStateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC18 RID: 44056
		// (get) Token: 0x06026D46 RID: 159046 RVA: 0x00551410 File Offset: 0x0054F610
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

		// Token: 0x06026D47 RID: 159047 RVA: 0x00551447 File Offset: 0x0054F647
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06026D48 RID: 159048 RVA: 0x00551456 File Offset: 0x0054F656
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700AC19 RID: 44057
		// (get) Token: 0x06026D49 RID: 159049 RVA: 0x00551464 File Offset: 0x0054F664
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

		// Token: 0x06026D4A RID: 159050 RVA: 0x0055149B File Offset: 0x0054F69B
		public Span<byte> GetMaterialDaBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06026D4B RID: 159051 RVA: 0x005514AA File Offset: 0x0054F6AA
		public byte[] GetMaterialDaArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06026D4C RID: 159052 RVA: 0x005514B8 File Offset: 0x0054F6B8
		public int BuffEffectIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AC1A RID: 44058
		// (get) Token: 0x06026D4D RID: 159053 RVA: 0x005514F8 File Offset: 0x0054F6F8
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

		// Token: 0x06026D4E RID: 159054 RVA: 0x00551523 File Offset: 0x0054F723
		public Span<int> GetBuffEffectIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06026D4F RID: 159055 RVA: 0x00551532 File Offset: 0x0054F732
		public int[] GetBuffEffectIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700AC1B RID: 44059
		// (get) Token: 0x06026D50 RID: 159056 RVA: 0x00551540 File Offset: 0x0054F740
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

		// Token: 0x06026D51 RID: 159057 RVA: 0x0055157D File Offset: 0x0054F77D
		public static Offset<INpcPerformStateConfig> CreateINpcPerformStateConfig(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset), StringOffset MaterialDaOffset = default(StringOffset), VectorOffset BuffEffectIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			INpcPerformStateConfig.AddBuffEffectIds(builder, BuffEffectIdsOffset);
			INpcPerformStateConfig.AddMaterialDa(builder, MaterialDaOffset);
			INpcPerformStateConfig.AddState(builder, StateOffset);
			INpcPerformStateConfig.AddNullMask(builder, NullMask);
			return INpcPerformStateConfig.EndINpcPerformStateConfig(builder);
		}

		// Token: 0x06026D52 RID: 159058 RVA: 0x005515A9 File Offset: 0x0054F7A9
		public static void StartINpcPerformStateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06026D53 RID: 159059 RVA: 0x005515B2 File Offset: 0x0054F7B2
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x06026D54 RID: 159060 RVA: 0x005515C2 File Offset: 0x0054F7C2
		public static void AddMaterialDa(FlatBufferBuilder builder, StringOffset materialDaOffset)
		{
			builder.AddOffset(1, materialDaOffset.Value, 0);
		}

		// Token: 0x06026D55 RID: 159061 RVA: 0x005515D2 File Offset: 0x0054F7D2
		public static void AddBuffEffectIds(FlatBufferBuilder builder, VectorOffset buffEffectIdsOffset)
		{
			builder.AddOffset(2, buffEffectIdsOffset.Value, 0);
		}

		// Token: 0x06026D56 RID: 159062 RVA: 0x005515E4 File Offset: 0x0054F7E4
		public static VectorOffset CreateBuffEffectIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06026D57 RID: 159063 RVA: 0x0055161B File Offset: 0x0054F81B
		public static VectorOffset CreateBuffEffectIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026D58 RID: 159064 RVA: 0x00551635 File Offset: 0x0054F835
		public static VectorOffset CreateBuffEffectIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026D59 RID: 159065 RVA: 0x00551653 File Offset: 0x0054F853
		public static VectorOffset CreateBuffEffectIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026D5A RID: 159066 RVA: 0x0055166C File Offset: 0x0054F86C
		public static void StartBuffEffectIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026D5B RID: 159067 RVA: 0x00551677 File Offset: 0x0054F877
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06026D5C RID: 159068 RVA: 0x00551682 File Offset: 0x0054F882
		public static Offset<INpcPerformStateConfig> EndINpcPerformStateConfig(FlatBufferBuilder builder)
		{
			return new Offset<INpcPerformStateConfig>(builder.EndTable());
		}

		// Token: 0x06026D5D RID: 159069 RVA: 0x00551690 File Offset: 0x0054F890
		public INpcPerformStateConfigT UnPack()
		{
			INpcPerformStateConfigT npcPerformStateConfigT = new INpcPerformStateConfigT();
			this.UnPackTo(npcPerformStateConfigT);
			return npcPerformStateConfigT;
		}

		// Token: 0x06026D5E RID: 159070 RVA: 0x005516AC File Offset: 0x0054F8AC
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

		// Token: 0x06026D5F RID: 159071 RVA: 0x0055170C File Offset: 0x0054F90C
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

		// Token: 0x0400F648 RID: 63048
		private Table __p;
	}
}
