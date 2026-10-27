using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006840 RID: 26688
	public struct IFocusOnCustomMapMark : IFlatbufferObject
	{
		// Token: 0x1700C643 RID: 50755
		// (get) Token: 0x0602E885 RID: 190597 RVA: 0x006596B8 File Offset: 0x006578B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E886 RID: 190598 RVA: 0x006596C5 File Offset: 0x006578C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E887 RID: 190599 RVA: 0x006596CC File Offset: 0x006578CC
		public static IFocusOnCustomMapMark GetRootAsIFocusOnCustomMapMark(ByteBuffer _bb)
		{
			return IFocusOnCustomMapMark.GetRootAsIFocusOnCustomMapMark(_bb, default(IFocusOnCustomMapMark));
		}

		// Token: 0x0602E888 RID: 190600 RVA: 0x006596E8 File Offset: 0x006578E8
		public static IFocusOnCustomMapMark GetRootAsIFocusOnCustomMapMark(ByteBuffer _bb, IFocusOnCustomMapMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E889 RID: 190601 RVA: 0x00659705 File Offset: 0x00657905
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E88A RID: 190602 RVA: 0x00659714 File Offset: 0x00657914
		public IFocusOnCustomMapMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C644 RID: 50756
		// (get) Token: 0x0602E88B RID: 190603 RVA: 0x00659724 File Offset: 0x00657924
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

		// Token: 0x1700C645 RID: 50757
		// (get) Token: 0x0602E88C RID: 190604 RVA: 0x00659760 File Offset: 0x00657960
		public int MarkId
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

		// Token: 0x0602E88D RID: 190605 RVA: 0x0065979C File Offset: 0x0065799C
		public static Offset<IFocusOnCustomMapMark> CreateIFocusOnCustomMapMark(FlatBufferBuilder builder, EMapMarkType Type = EMapMarkType.Custom, int MarkId = 0)
		{
			builder.StartTable(2);
			IFocusOnCustomMapMark.AddMarkId(builder, MarkId);
			IFocusOnCustomMapMark.AddType(builder, Type);
			return IFocusOnCustomMapMark.EndIFocusOnCustomMapMark(builder);
		}

		// Token: 0x0602E88E RID: 190606 RVA: 0x006597B9 File Offset: 0x006579B9
		public static void StartIFocusOnCustomMapMark(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E88F RID: 190607 RVA: 0x006597C2 File Offset: 0x006579C2
		public static void AddType(FlatBufferBuilder builder, EMapMarkType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E890 RID: 190608 RVA: 0x006597CD File Offset: 0x006579CD
		public static void AddMarkId(FlatBufferBuilder builder, int markId)
		{
			builder.AddInt(1, markId, 0);
		}

		// Token: 0x0602E891 RID: 190609 RVA: 0x006597D8 File Offset: 0x006579D8
		public static Offset<IFocusOnCustomMapMark> EndIFocusOnCustomMapMark(FlatBufferBuilder builder)
		{
			return new Offset<IFocusOnCustomMapMark>(builder.EndTable());
		}

		// Token: 0x0602E892 RID: 190610 RVA: 0x006597E8 File Offset: 0x006579E8
		public IFocusOnCustomMapMarkT UnPack()
		{
			IFocusOnCustomMapMarkT focusOnCustomMapMarkT = new IFocusOnCustomMapMarkT();
			this.UnPackTo(focusOnCustomMapMarkT);
			return focusOnCustomMapMarkT;
		}

		// Token: 0x0602E893 RID: 190611 RVA: 0x00659803 File Offset: 0x00657A03
		public void UnPackTo(IFocusOnCustomMapMarkT _o)
		{
			_o.Type = this.Type;
			_o.MarkId = this.MarkId;
		}

		// Token: 0x0602E894 RID: 190612 RVA: 0x00659820 File Offset: 0x00657A20
		public static Offset<IFocusOnCustomMapMark> Pack(FlatBufferBuilder builder, IFocusOnCustomMapMarkT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFocusOnCustomMapMark>);
			}
			return IFocusOnCustomMapMark.CreateIFocusOnCustomMapMark(builder, _o.Type, _o.MarkId);
		}

		// Token: 0x04010F89 RID: 69513
		private Table __p;
	}
}
