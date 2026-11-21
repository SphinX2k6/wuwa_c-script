using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004502 RID: 17666
	public struct IRoleTowerChallengeTitleKillProgress : IFlatbufferObject
	{
		// Token: 0x17007AFD RID: 31485
		// (get) Token: 0x0601990F RID: 104719 RVA: 0x003A50ED File Offset: 0x003A32ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019910 RID: 104720 RVA: 0x003A50FA File Offset: 0x003A32FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019911 RID: 104721 RVA: 0x003A5104 File Offset: 0x003A3304
		public static IRoleTowerChallengeTitleKillProgress GetRootAsIRoleTowerChallengeTitleKillProgress(ByteBuffer _bb)
		{
			return IRoleTowerChallengeTitleKillProgress.GetRootAsIRoleTowerChallengeTitleKillProgress(_bb, default(IRoleTowerChallengeTitleKillProgress));
		}

		// Token: 0x06019912 RID: 104722 RVA: 0x003A5120 File Offset: 0x003A3320
		public static IRoleTowerChallengeTitleKillProgress GetRootAsIRoleTowerChallengeTitleKillProgress(ByteBuffer _bb, IRoleTowerChallengeTitleKillProgress obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019913 RID: 104723 RVA: 0x003A513D File Offset: 0x003A333D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019914 RID: 104724 RVA: 0x003A514C File Offset: 0x003A334C
		public IRoleTowerChallengeTitleKillProgress __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007AFE RID: 31486
		// (get) Token: 0x06019915 RID: 104725 RVA: 0x003A515C File Offset: 0x003A335C
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

		// Token: 0x06019916 RID: 104726 RVA: 0x003A5198 File Offset: 0x003A3398
		public static Offset<IRoleTowerChallengeTitleKillProgress> CreateIRoleTowerChallengeTitleKillProgress(FlatBufferBuilder builder, ERoleTowerChallengeTitleType Type = ERoleTowerChallengeTitleType.KillProgress)
		{
			builder.StartTable(1);
			IRoleTowerChallengeTitleKillProgress.AddType(builder, Type);
			return IRoleTowerChallengeTitleKillProgress.EndIRoleTowerChallengeTitleKillProgress(builder);
		}

		// Token: 0x06019917 RID: 104727 RVA: 0x003A51AE File Offset: 0x003A33AE
		public static void StartIRoleTowerChallengeTitleKillProgress(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019918 RID: 104728 RVA: 0x003A51B7 File Offset: 0x003A33B7
		public static void AddType(FlatBufferBuilder builder, ERoleTowerChallengeTitleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019919 RID: 104729 RVA: 0x003A51C2 File Offset: 0x003A33C2
		public static Offset<IRoleTowerChallengeTitleKillProgress> EndIRoleTowerChallengeTitleKillProgress(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerChallengeTitleKillProgress>(builder.EndTable());
		}

		// Token: 0x0601991A RID: 104730 RVA: 0x003A51D0 File Offset: 0x003A33D0
		public IRoleTowerChallengeTitleKillProgressT UnPack()
		{
			IRoleTowerChallengeTitleKillProgressT roleTowerChallengeTitleKillProgressT = new IRoleTowerChallengeTitleKillProgressT();
			this.UnPackTo(roleTowerChallengeTitleKillProgressT);
			return roleTowerChallengeTitleKillProgressT;
		}

		// Token: 0x0601991B RID: 104731 RVA: 0x003A51EB File Offset: 0x003A33EB
		public void UnPackTo(IRoleTowerChallengeTitleKillProgressT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601991C RID: 104732 RVA: 0x003A51FC File Offset: 0x003A33FC
		public static Offset<IRoleTowerChallengeTitleKillProgress> Pack(FlatBufferBuilder builder, IRoleTowerChallengeTitleKillProgressT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerChallengeTitleKillProgress>);
			}
			return IRoleTowerChallengeTitleKillProgress.CreateIRoleTowerChallengeTitleKillProgress(builder, _o.Type);
		}

		// Token: 0x0400C63F RID: 50751
		private Table __p;
	}
}
