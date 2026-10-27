using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040C4 RID: 16580
	public struct IRoleTowerChallengeTitlePhantomExp : IFlatbufferObject
	{
		// Token: 0x170074FA RID: 29946
		// (get) Token: 0x06018280 RID: 98944 RVA: 0x0037B315 File Offset: 0x00379515
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018281 RID: 98945 RVA: 0x0037B322 File Offset: 0x00379522
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018282 RID: 98946 RVA: 0x0037B32C File Offset: 0x0037952C
		public static IRoleTowerChallengeTitlePhantomExp GetRootAsIRoleTowerChallengeTitlePhantomExp(ByteBuffer _bb)
		{
			return IRoleTowerChallengeTitlePhantomExp.GetRootAsIRoleTowerChallengeTitlePhantomExp(_bb, default(IRoleTowerChallengeTitlePhantomExp));
		}

		// Token: 0x06018283 RID: 98947 RVA: 0x0037B348 File Offset: 0x00379548
		public static IRoleTowerChallengeTitlePhantomExp GetRootAsIRoleTowerChallengeTitlePhantomExp(ByteBuffer _bb, IRoleTowerChallengeTitlePhantomExp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018284 RID: 98948 RVA: 0x0037B365 File Offset: 0x00379565
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018285 RID: 98949 RVA: 0x0037B374 File Offset: 0x00379574
		public IRoleTowerChallengeTitlePhantomExp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074FB RID: 29947
		// (get) Token: 0x06018286 RID: 98950 RVA: 0x0037B384 File Offset: 0x00379584
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

		// Token: 0x06018287 RID: 98951 RVA: 0x0037B3C0 File Offset: 0x003795C0
		public static Offset<IRoleTowerChallengeTitlePhantomExp> CreateIRoleTowerChallengeTitlePhantomExp(FlatBufferBuilder builder, ERoleTowerChallengeTitleType Type = ERoleTowerChallengeTitleType.KillProgress)
		{
			builder.StartTable(1);
			IRoleTowerChallengeTitlePhantomExp.AddType(builder, Type);
			return IRoleTowerChallengeTitlePhantomExp.EndIRoleTowerChallengeTitlePhantomExp(builder);
		}

		// Token: 0x06018288 RID: 98952 RVA: 0x0037B3D6 File Offset: 0x003795D6
		public static void StartIRoleTowerChallengeTitlePhantomExp(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018289 RID: 98953 RVA: 0x0037B3DF File Offset: 0x003795DF
		public static void AddType(FlatBufferBuilder builder, ERoleTowerChallengeTitleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601828A RID: 98954 RVA: 0x0037B3EA File Offset: 0x003795EA
		public static Offset<IRoleTowerChallengeTitlePhantomExp> EndIRoleTowerChallengeTitlePhantomExp(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerChallengeTitlePhantomExp>(builder.EndTable());
		}

		// Token: 0x0601828B RID: 98955 RVA: 0x0037B3F8 File Offset: 0x003795F8
		public IRoleTowerChallengeTitlePhantomExpT UnPack()
		{
			IRoleTowerChallengeTitlePhantomExpT roleTowerChallengeTitlePhantomExpT = new IRoleTowerChallengeTitlePhantomExpT();
			this.UnPackTo(roleTowerChallengeTitlePhantomExpT);
			return roleTowerChallengeTitlePhantomExpT;
		}

		// Token: 0x0601828C RID: 98956 RVA: 0x0037B413 File Offset: 0x00379613
		public void UnPackTo(IRoleTowerChallengeTitlePhantomExpT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601828D RID: 98957 RVA: 0x0037B424 File Offset: 0x00379624
		public static Offset<IRoleTowerChallengeTitlePhantomExp> Pack(FlatBufferBuilder builder, IRoleTowerChallengeTitlePhantomExpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerChallengeTitlePhantomExp>);
			}
			return IRoleTowerChallengeTitlePhantomExp.CreateIRoleTowerChallengeTitlePhantomExp(builder, _o.Type);
		}

		// Token: 0x0400BC58 RID: 48216
		private Table __p;
	}
}
