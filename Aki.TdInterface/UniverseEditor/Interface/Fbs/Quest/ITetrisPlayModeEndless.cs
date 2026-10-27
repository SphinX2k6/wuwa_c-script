using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041C3 RID: 16835
	public struct ITetrisPlayModeEndless : IFlatbufferObject
	{
		// Token: 0x1700775A RID: 30554
		// (get) Token: 0x06018CA8 RID: 101544 RVA: 0x0039181A File Offset: 0x0038FA1A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018CA9 RID: 101545 RVA: 0x00391827 File Offset: 0x0038FA27
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018CAA RID: 101546 RVA: 0x00391830 File Offset: 0x0038FA30
		public static ITetrisPlayModeEndless GetRootAsITetrisPlayModeEndless(ByteBuffer _bb)
		{
			return ITetrisPlayModeEndless.GetRootAsITetrisPlayModeEndless(_bb, default(ITetrisPlayModeEndless));
		}

		// Token: 0x06018CAB RID: 101547 RVA: 0x0039184C File Offset: 0x0038FA4C
		public static ITetrisPlayModeEndless GetRootAsITetrisPlayModeEndless(ByteBuffer _bb, ITetrisPlayModeEndless obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018CAC RID: 101548 RVA: 0x00391869 File Offset: 0x0038FA69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018CAD RID: 101549 RVA: 0x00391878 File Offset: 0x0038FA78
		public ITetrisPlayModeEndless __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700775B RID: 30555
		// (get) Token: 0x06018CAE RID: 101550 RVA: 0x00391888 File Offset: 0x0038FA88
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

		// Token: 0x1700775C RID: 30556
		// (get) Token: 0x06018CAF RID: 101551 RVA: 0x003918C4 File Offset: 0x0038FAC4
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

		// Token: 0x1700775D RID: 30557
		// (get) Token: 0x06018CB0 RID: 101552 RVA: 0x00391900 File Offset: 0x0038FB00
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

		// Token: 0x06018CB1 RID: 101553 RVA: 0x0039193C File Offset: 0x0038FB3C
		public static Offset<ITetrisPlayModeEndless> CreateITetrisPlayModeEndless(FlatBufferBuilder builder, ETetrisPlayMode Type = ETetrisPlayMode.Normal, int SpeedLevel = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ITetrisPlayModeEndless.AddSpeedLevel(builder, SpeedLevel);
			ITetrisPlayModeEndless.AddNullMask(builder, NullMask);
			ITetrisPlayModeEndless.AddType(builder, Type);
			return ITetrisPlayModeEndless.EndITetrisPlayModeEndless(builder);
		}

		// Token: 0x06018CB2 RID: 101554 RVA: 0x00391960 File Offset: 0x0038FB60
		public static void StartITetrisPlayModeEndless(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06018CB3 RID: 101555 RVA: 0x00391969 File Offset: 0x0038FB69
		public static void AddType(FlatBufferBuilder builder, ETetrisPlayMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018CB4 RID: 101556 RVA: 0x00391974 File Offset: 0x0038FB74
		public static void AddSpeedLevel(FlatBufferBuilder builder, int speedLevel)
		{
			builder.AddInt(1, speedLevel, 0);
		}

		// Token: 0x06018CB5 RID: 101557 RVA: 0x0039197F File Offset: 0x0038FB7F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06018CB6 RID: 101558 RVA: 0x0039198A File Offset: 0x0038FB8A
		public static Offset<ITetrisPlayModeEndless> EndITetrisPlayModeEndless(FlatBufferBuilder builder)
		{
			return new Offset<ITetrisPlayModeEndless>(builder.EndTable());
		}

		// Token: 0x06018CB7 RID: 101559 RVA: 0x00391998 File Offset: 0x0038FB98
		public ITetrisPlayModeEndlessT UnPack()
		{
			ITetrisPlayModeEndlessT tetrisPlayModeEndlessT = new ITetrisPlayModeEndlessT();
			this.UnPackTo(tetrisPlayModeEndlessT);
			return tetrisPlayModeEndlessT;
		}

		// Token: 0x06018CB8 RID: 101560 RVA: 0x003919B3 File Offset: 0x0038FBB3
		public void UnPackTo(ITetrisPlayModeEndlessT _o)
		{
			_o.Type = this.Type;
			_o.SpeedLevel = this.SpeedLevel;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018CB9 RID: 101561 RVA: 0x003919DC File Offset: 0x0038FBDC
		public static Offset<ITetrisPlayModeEndless> Pack(FlatBufferBuilder builder, ITetrisPlayModeEndlessT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITetrisPlayModeEndless>);
			}
			return ITetrisPlayModeEndless.CreateITetrisPlayModeEndless(builder, _o.Type, _o.SpeedLevel, _o.NullMask);
		}

		// Token: 0x0400BE0B RID: 48651
		private Table __p;
	}
}
