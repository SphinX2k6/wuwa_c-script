using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045F2 RID: 17906
	public struct ITakePhoto2TargetPartCondition : IFlatbufferObject
	{
		// Token: 0x17007D4B RID: 32075
		// (get) Token: 0x0601A2BD RID: 107197 RVA: 0x003BA5CA File Offset: 0x003B87CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A2BE RID: 107198 RVA: 0x003BA5D7 File Offset: 0x003B87D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A2BF RID: 107199 RVA: 0x003BA5E0 File Offset: 0x003B87E0
		public static ITakePhoto2TargetPartCondition GetRootAsITakePhoto2TargetPartCondition(ByteBuffer _bb)
		{
			return ITakePhoto2TargetPartCondition.GetRootAsITakePhoto2TargetPartCondition(_bb, default(ITakePhoto2TargetPartCondition));
		}

		// Token: 0x0601A2C0 RID: 107200 RVA: 0x003BA5FC File Offset: 0x003B87FC
		public static ITakePhoto2TargetPartCondition GetRootAsITakePhoto2TargetPartCondition(ByteBuffer _bb, ITakePhoto2TargetPartCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A2C1 RID: 107201 RVA: 0x003BA619 File Offset: 0x003B8819
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A2C2 RID: 107202 RVA: 0x003BA628 File Offset: 0x003B8828
		public ITakePhoto2TargetPartCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601A2C3 RID: 107203 RVA: 0x003BA638 File Offset: 0x003B8838
		public string Tags(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007D4C RID: 32076
		// (get) Token: 0x0601A2C4 RID: 107204 RVA: 0x003BA674 File Offset: 0x003B8874
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

		// Token: 0x0601A2C5 RID: 107205 RVA: 0x003BA69F File Offset: 0x003B889F
		public static Offset<ITakePhoto2TargetPartCondition> CreateITakePhoto2TargetPartCondition(FlatBufferBuilder builder, VectorOffset TagsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ITakePhoto2TargetPartCondition.AddTags(builder, TagsOffset);
			return ITakePhoto2TargetPartCondition.EndITakePhoto2TargetPartCondition(builder);
		}

		// Token: 0x0601A2C6 RID: 107206 RVA: 0x003BA6B5 File Offset: 0x003B88B5
		public static void StartITakePhoto2TargetPartCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A2C7 RID: 107207 RVA: 0x003BA6BE File Offset: 0x003B88BE
		public static void AddTags(FlatBufferBuilder builder, VectorOffset tagsOffset)
		{
			builder.AddOffset(0, tagsOffset.Value, 0);
		}

		// Token: 0x0601A2C8 RID: 107208 RVA: 0x003BA6D0 File Offset: 0x003B88D0
		public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A2C9 RID: 107209 RVA: 0x003BA710 File Offset: 0x003B8910
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A2CA RID: 107210 RVA: 0x003BA72A File Offset: 0x003B892A
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A2CB RID: 107211 RVA: 0x003BA748 File Offset: 0x003B8948
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A2CC RID: 107212 RVA: 0x003BA761 File Offset: 0x003B8961
		public static void StartTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A2CD RID: 107213 RVA: 0x003BA76C File Offset: 0x003B896C
		public static Offset<ITakePhoto2TargetPartCondition> EndITakePhoto2TargetPartCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2TargetPartCondition>(builder.EndTable());
		}

		// Token: 0x0601A2CE RID: 107214 RVA: 0x003BA77C File Offset: 0x003B897C
		public ITakePhoto2TargetPartConditionT UnPack()
		{
			ITakePhoto2TargetPartConditionT takePhoto2TargetPartConditionT = new ITakePhoto2TargetPartConditionT();
			this.UnPackTo(takePhoto2TargetPartConditionT);
			return takePhoto2TargetPartConditionT;
		}

		// Token: 0x0601A2CF RID: 107215 RVA: 0x003BA798 File Offset: 0x003B8998
		public void UnPackTo(ITakePhoto2TargetPartConditionT _o)
		{
			_o.Tags = new List<string>();
			for (int i = 0; i < this.TagsLength; i++)
			{
				_o.Tags.Add(this.Tags(i));
			}
		}

		// Token: 0x0601A2D0 RID: 107216 RVA: 0x003BA7D4 File Offset: 0x003B89D4
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

		// Token: 0x0400C7DD RID: 51165
		private Table __p;
	}
}
