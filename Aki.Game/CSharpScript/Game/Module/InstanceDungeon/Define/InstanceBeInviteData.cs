using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x0200488F RID: 18575
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceBeInviteData
	{
		// Token: 0x0602EB3B RID: 191291 RVA: 0x00D08EC5 File Offset: 0x00D070C5
		public void SetPlayerId(int value)
		{
			this.PlayerId = value;
		}

		// Token: 0x0602EB3C RID: 191292 RVA: 0x00D08ECE File Offset: 0x00D070CE
		public int GetPlayerId()
		{
			return this.PlayerId;
		}

		// Token: 0x0602EB3D RID: 191293 RVA: 0x00D08ED6 File Offset: 0x00D070D6
		public void SetInstanceId(int value)
		{
			this.InstanceId = value;
		}

		// Token: 0x0602EB3E RID: 191294 RVA: 0x00D08EDF File Offset: 0x00D070DF
		public int GetInstanceId()
		{
			return this.InstanceId;
		}

		// Token: 0x0602EB3F RID: 191295 RVA: 0x00D08EE7 File Offset: 0x00D070E7
		public void SetName(string value)
		{
			this.Name = value;
		}

		// Token: 0x0602EB40 RID: 191296 RVA: 0x00D08EF0 File Offset: 0x00D070F0
		public string GetName()
		{
			return this.Name;
		}

		// Token: 0x0602EB41 RID: 191297 RVA: 0x00D08EF8 File Offset: 0x00D070F8
		public void SetLimitTimestamp(long value)
		{
			this.LimitTimestamp = value;
		}

		// Token: 0x0602EB42 RID: 191298 RVA: 0x00D08F01 File Offset: 0x00D07101
		public long GetLimitTimestamp()
		{
			return this.LimitTimestamp;
		}

		// Token: 0x0602EB43 RID: 191299 RVA: 0x00D08F0C File Offset: 0x00D0710C
		[NullableContext(2)]
		public string GetInstanceName()
		{
			InstanceDungeon? config = ConfigInstanceDungeonById.GetConfig(this.InstanceId, true);
			if (config != null)
			{
				return ConfigMultiTextLang.GetLocalTextNew(config.Value.MapName, null);
			}
			return null;
		}

		// Token: 0x04018D27 RID: 101671
		private int PlayerId;

		// Token: 0x04018D28 RID: 101672
		private int InstanceId;

		// Token: 0x04018D29 RID: 101673
		private string Name = "";

		// Token: 0x04018D2A RID: 101674
		private long LimitTimestamp;
	}
}
