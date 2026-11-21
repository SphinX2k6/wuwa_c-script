using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Reward
{
	// Token: 0x02003ED7 RID: 16087
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class RewardModel : ModelBase
	{
		// Token: 0x06028CA0 RID: 167072 RVA: 0x00B7171C File Offset: 0x00B6F91C
		private void InitTraceInfo()
		{
			this.GroundTrace = new UTraceSphereElement();
			this.GroundTrace.WorldContextObject = GlobalData.World;
			this.GroundTrace.bIsSingle = true;
			this.GroundTrace.bIgnoreSelf = true;
			this.GroundTrace.AddObjectTypeQuery(KuroObjectTypeQuery.WorldStatic);
			this.WaterTrace = new UTraceLineElement();
			this.WaterTrace.WorldContextObject = GlobalData.World;
			this.WaterTrace.bIsSingle = true;
			this.WaterTrace.bIgnoreSelf = true;
			this.WaterTrace.SetTraceTypeQuery(KuroTraceTypeQuery.Water);
		}

		// Token: 0x06028CA1 RID: 167073 RVA: 0x00B717B0 File Offset: 0x00B6F9B0
		public bool CheckGroundHit(IVector centerLocation, float radius, float zOffset)
		{
			if (this.GroundTrace == null)
			{
				this.InitTraceInfo();
			}
			TraceElementCommon.Instance.SetStartLocation(this.GroundTrace, centerLocation);
			this.GroundTrace.SetEndLocation(centerLocation.X, centerLocation.Y, centerLocation.Z + (double)zOffset);
			this.GroundTrace.Radius = radius;
			bool result = false;
			if (TraceElementCommon.Instance.SphereTrace(this.GroundTrace, "RewardModel_CheckGroundHit") && this.GroundTrace.HitResult.bBlockingHit)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06028CA2 RID: 167074 RVA: 0x00B71838 File Offset: 0x00B6FA38
		public bool CheckWaterHit(IVector preFrameLocation, IVector centerLocation, float zOffset, float radius)
		{
			if (this.WaterTrace == null)
			{
				this.InitTraceInfo();
			}
			TraceElementCommon.Instance.SetStartLocation(this.WaterTrace, preFrameLocation);
			this.WaterTrace.SetEndLocation(centerLocation.X, centerLocation.Y, centerLocation.Z - (double)zOffset);
			bool result = false;
			if (TraceElementCommon.Instance.LineTrace(this.WaterTrace, "RewardModel_CheckWaterHit") && this.WaterTrace.HitResult.bBlockingHit)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x170052E8 RID: 21224
		// (get) Token: 0x06028CA3 RID: 167075 RVA: 0x00B718B2 File Offset: 0x00B6FAB2
		public static RewardModel Instance
		{
			get
			{
				return RewardModel._Instance;
			}
		}

		// Token: 0x06028CA4 RID: 167076 RVA: 0x00B718B9 File Offset: 0x00B6FAB9
		public static RewardModel GetOrCreateInstance()
		{
			if (RewardModel._Instance == null)
			{
				RewardModel.CreateInstance();
			}
			return RewardModel._Instance;
		}

		// Token: 0x06028CA5 RID: 167077 RVA: 0x00B718CD File Offset: 0x00B6FACD
		public static bool CreateInstance()
		{
			if (RewardModel._Instance != null)
			{
				return true;
			}
			RewardModel._Instance = new RewardModel();
			return true;
		}

		// Token: 0x06028CA6 RID: 167078 RVA: 0x00B718E3 File Offset: 0x00B6FAE3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06028CA7 RID: 167079 RVA: 0x00B718E5 File Offset: 0x00B6FAE5
		public static void ResetStaticDefaultValue()
		{
			RewardModel._Instance = null;
		}

		// Token: 0x06028CA8 RID: 167080 RVA: 0x00B718ED File Offset: 0x00B6FAED
		static RewardModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RewardModel.CreateStaticDefaultValue), new Action(RewardModel.ResetStaticDefaultValue));
		}

		// Token: 0x04016324 RID: 90916
		private const string CHECK_GROUND_PROFILE_KEY = "RewardModel_CheckGroundHit";

		// Token: 0x04016325 RID: 90917
		private const string CHECK_WATER_PROFILE_KEY = "RewardModel_CheckWaterHit";

		// Token: 0x04016326 RID: 90918
		[Nullable(2)]
		private UTraceSphereElement GroundTrace;

		// Token: 0x04016327 RID: 90919
		[Nullable(2)]
		private UTraceLineElement WaterTrace;

		// Token: 0x04016328 RID: 90920
		[Nullable(2)]
		private static RewardModel _Instance;
	}
}
