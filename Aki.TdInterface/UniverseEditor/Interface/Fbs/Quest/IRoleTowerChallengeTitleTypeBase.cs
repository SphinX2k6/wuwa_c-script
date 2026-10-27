using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040C7 RID: 16583
	public struct IRoleTowerChallengeTitleTypeBase : IFlatbufferObject
	{
		// Token: 0x170074FD RID: 29949
		// (get) Token: 0x06018292 RID: 98962 RVA: 0x0037B48D File Offset: 0x0037968D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018293 RID: 98963 RVA: 0x0037B49A File Offset: 0x0037969A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018294 RID: 98964 RVA: 0x0037B4A4 File Offset: 0x003796A4
		public static IRoleTowerChallengeTitleTypeBase GetRootAsIRoleTowerChallengeTitleTypeBase(ByteBuffer _bb)
		{
			return IRoleTowerChallengeTitleTypeBase.GetRootAsIRoleTowerChallengeTitleTypeBase(_bb, default(IRoleTowerChallengeTitleTypeBase));
		}

		// Token: 0x06018295 RID: 98965 RVA: 0x0037B4C0 File Offset: 0x003796C0
		public static IRoleTowerChallengeTitleTypeBase GetRootAsIRoleTowerChallengeTitleTypeBase(ByteBuffer _bb, IRoleTowerChallengeTitleTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018296 RID: 98966 RVA: 0x0037B4DD File Offset: 0x003796DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018297 RID: 98967 RVA: 0x0037B4EC File Offset: 0x003796EC
		public IRoleTowerChallengeTitleTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074FE RID: 29950
		// (get) Token: 0x06018298 RID: 98968 RVA: 0x0037B4FC File Offset: 0x003796FC
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

		// Token: 0x06018299 RID: 98969 RVA: 0x0037B538 File Offset: 0x00379738
		public static Offset<IRoleTowerChallengeTitleTypeBase> CreateIRoleTowerChallengeTitleTypeBase(FlatBufferBuilder builder, ERoleTowerChallengeTitleType Type = ERoleTowerChallengeTitleType.KillProgress)
		{
			builder.StartTable(1);
			IRoleTowerChallengeTitleTypeBase.AddType(builder, Type);
			return IRoleTowerChallengeTitleTypeBase.EndIRoleTowerChallengeTitleTypeBase(builder);
		}

		// Token: 0x0601829A RID: 98970 RVA: 0x0037B54E File Offset: 0x0037974E
		public static void StartIRoleTowerChallengeTitleTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601829B RID: 98971 RVA: 0x0037B557 File Offset: 0x00379757
		public static void AddType(FlatBufferBuilder builder, ERoleTowerChallengeTitleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601829C RID: 98972 RVA: 0x0037B562 File Offset: 0x00379762
		public static Offset<IRoleTowerChallengeTitleTypeBase> EndIRoleTowerChallengeTitleTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerChallengeTitleTypeBase>(builder.EndTable());
		}

		// Token: 0x0601829D RID: 98973 RVA: 0x0037B570 File Offset: 0x00379770
		public IRoleTowerChallengeTitleTypeBaseT UnPack()
		{
			IRoleTowerChallengeTitleTypeBaseT roleTowerChallengeTitleTypeBaseT = new IRoleTowerChallengeTitleTypeBaseT();
			this.UnPackTo(roleTowerChallengeTitleTypeBaseT);
			return roleTowerChallengeTitleTypeBaseT;
		}

		// Token: 0x0601829E RID: 98974 RVA: 0x0037B58B File Offset: 0x0037978B
		public void UnPackTo(IRoleTowerChallengeTitleTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601829F RID: 98975 RVA: 0x0037B59C File Offset: 0x0037979C
		public static Offset<IRoleTowerChallengeTitleTypeBase> Pack(FlatBufferBuilder builder, IRoleTowerChallengeTitleTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerChallengeTitleTypeBase>);
			}
			return IRoleTowerChallengeTitleTypeBase.CreateIRoleTowerChallengeTitleTypeBase(builder, _o.Type);
		}

		// Token: 0x0400BC5A RID: 48218
		private Table __p;
	}
}
