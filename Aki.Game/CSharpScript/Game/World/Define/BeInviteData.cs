using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.World.Define
{
	// Token: 0x02003455 RID: 13397
	[NullableContext(1)]
	[Nullable(0)]
	public class BeInviteData
	{
		// Token: 0x060222D4 RID: 139988 RVA: 0x009AE33D File Offset: 0x009AC53D
		public void SetPlayerId(int value)
		{
			this.PlayerId = value;
		}

		// Token: 0x060222D5 RID: 139989 RVA: 0x009AE346 File Offset: 0x009AC546
		public int GetPlayerId()
		{
			return this.PlayerId;
		}

		// Token: 0x060222D6 RID: 139990 RVA: 0x009AE34E File Offset: 0x009AC54E
		public void SetName(string value)
		{
			this.Name = value;
		}

		// Token: 0x060222D7 RID: 139991 RVA: 0x009AE357 File Offset: 0x009AC557
		public string GetName()
		{
			return this.Name;
		}

		// Token: 0x060222D8 RID: 139992 RVA: 0x009AE35F File Offset: 0x009AC55F
		public void SetContent(string value)
		{
			this.Content = value;
		}

		// Token: 0x060222D9 RID: 139993 RVA: 0x009AE368 File Offset: 0x009AC568
		public string GetContent()
		{
			return this.Content;
		}

		// Token: 0x060222DA RID: 139994 RVA: 0x009AE370 File Offset: 0x009AC570
		public void SetLimitTimestamp(long value)
		{
			this.LimitTimestamp = value;
		}

		// Token: 0x060222DB RID: 139995 RVA: 0x009AE379 File Offset: 0x009AC579
		public long GetLimitTimestamp()
		{
			return this.LimitTimestamp;
		}

		// Token: 0x060222DC RID: 139996 RVA: 0x009AE381 File Offset: 0x009AC581
		public void SetToken(string value)
		{
			this.Token = value;
		}

		// Token: 0x060222DD RID: 139997 RVA: 0x009AE38A File Offset: 0x009AC58A
		public string GetToken()
		{
			return this.Token;
		}

		// Token: 0x060222DE RID: 139998 RVA: 0x009AE392 File Offset: 0x009AC592
		public void SetGameplayTagHash(long value)
		{
			this.GameplayTagHash = new long?(value);
		}

		// Token: 0x060222DF RID: 139999 RVA: 0x009AE3A0 File Offset: 0x009AC5A0
		public long? GetGameplayTagHash()
		{
			return this.GameplayTagHash;
		}

		// Token: 0x04012CF5 RID: 77045
		private int PlayerId;

		// Token: 0x04012CF6 RID: 77046
		private string Name = "";

		// Token: 0x04012CF7 RID: 77047
		private string Content = "";

		// Token: 0x04012CF8 RID: 77048
		private long LimitTimestamp;

		// Token: 0x04012CF9 RID: 77049
		private string Token = "";

		// Token: 0x04012CFA RID: 77050
		private long? GameplayTagHash;
	}
}
