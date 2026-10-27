using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006843 RID: 26691
	public struct IFocusOnMapMark : IFlatbufferObject
	{
		// Token: 0x1700C648 RID: 50760
		// (get) Token: 0x0602E89B RID: 190619 RVA: 0x006598B6 File Offset: 0x00657AB6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E89C RID: 190620 RVA: 0x006598C3 File Offset: 0x00657AC3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E89D RID: 190621 RVA: 0x006598CC File Offset: 0x00657ACC
		public static IFocusOnMapMark GetRootAsIFocusOnMapMark(ByteBuffer _bb)
		{
			return IFocusOnMapMark.GetRootAsIFocusOnMapMark(_bb, default(IFocusOnMapMark));
		}

		// Token: 0x0602E89E RID: 190622 RVA: 0x006598E8 File Offset: 0x00657AE8
		public static IFocusOnMapMark GetRootAsIFocusOnMapMark(ByteBuffer _bb, IFocusOnMapMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E89F RID: 190623 RVA: 0x00659905 File Offset: 0x00657B05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E8A0 RID: 190624 RVA: 0x00659914 File Offset: 0x00657B14
		public IFocusOnMapMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C649 RID: 50761
		// (get) Token: 0x0602E8A1 RID: 190625 RVA: 0x00659924 File Offset: 0x00657B24
		public EMapMarkType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMapMarkType.Custom;
				}
				return (EMapMarkType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E8A2 RID: 190626 RVA: 0x00659960 File Offset: 0x00657B60
		public static Offset<IFocusOnMapMark> CreateIFocusOnMapMark(FlatBufferBuilder builder, EMapMarkType Type = EMapMarkType.Custom)
		{
			builder.StartTable(1);
			IFocusOnMapMark.AddType(builder, Type);
			return IFocusOnMapMark.EndIFocusOnMapMark(builder);
		}

		// Token: 0x0602E8A3 RID: 190627 RVA: 0x00659976 File Offset: 0x00657B76
		public static void StartIFocusOnMapMark(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E8A4 RID: 190628 RVA: 0x0065997F File Offset: 0x00657B7F
		public static void AddType(FlatBufferBuilder builder, EMapMarkType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E8A5 RID: 190629 RVA: 0x0065998A File Offset: 0x00657B8A
		public static Offset<IFocusOnMapMark> EndIFocusOnMapMark(FlatBufferBuilder builder)
		{
			return new Offset<IFocusOnMapMark>(builder.EndTable());
		}

		// Token: 0x0602E8A6 RID: 190630 RVA: 0x00659998 File Offset: 0x00657B98
		public IFocusOnMapMarkT UnPack()
		{
			IFocusOnMapMarkT focusOnMapMarkT = new IFocusOnMapMarkT();
			this.UnPackTo(focusOnMapMarkT);
			return focusOnMapMarkT;
		}

		// Token: 0x0602E8A7 RID: 190631 RVA: 0x006599B3 File Offset: 0x00657BB3
		public void UnPackTo(IFocusOnMapMarkT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E8A8 RID: 190632 RVA: 0x006599C4 File Offset: 0x00657BC4
		public static Offset<IFocusOnMapMark> Pack(FlatBufferBuilder builder, IFocusOnMapMarkT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFocusOnMapMark>);
			}
			return IFocusOnMapMark.CreateIFocusOnMapMark(builder, _o.Type);
		}

		// Token: 0x04010F8C RID: 69516
		private Table __p;
	}
}
