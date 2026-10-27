using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007247 RID: 29255
	public struct ISwing : IFlatbufferObject
	{
		// Token: 0x1700D911 RID: 55569
		// (get) Token: 0x06033E30 RID: 212528 RVA: 0x006FAE78 File Offset: 0x006F9078
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033E31 RID: 212529 RVA: 0x006FAE85 File Offset: 0x006F9085
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033E32 RID: 212530 RVA: 0x006FAE8C File Offset: 0x006F908C
		public static ISwing GetRootAsISwing(ByteBuffer _bb)
		{
			return ISwing.GetRootAsISwing(_bb, default(ISwing));
		}

		// Token: 0x06033E33 RID: 212531 RVA: 0x006FAEA8 File Offset: 0x006F90A8
		public static ISwing GetRootAsISwing(ByteBuffer _bb, ISwing obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033E34 RID: 212532 RVA: 0x006FAEC5 File Offset: 0x006F90C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033E35 RID: 212533 RVA: 0x006FAED4 File Offset: 0x006F90D4
		public ISwing __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D912 RID: 55570
		// (get) Token: 0x06033E36 RID: 212534 RVA: 0x006FAEE4 File Offset: 0x006F90E4
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

		// Token: 0x1700D913 RID: 55571
		// (get) Token: 0x06033E37 RID: 212535 RVA: 0x006FAF20 File Offset: 0x006F9120
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

		// Token: 0x06033E38 RID: 212536 RVA: 0x006FAF57 File Offset: 0x006F9157
		public Span<byte> GetSwingDaBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06033E39 RID: 212537 RVA: 0x006FAF66 File Offset: 0x006F9166
		public byte[] GetSwingDaArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D914 RID: 55572
		// (get) Token: 0x06033E3A RID: 212538 RVA: 0x006FAF74 File Offset: 0x006F9174
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

		// Token: 0x06033E3B RID: 212539 RVA: 0x006FAFB0 File Offset: 0x006F91B0
		public static Offset<ISwing> CreateISwing(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, StringOffset SwingDaOffset = default(StringOffset), int EntityId = 0)
		{
			builder.StartTable(3);
			ISwing.AddEntityId(builder, EntityId);
			ISwing.AddSwingDa(builder, SwingDaOffset);
			ISwing.AddType(builder, Type);
			return ISwing.EndISwing(builder);
		}

		// Token: 0x06033E3C RID: 212540 RVA: 0x006FAFD4 File Offset: 0x006F91D4
		public static void StartISwing(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06033E3D RID: 212541 RVA: 0x006FAFDD File Offset: 0x006F91DD
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033E3E RID: 212542 RVA: 0x006FAFE8 File Offset: 0x006F91E8
		public static void AddSwingDa(FlatBufferBuilder builder, StringOffset swingDaOffset)
		{
			builder.AddOffset(1, swingDaOffset.Value, 0);
		}

		// Token: 0x06033E3F RID: 212543 RVA: 0x006FAFF8 File Offset: 0x006F91F8
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x06033E40 RID: 212544 RVA: 0x006FB003 File Offset: 0x006F9203
		public static Offset<ISwing> EndISwing(FlatBufferBuilder builder)
		{
			return new Offset<ISwing>(builder.EndTable());
		}

		// Token: 0x06033E41 RID: 212545 RVA: 0x006FB010 File Offset: 0x006F9210
		public ISwingT UnPack()
		{
			ISwingT swingT = new ISwingT();
			this.UnPackTo(swingT);
			return swingT;
		}

		// Token: 0x06033E42 RID: 212546 RVA: 0x006FB02B File Offset: 0x006F922B
		public void UnPackTo(ISwingT _o)
		{
			_o.Type = this.Type;
			_o.SwingDa = this.SwingDa;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06033E43 RID: 212547 RVA: 0x006FB054 File Offset: 0x006F9254
		public static Offset<ISwing> Pack(FlatBufferBuilder builder, ISwingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwing>);
			}
			StringOffset swingDaOffset = (_o.SwingDa == null) ? default(StringOffset) : builder.CreateString(_o.SwingDa);
			return ISwing.CreateISwing(builder, _o.Type, swingDaOffset, _o.EntityId);
		}

		// Token: 0x04011D38 RID: 73016
		private Table __p;
	}
}
