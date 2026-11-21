using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007555 RID: 30037
	public struct IQiuyuanLongPressQinggong : IFlatbufferObject
	{
		// Token: 0x1700DCF0 RID: 56560
		// (get) Token: 0x06034AC7 RID: 215751 RVA: 0x00715DF0 File Offset: 0x00713FF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034AC8 RID: 215752 RVA: 0x00715DFD File Offset: 0x00713FFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034AC9 RID: 215753 RVA: 0x00715E04 File Offset: 0x00714004
		public static IQiuyuanLongPressQinggong GetRootAsIQiuyuanLongPressQinggong(ByteBuffer _bb)
		{
			return IQiuyuanLongPressQinggong.GetRootAsIQiuyuanLongPressQinggong(_bb, default(IQiuyuanLongPressQinggong));
		}

		// Token: 0x06034ACA RID: 215754 RVA: 0x00715E20 File Offset: 0x00714020
		public static IQiuyuanLongPressQinggong GetRootAsIQiuyuanLongPressQinggong(ByteBuffer _bb, IQiuyuanLongPressQinggong obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034ACB RID: 215755 RVA: 0x00715E3D File Offset: 0x0071403D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034ACC RID: 215756 RVA: 0x00715E4C File Offset: 0x0071404C
		public IQiuyuanLongPressQinggong __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DCF1 RID: 56561
		// (get) Token: 0x06034ACD RID: 215757 RVA: 0x00715E5C File Offset: 0x0071405C
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

		// Token: 0x06034ACE RID: 215758 RVA: 0x00715E98 File Offset: 0x00714098
		public static Offset<IQiuyuanLongPressQinggong> CreateIQiuyuanLongPressQinggong(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IQiuyuanLongPressQinggong.AddType(builder, Type);
			return IQiuyuanLongPressQinggong.EndIQiuyuanLongPressQinggong(builder);
		}

		// Token: 0x06034ACF RID: 215759 RVA: 0x00715EAE File Offset: 0x007140AE
		public static void StartIQiuyuanLongPressQinggong(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034AD0 RID: 215760 RVA: 0x00715EB7 File Offset: 0x007140B7
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034AD1 RID: 215761 RVA: 0x00715EC2 File Offset: 0x007140C2
		public static Offset<IQiuyuanLongPressQinggong> EndIQiuyuanLongPressQinggong(FlatBufferBuilder builder)
		{
			return new Offset<IQiuyuanLongPressQinggong>(builder.EndTable());
		}

		// Token: 0x06034AD2 RID: 215762 RVA: 0x00715ED0 File Offset: 0x007140D0
		public IQiuyuanLongPressQinggongT UnPack()
		{
			IQiuyuanLongPressQinggongT qiuyuanLongPressQinggongT = new IQiuyuanLongPressQinggongT();
			this.UnPackTo(qiuyuanLongPressQinggongT);
			return qiuyuanLongPressQinggongT;
		}

		// Token: 0x06034AD3 RID: 215763 RVA: 0x00715EEB File Offset: 0x007140EB
		public void UnPackTo(IQiuyuanLongPressQinggongT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034AD4 RID: 215764 RVA: 0x00715EFC File Offset: 0x007140FC
		public static Offset<IQiuyuanLongPressQinggong> Pack(FlatBufferBuilder builder, IQiuyuanLongPressQinggongT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQiuyuanLongPressQinggong>);
			}
			return IQiuyuanLongPressQinggong.CreateIQiuyuanLongPressQinggong(builder, _o.Type);
		}

		// Token: 0x04012738 RID: 75576
		private Table __p;
	}
}
