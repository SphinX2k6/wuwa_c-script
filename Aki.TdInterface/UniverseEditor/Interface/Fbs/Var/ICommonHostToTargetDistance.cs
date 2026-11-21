using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E65 RID: 15973
	public struct ICommonHostToTargetDistance : IFlatbufferObject
	{
		// Token: 0x17006BD4 RID: 27604
		// (get) Token: 0x06015843 RID: 88131 RVA: 0x0031A430 File Offset: 0x00318630
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015844 RID: 88132 RVA: 0x0031A43D File Offset: 0x0031863D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015845 RID: 88133 RVA: 0x0031A444 File Offset: 0x00318644
		public static ICommonHostToTargetDistance GetRootAsICommonHostToTargetDistance(ByteBuffer _bb)
		{
			return ICommonHostToTargetDistance.GetRootAsICommonHostToTargetDistance(_bb, default(ICommonHostToTargetDistance));
		}

		// Token: 0x06015846 RID: 88134 RVA: 0x0031A460 File Offset: 0x00318660
		public static ICommonHostToTargetDistance GetRootAsICommonHostToTargetDistance(ByteBuffer _bb, ICommonHostToTargetDistance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015847 RID: 88135 RVA: 0x0031A47D File Offset: 0x0031867D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015848 RID: 88136 RVA: 0x0031A48C File Offset: 0x0031868C
		public ICommonHostToTargetDistance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BD5 RID: 27605
		// (get) Token: 0x06015849 RID: 88137 RVA: 0x0031A49C File Offset: 0x0031869C
		public ESystemVarName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemVarName.CommonHotFixVar;
				}
				return (ESystemVarName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006BD6 RID: 27606
		// (get) Token: 0x0601584A RID: 88138 RVA: 0x0031A4D8 File Offset: 0x003186D8
		public IPosA? Pos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006BD7 RID: 27607
		// (get) Token: 0x0601584B RID: 88139 RVA: 0x0031A538 File Offset: 0x00318738
		public EDistanceMeasureMode DistanceMeasureMode
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EDistanceMeasureMode.Horizontal;
				}
				return (EDistanceMeasureMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601584C RID: 88140 RVA: 0x0031A574 File Offset: 0x00318774
		public static Offset<ICommonHostToTargetDistance> CreateICommonHostToTargetDistance(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar, Offset<IPosA> PosOffset = default(Offset<IPosA>), EDistanceMeasureMode DistanceMeasureMode = EDistanceMeasureMode.Horizontal)
		{
			builder.StartTable(3);
			ICommonHostToTargetDistance.AddPos(builder, PosOffset);
			ICommonHostToTargetDistance.AddDistanceMeasureMode(builder, DistanceMeasureMode);
			ICommonHostToTargetDistance.AddType(builder, Type);
			return ICommonHostToTargetDistance.EndICommonHostToTargetDistance(builder);
		}

		// Token: 0x0601584D RID: 88141 RVA: 0x0031A598 File Offset: 0x00318798
		public static void StartICommonHostToTargetDistance(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601584E RID: 88142 RVA: 0x0031A5A1 File Offset: 0x003187A1
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601584F RID: 88143 RVA: 0x0031A5AC File Offset: 0x003187AC
		public static void AddPos(FlatBufferBuilder builder, Offset<IPosA> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x06015850 RID: 88144 RVA: 0x0031A5BC File Offset: 0x003187BC
		public static void AddDistanceMeasureMode(FlatBufferBuilder builder, EDistanceMeasureMode distanceMeasureMode)
		{
			builder.AddByte(2, (byte)distanceMeasureMode, 0);
		}

		// Token: 0x06015851 RID: 88145 RVA: 0x0031A5C7 File Offset: 0x003187C7
		public static Offset<ICommonHostToTargetDistance> EndICommonHostToTargetDistance(FlatBufferBuilder builder)
		{
			return new Offset<ICommonHostToTargetDistance>(builder.EndTable());
		}

		// Token: 0x06015852 RID: 88146 RVA: 0x0031A5D4 File Offset: 0x003187D4
		public ICommonHostToTargetDistanceT UnPack()
		{
			ICommonHostToTargetDistanceT commonHostToTargetDistanceT = new ICommonHostToTargetDistanceT();
			this.UnPackTo(commonHostToTargetDistanceT);
			return commonHostToTargetDistanceT;
		}

		// Token: 0x06015853 RID: 88147 RVA: 0x0031A5F0 File Offset: 0x003187F0
		public void UnPackTo(ICommonHostToTargetDistanceT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.DistanceMeasureMode = this.DistanceMeasureMode;
		}

		// Token: 0x06015854 RID: 88148 RVA: 0x0031A644 File Offset: 0x00318844
		public static Offset<ICommonHostToTargetDistance> Pack(FlatBufferBuilder builder, ICommonHostToTargetDistanceT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonHostToTargetDistance>);
			}
			Offset<IPosA> posOffset = (_o.Pos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.Pos);
			return ICommonHostToTargetDistance.CreateICommonHostToTargetDistance(builder, _o.Type, posOffset, _o.DistanceMeasureMode);
		}

		// Token: 0x0400B828 RID: 47144
		private Table __p;
	}
}
