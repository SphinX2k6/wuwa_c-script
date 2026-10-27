using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F63 RID: 28515
	public struct ISendBattleEventsForMonsterSummon : IFlatbufferObject
	{
		// Token: 0x1700D3DA RID: 54234
		// (get) Token: 0x06032605 RID: 206341 RVA: 0x006CD11C File Offset: 0x006CB31C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032606 RID: 206342 RVA: 0x006CD129 File Offset: 0x006CB329
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032607 RID: 206343 RVA: 0x006CD130 File Offset: 0x006CB330
		public static ISendBattleEventsForMonsterSummon GetRootAsISendBattleEventsForMonsterSummon(ByteBuffer _bb)
		{
			return ISendBattleEventsForMonsterSummon.GetRootAsISendBattleEventsForMonsterSummon(_bb, default(ISendBattleEventsForMonsterSummon));
		}

		// Token: 0x06032608 RID: 206344 RVA: 0x006CD14C File Offset: 0x006CB34C
		public static ISendBattleEventsForMonsterSummon GetRootAsISendBattleEventsForMonsterSummon(ByteBuffer _bb, ISendBattleEventsForMonsterSummon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032609 RID: 206345 RVA: 0x006CD169 File Offset: 0x006CB369
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603260A RID: 206346 RVA: 0x006CD178 File Offset: 0x006CB378
		public ISendBattleEventsForMonsterSummon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3DB RID: 54235
		// (get) Token: 0x0603260B RID: 206347 RVA: 0x006CD188 File Offset: 0x006CB388
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

		// Token: 0x0603260C RID: 206348 RVA: 0x006CD1C4 File Offset: 0x006CB3C4
		public ISendBattleEventsForMonsterSummonConfig? Configs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISendBattleEventsForMonsterSummonConfig?(default(ISendBattleEventsForMonsterSummonConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D3DC RID: 54236
		// (get) Token: 0x0603260D RID: 206349 RVA: 0x006CD224 File Offset: 0x006CB424
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

		// Token: 0x0603260E RID: 206350 RVA: 0x006CD24F File Offset: 0x006CB44F
		public static Offset<ISendBattleEventsForMonsterSummon> CreateISendBattleEventsForMonsterSummon(FlatBufferBuilder builder, EExecBattleActionType Type = EExecBattleActionType.SetBattleTags, VectorOffset ConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISendBattleEventsForMonsterSummon.AddConfigs(builder, ConfigsOffset);
			ISendBattleEventsForMonsterSummon.AddType(builder, Type);
			return ISendBattleEventsForMonsterSummon.EndISendBattleEventsForMonsterSummon(builder);
		}

		// Token: 0x0603260F RID: 206351 RVA: 0x006CD26C File Offset: 0x006CB46C
		public static void StartISendBattleEventsForMonsterSummon(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032610 RID: 206352 RVA: 0x006CD275 File Offset: 0x006CB475
		public static void AddType(FlatBufferBuilder builder, EExecBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032611 RID: 206353 RVA: 0x006CD280 File Offset: 0x006CB480
		public static void AddConfigs(FlatBufferBuilder builder, VectorOffset configsOffset)
		{
			builder.AddOffset(1, configsOffset.Value, 0);
		}

		// Token: 0x06032612 RID: 206354 RVA: 0x006CD290 File Offset: 0x006CB490
		public static VectorOffset CreateConfigsVector(FlatBufferBuilder builder, Offset<ISendBattleEventsForMonsterSummonConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06032613 RID: 206355 RVA: 0x006CD2D0 File Offset: 0x006CB4D0
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, Offset<ISendBattleEventsForMonsterSummonConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISendBattleEventsForMonsterSummonConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032614 RID: 206356 RVA: 0x006CD2EA File Offset: 0x006CB4EA
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISendBattleEventsForMonsterSummonConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISendBattleEventsForMonsterSummonConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032615 RID: 206357 RVA: 0x006CD308 File Offset: 0x006CB508
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISendBattleEventsForMonsterSummonConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032616 RID: 206358 RVA: 0x006CD321 File Offset: 0x006CB521
		public static void StartConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032617 RID: 206359 RVA: 0x006CD32C File Offset: 0x006CB52C
		public static Offset<ISendBattleEventsForMonsterSummon> EndISendBattleEventsForMonsterSummon(FlatBufferBuilder builder)
		{
			return new Offset<ISendBattleEventsForMonsterSummon>(builder.EndTable());
		}

		// Token: 0x06032618 RID: 206360 RVA: 0x006CD33C File Offset: 0x006CB53C
		public ISendBattleEventsForMonsterSummonT UnPack()
		{
			ISendBattleEventsForMonsterSummonT sendBattleEventsForMonsterSummonT = new ISendBattleEventsForMonsterSummonT();
			this.UnPackTo(sendBattleEventsForMonsterSummonT);
			return sendBattleEventsForMonsterSummonT;
		}

		// Token: 0x06032619 RID: 206361 RVA: 0x006CD358 File Offset: 0x006CB558
		public void UnPackTo(ISendBattleEventsForMonsterSummonT _o)
		{
			_o.Type = this.Type;
			_o.Configs = new List<ISendBattleEventsForMonsterSummonConfigT>();
			for (int i = 0; i < this.ConfigsLength; i++)
			{
				_o.Configs.Add((this.Configs(i) != null) ? this.Configs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0603261A RID: 206362 RVA: 0x006CD3C4 File Offset: 0x006CB5C4
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

		// Token: 0x0401195C RID: 72028
		private Table __p;
	}
}
