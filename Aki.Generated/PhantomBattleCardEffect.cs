using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FA6 RID: 4006
	public struct PhantomBattleCardEffect : IFlatbufferObject
	{
		// Token: 0x170025F6 RID: 9718
		// (get) Token: 0x0600AB67 RID: 43879 RVA: 0x002C8FEC File Offset: 0x002C71EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AB68 RID: 43880 RVA: 0x002C8FF9 File Offset: 0x002C71F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AB69 RID: 43881 RVA: 0x002C9000 File Offset: 0x002C7200
		public static PhantomBattleCardEffect GetRootAsPhantomBattleCardEffect(ByteBuffer _bb)
		{
			return PhantomBattleCardEffect.GetRootAsPhantomBattleCardEffect(_bb, default(PhantomBattleCardEffect));
		}

		// Token: 0x0600AB6A RID: 43882 RVA: 0x002C901C File Offset: 0x002C721C
		public static PhantomBattleCardEffect GetRootAsPhantomBattleCardEffect(ByteBuffer _bb, PhantomBattleCardEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AB6B RID: 43883 RVA: 0x002C9039 File Offset: 0x002C7239
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AB6C RID: 43884 RVA: 0x002C9048 File Offset: 0x002C7248
		public PhantomBattleCardEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170025F7 RID: 9719
		// (get) Token: 0x0600AB6D RID: 43885 RVA: 0x002C9058 File Offset: 0x002C7258
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

		// Token: 0x170025F8 RID: 9720
		// (get) Token: 0x0600AB6E RID: 43886 RVA: 0x002C9094 File Offset: 0x002C7294
		public string BaseColor
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AB6F RID: 43887 RVA: 0x002C90CB File Offset: 0x002C72CB
		public Span<byte> GetBaseColorBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600AB70 RID: 43888 RVA: 0x002C90DA File Offset: 0x002C72DA
		public byte[] GetBaseColorArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170025F9 RID: 9721
		// (get) Token: 0x0600AB71 RID: 43889 RVA: 0x002C90F4 File Offset: 0x002C72F4
		public string BackGroundColor
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

		// Token: 0x0600AB72 RID: 43890 RVA: 0x002C912B File Offset: 0x002C732B
		public Span<byte> GetBackGroundColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AB73 RID: 43891 RVA: 0x002C913A File Offset: 0x002C733A
		public byte[] GetBackGroundColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170025FA RID: 9722
		// (get) Token: 0x0600AB74 RID: 43892 RVA: 0x002C9154 File Offset: 0x002C7354
		public string FieldIcon
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

		// Token: 0x0600AB75 RID: 43893 RVA: 0x002C918C File Offset: 0x002C738C
		public Span<byte> GetFieldIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600AB76 RID: 43894 RVA: 0x002C919C File Offset: 0x002C739C
		public byte[] GetFieldIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170025FB RID: 9723
		// (get) Token: 0x0600AB77 RID: 43895 RVA: 0x002C91B4 File Offset: 0x002C73B4
		public string FieldRing
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

		// Token: 0x0600AB78 RID: 43896 RVA: 0x002C91EC File Offset: 0x002C73EC
		public Span<byte> GetFieldRingBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600AB79 RID: 43897 RVA: 0x002C91FC File Offset: 0x002C73FC
		public byte[] GetFieldRingArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170025FC RID: 9724
		// (get) Token: 0x0600AB7A RID: 43898 RVA: 0x002C9214 File Offset: 0x002C7414
		public string FieldActivateIcon
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

		// Token: 0x0600AB7B RID: 43899 RVA: 0x002C924C File Offset: 0x002C744C
		public Span<byte> GetFieldActivateIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600AB7C RID: 43900 RVA: 0x002C925C File Offset: 0x002C745C
		public byte[] GetFieldActivateIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170025FD RID: 9725
		// (get) Token: 0x0600AB7D RID: 43901 RVA: 0x002C9274 File Offset: 0x002C7474
		public string FieldActivateRing
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

		// Token: 0x0600AB7E RID: 43902 RVA: 0x002C92AC File Offset: 0x002C74AC
		public Span<byte> GetFieldActivateRingBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600AB7F RID: 43903 RVA: 0x002C92BC File Offset: 0x002C74BC
		public byte[] GetFieldActivateRingArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170025FE RID: 9726
		// (get) Token: 0x0600AB80 RID: 43904 RVA: 0x002C92D4 File Offset: 0x002C74D4
		public string FieldButtonColor
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AB81 RID: 43905 RVA: 0x002C930C File Offset: 0x002C750C
		public Span<byte> GetFieldButtonColorBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600AB82 RID: 43906 RVA: 0x002C931C File Offset: 0x002C751C
		public byte[] GetFieldButtonColorArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170025FF RID: 9727
		// (get) Token: 0x0600AB83 RID: 43907 RVA: 0x002C9334 File Offset: 0x002C7534
		public string FieldNorColor
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AB84 RID: 43908 RVA: 0x002C936C File Offset: 0x002C756C
		public Span<byte> GetFieldNorColorBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600AB85 RID: 43909 RVA: 0x002C937C File Offset: 0x002C757C
		public byte[] GetFieldNorColorArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002600 RID: 9728
		// (get) Token: 0x0600AB86 RID: 43910 RVA: 0x002C9394 File Offset: 0x002C7594
		public string FieldActivateColor
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AB87 RID: 43911 RVA: 0x002C93CC File Offset: 0x002C75CC
		public Span<byte> GetFieldActivateColorBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600AB88 RID: 43912 RVA: 0x002C93DC File Offset: 0x002C75DC
		public byte[] GetFieldActivateColorArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002601 RID: 9729
		// (get) Token: 0x0600AB89 RID: 43913 RVA: 0x002C93F4 File Offset: 0x002C75F4
		public string FieldLightColor
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AB8A RID: 43914 RVA: 0x002C942C File Offset: 0x002C762C
		public Span<byte> GetFieldLightColorBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600AB8B RID: 43915 RVA: 0x002C943C File Offset: 0x002C763C
		public byte[] GetFieldLightColorArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002602 RID: 9730
		// (get) Token: 0x0600AB8C RID: 43916 RVA: 0x002C9454 File Offset: 0x002C7654
		public string FieldReleaseColor
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AB8D RID: 43917 RVA: 0x002C948C File Offset: 0x002C768C
		public Span<byte> GetFieldReleaseColorBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600AB8E RID: 43918 RVA: 0x002C949C File Offset: 0x002C769C
		public byte[] GetFieldReleaseColorArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002603 RID: 9731
		// (get) Token: 0x0600AB8F RID: 43919 RVA: 0x002C94B4 File Offset: 0x002C76B4
		public string FieldSkillTexRelease
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AB90 RID: 43920 RVA: 0x002C94EC File Offset: 0x002C76EC
		public Span<byte> GetFieldSkillTexReleaseBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600AB91 RID: 43921 RVA: 0x002C94FC File Offset: 0x002C76FC
		public byte[] GetFieldSkillTexReleaseArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002604 RID: 9732
		// (get) Token: 0x0600AB92 RID: 43922 RVA: 0x002C9514 File Offset: 0x002C7714
		public string FieldSkillTexBg
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AB93 RID: 43923 RVA: 0x002C954C File Offset: 0x002C774C
		public Span<byte> GetFieldSkillTexBgBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600AB94 RID: 43924 RVA: 0x002C955C File Offset: 0x002C775C
		public byte[] GetFieldSkillTexBgArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17002605 RID: 9733
		// (get) Token: 0x0600AB95 RID: 43925 RVA: 0x002C9574 File Offset: 0x002C7774
		public string FieldSkillTexIcon
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AB96 RID: 43926 RVA: 0x002C95AC File Offset: 0x002C77AC
		public Span<byte> GetFieldSkillTexIconBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600AB97 RID: 43927 RVA: 0x002C95BC File Offset: 0x002C77BC
		public byte[] GetFieldSkillTexIconArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17002606 RID: 9734
		// (get) Token: 0x0600AB98 RID: 43928 RVA: 0x002C95D4 File Offset: 0x002C77D4
		public string FieldTexSmokeColor
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AB99 RID: 43929 RVA: 0x002C960C File Offset: 0x002C780C
		public Span<byte> GetFieldTexSmokeColorBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600AB9A RID: 43930 RVA: 0x002C961C File Offset: 0x002C781C
		public byte[] GetFieldTexSmokeColorArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x04005562 RID: 21858
		private Table __p;
	}
}
