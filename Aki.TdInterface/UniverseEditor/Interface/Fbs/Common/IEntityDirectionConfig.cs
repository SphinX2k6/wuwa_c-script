using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063E6 RID: 25574
	public struct IEntityDirectionConfig : IFlatbufferObject
	{
		// Token: 0x1700BCF8 RID: 48376
		// (get) Token: 0x0602B724 RID: 177956 RVA: 0x005EB688 File Offset: 0x005E9888
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B725 RID: 177957 RVA: 0x005EB695 File Offset: 0x005E9895
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B726 RID: 177958 RVA: 0x005EB69C File Offset: 0x005E989C
		public static IEntityDirectionConfig GetRootAsIEntityDirectionConfig(ByteBuffer _bb)
		{
			return IEntityDirectionConfig.GetRootAsIEntityDirectionConfig(_bb, default(IEntityDirectionConfig));
		}

		// Token: 0x0602B727 RID: 177959 RVA: 0x005EB6B8 File Offset: 0x005E98B8
		public static IEntityDirectionConfig GetRootAsIEntityDirectionConfig(ByteBuffer _bb, IEntityDirectionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B728 RID: 177960 RVA: 0x005EB6D5 File Offset: 0x005E98D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B729 RID: 177961 RVA: 0x005EB6E4 File Offset: 0x005E98E4
		public IEntityDirectionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCF9 RID: 48377
		// (get) Token: 0x0602B72A RID: 177962 RVA: 0x005EB6F4 File Offset: 0x005E98F4
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

		// Token: 0x0602B72B RID: 177963 RVA: 0x005EB730 File Offset: 0x005E9930
		public IEntityDirection? EntityDirectionConfig(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityDirection?(default(IEntityDirection).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BCFA RID: 48378
		// (get) Token: 0x0602B72C RID: 177964 RVA: 0x005EB790 File Offset: 0x005E9990
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

		// Token: 0x0602B72D RID: 177965 RVA: 0x005EB7BB File Offset: 0x005E99BB
		public static Offset<IEntityDirectionConfig> CreateIEntityDirectionConfig(FlatBufferBuilder builder, int LevelId = 0, VectorOffset EntityDirectionConfigOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IEntityDirectionConfig.AddEntityDirectionConfig(builder, EntityDirectionConfigOffset);
			IEntityDirectionConfig.AddLevelId(builder, LevelId);
			return IEntityDirectionConfig.EndIEntityDirectionConfig(builder);
		}

		// Token: 0x0602B72E RID: 177966 RVA: 0x005EB7D8 File Offset: 0x005E99D8
		public static void StartIEntityDirectionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B72F RID: 177967 RVA: 0x005EB7E1 File Offset: 0x005E99E1
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(0, levelId, 0);
		}

		// Token: 0x0602B730 RID: 177968 RVA: 0x005EB7EC File Offset: 0x005E99EC
		public static void AddEntityDirectionConfig(FlatBufferBuilder builder, VectorOffset entityDirectionConfigOffset)
		{
			builder.AddOffset(1, entityDirectionConfigOffset.Value, 0);
		}

		// Token: 0x0602B731 RID: 177969 RVA: 0x005EB7FC File Offset: 0x005E99FC
		public static VectorOffset CreateEntityDirectionConfigVector(FlatBufferBuilder builder, Offset<IEntityDirection>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602B732 RID: 177970 RVA: 0x005EB83C File Offset: 0x005E9A3C
		public static VectorOffset CreateEntityDirectionConfigVectorBlock(FlatBufferBuilder builder, Offset<IEntityDirection>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityDirection>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B733 RID: 177971 RVA: 0x005EB856 File Offset: 0x005E9A56
		public static VectorOffset CreateEntityDirectionConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityDirection>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityDirection>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B734 RID: 177972 RVA: 0x005EB874 File Offset: 0x005E9A74
		public static VectorOffset CreateEntityDirectionConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityDirection>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602B735 RID: 177973 RVA: 0x005EB88D File Offset: 0x005E9A8D
		public static void StartEntityDirectionConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602B736 RID: 177974 RVA: 0x005EB898 File Offset: 0x005E9A98
		public static Offset<IEntityDirectionConfig> EndIEntityDirectionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEntityDirectionConfig>(builder.EndTable());
		}

		// Token: 0x0602B737 RID: 177975 RVA: 0x005EB8A8 File Offset: 0x005E9AA8
		public IEntityDirectionConfigT UnPack()
		{
			IEntityDirectionConfigT entityDirectionConfigT = new IEntityDirectionConfigT();
			this.UnPackTo(entityDirectionConfigT);
			return entityDirectionConfigT;
		}

		// Token: 0x0602B738 RID: 177976 RVA: 0x005EB8C4 File Offset: 0x005E9AC4
		public void UnPackTo(IEntityDirectionConfigT _o)
		{
			_o.LevelId = this.LevelId;
			_o.EntityDirectionConfig = new List<IEntityDirectionT>();
			for (int i = 0; i < this.EntityDirectionConfigLength; i++)
			{
				_o.EntityDirectionConfig.Add((this.EntityDirectionConfig(i) != null) ? this.EntityDirectionConfig(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602B739 RID: 177977 RVA: 0x005EB930 File Offset: 0x005E9B30
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

		// Token: 0x040104DF RID: 66783
		private Table __p;
	}
}
