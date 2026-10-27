using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010FA RID: 4346
	public struct SurvivorsEffect : IFlatbufferObject
	{
		// Token: 0x170038BE RID: 14526
		// (get) Token: 0x0600DA62 RID: 55906 RVA: 0x00323A41 File Offset: 0x00321C41
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DA63 RID: 55907 RVA: 0x00323A4E File Offset: 0x00321C4E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DA64 RID: 55908 RVA: 0x00323A58 File Offset: 0x00321C58
		public static SurvivorsEffect GetRootAsSurvivorsEffect(ByteBuffer _bb)
		{
			return SurvivorsEffect.GetRootAsSurvivorsEffect(_bb, default(SurvivorsEffect));
		}

		// Token: 0x0600DA65 RID: 55909 RVA: 0x00323A74 File Offset: 0x00321C74
		public static SurvivorsEffect GetRootAsSurvivorsEffect(ByteBuffer _bb, SurvivorsEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DA66 RID: 55910 RVA: 0x00323A91 File Offset: 0x00321C91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DA67 RID: 55911 RVA: 0x00323AA0 File Offset: 0x00321CA0
		public SurvivorsEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170038BF RID: 14527
		// (get) Token: 0x0600DA68 RID: 55912 RVA: 0x00323AB0 File Offset: 0x00321CB0
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

		// Token: 0x170038C0 RID: 14528
		// (get) Token: 0x0600DA69 RID: 55913 RVA: 0x00323AEC File Offset: 0x00321CEC
		public int DescIntParam
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

		// Token: 0x04005230 RID: 21040
		private Table __p;
	}
}
