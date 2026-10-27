using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AA5 RID: 19109
	public struct ICheckIsTrackingQuest : IFlatbufferObject
	{
		// Token: 0x17008A79 RID: 35449
		// (get) Token: 0x0601DFB8 RID: 122808 RVA: 0x0043590D File Offset: 0x00433B0D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DFB9 RID: 122809 RVA: 0x0043591A File Offset: 0x00433B1A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DFBA RID: 122810 RVA: 0x00435924 File Offset: 0x00433B24
		public static ICheckIsTrackingQuest GetRootAsICheckIsTrackingQuest(ByteBuffer _bb)
		{
			return ICheckIsTrackingQuest.GetRootAsICheckIsTrackingQuest(_bb, default(ICheckIsTrackingQuest));
		}

		// Token: 0x0601DFBB RID: 122811 RVA: 0x00435940 File Offset: 0x00433B40
		public static ICheckIsTrackingQuest GetRootAsICheckIsTrackingQuest(ByteBuffer _bb, ICheckIsTrackingQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DFBC RID: 122812 RVA: 0x0043595D File Offset: 0x00433B5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DFBD RID: 122813 RVA: 0x0043596C File Offset: 0x00433B6C
		public ICheckIsTrackingQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A7A RID: 35450
		// (get) Token: 0x0601DFBE RID: 122814 RVA: 0x0043597C File Offset: 0x00433B7C
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

		// Token: 0x17008A7B RID: 35451
		// (get) Token: 0x0601DFBF RID: 122815 RVA: 0x004359B8 File Offset: 0x00433BB8
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

		// Token: 0x17008A7C RID: 35452
		// (get) Token: 0x0601DFC0 RID: 122816 RVA: 0x004359F4 File Offset: 0x00433BF4
		public bool IsTracking
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601DFC1 RID: 122817 RVA: 0x00435A33 File Offset: 0x00433C33
		public static Offset<ICheckIsTrackingQuest> CreateICheckIsTrackingQuest(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int QuestId = 0, bool IsTracking = false)
		{
			builder.StartTable(3);
			ICheckIsTrackingQuest.AddQuestId(builder, QuestId);
			ICheckIsTrackingQuest.AddIsTracking(builder, IsTracking);
			ICheckIsTrackingQuest.AddType(builder, Type);
			return ICheckIsTrackingQuest.EndICheckIsTrackingQuest(builder);
		}

		// Token: 0x0601DFC2 RID: 122818 RVA: 0x00435A57 File Offset: 0x00433C57
		public static void StartICheckIsTrackingQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DFC3 RID: 122819 RVA: 0x00435A60 File Offset: 0x00433C60
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DFC4 RID: 122820 RVA: 0x00435A6B File Offset: 0x00433C6B
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(1, questId, 0);
		}

		// Token: 0x0601DFC5 RID: 122821 RVA: 0x00435A76 File Offset: 0x00433C76
		public static void AddIsTracking(FlatBufferBuilder builder, bool isTracking)
		{
			builder.AddBool(2, isTracking, false);
		}

		// Token: 0x0601DFC6 RID: 122822 RVA: 0x00435A81 File Offset: 0x00433C81
		public static Offset<ICheckIsTrackingQuest> EndICheckIsTrackingQuest(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsTrackingQuest>(builder.EndTable());
		}

		// Token: 0x0601DFC7 RID: 122823 RVA: 0x00435A90 File Offset: 0x00433C90
		public ICheckIsTrackingQuestT UnPack()
		{
			ICheckIsTrackingQuestT checkIsTrackingQuestT = new ICheckIsTrackingQuestT();
			this.UnPackTo(checkIsTrackingQuestT);
			return checkIsTrackingQuestT;
		}

		// Token: 0x0601DFC8 RID: 122824 RVA: 0x00435AAB File Offset: 0x00433CAB
		public void UnPackTo(ICheckIsTrackingQuestT _o)
		{
			_o.Type = this.Type;
			_o.QuestId = this.QuestId;
			_o.IsTracking = this.IsTracking;
		}

		// Token: 0x0601DFC9 RID: 122825 RVA: 0x00435AD4 File Offset: 0x00433CD4
		public static Offset<ICheckIsTrackingQuest> Pack(FlatBufferBuilder builder, ICheckIsTrackingQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsTrackingQuest>);
			}
			return ICheckIsTrackingQuest.CreateICheckIsTrackingQuest(builder, _o.Type, _o.QuestId, _o.IsTracking);
		}

		// Token: 0x0400D31B RID: 54043
		private Table __p;
	}
}
