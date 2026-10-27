using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EE1 RID: 16097
	public struct IKurotatoConditionStepPrepare : IFlatbufferObject
	{
		// Token: 0x17006FB5 RID: 28597
		// (get) Token: 0x06016C51 RID: 93265 RVA: 0x003492C1 File Offset: 0x003474C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016C52 RID: 93266 RVA: 0x003492CE File Offset: 0x003474CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016C53 RID: 93267 RVA: 0x003492D8 File Offset: 0x003474D8
		public static IKurotatoConditionStepPrepare GetRootAsIKurotatoConditionStepPrepare(ByteBuffer _bb)
		{
			return IKurotatoConditionStepPrepare.GetRootAsIKurotatoConditionStepPrepare(_bb, default(IKurotatoConditionStepPrepare));
		}

		// Token: 0x06016C54 RID: 93268 RVA: 0x003492F4 File Offset: 0x003474F4
		public static IKurotatoConditionStepPrepare GetRootAsIKurotatoConditionStepPrepare(ByteBuffer _bb, IKurotatoConditionStepPrepare obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016C55 RID: 93269 RVA: 0x00349311 File Offset: 0x00347511
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016C56 RID: 93270 RVA: 0x00349320 File Offset: 0x00347520
		public IKurotatoConditionStepPrepare __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FB6 RID: 28598
		// (get) Token: 0x06016C57 RID: 93271 RVA: 0x00349330 File Offset: 0x00347530
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

		// Token: 0x06016C58 RID: 93272 RVA: 0x0034936C File Offset: 0x0034756C
		public static Offset<IKurotatoConditionStepPrepare> CreateIKurotatoConditionStepPrepare(FlatBufferBuilder builder, EKurotatoConditionStep Type = EKurotatoConditionStep.Prepare)
		{
			builder.StartTable(1);
			IKurotatoConditionStepPrepare.AddType(builder, Type);
			return IKurotatoConditionStepPrepare.EndIKurotatoConditionStepPrepare(builder);
		}

		// Token: 0x06016C59 RID: 93273 RVA: 0x00349382 File Offset: 0x00347582
		public static void StartIKurotatoConditionStepPrepare(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016C5A RID: 93274 RVA: 0x0034938B File Offset: 0x0034758B
		public static void AddType(FlatBufferBuilder builder, EKurotatoConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016C5B RID: 93275 RVA: 0x00349396 File Offset: 0x00347596
		public static Offset<IKurotatoConditionStepPrepare> EndIKurotatoConditionStepPrepare(FlatBufferBuilder builder)
		{
			return new Offset<IKurotatoConditionStepPrepare>(builder.EndTable());
		}

		// Token: 0x06016C5C RID: 93276 RVA: 0x003493A4 File Offset: 0x003475A4
		public IKurotatoConditionStepPrepareT UnPack()
		{
			IKurotatoConditionStepPrepareT kurotatoConditionStepPrepareT = new IKurotatoConditionStepPrepareT();
			this.UnPackTo(kurotatoConditionStepPrepareT);
			return kurotatoConditionStepPrepareT;
		}

		// Token: 0x06016C5D RID: 93277 RVA: 0x003493BF File Offset: 0x003475BF
		public void UnPackTo(IKurotatoConditionStepPrepareT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016C5E RID: 93278 RVA: 0x003493D0 File Offset: 0x003475D0
		public static Offset<IKurotatoConditionStepPrepare> Pack(FlatBufferBuilder builder, IKurotatoConditionStepPrepareT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKurotatoConditionStepPrepare>);
			}
			return IKurotatoConditionStepPrepare.CreateIKurotatoConditionStepPrepare(builder, _o.Type);
		}

		// Token: 0x0400B8C3 RID: 47299
		private Table __p;
	}
}
