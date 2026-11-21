using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F80 RID: 28544
	public struct IHeadStyleNormal : IFlatbufferObject
	{
		// Token: 0x1700D111 RID: 53521
		// (get) Token: 0x06031678 RID: 202360 RVA: 0x006B2F72 File Offset: 0x006B1172
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031679 RID: 202361 RVA: 0x006B2F7F File Offset: 0x006B117F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603167A RID: 202362 RVA: 0x006B2F88 File Offset: 0x006B1188
		public static IHeadStyleNormal GetRootAsIHeadStyleNormal(ByteBuffer _bb)
		{
			return IHeadStyleNormal.GetRootAsIHeadStyleNormal(_bb, default(IHeadStyleNormal));
		}

		// Token: 0x0603167B RID: 202363 RVA: 0x006B2FA4 File Offset: 0x006B11A4
		public static IHeadStyleNormal GetRootAsIHeadStyleNormal(ByteBuffer _bb, IHeadStyleNormal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603167C RID: 202364 RVA: 0x006B2FC1 File Offset: 0x006B11C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603167D RID: 202365 RVA: 0x006B2FD0 File Offset: 0x006B11D0
		public IHeadStyleNormal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D112 RID: 53522
		// (get) Token: 0x0603167E RID: 202366 RVA: 0x006B2FE0 File Offset: 0x006B11E0
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

		// Token: 0x1700D113 RID: 53523
		// (get) Token: 0x0603167F RID: 202367 RVA: 0x006B301C File Offset: 0x006B121C
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

		// Token: 0x06031680 RID: 202368 RVA: 0x006B3058 File Offset: 0x006B1258
		public static Offset<IHeadStyleNormal> CreateIHeadStyleNormal(FlatBufferBuilder builder, EHeadStyle Type = EHeadStyle.Normal, int WhoId = 0)
		{
			builder.StartTable(2);
			IHeadStyleNormal.AddWhoId(builder, WhoId);
			IHeadStyleNormal.AddType(builder, Type);
			return IHeadStyleNormal.EndIHeadStyleNormal(builder);
		}

		// Token: 0x06031681 RID: 202369 RVA: 0x006B3075 File Offset: 0x006B1275
		public static void StartIHeadStyleNormal(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031682 RID: 202370 RVA: 0x006B307E File Offset: 0x006B127E
		public static void AddType(FlatBufferBuilder builder, EHeadStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031683 RID: 202371 RVA: 0x006B3089 File Offset: 0x006B1289
		public static void AddWhoId(FlatBufferBuilder builder, int whoId)
		{
			builder.AddInt(1, whoId, 0);
		}

		// Token: 0x06031684 RID: 202372 RVA: 0x006B3094 File Offset: 0x006B1294
		public static Offset<IHeadStyleNormal> EndIHeadStyleNormal(FlatBufferBuilder builder)
		{
			return new Offset<IHeadStyleNormal>(builder.EndTable());
		}

		// Token: 0x06031685 RID: 202373 RVA: 0x006B30A4 File Offset: 0x006B12A4
		public IHeadStyleNormalT UnPack()
		{
			IHeadStyleNormalT headStyleNormalT = new IHeadStyleNormalT();
			this.UnPackTo(headStyleNormalT);
			return headStyleNormalT;
		}

		// Token: 0x06031686 RID: 202374 RVA: 0x006B30BF File Offset: 0x006B12BF
		public void UnPackTo(IHeadStyleNormalT _o)
		{
			_o.Type = this.Type;
			_o.WhoId = this.WhoId;
		}

		// Token: 0x06031687 RID: 202375 RVA: 0x006B30DC File Offset: 0x006B12DC
		public static Offset<IHeadStyleNormal> Pack(FlatBufferBuilder builder, IHeadStyleNormalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHeadStyleNormal>);
			}
			return IHeadStyleNormal.CreateIHeadStyleNormal(builder, _o.Type, _o.WhoId);
		}

		// Token: 0x04011E93 RID: 73363
		private Table __p;
	}
}
