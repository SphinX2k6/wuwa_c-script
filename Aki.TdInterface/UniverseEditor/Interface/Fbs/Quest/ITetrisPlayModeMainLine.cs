using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041C6 RID: 16838
	public struct ITetrisPlayModeMainLine : IFlatbufferObject
	{
		// Token: 0x17007761 RID: 30561
		// (get) Token: 0x06018CC2 RID: 101570 RVA: 0x00391AAC File Offset: 0x0038FCAC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018CC3 RID: 101571 RVA: 0x00391AB9 File Offset: 0x0038FCB9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018CC4 RID: 101572 RVA: 0x00391AC0 File Offset: 0x0038FCC0
		public static ITetrisPlayModeMainLine GetRootAsITetrisPlayModeMainLine(ByteBuffer _bb)
		{
			return ITetrisPlayModeMainLine.GetRootAsITetrisPlayModeMainLine(_bb, default(ITetrisPlayModeMainLine));
		}

		// Token: 0x06018CC5 RID: 101573 RVA: 0x00391ADC File Offset: 0x0038FCDC
		public static ITetrisPlayModeMainLine GetRootAsITetrisPlayModeMainLine(ByteBuffer _bb, ITetrisPlayModeMainLine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018CC6 RID: 101574 RVA: 0x00391AF9 File Offset: 0x0038FCF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018CC7 RID: 101575 RVA: 0x00391B08 File Offset: 0x0038FD08
		public ITetrisPlayModeMainLine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007762 RID: 30562
		// (get) Token: 0x06018CC8 RID: 101576 RVA: 0x00391B18 File Offset: 0x0038FD18
		public ETetrisPlayMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETetrisPlayMode.Normal;
				}
				return (ETetrisPlayMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007763 RID: 30563
		// (get) Token: 0x06018CC9 RID: 101577 RVA: 0x00391B54 File Offset: 0x0038FD54
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007764 RID: 30564
		// (get) Token: 0x06018CCA RID: 101578 RVA: 0x00391B90 File Offset: 0x0038FD90
		public string EntityState
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018CCB RID: 101579 RVA: 0x00391BC7 File Offset: 0x0038FDC7
		public Span<byte> GetEntityStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06018CCC RID: 101580 RVA: 0x00391BD6 File Offset: 0x0038FDD6
		public byte[] GetEntityStateArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17007765 RID: 30565
		// (get) Token: 0x06018CCD RID: 101581 RVA: 0x00391BE4 File Offset: 0x0038FDE4
		public int FieldHeight
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007766 RID: 30566
		// (get) Token: 0x06018CCE RID: 101582 RVA: 0x00391C24 File Offset: 0x0038FE24
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018CCF RID: 101583 RVA: 0x00391C61 File Offset: 0x0038FE61
		public static Offset<ITetrisPlayModeMainLine> CreateITetrisPlayModeMainLine(FlatBufferBuilder builder, ETetrisPlayMode Type = ETetrisPlayMode.Normal, int EntityId = 0, StringOffset EntityStateOffset = default(StringOffset), int FieldHeight = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			ITetrisPlayModeMainLine.AddFieldHeight(builder, FieldHeight);
			ITetrisPlayModeMainLine.AddEntityState(builder, EntityStateOffset);
			ITetrisPlayModeMainLine.AddEntityId(builder, EntityId);
			ITetrisPlayModeMainLine.AddNullMask(builder, NullMask);
			ITetrisPlayModeMainLine.AddType(builder, Type);
			return ITetrisPlayModeMainLine.EndITetrisPlayModeMainLine(builder);
		}

		// Token: 0x06018CD0 RID: 101584 RVA: 0x00391C95 File Offset: 0x0038FE95
		public static void StartITetrisPlayModeMainLine(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06018CD1 RID: 101585 RVA: 0x00391C9E File Offset: 0x0038FE9E
		public static void AddType(FlatBufferBuilder builder, ETetrisPlayMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018CD2 RID: 101586 RVA: 0x00391CA9 File Offset: 0x0038FEA9
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06018CD3 RID: 101587 RVA: 0x00391CB4 File Offset: 0x0038FEB4
		public static void AddEntityState(FlatBufferBuilder builder, StringOffset entityStateOffset)
		{
			builder.AddOffset(2, entityStateOffset.Value, 0);
		}

		// Token: 0x06018CD4 RID: 101588 RVA: 0x00391CC4 File Offset: 0x0038FEC4
		public static void AddFieldHeight(FlatBufferBuilder builder, int fieldHeight)
		{
			builder.AddInt(3, fieldHeight, 0);
		}

		// Token: 0x06018CD5 RID: 101589 RVA: 0x00391CCF File Offset: 0x0038FECF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06018CD6 RID: 101590 RVA: 0x00391CDA File Offset: 0x0038FEDA
		public static Offset<ITetrisPlayModeMainLine> EndITetrisPlayModeMainLine(FlatBufferBuilder builder)
		{
			return new Offset<ITetrisPlayModeMainLine>(builder.EndTable());
		}

		// Token: 0x06018CD7 RID: 101591 RVA: 0x00391CE8 File Offset: 0x0038FEE8
		public ITetrisPlayModeMainLineT UnPack()
		{
			ITetrisPlayModeMainLineT tetrisPlayModeMainLineT = new ITetrisPlayModeMainLineT();
			this.UnPackTo(tetrisPlayModeMainLineT);
			return tetrisPlayModeMainLineT;
		}

		// Token: 0x06018CD8 RID: 101592 RVA: 0x00391D03 File Offset: 0x0038FF03
		public void UnPackTo(ITetrisPlayModeMainLineT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.EntityState = this.EntityState;
			_o.FieldHeight = this.FieldHeight;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018CD9 RID: 101593 RVA: 0x00391D44 File Offset: 0x0038FF44
		public static Offset<ITetrisPlayModeMainLine> Pack(FlatBufferBuilder builder, ITetrisPlayModeMainLineT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITetrisPlayModeMainLine>);
			}
			StringOffset entityStateOffset = (_o.EntityState == null) ? default(StringOffset) : builder.CreateString(_o.EntityState);
			return ITetrisPlayModeMainLine.CreateITetrisPlayModeMainLine(builder, _o.Type, _o.EntityId, entityStateOffset, _o.FieldHeight, _o.NullMask);
		}

		// Token: 0x0400BE0F RID: 48655
		private Table __p;
	}
}
