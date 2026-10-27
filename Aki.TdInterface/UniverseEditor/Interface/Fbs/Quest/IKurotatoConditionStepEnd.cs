using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EDE RID: 16094
	public struct IKurotatoConditionStepEnd : IFlatbufferObject
	{
		// Token: 0x17006FB2 RID: 28594
		// (get) Token: 0x06016C3F RID: 93247 RVA: 0x00349149 File Offset: 0x00347349
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016C40 RID: 93248 RVA: 0x00349156 File Offset: 0x00347356
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016C41 RID: 93249 RVA: 0x00349160 File Offset: 0x00347360
		public static IKurotatoConditionStepEnd GetRootAsIKurotatoConditionStepEnd(ByteBuffer _bb)
		{
			return IKurotatoConditionStepEnd.GetRootAsIKurotatoConditionStepEnd(_bb, default(IKurotatoConditionStepEnd));
		}

		// Token: 0x06016C42 RID: 93250 RVA: 0x0034917C File Offset: 0x0034737C
		public static IKurotatoConditionStepEnd GetRootAsIKurotatoConditionStepEnd(ByteBuffer _bb, IKurotatoConditionStepEnd obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016C43 RID: 93251 RVA: 0x00349199 File Offset: 0x00347399
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016C44 RID: 93252 RVA: 0x003491A8 File Offset: 0x003473A8
		public IKurotatoConditionStepEnd __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FB3 RID: 28595
		// (get) Token: 0x06016C45 RID: 93253 RVA: 0x003491B8 File Offset: 0x003473B8
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

		// Token: 0x06016C46 RID: 93254 RVA: 0x003491F4 File Offset: 0x003473F4
		public static Offset<IKurotatoConditionStepEnd> CreateIKurotatoConditionStepEnd(FlatBufferBuilder builder, EKurotatoConditionStep Type = EKurotatoConditionStep.Prepare)
		{
			builder.StartTable(1);
			IKurotatoConditionStepEnd.AddType(builder, Type);
			return IKurotatoConditionStepEnd.EndIKurotatoConditionStepEnd(builder);
		}

		// Token: 0x06016C47 RID: 93255 RVA: 0x0034920A File Offset: 0x0034740A
		public static void StartIKurotatoConditionStepEnd(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016C48 RID: 93256 RVA: 0x00349213 File Offset: 0x00347413
		public static void AddType(FlatBufferBuilder builder, EKurotatoConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016C49 RID: 93257 RVA: 0x0034921E File Offset: 0x0034741E
		public static Offset<IKurotatoConditionStepEnd> EndIKurotatoConditionStepEnd(FlatBufferBuilder builder)
		{
			return new Offset<IKurotatoConditionStepEnd>(builder.EndTable());
		}

		// Token: 0x06016C4A RID: 93258 RVA: 0x0034922C File Offset: 0x0034742C
		public IKurotatoConditionStepEndT UnPack()
		{
			IKurotatoConditionStepEndT kurotatoConditionStepEndT = new IKurotatoConditionStepEndT();
			this.UnPackTo(kurotatoConditionStepEndT);
			return kurotatoConditionStepEndT;
		}

		// Token: 0x06016C4B RID: 93259 RVA: 0x00349247 File Offset: 0x00347447
		public void UnPackTo(IKurotatoConditionStepEndT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016C4C RID: 93260 RVA: 0x00349258 File Offset: 0x00347458
		public static Offset<IKurotatoConditionStepEnd> Pack(FlatBufferBuilder builder, IKurotatoConditionStepEndT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKurotatoConditionStepEnd>);
			}
			return IKurotatoConditionStepEnd.CreateIKurotatoConditionStepEnd(builder, _o.Type);
		}

		// Token: 0x0400B8C1 RID: 47297
		private Table __p;
	}
}
