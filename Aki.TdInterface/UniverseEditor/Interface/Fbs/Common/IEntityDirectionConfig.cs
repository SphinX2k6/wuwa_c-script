using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DA9 RID: 23977
	public struct IEntityDirectionConfig : IFlatbufferObject
	{
		// Token: 0x1700B392 RID: 45970
		// (get) Token: 0x0602909A RID: 168090 RVA: 0x005A2958 File Offset: 0x005A0B58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602909B RID: 168091 RVA: 0x005A2965 File Offset: 0x005A0B65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602909C RID: 168092 RVA: 0x005A296C File Offset: 0x005A0B6C
		public static IEntityDirectionConfig GetRootAsIEntityDirectionConfig(ByteBuffer _bb)
		{
			return IEntityDirectionConfig.GetRootAsIEntityDirectionConfig(_bb, default(IEntityDirectionConfig));
		}

		// Token: 0x0602909D RID: 168093 RVA: 0x005A2988 File Offset: 0x005A0B88
		public static IEntityDirectionConfig GetRootAsIEntityDirectionConfig(ByteBuffer _bb, IEntityDirectionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602909E RID: 168094 RVA: 0x005A29A5 File Offset: 0x005A0BA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602909F RID: 168095 RVA: 0x005A29B4 File Offset: 0x005A0BB4
		public IEntityDirectionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B393 RID: 45971
		// (get) Token: 0x060290A0 RID: 168096 RVA: 0x005A29C4 File Offset: 0x005A0BC4
		public int LevelId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060290A1 RID: 168097 RVA: 0x005A2A00 File Offset: 0x005A0C00
		public IEntityDirection? EntityDirectionConfig(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityDirection?(default(IEntityDirection).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B394 RID: 45972
		// (get) Token: 0x060290A2 RID: 168098 RVA: 0x005A2A60 File Offset: 0x005A0C60
		public int EntityDirectionConfigLength
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

		// Token: 0x060290A3 RID: 168099 RVA: 0x005A2A8B File Offset: 0x005A0C8B
		public static Offset<IEntityDirectionConfig> CreateIEntityDirectionConfig(FlatBufferBuilder builder, int LevelId = 0, VectorOffset EntityDirectionConfigOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IEntityDirectionConfig.AddEntityDirectionConfig(builder, EntityDirectionConfigOffset);
			IEntityDirectionConfig.AddLevelId(builder, LevelId);
			return IEntityDirectionConfig.EndIEntityDirectionConfig(builder);
		}

		// Token: 0x060290A4 RID: 168100 RVA: 0x005A2AA8 File Offset: 0x005A0CA8
		public static void StartIEntityDirectionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060290A5 RID: 168101 RVA: 0x005A2AB1 File Offset: 0x005A0CB1
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(0, levelId, 0);
		}

		// Token: 0x060290A6 RID: 168102 RVA: 0x005A2ABC File Offset: 0x005A0CBC
		public static void AddEntityDirectionConfig(FlatBufferBuilder builder, VectorOffset entityDirectionConfigOffset)
		{
			builder.AddOffset(1, entityDirectionConfigOffset.Value, 0);
		}

		// Token: 0x060290A7 RID: 168103 RVA: 0x005A2ACC File Offset: 0x005A0CCC
		public static VectorOffset CreateEntityDirectionConfigVector(FlatBufferBuilder builder, Offset<IEntityDirection>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060290A8 RID: 168104 RVA: 0x005A2B0C File Offset: 0x005A0D0C
		public static VectorOffset CreateEntityDirectionConfigVectorBlock(FlatBufferBuilder builder, Offset<IEntityDirection>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityDirection>>(data);
			return builder.EndVector();
		}

		// Token: 0x060290A9 RID: 168105 RVA: 0x005A2B26 File Offset: 0x005A0D26
		public static VectorOffset CreateEntityDirectionConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityDirection>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityDirection>>(data);
			return builder.EndVector();
		}

		// Token: 0x060290AA RID: 168106 RVA: 0x005A2B44 File Offset: 0x005A0D44
		public static VectorOffset CreateEntityDirectionConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityDirection>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060290AB RID: 168107 RVA: 0x005A2B5D File Offset: 0x005A0D5D
		public static void StartEntityDirectionConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060290AC RID: 168108 RVA: 0x005A2B68 File Offset: 0x005A0D68
		public static Offset<IEntityDirectionConfig> EndIEntityDirectionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEntityDirectionConfig>(builder.EndTable());
		}

		// Token: 0x060290AD RID: 168109 RVA: 0x005A2B78 File Offset: 0x005A0D78
		public IEntityDirectionConfigT UnPack()
		{
			IEntityDirectionConfigT entityDirectionConfigT = new IEntityDirectionConfigT();
			this.UnPackTo(entityDirectionConfigT);
			return entityDirectionConfigT;
		}

		// Token: 0x060290AE RID: 168110 RVA: 0x005A2B94 File Offset: 0x005A0D94
		public void UnPackTo(IEntityDirectionConfigT _o)
		{
			_o.LevelId = this.LevelId;
			_o.EntityDirectionConfig = new List<IEntityDirectionT>();
			for (int i = 0; i < this.EntityDirectionConfigLength; i++)
			{
				_o.EntityDirectionConfig.Add((this.EntityDirectionConfig(i) != null) ? this.EntityDirectionConfig(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060290AF RID: 168111 RVA: 0x005A2C00 File Offset: 0x005A0E00
		public static Offset<IEntityDirectionConfig> Pack(FlatBufferBuilder builder, IEntityDirectionConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityDirectionConfig>);
			}
			VectorOffset entityDirectionConfigOffset = default(VectorOffset);
			if (_o.EntityDirectionConfig != null)
			{
				Offset<IEntityDirection>[] array = new Offset<IEntityDirection>[_o.EntityDirectionConfig.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityDirection.Pack(builder, _o.EntityDirectionConfig[i]);
				}
				entityDirectionConfigOffset = IEntityDirectionConfig.CreateEntityDirectionConfigVector(builder, array);
			}
			return IEntityDirectionConfig.CreateIEntityDirectionConfig(builder, _o.LevelId, entityDirectionConfigOffset);
		}

		// Token: 0x0400F784 RID: 63364
		private Table __p;
	}
}
