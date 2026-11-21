using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001157 RID: 4439
	public struct RoleTowerStar : IFlatbufferObject
	{
		// Token: 0x17003462 RID: 13410
		// (get) Token: 0x0600D2E4 RID: 53988 RVA: 0x0031FA50 File Offset: 0x0031DC50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D2E5 RID: 53989 RVA: 0x0031FA5D File Offset: 0x0031DC5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D2E6 RID: 53990 RVA: 0x0031FA64 File Offset: 0x0031DC64
		public static RoleTowerStar GetRootAsRoleTowerStar(ByteBuffer _bb)
		{
			return RoleTowerStar.GetRootAsRoleTowerStar(_bb, default(RoleTowerStar));
		}

		// Token: 0x0600D2E7 RID: 53991 RVA: 0x0031FA80 File Offset: 0x0031DC80
		public static RoleTowerStar GetRootAsRoleTowerStar(ByteBuffer _bb, RoleTowerStar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D2E8 RID: 53992 RVA: 0x0031FA9D File Offset: 0x0031DC9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D2E9 RID: 53993 RVA: 0x0031FAAC File Offset: 0x0031DCAC
		public RoleTowerStar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003463 RID: 13411
		// (get) Token: 0x0600D2EA RID: 53994 RVA: 0x0031FABC File Offset: 0x0031DCBC
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

		// Token: 0x17003464 RID: 13412
		// (get) Token: 0x0600D2EB RID: 53995 RVA: 0x0031FAF8 File Offset: 0x0031DCF8
		public int GroupId
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

		// Token: 0x17003465 RID: 13413
		// (get) Token: 0x0600D2EC RID: 53996 RVA: 0x0031FB34 File Offset: 0x0031DD34
		public int StarIndex
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003466 RID: 13414
		// (get) Token: 0x0600D2ED RID: 53997 RVA: 0x0031FB70 File Offset: 0x0031DD70
		public string Name
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D2EE RID: 53998 RVA: 0x0031FBA8 File Offset: 0x0031DDA8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D2EF RID: 53999 RVA: 0x0031FBB8 File Offset: 0x0031DDB8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003467 RID: 13415
		// (get) Token: 0x0600D2F0 RID: 54000 RVA: 0x0031FBD0 File Offset: 0x0031DDD0
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D2F1 RID: 54001 RVA: 0x0031FC08 File Offset: 0x0031DE08
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D2F2 RID: 54002 RVA: 0x0031FC18 File Offset: 0x0031DE18
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D2F3 RID: 54003 RVA: 0x0031FC30 File Offset: 0x0031DE30
		public string DescParam(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003468 RID: 13416
		// (get) Token: 0x0600D2F4 RID: 54004 RVA: 0x0031FC6C File Offset: 0x0031DE6C
		public int DescParamLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003469 RID: 13417
		// (get) Token: 0x0600D2F5 RID: 54005 RVA: 0x0031FC98 File Offset: 0x0031DE98
		public string DetailDesc
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D2F6 RID: 54006 RVA: 0x0031FCD0 File Offset: 0x0031DED0
		public Span<byte> GetDetailDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D2F7 RID: 54007 RVA: 0x0031FCE0 File Offset: 0x0031DEE0
		public byte[] GetDetailDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D2F8 RID: 54008 RVA: 0x0031FCF8 File Offset: 0x0031DEF8
		public string DetailDescParam(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700346A RID: 13418
		// (get) Token: 0x0600D2F9 RID: 54009 RVA: 0x0031FD34 File Offset: 0x0031DF34
		public int DetailDescParamLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D2FA RID: 54010 RVA: 0x0031FD60 File Offset: 0x0031DF60
		[NullableContext(1)]
		public string[] DescParam()
		{
			return this.DescParamIter().ToArray<string>();
		}

		// Token: 0x0600D2FB RID: 54011 RVA: 0x0031FD6D File Offset: 0x0031DF6D
		[NullableContext(1)]
		public IEnumerable<string> DescParamIter()
		{
			RoleTowerStar.<DescParamIter>d__33 <DescParamIter>d__ = new RoleTowerStar.<DescParamIter>d__33(-2);
			<DescParamIter>d__.<>3__<>4__this = this;
			return <DescParamIter>d__;
		}

		// Token: 0x0600D2FC RID: 54012 RVA: 0x0031FD82 File Offset: 0x0031DF82
		[NullableContext(1)]
		public string[] DetailDescParam()
		{
			return this.DetailDescParamIter().ToArray<string>();
		}

		// Token: 0x0600D2FD RID: 54013 RVA: 0x0031FD8F File Offset: 0x0031DF8F
		[NullableContext(1)]
		public IEnumerable<string> DetailDescParamIter()
		{
			RoleTowerStar.<DetailDescParamIter>d__35 <DetailDescParamIter>d__ = new RoleTowerStar.<DetailDescParamIter>d__35(-2);
			<DetailDescParamIter>d__.<>3__<>4__this = this;
			return <DetailDescParamIter>d__;
		}

		// Token: 0x0400575F RID: 22367
		private Table __p;
	}
}
