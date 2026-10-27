using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DDD RID: 28125
	public struct IQiuyuanQinggongEnd : IFlatbufferObject
	{
		// Token: 0x1700D1AB RID: 53675
		// (get) Token: 0x06031ADD RID: 203485 RVA: 0x006BA87D File Offset: 0x006B8A7D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031ADE RID: 203486 RVA: 0x006BA88A File Offset: 0x006B8A8A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031ADF RID: 203487 RVA: 0x006BA894 File Offset: 0x006B8A94
		public static IQiuyuanQinggongEnd GetRootAsIQiuyuanQinggongEnd(ByteBuffer _bb)
		{
			return IQiuyuanQinggongEnd.GetRootAsIQiuyuanQinggongEnd(_bb, default(IQiuyuanQinggongEnd));
		}

		// Token: 0x06031AE0 RID: 203488 RVA: 0x006BA8B0 File Offset: 0x006B8AB0
		public static IQiuyuanQinggongEnd GetRootAsIQiuyuanQinggongEnd(ByteBuffer _bb, IQiuyuanQinggongEnd obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031AE1 RID: 203489 RVA: 0x006BA8CD File Offset: 0x006B8ACD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031AE2 RID: 203490 RVA: 0x006BA8DC File Offset: 0x006B8ADC
		public IQiuyuanQinggongEnd __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1AC RID: 53676
		// (get) Token: 0x06031AE3 RID: 203491 RVA: 0x006BA8EC File Offset: 0x006B8AEC
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

		// Token: 0x06031AE4 RID: 203492 RVA: 0x006BA928 File Offset: 0x006B8B28
		public static Offset<IQiuyuanQinggongEnd> CreateIQiuyuanQinggongEnd(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IQiuyuanQinggongEnd.AddType(builder, Type);
			return IQiuyuanQinggongEnd.EndIQiuyuanQinggongEnd(builder);
		}

		// Token: 0x06031AE5 RID: 203493 RVA: 0x006BA93E File Offset: 0x006B8B3E
		public static void StartIQiuyuanQinggongEnd(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031AE6 RID: 203494 RVA: 0x006BA947 File Offset: 0x006B8B47
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031AE7 RID: 203495 RVA: 0x006BA952 File Offset: 0x006B8B52
		public static Offset<IQiuyuanQinggongEnd> EndIQiuyuanQinggongEnd(FlatBufferBuilder builder)
		{
			return new Offset<IQiuyuanQinggongEnd>(builder.EndTable());
		}

		// Token: 0x06031AE8 RID: 203496 RVA: 0x006BA960 File Offset: 0x006B8B60
		public IQiuyuanQinggongEndT UnPack()
		{
			IQiuyuanQinggongEndT qiuyuanQinggongEndT = new IQiuyuanQinggongEndT();
			this.UnPackTo(qiuyuanQinggongEndT);
			return qiuyuanQinggongEndT;
		}

		// Token: 0x06031AE9 RID: 203497 RVA: 0x006BA97B File Offset: 0x006B8B7B
		public void UnPackTo(IQiuyuanQinggongEndT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031AEA RID: 203498 RVA: 0x006BA98C File Offset: 0x006B8B8C
		public static Offset<IQiuyuanQinggongEnd> Pack(FlatBufferBuilder builder, IQiuyuanQinggongEndT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQiuyuanQinggongEnd>);
			}
			return IQiuyuanQinggongEnd.CreateIQiuyuanQinggongEnd(builder, _o.Type);
		}

		// Token: 0x040117BE RID: 71614
		private Table __p;
	}
}
