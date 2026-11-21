using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A1C RID: 31260
	public struct ISwing : IFlatbufferObject
	{
		// Token: 0x1700E50A RID: 58634
		// (get) Token: 0x06037132 RID: 225586 RVA: 0x0075C1D8 File Offset: 0x0075A3D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06037133 RID: 225587 RVA: 0x0075C1E5 File Offset: 0x0075A3E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037134 RID: 225588 RVA: 0x0075C1EC File Offset: 0x0075A3EC
		public static ISwing GetRootAsISwing(ByteBuffer _bb)
		{
			return ISwing.GetRootAsISwing(_bb, default(ISwing));
		}

		// Token: 0x06037135 RID: 225589 RVA: 0x0075C208 File Offset: 0x0075A408
		public static ISwing GetRootAsISwing(ByteBuffer _bb, ISwing obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06037136 RID: 225590 RVA: 0x0075C225 File Offset: 0x0075A425
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06037137 RID: 225591 RVA: 0x0075C234 File Offset: 0x0075A434
		public ISwing __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E50B RID: 58635
		// (get) Token: 0x06037138 RID: 225592 RVA: 0x0075C244 File Offset: 0x0075A444
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E50C RID: 58636
		// (get) Token: 0x06037139 RID: 225593 RVA: 0x0075C280 File Offset: 0x0075A480
		public string SwingDa
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

		// Token: 0x0603713A RID: 225594 RVA: 0x0075C2B7 File Offset: 0x0075A4B7
		public Span<byte> GetSwingDaBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603713B RID: 225595 RVA: 0x0075C2C6 File Offset: 0x0075A4C6
		public byte[] GetSwingDaArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E50D RID: 58637
		// (get) Token: 0x0603713C RID: 225596 RVA: 0x0075C2D4 File Offset: 0x0075A4D4
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603713D RID: 225597 RVA: 0x0075C310 File Offset: 0x0075A510
		public static Offset<ISwing> CreateISwing(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, StringOffset SwingDaOffset = default(StringOffset), int EntityId = 0)
		{
			builder.StartTable(3);
			ISwing.AddEntityId(builder, EntityId);
			ISwing.AddSwingDa(builder, SwingDaOffset);
			ISwing.AddType(builder, Type);
			return ISwing.EndISwing(builder);
		}

		// Token: 0x0603713E RID: 225598 RVA: 0x0075C334 File Offset: 0x0075A534
		public static void StartISwing(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603713F RID: 225599 RVA: 0x0075C33D File Offset: 0x0075A53D
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06037140 RID: 225600 RVA: 0x0075C348 File Offset: 0x0075A548
		public static void AddSwingDa(FlatBufferBuilder builder, StringOffset swingDaOffset)
		{
			builder.AddOffset(1, swingDaOffset.Value, 0);
		}

		// Token: 0x06037141 RID: 225601 RVA: 0x0075C358 File Offset: 0x0075A558
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x06037142 RID: 225602 RVA: 0x0075C363 File Offset: 0x0075A563
		public static Offset<ISwing> EndISwing(FlatBufferBuilder builder)
		{
			return new Offset<ISwing>(builder.EndTable());
		}

		// Token: 0x06037143 RID: 225603 RVA: 0x0075C370 File Offset: 0x0075A570
		public ISwingT UnPack()
		{
			ISwingT swingT = new ISwingT();
			this.UnPackTo(swingT);
			return swingT;
		}

		// Token: 0x06037144 RID: 225604 RVA: 0x0075C38B File Offset: 0x0075A58B
		public void UnPackTo(ISwingT _o)
		{
			_o.Type = this.Type;
			_o.SwingDa = this.SwingDa;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06037145 RID: 225605 RVA: 0x0075C3B4 File Offset: 0x0075A5B4
		public static Offset<ISwing> Pack(FlatBufferBuilder builder, ISwingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwing>);
			}
			StringOffset swingDaOffset = (_o.SwingDa == null) ? default(StringOffset) : builder.CreateString(_o.SwingDa);
			return ISwing.CreateISwing(builder, _o.Type, swingDaOffset, _o.EntityId);
		}

		// Token: 0x04012D3A RID: 77114
		private Table __p;
	}
}
