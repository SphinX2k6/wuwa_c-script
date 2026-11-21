using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C56 RID: 27734
	public struct IDisableMoveOperation : IFlatbufferObject
	{
		// Token: 0x1700CB55 RID: 52053
		// (get) Token: 0x0602FC14 RID: 195604 RVA: 0x00681318 File Offset: 0x0067F518
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FC15 RID: 195605 RVA: 0x00681325 File Offset: 0x0067F525
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FC16 RID: 195606 RVA: 0x0068132C File Offset: 0x0067F52C
		public static IDisableMoveOperation GetRootAsIDisableMoveOperation(ByteBuffer _bb)
		{
			return IDisableMoveOperation.GetRootAsIDisableMoveOperation(_bb, default(IDisableMoveOperation));
		}

		// Token: 0x0602FC17 RID: 195607 RVA: 0x00681348 File Offset: 0x0067F548
		public static IDisableMoveOperation GetRootAsIDisableMoveOperation(ByteBuffer _bb, IDisableMoveOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FC18 RID: 195608 RVA: 0x00681365 File Offset: 0x0067F565
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FC19 RID: 195609 RVA: 0x00681374 File Offset: 0x0067F574
		public IDisableMoveOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB56 RID: 52054
		// (get) Token: 0x0602FC1A RID: 195610 RVA: 0x00681384 File Offset: 0x0067F584
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

		// Token: 0x1700CB57 RID: 52055
		// (get) Token: 0x0602FC1B RID: 195611 RVA: 0x006813C0 File Offset: 0x0067F5C0
		public bool Forward
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB58 RID: 52056
		// (get) Token: 0x0602FC1C RID: 195612 RVA: 0x00681400 File Offset: 0x0067F600
		public bool Back
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB59 RID: 52057
		// (get) Token: 0x0602FC1D RID: 195613 RVA: 0x00681440 File Offset: 0x0067F640
		public bool Left
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB5A RID: 52058
		// (get) Token: 0x0602FC1E RID: 195614 RVA: 0x00681480 File Offset: 0x0067F680
		public bool Right
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB5B RID: 52059
		// (get) Token: 0x0602FC1F RID: 195615 RVA: 0x006814C0 File Offset: 0x0067F6C0
		public bool ForceWalk
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB5C RID: 52060
		// (get) Token: 0x0602FC20 RID: 195616 RVA: 0x00681500 File Offset: 0x0067F700
		public bool ForceJog
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB5D RID: 52061
		// (get) Token: 0x0602FC21 RID: 195617 RVA: 0x00681540 File Offset: 0x0067F740
		public bool ForbidSprint
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB5E RID: 52062
		// (get) Token: 0x0602FC22 RID: 195618 RVA: 0x00681580 File Offset: 0x0067F780
		public bool ForbidAndDisableSprint
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB5F RID: 52063
		// (get) Token: 0x0602FC23 RID: 195619 RVA: 0x006815C0 File Offset: 0x0067F7C0
		public bool ForbidAndDisableMotorcycleSprint
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB60 RID: 52064
		// (get) Token: 0x0602FC24 RID: 195620 RVA: 0x00681600 File Offset: 0x0067F800
		public bool DisableClimbAndStep
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB61 RID: 52065
		// (get) Token: 0x0602FC25 RID: 195621 RVA: 0x00681640 File Offset: 0x0067F840
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

		// Token: 0x0602FC26 RID: 195622 RVA: 0x00681680 File Offset: 0x0067F880
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

		// Token: 0x0602FC27 RID: 195623 RVA: 0x006816F8 File Offset: 0x0067F8F8
		public static void StartIDisableMoveOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x0602FC28 RID: 195624 RVA: 0x00681702 File Offset: 0x0067F902
		public static void AddType(FlatBufferBuilder builder, EMoveOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FC29 RID: 195625 RVA: 0x0068170D File Offset: 0x0067F90D
		public static void AddForward(FlatBufferBuilder builder, bool forward)
		{
			builder.AddBool(1, forward, false);
		}

		// Token: 0x0602FC2A RID: 195626 RVA: 0x00681718 File Offset: 0x0067F918
		public static void AddBack(FlatBufferBuilder builder, bool back)
		{
			builder.AddBool(2, back, false);
		}

		// Token: 0x0602FC2B RID: 195627 RVA: 0x00681723 File Offset: 0x0067F923
		public static void AddLeft(FlatBufferBuilder builder, bool left)
		{
			builder.AddBool(3, left, false);
		}

		// Token: 0x0602FC2C RID: 195628 RVA: 0x0068172E File Offset: 0x0067F92E
		public static void AddRight(FlatBufferBuilder builder, bool right)
		{
			builder.AddBool(4, right, false);
		}

		// Token: 0x0602FC2D RID: 195629 RVA: 0x00681739 File Offset: 0x0067F939
		public static void AddForceWalk(FlatBufferBuilder builder, bool forceWalk)
		{
			builder.AddBool(5, forceWalk, false);
		}

		// Token: 0x0602FC2E RID: 195630 RVA: 0x00681744 File Offset: 0x0067F944
		public static void AddForceJog(FlatBufferBuilder builder, bool forceJog)
		{
			builder.AddBool(6, forceJog, false);
		}

		// Token: 0x0602FC2F RID: 195631 RVA: 0x0068174F File Offset: 0x0067F94F
		public static void AddForbidSprint(FlatBufferBuilder builder, bool forbidSprint)
		{
			builder.AddBool(7, forbidSprint, false);
		}

		// Token: 0x0602FC30 RID: 195632 RVA: 0x0068175A File Offset: 0x0067F95A
		public static void AddForbidAndDisableSprint(FlatBufferBuilder builder, bool forbidAndDisableSprint)
		{
			builder.AddBool(8, forbidAndDisableSprint, false);
		}

		// Token: 0x0602FC31 RID: 195633 RVA: 0x00681765 File Offset: 0x0067F965
		public static void AddForbidAndDisableMotorcycleSprint(FlatBufferBuilder builder, bool forbidAndDisableMotorcycleSprint)
		{
			builder.AddBool(9, forbidAndDisableMotorcycleSprint, false);
		}

		// Token: 0x0602FC32 RID: 195634 RVA: 0x00681771 File Offset: 0x0067F971
		public static void AddDisableClimbAndStep(FlatBufferBuilder builder, bool disableClimbAndStep)
		{
			builder.AddBool(10, disableClimbAndStep, false);
		}

		// Token: 0x0602FC33 RID: 195635 RVA: 0x0068177D File Offset: 0x0067F97D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(11, nullMask, 0);
		}

		// Token: 0x0602FC34 RID: 195636 RVA: 0x00681789 File Offset: 0x0067F989
		public static Offset<IDisableMoveOperation> EndIDisableMoveOperation(FlatBufferBuilder builder)
		{
			return new Offset<IDisableMoveOperation>(builder.EndTable());
		}

		// Token: 0x0602FC35 RID: 195637 RVA: 0x00681798 File Offset: 0x0067F998
		public IDisableMoveOperationT UnPack()
		{
			IDisableMoveOperationT disableMoveOperationT = new IDisableMoveOperationT();
			this.UnPackTo(disableMoveOperationT);
			return disableMoveOperationT;
		}

		// Token: 0x0602FC36 RID: 195638 RVA: 0x006817B4 File Offset: 0x0067F9B4
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

		// Token: 0x0602FC37 RID: 195639 RVA: 0x00681854 File Offset: 0x0067FA54
		public static Offset<IDisableMoveOperation> Pack(FlatBufferBuilder builder, IDisableMoveOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableMoveOperation>);
			}
			return IDisableMoveOperation.CreateIDisableMoveOperation(builder, _o.Type, _o.Forward, _o.Back, _o.Left, _o.Right, _o.ForceWalk, _o.ForceJog, _o.ForbidSprint, _o.ForbidAndDisableSprint, _o.ForbidAndDisableMotorcycleSprint, _o.DisableClimbAndStep, _o.NullMask);
		}

		// Token: 0x04011A75 RID: 72309
		private Table __p;
	}
}
