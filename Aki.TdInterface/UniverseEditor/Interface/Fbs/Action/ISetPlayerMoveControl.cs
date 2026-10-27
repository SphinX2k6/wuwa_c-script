using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200704C RID: 28748
	public struct ISetPlayerMoveControl : IFlatbufferObject
	{
		// Token: 0x1700D588 RID: 54664
		// (get) Token: 0x06032DF5 RID: 208373 RVA: 0x006DCAFB File Offset: 0x006DACFB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032DF6 RID: 208374 RVA: 0x006DCB08 File Offset: 0x006DAD08
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032DF7 RID: 208375 RVA: 0x006DCB10 File Offset: 0x006DAD10
		public static ISetPlayerMoveControl GetRootAsISetPlayerMoveControl(ByteBuffer _bb)
		{
			return ISetPlayerMoveControl.GetRootAsISetPlayerMoveControl(_bb, default(ISetPlayerMoveControl));
		}

		// Token: 0x06032DF8 RID: 208376 RVA: 0x006DCB2C File Offset: 0x006DAD2C
		public static ISetPlayerMoveControl GetRootAsISetPlayerMoveControl(ByteBuffer _bb, ISetPlayerMoveControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032DF9 RID: 208377 RVA: 0x006DCB49 File Offset: 0x006DAD49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032DFA RID: 208378 RVA: 0x006DCB58 File Offset: 0x006DAD58
		public ISetPlayerMoveControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D589 RID: 54665
		// (get) Token: 0x06032DFB RID: 208379 RVA: 0x006DCB68 File Offset: 0x006DAD68
		public int Left
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

		// Token: 0x1700D58A RID: 54666
		// (get) Token: 0x06032DFC RID: 208380 RVA: 0x006DCBA4 File Offset: 0x006DADA4
		public int Right
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

		// Token: 0x1700D58B RID: 54667
		// (get) Token: 0x06032DFD RID: 208381 RVA: 0x006DCBE0 File Offset: 0x006DADE0
		public int Forward
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D58C RID: 54668
		// (get) Token: 0x06032DFE RID: 208382 RVA: 0x006DCC1C File Offset: 0x006DAE1C
		public int Back
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

		// Token: 0x06032DFF RID: 208383 RVA: 0x006DCC59 File Offset: 0x006DAE59
		public static Offset<ISetPlayerMoveControl> CreateISetPlayerMoveControl(FlatBufferBuilder builder, int Left = 0, int Right = 0, int Forward = 0, int Back = 0)
		{
			builder.StartTable(4);
			ISetPlayerMoveControl.AddBack(builder, Back);
			ISetPlayerMoveControl.AddForward(builder, Forward);
			ISetPlayerMoveControl.AddRight(builder, Right);
			ISetPlayerMoveControl.AddLeft(builder, Left);
			return ISetPlayerMoveControl.EndISetPlayerMoveControl(builder);
		}

		// Token: 0x06032E00 RID: 208384 RVA: 0x006DCC85 File Offset: 0x006DAE85
		public static void StartISetPlayerMoveControl(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06032E01 RID: 208385 RVA: 0x006DCC8E File Offset: 0x006DAE8E
		public static void AddLeft(FlatBufferBuilder builder, int left)
		{
			builder.AddInt(0, left, 0);
		}

		// Token: 0x06032E02 RID: 208386 RVA: 0x006DCC99 File Offset: 0x006DAE99
		public static void AddRight(FlatBufferBuilder builder, int right)
		{
			builder.AddInt(1, right, 0);
		}

		// Token: 0x06032E03 RID: 208387 RVA: 0x006DCCA4 File Offset: 0x006DAEA4
		public static void AddForward(FlatBufferBuilder builder, int forward)
		{
			builder.AddInt(2, forward, 0);
		}

		// Token: 0x06032E04 RID: 208388 RVA: 0x006DCCAF File Offset: 0x006DAEAF
		public static void AddBack(FlatBufferBuilder builder, int back)
		{
			builder.AddInt(3, back, 0);
		}

		// Token: 0x06032E05 RID: 208389 RVA: 0x006DCCBA File Offset: 0x006DAEBA
		public static Offset<ISetPlayerMoveControl> EndISetPlayerMoveControl(FlatBufferBuilder builder)
		{
			return new Offset<ISetPlayerMoveControl>(builder.EndTable());
		}

		// Token: 0x06032E06 RID: 208390 RVA: 0x006DCCC8 File Offset: 0x006DAEC8
		public ISetPlayerMoveControlT UnPack()
		{
			ISetPlayerMoveControlT setPlayerMoveControlT = new ISetPlayerMoveControlT();
			this.UnPackTo(setPlayerMoveControlT);
			return setPlayerMoveControlT;
		}

		// Token: 0x06032E07 RID: 208391 RVA: 0x006DCCE3 File Offset: 0x006DAEE3
		public void UnPackTo(ISetPlayerMoveControlT _o)
		{
			_o.Left = this.Left;
			_o.Right = this.Right;
			_o.Forward = this.Forward;
			_o.Back = this.Back;
		}

		// Token: 0x06032E08 RID: 208392 RVA: 0x006DCD18 File Offset: 0x006DAF18
		public static Offset<ISetPlayerMoveControl> Pack(FlatBufferBuilder builder, ISetPlayerMoveControlT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetPlayerMoveControl>);
			}
			return ISetPlayerMoveControl.CreateISetPlayerMoveControl(builder, _o.Left, _o.Right, _o.Forward, _o.Back);
		}

		// Token: 0x04011A8F RID: 72335
		private Table __p;
	}
}
