using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02005E92 RID: 24210
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleVolumeInfo
	{
		// Token: 0x0603D96F RID: 252271 RVA: 0x00EDE60B File Offset: 0x00EDC80B
		public RoleVolumeInfo(int roleId, int entityId)
		{
			this.RoleId = roleId;
			this.EntityId = entityId;
			this.TimeValue = Time.Instance.Now;
		}

		// Token: 0x0603D970 RID: 252272 RVA: 0x00EDE647 File Offset: 0x00EDC847
		public double GetDistSquared()
		{
			return this.DistSquared;
		}

		// Token: 0x0603D971 RID: 252273 RVA: 0x00EDE650 File Offset: 0x00EDC850
		public void UpdateDistSquared(double value)
		{
			this.DistSquared = Math.Min(value, RoleAudioVolumeInfo.MaxDistanceSquared);
			if (Math.Abs(this.DistSquared - RoleAudioVolumeInfo.MaxDistanceSquared) < 0.0001)
			{
				this.Priority = EEventVolumePriority.Mute;
				return;
			}
			this.Priority = ((this.DistSquared < RoleAudioVolumeInfo.SplitDistanceSquared) ? EEventVolumePriority.Top : EEventVolumePriority.Second);
		}

		// Token: 0x0603D972 RID: 252274 RVA: 0x00EDE6A9 File Offset: 0x00EDC8A9
		public void AddEvent(int handle, EventVolumeInfo info)
		{
			this.EventList[handle] = info;
			info.OnChangeVolume(this.Volume, this);
		}

		// Token: 0x0603D973 RID: 252275 RVA: 0x00EDE6C5 File Offset: 0x00EDC8C5
		public void RemoveEvent(int handle)
		{
			this.EventList.Remove(handle);
		}

		// Token: 0x0603D974 RID: 252276 RVA: 0x00EDE6D4 File Offset: 0x00EDC8D4
		public void SetPlayEvent(bool result)
		{
			if (result)
			{
				this.TimeValue = Time.Instance.Now;
			}
			this.IsCurrentRole = result;
			this.ChangeVolume((result > false) ? 1 : 0);
		}

		// Token: 0x0603D975 RID: 252277 RVA: 0x00EDE6FA File Offset: 0x00EDC8FA
		public bool Empty()
		{
			return this.EventList.Count == 0;
		}

		// Token: 0x0603D976 RID: 252278 RVA: 0x00EDE70C File Offset: 0x00EDC90C
		private void ChangeVolume(int volume)
		{
			this.Volume = volume;
			foreach (KeyValuePair<int, EventVolumeInfo> keyValuePair in this.EventList)
			{
				keyValuePair.Value.OnChangeVolume(volume, this);
			}
		}

		// Token: 0x0603D977 RID: 252279 RVA: 0x00EDE770 File Offset: 0x00EDC970
		public static int Compare(RoleVolumeInfo a, RoleVolumeInfo b)
		{
			if (a.Priority == b.Priority)
			{
				EEventVolumePriority priority = a.Priority;
				if (priority != EEventVolumePriority.Second)
				{
					if (priority == EEventVolumePriority.Top)
					{
						double num = b.TimeValue - a.TimeValue;
						if (num == 0.0)
						{
							num -= 1.0;
						}
						return Math.Sign(num);
					}
				}
				else
				{
					if (a.IsCurrentRole)
					{
						return Math.Sign(a.GetDistSquared() * RoleAudioVolumeInfo.CorrectionRatio - b.GetDistSquared());
					}
					if (b.IsCurrentRole)
					{
						return Math.Sign(a.GetDistSquared() - b.GetDistSquared() * RoleAudioVolumeInfo.CorrectionRatio);
					}
					double num2 = a.GetDistSquared() - b.GetDistSquared();
					if (num2 < 0.0001)
					{
						num2 -= 1.0;
					}
					return Math.Sign(num2);
				}
			}
			int num3 = b.Priority - a.Priority;
			if (num3 == 0)
			{
				num3--;
			}
			return num3;
		}

		// Token: 0x04020242 RID: 131650
		private int Volume;

		// Token: 0x04020243 RID: 131651
		private double DistSquared = RoleAudioVolumeInfo.MaxDistanceSquared;

		// Token: 0x04020244 RID: 131652
		private readonly Dictionary<int, EventVolumeInfo> EventList = new Dictionary<int, EventVolumeInfo>();

		// Token: 0x04020245 RID: 131653
		public bool IsCurrentRole;

		// Token: 0x04020246 RID: 131654
		public int RoleId;

		// Token: 0x04020247 RID: 131655
		public int EntityId;

		// Token: 0x04020248 RID: 131656
		public double TimeValue;

		// Token: 0x04020249 RID: 131657
		public EEventVolumePriority Priority;
	}
}
