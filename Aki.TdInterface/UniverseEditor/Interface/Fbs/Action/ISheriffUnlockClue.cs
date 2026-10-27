using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070CA RID: 28874
	public struct ISheriffUnlockClue : IFlatbufferObject
	{
		// Token: 0x1700D67D RID: 54909
		// (get) Token: 0x06033240 RID: 209472 RVA: 0x006E54EE File Offset: 0x006E36EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033241 RID: 209473 RVA: 0x006E54FB File Offset: 0x006E36FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033242 RID: 209474 RVA: 0x006E5504 File Offset: 0x006E3704
		public static ISheriffUnlockClue GetRootAsISheriffUnlockClue(ByteBuffer _bb)
		{
			return ISheriffUnlockClue.GetRootAsISheriffUnlockClue(_bb, default(ISheriffUnlockClue));
		}

		// Token: 0x06033243 RID: 209475 RVA: 0x006E5520 File Offset: 0x006E3720
		public static ISheriffUnlockClue GetRootAsISheriffUnlockClue(ByteBuffer _bb, ISheriffUnlockClue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033244 RID: 209476 RVA: 0x006E553D File Offset: 0x006E373D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033245 RID: 209477 RVA: 0x006E554C File Offset: 0x006E374C
		public ISheriffUnlockClue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D67E RID: 54910
		// (get) Token: 0x06033246 RID: 209478 RVA: 0x006E555C File Offset: 0x006E375C
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

		// Token: 0x06033247 RID: 209479 RVA: 0x006E5598 File Offset: 0x006E3798
		public static Offset<ISheriffUnlockClue> CreateISheriffUnlockClue(FlatBufferBuilder builder, int ClueId = 0)
		{
			builder.StartTable(1);
			ISheriffUnlockClue.AddClueId(builder, ClueId);
			return ISheriffUnlockClue.EndISheriffUnlockClue(builder);
		}

		// Token: 0x06033248 RID: 209480 RVA: 0x006E55AE File Offset: 0x006E37AE
		public static void StartISheriffUnlockClue(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033249 RID: 209481 RVA: 0x006E55B7 File Offset: 0x006E37B7
		public static void AddClueId(FlatBufferBuilder builder, int clueId)
		{
			builder.AddInt(0, clueId, 0);
		}

		// Token: 0x0603324A RID: 209482 RVA: 0x006E55C2 File Offset: 0x006E37C2
		public static Offset<ISheriffUnlockClue> EndISheriffUnlockClue(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffUnlockClue>(builder.EndTable());
		}

		// Token: 0x0603324B RID: 209483 RVA: 0x006E55D0 File Offset: 0x006E37D0
		public ISheriffUnlockClueT UnPack()
		{
			ISheriffUnlockClueT sheriffUnlockClueT = new ISheriffUnlockClueT();
			this.UnPackTo(sheriffUnlockClueT);
			return sheriffUnlockClueT;
		}

		// Token: 0x0603324C RID: 209484 RVA: 0x006E55EB File Offset: 0x006E37EB
		public void UnPackTo(ISheriffUnlockClueT _o)
		{
			_o.ClueId = this.ClueId;
		}

		// Token: 0x0603324D RID: 209485 RVA: 0x006E55FC File Offset: 0x006E37FC
		public static Offset<ISheriffUnlockClue> Pack(FlatBufferBuilder builder, ISheriffUnlockClueT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffUnlockClue>);
			}
			return ISheriffUnlockClue.CreateISheriffUnlockClue(builder, _o.ClueId);
		}

		// Token: 0x04011B39 RID: 72505
		private Table __p;
	}
}
