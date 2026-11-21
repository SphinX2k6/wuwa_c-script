using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D02 RID: 23810
	public struct IPatrolPositionRefreshConfig : IFlatbufferObject
	{
		// Token: 0x1700AEF2 RID: 44786
		// (get) Token: 0x060278AE RID: 161966 RVA: 0x00568EA5 File Offset: 0x005670A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060278AF RID: 161967 RVA: 0x00568EB2 File Offset: 0x005670B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060278B0 RID: 161968 RVA: 0x00568EBC File Offset: 0x005670BC
		public static IPatrolPositionRefreshConfig GetRootAsIPatrolPositionRefreshConfig(ByteBuffer _bb)
		{
			return IPatrolPositionRefreshConfig.GetRootAsIPatrolPositionRefreshConfig(_bb, default(IPatrolPositionRefreshConfig));
		}

		// Token: 0x060278B1 RID: 161969 RVA: 0x00568ED8 File Offset: 0x005670D8
		public static IPatrolPositionRefreshConfig GetRootAsIPatrolPositionRefreshConfig(ByteBuffer _bb, IPatrolPositionRefreshConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060278B2 RID: 161970 RVA: 0x00568EF5 File Offset: 0x005670F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060278B3 RID: 161971 RVA: 0x00568F04 File Offset: 0x00567104
		public IPatrolPositionRefreshConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060278B4 RID: 161972 RVA: 0x00568F14 File Offset: 0x00567114
		public TPatrolPositionRefreshTrigger TriggerConditionsType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TPatrolPositionRefreshTrigger.NONE;
			}
			return (TPatrolPositionRefreshTrigger)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700AEF3 RID: 44787
		// (get) Token: 0x060278B5 RID: 161973 RVA: 0x00568F54 File Offset: 0x00567154
		public int TriggerConditionsTypeLength
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

		// Token: 0x060278B6 RID: 161974 RVA: 0x00568F7F File Offset: 0x0056717F
		public Span<TPatrolPositionRefreshTrigger> GetTriggerConditionsTypeBytes()
		{
			return this.__p.__vector_as_span<TPatrolPositionRefreshTrigger>(4, 1);
		}

		// Token: 0x060278B7 RID: 161975 RVA: 0x00568F90 File Offset: 0x00567190
		public TPatrolPositionRefreshTrigger[] GetTriggerConditionsTypeArray()
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TPatrolPositionRefreshTrigger[] array = new TPatrolPositionRefreshTrigger[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TPatrolPositionRefreshTrigger)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x060278B8 RID: 161976 RVA: 0x00568FFC File Offset: 0x005671FC
		public TTable? TriggerConditions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700AEF4 RID: 44788
		// (get) Token: 0x060278B9 RID: 161977 RVA: 0x00569044 File Offset: 0x00567244
		public int TriggerConditionsLength
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

		// Token: 0x1700AEF5 RID: 44789
		// (get) Token: 0x060278BA RID: 161978 RVA: 0x00569070 File Offset: 0x00567270
		public IPatrolPositionRefreshAtNearestSplinePointToPlayer? Refresh
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IPatrolPositionRefreshAtNearestSplinePointToPlayer?(default(IPatrolPositionRefreshAtNearestSplinePointToPlayer).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060278BB RID: 161979 RVA: 0x005690CD File Offset: 0x005672CD
		public static Offset<IPatrolPositionRefreshConfig> CreateIPatrolPositionRefreshConfig(FlatBufferBuilder builder, VectorOffset TriggerConditions_typeOffset = default(VectorOffset), VectorOffset TriggerConditionsOffset = default(VectorOffset), Offset<IPatrolPositionRefreshAtNearestSplinePointToPlayer> RefreshOffset = default(Offset<IPatrolPositionRefreshAtNearestSplinePointToPlayer>))
		{
			builder.StartTable(3);
			IPatrolPositionRefreshConfig.AddRefresh(builder, RefreshOffset);
			IPatrolPositionRefreshConfig.AddTriggerConditions(builder, TriggerConditionsOffset);
			IPatrolPositionRefreshConfig.AddTriggerConditionsType(builder, TriggerConditions_typeOffset);
			return IPatrolPositionRefreshConfig.EndIPatrolPositionRefreshConfig(builder);
		}

		// Token: 0x060278BC RID: 161980 RVA: 0x005690F1 File Offset: 0x005672F1
		public static void StartIPatrolPositionRefreshConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060278BD RID: 161981 RVA: 0x005690FA File Offset: 0x005672FA
		public static void AddTriggerConditionsType(FlatBufferBuilder builder, VectorOffset triggerConditionsTypeOffset)
		{
			builder.AddOffset(0, triggerConditionsTypeOffset.Value, 0);
		}

		// Token: 0x060278BE RID: 161982 RVA: 0x0056910C File Offset: 0x0056730C
		public static VectorOffset CreateTriggerConditionsTypeVector(FlatBufferBuilder builder, TPatrolPositionRefreshTrigger[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060278BF RID: 161983 RVA: 0x00569143 File Offset: 0x00567343
		public static VectorOffset CreateTriggerConditionsTypeVectorBlock(FlatBufferBuilder builder, TPatrolPositionRefreshTrigger[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TPatrolPositionRefreshTrigger>(data);
			return builder.EndVector();
		}

		// Token: 0x060278C0 RID: 161984 RVA: 0x0056915D File Offset: 0x0056735D
		public static VectorOffset CreateTriggerConditionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TPatrolPositionRefreshTrigger> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TPatrolPositionRefreshTrigger>(data);
			return builder.EndVector();
		}

		// Token: 0x060278C1 RID: 161985 RVA: 0x0056917B File Offset: 0x0056737B
		public static VectorOffset CreateTriggerConditionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TPatrolPositionRefreshTrigger>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060278C2 RID: 161986 RVA: 0x00569194 File Offset: 0x00567394
		public static void StartTriggerConditionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060278C3 RID: 161987 RVA: 0x0056919F File Offset: 0x0056739F
		public static void AddTriggerConditions(FlatBufferBuilder builder, VectorOffset triggerConditionsOffset)
		{
			builder.AddOffset(1, triggerConditionsOffset.Value, 0);
		}

		// Token: 0x060278C4 RID: 161988 RVA: 0x005691B0 File Offset: 0x005673B0
		public static VectorOffset CreateTriggerConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060278C5 RID: 161989 RVA: 0x005691E7 File Offset: 0x005673E7
		public static VectorOffset CreateTriggerConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060278C6 RID: 161990 RVA: 0x00569201 File Offset: 0x00567401
		public static VectorOffset CreateTriggerConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060278C7 RID: 161991 RVA: 0x0056921F File Offset: 0x0056741F
		public static VectorOffset CreateTriggerConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060278C8 RID: 161992 RVA: 0x00569238 File Offset: 0x00567438
		public static void StartTriggerConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060278C9 RID: 161993 RVA: 0x00569243 File Offset: 0x00567443
		public static void AddRefresh(FlatBufferBuilder builder, Offset<IPatrolPositionRefreshAtNearestSplinePointToPlayer> refreshOffset)
		{
			builder.AddOffset(2, refreshOffset.Value, 0);
		}

		// Token: 0x060278CA RID: 161994 RVA: 0x00569253 File Offset: 0x00567453
		public static Offset<IPatrolPositionRefreshConfig> EndIPatrolPositionRefreshConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPatrolPositionRefreshConfig>(builder.EndTable());
		}

		// Token: 0x060278CB RID: 161995 RVA: 0x00569260 File Offset: 0x00567460
		public IPatrolPositionRefreshConfigT UnPack()
		{
			IPatrolPositionRefreshConfigT patrolPositionRefreshConfigT = new IPatrolPositionRefreshConfigT();
			this.UnPackTo(patrolPositionRefreshConfigT);
			return patrolPositionRefreshConfigT;
		}

		// Token: 0x060278CC RID: 161996 RVA: 0x0056927C File Offset: 0x0056747C
		public void UnPackTo(IPatrolPositionRefreshConfigT _o)
		{
			_o.TriggerConditions = new List<TPatrolPositionRefreshTriggerUnion>();
			for (int i = 0; i < this.TriggerConditionsLength; i++)
			{
				TPatrolPositionRefreshTriggerUnion tpatrolPositionRefreshTriggerUnion = new TPatrolPositionRefreshTriggerUnion();
				tpatrolPositionRefreshTriggerUnion.Type = this.TriggerConditionsType(i);
				TPatrolPositionRefreshTrigger tpatrolPositionRefreshTrigger = this.TriggerConditionsType(i);
				if (tpatrolPositionRefreshTrigger != TPatrolPositionRefreshTrigger.IPatrolPositionRefreshOnEntityAwake)
				{
					if (tpatrolPositionRefreshTrigger == TPatrolPositionRefreshTrigger.IPatrolPositionRefreshOnEntityVisibilityShown)
					{
						tpatrolPositionRefreshTriggerUnion.Value = ((this.TriggerConditions<IPatrolPositionRefreshOnEntityVisibilityShown>(i) != null) ? this.TriggerConditions<IPatrolPositionRefreshOnEntityVisibilityShown>(i).Value.UnPack() : null);
					}
				}
				else
				{
					tpatrolPositionRefreshTriggerUnion.Value = ((this.TriggerConditions<IPatrolPositionRefreshOnEntityAwake>(i) != null) ? this.TriggerConditions<IPatrolPositionRefreshOnEntityAwake>(i).Value.UnPack() : null);
				}
				_o.TriggerConditions.Add(tpatrolPositionRefreshTriggerUnion);
			}
			_o.Refresh = ((this.Refresh != null) ? this.Refresh.Value.UnPack() : null);
		}

		// Token: 0x060278CD RID: 161997 RVA: 0x00569378 File Offset: 0x00567578
		public static Offset<IPatrolPositionRefreshConfig> Pack(FlatBufferBuilder builder, IPatrolPositionRefreshConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPatrolPositionRefreshConfig>);
			}
			VectorOffset triggerConditions_typeOffset = default(VectorOffset);
			if (_o.TriggerConditions != null)
			{
				TPatrolPositionRefreshTrigger[] array = new TPatrolPositionRefreshTrigger[_o.TriggerConditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.TriggerConditions[i].Type;
				}
				triggerConditions_typeOffset = IPatrolPositionRefreshConfig.CreateTriggerConditionsTypeVector(builder, array);
			}
			VectorOffset triggerConditionsOffset = default(VectorOffset);
			if (_o.TriggerConditions != null)
			{
				int[] array2 = new int[_o.TriggerConditions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TPatrolPositionRefreshTriggerUnion.Pack(builder, _o.TriggerConditions[j]);
				}
				triggerConditionsOffset = IPatrolPositionRefreshConfig.CreateTriggerConditionsVector(builder, array2);
			}
			Offset<IPatrolPositionRefreshAtNearestSplinePointToPlayer> refreshOffset = (_o.Refresh == null) ? default(Offset<IPatrolPositionRefreshAtNearestSplinePointToPlayer>) : IPatrolPositionRefreshAtNearestSplinePointToPlayer.Pack(builder, _o.Refresh);
			return IPatrolPositionRefreshConfig.CreateIPatrolPositionRefreshConfig(builder, triggerConditions_typeOffset, triggerConditionsOffset, refreshOffset);
		}

		// Token: 0x0400F83D RID: 63549
		private Table __p;
	}
}
