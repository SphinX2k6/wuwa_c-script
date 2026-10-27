using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EEA RID: 16106
	public struct IKurotatoConditionStepUpdateBatch : IFlatbufferObject
	{
		// Token: 0x17006FBE RID: 28606
		// (get) Token: 0x06016C87 RID: 93319 RVA: 0x00349729 File Offset: 0x00347929
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016C88 RID: 93320 RVA: 0x00349736 File Offset: 0x00347936
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016C89 RID: 93321 RVA: 0x00349740 File Offset: 0x00347940
		public static IKurotatoConditionStepUpdateBatch GetRootAsIKurotatoConditionStepUpdateBatch(ByteBuffer _bb)
		{
			return IKurotatoConditionStepUpdateBatch.GetRootAsIKurotatoConditionStepUpdateBatch(_bb, default(IKurotatoConditionStepUpdateBatch));
		}

		// Token: 0x06016C8A RID: 93322 RVA: 0x0034975C File Offset: 0x0034795C
		public static IKurotatoConditionStepUpdateBatch GetRootAsIKurotatoConditionStepUpdateBatch(ByteBuffer _bb, IKurotatoConditionStepUpdateBatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016C8B RID: 93323 RVA: 0x00349779 File Offset: 0x00347979
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016C8C RID: 93324 RVA: 0x00349788 File Offset: 0x00347988
		public IKurotatoConditionStepUpdateBatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FBF RID: 28607
		// (get) Token: 0x06016C8D RID: 93325 RVA: 0x00349798 File Offset: 0x00347998
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

		// Token: 0x06016C8E RID: 93326 RVA: 0x003497D4 File Offset: 0x003479D4
		public static Offset<IKurotatoConditionStepUpdateBatch> CreateIKurotatoConditionStepUpdateBatch(FlatBufferBuilder builder, EKurotatoConditionStep Type = EKurotatoConditionStep.Prepare)
		{
			builder.StartTable(1);
			IKurotatoConditionStepUpdateBatch.AddType(builder, Type);
			return IKurotatoConditionStepUpdateBatch.EndIKurotatoConditionStepUpdateBatch(builder);
		}

		// Token: 0x06016C8F RID: 93327 RVA: 0x003497EA File Offset: 0x003479EA
		public static void StartIKurotatoConditionStepUpdateBatch(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016C90 RID: 93328 RVA: 0x003497F3 File Offset: 0x003479F3
		public static void AddType(FlatBufferBuilder builder, EKurotatoConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016C91 RID: 93329 RVA: 0x003497FE File Offset: 0x003479FE
		public static Offset<IKurotatoConditionStepUpdateBatch> EndIKurotatoConditionStepUpdateBatch(FlatBufferBuilder builder)
		{
			return new Offset<IKurotatoConditionStepUpdateBatch>(builder.EndTable());
		}

		// Token: 0x06016C92 RID: 93330 RVA: 0x0034980C File Offset: 0x00347A0C
		public IKurotatoConditionStepUpdateBatchT UnPack()
		{
			IKurotatoConditionStepUpdateBatchT kurotatoConditionStepUpdateBatchT = new IKurotatoConditionStepUpdateBatchT();
			this.UnPackTo(kurotatoConditionStepUpdateBatchT);
			return kurotatoConditionStepUpdateBatchT;
		}

		// Token: 0x06016C93 RID: 93331 RVA: 0x00349827 File Offset: 0x00347A27
		public void UnPackTo(IKurotatoConditionStepUpdateBatchT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016C94 RID: 93332 RVA: 0x00349838 File Offset: 0x00347A38
		public static Offset<IKurotatoConditionStepUpdateBatch> Pack(FlatBufferBuilder builder, IKurotatoConditionStepUpdateBatchT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKurotatoConditionStepUpdateBatch>);
			}
			return IKurotatoConditionStepUpdateBatch.CreateIKurotatoConditionStepUpdateBatch(builder, _o.Type);
		}

		// Token: 0x0400B8C9 RID: 47305
		private Table __p;
	}
}
