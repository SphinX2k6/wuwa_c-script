using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Reward
{
	// Token: 0x02004F0E RID: 20238
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class RewardModel : ModelBase
	{
		// Token: 0x06033E35 RID: 212533 RVA: 0x00C2812C File Offset: 0x00C2632C
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

		// Token: 0x06033E36 RID: 212534 RVA: 0x00C281C0 File Offset: 0x00C263C0
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

		// Token: 0x06033E37 RID: 212535 RVA: 0x00C28248 File Offset: 0x00C26448
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

		// Token: 0x17007F38 RID: 32568
		// (get) Token: 0x06033E38 RID: 212536 RVA: 0x00C282C2 File Offset: 0x00C264C2
		public static RewardModel Instance
		{
			get
			{
				return RewardModel._Instance;
			}
		}

		// Token: 0x06033E39 RID: 212537 RVA: 0x00C282C9 File Offset: 0x00C264C9
		public static RewardModel GetOrCreateInstance()
		{
			if (RewardModel._Instance == null)
			{
				RewardModel.CreateInstance();
			}
			return RewardModel._Instance;
		}

		// Token: 0x06033E3A RID: 212538 RVA: 0x00C282DD File Offset: 0x00C264DD
		public static bool CreateInstance()
		{
			if (RewardModel._Instance != null)
			{
				return true;
			}
			RewardModel._Instance = new RewardModel();
			return true;
		}

		// Token: 0x06033E3B RID: 212539 RVA: 0x00C282F3 File Offset: 0x00C264F3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06033E3C RID: 212540 RVA: 0x00C282F5 File Offset: 0x00C264F5
		public static void ResetStaticDefaultValue()
		{
			RewardModel._Instance = null;
		}

		// Token: 0x06033E3D RID: 212541 RVA: 0x00C282FD File Offset: 0x00C264FD
		static RewardModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RewardModel.CreateStaticDefaultValue), new Action(RewardModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401B951 RID: 112977
		private const string CHECK_GROUND_PROFILE_KEY = "RewardModel_CheckGroundHit";

		// Token: 0x0401B952 RID: 112978
		private const string CHECK_WATER_PROFILE_KEY = "RewardModel_CheckWaterHit";

		// Token: 0x0401B953 RID: 112979
		[Nullable(2)]
		private UTraceSphereElement GroundTrace;

		// Token: 0x0401B954 RID: 112980
		[Nullable(2)]
		private UTraceLineElement WaterTrace;

		// Token: 0x0401B955 RID: 112981
		[Nullable(2)]
		private static RewardModel _Instance;
	}
}
