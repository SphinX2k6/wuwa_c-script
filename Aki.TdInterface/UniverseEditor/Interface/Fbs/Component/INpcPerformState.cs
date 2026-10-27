using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200563B RID: 22075
	public struct INpcPerformState : IFlatbufferObject
	{
		// Token: 0x1700A388 RID: 41864
		// (get) Token: 0x06024B05 RID: 150277 RVA: 0x00510646 File Offset: 0x0050E846
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024B06 RID: 150278 RVA: 0x00510653 File Offset: 0x0050E853
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024B07 RID: 150279 RVA: 0x0051065C File Offset: 0x0050E85C
		public static INpcPerformState GetRootAsINpcPerformState(ByteBuffer _bb)
		{
			return INpcPerformState.GetRootAsINpcPerformState(_bb, default(INpcPerformState));
		}

		// Token: 0x06024B08 RID: 150280 RVA: 0x00510678 File Offset: 0x0050E878
		public static INpcPerformState GetRootAsINpcPerformState(ByteBuffer _bb, INpcPerformState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024B09 RID: 150281 RVA: 0x00510695 File Offset: 0x0050E895
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024B0A RID: 150282 RVA: 0x005106A4 File Offset: 0x0050E8A4
		public INpcPerformState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A389 RID: 41865
		// (get) Token: 0x06024B0B RID: 150283 RVA: 0x005106B4 File Offset: 0x0050E8B4
		public IInitNpcPerformState? InitState
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IInitNpcPerformState?(default(IInitNpcPerformState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06024B0C RID: 150284 RVA: 0x00510714 File Offset: 0x0050E914
		public INpcPerformStateConfig? Configs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new INpcPerformStateConfig?(default(INpcPerformStateConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A38A RID: 41866
		// (get) Token: 0x06024B0D RID: 150285 RVA: 0x00510774 File Offset: 0x0050E974
		public int ConfigsLength
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

		// Token: 0x06024B0E RID: 150286 RVA: 0x0051079F File Offset: 0x0050E99F
		public static Offset<INpcPerformState> CreateINpcPerformState(FlatBufferBuilder builder, Offset<IInitNpcPerformState> InitStateOffset = default(Offset<IInitNpcPerformState>), VectorOffset ConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			INpcPerformState.AddConfigs(builder, ConfigsOffset);
			INpcPerformState.AddInitState(builder, InitStateOffset);
			return INpcPerformState.EndINpcPerformState(builder);
		}

		// Token: 0x06024B0F RID: 150287 RVA: 0x005107BC File Offset: 0x0050E9BC
		public static void StartINpcPerformState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024B10 RID: 150288 RVA: 0x005107C5 File Offset: 0x0050E9C5
		public static void AddInitState(FlatBufferBuilder builder, Offset<IInitNpcPerformState> initStateOffset)
		{
			builder.AddOffset(0, initStateOffset.Value, 0);
		}

		// Token: 0x06024B11 RID: 150289 RVA: 0x005107D5 File Offset: 0x0050E9D5
		public static void AddConfigs(FlatBufferBuilder builder, VectorOffset configsOffset)
		{
			builder.AddOffset(1, configsOffset.Value, 0);
		}

		// Token: 0x06024B12 RID: 150290 RVA: 0x005107E8 File Offset: 0x0050E9E8
		public static VectorOffset CreateConfigsVector(FlatBufferBuilder builder, Offset<INpcPerformStateConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024B13 RID: 150291 RVA: 0x00510828 File Offset: 0x0050EA28
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, Offset<INpcPerformStateConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INpcPerformStateConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024B14 RID: 150292 RVA: 0x00510842 File Offset: 0x0050EA42
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INpcPerformStateConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INpcPerformStateConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024B15 RID: 150293 RVA: 0x00510860 File Offset: 0x0050EA60
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INpcPerformStateConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024B16 RID: 150294 RVA: 0x00510879 File Offset: 0x0050EA79
		public static void StartConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024B17 RID: 150295 RVA: 0x00510884 File Offset: 0x0050EA84
		public static Offset<INpcPerformState> EndINpcPerformState(FlatBufferBuilder builder)
		{
			return new Offset<INpcPerformState>(builder.EndTable());
		}

		// Token: 0x06024B18 RID: 150296 RVA: 0x00510894 File Offset: 0x0050EA94
		public INpcPerformStateT UnPack()
		{
			INpcPerformStateT npcPerformStateT = new INpcPerformStateT();
			this.UnPackTo(npcPerformStateT);
			return npcPerformStateT;
		}

		// Token: 0x06024B19 RID: 150297 RVA: 0x005108B0 File Offset: 0x0050EAB0
		public void UnPackTo(INpcPerformStateT _o)
		{
			_o.InitState = ((this.InitState != null) ? this.InitState.Value.UnPack() : null);
			_o.Configs = new List<INpcPerformStateConfigT>();
			for (int i = 0; i < this.ConfigsLength; i++)
			{
				_o.Configs.Add((this.Configs(i) != null) ? this.Configs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06024B1A RID: 150298 RVA: 0x00510940 File Offset: 0x0050EB40
		public static Offset<INpcPerformState> Pack(FlatBufferBuilder builder, INpcPerformStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcPerformState>);
			}
			Offset<IInitNpcPerformState> initStateOffset = (_o.InitState == null) ? default(Offset<IInitNpcPerformState>) : IInitNpcPerformState.Pack(builder, _o.InitState);
			VectorOffset configsOffset = default(VectorOffset);
			if (_o.Configs != null)
			{
				Offset<INpcPerformStateConfig>[] array = new Offset<INpcPerformStateConfig>[_o.Configs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = INpcPerformStateConfig.Pack(builder, _o.Configs[i]);
				}
				configsOffset = INpcPerformState.CreateConfigsVector(builder, array);
			}
			return INpcPerformState.CreateINpcPerformState(builder, initStateOffset, configsOffset);
		}

		// Token: 0x0400E9E0 RID: 59872
		private Table __p;
	}
}
