using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007726 RID: 30502
	public struct ISendBattleEventsForMonsterSummon : IFlatbufferObject
	{
		// Token: 0x1700DFA6 RID: 57254
		// (get) Token: 0x06035843 RID: 219203 RVA: 0x0072C95C File Offset: 0x0072AB5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035844 RID: 219204 RVA: 0x0072C969 File Offset: 0x0072AB69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035845 RID: 219205 RVA: 0x0072C970 File Offset: 0x0072AB70
		public static ISendBattleEventsForMonsterSummon GetRootAsISendBattleEventsForMonsterSummon(ByteBuffer _bb)
		{
			return ISendBattleEventsForMonsterSummon.GetRootAsISendBattleEventsForMonsterSummon(_bb, default(ISendBattleEventsForMonsterSummon));
		}

		// Token: 0x06035846 RID: 219206 RVA: 0x0072C98C File Offset: 0x0072AB8C
		public static ISendBattleEventsForMonsterSummon GetRootAsISendBattleEventsForMonsterSummon(ByteBuffer _bb, ISendBattleEventsForMonsterSummon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035847 RID: 219207 RVA: 0x0072C9A9 File Offset: 0x0072ABA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035848 RID: 219208 RVA: 0x0072C9B8 File Offset: 0x0072ABB8
		public ISendBattleEventsForMonsterSummon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DFA7 RID: 57255
		// (get) Token: 0x06035849 RID: 219209 RVA: 0x0072C9C8 File Offset: 0x0072ABC8
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

		// Token: 0x0603584A RID: 219210 RVA: 0x0072CA04 File Offset: 0x0072AC04
		public ISendBattleEventsForMonsterSummonConfig? Configs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISendBattleEventsForMonsterSummonConfig?(default(ISendBattleEventsForMonsterSummonConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DFA8 RID: 57256
		// (get) Token: 0x0603584B RID: 219211 RVA: 0x0072CA64 File Offset: 0x0072AC64
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

		// Token: 0x0603584C RID: 219212 RVA: 0x0072CA8F File Offset: 0x0072AC8F
		public static Offset<ISendBattleEventsForMonsterSummon> CreateISendBattleEventsForMonsterSummon(FlatBufferBuilder builder, EExecBattleActionType Type = EExecBattleActionType.SetBattleTags, VectorOffset ConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISendBattleEventsForMonsterSummon.AddConfigs(builder, ConfigsOffset);
			ISendBattleEventsForMonsterSummon.AddType(builder, Type);
			return ISendBattleEventsForMonsterSummon.EndISendBattleEventsForMonsterSummon(builder);
		}

		// Token: 0x0603584D RID: 219213 RVA: 0x0072CAAC File Offset: 0x0072ACAC
		public static void StartISendBattleEventsForMonsterSummon(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603584E RID: 219214 RVA: 0x0072CAB5 File Offset: 0x0072ACB5
		public static void AddType(FlatBufferBuilder builder, EExecBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603584F RID: 219215 RVA: 0x0072CAC0 File Offset: 0x0072ACC0
		public static void AddConfigs(FlatBufferBuilder builder, VectorOffset configsOffset)
		{
			builder.AddOffset(1, configsOffset.Value, 0);
		}

		// Token: 0x06035850 RID: 219216 RVA: 0x0072CAD0 File Offset: 0x0072ACD0
		public static VectorOffset CreateConfigsVector(FlatBufferBuilder builder, Offset<ISendBattleEventsForMonsterSummonConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035851 RID: 219217 RVA: 0x0072CB10 File Offset: 0x0072AD10
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, Offset<ISendBattleEventsForMonsterSummonConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISendBattleEventsForMonsterSummonConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035852 RID: 219218 RVA: 0x0072CB2A File Offset: 0x0072AD2A
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISendBattleEventsForMonsterSummonConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISendBattleEventsForMonsterSummonConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035853 RID: 219219 RVA: 0x0072CB48 File Offset: 0x0072AD48
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISendBattleEventsForMonsterSummonConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035854 RID: 219220 RVA: 0x0072CB61 File Offset: 0x0072AD61
		public static void StartConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035855 RID: 219221 RVA: 0x0072CB6C File Offset: 0x0072AD6C
		public static Offset<ISendBattleEventsForMonsterSummon> EndISendBattleEventsForMonsterSummon(FlatBufferBuilder builder)
		{
			return new Offset<ISendBattleEventsForMonsterSummon>(builder.EndTable());
		}

		// Token: 0x06035856 RID: 219222 RVA: 0x0072CB7C File Offset: 0x0072AD7C
		public ISendBattleEventsForMonsterSummonT UnPack()
		{
			ISendBattleEventsForMonsterSummonT sendBattleEventsForMonsterSummonT = new ISendBattleEventsForMonsterSummonT();
			this.UnPackTo(sendBattleEventsForMonsterSummonT);
			return sendBattleEventsForMonsterSummonT;
		}

		// Token: 0x06035857 RID: 219223 RVA: 0x0072CB98 File Offset: 0x0072AD98
		public void UnPackTo(ISendBattleEventsForMonsterSummonT _o)
		{
			_o.Type = this.Type;
			_o.Configs = new List<ISendBattleEventsForMonsterSummonConfigT>();
			for (int i = 0; i < this.ConfigsLength; i++)
			{
				_o.Configs.Add((this.Configs(i) != null) ? this.Configs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06035858 RID: 219224 RVA: 0x0072CC04 File Offset: 0x0072AE04
		public static Offset<ISendBattleEventsForMonsterSummon> Pack(FlatBufferBuilder builder, ISendBattleEventsForMonsterSummonT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISendBattleEventsForMonsterSummon>);
			}
			VectorOffset configsOffset = default(VectorOffset);
			if (_o.Configs != null)
			{
				Offset<ISendBattleEventsForMonsterSummonConfig>[] array = new Offset<ISendBattleEventsForMonsterSummonConfig>[_o.Configs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISendBattleEventsForMonsterSummonConfig.Pack(builder, _o.Configs[i]);
				}
				configsOffset = ISendBattleEventsForMonsterSummon.CreateConfigsVector(builder, array);
			}
			return ISendBattleEventsForMonsterSummon.CreateISendBattleEventsForMonsterSummon(builder, _o.Type, configsOffset);
		}

		// Token: 0x0401293C RID: 76092
		private Table __p;
	}
}
