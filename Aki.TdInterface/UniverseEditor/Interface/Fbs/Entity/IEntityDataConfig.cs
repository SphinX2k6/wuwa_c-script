using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047A5 RID: 18341
	public struct IEntityDataConfig : IFlatbufferObject
	{
		// Token: 0x170083B8 RID: 33720
		// (get) Token: 0x0601C4B5 RID: 115893 RVA: 0x0040172D File Offset: 0x003FF92D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C4B6 RID: 115894 RVA: 0x0040173A File Offset: 0x003FF93A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C4B7 RID: 115895 RVA: 0x00401744 File Offset: 0x003FF944
		public static IEntityDataConfig GetRootAsIEntityDataConfig(ByteBuffer _bb)
		{
			return IEntityDataConfig.GetRootAsIEntityDataConfig(_bb, default(IEntityDataConfig));
		}

		// Token: 0x0601C4B8 RID: 115896 RVA: 0x00401760 File Offset: 0x003FF960
		public static IEntityDataConfig GetRootAsIEntityDataConfig(ByteBuffer _bb, IEntityDataConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C4B9 RID: 115897 RVA: 0x0040177D File Offset: 0x003FF97D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C4BA RID: 115898 RVA: 0x0040178C File Offset: 0x003FF98C
		public IEntityDataConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601C4BB RID: 115899 RVA: 0x0040179C File Offset: 0x003FF99C
		public IEntityTemplate? EntityDatas(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEntityTemplate?(default(IEntityTemplate).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170083B9 RID: 33721
		// (get) Token: 0x0601C4BC RID: 115900 RVA: 0x004017FC File Offset: 0x003FF9FC
		public int EntityDatasLength
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

		// Token: 0x0601C4BD RID: 115901 RVA: 0x00401827 File Offset: 0x003FFA27
		public static Offset<IEntityDataConfig> CreateIEntityDataConfig(FlatBufferBuilder builder, VectorOffset EntityDatasOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IEntityDataConfig.AddEntityDatas(builder, EntityDatasOffset);
			return IEntityDataConfig.EndIEntityDataConfig(builder);
		}

		// Token: 0x0601C4BE RID: 115902 RVA: 0x0040183D File Offset: 0x003FFA3D
		public static void StartIEntityDataConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C4BF RID: 115903 RVA: 0x00401846 File Offset: 0x003FFA46
		public static void AddEntityDatas(FlatBufferBuilder builder, VectorOffset entityDatasOffset)
		{
			builder.AddOffset(0, entityDatasOffset.Value, 0);
		}

		// Token: 0x0601C4C0 RID: 115904 RVA: 0x00401858 File Offset: 0x003FFA58
		public static VectorOffset CreateEntityDatasVector(FlatBufferBuilder builder, Offset<IEntityTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C4C1 RID: 115905 RVA: 0x00401898 File Offset: 0x003FFA98
		public static VectorOffset CreateEntityDatasVectorBlock(FlatBufferBuilder builder, Offset<IEntityTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C4C2 RID: 115906 RVA: 0x004018B2 File Offset: 0x003FFAB2
		public static VectorOffset CreateEntityDatasVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityTemplate>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C4C3 RID: 115907 RVA: 0x004018D0 File Offset: 0x003FFAD0
		public static VectorOffset CreateEntityDatasVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityTemplate>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C4C4 RID: 115908 RVA: 0x004018E9 File Offset: 0x003FFAE9
		public static void StartEntityDatasVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C4C5 RID: 115909 RVA: 0x004018F4 File Offset: 0x003FFAF4
		public static Offset<IEntityDataConfig> EndIEntityDataConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEntityDataConfig>(builder.EndTable());
		}

		// Token: 0x0601C4C6 RID: 115910 RVA: 0x00401904 File Offset: 0x003FFB04
		public IEntityDataConfigT UnPack()
		{
			IEntityDataConfigT entityDataConfigT = new IEntityDataConfigT();
			this.UnPackTo(entityDataConfigT);
			return entityDataConfigT;
		}

		// Token: 0x0601C4C7 RID: 115911 RVA: 0x00401920 File Offset: 0x003FFB20
		public void UnPackTo(IEntityDataConfigT _o)
		{
			_o.EntityDatas = new List<IEntityTemplateT>();
			for (int i = 0; i < this.EntityDatasLength; i++)
			{
				_o.EntityDatas.Add((this.EntityDatas(i) != null) ? this.EntityDatas(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601C4C8 RID: 115912 RVA: 0x00401980 File Offset: 0x003FFB80
		public static Offset<IEntityDataConfig> Pack(FlatBufferBuilder builder, IEntityDataConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityDataConfig>);
			}
			VectorOffset entityDatasOffset = default(VectorOffset);
			if (_o.EntityDatas != null)
			{
				Offset<IEntityTemplate>[] array = new Offset<IEntityTemplate>[_o.EntityDatas.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityTemplate.Pack(builder, _o.EntityDatas[i]);
				}
				entityDatasOffset = IEntityDataConfig.CreateEntityDatasVector(builder, array);
			}
			return IEntityDataConfig.CreateIEntityDataConfig(builder, entityDatasOffset);
		}

		// Token: 0x0400CC24 RID: 52260
		private Table __p;
	}
}
