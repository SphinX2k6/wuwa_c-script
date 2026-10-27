using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072C3 RID: 29379
	public class CameraNearClipConfig : IStaticVariableResetter
	{
		// Token: 0x06048124 RID: 295204 RVA: 0x0127AE4D File Offset: 0x0127904D
		static CameraNearClipConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CameraNearClipConfig.CreateStaticDefaultValue), new Action(CameraNearClipConfig.ResetStaticDefaultValue));
		}

		// Token: 0x06048125 RID: 295205 RVA: 0x0127AE6C File Offset: 0x0127906C
		public CameraNearClipConfig(int priority)
		{
			this.Priority = priority;
			this.Id = ++CameraNearClipConfig._instanceId;
		}

		// Token: 0x06048126 RID: 295206 RVA: 0x0127AE8E File Offset: 0x0127908E
		public bool IsValid()
		{
			return true;
		}

		// Token: 0x06048127 RID: 295207 RVA: 0x0127AE91 File Offset: 0x01279091
		public int SetRelativeNearClip(ECameraRelativeNearClipTargetType targetType, float distance)
		{
			this.Type = ECameraNearClipType.Relative;
			this.CameraBaseNearClip = new CameraRelativeNearClipConfig(targetType, distance);
			return this.Id;
		}

		// Token: 0x06048128 RID: 295208 RVA: 0x0127AEAD File Offset: 0x012790AD
		public int SetAbsoluteNearClip(float distance)
		{
			this.Type = ECameraNearClipType.Absolute;
			this.CameraBaseNearClip = new CameraAbsoluteNearClipConfig(distance);
			return this.Id;
		}

		// Token: 0x06048129 RID: 295209 RVA: 0x0127AEC8 File Offset: 0x012790C8
		public static void CreateStaticDefaultValue()
		{
			CameraNearClipConfig._instanceId = 0;
		}

		// Token: 0x0604812A RID: 295210 RVA: 0x0127AED0 File Offset: 0x012790D0
		public static void ResetStaticDefaultValue()
		{
			CameraNearClipConfig._instanceId = 0;
		}

		// Token: 0x04026064 RID: 155748
		private static int _instanceId;

		// Token: 0x04026065 RID: 155749
		public readonly int Id;

		// Token: 0x04026066 RID: 155750
		public bool MarkDelete;

		// Token: 0x04026067 RID: 155751
		public ECameraNearClipType Type;

		// Token: 0x04026068 RID: 155752
		[Nullable(2)]
		public CameraBaseNearClipConfig CameraBaseNearClip;

		// Token: 0x04026069 RID: 155753
		public readonly int Priority;
	}
}
