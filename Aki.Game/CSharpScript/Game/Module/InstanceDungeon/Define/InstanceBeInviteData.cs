using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020058B7 RID: 22711
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceBeInviteData
	{
		// Token: 0x06039C18 RID: 236568 RVA: 0x00DB9FAD File Offset: 0x00DB81AD
		public void SetPlayerId(int value)
		{
			this.PlayerId = value;
		}

		// Token: 0x06039C19 RID: 236569 RVA: 0x00DB9FB6 File Offset: 0x00DB81B6
		public int GetPlayerId()
		{
			return this.PlayerId;
		}

		// Token: 0x06039C1A RID: 236570 RVA: 0x00DB9FBE File Offset: 0x00DB81BE
		public void SetInstanceId(int value)
		{
			this.InstanceId = value;
		}

		// Token: 0x06039C1B RID: 236571 RVA: 0x00DB9FC7 File Offset: 0x00DB81C7
		public int GetInstanceId()
		{
			return this.InstanceId;
		}

		// Token: 0x06039C1C RID: 236572 RVA: 0x00DB9FCF File Offset: 0x00DB81CF
		public void SetName(string value)
		{
			this.Name = value;
		}

		// Token: 0x06039C1D RID: 236573 RVA: 0x00DB9FD8 File Offset: 0x00DB81D8
		public string GetName()
		{
			return this.Name;
		}

		// Token: 0x06039C1E RID: 236574 RVA: 0x00DB9FE0 File Offset: 0x00DB81E0
		public void SetLimitTimestamp(long value)
		{
			this.LimitTimestamp = value;
		}

		// Token: 0x06039C1F RID: 236575 RVA: 0x00DB9FE9 File Offset: 0x00DB81E9
		public long GetLimitTimestamp()
		{
			return this.LimitTimestamp;
		}

		// Token: 0x06039C20 RID: 236576 RVA: 0x00DB9FF4 File Offset: 0x00DB81F4
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

		// Token: 0x0401E28A RID: 123530
		private int PlayerId;

		// Token: 0x0401E28B RID: 123531
		private int InstanceId;

		// Token: 0x0401E28C RID: 123532
		private string Name = "";

		// Token: 0x0401E28D RID: 123533
		private long LimitTimestamp;
	}
}
