using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F93 RID: 28563
	public struct ISetAlertUiVisible : IFlatbufferObject
	{
		// Token: 0x1700D424 RID: 54308
		// (get) Token: 0x060327A5 RID: 206757 RVA: 0x006D05E3 File Offset: 0x006CE7E3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060327A6 RID: 206758 RVA: 0x006D05F0 File Offset: 0x006CE7F0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060327A7 RID: 206759 RVA: 0x006D05F8 File Offset: 0x006CE7F8
		public static ISetAlertUiVisible GetRootAsISetAlertUiVisible(ByteBuffer _bb)
		{
			return ISetAlertUiVisible.GetRootAsISetAlertUiVisible(_bb, default(ISetAlertUiVisible));
		}

		// Token: 0x060327A8 RID: 206760 RVA: 0x006D0614 File Offset: 0x006CE814
		public static ISetAlertUiVisible GetRootAsISetAlertUiVisible(ByteBuffer _bb, ISetAlertUiVisible obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060327A9 RID: 206761 RVA: 0x006D0631 File Offset: 0x006CE831
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060327AA RID: 206762 RVA: 0x006D0640 File Offset: 0x006CE840
		public ISetAlertUiVisible __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D425 RID: 54309
		// (get) Token: 0x060327AB RID: 206763 RVA: 0x006D0650 File Offset: 0x006CE850
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

		// Token: 0x1700D426 RID: 54310
		// (get) Token: 0x060327AC RID: 206764 RVA: 0x006D068C File Offset: 0x006CE88C
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

		// Token: 0x1700D427 RID: 54311
		// (get) Token: 0x060327AD RID: 206765 RVA: 0x006D06C8 File Offset: 0x006CE8C8
		public bool IsVisible
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060327AE RID: 206766 RVA: 0x006D0707 File Offset: 0x006CE907
		public static Offset<ISetAlertUiVisible> CreateISetAlertUiVisible(FlatBufferBuilder builder, EAlertSystemOption Type = EAlertSystemOption.EnableAlertArea, int AreaId = 0, bool IsVisible = false)
		{
			builder.StartTable(3);
			ISetAlertUiVisible.AddAreaId(builder, AreaId);
			ISetAlertUiVisible.AddIsVisible(builder, IsVisible);
			ISetAlertUiVisible.AddType(builder, Type);
			return ISetAlertUiVisible.EndISetAlertUiVisible(builder);
		}

		// Token: 0x060327AF RID: 206767 RVA: 0x006D072B File Offset: 0x006CE92B
		public static void StartISetAlertUiVisible(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060327B0 RID: 206768 RVA: 0x006D0734 File Offset: 0x006CE934
		public static void AddType(FlatBufferBuilder builder, EAlertSystemOption type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060327B1 RID: 206769 RVA: 0x006D073F File Offset: 0x006CE93F
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(1, areaId, 0);
		}

		// Token: 0x060327B2 RID: 206770 RVA: 0x006D074A File Offset: 0x006CE94A
		public static void AddIsVisible(FlatBufferBuilder builder, bool isVisible)
		{
			builder.AddBool(2, isVisible, false);
		}

		// Token: 0x060327B3 RID: 206771 RVA: 0x006D0755 File Offset: 0x006CE955
		public static Offset<ISetAlertUiVisible> EndISetAlertUiVisible(FlatBufferBuilder builder)
		{
			return new Offset<ISetAlertUiVisible>(builder.EndTable());
		}

		// Token: 0x060327B4 RID: 206772 RVA: 0x006D0764 File Offset: 0x006CE964
		public ISetAlertUiVisibleT UnPack()
		{
			ISetAlertUiVisibleT setAlertUiVisibleT = new ISetAlertUiVisibleT();
			this.UnPackTo(setAlertUiVisibleT);
			return setAlertUiVisibleT;
		}

		// Token: 0x060327B5 RID: 206773 RVA: 0x006D077F File Offset: 0x006CE97F
		public void UnPackTo(ISetAlertUiVisibleT _o)
		{
			_o.Type = this.Type;
			_o.AreaId = this.AreaId;
			_o.IsVisible = this.IsVisible;
		}

		// Token: 0x060327B6 RID: 206774 RVA: 0x006D07A8 File Offset: 0x006CE9A8
		public static Offset<ISetAlertUiVisible> Pack(FlatBufferBuilder builder, ISetAlertUiVisibleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetAlertUiVisible>);
			}
			return ISetAlertUiVisible.CreateISetAlertUiVisible(builder, _o.Type, _o.AreaId, _o.IsVisible);
		}

		// Token: 0x0401198F RID: 72079
		private Table __p;
	}
}
