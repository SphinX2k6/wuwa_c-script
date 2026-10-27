using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041C9 RID: 16841
	public struct ITetrisPlayModeNormal : IFlatbufferObject
	{
		// Token: 0x1700776C RID: 30572
		// (get) Token: 0x06018CE6 RID: 101606 RVA: 0x00391E88 File Offset: 0x00390088
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018CE7 RID: 101607 RVA: 0x00391E95 File Offset: 0x00390095
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018CE8 RID: 101608 RVA: 0x00391E9C File Offset: 0x0039009C
		public static ITetrisPlayModeNormal GetRootAsITetrisPlayModeNormal(ByteBuffer _bb)
		{
			return ITetrisPlayModeNormal.GetRootAsITetrisPlayModeNormal(_bb, default(ITetrisPlayModeNormal));
		}

		// Token: 0x06018CE9 RID: 101609 RVA: 0x00391EB8 File Offset: 0x003900B8
		public static ITetrisPlayModeNormal GetRootAsITetrisPlayModeNormal(ByteBuffer _bb, ITetrisPlayModeNormal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018CEA RID: 101610 RVA: 0x00391ED5 File Offset: 0x003900D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018CEB RID: 101611 RVA: 0x00391EE4 File Offset: 0x003900E4
		public ITetrisPlayModeNormal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700776D RID: 30573
		// (get) Token: 0x06018CEC RID: 101612 RVA: 0x00391EF4 File Offset: 0x003900F4
		public ETetrisPlayMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETetrisPlayMode.Normal;
				}
				return (ETetrisPlayMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700776E RID: 30574
		// (get) Token: 0x06018CED RID: 101613 RVA: 0x00391F30 File Offset: 0x00390130
		public int Time
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

		// Token: 0x06018CEE RID: 101614 RVA: 0x00391F6C File Offset: 0x0039016C
		public static Offset<ITetrisPlayModeNormal> CreateITetrisPlayModeNormal(FlatBufferBuilder builder, ETetrisPlayMode Type = ETetrisPlayMode.Normal, int Time = 0)
		{
			builder.StartTable(2);
			ITetrisPlayModeNormal.AddTime(builder, Time);
			ITetrisPlayModeNormal.AddType(builder, Type);
			return ITetrisPlayModeNormal.EndITetrisPlayModeNormal(builder);
		}

		// Token: 0x06018CEF RID: 101615 RVA: 0x00391F89 File Offset: 0x00390189
		public static void StartITetrisPlayModeNormal(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018CF0 RID: 101616 RVA: 0x00391F92 File Offset: 0x00390192
		public static void AddType(FlatBufferBuilder builder, ETetrisPlayMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018CF1 RID: 101617 RVA: 0x00391F9D File Offset: 0x0039019D
		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(1, time, 0);
		}

		// Token: 0x06018CF2 RID: 101618 RVA: 0x00391FA8 File Offset: 0x003901A8
		public static Offset<ITetrisPlayModeNormal> EndITetrisPlayModeNormal(FlatBufferBuilder builder)
		{
			return new Offset<ITetrisPlayModeNormal>(builder.EndTable());
		}

		// Token: 0x06018CF3 RID: 101619 RVA: 0x00391FB8 File Offset: 0x003901B8
		public ITetrisPlayModeNormalT UnPack()
		{
			ITetrisPlayModeNormalT tetrisPlayModeNormalT = new ITetrisPlayModeNormalT();
			this.UnPackTo(tetrisPlayModeNormalT);
			return tetrisPlayModeNormalT;
		}

		// Token: 0x06018CF4 RID: 101620 RVA: 0x00391FD3 File Offset: 0x003901D3
		public void UnPackTo(ITetrisPlayModeNormalT _o)
		{
			_o.Type = this.Type;
			_o.Time = this.Time;
		}

		// Token: 0x06018CF5 RID: 101621 RVA: 0x00391FF0 File Offset: 0x003901F0
		public static Offset<ITetrisPlayModeNormal> Pack(FlatBufferBuilder builder, ITetrisPlayModeNormalT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITetrisPlayModeNormal>);
			}
			return ITetrisPlayModeNormal.CreateITetrisPlayModeNormal(builder, _o.Type, _o.Time);
		}

		// Token: 0x0400BE15 RID: 48661
		private Table __p;
	}
}
