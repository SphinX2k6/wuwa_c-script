using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004799 RID: 18329
	public struct IEntityConfig : IFlatbufferObject
	{
		// Token: 0x17008386 RID: 33670
		// (get) Token: 0x0601C3F9 RID: 115705 RVA: 0x003FFE1B File Offset: 0x003FE01B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C3FA RID: 115706 RVA: 0x003FFE28 File Offset: 0x003FE028
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C3FB RID: 115707 RVA: 0x003FFE30 File Offset: 0x003FE030
		public static IEntityConfig GetRootAsIEntityConfig(ByteBuffer _bb)
		{
			return IEntityConfig.GetRootAsIEntityConfig(_bb, default(IEntityConfig));
		}

		// Token: 0x0601C3FC RID: 115708 RVA: 0x003FFE4C File Offset: 0x003FE04C
		public static IEntityConfig GetRootAsIEntityConfig(ByteBuffer _bb, IEntityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C3FD RID: 115709 RVA: 0x003FFE69 File Offset: 0x003FE069
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C3FE RID: 115710 RVA: 0x003FFE78 File Offset: 0x003FE078
		public IEntityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008387 RID: 33671
		// (get) Token: 0x0601C3FF RID: 115711 RVA: 0x003FFE88 File Offset: 0x003FE088
		public string ComponentsByEntity
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

		// Token: 0x0601C400 RID: 115712 RVA: 0x003FFEBF File Offset: 0x003FE0BF
		public Span<byte> GetComponentsByEntityBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601C401 RID: 115713 RVA: 0x003FFECE File Offset: 0x003FE0CE
		public byte[] GetComponentsByEntityArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601C402 RID: 115714 RVA: 0x003FFEDC File Offset: 0x003FE0DC
		public static Offset<IEntityConfig> CreateIEntityConfig(FlatBufferBuilder builder, StringOffset ComponentsByEntityOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IEntityConfig.AddComponentsByEntity(builder, ComponentsByEntityOffset);
			return IEntityConfig.EndIEntityConfig(builder);
		}

		// Token: 0x0601C403 RID: 115715 RVA: 0x003FFEF2 File Offset: 0x003FE0F2
		public static void StartIEntityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C404 RID: 115716 RVA: 0x003FFEFB File Offset: 0x003FE0FB
		public static void AddComponentsByEntity(FlatBufferBuilder builder, StringOffset componentsByEntityOffset)
		{
			builder.AddOffset(0, componentsByEntityOffset.Value, 0);
		}

		// Token: 0x0601C405 RID: 115717 RVA: 0x003FFF0B File Offset: 0x003FE10B
		public static Offset<IEntityConfig> EndIEntityConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEntityConfig>(builder.EndTable());
		}

		// Token: 0x0601C406 RID: 115718 RVA: 0x003FFF18 File Offset: 0x003FE118
		public IEntityConfigT UnPack()
		{
			IEntityConfigT entityConfigT = new IEntityConfigT();
			this.UnPackTo(entityConfigT);
			return entityConfigT;
		}

		// Token: 0x0601C407 RID: 115719 RVA: 0x003FFF33 File Offset: 0x003FE133
		public void UnPackTo(IEntityConfigT _o)
		{
			_o.ComponentsByEntity = this.ComponentsByEntity;
		}

		// Token: 0x0601C408 RID: 115720 RVA: 0x003FFF44 File Offset: 0x003FE144
		public static Offset<IEntityConfig> Pack(FlatBufferBuilder builder, IEntityConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityConfig>);
			}
			StringOffset componentsByEntityOffset = (_o.ComponentsByEntity == null) ? default(StringOffset) : builder.CreateString(_o.ComponentsByEntity);
			return IEntityConfig.CreateIEntityConfig(builder, componentsByEntityOffset);
		}

		// Token: 0x0400CC09 RID: 52233
		private Table __p;
	}
}
