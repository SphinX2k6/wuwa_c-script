using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FC0 RID: 28608
	public struct ISetBattleTags : IFlatbufferObject
	{
		// Token: 0x1700D46B RID: 54379
		// (get) Token: 0x06032908 RID: 207112 RVA: 0x006D2CDC File Offset: 0x006D0EDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032909 RID: 207113 RVA: 0x006D2CE9 File Offset: 0x006D0EE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603290A RID: 207114 RVA: 0x006D2CF0 File Offset: 0x006D0EF0
		public static ISetBattleTags GetRootAsISetBattleTags(ByteBuffer _bb)
		{
			return ISetBattleTags.GetRootAsISetBattleTags(_bb, default(ISetBattleTags));
		}

		// Token: 0x0603290B RID: 207115 RVA: 0x006D2D0C File Offset: 0x006D0F0C
		public static ISetBattleTags GetRootAsISetBattleTags(ByteBuffer _bb, ISetBattleTags obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603290C RID: 207116 RVA: 0x006D2D29 File Offset: 0x006D0F29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603290D RID: 207117 RVA: 0x006D2D38 File Offset: 0x006D0F38
		public ISetBattleTags __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D46C RID: 54380
		// (get) Token: 0x0603290E RID: 207118 RVA: 0x006D2D48 File Offset: 0x006D0F48
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

		// Token: 0x0603290F RID: 207119 RVA: 0x006D2D84 File Offset: 0x006D0F84
		public ISetBattleTagConfig? Configs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISetBattleTagConfig?(default(ISetBattleTagConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D46D RID: 54381
		// (get) Token: 0x06032910 RID: 207120 RVA: 0x006D2DE4 File Offset: 0x006D0FE4
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

		// Token: 0x06032911 RID: 207121 RVA: 0x006D2E0F File Offset: 0x006D100F
		public static Offset<ISetBattleTags> CreateISetBattleTags(FlatBufferBuilder builder, EExecBattleActionType Type = EExecBattleActionType.SetBattleTags, VectorOffset ConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISetBattleTags.AddConfigs(builder, ConfigsOffset);
			ISetBattleTags.AddType(builder, Type);
			return ISetBattleTags.EndISetBattleTags(builder);
		}

		// Token: 0x06032912 RID: 207122 RVA: 0x006D2E2C File Offset: 0x006D102C
		public static void StartISetBattleTags(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032913 RID: 207123 RVA: 0x006D2E35 File Offset: 0x006D1035
		public static void AddType(FlatBufferBuilder builder, EExecBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032914 RID: 207124 RVA: 0x006D2E40 File Offset: 0x006D1040
		public static void AddConfigs(FlatBufferBuilder builder, VectorOffset configsOffset)
		{
			builder.AddOffset(1, configsOffset.Value, 0);
		}

		// Token: 0x06032915 RID: 207125 RVA: 0x006D2E50 File Offset: 0x006D1050
		public static VectorOffset CreateConfigsVector(FlatBufferBuilder builder, Offset<ISetBattleTagConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06032916 RID: 207126 RVA: 0x006D2E90 File Offset: 0x006D1090
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, Offset<ISetBattleTagConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISetBattleTagConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032917 RID: 207127 RVA: 0x006D2EAA File Offset: 0x006D10AA
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISetBattleTagConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISetBattleTagConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032918 RID: 207128 RVA: 0x006D2EC8 File Offset: 0x006D10C8
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISetBattleTagConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032919 RID: 207129 RVA: 0x006D2EE1 File Offset: 0x006D10E1
		public static void StartConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603291A RID: 207130 RVA: 0x006D2EEC File Offset: 0x006D10EC
		public static Offset<ISetBattleTags> EndISetBattleTags(FlatBufferBuilder builder)
		{
			return new Offset<ISetBattleTags>(builder.EndTable());
		}

		// Token: 0x0603291B RID: 207131 RVA: 0x006D2EFC File Offset: 0x006D10FC
		public ISetBattleTagsT UnPack()
		{
			ISetBattleTagsT setBattleTagsT = new ISetBattleTagsT();
			this.UnPackTo(setBattleTagsT);
			return setBattleTagsT;
		}

		// Token: 0x0603291C RID: 207132 RVA: 0x006D2F18 File Offset: 0x006D1118
		public void UnPackTo(ISetBattleTagsT _o)
		{
			_o.Type = this.Type;
			_o.Configs = new List<ISetBattleTagConfigT>();
			for (int i = 0; i < this.ConfigsLength; i++)
			{
				_o.Configs.Add((this.Configs(i) != null) ? this.Configs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0603291D RID: 207133 RVA: 0x006D2F84 File Offset: 0x006D1184
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

		// Token: 0x040119C7 RID: 72135
		private Table __p;
	}
}
