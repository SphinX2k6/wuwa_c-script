using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004622 RID: 17954
	public struct ITetrisPlayModeNormal : IFlatbufferObject
	{
		// Token: 0x17007D98 RID: 32152
		// (get) Token: 0x0601A43C RID: 107580 RVA: 0x003BD2DC File Offset: 0x003BB4DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A43D RID: 107581 RVA: 0x003BD2E9 File Offset: 0x003BB4E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A43E RID: 107582 RVA: 0x003BD2F0 File Offset: 0x003BB4F0
		public static ITetrisPlayModeNormal GetRootAsITetrisPlayModeNormal(ByteBuffer _bb)
		{
			return ITetrisPlayModeNormal.GetRootAsITetrisPlayModeNormal(_bb, default(ITetrisPlayModeNormal));
		}

		// Token: 0x0601A43F RID: 107583 RVA: 0x003BD30C File Offset: 0x003BB50C
		public static ITetrisPlayModeNormal GetRootAsITetrisPlayModeNormal(ByteBuffer _bb, ITetrisPlayModeNormal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A440 RID: 107584 RVA: 0x003BD329 File Offset: 0x003BB529
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A441 RID: 107585 RVA: 0x003BD338 File Offset: 0x003BB538
		public ITetrisPlayModeNormal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D99 RID: 32153
		// (get) Token: 0x0601A442 RID: 107586 RVA: 0x003BD348 File Offset: 0x003BB548
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

		// Token: 0x17007D9A RID: 32154
		// (get) Token: 0x0601A443 RID: 107587 RVA: 0x003BD384 File Offset: 0x003BB584
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

		// Token: 0x0601A444 RID: 107588 RVA: 0x003BD3C0 File Offset: 0x003BB5C0
		public static Offset<ITetrisPlayModeNormal> CreateITetrisPlayModeNormal(FlatBufferBuilder builder, ETetrisPlayMode Type = ETetrisPlayMode.Normal, int Time = 0)
		{
			builder.StartTable(2);
			ITetrisPlayModeNormal.AddTime(builder, Time);
			ITetrisPlayModeNormal.AddType(builder, Type);
			return ITetrisPlayModeNormal.EndITetrisPlayModeNormal(builder);
		}

		// Token: 0x0601A445 RID: 107589 RVA: 0x003BD3DD File Offset: 0x003BB5DD
		public static void StartITetrisPlayModeNormal(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A446 RID: 107590 RVA: 0x003BD3E6 File Offset: 0x003BB5E6
		public static void AddType(FlatBufferBuilder builder, ETetrisPlayMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A447 RID: 107591 RVA: 0x003BD3F1 File Offset: 0x003BB5F1
		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(1, time, 0);
		}

		// Token: 0x0601A448 RID: 107592 RVA: 0x003BD3FC File Offset: 0x003BB5FC
		public static Offset<ITetrisPlayModeNormal> EndITetrisPlayModeNormal(FlatBufferBuilder builder)
		{
			return new Offset<ITetrisPlayModeNormal>(builder.EndTable());
		}

		// Token: 0x0601A449 RID: 107593 RVA: 0x003BD40C File Offset: 0x003BB60C
		public ITetrisPlayModeNormalT UnPack()
		{
			ITetrisPlayModeNormalT tetrisPlayModeNormalT = new ITetrisPlayModeNormalT();
			this.UnPackTo(tetrisPlayModeNormalT);
			return tetrisPlayModeNormalT;
		}

		// Token: 0x0601A44A RID: 107594 RVA: 0x003BD427 File Offset: 0x003BB627
		public void UnPackTo(ITetrisPlayModeNormalT _o)
		{
			_o.Type = this.Type;
			_o.Time = this.Time;
		}

		// Token: 0x0601A44B RID: 107595 RVA: 0x003BD444 File Offset: 0x003BB644
		public static Offset<ITetrisPlayModeNormal> Pack(FlatBufferBuilder builder, ITetrisPlayModeNormalT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITetrisPlayModeNormal>);
			}
			return ITetrisPlayModeNormal.CreateITetrisPlayModeNormal(builder, _o.Type, _o.Time);
		}

		// Token: 0x0400C81F RID: 51231
		private Table __p;
	}
}
