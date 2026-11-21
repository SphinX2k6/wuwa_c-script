using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057E7 RID: 22503
	public struct IFlowerPollutionComponent : IFlatbufferObject
	{
		// Token: 0x1700A2C3 RID: 41667
		// (get) Token: 0x060245AD RID: 148909 RVA: 0x004FEB2F File Offset: 0x004FCD2F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060245AE RID: 148910 RVA: 0x004FEB3C File Offset: 0x004FCD3C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060245AF RID: 148911 RVA: 0x004FEB44 File Offset: 0x004FCD44
		public static IFlowerPollutionComponent GetRootAsIFlowerPollutionComponent(ByteBuffer _bb)
		{
			return IFlowerPollutionComponent.GetRootAsIFlowerPollutionComponent(_bb, default(IFlowerPollutionComponent));
		}

		// Token: 0x060245B0 RID: 148912 RVA: 0x004FEB60 File Offset: 0x004FCD60
		public static IFlowerPollutionComponent GetRootAsIFlowerPollutionComponent(ByteBuffer _bb, IFlowerPollutionComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060245B1 RID: 148913 RVA: 0x004FEB7D File Offset: 0x004FCD7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060245B2 RID: 148914 RVA: 0x004FEB8C File Offset: 0x004FCD8C
		public IFlowerPollutionComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A2C4 RID: 41668
		// (get) Token: 0x060245B3 RID: 148915 RVA: 0x004FEB9C File Offset: 0x004FCD9C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A2C5 RID: 41669
		// (get) Token: 0x060245B4 RID: 148916 RVA: 0x004FEBDC File Offset: 0x004FCDDC
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

		// Token: 0x1700A2C6 RID: 41670
		// (get) Token: 0x060245B5 RID: 148917 RVA: 0x004FEC3C File Offset: 0x004FCE3C
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

		// Token: 0x060245B6 RID: 148918 RVA: 0x004FEC9C File Offset: 0x004FCE9C
		public int ObstacleEntityIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A2C7 RID: 41671
		// (get) Token: 0x060245B7 RID: 148919 RVA: 0x004FECDC File Offset: 0x004FCEDC
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

		// Token: 0x060245B8 RID: 148920 RVA: 0x004FED08 File Offset: 0x004FCF08
		public Span<int> GetObstacleEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060245B9 RID: 148921 RVA: 0x004FED18 File Offset: 0x004FCF18
		public int[] GetObstacleEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x060245BA RID: 148922 RVA: 0x004FED28 File Offset: 0x004FCF28
		public int PollutionSourceEntityIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A2C8 RID: 41672
		// (get) Token: 0x060245BB RID: 148923 RVA: 0x004FED68 File Offset: 0x004FCF68
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

		// Token: 0x060245BC RID: 148924 RVA: 0x004FED94 File Offset: 0x004FCF94
		public Span<int> GetPollutionSourceEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x060245BD RID: 148925 RVA: 0x004FEDA4 File Offset: 0x004FCFA4
		public int[] GetPollutionSourceEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(12);
		}

		// Token: 0x060245BE RID: 148926 RVA: 0x004FEDB4 File Offset: 0x004FCFB4
		public IActionInfo? OnEnterPollutionRangeActions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A2C9 RID: 41673
		// (get) Token: 0x060245BF RID: 148927 RVA: 0x004FEE18 File Offset: 0x004FD018
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

		// Token: 0x060245C0 RID: 148928 RVA: 0x004FEE44 File Offset: 0x004FD044
		public IActionInfo? OnLeavePollutionRangeActions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A2CA RID: 41674
		// (get) Token: 0x060245C1 RID: 148929 RVA: 0x004FEEA8 File Offset: 0x004FD0A8
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

		// Token: 0x1700A2CB RID: 41675
		// (get) Token: 0x060245C2 RID: 148930 RVA: 0x004FEED4 File Offset: 0x004FD0D4
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

		// Token: 0x060245C3 RID: 148931 RVA: 0x004FEF0C File Offset: 0x004FD10C
		public Span<byte> GetBakeDataBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060245C4 RID: 148932 RVA: 0x004FEF1C File Offset: 0x004FD11C
		public byte[] GetBakeDataArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700A2CC RID: 41676
		// (get) Token: 0x060245C5 RID: 148933 RVA: 0x004FEF2C File Offset: 0x004FD12C
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

		// Token: 0x060245C6 RID: 148934 RVA: 0x004FEF6C File Offset: 0x004FD16C
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

		// Token: 0x060245C7 RID: 148935 RVA: 0x004FEFCC File Offset: 0x004FD1CC
		public static void StartIFlowerPollutionComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x060245C8 RID: 148936 RVA: 0x004FEFD6 File Offset: 0x004FD1D6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060245C9 RID: 148937 RVA: 0x004FEFE1 File Offset: 0x004FD1E1
		public static void AddSplineConfigs(FlatBufferBuilder builder, Offset<IFlowerPollutionSplineConfig> splineConfigsOffset)
		{
			builder.AddOffset(1, splineConfigsOffset.Value, 0);
		}

		// Token: 0x060245CA RID: 148938 RVA: 0x004FEFF1 File Offset: 0x004FD1F1
		public static void AddPointLightConfig(FlatBufferBuilder builder, Offset<IFlowerPollutionPointLightConfig> pointLightConfigOffset)
		{
			builder.AddOffset(2, pointLightConfigOffset.Value, 0);
		}

		// Token: 0x060245CB RID: 148939 RVA: 0x004FF001 File Offset: 0x004FD201
		public static void AddObstacleEntityIds(FlatBufferBuilder builder, VectorOffset obstacleEntityIdsOffset)
		{
			builder.AddOffset(3, obstacleEntityIdsOffset.Value, 0);
		}

		// Token: 0x060245CC RID: 148940 RVA: 0x004FF014 File Offset: 0x004FD214
		public static VectorOffset CreateObstacleEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060245CD RID: 148941 RVA: 0x004FF04B File Offset: 0x004FD24B
		public static VectorOffset CreateObstacleEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060245CE RID: 148942 RVA: 0x004FF065 File Offset: 0x004FD265
		public static VectorOffset CreateObstacleEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060245CF RID: 148943 RVA: 0x004FF083 File Offset: 0x004FD283
		public static VectorOffset CreateObstacleEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060245D0 RID: 148944 RVA: 0x004FF09C File Offset: 0x004FD29C
		public static void StartObstacleEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060245D1 RID: 148945 RVA: 0x004FF0A7 File Offset: 0x004FD2A7
		public static void AddPollutionSourceEntityIds(FlatBufferBuilder builder, VectorOffset pollutionSourceEntityIdsOffset)
		{
			builder.AddOffset(4, pollutionSourceEntityIdsOffset.Value, 0);
		}

		// Token: 0x060245D2 RID: 148946 RVA: 0x004FF0B8 File Offset: 0x004FD2B8
		public static VectorOffset CreatePollutionSourceEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060245D3 RID: 148947 RVA: 0x004FF0EF File Offset: 0x004FD2EF
		public static VectorOffset CreatePollutionSourceEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060245D4 RID: 148948 RVA: 0x004FF109 File Offset: 0x004FD309
		public static VectorOffset CreatePollutionSourceEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060245D5 RID: 148949 RVA: 0x004FF127 File Offset: 0x004FD327
		public static VectorOffset CreatePollutionSourceEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060245D6 RID: 148950 RVA: 0x004FF140 File Offset: 0x004FD340
		public static void StartPollutionSourceEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060245D7 RID: 148951 RVA: 0x004FF14B File Offset: 0x004FD34B
		public static void AddOnEnterPollutionRangeActions(FlatBufferBuilder builder, VectorOffset onEnterPollutionRangeActionsOffset)
		{
			builder.AddOffset(5, onEnterPollutionRangeActionsOffset.Value, 0);
		}

		// Token: 0x060245D8 RID: 148952 RVA: 0x004FF15C File Offset: 0x004FD35C
		public static VectorOffset CreateOnEnterPollutionRangeActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060245D9 RID: 148953 RVA: 0x004FF19C File Offset: 0x004FD39C
		public static VectorOffset CreateOnEnterPollutionRangeActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060245DA RID: 148954 RVA: 0x004FF1B6 File Offset: 0x004FD3B6
		public static VectorOffset CreateOnEnterPollutionRangeActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060245DB RID: 148955 RVA: 0x004FF1D4 File Offset: 0x004FD3D4
		public static VectorOffset CreateOnEnterPollutionRangeActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060245DC RID: 148956 RVA: 0x004FF1ED File Offset: 0x004FD3ED
		public static void StartOnEnterPollutionRangeActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060245DD RID: 148957 RVA: 0x004FF1F8 File Offset: 0x004FD3F8
		public static void AddOnLeavePollutionRangeActions(FlatBufferBuilder builder, VectorOffset onLeavePollutionRangeActionsOffset)
		{
			builder.AddOffset(6, onLeavePollutionRangeActionsOffset.Value, 0);
		}

		// Token: 0x060245DE RID: 148958 RVA: 0x004FF208 File Offset: 0x004FD408
		public static VectorOffset CreateOnLeavePollutionRangeActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060245DF RID: 148959 RVA: 0x004FF248 File Offset: 0x004FD448
		public static VectorOffset CreateOnLeavePollutionRangeActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060245E0 RID: 148960 RVA: 0x004FF262 File Offset: 0x004FD462
		public static VectorOffset CreateOnLeavePollutionRangeActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060245E1 RID: 148961 RVA: 0x004FF280 File Offset: 0x004FD480
		public static VectorOffset CreateOnLeavePollutionRangeActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060245E2 RID: 148962 RVA: 0x004FF299 File Offset: 0x004FD499
		public static void StartOnLeavePollutionRangeActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060245E3 RID: 148963 RVA: 0x004FF2A4 File Offset: 0x004FD4A4
		public static void AddBakeData(FlatBufferBuilder builder, StringOffset bakeDataOffset)
		{
			builder.AddOffset(7, bakeDataOffset.Value, 0);
		}

		// Token: 0x060245E4 RID: 148964 RVA: 0x004FF2B4 File Offset: 0x004FD4B4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x060245E5 RID: 148965 RVA: 0x004FF2BF File Offset: 0x004FD4BF
		public static Offset<IFlowerPollutionComponent> EndIFlowerPollutionComponent(FlatBufferBuilder builder)
		{
			return new Offset<IFlowerPollutionComponent>(builder.EndTable());
		}

		// Token: 0x060245E6 RID: 148966 RVA: 0x004FF2CC File Offset: 0x004FD4CC
		public IFlowerPollutionComponentT UnPack()
		{
			IFlowerPollutionComponentT flowerPollutionComponentT = new IFlowerPollutionComponentT();
			this.UnPackTo(flowerPollutionComponentT);
			return flowerPollutionComponentT;
		}

		// Token: 0x060245E7 RID: 148967 RVA: 0x004FF2E8 File Offset: 0x004FD4E8
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

		// Token: 0x060245E8 RID: 148968 RVA: 0x004FF494 File Offset: 0x004FD694
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

		// Token: 0x0400EFE6 RID: 61414
		private Table __p;
	}
}
