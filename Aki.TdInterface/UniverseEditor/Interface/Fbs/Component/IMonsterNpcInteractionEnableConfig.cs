using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B25 RID: 23333
	public struct IMonsterNpcInteractionEnableConfig : IFlatbufferObject
	{
		// Token: 0x1700AA53 RID: 43603
		// (get) Token: 0x060265F6 RID: 157174 RVA: 0x00541A40 File Offset: 0x0053FC40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060265F7 RID: 157175 RVA: 0x00541A4D File Offset: 0x0053FC4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060265F8 RID: 157176 RVA: 0x00541A54 File Offset: 0x0053FC54
		public static IMonsterNpcInteractionEnableConfig GetRootAsIMonsterNpcInteractionEnableConfig(ByteBuffer _bb)
		{
			return IMonsterNpcInteractionEnableConfig.GetRootAsIMonsterNpcInteractionEnableConfig(_bb, default(IMonsterNpcInteractionEnableConfig));
		}

		// Token: 0x060265F9 RID: 157177 RVA: 0x00541A70 File Offset: 0x0053FC70
		public static IMonsterNpcInteractionEnableConfig GetRootAsIMonsterNpcInteractionEnableConfig(ByteBuffer _bb, IMonsterNpcInteractionEnableConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060265FA RID: 157178 RVA: 0x00541A8D File Offset: 0x0053FC8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060265FB RID: 157179 RVA: 0x00541A9C File Offset: 0x0053FC9C
		public IMonsterNpcInteractionEnableConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060265FC RID: 157180 RVA: 0x00541AAC File Offset: 0x0053FCAC
		public TMonsterNpcInteractionConfig InteractionsType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TMonsterNpcInteractionConfig.NONE;
			}
			return (TMonsterNpcInteractionConfig)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700AA54 RID: 43604
		// (get) Token: 0x060265FD RID: 157181 RVA: 0x00541AEC File Offset: 0x0053FCEC
		public int InteractionsTypeLength
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

		// Token: 0x060265FE RID: 157182 RVA: 0x00541B17 File Offset: 0x0053FD17
		public Span<TMonsterNpcInteractionConfig> GetInteractionsTypeBytes()
		{
			return this.__p.__vector_as_span<TMonsterNpcInteractionConfig>(4, 1);
		}

		// Token: 0x060265FF RID: 157183 RVA: 0x00541B28 File Offset: 0x0053FD28
		public TMonsterNpcInteractionConfig[] GetInteractionsTypeArray()
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TMonsterNpcInteractionConfig[] array = new TMonsterNpcInteractionConfig[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TMonsterNpcInteractionConfig)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06026600 RID: 157184 RVA: 0x00541B94 File Offset: 0x0053FD94
		public TTable? Interactions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700AA55 RID: 43605
		// (get) Token: 0x06026601 RID: 157185 RVA: 0x00541BDC File Offset: 0x0053FDDC
		public int InteractionsLength
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

		// Token: 0x06026602 RID: 157186 RVA: 0x00541C07 File Offset: 0x0053FE07
		public static Offset<IMonsterNpcInteractionEnableConfig> CreateIMonsterNpcInteractionEnableConfig(FlatBufferBuilder builder, VectorOffset Interactions_typeOffset = default(VectorOffset), VectorOffset InteractionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IMonsterNpcInteractionEnableConfig.AddInteractions(builder, InteractionsOffset);
			IMonsterNpcInteractionEnableConfig.AddInteractionsType(builder, Interactions_typeOffset);
			return IMonsterNpcInteractionEnableConfig.EndIMonsterNpcInteractionEnableConfig(builder);
		}

		// Token: 0x06026603 RID: 157187 RVA: 0x00541C24 File Offset: 0x0053FE24
		public static void StartIMonsterNpcInteractionEnableConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026604 RID: 157188 RVA: 0x00541C2D File Offset: 0x0053FE2D
		public static void AddInteractionsType(FlatBufferBuilder builder, VectorOffset interactionsTypeOffset)
		{
			builder.AddOffset(0, interactionsTypeOffset.Value, 0);
		}

		// Token: 0x06026605 RID: 157189 RVA: 0x00541C40 File Offset: 0x0053FE40
		public static VectorOffset CreateInteractionsTypeVector(FlatBufferBuilder builder, TMonsterNpcInteractionConfig[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06026606 RID: 157190 RVA: 0x00541C77 File Offset: 0x0053FE77
		public static VectorOffset CreateInteractionsTypeVectorBlock(FlatBufferBuilder builder, TMonsterNpcInteractionConfig[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMonsterNpcInteractionConfig>(data);
			return builder.EndVector();
		}

		// Token: 0x06026607 RID: 157191 RVA: 0x00541C91 File Offset: 0x0053FE91
		public static VectorOffset CreateInteractionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMonsterNpcInteractionConfig> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMonsterNpcInteractionConfig>(data);
			return builder.EndVector();
		}

		// Token: 0x06026608 RID: 157192 RVA: 0x00541CAF File Offset: 0x0053FEAF
		public static VectorOffset CreateInteractionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMonsterNpcInteractionConfig>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026609 RID: 157193 RVA: 0x00541CC8 File Offset: 0x0053FEC8
		public static void StartInteractionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602660A RID: 157194 RVA: 0x00541CD3 File Offset: 0x0053FED3
		public static void AddInteractions(FlatBufferBuilder builder, VectorOffset interactionsOffset)
		{
			builder.AddOffset(1, interactionsOffset.Value, 0);
		}

		// Token: 0x0602660B RID: 157195 RVA: 0x00541CE4 File Offset: 0x0053FEE4
		public static VectorOffset CreateInteractionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602660C RID: 157196 RVA: 0x00541D1B File Offset: 0x0053FF1B
		public static VectorOffset CreateInteractionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602660D RID: 157197 RVA: 0x00541D35 File Offset: 0x0053FF35
		public static VectorOffset CreateInteractionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602660E RID: 157198 RVA: 0x00541D53 File Offset: 0x0053FF53
		public static VectorOffset CreateInteractionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602660F RID: 157199 RVA: 0x00541D6C File Offset: 0x0053FF6C
		public static void StartInteractionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026610 RID: 157200 RVA: 0x00541D77 File Offset: 0x0053FF77
		public static Offset<IMonsterNpcInteractionEnableConfig> EndIMonsterNpcInteractionEnableConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterNpcInteractionEnableConfig>(builder.EndTable());
		}

		// Token: 0x06026611 RID: 157201 RVA: 0x00541D84 File Offset: 0x0053FF84
		public IMonsterNpcInteractionEnableConfigT UnPack()
		{
			IMonsterNpcInteractionEnableConfigT monsterNpcInteractionEnableConfigT = new IMonsterNpcInteractionEnableConfigT();
			this.UnPackTo(monsterNpcInteractionEnableConfigT);
			return monsterNpcInteractionEnableConfigT;
		}

		// Token: 0x06026612 RID: 157202 RVA: 0x00541DA0 File Offset: 0x0053FFA0
		public void UnPackTo(IMonsterNpcInteractionEnableConfigT _o)
		{
			_o.Interactions = new List<TMonsterNpcInteractionConfigUnion>();
			for (int i = 0; i < this.InteractionsLength; i++)
			{
				TMonsterNpcInteractionConfigUnion tmonsterNpcInteractionConfigUnion = new TMonsterNpcInteractionConfigUnion();
				tmonsterNpcInteractionConfigUnion.Type = this.InteractionsType(i);
				switch (this.InteractionsType(i))
				{
				case TMonsterNpcInteractionConfig.IMonsterNpcInteractionGazePerform:
					tmonsterNpcInteractionConfigUnion.Value = ((this.Interactions<IMonsterNpcInteractionGazePerform>(i) != null) ? this.Interactions<IMonsterNpcInteractionGazePerform>(i).Value.UnPack() : null);
					break;
				case TMonsterNpcInteractionConfig.IMonsterNpcInteractionHook:
					tmonsterNpcInteractionConfigUnion.Value = ((this.Interactions<IMonsterNpcInteractionHook>(i) != null) ? this.Interactions<IMonsterNpcInteractionHook>(i).Value.UnPack() : null);
					break;
				case TMonsterNpcInteractionConfig.IMonsterNpcInteractionSwordRiding:
					tmonsterNpcInteractionConfigUnion.Value = ((this.Interactions<IMonsterNpcInteractionSwordRiding>(i) != null) ? this.Interactions<IMonsterNpcInteractionSwordRiding>(i).Value.UnPack() : null);
					break;
				case TMonsterNpcInteractionConfig.IMonsterNpcInteractionWallRun:
					tmonsterNpcInteractionConfigUnion.Value = ((this.Interactions<IMonsterNpcInteractionWallRun>(i) != null) ? this.Interactions<IMonsterNpcInteractionWallRun>(i).Value.UnPack() : null);
					break;
				}
				_o.Interactions.Add(tmonsterNpcInteractionConfigUnion);
			}
		}

		// Token: 0x06026613 RID: 157203 RVA: 0x00541EEC File Offset: 0x005400EC
		public static Offset<IMonsterNpcInteractionEnableConfig> Pack(FlatBufferBuilder builder, IMonsterNpcInteractionEnableConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterNpcInteractionEnableConfig>);
			}
			VectorOffset interactions_typeOffset = default(VectorOffset);
			if (_o.Interactions != null)
			{
				TMonsterNpcInteractionConfig[] array = new TMonsterNpcInteractionConfig[_o.Interactions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Interactions[i].Type;
				}
				interactions_typeOffset = IMonsterNpcInteractionEnableConfig.CreateInteractionsTypeVector(builder, array);
			}
			VectorOffset interactionsOffset = default(VectorOffset);
			if (_o.Interactions != null)
			{
				int[] array2 = new int[_o.Interactions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TMonsterNpcInteractionConfigUnion.Pack(builder, _o.Interactions[j]);
				}
				interactionsOffset = IMonsterNpcInteractionEnableConfig.CreateInteractionsVector(builder, array2);
			}
			return IMonsterNpcInteractionEnableConfig.CreateIMonsterNpcInteractionEnableConfig(builder, interactions_typeOffset, interactionsOffset);
		}

		// Token: 0x0400F51D RID: 62749
		private Table __p;
	}
}
