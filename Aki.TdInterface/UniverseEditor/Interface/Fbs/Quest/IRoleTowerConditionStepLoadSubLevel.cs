using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040D6 RID: 16598
	public struct IRoleTowerConditionStepLoadSubLevel : IFlatbufferObject
	{
		// Token: 0x1700750A RID: 29962
		// (get) Token: 0x060182EC RID: 99052 RVA: 0x0037BC91 File Offset: 0x00379E91
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060182ED RID: 99053 RVA: 0x0037BC9E File Offset: 0x00379E9E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060182EE RID: 99054 RVA: 0x0037BCA8 File Offset: 0x00379EA8
		public static IRoleTowerConditionStepLoadSubLevel GetRootAsIRoleTowerConditionStepLoadSubLevel(ByteBuffer _bb)
		{
			return IRoleTowerConditionStepLoadSubLevel.GetRootAsIRoleTowerConditionStepLoadSubLevel(_bb, default(IRoleTowerConditionStepLoadSubLevel));
		}

		// Token: 0x060182EF RID: 99055 RVA: 0x0037BCC4 File Offset: 0x00379EC4
		public static IRoleTowerConditionStepLoadSubLevel GetRootAsIRoleTowerConditionStepLoadSubLevel(ByteBuffer _bb, IRoleTowerConditionStepLoadSubLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060182F0 RID: 99056 RVA: 0x0037BCE1 File Offset: 0x00379EE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060182F1 RID: 99057 RVA: 0x0037BCF0 File Offset: 0x00379EF0
		public IRoleTowerConditionStepLoadSubLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700750B RID: 29963
		// (get) Token: 0x060182F2 RID: 99058 RVA: 0x0037BD00 File Offset: 0x00379F00
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

		// Token: 0x060182F3 RID: 99059 RVA: 0x0037BD3C File Offset: 0x00379F3C
		public static Offset<IRoleTowerConditionStepLoadSubLevel> CreateIRoleTowerConditionStepLoadSubLevel(FlatBufferBuilder builder, ERoleTowerConditionStep Type = ERoleTowerConditionStep.Prepare)
		{
			builder.StartTable(1);
			IRoleTowerConditionStepLoadSubLevel.AddType(builder, Type);
			return IRoleTowerConditionStepLoadSubLevel.EndIRoleTowerConditionStepLoadSubLevel(builder);
		}

		// Token: 0x060182F4 RID: 99060 RVA: 0x0037BD52 File Offset: 0x00379F52
		public static void StartIRoleTowerConditionStepLoadSubLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060182F5 RID: 99061 RVA: 0x0037BD5B File Offset: 0x00379F5B
		public static void AddType(FlatBufferBuilder builder, ERoleTowerConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060182F6 RID: 99062 RVA: 0x0037BD66 File Offset: 0x00379F66
		public static Offset<IRoleTowerConditionStepLoadSubLevel> EndIRoleTowerConditionStepLoadSubLevel(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerConditionStepLoadSubLevel>(builder.EndTable());
		}

		// Token: 0x060182F7 RID: 99063 RVA: 0x0037BD74 File Offset: 0x00379F74
		public IRoleTowerConditionStepLoadSubLevelT UnPack()
		{
			IRoleTowerConditionStepLoadSubLevelT roleTowerConditionStepLoadSubLevelT = new IRoleTowerConditionStepLoadSubLevelT();
			this.UnPackTo(roleTowerConditionStepLoadSubLevelT);
			return roleTowerConditionStepLoadSubLevelT;
		}

		// Token: 0x060182F8 RID: 99064 RVA: 0x0037BD8F File Offset: 0x00379F8F
		public void UnPackTo(IRoleTowerConditionStepLoadSubLevelT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060182F9 RID: 99065 RVA: 0x0037BDA0 File Offset: 0x00379FA0
		public static Offset<IRoleTowerConditionStepLoadSubLevel> Pack(FlatBufferBuilder builder, IRoleTowerConditionStepLoadSubLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerConditionStepLoadSubLevel>);
			}
			return IRoleTowerConditionStepLoadSubLevel.CreateIRoleTowerConditionStepLoadSubLevel(builder, _o.Type);
		}

		// Token: 0x0400BC72 RID: 48242
		private Table __p;
	}
}
