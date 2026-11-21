using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007234 RID: 29236
	public struct IMontageId : IFlatbufferObject
	{
		// Token: 0x1700D621 RID: 54817
		// (get) Token: 0x06032E50 RID: 208464 RVA: 0x006DF2DB File Offset: 0x006DD4DB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032E51 RID: 208465 RVA: 0x006DF2E8 File Offset: 0x006DD4E8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032E52 RID: 208466 RVA: 0x006DF2F0 File Offset: 0x006DD4F0
		public static IMontageId GetRootAsIMontageId(ByteBuffer _bb)
		{
			return IMontageId.GetRootAsIMontageId(_bb, default(IMontageId));
		}

		// Token: 0x06032E53 RID: 208467 RVA: 0x006DF30C File Offset: 0x006DD50C
		public static IMontageId GetRootAsIMontageId(ByteBuffer _bb, IMontageId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032E54 RID: 208468 RVA: 0x006DF329 File Offset: 0x006DD529
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032E55 RID: 208469 RVA: 0x006DF338 File Offset: 0x006DD538
		public IMontageId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D622 RID: 54818
		// (get) Token: 0x06032E56 RID: 208470 RVA: 0x006DF348 File Offset: 0x006DD548
		public int MontageId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D623 RID: 54819
		// (get) Token: 0x06032E57 RID: 208471 RVA: 0x006DF384 File Offset: 0x006DD584
		public bool IsAbp
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D624 RID: 54820
		// (get) Token: 0x06032E58 RID: 208472 RVA: 0x006DF3C4 File Offset: 0x006DD5C4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032E59 RID: 208473 RVA: 0x006DF400 File Offset: 0x006DD600
		public static Offset<IMontageId> CreateIMontageId(FlatBufferBuilder builder, int MontageId = 0, bool IsAbp = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IMontageId.AddMontageId(builder, MontageId);
			IMontageId.AddNullMask(builder, NullMask);
			IMontageId.AddIsAbp(builder, IsAbp);
			return IMontageId.EndIMontageId(builder);
		}

		// Token: 0x06032E5A RID: 208474 RVA: 0x006DF424 File Offset: 0x006DD624
		public static void StartIMontageId(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06032E5B RID: 208475 RVA: 0x006DF42D File Offset: 0x006DD62D
		public static void AddMontageId(FlatBufferBuilder builder, int montageId)
		{
			builder.AddInt(0, montageId, 0);
		}

		// Token: 0x06032E5C RID: 208476 RVA: 0x006DF438 File Offset: 0x006DD638
		public static void AddIsAbp(FlatBufferBuilder builder, bool isAbp)
		{
			builder.AddBool(1, isAbp, false);
		}

		// Token: 0x06032E5D RID: 208477 RVA: 0x006DF443 File Offset: 0x006DD643
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06032E5E RID: 208478 RVA: 0x006DF44E File Offset: 0x006DD64E
		public static Offset<IMontageId> EndIMontageId(FlatBufferBuilder builder)
		{
			return new Offset<IMontageId>(builder.EndTable());
		}

		// Token: 0x06032E5F RID: 208479 RVA: 0x006DF45C File Offset: 0x006DD65C
		public IMontageIdT UnPack()
		{
			IMontageIdT montageIdT = new IMontageIdT();
			this.UnPackTo(montageIdT);
			return montageIdT;
		}

		// Token: 0x06032E60 RID: 208480 RVA: 0x006DF477 File Offset: 0x006DD677
		public void UnPackTo(IMontageIdT _o)
		{
			_o.MontageId = this.MontageId;
			_o.IsAbp = this.IsAbp;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032E61 RID: 208481 RVA: 0x006DF4A0 File Offset: 0x006DD6A0
		public static Offset<IMontageId> Pack(FlatBufferBuilder builder, IMontageIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMontageId>);
			}
			return IMontageId.CreateIMontageId(builder, _o.MontageId, _o.IsAbp, _o.NullMask);
		}

		// Token: 0x0401227D RID: 74365
		private Table __p;
	}
}
