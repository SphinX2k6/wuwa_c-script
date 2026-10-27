using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010B9 RID: 4281
	public struct SkillButtonEffect : IFlatbufferObject
	{
		// Token: 0x17003676 RID: 13942
		// (get) Token: 0x0600D3C2 RID: 54210 RVA: 0x00313C65 File Offset: 0x00311E65
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D3C3 RID: 54211 RVA: 0x00313C72 File Offset: 0x00311E72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D3C4 RID: 54212 RVA: 0x00313C7C File Offset: 0x00311E7C
		public static SkillButtonEffect GetRootAsSkillButtonEffect(ByteBuffer _bb)
		{
			return SkillButtonEffect.GetRootAsSkillButtonEffect(_bb, default(SkillButtonEffect));
		}

		// Token: 0x0600D3C5 RID: 54213 RVA: 0x00313C98 File Offset: 0x00311E98
		public static SkillButtonEffect GetRootAsSkillButtonEffect(ByteBuffer _bb, SkillButtonEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D3C6 RID: 54214 RVA: 0x00313CB5 File Offset: 0x00311EB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D3C7 RID: 54215 RVA: 0x00313CC4 File Offset: 0x00311EC4
		public SkillButtonEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003677 RID: 13943
		// (get) Token: 0x0600D3C8 RID: 54216 RVA: 0x00313CD4 File Offset: 0x00311ED4
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

		// Token: 0x17003678 RID: 13944
		// (get) Token: 0x0600D3C9 RID: 54217 RVA: 0x00313D10 File Offset: 0x00311F10
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

		// Token: 0x0600D3CA RID: 54218 RVA: 0x00313D47 File Offset: 0x00311F47
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D3CB RID: 54219 RVA: 0x00313D56 File Offset: 0x00311F56
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003679 RID: 13945
		// (get) Token: 0x0600D3CC RID: 54220 RVA: 0x00313D70 File Offset: 0x00311F70
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

		// Token: 0x0600D3CD RID: 54221 RVA: 0x00313DA7 File Offset: 0x00311FA7
		public Span<byte> GetNiagaraPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D3CE RID: 54222 RVA: 0x00313DB6 File Offset: 0x00311FB6
		public byte[] GetNiagaraPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700367A RID: 13946
		// (get) Token: 0x0600D3CF RID: 54223 RVA: 0x00313DD0 File Offset: 0x00311FD0
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

		// Token: 0x1700367B RID: 13947
		// (get) Token: 0x0600D3D0 RID: 54224 RVA: 0x00313E10 File Offset: 0x00312010
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

		// Token: 0x0600D3D1 RID: 54225 RVA: 0x00313E48 File Offset: 0x00312048
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D3D2 RID: 54226 RVA: 0x00313E58 File Offset: 0x00312058
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700367C RID: 13948
		// (get) Token: 0x0600D3D3 RID: 54227 RVA: 0x00313E70 File Offset: 0x00312070
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

		// Token: 0x040051D3 RID: 20947
		private Table __p;
	}
}
