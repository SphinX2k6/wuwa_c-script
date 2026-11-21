using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044CC RID: 17612
	public struct IRecallEntityConfig : IFlatbufferObject
	{
		// Token: 0x17007A99 RID: 31385
		// (get) Token: 0x0601972A RID: 104234 RVA: 0x003A1630 File Offset: 0x0039F830
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601972B RID: 104235 RVA: 0x003A163D File Offset: 0x0039F83D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601972C RID: 104236 RVA: 0x003A1644 File Offset: 0x0039F844
		public static IRecallEntityConfig GetRootAsIRecallEntityConfig(ByteBuffer _bb)
		{
			return IRecallEntityConfig.GetRootAsIRecallEntityConfig(_bb, default(IRecallEntityConfig));
		}

		// Token: 0x0601972D RID: 104237 RVA: 0x003A1660 File Offset: 0x0039F860
		public static IRecallEntityConfig GetRootAsIRecallEntityConfig(ByteBuffer _bb, IRecallEntityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601972E RID: 104238 RVA: 0x003A167D File Offset: 0x0039F87D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601972F RID: 104239 RVA: 0x003A168C File Offset: 0x0039F88C
		public IRecallEntityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06019730 RID: 104240 RVA: 0x003A169C File Offset: 0x0039F89C
		public IRecallEntityGroup? EntityGroups(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IRecallEntityGroup?(default(IRecallEntityGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007A9A RID: 31386
		// (get) Token: 0x06019731 RID: 104241 RVA: 0x003A16FC File Offset: 0x0039F8FC
		public int EntityGroupsLength
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

		// Token: 0x06019732 RID: 104242 RVA: 0x003A1728 File Offset: 0x0039F928
		public IRecallEntry? Recalls(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IRecallEntry?(default(IRecallEntry).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007A9B RID: 31387
		// (get) Token: 0x06019733 RID: 104243 RVA: 0x003A1788 File Offset: 0x0039F988
		public int RecallsLength
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

		// Token: 0x06019734 RID: 104244 RVA: 0x003A17B3 File Offset: 0x0039F9B3
		public static Offset<IRecallEntityConfig> CreateIRecallEntityConfig(FlatBufferBuilder builder, VectorOffset EntityGroupsOffset = default(VectorOffset), VectorOffset RecallsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRecallEntityConfig.AddRecalls(builder, RecallsOffset);
			IRecallEntityConfig.AddEntityGroups(builder, EntityGroupsOffset);
			return IRecallEntityConfig.EndIRecallEntityConfig(builder);
		}

		// Token: 0x06019735 RID: 104245 RVA: 0x003A17D0 File Offset: 0x0039F9D0
		public static void StartIRecallEntityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06019736 RID: 104246 RVA: 0x003A17D9 File Offset: 0x0039F9D9
		public static void AddEntityGroups(FlatBufferBuilder builder, VectorOffset entityGroupsOffset)
		{
			builder.AddOffset(0, entityGroupsOffset.Value, 0);
		}

		// Token: 0x06019737 RID: 104247 RVA: 0x003A17EC File Offset: 0x0039F9EC
		public static VectorOffset CreateEntityGroupsVector(FlatBufferBuilder builder, Offset<IRecallEntityGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019738 RID: 104248 RVA: 0x003A182C File Offset: 0x0039FA2C
		public static VectorOffset CreateEntityGroupsVectorBlock(FlatBufferBuilder builder, Offset<IRecallEntityGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRecallEntityGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019739 RID: 104249 RVA: 0x003A1846 File Offset: 0x0039FA46
		public static VectorOffset CreateEntityGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRecallEntityGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRecallEntityGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601973A RID: 104250 RVA: 0x003A1864 File Offset: 0x0039FA64
		public static VectorOffset CreateEntityGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRecallEntityGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601973B RID: 104251 RVA: 0x003A187D File Offset: 0x0039FA7D
		public static void StartEntityGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601973C RID: 104252 RVA: 0x003A1888 File Offset: 0x0039FA88
		public static void AddRecalls(FlatBufferBuilder builder, VectorOffset recallsOffset)
		{
			builder.AddOffset(1, recallsOffset.Value, 0);
		}

		// Token: 0x0601973D RID: 104253 RVA: 0x003A1898 File Offset: 0x0039FA98
		public static VectorOffset CreateRecallsVector(FlatBufferBuilder builder, Offset<IRecallEntry>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601973E RID: 104254 RVA: 0x003A18D8 File Offset: 0x0039FAD8
		public static VectorOffset CreateRecallsVectorBlock(FlatBufferBuilder builder, Offset<IRecallEntry>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRecallEntry>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601973F RID: 104255 RVA: 0x003A18F2 File Offset: 0x0039FAF2
		public static VectorOffset CreateRecallsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRecallEntry>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRecallEntry>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019740 RID: 104256 RVA: 0x003A1910 File Offset: 0x0039FB10
		public static VectorOffset CreateRecallsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRecallEntry>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019741 RID: 104257 RVA: 0x003A1929 File Offset: 0x0039FB29
		public static void StartRecallsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019742 RID: 104258 RVA: 0x003A1934 File Offset: 0x0039FB34
		public static Offset<IRecallEntityConfig> EndIRecallEntityConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRecallEntityConfig>(builder.EndTable());
		}

		// Token: 0x06019743 RID: 104259 RVA: 0x003A1944 File Offset: 0x0039FB44
		public IRecallEntityConfigT UnPack()
		{
			IRecallEntityConfigT recallEntityConfigT = new IRecallEntityConfigT();
			this.UnPackTo(recallEntityConfigT);
			return recallEntityConfigT;
		}

		// Token: 0x06019744 RID: 104260 RVA: 0x003A1960 File Offset: 0x0039FB60
		public void UnPackTo(IRecallEntityConfigT _o)
		{
			_o.EntityGroups = new List<IRecallEntityGroupT>();
			for (int i = 0; i < this.EntityGroupsLength; i++)
			{
				_o.EntityGroups.Add((this.EntityGroups(i) != null) ? this.EntityGroups(i).Value.UnPack() : null);
			}
			_o.Recalls = new List<IRecallEntryT>();
			for (int j = 0; j < this.RecallsLength; j++)
			{
				_o.Recalls.Add((this.Recalls(j) != null) ? this.Recalls(j).Value.UnPack() : null);
			}
		}

		// Token: 0x06019745 RID: 104261 RVA: 0x003A1A14 File Offset: 0x0039FC14
		public static Offset<IRecallEntityConfig> Pack(FlatBufferBuilder builder, IRecallEntityConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecallEntityConfig>);
			}
			VectorOffset entityGroupsOffset = default(VectorOffset);
			if (_o.EntityGroups != null)
			{
				Offset<IRecallEntityGroup>[] array = new Offset<IRecallEntityGroup>[_o.EntityGroups.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IRecallEntityGroup.Pack(builder, _o.EntityGroups[i]);
				}
				entityGroupsOffset = IRecallEntityConfig.CreateEntityGroupsVector(builder, array);
			}
			VectorOffset recallsOffset = default(VectorOffset);
			if (_o.Recalls != null)
			{
				Offset<IRecallEntry>[] array2 = new Offset<IRecallEntry>[_o.Recalls.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IRecallEntry.Pack(builder, _o.Recalls[j]);
				}
				recallsOffset = IRecallEntityConfig.CreateRecallsVector(builder, array2);
			}
			return IRecallEntityConfig.CreateIRecallEntityConfig(builder, entityGroupsOffset, recallsOffset);
		}

		// Token: 0x0400C5FB RID: 50683
		private Table __p;
	}
}
