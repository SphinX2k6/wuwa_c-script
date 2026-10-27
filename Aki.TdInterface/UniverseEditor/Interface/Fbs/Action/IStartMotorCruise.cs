using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071B1 RID: 29105
	public struct IStartMotorCruise : IFlatbufferObject
	{
		// Token: 0x1700D827 RID: 55335
		// (get) Token: 0x060339BC RID: 211388 RVA: 0x006F323A File Offset: 0x006F143A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060339BD RID: 211389 RVA: 0x006F3247 File Offset: 0x006F1447
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060339BE RID: 211390 RVA: 0x006F3250 File Offset: 0x006F1450
		public static IStartMotorCruise GetRootAsIStartMotorCruise(ByteBuffer _bb)
		{
			return IStartMotorCruise.GetRootAsIStartMotorCruise(_bb, default(IStartMotorCruise));
		}

		// Token: 0x060339BF RID: 211391 RVA: 0x006F326C File Offset: 0x006F146C
		public static IStartMotorCruise GetRootAsIStartMotorCruise(ByteBuffer _bb, IStartMotorCruise obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060339C0 RID: 211392 RVA: 0x006F3289 File Offset: 0x006F1489
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060339C1 RID: 211393 RVA: 0x006F3298 File Offset: 0x006F1498
		public IStartMotorCruise __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D828 RID: 55336
		// (get) Token: 0x060339C2 RID: 211394 RVA: 0x006F32A8 File Offset: 0x006F14A8
		public ISplineWayPoint? StartPoint
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ISplineWayPoint?(default(ISplineWayPoint).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D829 RID: 55337
		// (get) Token: 0x060339C3 RID: 211395 RVA: 0x006F3308 File Offset: 0x006F1508
		public ISplineWayPoint? EndPoint
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ISplineWayPoint?(default(ISplineWayPoint).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D82A RID: 55338
		// (get) Token: 0x060339C4 RID: 211396 RVA: 0x006F3368 File Offset: 0x006F1568
		public bool AllowSkip
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060339C5 RID: 211397 RVA: 0x006F33A7 File Offset: 0x006F15A7
		public static Offset<IStartMotorCruise> CreateIStartMotorCruise(FlatBufferBuilder builder, Offset<ISplineWayPoint> StartPointOffset = default(Offset<ISplineWayPoint>), Offset<ISplineWayPoint> EndPointOffset = default(Offset<ISplineWayPoint>), bool AllowSkip = false)
		{
			builder.StartTable(3);
			IStartMotorCruise.AddEndPoint(builder, EndPointOffset);
			IStartMotorCruise.AddStartPoint(builder, StartPointOffset);
			IStartMotorCruise.AddAllowSkip(builder, AllowSkip);
			return IStartMotorCruise.EndIStartMotorCruise(builder);
		}

		// Token: 0x060339C6 RID: 211398 RVA: 0x006F33CB File Offset: 0x006F15CB
		public static void StartIStartMotorCruise(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060339C7 RID: 211399 RVA: 0x006F33D4 File Offset: 0x006F15D4
		public static void AddStartPoint(FlatBufferBuilder builder, Offset<ISplineWayPoint> startPointOffset)
		{
			builder.AddOffset(0, startPointOffset.Value, 0);
		}

		// Token: 0x060339C8 RID: 211400 RVA: 0x006F33E4 File Offset: 0x006F15E4
		public static void AddEndPoint(FlatBufferBuilder builder, Offset<ISplineWayPoint> endPointOffset)
		{
			builder.AddOffset(1, endPointOffset.Value, 0);
		}

		// Token: 0x060339C9 RID: 211401 RVA: 0x006F33F4 File Offset: 0x006F15F4
		public static void AddAllowSkip(FlatBufferBuilder builder, bool allowSkip)
		{
			builder.AddBool(2, allowSkip, false);
		}

		// Token: 0x060339CA RID: 211402 RVA: 0x006F33FF File Offset: 0x006F15FF
		public static Offset<IStartMotorCruise> EndIStartMotorCruise(FlatBufferBuilder builder)
		{
			return new Offset<IStartMotorCruise>(builder.EndTable());
		}

		// Token: 0x060339CB RID: 211403 RVA: 0x006F340C File Offset: 0x006F160C
		public IStartMotorCruiseT UnPack()
		{
			IStartMotorCruiseT startMotorCruiseT = new IStartMotorCruiseT();
			this.UnPackTo(startMotorCruiseT);
			return startMotorCruiseT;
		}

		// Token: 0x060339CC RID: 211404 RVA: 0x006F3428 File Offset: 0x006F1628
		public void UnPackTo(IStartMotorCruiseT _o)
		{
			_o.StartPoint = ((this.StartPoint != null) ? this.StartPoint.Value.UnPack() : null);
			_o.EndPoint = ((this.EndPoint != null) ? this.EndPoint.Value.UnPack() : null);
			_o.AllowSkip = this.AllowSkip;
		}

		// Token: 0x060339CD RID: 211405 RVA: 0x006F34A0 File Offset: 0x006F16A0
		public static Offset<IStartMotorCruise> Pack(FlatBufferBuilder builder, IStartMotorCruiseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStartMotorCruise>);
			}
			Offset<ISplineWayPoint> startPointOffset = (_o.StartPoint == null) ? default(Offset<ISplineWayPoint>) : ISplineWayPoint.Pack(builder, _o.StartPoint);
			Offset<ISplineWayPoint> endPointOffset = (_o.EndPoint == null) ? default(Offset<ISplineWayPoint>) : ISplineWayPoint.Pack(builder, _o.EndPoint);
			return IStartMotorCruise.CreateIStartMotorCruise(builder, startPointOffset, endPointOffset, _o.AllowSkip);
		}

		// Token: 0x04011C7B RID: 72827
		private Table __p;
	}
}
