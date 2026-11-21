using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004310 RID: 17168
	public struct IKurotatoConditionStepBase : IFlatbufferObject
	{
		// Token: 0x17007596 RID: 30102
		// (get) Token: 0x06018246 RID: 98886 RVA: 0x00371BDD File Offset: 0x0036FDDD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018247 RID: 98887 RVA: 0x00371BEA File Offset: 0x0036FDEA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018248 RID: 98888 RVA: 0x00371BF4 File Offset: 0x0036FDF4
		public static IKurotatoConditionStepBase GetRootAsIKurotatoConditionStepBase(ByteBuffer _bb)
		{
			return IKurotatoConditionStepBase.GetRootAsIKurotatoConditionStepBase(_bb, default(IKurotatoConditionStepBase));
		}

		// Token: 0x06018249 RID: 98889 RVA: 0x00371C10 File Offset: 0x0036FE10
		public static IKurotatoConditionStepBase GetRootAsIKurotatoConditionStepBase(ByteBuffer _bb, IKurotatoConditionStepBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601824A RID: 98890 RVA: 0x00371C2D File Offset: 0x0036FE2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601824B RID: 98891 RVA: 0x00371C3C File Offset: 0x0036FE3C
		public IKurotatoConditionStepBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007597 RID: 30103
		// (get) Token: 0x0601824C RID: 98892 RVA: 0x00371C4C File Offset: 0x0036FE4C
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

		// Token: 0x0601824D RID: 98893 RVA: 0x00371C88 File Offset: 0x0036FE88
		public static Offset<IKurotatoConditionStepBase> CreateIKurotatoConditionStepBase(FlatBufferBuilder builder, EKurotatoConditionStep Type = EKurotatoConditionStep.Prepare)
		{
			builder.StartTable(1);
			IKurotatoConditionStepBase.AddType(builder, Type);
			return IKurotatoConditionStepBase.EndIKurotatoConditionStepBase(builder);
		}

		// Token: 0x0601824E RID: 98894 RVA: 0x00371C9E File Offset: 0x0036FE9E
		public static void StartIKurotatoConditionStepBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601824F RID: 98895 RVA: 0x00371CA7 File Offset: 0x0036FEA7
		public static void AddType(FlatBufferBuilder builder, EKurotatoConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018250 RID: 98896 RVA: 0x00371CB2 File Offset: 0x0036FEB2
		public static Offset<IKurotatoConditionStepBase> EndIKurotatoConditionStepBase(FlatBufferBuilder builder)
		{
			return new Offset<IKurotatoConditionStepBase>(builder.EndTable());
		}

		// Token: 0x06018251 RID: 98897 RVA: 0x00371CC0 File Offset: 0x0036FEC0
		public IKurotatoConditionStepBaseT UnPack()
		{
			IKurotatoConditionStepBaseT kurotatoConditionStepBaseT = new IKurotatoConditionStepBaseT();
			this.UnPackTo(kurotatoConditionStepBaseT);
			return kurotatoConditionStepBaseT;
		}

		// Token: 0x06018252 RID: 98898 RVA: 0x00371CDB File Offset: 0x0036FEDB
		public void UnPackTo(IKurotatoConditionStepBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06018253 RID: 98899 RVA: 0x00371CEC File Offset: 0x0036FEEC
		public static Offset<IKurotatoConditionStepBase> Pack(FlatBufferBuilder builder, IKurotatoConditionStepBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKurotatoConditionStepBase>);
			}
			return IKurotatoConditionStepBase.CreateIKurotatoConditionStepBase(builder, _o.Type);
		}

		// Token: 0x0400C28B RID: 49803
		private Table __p;
	}
}
