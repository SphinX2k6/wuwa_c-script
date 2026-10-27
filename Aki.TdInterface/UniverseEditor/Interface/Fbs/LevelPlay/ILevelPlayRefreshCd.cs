using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200450F RID: 17679
	public struct ILevelPlayRefreshCd : IFlatbufferObject
	{
		// Token: 0x17007D58 RID: 32088
		// (get) Token: 0x0601A907 RID: 108807 RVA: 0x003CB381 File Offset: 0x003C9581
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A908 RID: 108808 RVA: 0x003CB38E File Offset: 0x003C958E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A909 RID: 108809 RVA: 0x003CB398 File Offset: 0x003C9598
		public static ILevelPlayRefreshCd GetRootAsILevelPlayRefreshCd(ByteBuffer _bb)
		{
			return ILevelPlayRefreshCd.GetRootAsILevelPlayRefreshCd(_bb, default(ILevelPlayRefreshCd));
		}

		// Token: 0x0601A90A RID: 108810 RVA: 0x003CB3B4 File Offset: 0x003C95B4
		public static ILevelPlayRefreshCd GetRootAsILevelPlayRefreshCd(ByteBuffer _bb, ILevelPlayRefreshCd obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A90B RID: 108811 RVA: 0x003CB3D1 File Offset: 0x003C95D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A90C RID: 108812 RVA: 0x003CB3E0 File Offset: 0x003C95E0
		public ILevelPlayRefreshCd __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D59 RID: 32089
		// (get) Token: 0x0601A90D RID: 108813 RVA: 0x003CB3F0 File Offset: 0x003C95F0
		public int MinRefreshCd
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

		// Token: 0x17007D5A RID: 32090
		// (get) Token: 0x0601A90E RID: 108814 RVA: 0x003CB42C File Offset: 0x003C962C
		public int MaxRefreshCd
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

		// Token: 0x0601A90F RID: 108815 RVA: 0x003CB468 File Offset: 0x003C9668
		public static Offset<ILevelPlayRefreshCd> CreateILevelPlayRefreshCd(FlatBufferBuilder builder, int MinRefreshCd = 0, int MaxRefreshCd = 0)
		{
			builder.StartTable(2);
			ILevelPlayRefreshCd.AddMaxRefreshCd(builder, MaxRefreshCd);
			ILevelPlayRefreshCd.AddMinRefreshCd(builder, MinRefreshCd);
			return ILevelPlayRefreshCd.EndILevelPlayRefreshCd(builder);
		}

		// Token: 0x0601A910 RID: 108816 RVA: 0x003CB485 File Offset: 0x003C9685
		public static void StartILevelPlayRefreshCd(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A911 RID: 108817 RVA: 0x003CB48E File Offset: 0x003C968E
		public static void AddMinRefreshCd(FlatBufferBuilder builder, int minRefreshCd)
		{
			builder.AddInt(0, minRefreshCd, 0);
		}

		// Token: 0x0601A912 RID: 108818 RVA: 0x003CB499 File Offset: 0x003C9699
		public static void AddMaxRefreshCd(FlatBufferBuilder builder, int maxRefreshCd)
		{
			builder.AddInt(1, maxRefreshCd, 0);
		}

		// Token: 0x0601A913 RID: 108819 RVA: 0x003CB4A4 File Offset: 0x003C96A4
		public static Offset<ILevelPlayRefreshCd> EndILevelPlayRefreshCd(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayRefreshCd>(builder.EndTable());
		}

		// Token: 0x0601A914 RID: 108820 RVA: 0x003CB4B4 File Offset: 0x003C96B4
		public ILevelPlayRefreshCdT UnPack()
		{
			ILevelPlayRefreshCdT levelPlayRefreshCdT = new ILevelPlayRefreshCdT();
			this.UnPackTo(levelPlayRefreshCdT);
			return levelPlayRefreshCdT;
		}

		// Token: 0x0601A915 RID: 108821 RVA: 0x003CB4CF File Offset: 0x003C96CF
		public void UnPackTo(ILevelPlayRefreshCdT _o)
		{
			_o.MinRefreshCd = this.MinRefreshCd;
			_o.MaxRefreshCd = this.MaxRefreshCd;
		}

		// Token: 0x0601A916 RID: 108822 RVA: 0x003CB4EC File Offset: 0x003C96EC
		public static Offset<ILevelPlayRefreshCd> Pack(FlatBufferBuilder builder, ILevelPlayRefreshCdT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayRefreshCd>);
			}
			return ILevelPlayRefreshCd.CreateILevelPlayRefreshCd(builder, _o.MinRefreshCd, _o.MaxRefreshCd);
		}

		// Token: 0x0400C579 RID: 50553
		private Table __p;
	}
}
