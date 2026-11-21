using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200444B RID: 17483
	public struct IQuestRecallConfig : IFlatbufferObject
	{
		// Token: 0x17007933 RID: 31027
		// (get) Token: 0x0601911B RID: 102683 RVA: 0x00393720 File Offset: 0x00391920
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601911C RID: 102684 RVA: 0x0039372D File Offset: 0x0039192D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601911D RID: 102685 RVA: 0x00393734 File Offset: 0x00391934
		public static IQuestRecallConfig GetRootAsIQuestRecallConfig(ByteBuffer _bb)
		{
			return IQuestRecallConfig.GetRootAsIQuestRecallConfig(_bb, default(IQuestRecallConfig));
		}

		// Token: 0x0601911E RID: 102686 RVA: 0x00393750 File Offset: 0x00391950
		public static IQuestRecallConfig GetRootAsIQuestRecallConfig(ByteBuffer _bb, IQuestRecallConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601911F RID: 102687 RVA: 0x0039376D File Offset: 0x0039196D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019120 RID: 102688 RVA: 0x0039377C File Offset: 0x0039197C
		public IQuestRecallConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007934 RID: 31028
		// (get) Token: 0x06019121 RID: 102689 RVA: 0x0039378C File Offset: 0x0039198C
		public int RecallId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019122 RID: 102690 RVA: 0x003937C8 File Offset: 0x003919C8
		public IRecallEntityList? RecallEntityList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IRecallEntityList?(default(IRecallEntityList).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007935 RID: 31029
		// (get) Token: 0x06019123 RID: 102691 RVA: 0x00393828 File Offset: 0x00391A28
		public int RecallEntityListLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06019124 RID: 102692 RVA: 0x00393853 File Offset: 0x00391A53
		public static Offset<IQuestRecallConfig> CreateIQuestRecallConfig(FlatBufferBuilder builder, int RecallId = 0, VectorOffset RecallEntityListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IQuestRecallConfig.AddRecallEntityList(builder, RecallEntityListOffset);
			IQuestRecallConfig.AddRecallId(builder, RecallId);
			return IQuestRecallConfig.EndIQuestRecallConfig(builder);
		}

		// Token: 0x06019125 RID: 102693 RVA: 0x00393870 File Offset: 0x00391A70
		public static void StartIQuestRecallConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06019126 RID: 102694 RVA: 0x00393879 File Offset: 0x00391A79
		public static void AddRecallId(FlatBufferBuilder builder, int recallId)
		{
			builder.AddInt(0, recallId, 0);
		}

		// Token: 0x06019127 RID: 102695 RVA: 0x00393884 File Offset: 0x00391A84
		public static void AddRecallEntityList(FlatBufferBuilder builder, VectorOffset recallEntityListOffset)
		{
			builder.AddOffset(1, recallEntityListOffset.Value, 0);
		}

		// Token: 0x06019128 RID: 102696 RVA: 0x00393894 File Offset: 0x00391A94
		public static VectorOffset CreateRecallEntityListVector(FlatBufferBuilder builder, Offset<IRecallEntityList>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019129 RID: 102697 RVA: 0x003938D4 File Offset: 0x00391AD4
		public static VectorOffset CreateRecallEntityListVectorBlock(FlatBufferBuilder builder, Offset<IRecallEntityList>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRecallEntityList>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601912A RID: 102698 RVA: 0x003938EE File Offset: 0x00391AEE
		public static VectorOffset CreateRecallEntityListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRecallEntityList>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRecallEntityList>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601912B RID: 102699 RVA: 0x0039390C File Offset: 0x00391B0C
		public static VectorOffset CreateRecallEntityListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRecallEntityList>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601912C RID: 102700 RVA: 0x00393925 File Offset: 0x00391B25
		public static void StartRecallEntityListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601912D RID: 102701 RVA: 0x00393930 File Offset: 0x00391B30
		public static Offset<IQuestRecallConfig> EndIQuestRecallConfig(FlatBufferBuilder builder)
		{
			return new Offset<IQuestRecallConfig>(builder.EndTable());
		}

		// Token: 0x0601912E RID: 102702 RVA: 0x00393940 File Offset: 0x00391B40
		public IQuestRecallConfigT UnPack()
		{
			IQuestRecallConfigT questRecallConfigT = new IQuestRecallConfigT();
			this.UnPackTo(questRecallConfigT);
			return questRecallConfigT;
		}

		// Token: 0x0601912F RID: 102703 RVA: 0x0039395C File Offset: 0x00391B5C
		public void UnPackTo(IQuestRecallConfigT _o)
		{
			_o.RecallId = this.RecallId;
			_o.RecallEntityList = new List<IRecallEntityListT>();
			for (int i = 0; i < this.RecallEntityListLength; i++)
			{
				_o.RecallEntityList.Add((this.RecallEntityList(i) != null) ? this.RecallEntityList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06019130 RID: 102704 RVA: 0x003939C8 File Offset: 0x00391BC8
		public static Offset<IQuestRecallConfig> Pack(FlatBufferBuilder builder, IQuestRecallConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestRecallConfig>);
			}
			VectorOffset recallEntityListOffset = default(VectorOffset);
			if (_o.RecallEntityList != null)
			{
				Offset<IRecallEntityList>[] array = new Offset<IRecallEntityList>[_o.RecallEntityList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IRecallEntityList.Pack(builder, _o.RecallEntityList[i]);
				}
				recallEntityListOffset = IQuestRecallConfig.CreateRecallEntityListVector(builder, array);
			}
			return IQuestRecallConfig.CreateIQuestRecallConfig(builder, _o.RecallId, recallEntityListOffset);
		}

		// Token: 0x0400C50B RID: 50443
		private Table __p;
	}
}
