using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052EE RID: 21230
	public struct IGazeCondition : IFlatbufferObject
	{
		// Token: 0x17009BCF RID: 39887
		// (get) Token: 0x06022A88 RID: 141960 RVA: 0x004CDC5E File Offset: 0x004CBE5E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022A89 RID: 141961 RVA: 0x004CDC6B File Offset: 0x004CBE6B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022A8A RID: 141962 RVA: 0x004CDC74 File Offset: 0x004CBE74
		public static IGazeCondition GetRootAsIGazeCondition(ByteBuffer _bb)
		{
			return IGazeCondition.GetRootAsIGazeCondition(_bb, default(IGazeCondition));
		}

		// Token: 0x06022A8B RID: 141963 RVA: 0x004CDC90 File Offset: 0x004CBE90
		public static IGazeCondition GetRootAsIGazeCondition(ByteBuffer _bb, IGazeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022A8C RID: 141964 RVA: 0x004CDCAD File Offset: 0x004CBEAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022A8D RID: 141965 RVA: 0x004CDCBC File Offset: 0x004CBEBC
		public IGazeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009BD0 RID: 39888
		// (get) Token: 0x06022A8E RID: 141966 RVA: 0x004CDCCC File Offset: 0x004CBECC
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

		// Token: 0x17009BD1 RID: 39889
		// (get) Token: 0x06022A8F RID: 141967 RVA: 0x004CDD08 File Offset: 0x004CBF08
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

		// Token: 0x17009BD2 RID: 39890
		// (get) Token: 0x06022A90 RID: 141968 RVA: 0x004CDD68 File Offset: 0x004CBF68
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

		// Token: 0x06022A91 RID: 141969 RVA: 0x004CDDA4 File Offset: 0x004CBFA4
		public static Offset<IGazeCondition> CreateIGazeCondition(FlatBufferBuilder builder, int GazeInDistance = 0, Offset<IConeTriggerShape> ScanRangeOffset = default(Offset<IConeTriggerShape>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IGazeCondition.AddScanRange(builder, ScanRangeOffset);
			IGazeCondition.AddGazeInDistance(builder, GazeInDistance);
			IGazeCondition.AddNullMask(builder, NullMask);
			return IGazeCondition.EndIGazeCondition(builder);
		}

		// Token: 0x06022A92 RID: 141970 RVA: 0x004CDDC8 File Offset: 0x004CBFC8
		public static void StartIGazeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022A93 RID: 141971 RVA: 0x004CDDD1 File Offset: 0x004CBFD1
		public static void AddGazeInDistance(FlatBufferBuilder builder, int gazeInDistance)
		{
			builder.AddInt(0, gazeInDistance, 0);
		}

		// Token: 0x06022A94 RID: 141972 RVA: 0x004CDDDC File Offset: 0x004CBFDC
		public static void AddScanRange(FlatBufferBuilder builder, Offset<IConeTriggerShape> scanRangeOffset)
		{
			builder.AddOffset(1, scanRangeOffset.Value, 0);
		}

		// Token: 0x06022A95 RID: 141973 RVA: 0x004CDDEC File Offset: 0x004CBFEC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06022A96 RID: 141974 RVA: 0x004CDDF7 File Offset: 0x004CBFF7
		public static Offset<IGazeCondition> EndIGazeCondition(FlatBufferBuilder builder)
		{
			return new Offset<IGazeCondition>(builder.EndTable());
		}

		// Token: 0x06022A97 RID: 141975 RVA: 0x004CDE04 File Offset: 0x004CC004
		public IGazeConditionT UnPack()
		{
			IGazeConditionT gazeConditionT = new IGazeConditionT();
			this.UnPackTo(gazeConditionT);
			return gazeConditionT;
		}

		// Token: 0x06022A98 RID: 141976 RVA: 0x004CDE20 File Offset: 0x004CC020
		public void UnPackTo(IGazeConditionT _o)
		{
			_o.GazeInDistance = this.GazeInDistance;
			_o.ScanRange = ((this.ScanRange != null) ? this.ScanRange.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022A99 RID: 141977 RVA: 0x004CDE74 File Offset: 0x004CC074
		public static Offset<IGazeCondition> Pack(FlatBufferBuilder builder, IGazeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGazeCondition>);
			}
			Offset<IConeTriggerShape> scanRangeOffset = (_o.ScanRange == null) ? default(Offset<IConeTriggerShape>) : IConeTriggerShape.Pack(builder, _o.ScanRange);
			return IGazeCondition.CreateIGazeCondition(builder, _o.GazeInDistance, scanRangeOffset, _o.NullMask);
		}

		// Token: 0x0400E490 RID: 58512
		private Table __p;
	}
}
