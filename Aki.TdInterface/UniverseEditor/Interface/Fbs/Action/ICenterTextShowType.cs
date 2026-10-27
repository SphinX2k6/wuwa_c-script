using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062BA RID: 25274
	public struct ICenterTextShowType : IFlatbufferObject
	{
		// Token: 0x1700BCB1 RID: 48305
		// (get) Token: 0x0602BADD RID: 178909 RVA: 0x00603189 File Offset: 0x00601389
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BADE RID: 178910 RVA: 0x00603196 File Offset: 0x00601396
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BADF RID: 178911 RVA: 0x006031A0 File Offset: 0x006013A0
		public static ICenterTextShowType GetRootAsICenterTextShowType(ByteBuffer _bb)
		{
			return ICenterTextShowType.GetRootAsICenterTextShowType(_bb, default(ICenterTextShowType));
		}

		// Token: 0x0602BAE0 RID: 178912 RVA: 0x006031BC File Offset: 0x006013BC
		public static ICenterTextShowType GetRootAsICenterTextShowType(ByteBuffer _bb, ICenterTextShowType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BAE1 RID: 178913 RVA: 0x006031D9 File Offset: 0x006013D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BAE2 RID: 178914 RVA: 0x006031E8 File Offset: 0x006013E8
		public ICenterTextShowType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCB2 RID: 48306
		// (get) Token: 0x0602BAE3 RID: 178915 RVA: 0x006031F8 File Offset: 0x006013F8
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

		// Token: 0x0602BAE4 RID: 178916 RVA: 0x00603234 File Offset: 0x00601434
		public static Offset<ICenterTextShowType> CreateICenterTextShowType(FlatBufferBuilder builder, ECenterTextShowAnim Type = ECenterTextShowAnim.ShowAll)
		{
			builder.StartTable(1);
			ICenterTextShowType.AddType(builder, Type);
			return ICenterTextShowType.EndICenterTextShowType(builder);
		}

		// Token: 0x0602BAE5 RID: 178917 RVA: 0x0060324A File Offset: 0x0060144A
		public static void StartICenterTextShowType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BAE6 RID: 178918 RVA: 0x00603253 File Offset: 0x00601453
		public static void AddType(FlatBufferBuilder builder, ECenterTextShowAnim type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BAE7 RID: 178919 RVA: 0x0060325E File Offset: 0x0060145E
		public static Offset<ICenterTextShowType> EndICenterTextShowType(FlatBufferBuilder builder)
		{
			return new Offset<ICenterTextShowType>(builder.EndTable());
		}

		// Token: 0x0602BAE8 RID: 178920 RVA: 0x0060326C File Offset: 0x0060146C
		public ICenterTextShowTypeT UnPack()
		{
			ICenterTextShowTypeT centerTextShowTypeT = new ICenterTextShowTypeT();
			this.UnPackTo(centerTextShowTypeT);
			return centerTextShowTypeT;
		}

		// Token: 0x0602BAE9 RID: 178921 RVA: 0x00603287 File Offset: 0x00601487
		public void UnPackTo(ICenterTextShowTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602BAEA RID: 178922 RVA: 0x00603298 File Offset: 0x00601498
		public static Offset<ICenterTextShowType> Pack(FlatBufferBuilder builder, ICenterTextShowTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICenterTextShowType>);
			}
			return ICenterTextShowType.CreateICenterTextShowType(builder, _o.Type);
		}

		// Token: 0x0401085C RID: 67676
		private Table __p;
	}
}
