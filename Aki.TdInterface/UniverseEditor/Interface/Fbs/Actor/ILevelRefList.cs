using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Actor
{
	// Token: 0x02005EFD RID: 24317
	public struct ILevelRefList : IFlatbufferObject
	{
		// Token: 0x1700B5CA RID: 46538
		// (get) Token: 0x06029C44 RID: 171076 RVA: 0x005BB27C File Offset: 0x005B947C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029C45 RID: 171077 RVA: 0x005BB289 File Offset: 0x005B9489
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029C46 RID: 171078 RVA: 0x005BB290 File Offset: 0x005B9490
		public static ILevelRefList GetRootAsILevelRefList(ByteBuffer _bb)
		{
			return ILevelRefList.GetRootAsILevelRefList(_bb, default(ILevelRefList));
		}

		// Token: 0x06029C47 RID: 171079 RVA: 0x005BB2AC File Offset: 0x005B94AC
		public static ILevelRefList GetRootAsILevelRefList(ByteBuffer _bb, ILevelRefList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029C48 RID: 171080 RVA: 0x005BB2C9 File Offset: 0x005B94C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029C49 RID: 171081 RVA: 0x005BB2D8 File Offset: 0x005B94D8
		public ILevelRefList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06029C4A RID: 171082 RVA: 0x005BB2E8 File Offset: 0x005B94E8
		public ILevelRefData? LevelRefList(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new ILevelRefData?(default(ILevelRefData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B5CB RID: 46539
		// (get) Token: 0x06029C4B RID: 171083 RVA: 0x005BB348 File Offset: 0x005B9548
		public int LevelRefListLength
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

		// Token: 0x06029C4C RID: 171084 RVA: 0x005BB373 File Offset: 0x005B9573
		public static Offset<ILevelRefList> CreateILevelRefList(FlatBufferBuilder builder, VectorOffset LevelRefListOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ILevelRefList.AddLevelRefList(builder, LevelRefListOffset);
			return ILevelRefList.EndILevelRefList(builder);
		}

		// Token: 0x06029C4D RID: 171085 RVA: 0x005BB389 File Offset: 0x005B9589
		public static void StartILevelRefList(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029C4E RID: 171086 RVA: 0x005BB392 File Offset: 0x005B9592
		public static void AddLevelRefList(FlatBufferBuilder builder, VectorOffset levelRefListOffset)
		{
			builder.AddOffset(0, levelRefListOffset.Value, 0);
		}

		// Token: 0x06029C4F RID: 171087 RVA: 0x005BB3A4 File Offset: 0x005B95A4
		public static VectorOffset CreateLevelRefListVector(FlatBufferBuilder builder, Offset<ILevelRefData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029C50 RID: 171088 RVA: 0x005BB3E4 File Offset: 0x005B95E4
		public static VectorOffset CreateLevelRefListVectorBlock(FlatBufferBuilder builder, Offset<ILevelRefData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILevelRefData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029C51 RID: 171089 RVA: 0x005BB3FE File Offset: 0x005B95FE
		public static VectorOffset CreateLevelRefListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILevelRefData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILevelRefData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029C52 RID: 171090 RVA: 0x005BB41C File Offset: 0x005B961C
		public static VectorOffset CreateLevelRefListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILevelRefData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029C53 RID: 171091 RVA: 0x005BB435 File Offset: 0x005B9635
		public static void StartLevelRefListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029C54 RID: 171092 RVA: 0x005BB440 File Offset: 0x005B9640
		public static Offset<ILevelRefList> EndILevelRefList(FlatBufferBuilder builder)
		{
			return new Offset<ILevelRefList>(builder.EndTable());
		}

		// Token: 0x06029C55 RID: 171093 RVA: 0x005BB450 File Offset: 0x005B9650
		public ILevelRefListT UnPack()
		{
			ILevelRefListT levelRefListT = new ILevelRefListT();
			this.UnPackTo(levelRefListT);
			return levelRefListT;
		}

		// Token: 0x06029C56 RID: 171094 RVA: 0x005BB46C File Offset: 0x005B966C
		public void UnPackTo(ILevelRefListT _o)
		{
			_o.LevelRefList = new List<ILevelRefDataT>();
			for (int i = 0; i < this.LevelRefListLength; i++)
			{
				_o.LevelRefList.Add((this.LevelRefList(i) != null) ? this.LevelRefList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06029C57 RID: 171095 RVA: 0x005BB4CC File Offset: 0x005B96CC
		public static Offset<ILevelRefList> Pack(FlatBufferBuilder builder, ILevelRefListT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelRefList>);
			}
			VectorOffset levelRefListOffset = default(VectorOffset);
			if (_o.LevelRefList != null)
			{
				Offset<ILevelRefData>[] array = new Offset<ILevelRefData>[_o.LevelRefList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ILevelRefData.Pack(builder, _o.LevelRefList[i]);
				}
				levelRefListOffset = ILevelRefList.CreateLevelRefListVector(builder, array);
			}
			return ILevelRefList.CreateILevelRefList(builder, levelRefListOffset);
		}

		// Token: 0x0400FA03 RID: 64003
		private Table __p;
	}
}
