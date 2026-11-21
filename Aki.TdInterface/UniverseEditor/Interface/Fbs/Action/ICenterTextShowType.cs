using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200692B RID: 26923
	public struct ICenterTextShowType : IFlatbufferObject
	{
		// Token: 0x1700C63B RID: 50747
		// (get) Token: 0x0602E246 RID: 188998 RVA: 0x0064E195 File Offset: 0x0064C395
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E247 RID: 188999 RVA: 0x0064E1A2 File Offset: 0x0064C3A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E248 RID: 189000 RVA: 0x0064E1AC File Offset: 0x0064C3AC
		public static ICenterTextShowType GetRootAsICenterTextShowType(ByteBuffer _bb)
		{
			return ICenterTextShowType.GetRootAsICenterTextShowType(_bb, default(ICenterTextShowType));
		}

		// Token: 0x0602E249 RID: 189001 RVA: 0x0064E1C8 File Offset: 0x0064C3C8
		public static ICenterTextShowType GetRootAsICenterTextShowType(ByteBuffer _bb, ICenterTextShowType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E24A RID: 189002 RVA: 0x0064E1E5 File Offset: 0x0064C3E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E24B RID: 189003 RVA: 0x0064E1F4 File Offset: 0x0064C3F4
		public ICenterTextShowType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C63C RID: 50748
		// (get) Token: 0x0602E24C RID: 189004 RVA: 0x0064E204 File Offset: 0x0064C404
		public ECenterTextShowAnim Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECenterTextShowAnim.ShowAll;
				}
				return (ECenterTextShowAnim)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E24D RID: 189005 RVA: 0x0064E240 File Offset: 0x0064C440
		public static Offset<ICenterTextShowType> CreateICenterTextShowType(FlatBufferBuilder builder, ECenterTextShowAnim Type = ECenterTextShowAnim.ShowAll)
		{
			builder.StartTable(1);
			ICenterTextShowType.AddType(builder, Type);
			return ICenterTextShowType.EndICenterTextShowType(builder);
		}

		// Token: 0x0602E24E RID: 189006 RVA: 0x0064E256 File Offset: 0x0064C456
		public static void StartICenterTextShowType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E24F RID: 189007 RVA: 0x0064E25F File Offset: 0x0064C45F
		public static void AddType(FlatBufferBuilder builder, ECenterTextShowAnim type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E250 RID: 189008 RVA: 0x0064E26A File Offset: 0x0064C46A
		public static Offset<ICenterTextShowType> EndICenterTextShowType(FlatBufferBuilder builder)
		{
			return new Offset<ICenterTextShowType>(builder.EndTable());
		}

		// Token: 0x0602E251 RID: 189009 RVA: 0x0064E278 File Offset: 0x0064C478
		public ICenterTextShowTypeT UnPack()
		{
			ICenterTextShowTypeT centerTextShowTypeT = new ICenterTextShowTypeT();
			this.UnPackTo(centerTextShowTypeT);
			return centerTextShowTypeT;
		}

		// Token: 0x0602E252 RID: 189010 RVA: 0x0064E293 File Offset: 0x0064C493
		public void UnPackTo(ICenterTextShowTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E253 RID: 189011 RVA: 0x0064E2A4 File Offset: 0x0064C4A4
		public static Offset<ICenterTextShowType> Pack(FlatBufferBuilder builder, ICenterTextShowTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICenterTextShowType>);
			}
			return ICenterTextShowType.CreateICenterTextShowType(builder, _o.Type);
		}

		// Token: 0x04011672 RID: 71282
		private Table __p;
	}
}
