using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A8A RID: 14986
	public struct ICommonHostToTargetDistance : IFlatbufferObject
	{
		// Token: 0x170066A4 RID: 26276
		// (get) Token: 0x06014527 RID: 83239 RVA: 0x002F7244 File Offset: 0x002F5444
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014528 RID: 83240 RVA: 0x002F7251 File Offset: 0x002F5451
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014529 RID: 83241 RVA: 0x002F7258 File Offset: 0x002F5458
		public static ICommonHostToTargetDistance GetRootAsICommonHostToTargetDistance(ByteBuffer _bb)
		{
			return ICommonHostToTargetDistance.GetRootAsICommonHostToTargetDistance(_bb, default(ICommonHostToTargetDistance));
		}

		// Token: 0x0601452A RID: 83242 RVA: 0x002F7274 File Offset: 0x002F5474
		public static ICommonHostToTargetDistance GetRootAsICommonHostToTargetDistance(ByteBuffer _bb, ICommonHostToTargetDistance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601452B RID: 83243 RVA: 0x002F7291 File Offset: 0x002F5491
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601452C RID: 83244 RVA: 0x002F72A0 File Offset: 0x002F54A0
		public ICommonHostToTargetDistance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170066A5 RID: 26277
		// (get) Token: 0x0601452D RID: 83245 RVA: 0x002F72B0 File Offset: 0x002F54B0
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

		// Token: 0x170066A6 RID: 26278
		// (get) Token: 0x0601452E RID: 83246 RVA: 0x002F72EC File Offset: 0x002F54EC
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

		// Token: 0x170066A7 RID: 26279
		// (get) Token: 0x0601452F RID: 83247 RVA: 0x002F734C File Offset: 0x002F554C
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

		// Token: 0x06014530 RID: 83248 RVA: 0x002F7388 File Offset: 0x002F5588
		public static Offset<ICommonHostToTargetDistance> CreateICommonHostToTargetDistance(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar, Offset<IPosA> PosOffset = default(Offset<IPosA>), EDistanceMeasureMode DistanceMeasureMode = EDistanceMeasureMode.Horizontal)
		{
			builder.StartTable(3);
			ICommonHostToTargetDistance.AddPos(builder, PosOffset);
			ICommonHostToTargetDistance.AddDistanceMeasureMode(builder, DistanceMeasureMode);
			ICommonHostToTargetDistance.AddType(builder, Type);
			return ICommonHostToTargetDistance.EndICommonHostToTargetDistance(builder);
		}

		// Token: 0x06014531 RID: 83249 RVA: 0x002F73AC File Offset: 0x002F55AC
		public static void StartICommonHostToTargetDistance(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06014532 RID: 83250 RVA: 0x002F73B5 File Offset: 0x002F55B5
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014533 RID: 83251 RVA: 0x002F73C0 File Offset: 0x002F55C0
		public static void AddPos(FlatBufferBuilder builder, Offset<IPosA> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x06014534 RID: 83252 RVA: 0x002F73D0 File Offset: 0x002F55D0
		public static void AddDistanceMeasureMode(FlatBufferBuilder builder, EDistanceMeasureMode distanceMeasureMode)
		{
			builder.AddByte(2, (byte)distanceMeasureMode, 0);
		}

		// Token: 0x06014535 RID: 83253 RVA: 0x002F73DB File Offset: 0x002F55DB
		public static Offset<ICommonHostToTargetDistance> EndICommonHostToTargetDistance(FlatBufferBuilder builder)
		{
			return new Offset<ICommonHostToTargetDistance>(builder.EndTable());
		}

		// Token: 0x06014536 RID: 83254 RVA: 0x002F73E8 File Offset: 0x002F55E8
		public ICommonHostToTargetDistanceT UnPack()
		{
			ICommonHostToTargetDistanceT commonHostToTargetDistanceT = new ICommonHostToTargetDistanceT();
			this.UnPackTo(commonHostToTargetDistanceT);
			return commonHostToTargetDistanceT;
		}

		// Token: 0x06014537 RID: 83255 RVA: 0x002F7404 File Offset: 0x002F5604
		public void UnPackTo(ICommonHostToTargetDistanceT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.DistanceMeasureMode = this.DistanceMeasureMode;
		}

		// Token: 0x06014538 RID: 83256 RVA: 0x002F7458 File Offset: 0x002F5658
		public static Offset<ICommonHostToTargetDistance> Pack(FlatBufferBuilder builder, ICommonHostToTargetDistanceT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonHostToTargetDistance>);
			}
			Offset<IPosA> posOffset = (_o.Pos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.Pos);
			return ICommonHostToTargetDistance.CreateICommonHostToTargetDistance(builder, _o.Type, posOffset, _o.DistanceMeasureMode);
		}

		// Token: 0x0400AF06 RID: 44806
		private Table __p;
	}
}
