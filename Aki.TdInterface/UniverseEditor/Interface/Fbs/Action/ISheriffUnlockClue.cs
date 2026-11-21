using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007896 RID: 30870
	public struct ISheriffUnlockClue : IFlatbufferObject
	{
		// Token: 0x1700E260 RID: 57952
		// (get) Token: 0x060364E2 RID: 222434 RVA: 0x00745AFA File Offset: 0x00743CFA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060364E3 RID: 222435 RVA: 0x00745B07 File Offset: 0x00743D07
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060364E4 RID: 222436 RVA: 0x00745B10 File Offset: 0x00743D10
		public static ISheriffUnlockClue GetRootAsISheriffUnlockClue(ByteBuffer _bb)
		{
			return ISheriffUnlockClue.GetRootAsISheriffUnlockClue(_bb, default(ISheriffUnlockClue));
		}

		// Token: 0x060364E5 RID: 222437 RVA: 0x00745B2C File Offset: 0x00743D2C
		public static ISheriffUnlockClue GetRootAsISheriffUnlockClue(ByteBuffer _bb, ISheriffUnlockClue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060364E6 RID: 222438 RVA: 0x00745B49 File Offset: 0x00743D49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060364E7 RID: 222439 RVA: 0x00745B58 File Offset: 0x00743D58
		public ISheriffUnlockClue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E261 RID: 57953
		// (get) Token: 0x060364E8 RID: 222440 RVA: 0x00745B68 File Offset: 0x00743D68
		public int ClueId
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

		// Token: 0x060364E9 RID: 222441 RVA: 0x00745BA4 File Offset: 0x00743DA4
		public static Offset<ISheriffUnlockClue> CreateISheriffUnlockClue(FlatBufferBuilder builder, int ClueId = 0)
		{
			builder.StartTable(1);
			ISheriffUnlockClue.AddClueId(builder, ClueId);
			return ISheriffUnlockClue.EndISheriffUnlockClue(builder);
		}

		// Token: 0x060364EA RID: 222442 RVA: 0x00745BBA File Offset: 0x00743DBA
		public static void StartISheriffUnlockClue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060364EB RID: 222443 RVA: 0x00745BC3 File Offset: 0x00743DC3
		public static void AddClueId(FlatBufferBuilder builder, int clueId)
		{
			builder.AddInt(0, clueId, 0);
		}

		// Token: 0x060364EC RID: 222444 RVA: 0x00745BCE File Offset: 0x00743DCE
		public static Offset<ISheriffUnlockClue> EndISheriffUnlockClue(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffUnlockClue>(builder.EndTable());
		}

		// Token: 0x060364ED RID: 222445 RVA: 0x00745BDC File Offset: 0x00743DDC
		public ISheriffUnlockClueT UnPack()
		{
			ISheriffUnlockClueT sheriffUnlockClueT = new ISheriffUnlockClueT();
			this.UnPackTo(sheriffUnlockClueT);
			return sheriffUnlockClueT;
		}

		// Token: 0x060364EE RID: 222446 RVA: 0x00745BF7 File Offset: 0x00743DF7
		public void UnPackTo(ISheriffUnlockClueT _o)
		{
			_o.ClueId = this.ClueId;
		}

		// Token: 0x060364EF RID: 222447 RVA: 0x00745C08 File Offset: 0x00743E08
		public static Offset<ISheriffUnlockClue> Pack(FlatBufferBuilder builder, ISheriffUnlockClueT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffUnlockClue>);
			}
			return ISheriffUnlockClue.CreateISheriffUnlockClue(builder, _o.ClueId);
		}

		// Token: 0x04012B27 RID: 76583
		private Table __p;
	}
}
