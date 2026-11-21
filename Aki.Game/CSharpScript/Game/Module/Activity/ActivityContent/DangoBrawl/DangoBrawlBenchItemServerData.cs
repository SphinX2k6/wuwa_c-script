using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200570F RID: 22287
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBenchItemServerData
	{
		// Token: 0x06036DBE RID: 224702 RVA: 0x00F4BECD File Offset: 0x00F4A0CD
		public DangoBrawlBenchItemServerData(DangoBrawlBenchItemInfo data)
		{
			this.ServerData = data;
		}

		// Token: 0x170069F2 RID: 27122
		// (get) Token: 0x06036DBF RID: 224703 RVA: 0x00F4BEDC File Offset: 0x00F4A0DC
		public int Uid
		{
			get
			{
				return this.ServerData.Inst.Uid;
			}
		}

		// Token: 0x170069F3 RID: 27123
		// (get) Token: 0x06036DC0 RID: 224704 RVA: 0x00F4BEEE File Offset: 0x00F4A0EE
		public int ConfigId
		{
			get
			{
				return this.ServerData.Inst.ConfigId;
			}
		}

		// Token: 0x0401D0F9 RID: 119033
		private readonly DangoBrawlBenchItemInfo ServerData;
	}
}
