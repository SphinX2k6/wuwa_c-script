using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065EB RID: 26091
	public struct IDisableMoveOperation : IFlatbufferObject
	{
		// Token: 0x1700C1BD RID: 49597
		// (get) Token: 0x0602D467 RID: 185447 RVA: 0x00634A9D File Offset: 0x00632C9D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D468 RID: 185448 RVA: 0x00634AAA File Offset: 0x00632CAA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D469 RID: 185449 RVA: 0x00634AB4 File Offset: 0x00632CB4
		public static IDisableMoveOperation GetRootAsIDisableMoveOperation(ByteBuffer _bb)
		{
			return IDisableMoveOperation.GetRootAsIDisableMoveOperation(_bb, default(IDisableMoveOperation));
		}

		// Token: 0x0602D46A RID: 185450 RVA: 0x00634AD0 File Offset: 0x00632CD0
		public static IDisableMoveOperation GetRootAsIDisableMoveOperation(ByteBuffer _bb, IDisableMoveOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D46B RID: 185451 RVA: 0x00634AED File Offset: 0x00632CED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D46C RID: 185452 RVA: 0x00634AFC File Offset: 0x00632CFC
		public IDisableMoveOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C1BE RID: 49598
		// (get) Token: 0x0602D46D RID: 185453 RVA: 0x00634B0C File Offset: 0x00632D0C
		public EMoveOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMoveOperationType.Enable;
				}
				return (EMoveOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C1BF RID: 49599
		// (get) Token: 0x0602D46E RID: 185454 RVA: 0x00634B48 File Offset: 0x00632D48
		public bool Forward
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C1C0 RID: 49600
		// (get) Token: 0x0602D46F RID: 185455 RVA: 0x00634B88 File Offset: 0x00632D88
		public bool Back
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C1C1 RID: 49601
		// (get) Token: 0x0602D470 RID: 185456 RVA: 0x00634BC8 File Offset: 0x00632DC8
		public bool Left
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C1C2 RID: 49602
		// (get) Token: 0x0602D471 RID: 185457 RVA: 0x00634C08 File Offset: 0x00632E08
		public bool Right
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C1C3 RID: 49603
		// (get) Token: 0x0602D472 RID: 185458 RVA: 0x00634C48 File Offset: 0x00632E48
		public bool ForceWalk
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C1C4 RID: 49604
		// (get) Token: 0x0602D473 RID: 185459 RVA: 0x00634C88 File Offset: 0x00632E88
		public bool ForceJog
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C1C5 RID: 49605
		// (get) Token: 0x0602D474 RID: 185460 RVA: 0x00634CC8 File Offset: 0x00632EC8
		public bool ForbidSprint
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C1C6 RID: 49606
		// (get) Token: 0x0602D475 RID: 185461 RVA: 0x00634D08 File Offset: 0x00632F08
		public bool ForbidAndDisableSprint
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C1C7 RID: 49607
		// (get) Token: 0x0602D476 RID: 185462 RVA: 0x00634D48 File Offset: 0x00632F48
		public bool ForbidAndDisableMotorcycleSprint
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C1C8 RID: 49608
		// (get) Token: 0x0602D477 RID: 185463 RVA: 0x00634D88 File Offset: 0x00632F88
		public bool DisableClimbAndStep
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C1C9 RID: 49609
		// (get) Token: 0x0602D478 RID: 185464 RVA: 0x00634DC8 File Offset: 0x00632FC8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D479 RID: 185465 RVA: 0x00634E08 File Offset: 0x00633008
		public static Offset<IDisableMoveOperation> CreateIDisableMoveOperation(FlatBufferBuilder builder, EMoveOperationType Type = EMoveOperationType.Enable, bool Forward = false, bool Back = false, bool Left = false, bool Right = false, bool ForceWalk = false, bool ForceJog = false, bool ForbidSprint = false, bool ForbidAndDisableSprint = false, bool ForbidAndDisableMotorcycleSprint = false, bool DisableClimbAndStep = false, byte NullMask = 0)
		{
			builder.StartTable(12);
			IDisableMoveOperation.AddNullMask(builder, NullMask);
			IDisableMoveOperation.AddDisableClimbAndStep(builder, DisableClimbAndStep);
			IDisableMoveOperation.AddForbidAndDisableMotorcycleSprint(builder, ForbidAndDisableMotorcycleSprint);
			IDisableMoveOperation.AddForbidAndDisableSprint(builder, ForbidAndDisableSprint);
			IDisableMoveOperation.AddForbidSprint(builder, ForbidSprint);
			IDisableMoveOperation.AddForceJog(builder, ForceJog);
			IDisableMoveOperation.AddForceWalk(builder, ForceWalk);
			IDisableMoveOperation.AddRight(builder, Right);
			IDisableMoveOperation.AddLeft(builder, Left);
			IDisableMoveOperation.AddBack(builder, Back);
			IDisableMoveOperation.AddForward(builder, Forward);
			IDisableMoveOperation.AddType(builder, Type);
			return IDisableMoveOperation.EndIDisableMoveOperation(builder);
		}

		// Token: 0x0602D47A RID: 185466 RVA: 0x00634E80 File Offset: 0x00633080
		public static void StartIDisableMoveOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x0602D47B RID: 185467 RVA: 0x00634E8A File Offset: 0x0063308A
		public static void AddType(FlatBufferBuilder builder, EMoveOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D47C RID: 185468 RVA: 0x00634E95 File Offset: 0x00633095
		public static void AddForward(FlatBufferBuilder builder, bool forward)
		{
			builder.AddBool(1, forward, false);
		}

		// Token: 0x0602D47D RID: 185469 RVA: 0x00634EA0 File Offset: 0x006330A0
		public static void AddBack(FlatBufferBuilder builder, bool back)
		{
			builder.AddBool(2, back, false);
		}

		// Token: 0x0602D47E RID: 185470 RVA: 0x00634EAB File Offset: 0x006330AB
		public static void AddLeft(FlatBufferBuilder builder, bool left)
		{
			builder.AddBool(3, left, false);
		}

		// Token: 0x0602D47F RID: 185471 RVA: 0x00634EB6 File Offset: 0x006330B6
		public static void AddRight(FlatBufferBuilder builder, bool right)
		{
			builder.AddBool(4, right, false);
		}

		// Token: 0x0602D480 RID: 185472 RVA: 0x00634EC1 File Offset: 0x006330C1
		public static void AddForceWalk(FlatBufferBuilder builder, bool forceWalk)
		{
			builder.AddBool(5, forceWalk, false);
		}

		// Token: 0x0602D481 RID: 185473 RVA: 0x00634ECC File Offset: 0x006330CC
		public static void AddForceJog(FlatBufferBuilder builder, bool forceJog)
		{
			builder.AddBool(6, forceJog, false);
		}

		// Token: 0x0602D482 RID: 185474 RVA: 0x00634ED7 File Offset: 0x006330D7
		public static void AddForbidSprint(FlatBufferBuilder builder, bool forbidSprint)
		{
			builder.AddBool(7, forbidSprint, false);
		}

		// Token: 0x0602D483 RID: 185475 RVA: 0x00634EE2 File Offset: 0x006330E2
		public static void AddForbidAndDisableSprint(FlatBufferBuilder builder, bool forbidAndDisableSprint)
		{
			builder.AddBool(8, forbidAndDisableSprint, false);
		}

		// Token: 0x0602D484 RID: 185476 RVA: 0x00634EED File Offset: 0x006330ED
		public static void AddForbidAndDisableMotorcycleSprint(FlatBufferBuilder builder, bool forbidAndDisableMotorcycleSprint)
		{
			builder.AddBool(9, forbidAndDisableMotorcycleSprint, false);
		}

		// Token: 0x0602D485 RID: 185477 RVA: 0x00634EF9 File Offset: 0x006330F9
		public static void AddDisableClimbAndStep(FlatBufferBuilder builder, bool disableClimbAndStep)
		{
			builder.AddBool(10, disableClimbAndStep, false);
		}

		// Token: 0x0602D486 RID: 185478 RVA: 0x00634F05 File Offset: 0x00633105
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(11, nullMask, 0);
		}

		// Token: 0x0602D487 RID: 185479 RVA: 0x00634F11 File Offset: 0x00633111
		public static Offset<IDisableMoveOperation> EndIDisableMoveOperation(FlatBufferBuilder builder)
		{
			return new Offset<IDisableMoveOperation>(builder.EndTable());
		}

		// Token: 0x0602D488 RID: 185480 RVA: 0x00634F20 File Offset: 0x00633120
		public IDisableMoveOperationT UnPack()
		{
			IDisableMoveOperationT disableMoveOperationT = new IDisableMoveOperationT();
			this.UnPackTo(disableMoveOperationT);
			return disableMoveOperationT;
		}

		// Token: 0x0602D489 RID: 185481 RVA: 0x00634F3C File Offset: 0x0063313C
		public void UnPackTo(IDisableMoveOperationT _o)
		{
			_o.Type = this.Type;
			_o.Forward = this.Forward;
			_o.Back = this.Back;
			_o.Left = this.Left;
			_o.Right = this.Right;
			_o.ForceWalk = this.ForceWalk;
			_o.ForceJog = this.ForceJog;
			_o.ForbidSprint = this.ForbidSprint;
			_o.ForbidAndDisableSprint = this.ForbidAndDisableSprint;
			_o.ForbidAndDisableMotorcycleSprint = this.ForbidAndDisableMotorcycleSprint;
			_o.DisableClimbAndStep = this.DisableClimbAndStep;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D48A RID: 185482 RVA: 0x00634FDC File Offset: 0x006331DC
		public static Offset<IDisableMoveOperation> Pack(FlatBufferBuilder builder, IDisableMoveOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableMoveOperation>);
			}
			return IDisableMoveOperation.CreateIDisableMoveOperation(builder, _o.Type, _o.Forward, _o.Back, _o.Left, _o.Right, _o.ForceWalk, _o.ForceJog, _o.ForbidSprint, _o.ForbidAndDisableSprint, _o.ForbidAndDisableMotorcycleSprint, _o.DisableClimbAndStep, _o.NullMask);
		}

		// Token: 0x04010C5E RID: 68702
		private Table __p;
	}
}
