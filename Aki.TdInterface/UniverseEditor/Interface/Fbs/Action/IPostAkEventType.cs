using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D7D RID: 28029
	public struct IPostAkEventType : IFlatbufferObject
	{
		// Token: 0x1700D125 RID: 53541
		// (get) Token: 0x06031836 RID: 202806 RVA: 0x006B64A6 File Offset: 0x006B46A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031837 RID: 202807 RVA: 0x006B64B3 File Offset: 0x006B46B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031838 RID: 202808 RVA: 0x006B64BC File Offset: 0x006B46BC
		public static IPostAkEventType GetRootAsIPostAkEventType(ByteBuffer _bb)
		{
			return IPostAkEventType.GetRootAsIPostAkEventType(_bb, default(IPostAkEventType));
		}

		// Token: 0x06031839 RID: 202809 RVA: 0x006B64D8 File Offset: 0x006B46D8
		public static IPostAkEventType GetRootAsIPostAkEventType(ByteBuffer _bb, IPostAkEventType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603183A RID: 202810 RVA: 0x006B64F5 File Offset: 0x006B46F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603183B RID: 202811 RVA: 0x006B6504 File Offset: 0x006B4704
		public IPostAkEventType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D126 RID: 53542
		// (get) Token: 0x0603183C RID: 202812 RVA: 0x006B6514 File Offset: 0x006B4714
		public EPostAkEvent Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPostAkEvent.Global;
				}
				return (EPostAkEvent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603183D RID: 202813 RVA: 0x006B6550 File Offset: 0x006B4750
		public static Offset<IPostAkEventType> CreateIPostAkEventType(FlatBufferBuilder builder, EPostAkEvent Type = EPostAkEvent.Global)
		{
			builder.StartTable(1);
			IPostAkEventType.AddType(builder, Type);
			return IPostAkEventType.EndIPostAkEventType(builder);
		}

		// Token: 0x0603183E RID: 202814 RVA: 0x006B6566 File Offset: 0x006B4766
		public static void StartIPostAkEventType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603183F RID: 202815 RVA: 0x006B656F File Offset: 0x006B476F
		public static void AddType(FlatBufferBuilder builder, EPostAkEvent type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031840 RID: 202816 RVA: 0x006B657A File Offset: 0x006B477A
		public static Offset<IPostAkEventType> EndIPostAkEventType(FlatBufferBuilder builder)
		{
			return new Offset<IPostAkEventType>(builder.EndTable());
		}

		// Token: 0x06031841 RID: 202817 RVA: 0x006B6588 File Offset: 0x006B4788
		public IPostAkEventTypeT UnPack()
		{
			IPostAkEventTypeT postAkEventTypeT = new IPostAkEventTypeT();
			this.UnPackTo(postAkEventTypeT);
			return postAkEventTypeT;
		}

		// Token: 0x06031842 RID: 202818 RVA: 0x006B65A3 File Offset: 0x006B47A3
		public void UnPackTo(IPostAkEventTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031843 RID: 202819 RVA: 0x006B65B4 File Offset: 0x006B47B4
		public static Offset<IPostAkEventType> Pack(FlatBufferBuilder builder, IPostAkEventTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPostAkEventType>);
			}
			return IPostAkEventType.CreateIPostAkEventType(builder, _o.Type);
		}

		// Token: 0x04011746 RID: 71494
		private Table __p;
	}
}
