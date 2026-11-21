using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200467F RID: 18047
	public struct ITrapDefenseConditionStepBase : IFlatbufferObject
	{
		// Token: 0x17007E78 RID: 32376
		// (get) Token: 0x0601A7EA RID: 108522 RVA: 0x003C58A2 File Offset: 0x003C3AA2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A7EB RID: 108523 RVA: 0x003C58AF File Offset: 0x003C3AAF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A7EC RID: 108524 RVA: 0x003C58B8 File Offset: 0x003C3AB8
		public static ITrapDefenseConditionStepBase GetRootAsITrapDefenseConditionStepBase(ByteBuffer _bb)
		{
			return ITrapDefenseConditionStepBase.GetRootAsITrapDefenseConditionStepBase(_bb, default(ITrapDefenseConditionStepBase));
		}

		// Token: 0x0601A7ED RID: 108525 RVA: 0x003C58D4 File Offset: 0x003C3AD4
		public static ITrapDefenseConditionStepBase GetRootAsITrapDefenseConditionStepBase(ByteBuffer _bb, ITrapDefenseConditionStepBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A7EE RID: 108526 RVA: 0x003C58F1 File Offset: 0x003C3AF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A7EF RID: 108527 RVA: 0x003C5900 File Offset: 0x003C3B00
		public ITrapDefenseConditionStepBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E79 RID: 32377
		// (get) Token: 0x0601A7F0 RID: 108528 RVA: 0x003C5910 File Offset: 0x003C3B10
		public ETrapDefenseConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrapDefenseConditionStep.Reward;
				}
				return (ETrapDefenseConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A7F1 RID: 108529 RVA: 0x003C594C File Offset: 0x003C3B4C
		public static Offset<ITrapDefenseConditionStepBase> CreateITrapDefenseConditionStepBase(FlatBufferBuilder builder, ETrapDefenseConditionStep Type = ETrapDefenseConditionStep.Reward)
		{
			builder.StartTable(1);
			ITrapDefenseConditionStepBase.AddType(builder, Type);
			return ITrapDefenseConditionStepBase.EndITrapDefenseConditionStepBase(builder);
		}

		// Token: 0x0601A7F2 RID: 108530 RVA: 0x003C5962 File Offset: 0x003C3B62
		public static void StartITrapDefenseConditionStepBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A7F3 RID: 108531 RVA: 0x003C596B File Offset: 0x003C3B6B
		public static void AddType(FlatBufferBuilder builder, ETrapDefenseConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A7F4 RID: 108532 RVA: 0x003C5976 File Offset: 0x003C3B76
		public static Offset<ITrapDefenseConditionStepBase> EndITrapDefenseConditionStepBase(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseConditionStepBase>(builder.EndTable());
		}

		// Token: 0x0601A7F5 RID: 108533 RVA: 0x003C5984 File Offset: 0x003C3B84
		public ITrapDefenseConditionStepBaseT UnPack()
		{
			ITrapDefenseConditionStepBaseT trapDefenseConditionStepBaseT = new ITrapDefenseConditionStepBaseT();
			this.UnPackTo(trapDefenseConditionStepBaseT);
			return trapDefenseConditionStepBaseT;
		}

		// Token: 0x0601A7F6 RID: 108534 RVA: 0x003C599F File Offset: 0x003C3B9F
		public void UnPackTo(ITrapDefenseConditionStepBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A7F7 RID: 108535 RVA: 0x003C59B0 File Offset: 0x003C3BB0
		public static Offset<ITrapDefenseConditionStepBase> Pack(FlatBufferBuilder builder, ITrapDefenseConditionStepBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseConditionStepBase>);
			}
			return ITrapDefenseConditionStepBase.CreateITrapDefenseConditionStepBase(builder, _o.Type);
		}

		// Token: 0x0400C8B1 RID: 51377
		private Table __p;
	}
}
