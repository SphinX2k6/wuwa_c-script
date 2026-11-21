using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005817 RID: 22551
	public struct IFollowTrackEndType : IFlatbufferObject
	{
		// Token: 0x1700A33F RID: 41791
		// (get) Token: 0x060247D9 RID: 149465 RVA: 0x0050398D File Offset: 0x00501B8D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060247DA RID: 149466 RVA: 0x0050399A File Offset: 0x00501B9A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060247DB RID: 149467 RVA: 0x005039A4 File Offset: 0x00501BA4
		public static IFollowTrackEndType GetRootAsIFollowTrackEndType(ByteBuffer _bb)
		{
			return IFollowTrackEndType.GetRootAsIFollowTrackEndType(_bb, default(IFollowTrackEndType));
		}

		// Token: 0x060247DC RID: 149468 RVA: 0x005039C0 File Offset: 0x00501BC0
		public static IFollowTrackEndType GetRootAsIFollowTrackEndType(ByteBuffer _bb, IFollowTrackEndType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060247DD RID: 149469 RVA: 0x005039DD File Offset: 0x00501BDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060247DE RID: 149470 RVA: 0x005039EC File Offset: 0x00501BEC
		public IFollowTrackEndType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A340 RID: 41792
		// (get) Token: 0x060247DF RID: 149471 RVA: 0x005039FC File Offset: 0x00501BFC
		public EFollowTrackEndType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFollowTrackEndType.ToStart;
				}
				return (EFollowTrackEndType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060247E0 RID: 149472 RVA: 0x00503A38 File Offset: 0x00501C38
		public static Offset<IFollowTrackEndType> CreateIFollowTrackEndType(FlatBufferBuilder builder, EFollowTrackEndType Type = EFollowTrackEndType.ToStart)
		{
			builder.StartTable(1);
			IFollowTrackEndType.AddType(builder, Type);
			return IFollowTrackEndType.EndIFollowTrackEndType(builder);
		}

		// Token: 0x060247E1 RID: 149473 RVA: 0x00503A4E File Offset: 0x00501C4E
		public static void StartIFollowTrackEndType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060247E2 RID: 149474 RVA: 0x00503A57 File Offset: 0x00501C57
		public static void AddType(FlatBufferBuilder builder, EFollowTrackEndType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060247E3 RID: 149475 RVA: 0x00503A62 File Offset: 0x00501C62
		public static Offset<IFollowTrackEndType> EndIFollowTrackEndType(FlatBufferBuilder builder)
		{
			return new Offset<IFollowTrackEndType>(builder.EndTable());
		}

		// Token: 0x060247E4 RID: 149476 RVA: 0x00503A70 File Offset: 0x00501C70
		public IFollowTrackEndTypeT UnPack()
		{
			IFollowTrackEndTypeT followTrackEndTypeT = new IFollowTrackEndTypeT();
			this.UnPackTo(followTrackEndTypeT);
			return followTrackEndTypeT;
		}

		// Token: 0x060247E5 RID: 149477 RVA: 0x00503A8B File Offset: 0x00501C8B
		public void UnPackTo(IFollowTrackEndTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060247E6 RID: 149478 RVA: 0x00503A9C File Offset: 0x00501C9C
		public static Offset<IFollowTrackEndType> Pack(FlatBufferBuilder builder, IFollowTrackEndTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowTrackEndType>);
			}
			return IFollowTrackEndType.CreateIFollowTrackEndType(builder, _o.Type);
		}

		// Token: 0x0400F035 RID: 61493
		private Table __p;
	}
}
