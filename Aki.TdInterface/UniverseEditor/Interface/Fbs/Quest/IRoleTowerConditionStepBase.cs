using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200450E RID: 17678
	public struct IRoleTowerConditionStepBase : IFlatbufferObject
	{
		// Token: 0x17007B08 RID: 31496
		// (get) Token: 0x06019955 RID: 104789 RVA: 0x003A56E2 File Offset: 0x003A38E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019956 RID: 104790 RVA: 0x003A56EF File Offset: 0x003A38EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019957 RID: 104791 RVA: 0x003A56F8 File Offset: 0x003A38F8
		public static IRoleTowerConditionStepBase GetRootAsIRoleTowerConditionStepBase(ByteBuffer _bb)
		{
			return IRoleTowerConditionStepBase.GetRootAsIRoleTowerConditionStepBase(_bb, default(IRoleTowerConditionStepBase));
		}

		// Token: 0x06019958 RID: 104792 RVA: 0x003A5714 File Offset: 0x003A3914
		public static IRoleTowerConditionStepBase GetRootAsIRoleTowerConditionStepBase(ByteBuffer _bb, IRoleTowerConditionStepBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019959 RID: 104793 RVA: 0x003A5731 File Offset: 0x003A3931
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601995A RID: 104794 RVA: 0x003A5740 File Offset: 0x003A3940
		public IRoleTowerConditionStepBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B09 RID: 31497
		// (get) Token: 0x0601995B RID: 104795 RVA: 0x003A5750 File Offset: 0x003A3950
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

		// Token: 0x0601995C RID: 104796 RVA: 0x003A578C File Offset: 0x003A398C
		public static Offset<IRoleTowerConditionStepBase> CreateIRoleTowerConditionStepBase(FlatBufferBuilder builder, ERoleTowerConditionStep Type = ERoleTowerConditionStep.Prepare)
		{
			builder.StartTable(1);
			IRoleTowerConditionStepBase.AddType(builder, Type);
			return IRoleTowerConditionStepBase.EndIRoleTowerConditionStepBase(builder);
		}

		// Token: 0x0601995D RID: 104797 RVA: 0x003A57A2 File Offset: 0x003A39A2
		public static void StartIRoleTowerConditionStepBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601995E RID: 104798 RVA: 0x003A57AB File Offset: 0x003A39AB
		public static void AddType(FlatBufferBuilder builder, ERoleTowerConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601995F RID: 104799 RVA: 0x003A57B6 File Offset: 0x003A39B6
		public static Offset<IRoleTowerConditionStepBase> EndIRoleTowerConditionStepBase(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerConditionStepBase>(builder.EndTable());
		}

		// Token: 0x06019960 RID: 104800 RVA: 0x003A57C4 File Offset: 0x003A39C4
		public IRoleTowerConditionStepBaseT UnPack()
		{
			IRoleTowerConditionStepBaseT roleTowerConditionStepBaseT = new IRoleTowerConditionStepBaseT();
			this.UnPackTo(roleTowerConditionStepBaseT);
			return roleTowerConditionStepBaseT;
		}

		// Token: 0x06019961 RID: 104801 RVA: 0x003A57DF File Offset: 0x003A39DF
		public void UnPackTo(IRoleTowerConditionStepBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019962 RID: 104802 RVA: 0x003A57F0 File Offset: 0x003A39F0
		public static Offset<IRoleTowerConditionStepBase> Pack(FlatBufferBuilder builder, IRoleTowerConditionStepBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerConditionStepBase>);
			}
			return IRoleTowerConditionStepBase.CreateIRoleTowerConditionStepBase(builder, _o.Type);
		}

		// Token: 0x0400C64D RID: 50765
		private Table __p;
	}
}
