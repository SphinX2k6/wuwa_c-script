using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075BC RID: 30140
	public struct IVisualNovelPerformanceRoleIntroduction : IFlatbufferObject
	{
		// Token: 0x1700E4D8 RID: 58584
		// (get) Token: 0x06036E18 RID: 224792 RVA: 0x007732C0 File Offset: 0x007714C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036E19 RID: 224793 RVA: 0x007732CD File Offset: 0x007714CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036E1A RID: 224794 RVA: 0x007732D4 File Offset: 0x007714D4
		public static IVisualNovelPerformanceRoleIntroduction GetRootAsIVisualNovelPerformanceRoleIntroduction(ByteBuffer _bb)
		{
			return IVisualNovelPerformanceRoleIntroduction.GetRootAsIVisualNovelPerformanceRoleIntroduction(_bb, default(IVisualNovelPerformanceRoleIntroduction));
		}

		// Token: 0x06036E1B RID: 224795 RVA: 0x007732F0 File Offset: 0x007714F0
		public static IVisualNovelPerformanceRoleIntroduction GetRootAsIVisualNovelPerformanceRoleIntroduction(ByteBuffer _bb, IVisualNovelPerformanceRoleIntroduction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036E1C RID: 224796 RVA: 0x0077330D File Offset: 0x0077150D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036E1D RID: 224797 RVA: 0x0077331C File Offset: 0x0077151C
		public IVisualNovelPerformanceRoleIntroduction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4D9 RID: 58585
		// (get) Token: 0x06036E1E RID: 224798 RVA: 0x0077332C File Offset: 0x0077152C
		public EVisualNovelPerformanceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelPerformanceType.Enter;
				}
				return (EVisualNovelPerformanceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E4DA RID: 58586
		// (get) Token: 0x06036E1F RID: 224799 RVA: 0x00773368 File Offset: 0x00771568
		public float StartTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E4DB RID: 58587
		// (get) Token: 0x06036E20 RID: 224800 RVA: 0x007733A8 File Offset: 0x007715A8
		public IVisualNovelRoleIntroductionSolarSchool? RoleIntroductionConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVisualNovelRoleIntroductionSolarSchool?(default(IVisualNovelRoleIntroductionSolarSchool).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E4DC RID: 58588
		// (get) Token: 0x06036E21 RID: 224801 RVA: 0x00773408 File Offset: 0x00771608
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036E22 RID: 224802 RVA: 0x00773445 File Offset: 0x00771645
		public static Offset<IVisualNovelPerformanceRoleIntroduction> CreateIVisualNovelPerformanceRoleIntroduction(FlatBufferBuilder builder, EVisualNovelPerformanceType Type = EVisualNovelPerformanceType.Enter, float StartTime = 0f, Offset<IVisualNovelRoleIntroductionSolarSchool> RoleIntroductionConfigOffset = default(Offset<IVisualNovelRoleIntroductionSolarSchool>), byte NullMask = 0)
		{
			builder.StartTable(4);
			IVisualNovelPerformanceRoleIntroduction.AddRoleIntroductionConfig(builder, RoleIntroductionConfigOffset);
			IVisualNovelPerformanceRoleIntroduction.AddStartTime(builder, StartTime);
			IVisualNovelPerformanceRoleIntroduction.AddNullMask(builder, NullMask);
			IVisualNovelPerformanceRoleIntroduction.AddType(builder, Type);
			return IVisualNovelPerformanceRoleIntroduction.EndIVisualNovelPerformanceRoleIntroduction(builder);
		}

		// Token: 0x06036E23 RID: 224803 RVA: 0x00773471 File Offset: 0x00771671
		public static void StartIVisualNovelPerformanceRoleIntroduction(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06036E24 RID: 224804 RVA: 0x0077347A File Offset: 0x0077167A
		public static void AddType(FlatBufferBuilder builder, EVisualNovelPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036E25 RID: 224805 RVA: 0x00773485 File Offset: 0x00771685
		public static void AddStartTime(FlatBufferBuilder builder, float startTime)
		{
			builder.AddFloat(1, startTime, 0.0);
		}

		// Token: 0x06036E26 RID: 224806 RVA: 0x00773498 File Offset: 0x00771698
		public static void AddRoleIntroductionConfig(FlatBufferBuilder builder, Offset<IVisualNovelRoleIntroductionSolarSchool> roleIntroductionConfigOffset)
		{
			builder.AddOffset(2, roleIntroductionConfigOffset.Value, 0);
		}

		// Token: 0x06036E27 RID: 224807 RVA: 0x007734A8 File Offset: 0x007716A8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06036E28 RID: 224808 RVA: 0x007734B3 File Offset: 0x007716B3
		public static Offset<IVisualNovelPerformanceRoleIntroduction> EndIVisualNovelPerformanceRoleIntroduction(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPerformanceRoleIntroduction>(builder.EndTable());
		}

		// Token: 0x06036E29 RID: 224809 RVA: 0x007734C0 File Offset: 0x007716C0
		public IVisualNovelPerformanceRoleIntroductionT UnPack()
		{
			IVisualNovelPerformanceRoleIntroductionT visualNovelPerformanceRoleIntroductionT = new IVisualNovelPerformanceRoleIntroductionT();
			this.UnPackTo(visualNovelPerformanceRoleIntroductionT);
			return visualNovelPerformanceRoleIntroductionT;
		}

		// Token: 0x06036E2A RID: 224810 RVA: 0x007734DC File Offset: 0x007716DC
		public void UnPackTo(IVisualNovelPerformanceRoleIntroductionT _o)
		{
			_o.Type = this.Type;
			_o.StartTime = this.StartTime;
			_o.RoleIntroductionConfig = ((this.RoleIntroductionConfig != null) ? this.RoleIntroductionConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036E2B RID: 224811 RVA: 0x0077353C File Offset: 0x0077173C
		public static Offset<IVisualNovelPerformanceRoleIntroduction> Pack(FlatBufferBuilder builder, IVisualNovelPerformanceRoleIntroductionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPerformanceRoleIntroduction>);
			}
			Offset<IVisualNovelRoleIntroductionSolarSchool> roleIntroductionConfigOffset = (_o.RoleIntroductionConfig == null) ? default(Offset<IVisualNovelRoleIntroductionSolarSchool>) : IVisualNovelRoleIntroductionSolarSchool.Pack(builder, _o.RoleIntroductionConfig);
			return IVisualNovelPerformanceRoleIntroduction.CreateIVisualNovelPerformanceRoleIntroduction(builder, _o.Type, _o.StartTime, roleIntroductionConfigOffset, _o.NullMask);
		}

		// Token: 0x04012508 RID: 75016
		private Table __p;
	}
}
