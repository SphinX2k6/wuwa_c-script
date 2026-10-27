using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200408B RID: 16523
	public struct IRecallEntityConfig : IFlatbufferObject
	{
		// Token: 0x17007497 RID: 29847
		// (get) Token: 0x06018091 RID: 98449 RVA: 0x003777F8 File Offset: 0x003759F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018092 RID: 98450 RVA: 0x00377805 File Offset: 0x00375A05
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018093 RID: 98451 RVA: 0x0037780C File Offset: 0x00375A0C
		public static IRecallEntityConfig GetRootAsIRecallEntityConfig(ByteBuffer _bb)
		{
			return IRecallEntityConfig.GetRootAsIRecallEntityConfig(_bb, default(IRecallEntityConfig));
		}

		// Token: 0x06018094 RID: 98452 RVA: 0x00377828 File Offset: 0x00375A28
		public static IRecallEntityConfig GetRootAsIRecallEntityConfig(ByteBuffer _bb, IRecallEntityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018095 RID: 98453 RVA: 0x00377845 File Offset: 0x00375A45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018096 RID: 98454 RVA: 0x00377854 File Offset: 0x00375A54
		public IRecallEntityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06018097 RID: 98455 RVA: 0x00377864 File Offset: 0x00375A64
		public IRecallEntityGroup? EntityGroups(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IRecallEntityGroup?(default(IRecallEntityGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007498 RID: 29848
		// (get) Token: 0x06018098 RID: 98456 RVA: 0x003778C4 File Offset: 0x00375AC4
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

		// Token: 0x06018099 RID: 98457 RVA: 0x003778F0 File Offset: 0x00375AF0
		public IRecallEntry? Recalls(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IRecallEntry?(default(IRecallEntry).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007499 RID: 29849
		// (get) Token: 0x0601809A RID: 98458 RVA: 0x00377950 File Offset: 0x00375B50
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

		// Token: 0x0601809B RID: 98459 RVA: 0x0037797B File Offset: 0x00375B7B
		public static Offset<IRecallEntityConfig> CreateIRecallEntityConfig(FlatBufferBuilder builder, VectorOffset EntityGroupsOffset = default(VectorOffset), VectorOffset RecallsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRecallEntityConfig.AddRecalls(builder, RecallsOffset);
			IRecallEntityConfig.AddEntityGroups(builder, EntityGroupsOffset);
			return IRecallEntityConfig.EndIRecallEntityConfig(builder);
		}

		// Token: 0x0601809C RID: 98460 RVA: 0x00377998 File Offset: 0x00375B98
		public static void StartIRecallEntityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601809D RID: 98461 RVA: 0x003779A1 File Offset: 0x00375BA1
		public static void AddEntityGroups(FlatBufferBuilder builder, VectorOffset entityGroupsOffset)
		{
			builder.AddOffset(0, entityGroupsOffset.Value, 0);
		}

		// Token: 0x0601809E RID: 98462 RVA: 0x003779B4 File Offset: 0x00375BB4
		public static VectorOffset CreateEntityGroupsVector(FlatBufferBuilder builder, Offset<IRecallEntityGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601809F RID: 98463 RVA: 0x003779F4 File Offset: 0x00375BF4
		public static VectorOffset CreateEntityGroupsVectorBlock(FlatBufferBuilder builder, Offset<IRecallEntityGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRecallEntityGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x060180A0 RID: 98464 RVA: 0x00377A0E File Offset: 0x00375C0E
		public static VectorOffset CreateEntityGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRecallEntityGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRecallEntityGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x060180A1 RID: 98465 RVA: 0x00377A2C File Offset: 0x00375C2C
		public static VectorOffset CreateEntityGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRecallEntityGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060180A2 RID: 98466 RVA: 0x00377A45 File Offset: 0x00375C45
		public static void StartEntityGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060180A3 RID: 98467 RVA: 0x00377A50 File Offset: 0x00375C50
		public static void AddRecalls(FlatBufferBuilder builder, VectorOffset recallsOffset)
		{
			builder.AddOffset(1, recallsOffset.Value, 0);
		}

		// Token: 0x060180A4 RID: 98468 RVA: 0x00377A60 File Offset: 0x00375C60
		public static VectorOffset CreateRecallsVector(FlatBufferBuilder builder, Offset<IRecallEntry>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060180A5 RID: 98469 RVA: 0x00377AA0 File Offset: 0x00375CA0
		public static VectorOffset CreateRecallsVectorBlock(FlatBufferBuilder builder, Offset<IRecallEntry>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRecallEntry>>(data);
			return builder.EndVector();
		}

		// Token: 0x060180A6 RID: 98470 RVA: 0x00377ABA File Offset: 0x00375CBA
		public static VectorOffset CreateRecallsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRecallEntry>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRecallEntry>>(data);
			return builder.EndVector();
		}

		// Token: 0x060180A7 RID: 98471 RVA: 0x00377AD8 File Offset: 0x00375CD8
		public static VectorOffset CreateRecallsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRecallEntry>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060180A8 RID: 98472 RVA: 0x00377AF1 File Offset: 0x00375CF1
		public static void StartRecallsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060180A9 RID: 98473 RVA: 0x00377AFC File Offset: 0x00375CFC
		public static Offset<IRecallEntityConfig> EndIRecallEntityConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRecallEntityConfig>(builder.EndTable());
		}

		// Token: 0x060180AA RID: 98474 RVA: 0x00377B0C File Offset: 0x00375D0C
		public IRecallEntityConfigT UnPack()
		{
			IRecallEntityConfigT recallEntityConfigT = new IRecallEntityConfigT();
			this.UnPackTo(recallEntityConfigT);
			return recallEntityConfigT;
		}

		// Token: 0x060180AB RID: 98475 RVA: 0x00377B28 File Offset: 0x00375D28
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

		// Token: 0x060180AC RID: 98476 RVA: 0x00377BDC File Offset: 0x00375DDC
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

		// Token: 0x0400BC14 RID: 48148
		private Table __p;
	}
}
