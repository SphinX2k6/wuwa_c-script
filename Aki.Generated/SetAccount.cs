using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001192 RID: 4498
	public struct SetAccount : IFlatbufferObject
	{
		// Token: 0x17003635 RID: 13877
		// (get) Token: 0x0600D808 RID: 55304 RVA: 0x0032AA21 File Offset: 0x00328C21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D809 RID: 55305 RVA: 0x0032AA2E File Offset: 0x00328C2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D80A RID: 55306 RVA: 0x0032AA38 File Offset: 0x00328C38
		public static SetAccount GetRootAsSetAccount(ByteBuffer _bb)
		{
			return SetAccount.GetRootAsSetAccount(_bb, default(SetAccount));
		}

		// Token: 0x0600D80B RID: 55307 RVA: 0x0032AA54 File Offset: 0x00328C54
		public static SetAccount GetRootAsSetAccount(ByteBuffer _bb, SetAccount obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D80C RID: 55308 RVA: 0x0032AA71 File Offset: 0x00328C71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D80D RID: 55309 RVA: 0x0032AA80 File Offset: 0x00328C80
		public SetAccount __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003636 RID: 13878
		// (get) Token: 0x0600D80E RID: 55310 RVA: 0x0032AA90 File Offset: 0x00328C90
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

		// Token: 0x17003637 RID: 13879
		// (get) Token: 0x0600D80F RID: 55311 RVA: 0x0032AACC File Offset: 0x00328CCC
		public int PackageType
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

		// Token: 0x0600D810 RID: 55312 RVA: 0x0032AB08 File Offset: 0x00328D08
		public string Language(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003638 RID: 13880
		// (get) Token: 0x0600D811 RID: 55313 RVA: 0x0032AB44 File Offset: 0x00328D44
		public int LanguageLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D812 RID: 55314 RVA: 0x0032AB70 File Offset: 0x00328D70
		public string PackageId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003639 RID: 13881
		// (get) Token: 0x0600D813 RID: 55315 RVA: 0x0032ABAC File Offset: 0x00328DAC
		public int PackageIdLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D814 RID: 55316 RVA: 0x0032ABD8 File Offset: 0x00328DD8
		public int Channel(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700363A RID: 13882
		// (get) Token: 0x0600D815 RID: 55317 RVA: 0x0032AC18 File Offset: 0x00328E18
		public int ChannelLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D816 RID: 55318 RVA: 0x0032AC44 File Offset: 0x00328E44
		public Span<int> GetChannelBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600D817 RID: 55319 RVA: 0x0032AC54 File Offset: 0x00328E54
		public int[] GetChannelArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x1700363B RID: 13883
		// (get) Token: 0x0600D818 RID: 55320 RVA: 0x0032AC6C File Offset: 0x00328E6C
		public string Adress
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D819 RID: 55321 RVA: 0x0032ACA4 File Offset: 0x00328EA4
		public Span<byte> GetAdressBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D81A RID: 55322 RVA: 0x0032ACB4 File Offset: 0x00328EB4
		public byte[] GetAdressArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D81B RID: 55323 RVA: 0x0032ACCC File Offset: 0x00328ECC
		[NullableContext(1)]
		public int[] Channel()
		{
			return this.GetChannelArray();
		}

		// Token: 0x0600D81C RID: 55324 RVA: 0x0032ACD4 File Offset: 0x00328ED4
		[NullableContext(1)]
		public IEnumerable<int> ChannelIter()
		{
			SetAccount.<ChannelIter>d__28 <ChannelIter>d__ = new SetAccount.<ChannelIter>d__28(-2);
			<ChannelIter>d__.<>3__<>4__this = this;
			return <ChannelIter>d__;
		}

		// Token: 0x0600D81D RID: 55325 RVA: 0x0032ACE9 File Offset: 0x00328EE9
		[NullableContext(1)]
		public string[] Language()
		{
			return this.LanguageIter().ToArray<string>();
		}

		// Token: 0x0600D81E RID: 55326 RVA: 0x0032ACF6 File Offset: 0x00328EF6
		[NullableContext(1)]
		public IEnumerable<string> LanguageIter()
		{
			SetAccount.<LanguageIter>d__30 <LanguageIter>d__ = new SetAccount.<LanguageIter>d__30(-2);
			<LanguageIter>d__.<>3__<>4__this = this;
			return <LanguageIter>d__;
		}

		// Token: 0x0600D81F RID: 55327 RVA: 0x0032AD0B File Offset: 0x00328F0B
		[NullableContext(1)]
		public string[] PackageId()
		{
			return this.PackageIdIter().ToArray<string>();
		}

		// Token: 0x0600D820 RID: 55328 RVA: 0x0032AD18 File Offset: 0x00328F18
		[NullableContext(1)]
		public IEnumerable<string> PackageIdIter()
		{
			SetAccount.<PackageIdIter>d__32 <PackageIdIter>d__ = new SetAccount.<PackageIdIter>d__32(-2);
			<PackageIdIter>d__.<>3__<>4__this = this;
			return <PackageIdIter>d__;
		}

		// Token: 0x040057A3 RID: 22435
		private Table __p;
	}
}
