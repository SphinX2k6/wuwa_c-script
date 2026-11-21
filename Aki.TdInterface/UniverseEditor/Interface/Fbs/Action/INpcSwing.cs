using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007349 RID: 29513
	public struct INpcSwing : IFlatbufferObject
	{
		// Token: 0x1700D84F RID: 55375
		// (get) Token: 0x0603378A RID: 210826 RVA: 0x006F014F File Offset: 0x006EE34F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603378B RID: 210827 RVA: 0x006F015C File Offset: 0x006EE35C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603378C RID: 210828 RVA: 0x006F0164 File Offset: 0x006EE364
		public static INpcSwing GetRootAsINpcSwing(ByteBuffer _bb)
		{
			return INpcSwing.GetRootAsINpcSwing(_bb, default(INpcSwing));
		}

		// Token: 0x0603378D RID: 210829 RVA: 0x006F0180 File Offset: 0x006EE380
		public static INpcSwing GetRootAsINpcSwing(ByteBuffer _bb, INpcSwing obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603378E RID: 210830 RVA: 0x006F019D File Offset: 0x006EE39D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603378F RID: 210831 RVA: 0x006F01AC File Offset: 0x006EE3AC
		public INpcSwing __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D850 RID: 55376
		// (get) Token: 0x06033790 RID: 210832 RVA: 0x006F01BC File Offset: 0x006EE3BC
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

		// Token: 0x1700D851 RID: 55377
		// (get) Token: 0x06033791 RID: 210833 RVA: 0x006F01F8 File Offset: 0x006EE3F8
		public bool KeepState
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D852 RID: 55378
		// (get) Token: 0x06033792 RID: 210834 RVA: 0x006F0238 File Offset: 0x006EE438
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

		// Token: 0x1700D853 RID: 55379
		// (get) Token: 0x06033793 RID: 210835 RVA: 0x006F0274 File Offset: 0x006EE474
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

		// Token: 0x06033794 RID: 210836 RVA: 0x006F02AC File Offset: 0x006EE4AC
		public Span<byte> GetSwingDaBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06033795 RID: 210837 RVA: 0x006F02BC File Offset: 0x006EE4BC
		public byte[] GetSwingDaArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700D854 RID: 55380
		// (get) Token: 0x06033796 RID: 210838 RVA: 0x006F02CC File Offset: 0x006EE4CC
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

		// Token: 0x1700D855 RID: 55381
		// (get) Token: 0x06033797 RID: 210839 RVA: 0x006F030C File Offset: 0x006EE50C
		public bool SkipSitDown
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D856 RID: 55382
		// (get) Token: 0x06033798 RID: 210840 RVA: 0x006F034C File Offset: 0x006EE54C
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

		// Token: 0x06033799 RID: 210841 RVA: 0x006F038C File Offset: 0x006EE58C
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

		// Token: 0x0603379A RID: 210842 RVA: 0x006F03DB File Offset: 0x006EE5DB
		public static void StartINpcSwing(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0603379B RID: 210843 RVA: 0x006F03E4 File Offset: 0x006EE5E4
		public static void AddType(FlatBufferBuilder builder, ENpcLeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603379C RID: 210844 RVA: 0x006F03EF File Offset: 0x006EE5EF
		public static void AddKeepState(FlatBufferBuilder builder, bool keepState)
		{
			builder.AddBool(1, keepState, false);
		}

		// Token: 0x0603379D RID: 210845 RVA: 0x006F03FA File Offset: 0x006EE5FA
		public static void AddTargetNpcId(FlatBufferBuilder builder, int targetNpcId)
		{
			builder.AddInt(2, targetNpcId, 0);
		}

		// Token: 0x0603379E RID: 210846 RVA: 0x006F0405 File Offset: 0x006EE605
		public static void AddSwingDa(FlatBufferBuilder builder, StringOffset swingDaOffset)
		{
			builder.AddOffset(3, swingDaOffset.Value, 0);
		}

		// Token: 0x0603379F RID: 210847 RVA: 0x006F0415 File Offset: 0x006EE615
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(4, entityId, 0);
		}

		// Token: 0x060337A0 RID: 210848 RVA: 0x006F0420 File Offset: 0x006EE620
		public static void AddSkipSitDown(FlatBufferBuilder builder, bool skipSitDown)
		{
			builder.AddBool(5, skipSitDown, false);
		}

		// Token: 0x060337A1 RID: 210849 RVA: 0x006F042B File Offset: 0x006EE62B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060337A2 RID: 210850 RVA: 0x006F0436 File Offset: 0x006EE636
		public static Offset<INpcSwing> EndINpcSwing(FlatBufferBuilder builder)
		{
			return new Offset<INpcSwing>(builder.EndTable());
		}

		// Token: 0x060337A3 RID: 210851 RVA: 0x006F0444 File Offset: 0x006EE644
		public INpcSwingT UnPack()
		{
			INpcSwingT npcSwingT = new INpcSwingT();
			this.UnPackTo(npcSwingT);
			return npcSwingT;
		}

		// Token: 0x060337A4 RID: 210852 RVA: 0x006F0460 File Offset: 0x006EE660
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

		// Token: 0x060337A5 RID: 210853 RVA: 0x006F04C4 File Offset: 0x006EE6C4
		public static Offset<INpcSwing> Pack(FlatBufferBuilder builder, INpcSwingT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcSwing>);
			}
			StringOffset swingDaOffset = (_o.SwingDa == null) ? default(StringOffset) : builder.CreateString(_o.SwingDa);
			return INpcSwing.CreateINpcSwing(builder, _o.Type, _o.KeepState, _o.TargetNpcId, swingDaOffset, _o.EntityId, _o.SkipSitDown, _o.NullMask);
		}

		// Token: 0x0401241C RID: 74780
		private Table __p;
	}
}
