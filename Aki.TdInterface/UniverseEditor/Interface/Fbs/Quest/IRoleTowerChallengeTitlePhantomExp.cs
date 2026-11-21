using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004505 RID: 17669
	public struct IRoleTowerChallengeTitlePhantomExp : IFlatbufferObject
	{
		// Token: 0x17007B00 RID: 31488
		// (get) Token: 0x06019921 RID: 104737 RVA: 0x003A5265 File Offset: 0x003A3465
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019922 RID: 104738 RVA: 0x003A5272 File Offset: 0x003A3472
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019923 RID: 104739 RVA: 0x003A527C File Offset: 0x003A347C
		public static IRoleTowerChallengeTitlePhantomExp GetRootAsIRoleTowerChallengeTitlePhantomExp(ByteBuffer _bb)
		{
			return IRoleTowerChallengeTitlePhantomExp.GetRootAsIRoleTowerChallengeTitlePhantomExp(_bb, default(IRoleTowerChallengeTitlePhantomExp));
		}

		// Token: 0x06019924 RID: 104740 RVA: 0x003A5298 File Offset: 0x003A3498
		public static IRoleTowerChallengeTitlePhantomExp GetRootAsIRoleTowerChallengeTitlePhantomExp(ByteBuffer _bb, IRoleTowerChallengeTitlePhantomExp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019925 RID: 104741 RVA: 0x003A52B5 File Offset: 0x003A34B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019926 RID: 104742 RVA: 0x003A52C4 File Offset: 0x003A34C4
		public IRoleTowerChallengeTitlePhantomExp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B01 RID: 31489
		// (get) Token: 0x06019927 RID: 104743 RVA: 0x003A52D4 File Offset: 0x003A34D4
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

		// Token: 0x06019928 RID: 104744 RVA: 0x003A5310 File Offset: 0x003A3510
		public static Offset<IRoleTowerChallengeTitlePhantomExp> CreateIRoleTowerChallengeTitlePhantomExp(FlatBufferBuilder builder, ERoleTowerChallengeTitleType Type = ERoleTowerChallengeTitleType.KillProgress)
		{
			builder.StartTable(1);
			IRoleTowerChallengeTitlePhantomExp.AddType(builder, Type);
			return IRoleTowerChallengeTitlePhantomExp.EndIRoleTowerChallengeTitlePhantomExp(builder);
		}

		// Token: 0x06019929 RID: 104745 RVA: 0x003A5326 File Offset: 0x003A3526
		public static void StartIRoleTowerChallengeTitlePhantomExp(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601992A RID: 104746 RVA: 0x003A532F File Offset: 0x003A352F
		public static void AddType(FlatBufferBuilder builder, ERoleTowerChallengeTitleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601992B RID: 104747 RVA: 0x003A533A File Offset: 0x003A353A
		public static Offset<IRoleTowerChallengeTitlePhantomExp> EndIRoleTowerChallengeTitlePhantomExp(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerChallengeTitlePhantomExp>(builder.EndTable());
		}

		// Token: 0x0601992C RID: 104748 RVA: 0x003A5348 File Offset: 0x003A3548
		public IRoleTowerChallengeTitlePhantomExpT UnPack()
		{
			IRoleTowerChallengeTitlePhantomExpT roleTowerChallengeTitlePhantomExpT = new IRoleTowerChallengeTitlePhantomExpT();
			this.UnPackTo(roleTowerChallengeTitlePhantomExpT);
			return roleTowerChallengeTitlePhantomExpT;
		}

		// Token: 0x0601992D RID: 104749 RVA: 0x003A5363 File Offset: 0x003A3563
		public void UnPackTo(IRoleTowerChallengeTitlePhantomExpT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601992E RID: 104750 RVA: 0x003A5374 File Offset: 0x003A3574
		public static Offset<IRoleTowerChallengeTitlePhantomExp> Pack(FlatBufferBuilder builder, IRoleTowerChallengeTitlePhantomExpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerChallengeTitlePhantomExp>);
			}
			return IRoleTowerChallengeTitlePhantomExp.CreateIRoleTowerChallengeTitlePhantomExp(builder, _o.Type);
		}

		// Token: 0x0400C641 RID: 50753
		private Table __p;
	}
}
