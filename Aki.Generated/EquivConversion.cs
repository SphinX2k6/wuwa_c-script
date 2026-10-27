using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C3F RID: 3135
	public struct EquivConversion : IFlatbufferObject
	{
		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06006A44 RID: 27204 RVA: 0x0022570D File Offset: 0x0022390D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006A45 RID: 27205 RVA: 0x0022571A File Offset: 0x0022391A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006A46 RID: 27206 RVA: 0x00225724 File Offset: 0x00223924
		public static EquivConversion GetRootAsEquivConversion(ByteBuffer _bb)
		{
			return EquivConversion.GetRootAsEquivConversion(_bb, default(EquivConversion));
		}

		// Token: 0x06006A47 RID: 27207 RVA: 0x00225740 File Offset: 0x00223940
		public static EquivConversion GetRootAsEquivConversion(ByteBuffer _bb, EquivConversion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006A48 RID: 27208 RVA: 0x0022575D File Offset: 0x0022395D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006A49 RID: 27209 RVA: 0x0022576C File Offset: 0x0022396C
		public EquivConversion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06006A4A RID: 27210 RVA: 0x0022577C File Offset: 0x0022397C
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

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x06006A4B RID: 27211 RVA: 0x002257B8 File Offset: 0x002239B8
		public int DamageRatio
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

		// Token: 0x04004C7F RID: 19583
		private Table __p;
	}
}
