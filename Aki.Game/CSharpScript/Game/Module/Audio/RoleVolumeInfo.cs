using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02004E77 RID: 20087
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleVolumeInfo
	{
		// Token: 0x060328FF RID: 207103 RVA: 0x00E2FB9B File Offset: 0x00E2DD9B
		public RoleVolumeInfo(int roleId, int entityId)
		{
			this.RoleId = roleId;
			this.EntityId = entityId;
			this.TimeValue = Time.Instance.Now;
		}

		// Token: 0x06032900 RID: 207104 RVA: 0x00E2FBD7 File Offset: 0x00E2DDD7
		public double GetDistSquared()
		{
			return this.DistSquared;
		}

		// Token: 0x06032901 RID: 207105 RVA: 0x00E2FBE0 File Offset: 0x00E2DDE0
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

		// Token: 0x06032902 RID: 207106 RVA: 0x00E2FC39 File Offset: 0x00E2DE39
		public void AddEvent(int handle, EventVolumeInfo info)
		{
			this.EventList[handle] = info;
			info.OnChangeVolume(this.Volume, this);
		}

		// Token: 0x06032903 RID: 207107 RVA: 0x00E2FC55 File Offset: 0x00E2DE55
		public void RemoveEvent(int handle)
		{
			this.EventList.Remove(handle);
		}

		// Token: 0x06032904 RID: 207108 RVA: 0x00E2FC64 File Offset: 0x00E2DE64
		public void SetPlayEvent(bool result)
		{
			if (result)
			{
				this.TimeValue = Time.Instance.Now;
			}
			this.IsCurrentRole = result;
			this.ChangeVolume((result > false) ? 1 : 0);
		}

		// Token: 0x06032905 RID: 207109 RVA: 0x00E2FC8A File Offset: 0x00E2DE8A
		public bool Empty()
		{
			return this.EventList.Count == 0;
		}

		// Token: 0x06032906 RID: 207110 RVA: 0x00E2FC9C File Offset: 0x00E2DE9C
		private void ChangeVolume(int volume)
		{
			this.Volume = volume;
			foreach (KeyValuePair<int, EventVolumeInfo> keyValuePair in this.EventList)
			{
				keyValuePair.Value.OnChangeVolume(volume, this);
			}
		}

		// Token: 0x06032907 RID: 207111 RVA: 0x00E2FD00 File Offset: 0x00E2DF00
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

		// Token: 0x0401AD09 RID: 109833
		private int Volume;

		// Token: 0x0401AD0A RID: 109834
		private double DistSquared = RoleAudioVolumeInfo.MaxDistanceSquared;

		// Token: 0x0401AD0B RID: 109835
		private readonly Dictionary<int, EventVolumeInfo> EventList = new Dictionary<int, EventVolumeInfo>();

		// Token: 0x0401AD0C RID: 109836
		public bool IsCurrentRole;

		// Token: 0x0401AD0D RID: 109837
		public int RoleId;

		// Token: 0x0401AD0E RID: 109838
		public int EntityId;

		// Token: 0x0401AD0F RID: 109839
		public double TimeValue;

		// Token: 0x0401AD10 RID: 109840
		public EEventVolumePriority Priority;
	}
}
