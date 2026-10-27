using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F35 RID: 3893
	public struct PinballRank : IFlatbufferObject
	{
		// Token: 0x170029AA RID: 10666
		// (get) Token: 0x0600AFE0 RID: 45024 RVA: 0x002C3DC9 File Offset: 0x002C1FC9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AFE1 RID: 45025 RVA: 0x002C3DD6 File Offset: 0x002C1FD6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AFE2 RID: 45026 RVA: 0x002C3DE0 File Offset: 0x002C1FE0
		public static PinballRank GetRootAsPinballRank(ByteBuffer _bb)
		{
			return PinballRank.GetRootAsPinballRank(_bb, default(PinballRank));
		}

		// Token: 0x0600AFE3 RID: 45027 RVA: 0x002C3DFC File Offset: 0x002C1FFC
		public static PinballRank GetRootAsPinballRank(ByteBuffer _bb, PinballRank obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AFE4 RID: 45028 RVA: 0x002C3E19 File Offset: 0x002C2019
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AFE5 RID: 45029 RVA: 0x002C3E28 File Offset: 0x002C2028
		public PinballRank __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170029AB RID: 10667
		// (get) Token: 0x0600AFE6 RID: 45030 RVA: 0x002C3E38 File Offset: 0x002C2038
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

		// Token: 0x170029AC RID: 10668
		// (get) Token: 0x0600AFE7 RID: 45031 RVA: 0x002C3E74 File Offset: 0x002C2074
		public int Tower
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

		// Token: 0x170029AD RID: 10669
		// (get) Token: 0x0600AFE8 RID: 45032 RVA: 0x002C3EB0 File Offset: 0x002C20B0
		public int PassTime
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

		// Token: 0x170029AE RID: 10670
		// (get) Token: 0x0600AFE9 RID: 45033 RVA: 0x002C3EEC File Offset: 0x002C20EC
		public int DisplayThreshold
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170029AF RID: 10671
		// (get) Token: 0x0600AFEA RID: 45034 RVA: 0x002C3F2C File Offset: 0x002C212C
		public string PlayerName
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

		// Token: 0x0600AFEB RID: 45035 RVA: 0x002C3F64 File Offset: 0x002C2164
		public Span<byte> GetPlayerNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600AFEC RID: 45036 RVA: 0x002C3F74 File Offset: 0x002C2174
		public byte[] GetPlayerNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AFED RID: 45037 RVA: 0x002C3F8C File Offset: 0x002C218C
		public string RoleList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170029B0 RID: 10672
		// (get) Token: 0x0600AFEE RID: 45038 RVA: 0x002C3FC8 File Offset: 0x002C21C8
		public int RoleListLength
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

		// Token: 0x0600AFEF RID: 45039 RVA: 0x002C3FF4 File Offset: 0x002C21F4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RoleListIter()或GetRoleListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] RoleList()
		{
			return this.RoleListIter().ToArray<string>();
		}

		// Token: 0x0600AFF0 RID: 45040 RVA: 0x002C4001 File Offset: 0x002C2201
		[NullableContext(1)]
		public readonly IEnumerable<string> RoleListIter()
		{
			PinballRank.<RoleListIter>d__24 <RoleListIter>d__ = new PinballRank.<RoleListIter>d__24(-2);
			<RoleListIter>d__.<>3__<>4__this = this;
			return <RoleListIter>d__;
		}

		// Token: 0x04004FFF RID: 20479
		private Table __p;
	}
}
