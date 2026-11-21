using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007818 RID: 30744
	public struct ISetPlayerMoveControl : IFlatbufferObject
	{
		// Token: 0x1700E169 RID: 57705
		// (get) Token: 0x06036092 RID: 221330 RVA: 0x0073D023 File Offset: 0x0073B223
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036093 RID: 221331 RVA: 0x0073D030 File Offset: 0x0073B230
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036094 RID: 221332 RVA: 0x0073D038 File Offset: 0x0073B238
		public static ISetPlayerMoveControl GetRootAsISetPlayerMoveControl(ByteBuffer _bb)
		{
			return ISetPlayerMoveControl.GetRootAsISetPlayerMoveControl(_bb, default(ISetPlayerMoveControl));
		}

		// Token: 0x06036095 RID: 221333 RVA: 0x0073D054 File Offset: 0x0073B254
		public static ISetPlayerMoveControl GetRootAsISetPlayerMoveControl(ByteBuffer _bb, ISetPlayerMoveControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036096 RID: 221334 RVA: 0x0073D071 File Offset: 0x0073B271
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036097 RID: 221335 RVA: 0x0073D080 File Offset: 0x0073B280
		public ISetPlayerMoveControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E16A RID: 57706
		// (get) Token: 0x06036098 RID: 221336 RVA: 0x0073D090 File Offset: 0x0073B290
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

		// Token: 0x1700E16B RID: 57707
		// (get) Token: 0x06036099 RID: 221337 RVA: 0x0073D0CC File Offset: 0x0073B2CC
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

		// Token: 0x1700E16C RID: 57708
		// (get) Token: 0x0603609A RID: 221338 RVA: 0x0073D108 File Offset: 0x0073B308
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

		// Token: 0x1700E16D RID: 57709
		// (get) Token: 0x0603609B RID: 221339 RVA: 0x0073D144 File Offset: 0x0073B344
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

		// Token: 0x0603609C RID: 221340 RVA: 0x0073D181 File Offset: 0x0073B381
		public static Offset<ISetPlayerMoveControl> CreateISetPlayerMoveControl(FlatBufferBuilder builder, int Left = 0, int Right = 0, int Forward = 0, int Back = 0)
		{
			builder.StartTable(4);
			ISetPlayerMoveControl.AddBack(builder, Back);
			ISetPlayerMoveControl.AddForward(builder, Forward);
			ISetPlayerMoveControl.AddRight(builder, Right);
			ISetPlayerMoveControl.AddLeft(builder, Left);
			return ISetPlayerMoveControl.EndISetPlayerMoveControl(builder);
		}

		// Token: 0x0603609D RID: 221341 RVA: 0x0073D1AD File Offset: 0x0073B3AD
		public static void StartISetPlayerMoveControl(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603609E RID: 221342 RVA: 0x0073D1B6 File Offset: 0x0073B3B6
		public static void AddLeft(FlatBufferBuilder builder, int left)
		{
			builder.AddInt(0, left, 0);
		}

		// Token: 0x0603609F RID: 221343 RVA: 0x0073D1C1 File Offset: 0x0073B3C1
		public static void AddRight(FlatBufferBuilder builder, int right)
		{
			builder.AddInt(1, right, 0);
		}

		// Token: 0x060360A0 RID: 221344 RVA: 0x0073D1CC File Offset: 0x0073B3CC
		public static void AddForward(FlatBufferBuilder builder, int forward)
		{
			builder.AddInt(2, forward, 0);
		}

		// Token: 0x060360A1 RID: 221345 RVA: 0x0073D1D7 File Offset: 0x0073B3D7
		public static void AddBack(FlatBufferBuilder builder, int back)
		{
			builder.AddInt(3, back, 0);
		}

		// Token: 0x060360A2 RID: 221346 RVA: 0x0073D1E2 File Offset: 0x0073B3E2
		public static Offset<ISetPlayerMoveControl> EndISetPlayerMoveControl(FlatBufferBuilder builder)
		{
			return new Offset<ISetPlayerMoveControl>(builder.EndTable());
		}

		// Token: 0x060360A3 RID: 221347 RVA: 0x0073D1F0 File Offset: 0x0073B3F0
		public ISetPlayerMoveControlT UnPack()
		{
			ISetPlayerMoveControlT setPlayerMoveControlT = new ISetPlayerMoveControlT();
			this.UnPackTo(setPlayerMoveControlT);
			return setPlayerMoveControlT;
		}

		// Token: 0x060360A4 RID: 221348 RVA: 0x0073D20B File Offset: 0x0073B40B
		public void UnPackTo(ISetPlayerMoveControlT _o)
		{
			_o.Left = this.Left;
			_o.Right = this.Right;
			_o.Forward = this.Forward;
			_o.Back = this.Back;
		}

		// Token: 0x060360A5 RID: 221349 RVA: 0x0073D240 File Offset: 0x0073B440
		public static Offset<ISetPlayerMoveControl> Pack(FlatBufferBuilder builder, ISetPlayerMoveControlT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetPlayerMoveControl>);
			}
			return ISetPlayerMoveControl.CreateISetPlayerMoveControl(builder, _o.Left, _o.Right, _o.Forward, _o.Back);
		}

		// Token: 0x04012A7C RID: 76412
		private Table __p;
	}
}
