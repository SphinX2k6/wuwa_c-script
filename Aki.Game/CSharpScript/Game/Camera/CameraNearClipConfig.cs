using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006445 RID: 25669
	public class CameraNearClipConfig : IStaticVariableResetter
	{
		// Token: 0x0603E518 RID: 255256 RVA: 0x0121D1E5 File Offset: 0x0121B3E5
		static CameraNearClipConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CameraNearClipConfig.CreateStaticDefaultValue), new Action(CameraNearClipConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0603E519 RID: 255257 RVA: 0x0121D204 File Offset: 0x0121B404
		public CameraNearClipConfig(int priority)
		{
			this.Priority = priority;
			this.Id = ++CameraNearClipConfig._instanceId;
		}

		// Token: 0x0603E51A RID: 255258 RVA: 0x0121D226 File Offset: 0x0121B426
		public bool IsValid()
		{
			return true;
		}

		// Token: 0x0603E51B RID: 255259 RVA: 0x0121D229 File Offset: 0x0121B429
		public int SetRelativeNearClip(ECameraRelativeNearClipTargetType targetType, float distance)
		{
			this.Type = ECameraNearClipType.Relative;
			this.CameraBaseNearClip = new CameraRelativeNearClipConfig(targetType, distance);
			return this.Id;
		}

		// Token: 0x0603E51C RID: 255260 RVA: 0x0121D245 File Offset: 0x0121B445
		public int SetAbsoluteNearClip(float distance)
		{
			this.Type = ECameraNearClipType.Absolute;
			this.CameraBaseNearClip = new CameraAbsoluteNearClipConfig(distance);
			return this.Id;
		}

		// Token: 0x0603E51D RID: 255261 RVA: 0x0121D260 File Offset: 0x0121B460
		public static void CreateStaticDefaultValue()
		{
			CameraNearClipConfig._instanceId = 0;
		}

		// Token: 0x0603E51E RID: 255262 RVA: 0x0121D268 File Offset: 0x0121B468
		public static void ResetStaticDefaultValue()
		{
			CameraNearClipConfig._instanceId = 0;
		}

		// Token: 0x04021344 RID: 136004
		private static int _instanceId;

		// Token: 0x04021345 RID: 136005
		public readonly int Id;

		// Token: 0x04021346 RID: 136006
		public bool MarkDelete;

		// Token: 0x04021347 RID: 136007
		public ECameraNearClipType Type;

		// Token: 0x04021348 RID: 136008
		[Nullable(2)]
		public CameraBaseNearClipConfig CameraBaseNearClip;

		// Token: 0x04021349 RID: 136009
		public readonly int Priority;
	}
}
