using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F23 RID: 20259
	public struct ICheckHonamiStoryLifeSupportLevel : IFlatbufferObject
	{
		// Token: 0x170090AD RID: 37037
		// (get) Token: 0x0601F7B3 RID: 128947 RVA: 0x00461D1A File Offset: 0x0045FF1A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F7B4 RID: 128948 RVA: 0x00461D27 File Offset: 0x0045FF27
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F7B5 RID: 128949 RVA: 0x00461D30 File Offset: 0x0045FF30
		public static ICheckHonamiStoryLifeSupportLevel GetRootAsICheckHonamiStoryLifeSupportLevel(ByteBuffer _bb)
		{
			return ICheckHonamiStoryLifeSupportLevel.GetRootAsICheckHonamiStoryLifeSupportLevel(_bb, default(ICheckHonamiStoryLifeSupportLevel));
		}

		// Token: 0x0601F7B6 RID: 128950 RVA: 0x00461D4C File Offset: 0x0045FF4C
		public static ICheckHonamiStoryLifeSupportLevel GetRootAsICheckHonamiStoryLifeSupportLevel(ByteBuffer _bb, ICheckHonamiStoryLifeSupportLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F7B7 RID: 128951 RVA: 0x00461D69 File Offset: 0x0045FF69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F7B8 RID: 128952 RVA: 0x00461D78 File Offset: 0x0045FF78
		public ICheckHonamiStoryLifeSupportLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090AE RID: 37038
		// (get) Token: 0x0601F7B9 RID: 128953 RVA: 0x00461D88 File Offset: 0x0045FF88
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170090AF RID: 37039
		// (get) Token: 0x0601F7BA RID: 128954 RVA: 0x00461DC4 File Offset: 0x0045FFC4
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170090B0 RID: 37040
		// (get) Token: 0x0601F7BB RID: 128955 RVA: 0x00461E00 File Offset: 0x00460000
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170090B1 RID: 37041
		// (get) Token: 0x0601F7BC RID: 128956 RVA: 0x00461E3C File Offset: 0x0046003C
		public int Level
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F7BD RID: 128957 RVA: 0x00461E79 File Offset: 0x00460079
		public static Offset<ICheckHonamiStoryLifeSupportLevel> CreateICheckHonamiStoryLifeSupportLevel(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int ActivityId = 0, ECompare Compare = ECompare.Eq, int Level = 0)
		{
			builder.StartTable(4);
			ICheckHonamiStoryLifeSupportLevel.AddLevel(builder, Level);
			ICheckHonamiStoryLifeSupportLevel.AddActivityId(builder, ActivityId);
			ICheckHonamiStoryLifeSupportLevel.AddCompare(builder, Compare);
			ICheckHonamiStoryLifeSupportLevel.AddType(builder, Type);
			return ICheckHonamiStoryLifeSupportLevel.EndICheckHonamiStoryLifeSupportLevel(builder);
		}

		// Token: 0x0601F7BE RID: 128958 RVA: 0x00461EA5 File Offset: 0x004600A5
		public static void StartICheckHonamiStoryLifeSupportLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601F7BF RID: 128959 RVA: 0x00461EAE File Offset: 0x004600AE
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F7C0 RID: 128960 RVA: 0x00461EB9 File Offset: 0x004600B9
		public static void AddActivityId(FlatBufferBuilder builder, int activityId)
		{
			builder.AddInt(1, activityId, 0);
		}

		// Token: 0x0601F7C1 RID: 128961 RVA: 0x00461EC4 File Offset: 0x004600C4
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601F7C2 RID: 128962 RVA: 0x00461ECF File Offset: 0x004600CF
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(3, level, 0);
		}

		// Token: 0x0601F7C3 RID: 128963 RVA: 0x00461EDA File Offset: 0x004600DA
		public static Offset<ICheckHonamiStoryLifeSupportLevel> EndICheckHonamiStoryLifeSupportLevel(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHonamiStoryLifeSupportLevel>(builder.EndTable());
		}

		// Token: 0x0601F7C4 RID: 128964 RVA: 0x00461EE8 File Offset: 0x004600E8
		public ICheckHonamiStoryLifeSupportLevelT UnPack()
		{
			ICheckHonamiStoryLifeSupportLevelT checkHonamiStoryLifeSupportLevelT = new ICheckHonamiStoryLifeSupportLevelT();
			this.UnPackTo(checkHonamiStoryLifeSupportLevelT);
			return checkHonamiStoryLifeSupportLevelT;
		}

		// Token: 0x0601F7C5 RID: 128965 RVA: 0x00461F03 File Offset: 0x00460103
		public void UnPackTo(ICheckHonamiStoryLifeSupportLevelT _o)
		{
			_o.Type = this.Type;
			_o.ActivityId = this.ActivityId;
			_o.Compare = this.Compare;
			_o.Level = this.Level;
		}

		// Token: 0x0601F7C6 RID: 128966 RVA: 0x00461F38 File Offset: 0x00460138
		public static Offset<ICheckHonamiStoryLifeSupportLevel> Pack(FlatBufferBuilder builder, ICheckHonamiStoryLifeSupportLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHonamiStoryLifeSupportLevel>);
			}
			return ICheckHonamiStoryLifeSupportLevel.CreateICheckHonamiStoryLifeSupportLevel(builder, _o.Type, _o.ActivityId, _o.Compare, _o.Level);
		}

		// Token: 0x0400DD96 RID: 56726
		private Table __p;
	}
}
