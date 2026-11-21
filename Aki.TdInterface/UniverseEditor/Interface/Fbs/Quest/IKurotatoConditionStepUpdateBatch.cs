using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004328 RID: 17192
	public struct IKurotatoConditionStepUpdateBatch : IFlatbufferObject
	{
		// Token: 0x170075AD RID: 30125
		// (get) Token: 0x060182DE RID: 99038 RVA: 0x003728F5 File Offset: 0x00370AF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060182DF RID: 99039 RVA: 0x00372902 File Offset: 0x00370B02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060182E0 RID: 99040 RVA: 0x0037290C File Offset: 0x00370B0C
		public static IKurotatoConditionStepUpdateBatch GetRootAsIKurotatoConditionStepUpdateBatch(ByteBuffer _bb)
		{
			return IKurotatoConditionStepUpdateBatch.GetRootAsIKurotatoConditionStepUpdateBatch(_bb, default(IKurotatoConditionStepUpdateBatch));
		}

		// Token: 0x060182E1 RID: 99041 RVA: 0x00372928 File Offset: 0x00370B28
		public static IKurotatoConditionStepUpdateBatch GetRootAsIKurotatoConditionStepUpdateBatch(ByteBuffer _bb, IKurotatoConditionStepUpdateBatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060182E2 RID: 99042 RVA: 0x00372945 File Offset: 0x00370B45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060182E3 RID: 99043 RVA: 0x00372954 File Offset: 0x00370B54
		public IKurotatoConditionStepUpdateBatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170075AE RID: 30126
		// (get) Token: 0x060182E4 RID: 99044 RVA: 0x00372964 File Offset: 0x00370B64
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

		// Token: 0x060182E5 RID: 99045 RVA: 0x003729A0 File Offset: 0x00370BA0
		public static Offset<IKurotatoConditionStepUpdateBatch> CreateIKurotatoConditionStepUpdateBatch(FlatBufferBuilder builder, EKurotatoConditionStep Type = EKurotatoConditionStep.Prepare)
		{
			builder.StartTable(1);
			IKurotatoConditionStepUpdateBatch.AddType(builder, Type);
			return IKurotatoConditionStepUpdateBatch.EndIKurotatoConditionStepUpdateBatch(builder);
		}

		// Token: 0x060182E6 RID: 99046 RVA: 0x003729B6 File Offset: 0x00370BB6
		public static void StartIKurotatoConditionStepUpdateBatch(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060182E7 RID: 99047 RVA: 0x003729BF File Offset: 0x00370BBF
		public static void AddType(FlatBufferBuilder builder, EKurotatoConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060182E8 RID: 99048 RVA: 0x003729CA File Offset: 0x00370BCA
		public static Offset<IKurotatoConditionStepUpdateBatch> EndIKurotatoConditionStepUpdateBatch(FlatBufferBuilder builder)
		{
			return new Offset<IKurotatoConditionStepUpdateBatch>(builder.EndTable());
		}

		// Token: 0x060182E9 RID: 99049 RVA: 0x003729D8 File Offset: 0x00370BD8
		public IKurotatoConditionStepUpdateBatchT UnPack()
		{
			IKurotatoConditionStepUpdateBatchT kurotatoConditionStepUpdateBatchT = new IKurotatoConditionStepUpdateBatchT();
			this.UnPackTo(kurotatoConditionStepUpdateBatchT);
			return kurotatoConditionStepUpdateBatchT;
		}

		// Token: 0x060182EA RID: 99050 RVA: 0x003729F3 File Offset: 0x00370BF3
		public void UnPackTo(IKurotatoConditionStepUpdateBatchT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060182EB RID: 99051 RVA: 0x00372A04 File Offset: 0x00370C04
		public static Offset<IKurotatoConditionStepUpdateBatch> Pack(FlatBufferBuilder builder, IKurotatoConditionStepUpdateBatchT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKurotatoConditionStepUpdateBatch>);
			}
			return IKurotatoConditionStepUpdateBatch.CreateIKurotatoConditionStepUpdateBatch(builder, _o.Type);
		}

		// Token: 0x0400C2A6 RID: 49830
		private Table __p;
	}
}
