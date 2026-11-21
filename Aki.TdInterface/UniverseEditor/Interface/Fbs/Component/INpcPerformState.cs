using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BD9 RID: 23513
	public struct INpcPerformState : IFlatbufferObject
	{
		// Token: 0x1700AC12 RID: 44050
		// (get) Token: 0x06026D24 RID: 159012 RVA: 0x00550F6A File Offset: 0x0054F16A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026D25 RID: 159013 RVA: 0x00550F77 File Offset: 0x0054F177
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026D26 RID: 159014 RVA: 0x00550F80 File Offset: 0x0054F180
		public static INpcPerformState GetRootAsINpcPerformState(ByteBuffer _bb)
		{
			return INpcPerformState.GetRootAsINpcPerformState(_bb, default(INpcPerformState));
		}

		// Token: 0x06026D27 RID: 159015 RVA: 0x00550F9C File Offset: 0x0054F19C
		public static INpcPerformState GetRootAsINpcPerformState(ByteBuffer _bb, INpcPerformState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026D28 RID: 159016 RVA: 0x00550FB9 File Offset: 0x0054F1B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026D29 RID: 159017 RVA: 0x00550FC8 File Offset: 0x0054F1C8
		public INpcPerformState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC13 RID: 44051
		// (get) Token: 0x06026D2A RID: 159018 RVA: 0x00550FD8 File Offset: 0x0054F1D8
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

		// Token: 0x06026D2B RID: 159019 RVA: 0x00551038 File Offset: 0x0054F238
		public INpcPerformStateConfig? Configs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new INpcPerformStateConfig?(default(INpcPerformStateConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AC14 RID: 44052
		// (get) Token: 0x06026D2C RID: 159020 RVA: 0x00551098 File Offset: 0x0054F298
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

		// Token: 0x06026D2D RID: 159021 RVA: 0x005510C3 File Offset: 0x0054F2C3
		public static Offset<INpcPerformState> CreateINpcPerformState(FlatBufferBuilder builder, Offset<IInitNpcPerformState> InitStateOffset = default(Offset<IInitNpcPerformState>), VectorOffset ConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			INpcPerformState.AddConfigs(builder, ConfigsOffset);
			INpcPerformState.AddInitState(builder, InitStateOffset);
			return INpcPerformState.EndINpcPerformState(builder);
		}

		// Token: 0x06026D2E RID: 159022 RVA: 0x005510E0 File Offset: 0x0054F2E0
		public static void StartINpcPerformState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026D2F RID: 159023 RVA: 0x005510E9 File Offset: 0x0054F2E9
		public static void AddInitState(FlatBufferBuilder builder, Offset<IInitNpcPerformState> initStateOffset)
		{
			builder.AddOffset(0, initStateOffset.Value, 0);
		}

		// Token: 0x06026D30 RID: 159024 RVA: 0x005510F9 File Offset: 0x0054F2F9
		public static void AddConfigs(FlatBufferBuilder builder, VectorOffset configsOffset)
		{
			builder.AddOffset(1, configsOffset.Value, 0);
		}

		// Token: 0x06026D31 RID: 159025 RVA: 0x0055110C File Offset: 0x0054F30C
		public static VectorOffset CreateConfigsVector(FlatBufferBuilder builder, Offset<INpcPerformStateConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026D32 RID: 159026 RVA: 0x0055114C File Offset: 0x0054F34C
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, Offset<INpcPerformStateConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INpcPerformStateConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026D33 RID: 159027 RVA: 0x00551166 File Offset: 0x0054F366
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INpcPerformStateConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INpcPerformStateConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026D34 RID: 159028 RVA: 0x00551184 File Offset: 0x0054F384
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INpcPerformStateConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026D35 RID: 159029 RVA: 0x0055119D File Offset: 0x0054F39D
		public static void StartConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026D36 RID: 159030 RVA: 0x005511A8 File Offset: 0x0054F3A8
		public static Offset<INpcPerformState> EndINpcPerformState(FlatBufferBuilder builder)
		{
			return new Offset<INpcPerformState>(builder.EndTable());
		}

		// Token: 0x06026D37 RID: 159031 RVA: 0x005511B8 File Offset: 0x0054F3B8
		public INpcPerformStateT UnPack()
		{
			INpcPerformStateT npcPerformStateT = new INpcPerformStateT();
			this.UnPackTo(npcPerformStateT);
			return npcPerformStateT;
		}

		// Token: 0x06026D38 RID: 159032 RVA: 0x005511D4 File Offset: 0x0054F3D4
		public void UnPackTo(INpcPerformStateT _o)
		{
			_o.InitState = ((this.InitState != null) ? this.InitState.Value.UnPack() : null);
			_o.Configs = new List<INpcPerformStateConfigT>();
			for (int i = 0; i < this.ConfigsLength; i++)
			{
				_o.Configs.Add((this.Configs(i) != null) ? this.Configs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06026D39 RID: 159033 RVA: 0x00551264 File Offset: 0x0054F464
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

		// Token: 0x0400F645 RID: 63045
		private Table __p;
	}
}
