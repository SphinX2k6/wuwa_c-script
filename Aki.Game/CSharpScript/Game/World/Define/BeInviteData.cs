using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.World.Define
{
	// Token: 0x02004530 RID: 17712
	[NullableContext(1)]
	[Nullable(0)]
	public class BeInviteData
	{
		// Token: 0x0602DC0C RID: 187404 RVA: 0x00A830F9 File Offset: 0x00A812F9
		public void SetPlayerId(int value)
		{
			this.PlayerId = value;
		}

		// Token: 0x0602DC0D RID: 187405 RVA: 0x00A83102 File Offset: 0x00A81302
		public int GetPlayerId()
		{
			return this.PlayerId;
		}

		// Token: 0x0602DC0E RID: 187406 RVA: 0x00A8310A File Offset: 0x00A8130A
		public void SetName(string value)
		{
			this.Name = value;
		}

		// Token: 0x0602DC0F RID: 187407 RVA: 0x00A83113 File Offset: 0x00A81313
		public string GetName()
		{
			return this.Name;
		}

		// Token: 0x0602DC10 RID: 187408 RVA: 0x00A8311B File Offset: 0x00A8131B
		public void SetContent(string value)
		{
			this.Content = value;
		}

		// Token: 0x0602DC11 RID: 187409 RVA: 0x00A83124 File Offset: 0x00A81324
		public string GetContent()
		{
			return this.Content;
		}

		// Token: 0x0602DC12 RID: 187410 RVA: 0x00A8312C File Offset: 0x00A8132C
		public void SetLimitTimestamp(long value)
		{
			this.LimitTimestamp = value;
		}

		// Token: 0x0602DC13 RID: 187411 RVA: 0x00A83135 File Offset: 0x00A81335
		public long GetLimitTimestamp()
		{
			return this.LimitTimestamp;
		}

		// Token: 0x0602DC14 RID: 187412 RVA: 0x00A8313D File Offset: 0x00A8133D
		public void SetToken(string value)
		{
			this.Token = value;
		}

		// Token: 0x0602DC15 RID: 187413 RVA: 0x00A83146 File Offset: 0x00A81346
		public string GetToken()
		{
			return this.Token;
		}

		// Token: 0x0602DC16 RID: 187414 RVA: 0x00A8314E File Offset: 0x00A8134E
		public void SetGameplayTagHash(long value)
		{
			this.GameplayTagHash = new long?(value);
		}

		// Token: 0x0602DC17 RID: 187415 RVA: 0x00A8315C File Offset: 0x00A8135C
		public long? GetGameplayTagHash()
		{
			return this.GameplayTagHash;
		}

		// Token: 0x040186D0 RID: 100048
		private int PlayerId;

		// Token: 0x040186D1 RID: 100049
		private string Name = "";

		// Token: 0x040186D2 RID: 100050
		private string Content = "";

		// Token: 0x040186D3 RID: 100051
		private long LimitTimestamp;

		// Token: 0x040186D4 RID: 100052
		private string Token = "";

		// Token: 0x040186D5 RID: 100053
		private long? GameplayTagHash;
	}
}
