using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C01 RID: 19457
	public struct IEntityConfig : IFlatbufferObject
	{
		// Token: 0x170089C7 RID: 35271
		// (get) Token: 0x0601DBCE RID: 121806 RVA: 0x0042C0B7 File Offset: 0x0042A2B7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DBCF RID: 121807 RVA: 0x0042C0C4 File Offset: 0x0042A2C4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DBD0 RID: 121808 RVA: 0x0042C0CC File Offset: 0x0042A2CC
		public static IEntityConfig GetRootAsIEntityConfig(ByteBuffer _bb)
		{
			return IEntityConfig.GetRootAsIEntityConfig(_bb, default(IEntityConfig));
		}

		// Token: 0x0601DBD1 RID: 121809 RVA: 0x0042C0E8 File Offset: 0x0042A2E8
		public static IEntityConfig GetRootAsIEntityConfig(ByteBuffer _bb, IEntityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DBD2 RID: 121810 RVA: 0x0042C105 File Offset: 0x0042A305
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DBD3 RID: 121811 RVA: 0x0042C114 File Offset: 0x0042A314
		public IEntityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170089C8 RID: 35272
		// (get) Token: 0x0601DBD4 RID: 121812 RVA: 0x0042C124 File Offset: 0x0042A324
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

		// Token: 0x0601DBD5 RID: 121813 RVA: 0x0042C15B File Offset: 0x0042A35B
		public Span<byte> GetComponentsByEntityBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601DBD6 RID: 121814 RVA: 0x0042C16A File Offset: 0x0042A36A
		public byte[] GetComponentsByEntityArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601DBD7 RID: 121815 RVA: 0x0042C178 File Offset: 0x0042A378
		public static Offset<IEntityConfig> CreateIEntityConfig(FlatBufferBuilder builder, StringOffset ComponentsByEntityOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IEntityConfig.AddComponentsByEntity(builder, ComponentsByEntityOffset);
			return IEntityConfig.EndIEntityConfig(builder);
		}

		// Token: 0x0601DBD8 RID: 121816 RVA: 0x0042C18E File Offset: 0x0042A38E
		public static void StartIEntityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601DBD9 RID: 121817 RVA: 0x0042C197 File Offset: 0x0042A397
		public static void AddComponentsByEntity(FlatBufferBuilder builder, StringOffset componentsByEntityOffset)
		{
			builder.AddOffset(0, componentsByEntityOffset.Value, 0);
		}

		// Token: 0x0601DBDA RID: 121818 RVA: 0x0042C1A7 File Offset: 0x0042A3A7
		public static Offset<IEntityConfig> EndIEntityConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEntityConfig>(builder.EndTable());
		}

		// Token: 0x0601DBDB RID: 121819 RVA: 0x0042C1B4 File Offset: 0x0042A3B4
		public IEntityConfigT UnPack()
		{
			IEntityConfigT entityConfigT = new IEntityConfigT();
			this.UnPackTo(entityConfigT);
			return entityConfigT;
		}

		// Token: 0x0601DBDC RID: 121820 RVA: 0x0042C1CF File Offset: 0x0042A3CF
		public void UnPackTo(IEntityConfigT _o)
		{
			_o.ComponentsByEntity = this.ComponentsByEntity;
		}

		// Token: 0x0601DBDD RID: 121821 RVA: 0x0042C1E0 File Offset: 0x0042A3E0
		public static Offset<IEntityConfig> Pack(FlatBufferBuilder builder, IEntityConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityConfig>);
			}
			StringOffset componentsByEntityOffset = (_o.ComponentsByEntity == null) ? default(StringOffset) : builder.CreateString(_o.ComponentsByEntity);
			return IEntityConfig.CreateIEntityConfig(builder, componentsByEntityOffset);
		}

		// Token: 0x0400D63F RID: 54847
		private Table __p;
	}
}
