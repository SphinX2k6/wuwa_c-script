using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045A1 RID: 17825
	public struct ISurvivorsRougeConditionStepChooseItem : IFlatbufferObject
	{
		// Token: 0x17007C9E RID: 31902
		// (get) Token: 0x06019FFC RID: 106492 RVA: 0x003B4EB9 File Offset: 0x003B30B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019FFD RID: 106493 RVA: 0x003B4EC6 File Offset: 0x003B30C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019FFE RID: 106494 RVA: 0x003B4ED0 File Offset: 0x003B30D0
		public static ISurvivorsRougeConditionStepChooseItem GetRootAsISurvivorsRougeConditionStepChooseItem(ByteBuffer _bb)
		{
			return ISurvivorsRougeConditionStepChooseItem.GetRootAsISurvivorsRougeConditionStepChooseItem(_bb, default(ISurvivorsRougeConditionStepChooseItem));
		}

		// Token: 0x06019FFF RID: 106495 RVA: 0x003B4EEC File Offset: 0x003B30EC
		public static ISurvivorsRougeConditionStepChooseItem GetRootAsISurvivorsRougeConditionStepChooseItem(ByteBuffer _bb, ISurvivorsRougeConditionStepChooseItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A000 RID: 106496 RVA: 0x003B4F09 File Offset: 0x003B3109
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A001 RID: 106497 RVA: 0x003B4F18 File Offset: 0x003B3118
		public ISurvivorsRougeConditionStepChooseItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C9F RID: 31903
		// (get) Token: 0x0601A002 RID: 106498 RVA: 0x003B4F28 File Offset: 0x003B3128
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

		// Token: 0x0601A003 RID: 106499 RVA: 0x003B4F64 File Offset: 0x003B3164
		public static Offset<ISurvivorsRougeConditionStepChooseItem> CreateISurvivorsRougeConditionStepChooseItem(FlatBufferBuilder builder, ESurvivorsRougeConditionStep Type = ESurvivorsRougeConditionStep.Prepare)
		{
			builder.StartTable(1);
			ISurvivorsRougeConditionStepChooseItem.AddType(builder, Type);
			return ISurvivorsRougeConditionStepChooseItem.EndISurvivorsRougeConditionStepChooseItem(builder);
		}

		// Token: 0x0601A004 RID: 106500 RVA: 0x003B4F7A File Offset: 0x003B317A
		public static void StartISurvivorsRougeConditionStepChooseItem(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A005 RID: 106501 RVA: 0x003B4F83 File Offset: 0x003B3183
		public static void AddType(FlatBufferBuilder builder, ESurvivorsRougeConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A006 RID: 106502 RVA: 0x003B4F8E File Offset: 0x003B318E
		public static Offset<ISurvivorsRougeConditionStepChooseItem> EndISurvivorsRougeConditionStepChooseItem(FlatBufferBuilder builder)
		{
			return new Offset<ISurvivorsRougeConditionStepChooseItem>(builder.EndTable());
		}

		// Token: 0x0601A007 RID: 106503 RVA: 0x003B4F9C File Offset: 0x003B319C
		public ISurvivorsRougeConditionStepChooseItemT UnPack()
		{
			ISurvivorsRougeConditionStepChooseItemT survivorsRougeConditionStepChooseItemT = new ISurvivorsRougeConditionStepChooseItemT();
			this.UnPackTo(survivorsRougeConditionStepChooseItemT);
			return survivorsRougeConditionStepChooseItemT;
		}

		// Token: 0x0601A008 RID: 106504 RVA: 0x003B4FB7 File Offset: 0x003B31B7
		public void UnPackTo(ISurvivorsRougeConditionStepChooseItemT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A009 RID: 106505 RVA: 0x003B4FC8 File Offset: 0x003B31C8
		public static Offset<ISurvivorsRougeConditionStepChooseItem> Pack(FlatBufferBuilder builder, ISurvivorsRougeConditionStepChooseItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISurvivorsRougeConditionStepChooseItem>);
			}
			return ISurvivorsRougeConditionStepChooseItem.CreateISurvivorsRougeConditionStepChooseItem(builder, _o.Type);
		}

		// Token: 0x0400C76B RID: 51051
		private Table __p;
	}
}
