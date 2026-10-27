using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005587 RID: 21895
	public struct IMonsterNpcInteractionEnableConfig : IFlatbufferObject
	{
		// Token: 0x1700A1CB RID: 41419
		// (get) Token: 0x060243E9 RID: 148457 RVA: 0x005014C8 File Offset: 0x004FF6C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060243EA RID: 148458 RVA: 0x005014D5 File Offset: 0x004FF6D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060243EB RID: 148459 RVA: 0x005014DC File Offset: 0x004FF6DC
		public static IMonsterNpcInteractionEnableConfig GetRootAsIMonsterNpcInteractionEnableConfig(ByteBuffer _bb)
		{
			return IMonsterNpcInteractionEnableConfig.GetRootAsIMonsterNpcInteractionEnableConfig(_bb, default(IMonsterNpcInteractionEnableConfig));
		}

		// Token: 0x060243EC RID: 148460 RVA: 0x005014F8 File Offset: 0x004FF6F8
		public static IMonsterNpcInteractionEnableConfig GetRootAsIMonsterNpcInteractionEnableConfig(ByteBuffer _bb, IMonsterNpcInteractionEnableConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060243ED RID: 148461 RVA: 0x00501515 File Offset: 0x004FF715
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060243EE RID: 148462 RVA: 0x00501524 File Offset: 0x004FF724
		public IMonsterNpcInteractionEnableConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060243EF RID: 148463 RVA: 0x00501534 File Offset: 0x004FF734
		public TMonsterNpcInteractionConfig InteractionsType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TMonsterNpcInteractionConfig.NONE;
			}
			return (TMonsterNpcInteractionConfig)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700A1CC RID: 41420
		// (get) Token: 0x060243F0 RID: 148464 RVA: 0x00501574 File Offset: 0x004FF774
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

		// Token: 0x060243F1 RID: 148465 RVA: 0x0050159F File Offset: 0x004FF79F
		public Span<TMonsterNpcInteractionConfig> GetInteractionsTypeBytes()
		{
			return this.__p.__vector_as_span<TMonsterNpcInteractionConfig>(4, 1);
		}

		// Token: 0x060243F2 RID: 148466 RVA: 0x005015B0 File Offset: 0x004FF7B0
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

		// Token: 0x060243F3 RID: 148467 RVA: 0x0050161C File Offset: 0x004FF81C
		public TTable? Interactions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700A1CD RID: 41421
		// (get) Token: 0x060243F4 RID: 148468 RVA: 0x00501664 File Offset: 0x004FF864
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

		// Token: 0x060243F5 RID: 148469 RVA: 0x0050168F File Offset: 0x004FF88F
		public static Offset<IMonsterNpcInteractionEnableConfig> CreateIMonsterNpcInteractionEnableConfig(FlatBufferBuilder builder, VectorOffset Interactions_typeOffset = default(VectorOffset), VectorOffset InteractionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IMonsterNpcInteractionEnableConfig.AddInteractions(builder, InteractionsOffset);
			IMonsterNpcInteractionEnableConfig.AddInteractionsType(builder, Interactions_typeOffset);
			return IMonsterNpcInteractionEnableConfig.EndIMonsterNpcInteractionEnableConfig(builder);
		}

		// Token: 0x060243F6 RID: 148470 RVA: 0x005016AC File Offset: 0x004FF8AC
		public static void StartIMonsterNpcInteractionEnableConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060243F7 RID: 148471 RVA: 0x005016B5 File Offset: 0x004FF8B5
		public static void AddInteractionsType(FlatBufferBuilder builder, VectorOffset interactionsTypeOffset)
		{
			builder.AddOffset(0, interactionsTypeOffset.Value, 0);
		}

		// Token: 0x060243F8 RID: 148472 RVA: 0x005016C8 File Offset: 0x004FF8C8
		public static VectorOffset CreateInteractionsTypeVector(FlatBufferBuilder builder, TMonsterNpcInteractionConfig[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060243F9 RID: 148473 RVA: 0x005016FF File Offset: 0x004FF8FF
		public static VectorOffset CreateInteractionsTypeVectorBlock(FlatBufferBuilder builder, TMonsterNpcInteractionConfig[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMonsterNpcInteractionConfig>(data);
			return builder.EndVector();
		}

		// Token: 0x060243FA RID: 148474 RVA: 0x00501719 File Offset: 0x004FF919
		public static VectorOffset CreateInteractionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMonsterNpcInteractionConfig> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMonsterNpcInteractionConfig>(data);
			return builder.EndVector();
		}

		// Token: 0x060243FB RID: 148475 RVA: 0x00501737 File Offset: 0x004FF937
		public static VectorOffset CreateInteractionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMonsterNpcInteractionConfig>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060243FC RID: 148476 RVA: 0x00501750 File Offset: 0x004FF950
		public static void StartInteractionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060243FD RID: 148477 RVA: 0x0050175B File Offset: 0x004FF95B
		public static void AddInteractions(FlatBufferBuilder builder, VectorOffset interactionsOffset)
		{
			builder.AddOffset(1, interactionsOffset.Value, 0);
		}

		// Token: 0x060243FE RID: 148478 RVA: 0x0050176C File Offset: 0x004FF96C
		public static VectorOffset CreateInteractionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060243FF RID: 148479 RVA: 0x005017A3 File Offset: 0x004FF9A3
		public static VectorOffset CreateInteractionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024400 RID: 148480 RVA: 0x005017BD File Offset: 0x004FF9BD
		public static VectorOffset CreateInteractionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024401 RID: 148481 RVA: 0x005017DB File Offset: 0x004FF9DB
		public static VectorOffset CreateInteractionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024402 RID: 148482 RVA: 0x005017F4 File Offset: 0x004FF9F4
		public static void StartInteractionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024403 RID: 148483 RVA: 0x005017FF File Offset: 0x004FF9FF
		public static Offset<IMonsterNpcInteractionEnableConfig> EndIMonsterNpcInteractionEnableConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterNpcInteractionEnableConfig>(builder.EndTable());
		}

		// Token: 0x06024404 RID: 148484 RVA: 0x0050180C File Offset: 0x004FFA0C
		public IMonsterNpcInteractionEnableConfigT UnPack()
		{
			IMonsterNpcInteractionEnableConfigT monsterNpcInteractionEnableConfigT = new IMonsterNpcInteractionEnableConfigT();
			this.UnPackTo(monsterNpcInteractionEnableConfigT);
			return monsterNpcInteractionEnableConfigT;
		}

		// Token: 0x06024405 RID: 148485 RVA: 0x00501828 File Offset: 0x004FFA28
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

		// Token: 0x06024406 RID: 148486 RVA: 0x00501974 File Offset: 0x004FFB74
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

		// Token: 0x0400E8BB RID: 59579
		private Table __p;
	}
}
