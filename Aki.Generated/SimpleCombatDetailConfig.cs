using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011AE RID: 4526
	public struct SimpleCombatDetailConfig : IFlatbufferObject
	{
		// Token: 0x1700373B RID: 14139
		// (get) Token: 0x0600DAAB RID: 55979 RVA: 0x00330B82 File Offset: 0x0032ED82
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DAAC RID: 55980 RVA: 0x00330B8F File Offset: 0x0032ED8F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DAAD RID: 55981 RVA: 0x00330B98 File Offset: 0x0032ED98
		public static SimpleCombatDetailConfig GetRootAsSimpleCombatDetailConfig(ByteBuffer _bb)
		{
			return SimpleCombatDetailConfig.GetRootAsSimpleCombatDetailConfig(_bb, default(SimpleCombatDetailConfig));
		}

		// Token: 0x0600DAAE RID: 55982 RVA: 0x00330BB4 File Offset: 0x0032EDB4
		public static SimpleCombatDetailConfig GetRootAsSimpleCombatDetailConfig(ByteBuffer _bb, SimpleCombatDetailConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DAAF RID: 55983 RVA: 0x00330BD1 File Offset: 0x0032EDD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DAB0 RID: 55984 RVA: 0x00330BE0 File Offset: 0x0032EDE0
		public SimpleCombatDetailConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700373C RID: 14140
		// (get) Token: 0x0600DAB1 RID: 55985 RVA: 0x00330BF0 File Offset: 0x0032EDF0
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

		// Token: 0x1700373D RID: 14141
		// (get) Token: 0x0600DAB2 RID: 55986 RVA: 0x00330C2C File Offset: 0x0032EE2C
		public int SimpleCombatId
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

		// Token: 0x1700373E RID: 14142
		// (get) Token: 0x0600DAB3 RID: 55987 RVA: 0x00330C68 File Offset: 0x0032EE68
		public int SubTypeId
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

		// Token: 0x1700373F RID: 14143
		// (get) Token: 0x0600DAB4 RID: 55988 RVA: 0x00330CA4 File Offset: 0x0032EEA4
		public string PrefabPath
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

		// Token: 0x0600DAB5 RID: 55989 RVA: 0x00330CDC File Offset: 0x0032EEDC
		public Span<byte> GetPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DAB6 RID: 55990 RVA: 0x00330CEC File Offset: 0x0032EEEC
		public byte[] GetPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003740 RID: 14144
		// (get) Token: 0x0600DAB7 RID: 55991 RVA: 0x00330D04 File Offset: 0x0032EF04
		public string DaPath
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

		// Token: 0x0600DAB8 RID: 55992 RVA: 0x00330D3C File Offset: 0x0032EF3C
		public Span<byte> GetDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DAB9 RID: 55993 RVA: 0x00330D4C File Offset: 0x0032EF4C
		public byte[] GetDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003741 RID: 14145
		// (get) Token: 0x0600DABA RID: 55994 RVA: 0x00330D64 File Offset: 0x0032EF64
		public int PropertyId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040057C7 RID: 22471
		private Table __p;
	}
}
