using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070CD RID: 28877
	public struct ISheriffUnlockEnding : IFlatbufferObject
	{
		// Token: 0x1700D680 RID: 54912
		// (get) Token: 0x06033252 RID: 209490 RVA: 0x006E5665 File Offset: 0x006E3865
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033253 RID: 209491 RVA: 0x006E5672 File Offset: 0x006E3872
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033254 RID: 209492 RVA: 0x006E567C File Offset: 0x006E387C
		public static ISheriffUnlockEnding GetRootAsISheriffUnlockEnding(ByteBuffer _bb)
		{
			return ISheriffUnlockEnding.GetRootAsISheriffUnlockEnding(_bb, default(ISheriffUnlockEnding));
		}

		// Token: 0x06033255 RID: 209493 RVA: 0x006E5698 File Offset: 0x006E3898
		public static ISheriffUnlockEnding GetRootAsISheriffUnlockEnding(ByteBuffer _bb, ISheriffUnlockEnding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033256 RID: 209494 RVA: 0x006E56B5 File Offset: 0x006E38B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033257 RID: 209495 RVA: 0x006E56C4 File Offset: 0x006E38C4
		public ISheriffUnlockEnding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D681 RID: 54913
		// (get) Token: 0x06033258 RID: 209496 RVA: 0x006E56D4 File Offset: 0x006E38D4
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

		// Token: 0x06033259 RID: 209497 RVA: 0x006E5710 File Offset: 0x006E3910
		public static Offset<ISheriffUnlockEnding> CreateISheriffUnlockEnding(FlatBufferBuilder builder, int EndingId = 0)
		{
			builder.StartTable(1);
			ISheriffUnlockEnding.AddEndingId(builder, EndingId);
			return ISheriffUnlockEnding.EndISheriffUnlockEnding(builder);
		}

		// Token: 0x0603325A RID: 209498 RVA: 0x006E5726 File Offset: 0x006E3926
		public static void StartISheriffUnlockEnding(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603325B RID: 209499 RVA: 0x006E572F File Offset: 0x006E392F
		public static void AddEndingId(FlatBufferBuilder builder, int endingId)
		{
			builder.AddInt(0, endingId, 0);
		}

		// Token: 0x0603325C RID: 209500 RVA: 0x006E573A File Offset: 0x006E393A
		public static Offset<ISheriffUnlockEnding> EndISheriffUnlockEnding(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffUnlockEnding>(builder.EndTable());
		}

		// Token: 0x0603325D RID: 209501 RVA: 0x006E5748 File Offset: 0x006E3948
		public ISheriffUnlockEndingT UnPack()
		{
			ISheriffUnlockEndingT sheriffUnlockEndingT = new ISheriffUnlockEndingT();
			this.UnPackTo(sheriffUnlockEndingT);
			return sheriffUnlockEndingT;
		}

		// Token: 0x0603325E RID: 209502 RVA: 0x006E5763 File Offset: 0x006E3963
		public void UnPackTo(ISheriffUnlockEndingT _o)
		{
			_o.EndingId = this.EndingId;
		}

		// Token: 0x0603325F RID: 209503 RVA: 0x006E5774 File Offset: 0x006E3974
		public static Offset<ISheriffUnlockEnding> Pack(FlatBufferBuilder builder, ISheriffUnlockEndingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffUnlockEnding>);
			}
			return ISheriffUnlockEnding.CreateISheriffUnlockEnding(builder, _o.EndingId);
		}

		// Token: 0x04011B3B RID: 72507
		private Table __p;
	}
}
