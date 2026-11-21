using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011B4 RID: 4532
	public struct SkillButtonEffect : IFlatbufferObject
	{
		// Token: 0x17003787 RID: 14215
		// (get) Token: 0x0600DB9F RID: 56223 RVA: 0x00332FF4 File Offset: 0x003311F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DBA0 RID: 56224 RVA: 0x00333001 File Offset: 0x00331201
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DBA1 RID: 56225 RVA: 0x00333008 File Offset: 0x00331208
		public static SkillButtonEffect GetRootAsSkillButtonEffect(ByteBuffer _bb)
		{
			return SkillButtonEffect.GetRootAsSkillButtonEffect(_bb, default(SkillButtonEffect));
		}

		// Token: 0x0600DBA2 RID: 56226 RVA: 0x00333024 File Offset: 0x00331224
		public static SkillButtonEffect GetRootAsSkillButtonEffect(ByteBuffer _bb, SkillButtonEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DBA3 RID: 56227 RVA: 0x00333041 File Offset: 0x00331241
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DBA4 RID: 56228 RVA: 0x00333050 File Offset: 0x00331250
		public SkillButtonEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003788 RID: 14216
		// (get) Token: 0x0600DBA5 RID: 56229 RVA: 0x00333060 File Offset: 0x00331260
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

		// Token: 0x17003789 RID: 14217
		// (get) Token: 0x0600DBA6 RID: 56230 RVA: 0x0033309C File Offset: 0x0033129C
		public string Name
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

		// Token: 0x0600DBA7 RID: 56231 RVA: 0x003330D3 File Offset: 0x003312D3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DBA8 RID: 56232 RVA: 0x003330E2 File Offset: 0x003312E2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700378A RID: 14218
		// (get) Token: 0x0600DBA9 RID: 56233 RVA: 0x003330FC File Offset: 0x003312FC
		public string NiagaraPath
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

		// Token: 0x0600DBAA RID: 56234 RVA: 0x00333133 File Offset: 0x00331333
		public Span<byte> GetNiagaraPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DBAB RID: 56235 RVA: 0x00333142 File Offset: 0x00331342
		public byte[] GetNiagaraPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700378B RID: 14219
		// (get) Token: 0x0600DBAC RID: 56236 RVA: 0x0033315C File Offset: 0x0033135C
		public int ElementId
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

		// Token: 0x1700378C RID: 14220
		// (get) Token: 0x0600DBAD RID: 56237 RVA: 0x0033319C File Offset: 0x0033139C
		public string Color
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

		// Token: 0x0600DBAE RID: 56238 RVA: 0x003331D4 File Offset: 0x003313D4
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DBAF RID: 56239 RVA: 0x003331E4 File Offset: 0x003313E4
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700378D RID: 14221
		// (get) Token: 0x0600DBB0 RID: 56240 RVA: 0x003331FC File Offset: 0x003313FC
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040057D2 RID: 22482
		private Table __p;
	}
}
