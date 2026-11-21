using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005871 RID: 22641
	public struct IGazeCondition : IFlatbufferObject
	{
		// Token: 0x1700A400 RID: 41984
		// (get) Token: 0x06024B22 RID: 150306 RVA: 0x0050A78A File Offset: 0x0050898A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024B23 RID: 150307 RVA: 0x0050A797 File Offset: 0x00508997
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024B24 RID: 150308 RVA: 0x0050A7A0 File Offset: 0x005089A0
		public static IGazeCondition GetRootAsIGazeCondition(ByteBuffer _bb)
		{
			return IGazeCondition.GetRootAsIGazeCondition(_bb, default(IGazeCondition));
		}

		// Token: 0x06024B25 RID: 150309 RVA: 0x0050A7BC File Offset: 0x005089BC
		public static IGazeCondition GetRootAsIGazeCondition(ByteBuffer _bb, IGazeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024B26 RID: 150310 RVA: 0x0050A7D9 File Offset: 0x005089D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024B27 RID: 150311 RVA: 0x0050A7E8 File Offset: 0x005089E8
		public IGazeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A401 RID: 41985
		// (get) Token: 0x06024B28 RID: 150312 RVA: 0x0050A7F8 File Offset: 0x005089F8
		public int GazeInDistance
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

		// Token: 0x1700A402 RID: 41986
		// (get) Token: 0x06024B29 RID: 150313 RVA: 0x0050A834 File Offset: 0x00508A34
		public IConeTriggerShape? ScanRange
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConeTriggerShape?(default(IConeTriggerShape).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A403 RID: 41987
		// (get) Token: 0x06024B2A RID: 150314 RVA: 0x0050A894 File Offset: 0x00508A94
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

		// Token: 0x06024B2B RID: 150315 RVA: 0x0050A8D0 File Offset: 0x00508AD0
		public static Offset<IGazeCondition> CreateIGazeCondition(FlatBufferBuilder builder, int GazeInDistance = 0, Offset<IConeTriggerShape> ScanRangeOffset = default(Offset<IConeTriggerShape>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IGazeCondition.AddScanRange(builder, ScanRangeOffset);
			IGazeCondition.AddGazeInDistance(builder, GazeInDistance);
			IGazeCondition.AddNullMask(builder, NullMask);
			return IGazeCondition.EndIGazeCondition(builder);
		}

		// Token: 0x06024B2C RID: 150316 RVA: 0x0050A8F4 File Offset: 0x00508AF4
		public static void StartIGazeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024B2D RID: 150317 RVA: 0x0050A8FD File Offset: 0x00508AFD
		public static void AddGazeInDistance(FlatBufferBuilder builder, int gazeInDistance)
		{
			builder.AddInt(0, gazeInDistance, 0);
		}

		// Token: 0x06024B2E RID: 150318 RVA: 0x0050A908 File Offset: 0x00508B08
		public static void AddScanRange(FlatBufferBuilder builder, Offset<IConeTriggerShape> scanRangeOffset)
		{
			builder.AddOffset(1, scanRangeOffset.Value, 0);
		}

		// Token: 0x06024B2F RID: 150319 RVA: 0x0050A918 File Offset: 0x00508B18
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06024B30 RID: 150320 RVA: 0x0050A923 File Offset: 0x00508B23
		public static Offset<IGazeCondition> EndIGazeCondition(FlatBufferBuilder builder)
		{
			return new Offset<IGazeCondition>(builder.EndTable());
		}

		// Token: 0x06024B31 RID: 150321 RVA: 0x0050A930 File Offset: 0x00508B30
		public IGazeConditionT UnPack()
		{
			IGazeConditionT gazeConditionT = new IGazeConditionT();
			this.UnPackTo(gazeConditionT);
			return gazeConditionT;
		}

		// Token: 0x06024B32 RID: 150322 RVA: 0x0050A94C File Offset: 0x00508B4C
		public void UnPackTo(IGazeConditionT _o)
		{
			_o.GazeInDistance = this.GazeInDistance;
			_o.ScanRange = ((this.ScanRange != null) ? this.ScanRange.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024B33 RID: 150323 RVA: 0x0050A9A0 File Offset: 0x00508BA0
		public static Offset<IGazeCondition> Pack(FlatBufferBuilder builder, IGazeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGazeCondition>);
			}
			Offset<IConeTriggerShape> scanRangeOffset = (_o.ScanRange == null) ? default(Offset<IConeTriggerShape>) : IConeTriggerShape.Pack(builder, _o.ScanRange);
			return IGazeCondition.CreateIGazeCondition(builder, _o.GazeInDistance, scanRangeOffset, _o.NullMask);
		}

		// Token: 0x0400F0BC RID: 61628
		private Table __p;
	}
}
