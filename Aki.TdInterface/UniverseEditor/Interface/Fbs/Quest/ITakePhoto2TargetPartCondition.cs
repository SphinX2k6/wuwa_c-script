using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004199 RID: 16793
	public struct ITakePhoto2TargetPartCondition : IFlatbufferObject
	{
		// Token: 0x1700771F RID: 30495
		// (get) Token: 0x06018B67 RID: 101223 RVA: 0x0038F176 File Offset: 0x0038D376
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018B68 RID: 101224 RVA: 0x0038F183 File Offset: 0x0038D383
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018B69 RID: 101225 RVA: 0x0038F18C File Offset: 0x0038D38C
		public static ITakePhoto2TargetPartCondition GetRootAsITakePhoto2TargetPartCondition(ByteBuffer _bb)
		{
			return ITakePhoto2TargetPartCondition.GetRootAsITakePhoto2TargetPartCondition(_bb, default(ITakePhoto2TargetPartCondition));
		}

		// Token: 0x06018B6A RID: 101226 RVA: 0x0038F1A8 File Offset: 0x0038D3A8
		public static ITakePhoto2TargetPartCondition GetRootAsITakePhoto2TargetPartCondition(ByteBuffer _bb, ITakePhoto2TargetPartCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018B6B RID: 101227 RVA: 0x0038F1C5 File Offset: 0x0038D3C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018B6C RID: 101228 RVA: 0x0038F1D4 File Offset: 0x0038D3D4
		public ITakePhoto2TargetPartCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06018B6D RID: 101229 RVA: 0x0038F1E4 File Offset: 0x0038D3E4
		public string Tags(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007720 RID: 30496
		// (get) Token: 0x06018B6E RID: 101230 RVA: 0x0038F220 File Offset: 0x0038D420
		public int TagsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06018B6F RID: 101231 RVA: 0x0038F24B File Offset: 0x0038D44B
		public static Offset<ITakePhoto2TargetPartCondition> CreateITakePhoto2TargetPartCondition(FlatBufferBuilder builder, VectorOffset TagsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ITakePhoto2TargetPartCondition.AddTags(builder, TagsOffset);
			return ITakePhoto2TargetPartCondition.EndITakePhoto2TargetPartCondition(builder);
		}

		// Token: 0x06018B70 RID: 101232 RVA: 0x0038F261 File Offset: 0x0038D461
		public static void StartITakePhoto2TargetPartCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018B71 RID: 101233 RVA: 0x0038F26A File Offset: 0x0038D46A
		public static void AddTags(FlatBufferBuilder builder, VectorOffset tagsOffset)
		{
			builder.AddOffset(0, tagsOffset.Value, 0);
		}

		// Token: 0x06018B72 RID: 101234 RVA: 0x0038F27C File Offset: 0x0038D47C
		public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018B73 RID: 101235 RVA: 0x0038F2BC File Offset: 0x0038D4BC
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06018B74 RID: 101236 RVA: 0x0038F2D6 File Offset: 0x0038D4D6
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06018B75 RID: 101237 RVA: 0x0038F2F4 File Offset: 0x0038D4F4
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018B76 RID: 101238 RVA: 0x0038F30D File Offset: 0x0038D50D
		public static void StartTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018B77 RID: 101239 RVA: 0x0038F318 File Offset: 0x0038D518
		public static Offset<ITakePhoto2TargetPartCondition> EndITakePhoto2TargetPartCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2TargetPartCondition>(builder.EndTable());
		}

		// Token: 0x06018B78 RID: 101240 RVA: 0x0038F328 File Offset: 0x0038D528
		public ITakePhoto2TargetPartConditionT UnPack()
		{
			ITakePhoto2TargetPartConditionT takePhoto2TargetPartConditionT = new ITakePhoto2TargetPartConditionT();
			this.UnPackTo(takePhoto2TargetPartConditionT);
			return takePhoto2TargetPartConditionT;
		}

		// Token: 0x06018B79 RID: 101241 RVA: 0x0038F344 File Offset: 0x0038D544
		public void UnPackTo(ITakePhoto2TargetPartConditionT _o)
		{
			_o.Tags = new List<string>();
			for (int i = 0; i < this.TagsLength; i++)
			{
				_o.Tags.Add(this.Tags(i));
			}
		}

		// Token: 0x06018B7A RID: 101242 RVA: 0x0038F380 File Offset: 0x0038D580
		public static Offset<ITakePhoto2TargetPartCondition> Pack(FlatBufferBuilder builder, ITakePhoto2TargetPartConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2TargetPartCondition>);
			}
			VectorOffset tagsOffset = default(VectorOffset);
			if (_o.Tags != null)
			{
				StringOffset[] array = new StringOffset[_o.Tags.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Tags[i]);
				}
				tagsOffset = ITakePhoto2TargetPartCondition.CreateTagsVector(builder, array);
			}
			return ITakePhoto2TargetPartCondition.CreateITakePhoto2TargetPartCondition(builder, tagsOffset);
		}

		// Token: 0x0400BDD3 RID: 48595
		private Table __p;
	}
}
