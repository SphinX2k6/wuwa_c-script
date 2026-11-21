using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200431F RID: 17183
	public struct IKurotatoConditionStepPrepare : IFlatbufferObject
	{
		// Token: 0x170075A4 RID: 30116
		// (get) Token: 0x060182A8 RID: 98984 RVA: 0x0037248D File Offset: 0x0037068D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060182A9 RID: 98985 RVA: 0x0037249A File Offset: 0x0037069A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060182AA RID: 98986 RVA: 0x003724A4 File Offset: 0x003706A4
		public static IKurotatoConditionStepPrepare GetRootAsIKurotatoConditionStepPrepare(ByteBuffer _bb)
		{
			return IKurotatoConditionStepPrepare.GetRootAsIKurotatoConditionStepPrepare(_bb, default(IKurotatoConditionStepPrepare));
		}

		// Token: 0x060182AB RID: 98987 RVA: 0x003724C0 File Offset: 0x003706C0
		public static IKurotatoConditionStepPrepare GetRootAsIKurotatoConditionStepPrepare(ByteBuffer _bb, IKurotatoConditionStepPrepare obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060182AC RID: 98988 RVA: 0x003724DD File Offset: 0x003706DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060182AD RID: 98989 RVA: 0x003724EC File Offset: 0x003706EC
		public IKurotatoConditionStepPrepare __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170075A5 RID: 30117
		// (get) Token: 0x060182AE RID: 98990 RVA: 0x003724FC File Offset: 0x003706FC
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

		// Token: 0x060182AF RID: 98991 RVA: 0x00372538 File Offset: 0x00370738
		public static Offset<IKurotatoConditionStepPrepare> CreateIKurotatoConditionStepPrepare(FlatBufferBuilder builder, EKurotatoConditionStep Type = EKurotatoConditionStep.Prepare)
		{
			builder.StartTable(1);
			IKurotatoConditionStepPrepare.AddType(builder, Type);
			return IKurotatoConditionStepPrepare.EndIKurotatoConditionStepPrepare(builder);
		}

		// Token: 0x060182B0 RID: 98992 RVA: 0x0037254E File Offset: 0x0037074E
		public static void StartIKurotatoConditionStepPrepare(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060182B1 RID: 98993 RVA: 0x00372557 File Offset: 0x00370757
		public static void AddType(FlatBufferBuilder builder, EKurotatoConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060182B2 RID: 98994 RVA: 0x00372562 File Offset: 0x00370762
		public static Offset<IKurotatoConditionStepPrepare> EndIKurotatoConditionStepPrepare(FlatBufferBuilder builder)
		{
			return new Offset<IKurotatoConditionStepPrepare>(builder.EndTable());
		}

		// Token: 0x060182B3 RID: 98995 RVA: 0x00372570 File Offset: 0x00370770
		public IKurotatoConditionStepPrepareT UnPack()
		{
			IKurotatoConditionStepPrepareT kurotatoConditionStepPrepareT = new IKurotatoConditionStepPrepareT();
			this.UnPackTo(kurotatoConditionStepPrepareT);
			return kurotatoConditionStepPrepareT;
		}

		// Token: 0x060182B4 RID: 98996 RVA: 0x0037258B File Offset: 0x0037078B
		public void UnPackTo(IKurotatoConditionStepPrepareT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060182B5 RID: 98997 RVA: 0x0037259C File Offset: 0x0037079C
		public static Offset<IKurotatoConditionStepPrepare> Pack(FlatBufferBuilder builder, IKurotatoConditionStepPrepareT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKurotatoConditionStepPrepare>);
			}
			return IKurotatoConditionStepPrepare.CreateIKurotatoConditionStepPrepare(builder, _o.Type);
		}

		// Token: 0x0400C2A0 RID: 49824
		private Table __p;
	}
}
