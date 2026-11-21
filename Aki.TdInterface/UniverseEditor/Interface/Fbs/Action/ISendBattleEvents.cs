using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007723 RID: 30499
	public struct ISendBattleEvents : IFlatbufferObject
	{
		// Token: 0x1700DFA1 RID: 57249
		// (get) Token: 0x06035827 RID: 219175 RVA: 0x0072C5B0 File Offset: 0x0072A7B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035828 RID: 219176 RVA: 0x0072C5BD File Offset: 0x0072A7BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035829 RID: 219177 RVA: 0x0072C5C4 File Offset: 0x0072A7C4
		public static ISendBattleEvents GetRootAsISendBattleEvents(ByteBuffer _bb)
		{
			return ISendBattleEvents.GetRootAsISendBattleEvents(_bb, default(ISendBattleEvents));
		}

		// Token: 0x0603582A RID: 219178 RVA: 0x0072C5E0 File Offset: 0x0072A7E0
		public static ISendBattleEvents GetRootAsISendBattleEvents(ByteBuffer _bb, ISendBattleEvents obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603582B RID: 219179 RVA: 0x0072C5FD File Offset: 0x0072A7FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603582C RID: 219180 RVA: 0x0072C60C File Offset: 0x0072A80C
		public ISendBattleEvents __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DFA2 RID: 57250
		// (get) Token: 0x0603582D RID: 219181 RVA: 0x0072C61C File Offset: 0x0072A81C
		public EExecBattleActionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExecBattleActionType.SetBattleTags;
				}
				return (EExecBattleActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603582E RID: 219182 RVA: 0x0072C658 File Offset: 0x0072A858
		public ISetBattleTagConfig? Configs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISetBattleTagConfig?(default(ISetBattleTagConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DFA3 RID: 57251
		// (get) Token: 0x0603582F RID: 219183 RVA: 0x0072C6B8 File Offset: 0x0072A8B8
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

		// Token: 0x06035830 RID: 219184 RVA: 0x0072C6E3 File Offset: 0x0072A8E3
		public static Offset<ISendBattleEvents> CreateISendBattleEvents(FlatBufferBuilder builder, EExecBattleActionType Type = EExecBattleActionType.SetBattleTags, VectorOffset ConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISendBattleEvents.AddConfigs(builder, ConfigsOffset);
			ISendBattleEvents.AddType(builder, Type);
			return ISendBattleEvents.EndISendBattleEvents(builder);
		}

		// Token: 0x06035831 RID: 219185 RVA: 0x0072C700 File Offset: 0x0072A900
		public static void StartISendBattleEvents(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035832 RID: 219186 RVA: 0x0072C709 File Offset: 0x0072A909
		public static void AddType(FlatBufferBuilder builder, EExecBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035833 RID: 219187 RVA: 0x0072C714 File Offset: 0x0072A914
		public static void AddConfigs(FlatBufferBuilder builder, VectorOffset configsOffset)
		{
			builder.AddOffset(1, configsOffset.Value, 0);
		}

		// Token: 0x06035834 RID: 219188 RVA: 0x0072C724 File Offset: 0x0072A924
		public static VectorOffset CreateConfigsVector(FlatBufferBuilder builder, Offset<ISetBattleTagConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035835 RID: 219189 RVA: 0x0072C764 File Offset: 0x0072A964
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, Offset<ISetBattleTagConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISetBattleTagConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035836 RID: 219190 RVA: 0x0072C77E File Offset: 0x0072A97E
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISetBattleTagConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISetBattleTagConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035837 RID: 219191 RVA: 0x0072C79C File Offset: 0x0072A99C
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISetBattleTagConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035838 RID: 219192 RVA: 0x0072C7B5 File Offset: 0x0072A9B5
		public static void StartConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035839 RID: 219193 RVA: 0x0072C7C0 File Offset: 0x0072A9C0
		public static Offset<ISendBattleEvents> EndISendBattleEvents(FlatBufferBuilder builder)
		{
			return new Offset<ISendBattleEvents>(builder.EndTable());
		}

		// Token: 0x0603583A RID: 219194 RVA: 0x0072C7D0 File Offset: 0x0072A9D0
		public ISendBattleEventsT UnPack()
		{
			ISendBattleEventsT sendBattleEventsT = new ISendBattleEventsT();
			this.UnPackTo(sendBattleEventsT);
			return sendBattleEventsT;
		}

		// Token: 0x0603583B RID: 219195 RVA: 0x0072C7EC File Offset: 0x0072A9EC
		public void UnPackTo(ISendBattleEventsT _o)
		{
			_o.Type = this.Type;
			_o.Configs = new List<ISetBattleTagConfigT>();
			for (int i = 0; i < this.ConfigsLength; i++)
			{
				_o.Configs.Add((this.Configs(i) != null) ? this.Configs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0603583C RID: 219196 RVA: 0x0072C858 File Offset: 0x0072AA58
		public static Offset<ISendBattleEvents> Pack(FlatBufferBuilder builder, ISendBattleEventsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISendBattleEvents>);
			}
			VectorOffset configsOffset = default(VectorOffset);
			if (_o.Configs != null)
			{
				Offset<ISetBattleTagConfig>[] array = new Offset<ISetBattleTagConfig>[_o.Configs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISetBattleTagConfig.Pack(builder, _o.Configs[i]);
				}
				configsOffset = ISendBattleEvents.CreateConfigsVector(builder, array);
			}
			return ISendBattleEvents.CreateISendBattleEvents(builder, _o.Type, configsOffset);
		}

		// Token: 0x04012939 RID: 76089
		private Table __p;
	}
}
