using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200413F RID: 16703
	public struct IAwakeAndLoadEntityCondition : IFlatbufferObject
	{
		// Token: 0x17007117 RID: 28951
		// (get) Token: 0x06016EE7 RID: 93927 RVA: 0x003459FA File Offset: 0x00343BFA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016EE8 RID: 93928 RVA: 0x00345A07 File Offset: 0x00343C07
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016EE9 RID: 93929 RVA: 0x00345A10 File Offset: 0x00343C10
		public static IAwakeAndLoadEntityCondition GetRootAsIAwakeAndLoadEntityCondition(ByteBuffer _bb)
		{
			return IAwakeAndLoadEntityCondition.GetRootAsIAwakeAndLoadEntityCondition(_bb, default(IAwakeAndLoadEntityCondition));
		}

		// Token: 0x06016EEA RID: 93930 RVA: 0x00345A2C File Offset: 0x00343C2C
		public static IAwakeAndLoadEntityCondition GetRootAsIAwakeAndLoadEntityCondition(ByteBuffer _bb, IAwakeAndLoadEntityCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016EEB RID: 93931 RVA: 0x00345A49 File Offset: 0x00343C49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016EEC RID: 93932 RVA: 0x00345A58 File Offset: 0x00343C58
		public IAwakeAndLoadEntityCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007118 RID: 28952
		// (get) Token: 0x06016EED RID: 93933 RVA: 0x00345A68 File Offset: 0x00343C68
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007119 RID: 28953
		// (get) Token: 0x06016EEE RID: 93934 RVA: 0x00345AA4 File Offset: 0x00343CA4
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06016EEF RID: 93935 RVA: 0x00345B04 File Offset: 0x00343D04
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700711A RID: 28954
		// (get) Token: 0x06016EF0 RID: 93936 RVA: 0x00345B44 File Offset: 0x00343D44
		public int EntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06016EF1 RID: 93937 RVA: 0x00345B6F File Offset: 0x00343D6F
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06016EF2 RID: 93938 RVA: 0x00345B7E File Offset: 0x00343D7E
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700711B RID: 28955
		// (get) Token: 0x06016EF3 RID: 93939 RVA: 0x00345B8C File Offset: 0x00343D8C
		public bool IsWaitForShow
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700711C RID: 28956
		// (get) Token: 0x06016EF4 RID: 93940 RVA: 0x00345BCC File Offset: 0x00343DCC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016EF5 RID: 93941 RVA: 0x00345C09 File Offset: 0x00343E09
		public static Offset<IAwakeAndLoadEntityCondition> CreateIAwakeAndLoadEntityCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), VectorOffset EntityIdsOffset = default(VectorOffset), bool IsWaitForShow = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IAwakeAndLoadEntityCondition.AddEntityIds(builder, EntityIdsOffset);
			IAwakeAndLoadEntityCondition.AddPreConditions(builder, PreConditionsOffset);
			IAwakeAndLoadEntityCondition.AddNullMask(builder, NullMask);
			IAwakeAndLoadEntityCondition.AddIsWaitForShow(builder, IsWaitForShow);
			IAwakeAndLoadEntityCondition.AddType(builder, Type);
			return IAwakeAndLoadEntityCondition.EndIAwakeAndLoadEntityCondition(builder);
		}

		// Token: 0x06016EF6 RID: 93942 RVA: 0x00345C3D File Offset: 0x00343E3D
		public static void StartIAwakeAndLoadEntityCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06016EF7 RID: 93943 RVA: 0x00345C46 File Offset: 0x00343E46
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016EF8 RID: 93944 RVA: 0x00345C51 File Offset: 0x00343E51
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06016EF9 RID: 93945 RVA: 0x00345C61 File Offset: 0x00343E61
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(2, entityIdsOffset.Value, 0);
		}

		// Token: 0x06016EFA RID: 93946 RVA: 0x00345C74 File Offset: 0x00343E74
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06016EFB RID: 93947 RVA: 0x00345CAB File Offset: 0x00343EAB
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016EFC RID: 93948 RVA: 0x00345CC5 File Offset: 0x00343EC5
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016EFD RID: 93949 RVA: 0x00345CE3 File Offset: 0x00343EE3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016EFE RID: 93950 RVA: 0x00345CFC File Offset: 0x00343EFC
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016EFF RID: 93951 RVA: 0x00345D07 File Offset: 0x00343F07
		public static void AddIsWaitForShow(FlatBufferBuilder builder, bool isWaitForShow)
		{
			builder.AddBool(3, isWaitForShow, false);
		}

		// Token: 0x06016F00 RID: 93952 RVA: 0x00345D12 File Offset: 0x00343F12
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06016F01 RID: 93953 RVA: 0x00345D1D File Offset: 0x00343F1D
		public static Offset<IAwakeAndLoadEntityCondition> EndIAwakeAndLoadEntityCondition(FlatBufferBuilder builder)
		{
			return new Offset<IAwakeAndLoadEntityCondition>(builder.EndTable());
		}

		// Token: 0x06016F02 RID: 93954 RVA: 0x00345D2C File Offset: 0x00343F2C
		public IAwakeAndLoadEntityConditionT UnPack()
		{
			IAwakeAndLoadEntityConditionT awakeAndLoadEntityConditionT = new IAwakeAndLoadEntityConditionT();
			this.UnPackTo(awakeAndLoadEntityConditionT);
			return awakeAndLoadEntityConditionT;
		}

		// Token: 0x06016F03 RID: 93955 RVA: 0x00345D48 File Offset: 0x00343F48
		public void UnPackTo(IAwakeAndLoadEntityConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.IsWaitForShow = this.IsWaitForShow;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016F04 RID: 93956 RVA: 0x00345DD8 File Offset: 0x00343FD8
		public static Offset<IAwakeAndLoadEntityCondition> Pack(FlatBufferBuilder builder, IAwakeAndLoadEntityConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAwakeAndLoadEntityCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IAwakeAndLoadEntityCondition.CreateEntityIdsVector(builder, data);
			}
			return IAwakeAndLoadEntityCondition.CreateIAwakeAndLoadEntityCondition(builder, _o.Type, preConditionsOffset, entityIdsOffset, _o.IsWaitForShow, _o.NullMask);
		}

		// Token: 0x0400BF8E RID: 49038
		private Table __p;
	}
}
