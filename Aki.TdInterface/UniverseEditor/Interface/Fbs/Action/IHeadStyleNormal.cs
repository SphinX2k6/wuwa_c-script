using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068D0 RID: 26832
	public struct IHeadStyleNormal : IFlatbufferObject
	{
		// Token: 0x1700C717 RID: 50967
		// (get) Token: 0x0602ECC6 RID: 191686 RVA: 0x00662E2A File Offset: 0x0066102A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602ECC7 RID: 191687 RVA: 0x00662E37 File Offset: 0x00661037
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602ECC8 RID: 191688 RVA: 0x00662E40 File Offset: 0x00661040
		public static IHeadStyleNormal GetRootAsIHeadStyleNormal(ByteBuffer _bb)
		{
			return IHeadStyleNormal.GetRootAsIHeadStyleNormal(_bb, default(IHeadStyleNormal));
		}

		// Token: 0x0602ECC9 RID: 191689 RVA: 0x00662E5C File Offset: 0x0066105C
		public static IHeadStyleNormal GetRootAsIHeadStyleNormal(ByteBuffer _bb, IHeadStyleNormal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602ECCA RID: 191690 RVA: 0x00662E79 File Offset: 0x00661079
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602ECCB RID: 191691 RVA: 0x00662E88 File Offset: 0x00661088
		public IHeadStyleNormal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C718 RID: 50968
		// (get) Token: 0x0602ECCC RID: 191692 RVA: 0x00662E98 File Offset: 0x00661098
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

		// Token: 0x1700C719 RID: 50969
		// (get) Token: 0x0602ECCD RID: 191693 RVA: 0x00662ED4 File Offset: 0x006610D4
		public int WhoId
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

		// Token: 0x0602ECCE RID: 191694 RVA: 0x00662F10 File Offset: 0x00661110
		public static Offset<IHeadStyleNormal> CreateIHeadStyleNormal(FlatBufferBuilder builder, EHeadStyle Type = EHeadStyle.Normal, int WhoId = 0)
		{
			builder.StartTable(2);
			IHeadStyleNormal.AddWhoId(builder, WhoId);
			IHeadStyleNormal.AddType(builder, Type);
			return IHeadStyleNormal.EndIHeadStyleNormal(builder);
		}

		// Token: 0x0602ECCF RID: 191695 RVA: 0x00662F2D File Offset: 0x0066112D
		public static void StartIHeadStyleNormal(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602ECD0 RID: 191696 RVA: 0x00662F36 File Offset: 0x00661136
		public static void AddType(FlatBufferBuilder builder, EHeadStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602ECD1 RID: 191697 RVA: 0x00662F41 File Offset: 0x00661141
		public static void AddWhoId(FlatBufferBuilder builder, int whoId)
		{
			builder.AddInt(1, whoId, 0);
		}

		// Token: 0x0602ECD2 RID: 191698 RVA: 0x00662F4C File Offset: 0x0066114C
		public static Offset<IHeadStyleNormal> EndIHeadStyleNormal(FlatBufferBuilder builder)
		{
			return new Offset<IHeadStyleNormal>(builder.EndTable());
		}

		// Token: 0x0602ECD3 RID: 191699 RVA: 0x00662F5C File Offset: 0x0066115C
		public IHeadStyleNormalT UnPack()
		{
			IHeadStyleNormalT headStyleNormalT = new IHeadStyleNormalT();
			this.UnPackTo(headStyleNormalT);
			return headStyleNormalT;
		}

		// Token: 0x0602ECD4 RID: 191700 RVA: 0x00662F77 File Offset: 0x00661177
		public void UnPackTo(IHeadStyleNormalT _o)
		{
			_o.Type = this.Type;
			_o.WhoId = this.WhoId;
		}

		// Token: 0x0602ECD5 RID: 191701 RVA: 0x00662F94 File Offset: 0x00661194
		public static Offset<IHeadStyleNormal> Pack(FlatBufferBuilder builder, IHeadStyleNormalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHeadStyleNormal>);
			}
			return IHeadStyleNormal.CreateIHeadStyleNormal(builder, _o.Type, _o.WhoId);
		}

		// Token: 0x0401102C RID: 69676
		private Table __p;
	}
}
