using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D00 RID: 19712
	public struct IQuestAreaConflictSelector : IFlatbufferObject
	{
		// Token: 0x17008D13 RID: 36115
		// (get) Token: 0x0601E807 RID: 124935 RVA: 0x0044574B File Offset: 0x0044394B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E808 RID: 124936 RVA: 0x00445758 File Offset: 0x00443958
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E809 RID: 124937 RVA: 0x00445760 File Offset: 0x00443960
		public static IQuestAreaConflictSelector GetRootAsIQuestAreaConflictSelector(ByteBuffer _bb)
		{
			return IQuestAreaConflictSelector.GetRootAsIQuestAreaConflictSelector(_bb, default(IQuestAreaConflictSelector));
		}

		// Token: 0x0601E80A RID: 124938 RVA: 0x0044577C File Offset: 0x0044397C
		public static IQuestAreaConflictSelector GetRootAsIQuestAreaConflictSelector(ByteBuffer _bb, IQuestAreaConflictSelector obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E80B RID: 124939 RVA: 0x00445799 File Offset: 0x00443999
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E80C RID: 124940 RVA: 0x004457A8 File Offset: 0x004439A8
		public IQuestAreaConflictSelector __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D14 RID: 36116
		// (get) Token: 0x0601E80D RID: 124941 RVA: 0x004457B8 File Offset: 0x004439B8
		public EAreaConflictSelector Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAreaConflictSelector.Quest;
				}
				return (EAreaConflictSelector)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008D15 RID: 36117
		// (get) Token: 0x0601E80E RID: 124942 RVA: 0x004457F4 File Offset: 0x004439F4
		public int Id
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

		// Token: 0x0601E80F RID: 124943 RVA: 0x00445830 File Offset: 0x00443A30
		public static Offset<IQuestAreaConflictSelector> CreateIQuestAreaConflictSelector(FlatBufferBuilder builder, EAreaConflictSelector Type = EAreaConflictSelector.Quest, int Id = 0)
		{
			builder.StartTable(2);
			IQuestAreaConflictSelector.AddId(builder, Id);
			IQuestAreaConflictSelector.AddType(builder, Type);
			return IQuestAreaConflictSelector.EndIQuestAreaConflictSelector(builder);
		}

		// Token: 0x0601E810 RID: 124944 RVA: 0x0044584D File Offset: 0x00443A4D
		public static void StartIQuestAreaConflictSelector(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E811 RID: 124945 RVA: 0x00445856 File Offset: 0x00443A56
		public static void AddType(FlatBufferBuilder builder, EAreaConflictSelector type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E812 RID: 124946 RVA: 0x00445861 File Offset: 0x00443A61
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601E813 RID: 124947 RVA: 0x0044586C File Offset: 0x00443A6C
		public static Offset<IQuestAreaConflictSelector> EndIQuestAreaConflictSelector(FlatBufferBuilder builder)
		{
			return new Offset<IQuestAreaConflictSelector>(builder.EndTable());
		}

		// Token: 0x0601E814 RID: 124948 RVA: 0x0044587C File Offset: 0x00443A7C
		public IQuestAreaConflictSelectorT UnPack()
		{
			IQuestAreaConflictSelectorT questAreaConflictSelectorT = new IQuestAreaConflictSelectorT();
			this.UnPackTo(questAreaConflictSelectorT);
			return questAreaConflictSelectorT;
		}

		// Token: 0x0601E815 RID: 124949 RVA: 0x00445897 File Offset: 0x00443A97
		public void UnPackTo(IQuestAreaConflictSelectorT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0601E816 RID: 124950 RVA: 0x004458B4 File Offset: 0x00443AB4
		public static Offset<IQuestAreaConflictSelector> Pack(FlatBufferBuilder builder, IQuestAreaConflictSelectorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestAreaConflictSelector>);
			}
			return IQuestAreaConflictSelector.CreateIQuestAreaConflictSelector(builder, _o.Type, _o.Id);
		}

		// Token: 0x0400D8C1 RID: 55489
		private Table __p;
	}
}
