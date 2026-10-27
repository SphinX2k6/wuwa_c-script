using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004163 RID: 16739
	public struct ISurvivorsRougeConditionStepEnd : IFlatbufferObject
	{
		// Token: 0x17007695 RID: 30357
		// (get) Token: 0x06018958 RID: 100696 RVA: 0x0038ABED File Offset: 0x00388DED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018959 RID: 100697 RVA: 0x0038ABFA File Offset: 0x00388DFA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601895A RID: 100698 RVA: 0x0038AC04 File Offset: 0x00388E04
		public static ISurvivorsRougeConditionStepEnd GetRootAsISurvivorsRougeConditionStepEnd(ByteBuffer _bb)
		{
			return ISurvivorsRougeConditionStepEnd.GetRootAsISurvivorsRougeConditionStepEnd(_bb, default(ISurvivorsRougeConditionStepEnd));
		}

		// Token: 0x0601895B RID: 100699 RVA: 0x0038AC20 File Offset: 0x00388E20
		public static ISurvivorsRougeConditionStepEnd GetRootAsISurvivorsRougeConditionStepEnd(ByteBuffer _bb, ISurvivorsRougeConditionStepEnd obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601895C RID: 100700 RVA: 0x0038AC3D File Offset: 0x00388E3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601895D RID: 100701 RVA: 0x0038AC4C File Offset: 0x00388E4C
		public ISurvivorsRougeConditionStepEnd __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007696 RID: 30358
		// (get) Token: 0x0601895E RID: 100702 RVA: 0x0038AC5C File Offset: 0x00388E5C
		public ESurvivorsRougeConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESurvivorsRougeConditionStep.Prepare;
				}
				return (ESurvivorsRougeConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601895F RID: 100703 RVA: 0x0038AC98 File Offset: 0x00388E98
		public static Offset<ISurvivorsRougeConditionStepEnd> CreateISurvivorsRougeConditionStepEnd(FlatBufferBuilder builder, ESurvivorsRougeConditionStep Type = ESurvivorsRougeConditionStep.Prepare)
		{
			builder.StartTable(1);
			ISurvivorsRougeConditionStepEnd.AddType(builder, Type);
			return ISurvivorsRougeConditionStepEnd.EndISurvivorsRougeConditionStepEnd(builder);
		}

		// Token: 0x06018960 RID: 100704 RVA: 0x0038ACAE File Offset: 0x00388EAE
		public static void StartISurvivorsRougeConditionStepEnd(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018961 RID: 100705 RVA: 0x0038ACB7 File Offset: 0x00388EB7
		public static void AddType(FlatBufferBuilder builder, ESurvivorsRougeConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018962 RID: 100706 RVA: 0x0038ACC2 File Offset: 0x00388EC2
		public static Offset<ISurvivorsRougeConditionStepEnd> EndISurvivorsRougeConditionStepEnd(FlatBufferBuilder builder)
		{
			return new Offset<ISurvivorsRougeConditionStepEnd>(builder.EndTable());
		}

		// Token: 0x06018963 RID: 100707 RVA: 0x0038ACD0 File Offset: 0x00388ED0
		public ISurvivorsRougeConditionStepEndT UnPack()
		{
			ISurvivorsRougeConditionStepEndT survivorsRougeConditionStepEndT = new ISurvivorsRougeConditionStepEndT();
			this.UnPackTo(survivorsRougeConditionStepEndT);
			return survivorsRougeConditionStepEndT;
		}

		// Token: 0x06018964 RID: 100708 RVA: 0x0038ACEB File Offset: 0x00388EEB
		public void UnPackTo(ISurvivorsRougeConditionStepEndT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06018965 RID: 100709 RVA: 0x0038ACFC File Offset: 0x00388EFC
		public static Offset<ISurvivorsRougeConditionStepEnd> Pack(FlatBufferBuilder builder, ISurvivorsRougeConditionStepEndT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISurvivorsRougeConditionStepEnd>);
			}
			return ISurvivorsRougeConditionStepEnd.CreateISurvivorsRougeConditionStepEnd(builder, _o.Type);
		}

		// Token: 0x0400BD81 RID: 48513
		private Table __p;
	}
}
