using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004169 RID: 16745
	public struct ISurvivorsRougeConditionStepShopping : IFlatbufferObject
	{
		// Token: 0x1700769B RID: 30363
		// (get) Token: 0x0601897C RID: 100732 RVA: 0x0038AEDD File Offset: 0x003890DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601897D RID: 100733 RVA: 0x0038AEEA File Offset: 0x003890EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601897E RID: 100734 RVA: 0x0038AEF4 File Offset: 0x003890F4
		public static ISurvivorsRougeConditionStepShopping GetRootAsISurvivorsRougeConditionStepShopping(ByteBuffer _bb)
		{
			return ISurvivorsRougeConditionStepShopping.GetRootAsISurvivorsRougeConditionStepShopping(_bb, default(ISurvivorsRougeConditionStepShopping));
		}

		// Token: 0x0601897F RID: 100735 RVA: 0x0038AF10 File Offset: 0x00389110
		public static ISurvivorsRougeConditionStepShopping GetRootAsISurvivorsRougeConditionStepShopping(ByteBuffer _bb, ISurvivorsRougeConditionStepShopping obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018980 RID: 100736 RVA: 0x0038AF2D File Offset: 0x0038912D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018981 RID: 100737 RVA: 0x0038AF3C File Offset: 0x0038913C
		public ISurvivorsRougeConditionStepShopping __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700769C RID: 30364
		// (get) Token: 0x06018982 RID: 100738 RVA: 0x0038AF4C File Offset: 0x0038914C
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

		// Token: 0x06018983 RID: 100739 RVA: 0x0038AF88 File Offset: 0x00389188
		public static Offset<ISurvivorsRougeConditionStepShopping> CreateISurvivorsRougeConditionStepShopping(FlatBufferBuilder builder, ESurvivorsRougeConditionStep Type = ESurvivorsRougeConditionStep.Prepare)
		{
			builder.StartTable(1);
			ISurvivorsRougeConditionStepShopping.AddType(builder, Type);
			return ISurvivorsRougeConditionStepShopping.EndISurvivorsRougeConditionStepShopping(builder);
		}

		// Token: 0x06018984 RID: 100740 RVA: 0x0038AF9E File Offset: 0x0038919E
		public static void StartISurvivorsRougeConditionStepShopping(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018985 RID: 100741 RVA: 0x0038AFA7 File Offset: 0x003891A7
		public static void AddType(FlatBufferBuilder builder, ESurvivorsRougeConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018986 RID: 100742 RVA: 0x0038AFB2 File Offset: 0x003891B2
		public static Offset<ISurvivorsRougeConditionStepShopping> EndISurvivorsRougeConditionStepShopping(FlatBufferBuilder builder)
		{
			return new Offset<ISurvivorsRougeConditionStepShopping>(builder.EndTable());
		}

		// Token: 0x06018987 RID: 100743 RVA: 0x0038AFC0 File Offset: 0x003891C0
		public ISurvivorsRougeConditionStepShoppingT UnPack()
		{
			ISurvivorsRougeConditionStepShoppingT survivorsRougeConditionStepShoppingT = new ISurvivorsRougeConditionStepShoppingT();
			this.UnPackTo(survivorsRougeConditionStepShoppingT);
			return survivorsRougeConditionStepShoppingT;
		}

		// Token: 0x06018988 RID: 100744 RVA: 0x0038AFDB File Offset: 0x003891DB
		public void UnPackTo(ISurvivorsRougeConditionStepShoppingT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06018989 RID: 100745 RVA: 0x0038AFEC File Offset: 0x003891EC
		public static Offset<ISurvivorsRougeConditionStepShopping> Pack(FlatBufferBuilder builder, ISurvivorsRougeConditionStepShoppingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISurvivorsRougeConditionStepShopping>);
			}
			return ISurvivorsRougeConditionStepShopping.CreateISurvivorsRougeConditionStepShopping(builder, _o.Type);
		}

		// Token: 0x0400BD85 RID: 48517
		private Table __p;
	}
}
