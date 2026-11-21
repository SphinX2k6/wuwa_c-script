using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F74 RID: 20340
	public struct ICheckIsTrackingQuest : IFlatbufferObject
	{
		// Token: 0x17009166 RID: 37222
		// (get) Token: 0x0601FAA1 RID: 129697 RVA: 0x0046712D File Offset: 0x0046532D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FAA2 RID: 129698 RVA: 0x0046713A File Offset: 0x0046533A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FAA3 RID: 129699 RVA: 0x00467144 File Offset: 0x00465344
		public static ICheckIsTrackingQuest GetRootAsICheckIsTrackingQuest(ByteBuffer _bb)
		{
			return ICheckIsTrackingQuest.GetRootAsICheckIsTrackingQuest(_bb, default(ICheckIsTrackingQuest));
		}

		// Token: 0x0601FAA4 RID: 129700 RVA: 0x00467160 File Offset: 0x00465360
		public static ICheckIsTrackingQuest GetRootAsICheckIsTrackingQuest(ByteBuffer _bb, ICheckIsTrackingQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FAA5 RID: 129701 RVA: 0x0046717D File Offset: 0x0046537D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FAA6 RID: 129702 RVA: 0x0046718C File Offset: 0x0046538C
		public ICheckIsTrackingQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009167 RID: 37223
		// (get) Token: 0x0601FAA7 RID: 129703 RVA: 0x0046719C File Offset: 0x0046539C
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009168 RID: 37224
		// (get) Token: 0x0601FAA8 RID: 129704 RVA: 0x004671D8 File Offset: 0x004653D8
		public int QuestId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009169 RID: 37225
		// (get) Token: 0x0601FAA9 RID: 129705 RVA: 0x00467214 File Offset: 0x00465414
		public bool IsTracking
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601FAAA RID: 129706 RVA: 0x00467253 File Offset: 0x00465453
		public static Offset<ICheckIsTrackingQuest> CreateICheckIsTrackingQuest(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int QuestId = 0, bool IsTracking = false)
		{
			builder.StartTable(3);
			ICheckIsTrackingQuest.AddQuestId(builder, QuestId);
			ICheckIsTrackingQuest.AddIsTracking(builder, IsTracking);
			ICheckIsTrackingQuest.AddType(builder, Type);
			return ICheckIsTrackingQuest.EndICheckIsTrackingQuest(builder);
		}

		// Token: 0x0601FAAB RID: 129707 RVA: 0x00467277 File Offset: 0x00465477
		public static void StartICheckIsTrackingQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FAAC RID: 129708 RVA: 0x00467280 File Offset: 0x00465480
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FAAD RID: 129709 RVA: 0x0046728B File Offset: 0x0046548B
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(1, questId, 0);
		}

		// Token: 0x0601FAAE RID: 129710 RVA: 0x00467296 File Offset: 0x00465496
		public static void AddIsTracking(FlatBufferBuilder builder, bool isTracking)
		{
			builder.AddBool(2, isTracking, false);
		}

		// Token: 0x0601FAAF RID: 129711 RVA: 0x004672A1 File Offset: 0x004654A1
		public static Offset<ICheckIsTrackingQuest> EndICheckIsTrackingQuest(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsTrackingQuest>(builder.EndTable());
		}

		// Token: 0x0601FAB0 RID: 129712 RVA: 0x004672B0 File Offset: 0x004654B0
		public ICheckIsTrackingQuestT UnPack()
		{
			ICheckIsTrackingQuestT checkIsTrackingQuestT = new ICheckIsTrackingQuestT();
			this.UnPackTo(checkIsTrackingQuestT);
			return checkIsTrackingQuestT;
		}

		// Token: 0x0601FAB1 RID: 129713 RVA: 0x004672CB File Offset: 0x004654CB
		public void UnPackTo(ICheckIsTrackingQuestT _o)
		{
			_o.Type = this.Type;
			_o.QuestId = this.QuestId;
			_o.IsTracking = this.IsTracking;
		}

		// Token: 0x0601FAB2 RID: 129714 RVA: 0x004672F4 File Offset: 0x004654F4
		public static Offset<ICheckIsTrackingQuest> Pack(FlatBufferBuilder builder, ICheckIsTrackingQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsTrackingQuest>);
			}
			return ICheckIsTrackingQuest.CreateICheckIsTrackingQuest(builder, _o.Type, _o.QuestId, _o.IsTracking);
		}

		// Token: 0x0400DE00 RID: 56832
		private Table __p;
	}
}
