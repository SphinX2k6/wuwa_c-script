using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200400A RID: 16394
	public struct IQuestRecallConfig : IFlatbufferObject
	{
		// Token: 0x17007331 RID: 29489
		// (get) Token: 0x06017A82 RID: 96898 RVA: 0x0036992C File Offset: 0x00367B2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017A83 RID: 96899 RVA: 0x00369939 File Offset: 0x00367B39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017A84 RID: 96900 RVA: 0x00369940 File Offset: 0x00367B40
		public static IQuestRecallConfig GetRootAsIQuestRecallConfig(ByteBuffer _bb)
		{
			return IQuestRecallConfig.GetRootAsIQuestRecallConfig(_bb, default(IQuestRecallConfig));
		}

		// Token: 0x06017A85 RID: 96901 RVA: 0x0036995C File Offset: 0x00367B5C
		public static IQuestRecallConfig GetRootAsIQuestRecallConfig(ByteBuffer _bb, IQuestRecallConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017A86 RID: 96902 RVA: 0x00369979 File Offset: 0x00367B79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017A87 RID: 96903 RVA: 0x00369988 File Offset: 0x00367B88
		public IQuestRecallConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007332 RID: 29490
		// (get) Token: 0x06017A88 RID: 96904 RVA: 0x00369998 File Offset: 0x00367B98
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

		// Token: 0x06017A89 RID: 96905 RVA: 0x003699D4 File Offset: 0x00367BD4
		public IRecallEntityList? RecallEntityList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IRecallEntityList?(default(IRecallEntityList).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007333 RID: 29491
		// (get) Token: 0x06017A8A RID: 96906 RVA: 0x00369A34 File Offset: 0x00367C34
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

		// Token: 0x06017A8B RID: 96907 RVA: 0x00369A5F File Offset: 0x00367C5F
		public static Offset<IQuestRecallConfig> CreateIQuestRecallConfig(FlatBufferBuilder builder, int RecallId = 0, VectorOffset RecallEntityListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IQuestRecallConfig.AddRecallEntityList(builder, RecallEntityListOffset);
			IQuestRecallConfig.AddRecallId(builder, RecallId);
			return IQuestRecallConfig.EndIQuestRecallConfig(builder);
		}

		// Token: 0x06017A8C RID: 96908 RVA: 0x00369A7C File Offset: 0x00367C7C
		public static void StartIQuestRecallConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06017A8D RID: 96909 RVA: 0x00369A85 File Offset: 0x00367C85
		public static void AddRecallId(FlatBufferBuilder builder, int recallId)
		{
			builder.AddInt(0, recallId, 0);
		}

		// Token: 0x06017A8E RID: 96910 RVA: 0x00369A90 File Offset: 0x00367C90
		public static void AddRecallEntityList(FlatBufferBuilder builder, VectorOffset recallEntityListOffset)
		{
			builder.AddOffset(1, recallEntityListOffset.Value, 0);
		}

		// Token: 0x06017A8F RID: 96911 RVA: 0x00369AA0 File Offset: 0x00367CA0
		public static VectorOffset CreateRecallEntityListVector(FlatBufferBuilder builder, Offset<IRecallEntityList>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017A90 RID: 96912 RVA: 0x00369AE0 File Offset: 0x00367CE0
		public static VectorOffset CreateRecallEntityListVectorBlock(FlatBufferBuilder builder, Offset<IRecallEntityList>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRecallEntityList>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017A91 RID: 96913 RVA: 0x00369AFA File Offset: 0x00367CFA
		public static VectorOffset CreateRecallEntityListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRecallEntityList>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRecallEntityList>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017A92 RID: 96914 RVA: 0x00369B18 File Offset: 0x00367D18
		public static VectorOffset CreateRecallEntityListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRecallEntityList>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017A93 RID: 96915 RVA: 0x00369B31 File Offset: 0x00367D31
		public static void StartRecallEntityListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017A94 RID: 96916 RVA: 0x00369B3C File Offset: 0x00367D3C
		public static Offset<IQuestRecallConfig> EndIQuestRecallConfig(FlatBufferBuilder builder)
		{
			return new Offset<IQuestRecallConfig>(builder.EndTable());
		}

		// Token: 0x06017A95 RID: 96917 RVA: 0x00369B4C File Offset: 0x00367D4C
		public IQuestRecallConfigT UnPack()
		{
			IQuestRecallConfigT questRecallConfigT = new IQuestRecallConfigT();
			this.UnPackTo(questRecallConfigT);
			return questRecallConfigT;
		}

		// Token: 0x06017A96 RID: 96918 RVA: 0x00369B68 File Offset: 0x00367D68
		public void UnPackTo(IQuestRecallConfigT _o)
		{
			_o.RecallId = this.RecallId;
			_o.RecallEntityList = new List<IRecallEntityListT>();
			for (int i = 0; i < this.RecallEntityListLength; i++)
			{
				_o.RecallEntityList.Add((this.RecallEntityList(i) != null) ? this.RecallEntityList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06017A97 RID: 96919 RVA: 0x00369BD4 File Offset: 0x00367DD4
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

		// Token: 0x0400BB24 RID: 47908
		private Table __p;
	}
}
