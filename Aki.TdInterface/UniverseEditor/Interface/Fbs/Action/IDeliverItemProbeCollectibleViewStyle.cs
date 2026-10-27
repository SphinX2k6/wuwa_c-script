using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006570 RID: 25968
	public struct IDeliverItemProbeCollectibleViewStyle : IFlatbufferObject
	{
		// Token: 0x1700C0F7 RID: 49399
		// (get) Token: 0x0602D0D8 RID: 184536 RVA: 0x0062EA01 File Offset: 0x0062CC01
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D0D9 RID: 184537 RVA: 0x0062EA0E File Offset: 0x0062CC0E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D0DA RID: 184538 RVA: 0x0062EA18 File Offset: 0x0062CC18
		public static IDeliverItemProbeCollectibleViewStyle GetRootAsIDeliverItemProbeCollectibleViewStyle(ByteBuffer _bb)
		{
			return IDeliverItemProbeCollectibleViewStyle.GetRootAsIDeliverItemProbeCollectibleViewStyle(_bb, default(IDeliverItemProbeCollectibleViewStyle));
		}

		// Token: 0x0602D0DB RID: 184539 RVA: 0x0062EA34 File Offset: 0x0062CC34
		public static IDeliverItemProbeCollectibleViewStyle GetRootAsIDeliverItemProbeCollectibleViewStyle(ByteBuffer _bb, IDeliverItemProbeCollectibleViewStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D0DC RID: 184540 RVA: 0x0062EA51 File Offset: 0x0062CC51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D0DD RID: 184541 RVA: 0x0062EA60 File Offset: 0x0062CC60
		public IDeliverItemProbeCollectibleViewStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C0F8 RID: 49400
		// (get) Token: 0x0602D0DE RID: 184542 RVA: 0x0062EA70 File Offset: 0x0062CC70
		public EDeliverItemProbeCollectibleViewStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDeliverItemProbeCollectibleViewStyle.HandInItemStyle;
				}
				return (EDeliverItemProbeCollectibleViewStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D0DF RID: 184543 RVA: 0x0062EAAC File Offset: 0x0062CCAC
		public static Offset<IDeliverItemProbeCollectibleViewStyle> CreateIDeliverItemProbeCollectibleViewStyle(FlatBufferBuilder builder, EDeliverItemProbeCollectibleViewStyle Type = EDeliverItemProbeCollectibleViewStyle.HandInItemStyle)
		{
			builder.StartTable(1);
			IDeliverItemProbeCollectibleViewStyle.AddType(builder, Type);
			return IDeliverItemProbeCollectibleViewStyle.EndIDeliverItemProbeCollectibleViewStyle(builder);
		}

		// Token: 0x0602D0E0 RID: 184544 RVA: 0x0062EAC2 File Offset: 0x0062CCC2
		public static void StartIDeliverItemProbeCollectibleViewStyle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D0E1 RID: 184545 RVA: 0x0062EACB File Offset: 0x0062CCCB
		public static void AddType(FlatBufferBuilder builder, EDeliverItemProbeCollectibleViewStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D0E2 RID: 184546 RVA: 0x0062EAD6 File Offset: 0x0062CCD6
		public static Offset<IDeliverItemProbeCollectibleViewStyle> EndIDeliverItemProbeCollectibleViewStyle(FlatBufferBuilder builder)
		{
			return new Offset<IDeliverItemProbeCollectibleViewStyle>(builder.EndTable());
		}

		// Token: 0x0602D0E3 RID: 184547 RVA: 0x0062EAE4 File Offset: 0x0062CCE4
		public IDeliverItemProbeCollectibleViewStyleT UnPack()
		{
			IDeliverItemProbeCollectibleViewStyleT deliverItemProbeCollectibleViewStyleT = new IDeliverItemProbeCollectibleViewStyleT();
			this.UnPackTo(deliverItemProbeCollectibleViewStyleT);
			return deliverItemProbeCollectibleViewStyleT;
		}

		// Token: 0x0602D0E4 RID: 184548 RVA: 0x0062EAFF File Offset: 0x0062CCFF
		public void UnPackTo(IDeliverItemProbeCollectibleViewStyleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D0E5 RID: 184549 RVA: 0x0062EB10 File Offset: 0x0062CD10
		public static Offset<IDeliverItemProbeCollectibleViewStyle> Pack(FlatBufferBuilder builder, IDeliverItemProbeCollectibleViewStyleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDeliverItemProbeCollectibleViewStyle>);
			}
			return IDeliverItemProbeCollectibleViewStyle.CreateIDeliverItemProbeCollectibleViewStyle(builder, _o.Type);
		}

		// Token: 0x04010BC6 RID: 68550
		private Table __p;
	}
}
