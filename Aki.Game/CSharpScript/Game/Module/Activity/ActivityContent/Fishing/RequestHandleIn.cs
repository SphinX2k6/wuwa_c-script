using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005570 RID: 21872
	[NullableContext(1)]
	[Nullable(0)]
	public class RequestHandleIn : IRequestHandleIn
	{
		// Token: 0x17006916 RID: 26902
		// (get) Token: 0x0603637D RID: 222077 RVA: 0x00F209B9 File Offset: 0x00F1EBB9
		// (set) Token: 0x0603637E RID: 222078 RVA: 0x00F209C1 File Offset: 0x00F1EBC1
		public int InteractId { get; set; }

		// Token: 0x17006917 RID: 26903
		// (get) Token: 0x0603637F RID: 222079 RVA: 0x00F209CA File Offset: 0x00F1EBCA
		// (set) Token: 0x06036380 RID: 222080 RVA: 0x00F209D2 File Offset: 0x00F1EBD2
		public List<FishingItemInfo> LeftDataList { get; set; }

		// Token: 0x17006918 RID: 26904
		// (get) Token: 0x06036381 RID: 222081 RVA: 0x00F209DB File Offset: 0x00F1EBDB
		// (set) Token: 0x06036382 RID: 222082 RVA: 0x00F209E3 File Offset: 0x00F1EBE3
		public List<FishingItemInfo> RightDataList { get; set; }

		// Token: 0x17006919 RID: 26905
		// (get) Token: 0x06036383 RID: 222083 RVA: 0x00F209EC File Offset: 0x00F1EBEC
		// (set) Token: 0x06036384 RID: 222084 RVA: 0x00F209F4 File Offset: 0x00F1EBF4
		public int? RemoveIncId { get; set; }

		// Token: 0x1700691A RID: 26906
		// (get) Token: 0x06036385 RID: 222085 RVA: 0x00F209FD File Offset: 0x00F1EBFD
		// (set) Token: 0x06036386 RID: 222086 RVA: 0x00F20A05 File Offset: 0x00F1EC05
		public int ActionIncId { get; set; }

		// Token: 0x1700691B RID: 26907
		// (get) Token: 0x06036387 RID: 222087 RVA: 0x00F20A0E File Offset: 0x00F1EC0E
		// (set) Token: 0x06036388 RID: 222088 RVA: 0x00F20A16 File Offset: 0x00F1EC16
		[Nullable(2)]
		public Action<bool, bool> Callback { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x06036389 RID: 222089 RVA: 0x00F20A1F File Offset: 0x00F1EC1F
		public RequestHandleIn()
		{
			this.LeftDataList = new List<FishingItemInfo>();
			this.RightDataList = new List<FishingItemInfo>();
		}
	}
}
