using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041BD RID: 16829
	public struct ITetrisPlayModeBase : IFlatbufferObject
	{
		// Token: 0x17007755 RID: 30549
		// (get) Token: 0x06018C86 RID: 101510 RVA: 0x00391517 File Offset: 0x0038F717
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018C87 RID: 101511 RVA: 0x00391524 File Offset: 0x0038F724
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018C88 RID: 101512 RVA: 0x0039152C File Offset: 0x0038F72C
		public static ITetrisPlayModeBase GetRootAsITetrisPlayModeBase(ByteBuffer _bb)
		{
			return ITetrisPlayModeBase.GetRootAsITetrisPlayModeBase(_bb, default(ITetrisPlayModeBase));
		}

		// Token: 0x06018C89 RID: 101513 RVA: 0x00391548 File Offset: 0x0038F748
		public static ITetrisPlayModeBase GetRootAsITetrisPlayModeBase(ByteBuffer _bb, ITetrisPlayModeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018C8A RID: 101514 RVA: 0x00391565 File Offset: 0x0038F765
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018C8B RID: 101515 RVA: 0x00391574 File Offset: 0x0038F774
		public ITetrisPlayModeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007756 RID: 30550
		// (get) Token: 0x06018C8C RID: 101516 RVA: 0x00391584 File Offset: 0x0038F784
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

		// Token: 0x06018C8D RID: 101517 RVA: 0x003915C0 File Offset: 0x0038F7C0
		public static Offset<ITetrisPlayModeBase> CreateITetrisPlayModeBase(FlatBufferBuilder builder, ETetrisPlayMode Type = ETetrisPlayMode.Normal)
		{
			builder.StartTable(1);
			ITetrisPlayModeBase.AddType(builder, Type);
			return ITetrisPlayModeBase.EndITetrisPlayModeBase(builder);
		}

		// Token: 0x06018C8E RID: 101518 RVA: 0x003915D6 File Offset: 0x0038F7D6
		public static void StartITetrisPlayModeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018C8F RID: 101519 RVA: 0x003915DF File Offset: 0x0038F7DF
		public static void AddType(FlatBufferBuilder builder, ETetrisPlayMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018C90 RID: 101520 RVA: 0x003915EA File Offset: 0x0038F7EA
		public static Offset<ITetrisPlayModeBase> EndITetrisPlayModeBase(FlatBufferBuilder builder)
		{
			return new Offset<ITetrisPlayModeBase>(builder.EndTable());
		}

		// Token: 0x06018C91 RID: 101521 RVA: 0x003915F8 File Offset: 0x0038F7F8
		public ITetrisPlayModeBaseT UnPack()
		{
			ITetrisPlayModeBaseT tetrisPlayModeBaseT = new ITetrisPlayModeBaseT();
			this.UnPackTo(tetrisPlayModeBaseT);
			return tetrisPlayModeBaseT;
		}

		// Token: 0x06018C92 RID: 101522 RVA: 0x00391613 File Offset: 0x0038F813
		public void UnPackTo(ITetrisPlayModeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06018C93 RID: 101523 RVA: 0x00391624 File Offset: 0x0038F824
		public static Offset<ITetrisPlayModeBase> Pack(FlatBufferBuilder builder, ITetrisPlayModeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITetrisPlayModeBase>);
			}
			return ITetrisPlayModeBase.CreateITetrisPlayModeBase(builder, _o.Type);
		}

		// Token: 0x0400BE01 RID: 48641
		private Table __p;
	}
}
