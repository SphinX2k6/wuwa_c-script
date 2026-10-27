using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040C1 RID: 16577
	public struct IRoleTowerChallengeTitleKillProgress : IFlatbufferObject
	{
		// Token: 0x170074F7 RID: 29943
		// (get) Token: 0x0601826E RID: 98926 RVA: 0x0037B19D File Offset: 0x0037939D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601826F RID: 98927 RVA: 0x0037B1AA File Offset: 0x003793AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018270 RID: 98928 RVA: 0x0037B1B4 File Offset: 0x003793B4
		public static IRoleTowerChallengeTitleKillProgress GetRootAsIRoleTowerChallengeTitleKillProgress(ByteBuffer _bb)
		{
			return IRoleTowerChallengeTitleKillProgress.GetRootAsIRoleTowerChallengeTitleKillProgress(_bb, default(IRoleTowerChallengeTitleKillProgress));
		}

		// Token: 0x06018271 RID: 98929 RVA: 0x0037B1D0 File Offset: 0x003793D0
		public static IRoleTowerChallengeTitleKillProgress GetRootAsIRoleTowerChallengeTitleKillProgress(ByteBuffer _bb, IRoleTowerChallengeTitleKillProgress obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018272 RID: 98930 RVA: 0x0037B1ED File Offset: 0x003793ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018273 RID: 98931 RVA: 0x0037B1FC File Offset: 0x003793FC
		public IRoleTowerChallengeTitleKillProgress __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074F8 RID: 29944
		// (get) Token: 0x06018274 RID: 98932 RVA: 0x0037B20C File Offset: 0x0037940C
		public ERoleTowerChallengeTitleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERoleTowerChallengeTitleType.KillProgress;
				}
				return (ERoleTowerChallengeTitleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018275 RID: 98933 RVA: 0x0037B248 File Offset: 0x00379448
		public static Offset<IRoleTowerChallengeTitleKillProgress> CreateIRoleTowerChallengeTitleKillProgress(FlatBufferBuilder builder, ERoleTowerChallengeTitleType Type = ERoleTowerChallengeTitleType.KillProgress)
		{
			builder.StartTable(1);
			IRoleTowerChallengeTitleKillProgress.AddType(builder, Type);
			return IRoleTowerChallengeTitleKillProgress.EndIRoleTowerChallengeTitleKillProgress(builder);
		}

		// Token: 0x06018276 RID: 98934 RVA: 0x0037B25E File Offset: 0x0037945E
		public static void StartIRoleTowerChallengeTitleKillProgress(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018277 RID: 98935 RVA: 0x0037B267 File Offset: 0x00379467
		public static void AddType(FlatBufferBuilder builder, ERoleTowerChallengeTitleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018278 RID: 98936 RVA: 0x0037B272 File Offset: 0x00379472
		public static Offset<IRoleTowerChallengeTitleKillProgress> EndIRoleTowerChallengeTitleKillProgress(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerChallengeTitleKillProgress>(builder.EndTable());
		}

		// Token: 0x06018279 RID: 98937 RVA: 0x0037B280 File Offset: 0x00379480
		public IRoleTowerChallengeTitleKillProgressT UnPack()
		{
			IRoleTowerChallengeTitleKillProgressT roleTowerChallengeTitleKillProgressT = new IRoleTowerChallengeTitleKillProgressT();
			this.UnPackTo(roleTowerChallengeTitleKillProgressT);
			return roleTowerChallengeTitleKillProgressT;
		}

		// Token: 0x0601827A RID: 98938 RVA: 0x0037B29B File Offset: 0x0037949B
		public void UnPackTo(IRoleTowerChallengeTitleKillProgressT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601827B RID: 98939 RVA: 0x0037B2AC File Offset: 0x003794AC
		public static Offset<IRoleTowerChallengeTitleKillProgress> Pack(FlatBufferBuilder builder, IRoleTowerChallengeTitleKillProgressT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerChallengeTitleKillProgress>);
			}
			return IRoleTowerChallengeTitleKillProgress.CreateIRoleTowerChallengeTitleKillProgress(builder, _o.Type);
		}

		// Token: 0x0400BC56 RID: 48214
		private Table __p;
	}
}
