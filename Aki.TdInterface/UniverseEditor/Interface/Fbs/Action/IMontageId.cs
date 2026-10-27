using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AFD RID: 27389
	public struct IMontageId : IFlatbufferObject
	{
		// Token: 0x1700CB52 RID: 52050
		// (get) Token: 0x0603007C RID: 196732 RVA: 0x00687C23 File Offset: 0x00685E23
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603007D RID: 196733 RVA: 0x00687C30 File Offset: 0x00685E30
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603007E RID: 196734 RVA: 0x00687C38 File Offset: 0x00685E38
		public static IMontageId GetRootAsIMontageId(ByteBuffer _bb)
		{
			return IMontageId.GetRootAsIMontageId(_bb, default(IMontageId));
		}

		// Token: 0x0603007F RID: 196735 RVA: 0x00687C54 File Offset: 0x00685E54
		public static IMontageId GetRootAsIMontageId(ByteBuffer _bb, IMontageId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030080 RID: 196736 RVA: 0x00687C71 File Offset: 0x00685E71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030081 RID: 196737 RVA: 0x00687C80 File Offset: 0x00685E80
		public IMontageId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB53 RID: 52051
		// (get) Token: 0x06030082 RID: 196738 RVA: 0x00687C90 File Offset: 0x00685E90
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

		// Token: 0x1700CB54 RID: 52052
		// (get) Token: 0x06030083 RID: 196739 RVA: 0x00687CCC File Offset: 0x00685ECC
		public bool IsAbp
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB55 RID: 52053
		// (get) Token: 0x06030084 RID: 196740 RVA: 0x00687D0C File Offset: 0x00685F0C
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

		// Token: 0x06030085 RID: 196741 RVA: 0x00687D48 File Offset: 0x00685F48
		public static Offset<IMontageId> CreateIMontageId(FlatBufferBuilder builder, int MontageId = 0, bool IsAbp = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IMontageId.AddMontageId(builder, MontageId);
			IMontageId.AddNullMask(builder, NullMask);
			IMontageId.AddIsAbp(builder, IsAbp);
			return IMontageId.EndIMontageId(builder);
		}

		// Token: 0x06030086 RID: 196742 RVA: 0x00687D6C File Offset: 0x00685F6C
		public static void StartIMontageId(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06030087 RID: 196743 RVA: 0x00687D75 File Offset: 0x00685F75
		public static void AddMontageId(FlatBufferBuilder builder, int montageId)
		{
			builder.AddInt(0, montageId, 0);
		}

		// Token: 0x06030088 RID: 196744 RVA: 0x00687D80 File Offset: 0x00685F80
		public static void AddIsAbp(FlatBufferBuilder builder, bool isAbp)
		{
			builder.AddBool(1, isAbp, false);
		}

		// Token: 0x06030089 RID: 196745 RVA: 0x00687D8B File Offset: 0x00685F8B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0603008A RID: 196746 RVA: 0x00687D96 File Offset: 0x00685F96
		public static Offset<IMontageId> EndIMontageId(FlatBufferBuilder builder)
		{
			return new Offset<IMontageId>(builder.EndTable());
		}

		// Token: 0x0603008B RID: 196747 RVA: 0x00687DA4 File Offset: 0x00685FA4
		public IMontageIdT UnPack()
		{
			IMontageIdT montageIdT = new IMontageIdT();
			this.UnPackTo(montageIdT);
			return montageIdT;
		}

		// Token: 0x0603008C RID: 196748 RVA: 0x00687DBF File Offset: 0x00685FBF
		public void UnPackTo(IMontageIdT _o)
		{
			_o.MontageId = this.MontageId;
			_o.IsAbp = this.IsAbp;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603008D RID: 196749 RVA: 0x00687DE8 File Offset: 0x00685FE8
		public static Offset<IMontageId> Pack(FlatBufferBuilder builder, IMontageIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMontageId>);
			}
			return IMontageId.CreateIMontageId(builder, _o.MontageId, _o.IsAbp, _o.NullMask);
		}

		// Token: 0x0401136A RID: 70506
		private Table __p;
	}
}
