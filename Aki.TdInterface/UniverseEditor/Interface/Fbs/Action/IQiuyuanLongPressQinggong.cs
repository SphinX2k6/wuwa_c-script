using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DDA RID: 28122
	public struct IQiuyuanLongPressQinggong : IFlatbufferObject
	{
		// Token: 0x1700D1A8 RID: 53672
		// (get) Token: 0x06031ACB RID: 203467 RVA: 0x006BA708 File Offset: 0x006B8908
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031ACC RID: 203468 RVA: 0x006BA715 File Offset: 0x006B8915
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031ACD RID: 203469 RVA: 0x006BA71C File Offset: 0x006B891C
		public static IQiuyuanLongPressQinggong GetRootAsIQiuyuanLongPressQinggong(ByteBuffer _bb)
		{
			return IQiuyuanLongPressQinggong.GetRootAsIQiuyuanLongPressQinggong(_bb, default(IQiuyuanLongPressQinggong));
		}

		// Token: 0x06031ACE RID: 203470 RVA: 0x006BA738 File Offset: 0x006B8938
		public static IQiuyuanLongPressQinggong GetRootAsIQiuyuanLongPressQinggong(ByteBuffer _bb, IQiuyuanLongPressQinggong obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031ACF RID: 203471 RVA: 0x006BA755 File Offset: 0x006B8955
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031AD0 RID: 203472 RVA: 0x006BA764 File Offset: 0x006B8964
		public IQiuyuanLongPressQinggong __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1A9 RID: 53673
		// (get) Token: 0x06031AD1 RID: 203473 RVA: 0x006BA774 File Offset: 0x006B8974
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

		// Token: 0x06031AD2 RID: 203474 RVA: 0x006BA7B0 File Offset: 0x006B89B0
		public static Offset<IQiuyuanLongPressQinggong> CreateIQiuyuanLongPressQinggong(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IQiuyuanLongPressQinggong.AddType(builder, Type);
			return IQiuyuanLongPressQinggong.EndIQiuyuanLongPressQinggong(builder);
		}

		// Token: 0x06031AD3 RID: 203475 RVA: 0x006BA7C6 File Offset: 0x006B89C6
		public static void StartIQiuyuanLongPressQinggong(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031AD4 RID: 203476 RVA: 0x006BA7CF File Offset: 0x006B89CF
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031AD5 RID: 203477 RVA: 0x006BA7DA File Offset: 0x006B89DA
		public static Offset<IQiuyuanLongPressQinggong> EndIQiuyuanLongPressQinggong(FlatBufferBuilder builder)
		{
			return new Offset<IQiuyuanLongPressQinggong>(builder.EndTable());
		}

		// Token: 0x06031AD6 RID: 203478 RVA: 0x006BA7E8 File Offset: 0x006B89E8
		public IQiuyuanLongPressQinggongT UnPack()
		{
			IQiuyuanLongPressQinggongT qiuyuanLongPressQinggongT = new IQiuyuanLongPressQinggongT();
			this.UnPackTo(qiuyuanLongPressQinggongT);
			return qiuyuanLongPressQinggongT;
		}

		// Token: 0x06031AD7 RID: 203479 RVA: 0x006BA803 File Offset: 0x006B8A03
		public void UnPackTo(IQiuyuanLongPressQinggongT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031AD8 RID: 203480 RVA: 0x006BA814 File Offset: 0x006B8A14
		public static Offset<IQiuyuanLongPressQinggong> Pack(FlatBufferBuilder builder, IQiuyuanLongPressQinggongT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQiuyuanLongPressQinggong>);
			}
			return IQiuyuanLongPressQinggong.CreateIQiuyuanLongPressQinggong(builder, _o.Type);
		}

		// Token: 0x040117BC RID: 71612
		private Table __p;
	}
}
