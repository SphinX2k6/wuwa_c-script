using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004316 RID: 17174
	public struct IKurotatoConditionStepBattle : IFlatbufferObject
	{
		// Token: 0x1700759B RID: 30107
		// (get) Token: 0x06018272 RID: 98930 RVA: 0x00372028 File Offset: 0x00370228
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018273 RID: 98931 RVA: 0x00372035 File Offset: 0x00370235
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018274 RID: 98932 RVA: 0x0037203C File Offset: 0x0037023C
		public static IKurotatoConditionStepBattle GetRootAsIKurotatoConditionStepBattle(ByteBuffer _bb)
		{
			return IKurotatoConditionStepBattle.GetRootAsIKurotatoConditionStepBattle(_bb, default(IKurotatoConditionStepBattle));
		}

		// Token: 0x06018275 RID: 98933 RVA: 0x00372058 File Offset: 0x00370258
		public static IKurotatoConditionStepBattle GetRootAsIKurotatoConditionStepBattle(ByteBuffer _bb, IKurotatoConditionStepBattle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018276 RID: 98934 RVA: 0x00372075 File Offset: 0x00370275
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018277 RID: 98935 RVA: 0x00372084 File Offset: 0x00370284
		public IKurotatoConditionStepBattle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700759C RID: 30108
		// (get) Token: 0x06018278 RID: 98936 RVA: 0x00372094 File Offset: 0x00370294
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

		// Token: 0x06018279 RID: 98937 RVA: 0x003720D0 File Offset: 0x003702D0
		public static Offset<IKurotatoConditionStepBattle> CreateIKurotatoConditionStepBattle(FlatBufferBuilder builder, EKurotatoConditionStep Type = EKurotatoConditionStep.Prepare)
		{
			builder.StartTable(1);
			IKurotatoConditionStepBattle.AddType(builder, Type);
			return IKurotatoConditionStepBattle.EndIKurotatoConditionStepBattle(builder);
		}

		// Token: 0x0601827A RID: 98938 RVA: 0x003720E6 File Offset: 0x003702E6
		public static void StartIKurotatoConditionStepBattle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601827B RID: 98939 RVA: 0x003720EF File Offset: 0x003702EF
		public static void AddType(FlatBufferBuilder builder, EKurotatoConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601827C RID: 98940 RVA: 0x003720FA File Offset: 0x003702FA
		public static Offset<IKurotatoConditionStepBattle> EndIKurotatoConditionStepBattle(FlatBufferBuilder builder)
		{
			return new Offset<IKurotatoConditionStepBattle>(builder.EndTable());
		}

		// Token: 0x0601827D RID: 98941 RVA: 0x00372108 File Offset: 0x00370308
		public IKurotatoConditionStepBattleT UnPack()
		{
			IKurotatoConditionStepBattleT kurotatoConditionStepBattleT = new IKurotatoConditionStepBattleT();
			this.UnPackTo(kurotatoConditionStepBattleT);
			return kurotatoConditionStepBattleT;
		}

		// Token: 0x0601827E RID: 98942 RVA: 0x00372123 File Offset: 0x00370323
		public void UnPackTo(IKurotatoConditionStepBattleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601827F RID: 98943 RVA: 0x00372134 File Offset: 0x00370334
		public static Offset<IKurotatoConditionStepBattle> Pack(FlatBufferBuilder builder, IKurotatoConditionStepBattleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKurotatoConditionStepBattle>);
			}
			return IKurotatoConditionStepBattle.CreateIKurotatoConditionStepBattle(builder, _o.Type);
		}

		// Token: 0x0400C29A RID: 49818
		private Table __p;
	}
}
