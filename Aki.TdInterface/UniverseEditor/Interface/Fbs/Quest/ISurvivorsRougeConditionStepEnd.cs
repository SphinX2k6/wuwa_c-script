using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045A7 RID: 17831
	public struct ISurvivorsRougeConditionStepEnd : IFlatbufferObject
	{
		// Token: 0x17007CA4 RID: 31908
		// (get) Token: 0x0601A020 RID: 106528 RVA: 0x003B51A9 File Offset: 0x003B33A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A021 RID: 106529 RVA: 0x003B51B6 File Offset: 0x003B33B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A022 RID: 106530 RVA: 0x003B51C0 File Offset: 0x003B33C0
		public static ISurvivorsRougeConditionStepEnd GetRootAsISurvivorsRougeConditionStepEnd(ByteBuffer _bb)
		{
			return ISurvivorsRougeConditionStepEnd.GetRootAsISurvivorsRougeConditionStepEnd(_bb, default(ISurvivorsRougeConditionStepEnd));
		}

		// Token: 0x0601A023 RID: 106531 RVA: 0x003B51DC File Offset: 0x003B33DC
		public static ISurvivorsRougeConditionStepEnd GetRootAsISurvivorsRougeConditionStepEnd(ByteBuffer _bb, ISurvivorsRougeConditionStepEnd obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A024 RID: 106532 RVA: 0x003B51F9 File Offset: 0x003B33F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A025 RID: 106533 RVA: 0x003B5208 File Offset: 0x003B3408
		public ISurvivorsRougeConditionStepEnd __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007CA5 RID: 31909
		// (get) Token: 0x0601A026 RID: 106534 RVA: 0x003B5218 File Offset: 0x003B3418
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

		// Token: 0x0601A027 RID: 106535 RVA: 0x003B5254 File Offset: 0x003B3454
		public static Offset<ISurvivorsRougeConditionStepEnd> CreateISurvivorsRougeConditionStepEnd(FlatBufferBuilder builder, ESurvivorsRougeConditionStep Type = ESurvivorsRougeConditionStep.Prepare)
		{
			builder.StartTable(1);
			ISurvivorsRougeConditionStepEnd.AddType(builder, Type);
			return ISurvivorsRougeConditionStepEnd.EndISurvivorsRougeConditionStepEnd(builder);
		}

		// Token: 0x0601A028 RID: 106536 RVA: 0x003B526A File Offset: 0x003B346A
		public static void StartISurvivorsRougeConditionStepEnd(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A029 RID: 106537 RVA: 0x003B5273 File Offset: 0x003B3473
		public static void AddType(FlatBufferBuilder builder, ESurvivorsRougeConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A02A RID: 106538 RVA: 0x003B527E File Offset: 0x003B347E
		public static Offset<ISurvivorsRougeConditionStepEnd> EndISurvivorsRougeConditionStepEnd(FlatBufferBuilder builder)
		{
			return new Offset<ISurvivorsRougeConditionStepEnd>(builder.EndTable());
		}

		// Token: 0x0601A02B RID: 106539 RVA: 0x003B528C File Offset: 0x003B348C
		public ISurvivorsRougeConditionStepEndT UnPack()
		{
			ISurvivorsRougeConditionStepEndT survivorsRougeConditionStepEndT = new ISurvivorsRougeConditionStepEndT();
			this.UnPackTo(survivorsRougeConditionStepEndT);
			return survivorsRougeConditionStepEndT;
		}

		// Token: 0x0601A02C RID: 106540 RVA: 0x003B52A7 File Offset: 0x003B34A7
		public void UnPackTo(ISurvivorsRougeConditionStepEndT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A02D RID: 106541 RVA: 0x003B52B8 File Offset: 0x003B34B8
		public static Offset<ISurvivorsRougeConditionStepEnd> Pack(FlatBufferBuilder builder, ISurvivorsRougeConditionStepEndT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISurvivorsRougeConditionStepEnd>);
			}
			return ISurvivorsRougeConditionStepEnd.CreateISurvivorsRougeConditionStepEnd(builder, _o.Type);
		}

		// Token: 0x0400C76F RID: 51055
		private Table __p;
	}
}
