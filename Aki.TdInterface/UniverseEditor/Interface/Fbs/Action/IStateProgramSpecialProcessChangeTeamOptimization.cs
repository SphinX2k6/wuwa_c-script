using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071C6 RID: 29126
	public struct IStateProgramSpecialProcessChangeTeamOptimization : IFlatbufferObject
	{
		// Token: 0x1700D86A RID: 55402
		// (get) Token: 0x06033AB2 RID: 211634 RVA: 0x006F53B2 File Offset: 0x006F35B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033AB3 RID: 211635 RVA: 0x006F53BF File Offset: 0x006F35BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033AB4 RID: 211636 RVA: 0x006F53C8 File Offset: 0x006F35C8
		public static IStateProgramSpecialProcessChangeTeamOptimization GetRootAsIStateProgramSpecialProcessChangeTeamOptimization(ByteBuffer _bb)
		{
			return IStateProgramSpecialProcessChangeTeamOptimization.GetRootAsIStateProgramSpecialProcessChangeTeamOptimization(_bb, default(IStateProgramSpecialProcessChangeTeamOptimization));
		}

		// Token: 0x06033AB5 RID: 211637 RVA: 0x006F53E4 File Offset: 0x006F35E4
		public static IStateProgramSpecialProcessChangeTeamOptimization GetRootAsIStateProgramSpecialProcessChangeTeamOptimization(ByteBuffer _bb, IStateProgramSpecialProcessChangeTeamOptimization obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033AB6 RID: 211638 RVA: 0x006F5401 File Offset: 0x006F3601
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033AB7 RID: 211639 RVA: 0x006F5410 File Offset: 0x006F3610
		public IStateProgramSpecialProcessChangeTeamOptimization __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D86B RID: 55403
		// (get) Token: 0x06033AB8 RID: 211640 RVA: 0x006F5420 File Offset: 0x006F3620
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

		// Token: 0x1700D86C RID: 55404
		// (get) Token: 0x06033AB9 RID: 211641 RVA: 0x006F545C File Offset: 0x006F365C
		public bool IsOpenBlackScreen
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D86D RID: 55405
		// (get) Token: 0x06033ABA RID: 211642 RVA: 0x006F549C File Offset: 0x006F369C
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

		// Token: 0x06033ABB RID: 211643 RVA: 0x006F54D8 File Offset: 0x006F36D8
		public static Offset<IStateProgramSpecialProcessChangeTeamOptimization> CreateIStateProgramSpecialProcessChangeTeamOptimization(FlatBufferBuilder builder, ELogicProgramSpecialProcess Type = ELogicProgramSpecialProcess.ChangeTeamOptimization, bool IsOpenBlackScreen = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IStateProgramSpecialProcessChangeTeamOptimization.AddNullMask(builder, NullMask);
			IStateProgramSpecialProcessChangeTeamOptimization.AddIsOpenBlackScreen(builder, IsOpenBlackScreen);
			IStateProgramSpecialProcessChangeTeamOptimization.AddType(builder, Type);
			return IStateProgramSpecialProcessChangeTeamOptimization.EndIStateProgramSpecialProcessChangeTeamOptimization(builder);
		}

		// Token: 0x06033ABC RID: 211644 RVA: 0x006F54FC File Offset: 0x006F36FC
		public static void StartIStateProgramSpecialProcessChangeTeamOptimization(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06033ABD RID: 211645 RVA: 0x006F5505 File Offset: 0x006F3705
		public static void AddType(FlatBufferBuilder builder, ELogicProgramSpecialProcess type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033ABE RID: 211646 RVA: 0x006F5510 File Offset: 0x006F3710
		public static void AddIsOpenBlackScreen(FlatBufferBuilder builder, bool isOpenBlackScreen)
		{
			builder.AddBool(1, isOpenBlackScreen, false);
		}

		// Token: 0x06033ABF RID: 211647 RVA: 0x006F551B File Offset: 0x006F371B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06033AC0 RID: 211648 RVA: 0x006F5526 File Offset: 0x006F3726
		public static Offset<IStateProgramSpecialProcessChangeTeamOptimization> EndIStateProgramSpecialProcessChangeTeamOptimization(FlatBufferBuilder builder)
		{
			return new Offset<IStateProgramSpecialProcessChangeTeamOptimization>(builder.EndTable());
		}

		// Token: 0x06033AC1 RID: 211649 RVA: 0x006F5534 File Offset: 0x006F3734
		public IStateProgramSpecialProcessChangeTeamOptimizationT UnPack()
		{
			IStateProgramSpecialProcessChangeTeamOptimizationT stateProgramSpecialProcessChangeTeamOptimizationT = new IStateProgramSpecialProcessChangeTeamOptimizationT();
			this.UnPackTo(stateProgramSpecialProcessChangeTeamOptimizationT);
			return stateProgramSpecialProcessChangeTeamOptimizationT;
		}

		// Token: 0x06033AC2 RID: 211650 RVA: 0x006F554F File Offset: 0x006F374F
		public void UnPackTo(IStateProgramSpecialProcessChangeTeamOptimizationT _o)
		{
			_o.Type = this.Type;
			_o.IsOpenBlackScreen = this.IsOpenBlackScreen;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06033AC3 RID: 211651 RVA: 0x006F5578 File Offset: 0x006F3778
		public static Offset<IStateProgramSpecialProcessChangeTeamOptimization> Pack(FlatBufferBuilder builder, IStateProgramSpecialProcessChangeTeamOptimizationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStateProgramSpecialProcessChangeTeamOptimization>);
			}
			return IStateProgramSpecialProcessChangeTeamOptimization.CreateIStateProgramSpecialProcessChangeTeamOptimization(builder, _o.Type, _o.IsOpenBlackScreen, _o.NullMask);
		}

		// Token: 0x04011CA9 RID: 72873
		private Table __p;
	}
}
