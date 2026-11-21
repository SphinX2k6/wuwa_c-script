using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045AD RID: 17837
	public struct ISurvivorsRougeConditionStepShopping : IFlatbufferObject
	{
		// Token: 0x17007CAA RID: 31914
		// (get) Token: 0x0601A044 RID: 106564 RVA: 0x003B5499 File Offset: 0x003B3699
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A045 RID: 106565 RVA: 0x003B54A6 File Offset: 0x003B36A6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A046 RID: 106566 RVA: 0x003B54B0 File Offset: 0x003B36B0
		public static ISurvivorsRougeConditionStepShopping GetRootAsISurvivorsRougeConditionStepShopping(ByteBuffer _bb)
		{
			return ISurvivorsRougeConditionStepShopping.GetRootAsISurvivorsRougeConditionStepShopping(_bb, default(ISurvivorsRougeConditionStepShopping));
		}

		// Token: 0x0601A047 RID: 106567 RVA: 0x003B54CC File Offset: 0x003B36CC
		public static ISurvivorsRougeConditionStepShopping GetRootAsISurvivorsRougeConditionStepShopping(ByteBuffer _bb, ISurvivorsRougeConditionStepShopping obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A048 RID: 106568 RVA: 0x003B54E9 File Offset: 0x003B36E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A049 RID: 106569 RVA: 0x003B54F8 File Offset: 0x003B36F8
		public ISurvivorsRougeConditionStepShopping __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007CAB RID: 31915
		// (get) Token: 0x0601A04A RID: 106570 RVA: 0x003B5508 File Offset: 0x003B3708
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

		// Token: 0x0601A04B RID: 106571 RVA: 0x003B5544 File Offset: 0x003B3744
		public static Offset<ISurvivorsRougeConditionStepShopping> CreateISurvivorsRougeConditionStepShopping(FlatBufferBuilder builder, ESurvivorsRougeConditionStep Type = ESurvivorsRougeConditionStep.Prepare)
		{
			builder.StartTable(1);
			ISurvivorsRougeConditionStepShopping.AddType(builder, Type);
			return ISurvivorsRougeConditionStepShopping.EndISurvivorsRougeConditionStepShopping(builder);
		}

		// Token: 0x0601A04C RID: 106572 RVA: 0x003B555A File Offset: 0x003B375A
		public static void StartISurvivorsRougeConditionStepShopping(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A04D RID: 106573 RVA: 0x003B5563 File Offset: 0x003B3763
		public static void AddType(FlatBufferBuilder builder, ESurvivorsRougeConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A04E RID: 106574 RVA: 0x003B556E File Offset: 0x003B376E
		public static Offset<ISurvivorsRougeConditionStepShopping> EndISurvivorsRougeConditionStepShopping(FlatBufferBuilder builder)
		{
			return new Offset<ISurvivorsRougeConditionStepShopping>(builder.EndTable());
		}

		// Token: 0x0601A04F RID: 106575 RVA: 0x003B557C File Offset: 0x003B377C
		public ISurvivorsRougeConditionStepShoppingT UnPack()
		{
			ISurvivorsRougeConditionStepShoppingT survivorsRougeConditionStepShoppingT = new ISurvivorsRougeConditionStepShoppingT();
			this.UnPackTo(survivorsRougeConditionStepShoppingT);
			return survivorsRougeConditionStepShoppingT;
		}

		// Token: 0x0601A050 RID: 106576 RVA: 0x003B5597 File Offset: 0x003B3797
		public void UnPackTo(ISurvivorsRougeConditionStepShoppingT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A051 RID: 106577 RVA: 0x003B55A8 File Offset: 0x003B37A8
		public static Offset<ISurvivorsRougeConditionStepShopping> Pack(FlatBufferBuilder builder, ISurvivorsRougeConditionStepShoppingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISurvivorsRougeConditionStepShopping>);
			}
			return ISurvivorsRougeConditionStepShopping.CreateISurvivorsRougeConditionStepShopping(builder, _o.Type);
		}

		// Token: 0x0400C773 RID: 51059
		private Table __p;
	}
}
