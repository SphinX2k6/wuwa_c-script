using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DCF RID: 3535
	public struct GamePlayInformationGroup : IFlatbufferObject
	{
		// Token: 0x1700157A RID: 5498
		// (get) Token: 0x06007F44 RID: 32580 RVA: 0x002671B2 File Offset: 0x002653B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007F45 RID: 32581 RVA: 0x002671BF File Offset: 0x002653BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007F46 RID: 32582 RVA: 0x002671C8 File Offset: 0x002653C8
		public static GamePlayInformationGroup GetRootAsGamePlayInformationGroup(ByteBuffer _bb)
		{
			return GamePlayInformationGroup.GetRootAsGamePlayInformationGroup(_bb, default(GamePlayInformationGroup));
		}

		// Token: 0x06007F47 RID: 32583 RVA: 0x002671E4 File Offset: 0x002653E4
		public static GamePlayInformationGroup GetRootAsGamePlayInformationGroup(ByteBuffer _bb, GamePlayInformationGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007F48 RID: 32584 RVA: 0x00267201 File Offset: 0x00265401
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007F49 RID: 32585 RVA: 0x00267210 File Offset: 0x00265410
		public GamePlayInformationGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x06007F4A RID: 32586 RVA: 0x00267220 File Offset: 0x00265420
		public int Id
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

		// Token: 0x06007F4B RID: 32587 RVA: 0x0026725C File Offset: 0x0026545C
		public int InfoGroup(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700157C RID: 5500
		// (get) Token: 0x06007F4C RID: 32588 RVA: 0x0026729C File Offset: 0x0026549C
		public int InfoGroupLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007F4D RID: 32589 RVA: 0x002672C7 File Offset: 0x002654C7
		public Span<int> GetInfoGroupBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06007F4E RID: 32590 RVA: 0x002672D6 File Offset: 0x002654D6
		public int[] GetInfoGroupArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x1700157D RID: 5501
		// (get) Token: 0x06007F4F RID: 32591 RVA: 0x002672F0 File Offset: 0x002654F0
		public string IconString
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007F50 RID: 32592 RVA: 0x00267327 File Offset: 0x00265527
		public Span<byte> GetIconStringBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007F51 RID: 32593 RVA: 0x00267336 File Offset: 0x00265536
		public byte[] GetIconStringArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06007F52 RID: 32594 RVA: 0x0026734D File Offset: 0x0026554D
		[NullableContext(1)]
		public int[] InfoGroup()
		{
			return this.GetInfoGroupArray();
		}

		// Token: 0x06007F53 RID: 32595 RVA: 0x00267355 File Offset: 0x00265555
		[NullableContext(1)]
		public IEnumerable<int> InfoGroupIter()
		{
			GamePlayInformationGroup.<InfoGroupIter>d__20 <InfoGroupIter>d__ = new GamePlayInformationGroup.<InfoGroupIter>d__20(-2);
			<InfoGroupIter>d__.<>3__<>4__this = this;
			return <InfoGroupIter>d__;
		}

		// Token: 0x04005340 RID: 21312
		private Table __p;
	}
}
