using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200461C RID: 17948
	public struct ITetrisPlayModeEndless : IFlatbufferObject
	{
		// Token: 0x17007D86 RID: 32134
		// (get) Token: 0x0601A3FE RID: 107518 RVA: 0x003BCC6E File Offset: 0x003BAE6E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A3FF RID: 107519 RVA: 0x003BCC7B File Offset: 0x003BAE7B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A400 RID: 107520 RVA: 0x003BCC84 File Offset: 0x003BAE84
		public static ITetrisPlayModeEndless GetRootAsITetrisPlayModeEndless(ByteBuffer _bb)
		{
			return ITetrisPlayModeEndless.GetRootAsITetrisPlayModeEndless(_bb, default(ITetrisPlayModeEndless));
		}

		// Token: 0x0601A401 RID: 107521 RVA: 0x003BCCA0 File Offset: 0x003BAEA0
		public static ITetrisPlayModeEndless GetRootAsITetrisPlayModeEndless(ByteBuffer _bb, ITetrisPlayModeEndless obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A402 RID: 107522 RVA: 0x003BCCBD File Offset: 0x003BAEBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A403 RID: 107523 RVA: 0x003BCCCC File Offset: 0x003BAECC
		public ITetrisPlayModeEndless __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D87 RID: 32135
		// (get) Token: 0x0601A404 RID: 107524 RVA: 0x003BCCDC File Offset: 0x003BAEDC
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

		// Token: 0x17007D88 RID: 32136
		// (get) Token: 0x0601A405 RID: 107525 RVA: 0x003BCD18 File Offset: 0x003BAF18
		public int SpeedLevel
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

		// Token: 0x17007D89 RID: 32137
		// (get) Token: 0x0601A406 RID: 107526 RVA: 0x003BCD54 File Offset: 0x003BAF54
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A407 RID: 107527 RVA: 0x003BCD90 File Offset: 0x003BAF90
		public static Offset<ITetrisPlayModeEndless> CreateITetrisPlayModeEndless(FlatBufferBuilder builder, ETetrisPlayMode Type = ETetrisPlayMode.Normal, int SpeedLevel = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ITetrisPlayModeEndless.AddSpeedLevel(builder, SpeedLevel);
			ITetrisPlayModeEndless.AddNullMask(builder, NullMask);
			ITetrisPlayModeEndless.AddType(builder, Type);
			return ITetrisPlayModeEndless.EndITetrisPlayModeEndless(builder);
		}

		// Token: 0x0601A408 RID: 107528 RVA: 0x003BCDB4 File Offset: 0x003BAFB4
		public static void StartITetrisPlayModeEndless(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A409 RID: 107529 RVA: 0x003BCDBD File Offset: 0x003BAFBD
		public static void AddType(FlatBufferBuilder builder, ETetrisPlayMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A40A RID: 107530 RVA: 0x003BCDC8 File Offset: 0x003BAFC8
		public static void AddSpeedLevel(FlatBufferBuilder builder, int speedLevel)
		{
			builder.AddInt(1, speedLevel, 0);
		}

		// Token: 0x0601A40B RID: 107531 RVA: 0x003BCDD3 File Offset: 0x003BAFD3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601A40C RID: 107532 RVA: 0x003BCDDE File Offset: 0x003BAFDE
		public static Offset<ITetrisPlayModeEndless> EndITetrisPlayModeEndless(FlatBufferBuilder builder)
		{
			return new Offset<ITetrisPlayModeEndless>(builder.EndTable());
		}

		// Token: 0x0601A40D RID: 107533 RVA: 0x003BCDEC File Offset: 0x003BAFEC
		public ITetrisPlayModeEndlessT UnPack()
		{
			ITetrisPlayModeEndlessT tetrisPlayModeEndlessT = new ITetrisPlayModeEndlessT();
			this.UnPackTo(tetrisPlayModeEndlessT);
			return tetrisPlayModeEndlessT;
		}

		// Token: 0x0601A40E RID: 107534 RVA: 0x003BCE07 File Offset: 0x003BB007
		public void UnPackTo(ITetrisPlayModeEndlessT _o)
		{
			_o.Type = this.Type;
			_o.SpeedLevel = this.SpeedLevel;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A40F RID: 107535 RVA: 0x003BCE30 File Offset: 0x003BB030
		public static Offset<ITetrisPlayModeEndless> Pack(FlatBufferBuilder builder, ITetrisPlayModeEndlessT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITetrisPlayModeEndless>);
			}
			return ITetrisPlayModeEndless.CreateITetrisPlayModeEndless(builder, _o.Type, _o.SpeedLevel, _o.NullMask);
		}

		// Token: 0x0400C815 RID: 51221
		private Table __p;
	}
}
