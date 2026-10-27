using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200527F RID: 21119
	public struct IFlowerPollutionComponent : IFlatbufferObject
	{
		// Token: 0x17009AC5 RID: 39621
		// (get) Token: 0x06022613 RID: 140819 RVA: 0x004C3FBF File Offset: 0x004C21BF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022614 RID: 140820 RVA: 0x004C3FCC File Offset: 0x004C21CC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022615 RID: 140821 RVA: 0x004C3FD4 File Offset: 0x004C21D4
		public static IFlowerPollutionComponent GetRootAsIFlowerPollutionComponent(ByteBuffer _bb)
		{
			return IFlowerPollutionComponent.GetRootAsIFlowerPollutionComponent(_bb, default(IFlowerPollutionComponent));
		}

		// Token: 0x06022616 RID: 140822 RVA: 0x004C3FF0 File Offset: 0x004C21F0
		public static IFlowerPollutionComponent GetRootAsIFlowerPollutionComponent(ByteBuffer _bb, IFlowerPollutionComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022617 RID: 140823 RVA: 0x004C400D File Offset: 0x004C220D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022618 RID: 140824 RVA: 0x004C401C File Offset: 0x004C221C
		public IFlowerPollutionComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009AC6 RID: 39622
		// (get) Token: 0x06022619 RID: 140825 RVA: 0x004C402C File Offset: 0x004C222C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009AC7 RID: 39623
		// (get) Token: 0x0602261A RID: 140826 RVA: 0x004C406C File Offset: 0x004C226C
		public IFlowerPollutionSplineConfig? SplineConfigs
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IFlowerPollutionSplineConfig?(default(IFlowerPollutionSplineConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009AC8 RID: 39624
		// (get) Token: 0x0602261B RID: 140827 RVA: 0x004C40CC File Offset: 0x004C22CC
		public IFlowerPollutionPointLightConfig? PointLightConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IFlowerPollutionPointLightConfig?(default(IFlowerPollutionPointLightConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602261C RID: 140828 RVA: 0x004C412C File Offset: 0x004C232C
		public int ObstacleEntityIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009AC9 RID: 39625
		// (get) Token: 0x0602261D RID: 140829 RVA: 0x004C416C File Offset: 0x004C236C
		public int ObstacleEntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602261E RID: 140830 RVA: 0x004C4198 File Offset: 0x004C2398
		public Span<int> GetObstacleEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0602261F RID: 140831 RVA: 0x004C41A8 File Offset: 0x004C23A8
		public int[] GetObstacleEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x06022620 RID: 140832 RVA: 0x004C41B8 File Offset: 0x004C23B8
		public int PollutionSourceEntityIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009ACA RID: 39626
		// (get) Token: 0x06022621 RID: 140833 RVA: 0x004C41F8 File Offset: 0x004C23F8
		public int PollutionSourceEntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06022622 RID: 140834 RVA: 0x004C4224 File Offset: 0x004C2424
		public Span<int> GetPollutionSourceEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06022623 RID: 140835 RVA: 0x004C4234 File Offset: 0x004C2434
		public int[] GetPollutionSourceEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(12);
		}

		// Token: 0x06022624 RID: 140836 RVA: 0x004C4244 File Offset: 0x004C2444
		public IActionInfo? OnEnterPollutionRangeActions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009ACB RID: 39627
		// (get) Token: 0x06022625 RID: 140837 RVA: 0x004C42A8 File Offset: 0x004C24A8
		public int OnEnterPollutionRangeActionsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06022626 RID: 140838 RVA: 0x004C42D4 File Offset: 0x004C24D4
		public IActionInfo? OnLeavePollutionRangeActions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009ACC RID: 39628
		// (get) Token: 0x06022627 RID: 140839 RVA: 0x004C4338 File Offset: 0x004C2538
		public int OnLeavePollutionRangeActionsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009ACD RID: 39629
		// (get) Token: 0x06022628 RID: 140840 RVA: 0x004C4364 File Offset: 0x004C2564
		public string BakeData
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022629 RID: 140841 RVA: 0x004C439C File Offset: 0x004C259C
		public Span<byte> GetBakeDataBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0602262A RID: 140842 RVA: 0x004C43AC File Offset: 0x004C25AC
		public byte[] GetBakeDataArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x17009ACE RID: 39630
		// (get) Token: 0x0602262B RID: 140843 RVA: 0x004C43BC File Offset: 0x004C25BC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602262C RID: 140844 RVA: 0x004C43FC File Offset: 0x004C25FC
		public static Offset<IFlowerPollutionComponent> CreateIFlowerPollutionComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IFlowerPollutionSplineConfig> SplineConfigsOffset = default(Offset<IFlowerPollutionSplineConfig>), Offset<IFlowerPollutionPointLightConfig> PointLightConfigOffset = default(Offset<IFlowerPollutionPointLightConfig>), VectorOffset ObstacleEntityIdsOffset = default(VectorOffset), VectorOffset PollutionSourceEntityIdsOffset = default(VectorOffset), VectorOffset OnEnterPollutionRangeActionsOffset = default(VectorOffset), VectorOffset OnLeavePollutionRangeActionsOffset = default(VectorOffset), StringOffset BakeDataOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(9);
			IFlowerPollutionComponent.AddBakeData(builder, BakeDataOffset);
			IFlowerPollutionComponent.AddOnLeavePollutionRangeActions(builder, OnLeavePollutionRangeActionsOffset);
			IFlowerPollutionComponent.AddOnEnterPollutionRangeActions(builder, OnEnterPollutionRangeActionsOffset);
			IFlowerPollutionComponent.AddPollutionSourceEntityIds(builder, PollutionSourceEntityIdsOffset);
			IFlowerPollutionComponent.AddObstacleEntityIds(builder, ObstacleEntityIdsOffset);
			IFlowerPollutionComponent.AddPointLightConfig(builder, PointLightConfigOffset);
			IFlowerPollutionComponent.AddSplineConfigs(builder, SplineConfigsOffset);
			IFlowerPollutionComponent.AddNullMask(builder, NullMask);
			IFlowerPollutionComponent.AddDisabled(builder, Disabled);
			return IFlowerPollutionComponent.EndIFlowerPollutionComponent(builder);
		}

		// Token: 0x0602262D RID: 140845 RVA: 0x004C445C File Offset: 0x004C265C
		public static void StartIFlowerPollutionComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0602262E RID: 140846 RVA: 0x004C4466 File Offset: 0x004C2666
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602262F RID: 140847 RVA: 0x004C4471 File Offset: 0x004C2671
		public static void AddSplineConfigs(FlatBufferBuilder builder, Offset<IFlowerPollutionSplineConfig> splineConfigsOffset)
		{
			builder.AddOffset(1, splineConfigsOffset.Value, 0);
		}

		// Token: 0x06022630 RID: 140848 RVA: 0x004C4481 File Offset: 0x004C2681
		public static void AddPointLightConfig(FlatBufferBuilder builder, Offset<IFlowerPollutionPointLightConfig> pointLightConfigOffset)
		{
			builder.AddOffset(2, pointLightConfigOffset.Value, 0);
		}

		// Token: 0x06022631 RID: 140849 RVA: 0x004C4491 File Offset: 0x004C2691
		public static void AddObstacleEntityIds(FlatBufferBuilder builder, VectorOffset obstacleEntityIdsOffset)
		{
			builder.AddOffset(3, obstacleEntityIdsOffset.Value, 0);
		}

		// Token: 0x06022632 RID: 140850 RVA: 0x004C44A4 File Offset: 0x004C26A4
		public static VectorOffset CreateObstacleEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06022633 RID: 140851 RVA: 0x004C44DB File Offset: 0x004C26DB
		public static VectorOffset CreateObstacleEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06022634 RID: 140852 RVA: 0x004C44F5 File Offset: 0x004C26F5
		public static VectorOffset CreateObstacleEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06022635 RID: 140853 RVA: 0x004C4513 File Offset: 0x004C2713
		public static VectorOffset CreateObstacleEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022636 RID: 140854 RVA: 0x004C452C File Offset: 0x004C272C
		public static void StartObstacleEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022637 RID: 140855 RVA: 0x004C4537 File Offset: 0x004C2737
		public static void AddPollutionSourceEntityIds(FlatBufferBuilder builder, VectorOffset pollutionSourceEntityIdsOffset)
		{
			builder.AddOffset(4, pollutionSourceEntityIdsOffset.Value, 0);
		}

		// Token: 0x06022638 RID: 140856 RVA: 0x004C4548 File Offset: 0x004C2748
		public static VectorOffset CreatePollutionSourceEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06022639 RID: 140857 RVA: 0x004C457F File Offset: 0x004C277F
		public static VectorOffset CreatePollutionSourceEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602263A RID: 140858 RVA: 0x004C4599 File Offset: 0x004C2799
		public static VectorOffset CreatePollutionSourceEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602263B RID: 140859 RVA: 0x004C45B7 File Offset: 0x004C27B7
		public static VectorOffset CreatePollutionSourceEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602263C RID: 140860 RVA: 0x004C45D0 File Offset: 0x004C27D0
		public static void StartPollutionSourceEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602263D RID: 140861 RVA: 0x004C45DB File Offset: 0x004C27DB
		public static void AddOnEnterPollutionRangeActions(FlatBufferBuilder builder, VectorOffset onEnterPollutionRangeActionsOffset)
		{
			builder.AddOffset(5, onEnterPollutionRangeActionsOffset.Value, 0);
		}

		// Token: 0x0602263E RID: 140862 RVA: 0x004C45EC File Offset: 0x004C27EC
		public static VectorOffset CreateOnEnterPollutionRangeActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602263F RID: 140863 RVA: 0x004C462C File Offset: 0x004C282C
		public static VectorOffset CreateOnEnterPollutionRangeActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022640 RID: 140864 RVA: 0x004C4646 File Offset: 0x004C2846
		public static VectorOffset CreateOnEnterPollutionRangeActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022641 RID: 140865 RVA: 0x004C4664 File Offset: 0x004C2864
		public static VectorOffset CreateOnEnterPollutionRangeActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022642 RID: 140866 RVA: 0x004C467D File Offset: 0x004C287D
		public static void StartOnEnterPollutionRangeActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022643 RID: 140867 RVA: 0x004C4688 File Offset: 0x004C2888
		public static void AddOnLeavePollutionRangeActions(FlatBufferBuilder builder, VectorOffset onLeavePollutionRangeActionsOffset)
		{
			builder.AddOffset(6, onLeavePollutionRangeActionsOffset.Value, 0);
		}

		// Token: 0x06022644 RID: 140868 RVA: 0x004C4698 File Offset: 0x004C2898
		public static VectorOffset CreateOnLeavePollutionRangeActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022645 RID: 140869 RVA: 0x004C46D8 File Offset: 0x004C28D8
		public static VectorOffset CreateOnLeavePollutionRangeActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022646 RID: 140870 RVA: 0x004C46F2 File Offset: 0x004C28F2
		public static VectorOffset CreateOnLeavePollutionRangeActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022647 RID: 140871 RVA: 0x004C4710 File Offset: 0x004C2910
		public static VectorOffset CreateOnLeavePollutionRangeActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022648 RID: 140872 RVA: 0x004C4729 File Offset: 0x004C2929
		public static void StartOnLeavePollutionRangeActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022649 RID: 140873 RVA: 0x004C4734 File Offset: 0x004C2934
		public static void AddBakeData(FlatBufferBuilder builder, StringOffset bakeDataOffset)
		{
			builder.AddOffset(7, bakeDataOffset.Value, 0);
		}

		// Token: 0x0602264A RID: 140874 RVA: 0x004C4744 File Offset: 0x004C2944
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0602264B RID: 140875 RVA: 0x004C474F File Offset: 0x004C294F
		public static Offset<IFlowerPollutionComponent> EndIFlowerPollutionComponent(FlatBufferBuilder builder)
		{
			return new Offset<IFlowerPollutionComponent>(builder.EndTable());
		}

		// Token: 0x0602264C RID: 140876 RVA: 0x004C475C File Offset: 0x004C295C
		public IFlowerPollutionComponentT UnPack()
		{
			IFlowerPollutionComponentT flowerPollutionComponentT = new IFlowerPollutionComponentT();
			this.UnPackTo(flowerPollutionComponentT);
			return flowerPollutionComponentT;
		}

		// Token: 0x0602264D RID: 140877 RVA: 0x004C4778 File Offset: 0x004C2978
		public void UnPackTo(IFlowerPollutionComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.SplineConfigs = ((this.SplineConfigs != null) ? this.SplineConfigs.Value.UnPack() : null);
			_o.PointLightConfig = ((this.PointLightConfig != null) ? this.PointLightConfig.Value.UnPack() : null);
			_o.ObstacleEntityIds = new List<int>();
			for (int i = 0; i < this.ObstacleEntityIdsLength; i++)
			{
				_o.ObstacleEntityIds.Add(this.ObstacleEntityIds(i));
			}
			_o.PollutionSourceEntityIds = new List<int>();
			for (int j = 0; j < this.PollutionSourceEntityIdsLength; j++)
			{
				_o.PollutionSourceEntityIds.Add(this.PollutionSourceEntityIds(j));
			}
			_o.OnEnterPollutionRangeActions = new List<IActionInfoT>();
			for (int k = 0; k < this.OnEnterPollutionRangeActionsLength; k++)
			{
				_o.OnEnterPollutionRangeActions.Add((this.OnEnterPollutionRangeActions(k) != null) ? this.OnEnterPollutionRangeActions(k).Value.UnPack() : null);
			}
			_o.OnLeavePollutionRangeActions = new List<IActionInfoT>();
			for (int l = 0; l < this.OnLeavePollutionRangeActionsLength; l++)
			{
				_o.OnLeavePollutionRangeActions.Add((this.OnLeavePollutionRangeActions(l) != null) ? this.OnLeavePollutionRangeActions(l).Value.UnPack() : null);
			}
			_o.BakeData = this.BakeData;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602264E RID: 140878 RVA: 0x004C4924 File Offset: 0x004C2B24
		public static Offset<IFlowerPollutionComponent> Pack(FlatBufferBuilder builder, IFlowerPollutionComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowerPollutionComponent>);
			}
			Offset<IFlowerPollutionSplineConfig> splineConfigsOffset = (_o.SplineConfigs == null) ? default(Offset<IFlowerPollutionSplineConfig>) : IFlowerPollutionSplineConfig.Pack(builder, _o.SplineConfigs);
			Offset<IFlowerPollutionPointLightConfig> pointLightConfigOffset = (_o.PointLightConfig == null) ? default(Offset<IFlowerPollutionPointLightConfig>) : IFlowerPollutionPointLightConfig.Pack(builder, _o.PointLightConfig);
			VectorOffset obstacleEntityIdsOffset = default(VectorOffset);
			if (_o.ObstacleEntityIds != null)
			{
				int[] data = _o.ObstacleEntityIds.ToArray();
				obstacleEntityIdsOffset = IFlowerPollutionComponent.CreateObstacleEntityIdsVector(builder, data);
			}
			VectorOffset pollutionSourceEntityIdsOffset = default(VectorOffset);
			if (_o.PollutionSourceEntityIds != null)
			{
				int[] data2 = _o.PollutionSourceEntityIds.ToArray();
				pollutionSourceEntityIdsOffset = IFlowerPollutionComponent.CreatePollutionSourceEntityIdsVector(builder, data2);
			}
			VectorOffset onEnterPollutionRangeActionsOffset = default(VectorOffset);
			if (_o.OnEnterPollutionRangeActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.OnEnterPollutionRangeActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.OnEnterPollutionRangeActions[i]);
				}
				onEnterPollutionRangeActionsOffset = IFlowerPollutionComponent.CreateOnEnterPollutionRangeActionsVector(builder, array);
			}
			VectorOffset onLeavePollutionRangeActionsOffset = default(VectorOffset);
			if (_o.OnLeavePollutionRangeActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.OnLeavePollutionRangeActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.OnLeavePollutionRangeActions[j]);
				}
				onLeavePollutionRangeActionsOffset = IFlowerPollutionComponent.CreateOnLeavePollutionRangeActionsVector(builder, array2);
			}
			StringOffset bakeDataOffset = (_o.BakeData == null) ? default(StringOffset) : builder.CreateString(_o.BakeData);
			return IFlowerPollutionComponent.CreateIFlowerPollutionComponent(builder, _o.Disabled, splineConfigsOffset, pointLightConfigOffset, obstacleEntityIdsOffset, pollutionSourceEntityIdsOffset, onEnterPollutionRangeActionsOffset, onLeavePollutionRangeActionsOffset, bakeDataOffset, _o.NullMask);
		}

		// Token: 0x0400E3DF RID: 58335
		private Table __p;
	}
}
