using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004517 RID: 17687
	public struct IRoleTowerConditionStepLoadSubLevel : IFlatbufferObject
	{
		// Token: 0x17007B10 RID: 31504
		// (get) Token: 0x0601998D RID: 104845 RVA: 0x003A5BE1 File Offset: 0x003A3DE1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601998E RID: 104846 RVA: 0x003A5BEE File Offset: 0x003A3DEE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601998F RID: 104847 RVA: 0x003A5BF8 File Offset: 0x003A3DF8
		public static IRoleTowerConditionStepLoadSubLevel GetRootAsIRoleTowerConditionStepLoadSubLevel(ByteBuffer _bb)
		{
			return IRoleTowerConditionStepLoadSubLevel.GetRootAsIRoleTowerConditionStepLoadSubLevel(_bb, default(IRoleTowerConditionStepLoadSubLevel));
		}

		// Token: 0x06019990 RID: 104848 RVA: 0x003A5C14 File Offset: 0x003A3E14
		public static IRoleTowerConditionStepLoadSubLevel GetRootAsIRoleTowerConditionStepLoadSubLevel(ByteBuffer _bb, IRoleTowerConditionStepLoadSubLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019991 RID: 104849 RVA: 0x003A5C31 File Offset: 0x003A3E31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019992 RID: 104850 RVA: 0x003A5C40 File Offset: 0x003A3E40
		public IRoleTowerConditionStepLoadSubLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B11 RID: 31505
		// (get) Token: 0x06019993 RID: 104851 RVA: 0x003A5C50 File Offset: 0x003A3E50
		public ERoleTowerConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERoleTowerConditionStep.Prepare;
				}
				return (ERoleTowerConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019994 RID: 104852 RVA: 0x003A5C8C File Offset: 0x003A3E8C
		public static Offset<IRoleTowerConditionStepLoadSubLevel> CreateIRoleTowerConditionStepLoadSubLevel(FlatBufferBuilder builder, ERoleTowerConditionStep Type = ERoleTowerConditionStep.Prepare)
		{
			builder.StartTable(1);
			IRoleTowerConditionStepLoadSubLevel.AddType(builder, Type);
			return IRoleTowerConditionStepLoadSubLevel.EndIRoleTowerConditionStepLoadSubLevel(builder);
		}

		// Token: 0x06019995 RID: 104853 RVA: 0x003A5CA2 File Offset: 0x003A3EA2
		public static void StartIRoleTowerConditionStepLoadSubLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019996 RID: 104854 RVA: 0x003A5CAB File Offset: 0x003A3EAB
		public static void AddType(FlatBufferBuilder builder, ERoleTowerConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019997 RID: 104855 RVA: 0x003A5CB6 File Offset: 0x003A3EB6
		public static Offset<IRoleTowerConditionStepLoadSubLevel> EndIRoleTowerConditionStepLoadSubLevel(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerConditionStepLoadSubLevel>(builder.EndTable());
		}

		// Token: 0x06019998 RID: 104856 RVA: 0x003A5CC4 File Offset: 0x003A3EC4
		public IRoleTowerConditionStepLoadSubLevelT UnPack()
		{
			IRoleTowerConditionStepLoadSubLevelT roleTowerConditionStepLoadSubLevelT = new IRoleTowerConditionStepLoadSubLevelT();
			this.UnPackTo(roleTowerConditionStepLoadSubLevelT);
			return roleTowerConditionStepLoadSubLevelT;
		}

		// Token: 0x06019999 RID: 104857 RVA: 0x003A5CDF File Offset: 0x003A3EDF
		public void UnPackTo(IRoleTowerConditionStepLoadSubLevelT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601999A RID: 104858 RVA: 0x003A5CF0 File Offset: 0x003A3EF0
		public static Offset<IRoleTowerConditionStepLoadSubLevel> Pack(FlatBufferBuilder builder, IRoleTowerConditionStepLoadSubLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerConditionStepLoadSubLevel>);
			}
			return IRoleTowerConditionStepLoadSubLevel.CreateIRoleTowerConditionStepLoadSubLevel(builder, _o.Type);
		}

		// Token: 0x0400C65B RID: 50779
		private Table __p;
	}
}
