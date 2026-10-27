using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02005EE4 RID: 24292
	public struct IBuffConfig : IFlatbufferObject
	{
		// Token: 0x1700B5A4 RID: 46500
		// (get) Token: 0x06029B72 RID: 170866 RVA: 0x005B9AEC File Offset: 0x005B7CEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029B73 RID: 170867 RVA: 0x005B9AF9 File Offset: 0x005B7CF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029B74 RID: 170868 RVA: 0x005B9B00 File Offset: 0x005B7D00
		public static IBuffConfig GetRootAsIBuffConfig(ByteBuffer _bb)
		{
			return IBuffConfig.GetRootAsIBuffConfig(_bb, default(IBuffConfig));
		}

		// Token: 0x06029B75 RID: 170869 RVA: 0x005B9B1C File Offset: 0x005B7D1C
		public static IBuffConfig GetRootAsIBuffConfig(ByteBuffer _bb, IBuffConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029B76 RID: 170870 RVA: 0x005B9B39 File Offset: 0x005B7D39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029B77 RID: 170871 RVA: 0x005B9B48 File Offset: 0x005B7D48
		public IBuffConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B5A5 RID: 46501
		// (get) Token: 0x06029B78 RID: 170872 RVA: 0x005B9B58 File Offset: 0x005B7D58
		public int Id
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

		// Token: 0x1700B5A6 RID: 46502
		// (get) Token: 0x06029B79 RID: 170873 RVA: 0x005B9B94 File Offset: 0x005B7D94
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029B7A RID: 170874 RVA: 0x005B9BCB File Offset: 0x005B7DCB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06029B7B RID: 170875 RVA: 0x005B9BDA File Offset: 0x005B7DDA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06029B7C RID: 170876 RVA: 0x005B9BE8 File Offset: 0x005B7DE8
		public static Offset<IBuffConfig> CreateIBuffConfig(FlatBufferBuilder builder, int Id = 0, StringOffset NameOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IBuffConfig.AddName(builder, NameOffset);
			IBuffConfig.AddId(builder, Id);
			return IBuffConfig.EndIBuffConfig(builder);
		}

		// Token: 0x06029B7D RID: 170877 RVA: 0x005B9C05 File Offset: 0x005B7E05
		public static void StartIBuffConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029B7E RID: 170878 RVA: 0x005B9C0E File Offset: 0x005B7E0E
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06029B7F RID: 170879 RVA: 0x005B9C19 File Offset: 0x005B7E19
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x06029B80 RID: 170880 RVA: 0x005B9C29 File Offset: 0x005B7E29
		public static Offset<IBuffConfig> EndIBuffConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBuffConfig>(builder.EndTable());
		}

		// Token: 0x06029B81 RID: 170881 RVA: 0x005B9C38 File Offset: 0x005B7E38
		public IBuffConfigT UnPack()
		{
			IBuffConfigT buffConfigT = new IBuffConfigT();
			this.UnPackTo(buffConfigT);
			return buffConfigT;
		}

		// Token: 0x06029B82 RID: 170882 RVA: 0x005B9C53 File Offset: 0x005B7E53
		public void UnPackTo(IBuffConfigT _o)
		{
			_o.Id = this.Id;
			_o.Name = this.Name;
		}

		// Token: 0x06029B83 RID: 170883 RVA: 0x005B9C70 File Offset: 0x005B7E70
		public static Offset<IBuffConfig> Pack(FlatBufferBuilder builder, IBuffConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBuffConfig>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			return IBuffConfig.CreateIBuffConfig(builder, _o.Id, nameOffset);
		}

		// Token: 0x0400F9E9 RID: 63977
		private Table __p;
	}
}
