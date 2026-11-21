using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004508 RID: 17672
	public struct IRoleTowerChallengeTitleTypeBase : IFlatbufferObject
	{
		// Token: 0x17007B03 RID: 31491
		// (get) Token: 0x06019933 RID: 104755 RVA: 0x003A53DD File Offset: 0x003A35DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019934 RID: 104756 RVA: 0x003A53EA File Offset: 0x003A35EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019935 RID: 104757 RVA: 0x003A53F4 File Offset: 0x003A35F4
		public static IRoleTowerChallengeTitleTypeBase GetRootAsIRoleTowerChallengeTitleTypeBase(ByteBuffer _bb)
		{
			return IRoleTowerChallengeTitleTypeBase.GetRootAsIRoleTowerChallengeTitleTypeBase(_bb, default(IRoleTowerChallengeTitleTypeBase));
		}

		// Token: 0x06019936 RID: 104758 RVA: 0x003A5410 File Offset: 0x003A3610
		public static IRoleTowerChallengeTitleTypeBase GetRootAsIRoleTowerChallengeTitleTypeBase(ByteBuffer _bb, IRoleTowerChallengeTitleTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019937 RID: 104759 RVA: 0x003A542D File Offset: 0x003A362D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019938 RID: 104760 RVA: 0x003A543C File Offset: 0x003A363C
		public IRoleTowerChallengeTitleTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B04 RID: 31492
		// (get) Token: 0x06019939 RID: 104761 RVA: 0x003A544C File Offset: 0x003A364C
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

		// Token: 0x0601993A RID: 104762 RVA: 0x003A5488 File Offset: 0x003A3688
		public static Offset<IRoleTowerChallengeTitleTypeBase> CreateIRoleTowerChallengeTitleTypeBase(FlatBufferBuilder builder, ERoleTowerChallengeTitleType Type = ERoleTowerChallengeTitleType.KillProgress)
		{
			builder.StartTable(1);
			IRoleTowerChallengeTitleTypeBase.AddType(builder, Type);
			return IRoleTowerChallengeTitleTypeBase.EndIRoleTowerChallengeTitleTypeBase(builder);
		}

		// Token: 0x0601993B RID: 104763 RVA: 0x003A549E File Offset: 0x003A369E
		public static void StartIRoleTowerChallengeTitleTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601993C RID: 104764 RVA: 0x003A54A7 File Offset: 0x003A36A7
		public static void AddType(FlatBufferBuilder builder, ERoleTowerChallengeTitleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601993D RID: 104765 RVA: 0x003A54B2 File Offset: 0x003A36B2
		public static Offset<IRoleTowerChallengeTitleTypeBase> EndIRoleTowerChallengeTitleTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerChallengeTitleTypeBase>(builder.EndTable());
		}

		// Token: 0x0601993E RID: 104766 RVA: 0x003A54C0 File Offset: 0x003A36C0
		public IRoleTowerChallengeTitleTypeBaseT UnPack()
		{
			IRoleTowerChallengeTitleTypeBaseT roleTowerChallengeTitleTypeBaseT = new IRoleTowerChallengeTitleTypeBaseT();
			this.UnPackTo(roleTowerChallengeTitleTypeBaseT);
			return roleTowerChallengeTitleTypeBaseT;
		}

		// Token: 0x0601993F RID: 104767 RVA: 0x003A54DB File Offset: 0x003A36DB
		public void UnPackTo(IRoleTowerChallengeTitleTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019940 RID: 104768 RVA: 0x003A54EC File Offset: 0x003A36EC
		public static Offset<IRoleTowerChallengeTitleTypeBase> Pack(FlatBufferBuilder builder, IRoleTowerChallengeTitleTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerChallengeTitleTypeBase>);
			}
			return IRoleTowerChallengeTitleTypeBase.CreateIRoleTowerChallengeTitleTypeBase(builder, _o.Type);
		}

		// Token: 0x0400C643 RID: 50755
		private Table __p;
	}
}
