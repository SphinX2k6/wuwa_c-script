using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C0D RID: 19469
	public struct IEntityDataConfig : IFlatbufferObject
	{
		// Token: 0x170089F9 RID: 35321
		// (get) Token: 0x0601DC8A RID: 121994 RVA: 0x0042D9C9 File Offset: 0x0042BBC9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DC8B RID: 121995 RVA: 0x0042D9D6 File Offset: 0x0042BBD6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DC8C RID: 121996 RVA: 0x0042D9E0 File Offset: 0x0042BBE0
		public static IEntityDataConfig GetRootAsIEntityDataConfig(ByteBuffer _bb)
		{
			return IEntityDataConfig.GetRootAsIEntityDataConfig(_bb, default(IEntityDataConfig));
		}

		// Token: 0x0601DC8D RID: 121997 RVA: 0x0042D9FC File Offset: 0x0042BBFC
		public static IEntityDataConfig GetRootAsIEntityDataConfig(ByteBuffer _bb, IEntityDataConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DC8E RID: 121998 RVA: 0x0042DA19 File Offset: 0x0042BC19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DC8F RID: 121999 RVA: 0x0042DA28 File Offset: 0x0042BC28
		public IEntityDataConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601DC90 RID: 122000 RVA: 0x0042DA38 File Offset: 0x0042BC38
		public IEntityTemplate? EntityDatas(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEntityTemplate?(default(IEntityTemplate).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170089FA RID: 35322
		// (get) Token: 0x0601DC91 RID: 122001 RVA: 0x0042DA98 File Offset: 0x0042BC98
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

		// Token: 0x0601DC92 RID: 122002 RVA: 0x0042DAC3 File Offset: 0x0042BCC3
		public static Offset<IEntityDataConfig> CreateIEntityDataConfig(FlatBufferBuilder builder, VectorOffset EntityDatasOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IEntityDataConfig.AddEntityDatas(builder, EntityDatasOffset);
			return IEntityDataConfig.EndIEntityDataConfig(builder);
		}

		// Token: 0x0601DC93 RID: 122003 RVA: 0x0042DAD9 File Offset: 0x0042BCD9
		public static void StartIEntityDataConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601DC94 RID: 122004 RVA: 0x0042DAE2 File Offset: 0x0042BCE2
		public static void AddEntityDatas(FlatBufferBuilder builder, VectorOffset entityDatasOffset)
		{
			builder.AddOffset(0, entityDatasOffset.Value, 0);
		}

		// Token: 0x0601DC95 RID: 122005 RVA: 0x0042DAF4 File Offset: 0x0042BCF4
		public static VectorOffset CreateEntityDatasVector(FlatBufferBuilder builder, Offset<IEntityTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DC96 RID: 122006 RVA: 0x0042DB34 File Offset: 0x0042BD34
		public static VectorOffset CreateEntityDatasVectorBlock(FlatBufferBuilder builder, Offset<IEntityTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DC97 RID: 122007 RVA: 0x0042DB4E File Offset: 0x0042BD4E
		public static VectorOffset CreateEntityDatasVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityTemplate>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DC98 RID: 122008 RVA: 0x0042DB6C File Offset: 0x0042BD6C
		public static VectorOffset CreateEntityDatasVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityTemplate>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DC99 RID: 122009 RVA: 0x0042DB85 File Offset: 0x0042BD85
		public static void StartEntityDatasVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DC9A RID: 122010 RVA: 0x0042DB90 File Offset: 0x0042BD90
		public static Offset<IEntityDataConfig> EndIEntityDataConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEntityDataConfig>(builder.EndTable());
		}

		// Token: 0x0601DC9B RID: 122011 RVA: 0x0042DBA0 File Offset: 0x0042BDA0
		public IEntityDataConfigT UnPack()
		{
			IEntityDataConfigT entityDataConfigT = new IEntityDataConfigT();
			this.UnPackTo(entityDataConfigT);
			return entityDataConfigT;
		}

		// Token: 0x0601DC9C RID: 122012 RVA: 0x0042DBBC File Offset: 0x0042BDBC
		public void UnPackTo(IEntityDataConfigT _o)
		{
			_o.EntityDatas = new List<IEntityTemplateT>();
			for (int i = 0; i < this.EntityDatasLength; i++)
			{
				_o.EntityDatas.Add((this.EntityDatas(i) != null) ? this.EntityDatas(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601DC9D RID: 122013 RVA: 0x0042DC1C File Offset: 0x0042BE1C
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

		// Token: 0x0400D65A RID: 54874
		private Table __p;
	}
}
