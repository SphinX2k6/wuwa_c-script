using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007789 RID: 30601
	public struct ISetBattleTags : IFlatbufferObject
	{
		// Token: 0x1700E03F RID: 57407
		// (get) Token: 0x06035B6E RID: 220014 RVA: 0x00732920 File Offset: 0x00730B20
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035B6F RID: 220015 RVA: 0x0073292D File Offset: 0x00730B2D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035B70 RID: 220016 RVA: 0x00732934 File Offset: 0x00730B34
		public static ISetBattleTags GetRootAsISetBattleTags(ByteBuffer _bb)
		{
			return ISetBattleTags.GetRootAsISetBattleTags(_bb, default(ISetBattleTags));
		}

		// Token: 0x06035B71 RID: 220017 RVA: 0x00732950 File Offset: 0x00730B50
		public static ISetBattleTags GetRootAsISetBattleTags(ByteBuffer _bb, ISetBattleTags obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035B72 RID: 220018 RVA: 0x0073296D File Offset: 0x00730B6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035B73 RID: 220019 RVA: 0x0073297C File Offset: 0x00730B7C
		public ISetBattleTags __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E040 RID: 57408
		// (get) Token: 0x06035B74 RID: 220020 RVA: 0x0073298C File Offset: 0x00730B8C
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

		// Token: 0x06035B75 RID: 220021 RVA: 0x007329C8 File Offset: 0x00730BC8
		public ISetBattleTagConfig? Configs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISetBattleTagConfig?(default(ISetBattleTagConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E041 RID: 57409
		// (get) Token: 0x06035B76 RID: 220022 RVA: 0x00732A28 File Offset: 0x00730C28
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

		// Token: 0x06035B77 RID: 220023 RVA: 0x00732A53 File Offset: 0x00730C53
		public static Offset<ISetBattleTags> CreateISetBattleTags(FlatBufferBuilder builder, EExecBattleActionType Type = EExecBattleActionType.SetBattleTags, VectorOffset ConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISetBattleTags.AddConfigs(builder, ConfigsOffset);
			ISetBattleTags.AddType(builder, Type);
			return ISetBattleTags.EndISetBattleTags(builder);
		}

		// Token: 0x06035B78 RID: 220024 RVA: 0x00732A70 File Offset: 0x00730C70
		public static void StartISetBattleTags(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035B79 RID: 220025 RVA: 0x00732A79 File Offset: 0x00730C79
		public static void AddType(FlatBufferBuilder builder, EExecBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035B7A RID: 220026 RVA: 0x00732A84 File Offset: 0x00730C84
		public static void AddConfigs(FlatBufferBuilder builder, VectorOffset configsOffset)
		{
			builder.AddOffset(1, configsOffset.Value, 0);
		}

		// Token: 0x06035B7B RID: 220027 RVA: 0x00732A94 File Offset: 0x00730C94
		public static VectorOffset CreateConfigsVector(FlatBufferBuilder builder, Offset<ISetBattleTagConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035B7C RID: 220028 RVA: 0x00732AD4 File Offset: 0x00730CD4
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, Offset<ISetBattleTagConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISetBattleTagConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035B7D RID: 220029 RVA: 0x00732AEE File Offset: 0x00730CEE
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISetBattleTagConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISetBattleTagConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035B7E RID: 220030 RVA: 0x00732B0C File Offset: 0x00730D0C
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISetBattleTagConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035B7F RID: 220031 RVA: 0x00732B25 File Offset: 0x00730D25
		public static void StartConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035B80 RID: 220032 RVA: 0x00732B30 File Offset: 0x00730D30
		public static Offset<ISetBattleTags> EndISetBattleTags(FlatBufferBuilder builder)
		{
			return new Offset<ISetBattleTags>(builder.EndTable());
		}

		// Token: 0x06035B81 RID: 220033 RVA: 0x00732B40 File Offset: 0x00730D40
		public ISetBattleTagsT UnPack()
		{
			ISetBattleTagsT setBattleTagsT = new ISetBattleTagsT();
			this.UnPackTo(setBattleTagsT);
			return setBattleTagsT;
		}

		// Token: 0x06035B82 RID: 220034 RVA: 0x00732B5C File Offset: 0x00730D5C
		public void UnPackTo(ISetBattleTagsT _o)
		{
			_o.Type = this.Type;
			_o.Configs = new List<ISetBattleTagConfigT>();
			for (int i = 0; i < this.ConfigsLength; i++)
			{
				_o.Configs.Add((this.Configs(i) != null) ? this.Configs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06035B83 RID: 220035 RVA: 0x00732BC8 File Offset: 0x00730DC8
		public static Offset<ISetBattleTags> Pack(FlatBufferBuilder builder, ISetBattleTagsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetBattleTags>);
			}
			VectorOffset configsOffset = default(VectorOffset);
			if (_o.Configs != null)
			{
				Offset<ISetBattleTagConfig>[] array = new Offset<ISetBattleTagConfig>[_o.Configs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISetBattleTagConfig.Pack(builder, _o.Configs[i]);
				}
				configsOffset = ISetBattleTags.CreateConfigsVector(builder, array);
			}
			return ISetBattleTags.CreateISetBattleTags(builder, _o.Type, configsOffset);
		}

		// Token: 0x040129AC RID: 76204
		private Table __p;
	}
}
