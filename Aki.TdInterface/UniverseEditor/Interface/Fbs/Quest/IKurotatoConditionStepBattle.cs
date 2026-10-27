using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003ED8 RID: 16088
	public struct IKurotatoConditionStepBattle : IFlatbufferObject
	{
		// Token: 0x17006FAC RID: 28588
		// (get) Token: 0x06016C1B RID: 93211 RVA: 0x00348E5C File Offset: 0x0034705C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016C1C RID: 93212 RVA: 0x00348E69 File Offset: 0x00347069
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016C1D RID: 93213 RVA: 0x00348E70 File Offset: 0x00347070
		public static IKurotatoConditionStepBattle GetRootAsIKurotatoConditionStepBattle(ByteBuffer _bb)
		{
			return IKurotatoConditionStepBattle.GetRootAsIKurotatoConditionStepBattle(_bb, default(IKurotatoConditionStepBattle));
		}

		// Token: 0x06016C1E RID: 93214 RVA: 0x00348E8C File Offset: 0x0034708C
		public static IKurotatoConditionStepBattle GetRootAsIKurotatoConditionStepBattle(ByteBuffer _bb, IKurotatoConditionStepBattle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016C1F RID: 93215 RVA: 0x00348EA9 File Offset: 0x003470A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016C20 RID: 93216 RVA: 0x00348EB8 File Offset: 0x003470B8
		public IKurotatoConditionStepBattle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FAD RID: 28589
		// (get) Token: 0x06016C21 RID: 93217 RVA: 0x00348EC8 File Offset: 0x003470C8
		public EKurotatoConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EKurotatoConditionStep.Prepare;
				}
				return (EKurotatoConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016C22 RID: 93218 RVA: 0x00348F04 File Offset: 0x00347104
		public static Offset<IKurotatoConditionStepBattle> CreateIKurotatoConditionStepBattle(FlatBufferBuilder builder, EKurotatoConditionStep Type = EKurotatoConditionStep.Prepare)
		{
			builder.StartTable(1);
			IKurotatoConditionStepBattle.AddType(builder, Type);
			return IKurotatoConditionStepBattle.EndIKurotatoConditionStepBattle(builder);
		}

		// Token: 0x06016C23 RID: 93219 RVA: 0x00348F1A File Offset: 0x0034711A
		public static void StartIKurotatoConditionStepBattle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016C24 RID: 93220 RVA: 0x00348F23 File Offset: 0x00347123
		public static void AddType(FlatBufferBuilder builder, EKurotatoConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016C25 RID: 93221 RVA: 0x00348F2E File Offset: 0x0034712E
		public static Offset<IKurotatoConditionStepBattle> EndIKurotatoConditionStepBattle(FlatBufferBuilder builder)
		{
			return new Offset<IKurotatoConditionStepBattle>(builder.EndTable());
		}

		// Token: 0x06016C26 RID: 93222 RVA: 0x00348F3C File Offset: 0x0034713C
		public IKurotatoConditionStepBattleT UnPack()
		{
			IKurotatoConditionStepBattleT kurotatoConditionStepBattleT = new IKurotatoConditionStepBattleT();
			this.UnPackTo(kurotatoConditionStepBattleT);
			return kurotatoConditionStepBattleT;
		}

		// Token: 0x06016C27 RID: 93223 RVA: 0x00348F57 File Offset: 0x00347157
		public void UnPackTo(IKurotatoConditionStepBattleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016C28 RID: 93224 RVA: 0x00348F68 File Offset: 0x00347168
		public static Offset<IKurotatoConditionStepBattle> Pack(FlatBufferBuilder builder, IKurotatoConditionStepBattleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKurotatoConditionStepBattle>);
			}
			return IKurotatoConditionStepBattle.CreateIKurotatoConditionStepBattle(builder, _o.Type);
		}

		// Token: 0x0400B8BD RID: 47293
		private Table __p;
	}
}
