using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200799B RID: 31131
	public struct IStateProgramSpecialProcessChangeTeamOptimization : IFlatbufferObject
	{
		// Token: 0x1700E463 RID: 58467
		// (get) Token: 0x06036DB4 RID: 224692 RVA: 0x00756712 File Offset: 0x00754912
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036DB5 RID: 224693 RVA: 0x0075671F File Offset: 0x0075491F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036DB6 RID: 224694 RVA: 0x00756728 File Offset: 0x00754928
		public static IStateProgramSpecialProcessChangeTeamOptimization GetRootAsIStateProgramSpecialProcessChangeTeamOptimization(ByteBuffer _bb)
		{
			return IStateProgramSpecialProcessChangeTeamOptimization.GetRootAsIStateProgramSpecialProcessChangeTeamOptimization(_bb, default(IStateProgramSpecialProcessChangeTeamOptimization));
		}

		// Token: 0x06036DB7 RID: 224695 RVA: 0x00756744 File Offset: 0x00754944
		public static IStateProgramSpecialProcessChangeTeamOptimization GetRootAsIStateProgramSpecialProcessChangeTeamOptimization(ByteBuffer _bb, IStateProgramSpecialProcessChangeTeamOptimization obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036DB8 RID: 224696 RVA: 0x00756761 File Offset: 0x00754961
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036DB9 RID: 224697 RVA: 0x00756770 File Offset: 0x00754970
		public IStateProgramSpecialProcessChangeTeamOptimization __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E464 RID: 58468
		// (get) Token: 0x06036DBA RID: 224698 RVA: 0x00756780 File Offset: 0x00754980
		public ELogicProgramSpecialProcess Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELogicProgramSpecialProcess.ChangeTeamOptimization;
				}
				return (ELogicProgramSpecialProcess)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E465 RID: 58469
		// (get) Token: 0x06036DBB RID: 224699 RVA: 0x007567BC File Offset: 0x007549BC
		public bool IsOpenBlackScreen
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E466 RID: 58470
		// (get) Token: 0x06036DBC RID: 224700 RVA: 0x007567FC File Offset: 0x007549FC
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

		// Token: 0x06036DBD RID: 224701 RVA: 0x00756838 File Offset: 0x00754A38
		public static Offset<IStateProgramSpecialProcessChangeTeamOptimization> CreateIStateProgramSpecialProcessChangeTeamOptimization(FlatBufferBuilder builder, ELogicProgramSpecialProcess Type = ELogicProgramSpecialProcess.ChangeTeamOptimization, bool IsOpenBlackScreen = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IStateProgramSpecialProcessChangeTeamOptimization.AddNullMask(builder, NullMask);
			IStateProgramSpecialProcessChangeTeamOptimization.AddIsOpenBlackScreen(builder, IsOpenBlackScreen);
			IStateProgramSpecialProcessChangeTeamOptimization.AddType(builder, Type);
			return IStateProgramSpecialProcessChangeTeamOptimization.EndIStateProgramSpecialProcessChangeTeamOptimization(builder);
		}

		// Token: 0x06036DBE RID: 224702 RVA: 0x0075685C File Offset: 0x00754A5C
		public static void StartIStateProgramSpecialProcessChangeTeamOptimization(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036DBF RID: 224703 RVA: 0x00756865 File Offset: 0x00754A65
		public static void AddType(FlatBufferBuilder builder, ELogicProgramSpecialProcess type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036DC0 RID: 224704 RVA: 0x00756870 File Offset: 0x00754A70
		public static void AddIsOpenBlackScreen(FlatBufferBuilder builder, bool isOpenBlackScreen)
		{
			builder.AddBool(1, isOpenBlackScreen, false);
		}

		// Token: 0x06036DC1 RID: 224705 RVA: 0x0075687B File Offset: 0x00754A7B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06036DC2 RID: 224706 RVA: 0x00756886 File Offset: 0x00754A86
		public static Offset<IStateProgramSpecialProcessChangeTeamOptimization> EndIStateProgramSpecialProcessChangeTeamOptimization(FlatBufferBuilder builder)
		{
			return new Offset<IStateProgramSpecialProcessChangeTeamOptimization>(builder.EndTable());
		}

		// Token: 0x06036DC3 RID: 224707 RVA: 0x00756894 File Offset: 0x00754A94
		public IStateProgramSpecialProcessChangeTeamOptimizationT UnPack()
		{
			IStateProgramSpecialProcessChangeTeamOptimizationT stateProgramSpecialProcessChangeTeamOptimizationT = new IStateProgramSpecialProcessChangeTeamOptimizationT();
			this.UnPackTo(stateProgramSpecialProcessChangeTeamOptimizationT);
			return stateProgramSpecialProcessChangeTeamOptimizationT;
		}

		// Token: 0x06036DC4 RID: 224708 RVA: 0x007568AF File Offset: 0x00754AAF
		public void UnPackTo(IStateProgramSpecialProcessChangeTeamOptimizationT _o)
		{
			_o.Type = this.Type;
			_o.IsOpenBlackScreen = this.IsOpenBlackScreen;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036DC5 RID: 224709 RVA: 0x007568D8 File Offset: 0x00754AD8
		public static Offset<IStateProgramSpecialProcessChangeTeamOptimization> Pack(FlatBufferBuilder builder, IStateProgramSpecialProcessChangeTeamOptimizationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStateProgramSpecialProcessChangeTeamOptimization>);
			}
			return IStateProgramSpecialProcessChangeTeamOptimization.CreateIStateProgramSpecialProcessChangeTeamOptimization(builder, _o.Type, _o.IsOpenBlackScreen, _o.NullMask);
		}

		// Token: 0x04012CAB RID: 76971
		private Table __p;
	}
}
