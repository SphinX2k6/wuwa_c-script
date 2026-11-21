using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007899 RID: 30873
	public struct ISheriffUnlockEnding : IFlatbufferObject
	{
		// Token: 0x1700E263 RID: 57955
		// (get) Token: 0x060364F4 RID: 222452 RVA: 0x00745C71 File Offset: 0x00743E71
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060364F5 RID: 222453 RVA: 0x00745C7E File Offset: 0x00743E7E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060364F6 RID: 222454 RVA: 0x00745C88 File Offset: 0x00743E88
		public static ISheriffUnlockEnding GetRootAsISheriffUnlockEnding(ByteBuffer _bb)
		{
			return ISheriffUnlockEnding.GetRootAsISheriffUnlockEnding(_bb, default(ISheriffUnlockEnding));
		}

		// Token: 0x060364F7 RID: 222455 RVA: 0x00745CA4 File Offset: 0x00743EA4
		public static ISheriffUnlockEnding GetRootAsISheriffUnlockEnding(ByteBuffer _bb, ISheriffUnlockEnding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060364F8 RID: 222456 RVA: 0x00745CC1 File Offset: 0x00743EC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060364F9 RID: 222457 RVA: 0x00745CD0 File Offset: 0x00743ED0
		public ISheriffUnlockEnding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E264 RID: 57956
		// (get) Token: 0x060364FA RID: 222458 RVA: 0x00745CE0 File Offset: 0x00743EE0
		public int EndingId
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

		// Token: 0x060364FB RID: 222459 RVA: 0x00745D1C File Offset: 0x00743F1C
		public static Offset<ISheriffUnlockEnding> CreateISheriffUnlockEnding(FlatBufferBuilder builder, int EndingId = 0)
		{
			builder.StartTable(1);
			ISheriffUnlockEnding.AddEndingId(builder, EndingId);
			return ISheriffUnlockEnding.EndISheriffUnlockEnding(builder);
		}

		// Token: 0x060364FC RID: 222460 RVA: 0x00745D32 File Offset: 0x00743F32
		public static void StartISheriffUnlockEnding(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060364FD RID: 222461 RVA: 0x00745D3B File Offset: 0x00743F3B
		public static void AddEndingId(FlatBufferBuilder builder, int endingId)
		{
			builder.AddInt(0, endingId, 0);
		}

		// Token: 0x060364FE RID: 222462 RVA: 0x00745D46 File Offset: 0x00743F46
		public static Offset<ISheriffUnlockEnding> EndISheriffUnlockEnding(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffUnlockEnding>(builder.EndTable());
		}

		// Token: 0x060364FF RID: 222463 RVA: 0x00745D54 File Offset: 0x00743F54
		public ISheriffUnlockEndingT UnPack()
		{
			ISheriffUnlockEndingT sheriffUnlockEndingT = new ISheriffUnlockEndingT();
			this.UnPackTo(sheriffUnlockEndingT);
			return sheriffUnlockEndingT;
		}

		// Token: 0x06036500 RID: 222464 RVA: 0x00745D6F File Offset: 0x00743F6F
		public void UnPackTo(ISheriffUnlockEndingT _o)
		{
			_o.EndingId = this.EndingId;
		}

		// Token: 0x06036501 RID: 222465 RVA: 0x00745D80 File Offset: 0x00743F80
		public static Offset<ISheriffUnlockEnding> Pack(FlatBufferBuilder builder, ISheriffUnlockEndingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffUnlockEnding>);
			}
			return ISheriffUnlockEnding.CreateISheriffUnlockEnding(builder, _o.EndingId);
		}

		// Token: 0x04012B29 RID: 76585
		private Table __p;
	}
}
