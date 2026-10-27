using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BE5 RID: 27621
	public struct INpcSwing : IFlatbufferObject
	{
		// Token: 0x1700CD43 RID: 52547
		// (get) Token: 0x0603086E RID: 198766 RVA: 0x0069684F File Offset: 0x00694A4F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603086F RID: 198767 RVA: 0x0069685C File Offset: 0x00694A5C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030870 RID: 198768 RVA: 0x00696864 File Offset: 0x00694A64
		public static INpcSwing GetRootAsINpcSwing(ByteBuffer _bb)
		{
			return INpcSwing.GetRootAsINpcSwing(_bb, default(INpcSwing));
		}

		// Token: 0x06030871 RID: 198769 RVA: 0x00696880 File Offset: 0x00694A80
		public static INpcSwing GetRootAsINpcSwing(ByteBuffer _bb, INpcSwing obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030872 RID: 198770 RVA: 0x0069689D File Offset: 0x00694A9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030873 RID: 198771 RVA: 0x006968AC File Offset: 0x00694AAC
		public INpcSwing __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD44 RID: 52548
		// (get) Token: 0x06030874 RID: 198772 RVA: 0x006968BC File Offset: 0x00694ABC
		public ENpcLeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcLeisureInteract.SitDown;
				}
				return (ENpcLeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CD45 RID: 52549
		// (get) Token: 0x06030875 RID: 198773 RVA: 0x006968F8 File Offset: 0x00694AF8
		public bool KeepState
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CD46 RID: 52550
		// (get) Token: 0x06030876 RID: 198774 RVA: 0x00696938 File Offset: 0x00694B38
		public int TargetNpcId
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

		// Token: 0x1700CD47 RID: 52551
		// (get) Token: 0x06030877 RID: 198775 RVA: 0x00696974 File Offset: 0x00694B74
		public string SwingDa
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030878 RID: 198776 RVA: 0x006969AC File Offset: 0x00694BAC
		public Span<byte> GetSwingDaBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06030879 RID: 198777 RVA: 0x006969BC File Offset: 0x00694BBC
		public byte[] GetSwingDaArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700CD48 RID: 52552
		// (get) Token: 0x0603087A RID: 198778 RVA: 0x006969CC File Offset: 0x00694BCC
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CD49 RID: 52553
		// (get) Token: 0x0603087B RID: 198779 RVA: 0x00696A0C File Offset: 0x00694C0C
		public bool SkipSitDown
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CD4A RID: 52554
		// (get) Token: 0x0603087C RID: 198780 RVA: 0x00696A4C File Offset: 0x00694C4C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603087D RID: 198781 RVA: 0x00696A8C File Offset: 0x00694C8C
		public static Offset<INpcSwing> CreateINpcSwing(FlatBufferBuilder builder, ENpcLeisureInteract Type = ENpcLeisureInteract.SitDown, bool KeepState = false, int TargetNpcId = 0, StringOffset SwingDaOffset = default(StringOffset), int EntityId = 0, bool SkipSitDown = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			INpcSwing.AddEntityId(builder, EntityId);
			INpcSwing.AddSwingDa(builder, SwingDaOffset);
			INpcSwing.AddTargetNpcId(builder, TargetNpcId);
			INpcSwing.AddNullMask(builder, NullMask);
			INpcSwing.AddSkipSitDown(builder, SkipSitDown);
			INpcSwing.AddKeepState(builder, KeepState);
			INpcSwing.AddType(builder, Type);
			return INpcSwing.EndINpcSwing(builder);
		}

		// Token: 0x0603087E RID: 198782 RVA: 0x00696ADB File Offset: 0x00694CDB
		public static void StartINpcSwing(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0603087F RID: 198783 RVA: 0x00696AE4 File Offset: 0x00694CE4
		public static void AddType(FlatBufferBuilder builder, ENpcLeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030880 RID: 198784 RVA: 0x00696AEF File Offset: 0x00694CEF
		public static void AddKeepState(FlatBufferBuilder builder, bool keepState)
		{
			builder.AddBool(1, keepState, false);
		}

		// Token: 0x06030881 RID: 198785 RVA: 0x00696AFA File Offset: 0x00694CFA
		public static void AddTargetNpcId(FlatBufferBuilder builder, int targetNpcId)
		{
			builder.AddInt(2, targetNpcId, 0);
		}

		// Token: 0x06030882 RID: 198786 RVA: 0x00696B05 File Offset: 0x00694D05
		public static void AddSwingDa(FlatBufferBuilder builder, StringOffset swingDaOffset)
		{
			builder.AddOffset(3, swingDaOffset.Value, 0);
		}

		// Token: 0x06030883 RID: 198787 RVA: 0x00696B15 File Offset: 0x00694D15
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(4, entityId, 0);
		}

		// Token: 0x06030884 RID: 198788 RVA: 0x00696B20 File Offset: 0x00694D20
		public static void AddSkipSitDown(FlatBufferBuilder builder, bool skipSitDown)
		{
			builder.AddBool(5, skipSitDown, false);
		}

		// Token: 0x06030885 RID: 198789 RVA: 0x00696B2B File Offset: 0x00694D2B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06030886 RID: 198790 RVA: 0x00696B36 File Offset: 0x00694D36
		public static Offset<INpcSwing> EndINpcSwing(FlatBufferBuilder builder)
		{
			return new Offset<INpcSwing>(builder.EndTable());
		}

		// Token: 0x06030887 RID: 198791 RVA: 0x00696B44 File Offset: 0x00694D44
		public INpcSwingT UnPack()
		{
			INpcSwingT npcSwingT = new INpcSwingT();
			this.UnPackTo(npcSwingT);
			return npcSwingT;
		}

		// Token: 0x06030888 RID: 198792 RVA: 0x00696B60 File Offset: 0x00694D60
		public void UnPackTo(INpcSwingT _o)
		{
			_o.Type = this.Type;
			_o.KeepState = this.KeepState;
			_o.TargetNpcId = this.TargetNpcId;
			_o.SwingDa = this.SwingDa;
			_o.EntityId = this.EntityId;
			_o.SkipSitDown = this.SkipSitDown;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030889 RID: 198793 RVA: 0x00696BC4 File Offset: 0x00694DC4
		public static Offset<INpcSwing> Pack(FlatBufferBuilder builder, INpcSwingT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcSwing>);
			}
			StringOffset swingDaOffset = (_o.SwingDa == null) ? default(StringOffset) : builder.CreateString(_o.SwingDa);
			return INpcSwing.CreateINpcSwing(builder, _o.Type, _o.KeepState, _o.TargetNpcId, swingDaOffset, _o.EntityId, _o.SkipSitDown, _o.NullMask);
		}

		// Token: 0x040114CD RID: 70861
		private Table __p;
	}
}
