using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007759 RID: 30553
	public struct ISetAlertUiVisible : IFlatbufferObject
	{
		// Token: 0x1700DFF3 RID: 57331
		// (get) Token: 0x060359F5 RID: 219637 RVA: 0x0072FF9B File Offset: 0x0072E19B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060359F6 RID: 219638 RVA: 0x0072FFA8 File Offset: 0x0072E1A8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060359F7 RID: 219639 RVA: 0x0072FFB0 File Offset: 0x0072E1B0
		public static ISetAlertUiVisible GetRootAsISetAlertUiVisible(ByteBuffer _bb)
		{
			return ISetAlertUiVisible.GetRootAsISetAlertUiVisible(_bb, default(ISetAlertUiVisible));
		}

		// Token: 0x060359F8 RID: 219640 RVA: 0x0072FFCC File Offset: 0x0072E1CC
		public static ISetAlertUiVisible GetRootAsISetAlertUiVisible(ByteBuffer _bb, ISetAlertUiVisible obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060359F9 RID: 219641 RVA: 0x0072FFE9 File Offset: 0x0072E1E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060359FA RID: 219642 RVA: 0x0072FFF8 File Offset: 0x0072E1F8
		public ISetAlertUiVisible __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DFF4 RID: 57332
		// (get) Token: 0x060359FB RID: 219643 RVA: 0x00730008 File Offset: 0x0072E208
		public EAlertSystemOption Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAlertSystemOption.EnableAlertArea;
				}
				return (EAlertSystemOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DFF5 RID: 57333
		// (get) Token: 0x060359FC RID: 219644 RVA: 0x00730044 File Offset: 0x0072E244
		public int AreaId
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

		// Token: 0x1700DFF6 RID: 57334
		// (get) Token: 0x060359FD RID: 219645 RVA: 0x00730080 File Offset: 0x0072E280
		public bool IsVisible
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060359FE RID: 219646 RVA: 0x007300BF File Offset: 0x0072E2BF
		public static Offset<ISetAlertUiVisible> CreateISetAlertUiVisible(FlatBufferBuilder builder, EAlertSystemOption Type = EAlertSystemOption.EnableAlertArea, int AreaId = 0, bool IsVisible = false)
		{
			builder.StartTable(3);
			ISetAlertUiVisible.AddAreaId(builder, AreaId);
			ISetAlertUiVisible.AddIsVisible(builder, IsVisible);
			ISetAlertUiVisible.AddType(builder, Type);
			return ISetAlertUiVisible.EndISetAlertUiVisible(builder);
		}

		// Token: 0x060359FF RID: 219647 RVA: 0x007300E3 File Offset: 0x0072E2E3
		public static void StartISetAlertUiVisible(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06035A00 RID: 219648 RVA: 0x007300EC File Offset: 0x0072E2EC
		public static void AddType(FlatBufferBuilder builder, EAlertSystemOption type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035A01 RID: 219649 RVA: 0x007300F7 File Offset: 0x0072E2F7
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(1, areaId, 0);
		}

		// Token: 0x06035A02 RID: 219650 RVA: 0x00730102 File Offset: 0x0072E302
		public static void AddIsVisible(FlatBufferBuilder builder, bool isVisible)
		{
			builder.AddBool(2, isVisible, false);
		}

		// Token: 0x06035A03 RID: 219651 RVA: 0x0073010D File Offset: 0x0072E30D
		public static Offset<ISetAlertUiVisible> EndISetAlertUiVisible(FlatBufferBuilder builder)
		{
			return new Offset<ISetAlertUiVisible>(builder.EndTable());
		}

		// Token: 0x06035A04 RID: 219652 RVA: 0x0073011C File Offset: 0x0072E31C
		public ISetAlertUiVisibleT UnPack()
		{
			ISetAlertUiVisibleT setAlertUiVisibleT = new ISetAlertUiVisibleT();
			this.UnPackTo(setAlertUiVisibleT);
			return setAlertUiVisibleT;
		}

		// Token: 0x06035A05 RID: 219653 RVA: 0x00730137 File Offset: 0x0072E337
		public void UnPackTo(ISetAlertUiVisibleT _o)
		{
			_o.Type = this.Type;
			_o.AreaId = this.AreaId;
			_o.IsVisible = this.IsVisible;
		}

		// Token: 0x06035A06 RID: 219654 RVA: 0x00730160 File Offset: 0x0072E360
		public static Offset<ISetAlertUiVisible> Pack(FlatBufferBuilder builder, ISetAlertUiVisibleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetAlertUiVisible>);
			}
			return ISetAlertUiVisible.CreateISetAlertUiVisible(builder, _o.Type, _o.AreaId, _o.IsVisible);
		}

		// Token: 0x04012971 RID: 76145
		private Table __p;
	}
}
