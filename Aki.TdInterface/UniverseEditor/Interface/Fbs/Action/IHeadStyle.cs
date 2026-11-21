using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F7A RID: 28538
	public struct IHeadStyle : IFlatbufferObject
	{
		// Token: 0x1700D109 RID: 53513
		// (get) Token: 0x06031650 RID: 202320 RVA: 0x006B2BF9 File Offset: 0x006B0DF9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031651 RID: 202321 RVA: 0x006B2C06 File Offset: 0x006B0E06
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031652 RID: 202322 RVA: 0x006B2C10 File Offset: 0x006B0E10
		public static IHeadStyle GetRootAsIHeadStyle(ByteBuffer _bb)
		{
			return IHeadStyle.GetRootAsIHeadStyle(_bb, default(IHeadStyle));
		}

		// Token: 0x06031653 RID: 202323 RVA: 0x006B2C2C File Offset: 0x006B0E2C
		public static IHeadStyle GetRootAsIHeadStyle(ByteBuffer _bb, IHeadStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031654 RID: 202324 RVA: 0x006B2C49 File Offset: 0x006B0E49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031655 RID: 202325 RVA: 0x006B2C58 File Offset: 0x006B0E58
		public IHeadStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D10A RID: 53514
		// (get) Token: 0x06031656 RID: 202326 RVA: 0x006B2C68 File Offset: 0x006B0E68
		public EHeadStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHeadStyle.Normal;
				}
				return (EHeadStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031657 RID: 202327 RVA: 0x006B2CA4 File Offset: 0x006B0EA4
		public static Offset<IHeadStyle> CreateIHeadStyle(FlatBufferBuilder builder, EHeadStyle Type = EHeadStyle.Normal)
		{
			builder.StartTable(1);
			IHeadStyle.AddType(builder, Type);
			return IHeadStyle.EndIHeadStyle(builder);
		}

		// Token: 0x06031658 RID: 202328 RVA: 0x006B2CBA File Offset: 0x006B0EBA
		public static void StartIHeadStyle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031659 RID: 202329 RVA: 0x006B2CC3 File Offset: 0x006B0EC3
		public static void AddType(FlatBufferBuilder builder, EHeadStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603165A RID: 202330 RVA: 0x006B2CCE File Offset: 0x006B0ECE
		public static Offset<IHeadStyle> EndIHeadStyle(FlatBufferBuilder builder)
		{
			return new Offset<IHeadStyle>(builder.EndTable());
		}

		// Token: 0x0603165B RID: 202331 RVA: 0x006B2CDC File Offset: 0x006B0EDC
		public IHeadStyleT UnPack()
		{
			IHeadStyleT headStyleT = new IHeadStyleT();
			this.UnPackTo(headStyleT);
			return headStyleT;
		}

		// Token: 0x0603165C RID: 202332 RVA: 0x006B2CF7 File Offset: 0x006B0EF7
		public void UnPackTo(IHeadStyleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603165D RID: 202333 RVA: 0x006B2D08 File Offset: 0x006B0F08
		public static Offset<IHeadStyle> Pack(FlatBufferBuilder builder, IHeadStyleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHeadStyle>);
			}
			return IHeadStyle.CreateIHeadStyle(builder, _o.Type);
		}

		// Token: 0x04011E8E RID: 73358
		private Table __p;
	}
}
