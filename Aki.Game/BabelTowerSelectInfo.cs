using System;

// Token: 0x020005E1 RID: 1505
public class BabelTowerSelectInfo : IBabelTowerSelectInfo
{
	// Token: 0x170009E5 RID: 2533
	// (get) Token: 0x060046F2 RID: 18162 RVA: 0x001844CA File Offset: 0x001826CA
	// (set) Token: 0x060046F3 RID: 18163 RVA: 0x001844D2 File Offset: 0x001826D2
	public EBabelTowerDeTermState State { get; set; }

	// Token: 0x170009E6 RID: 2534
	// (get) Token: 0x060046F4 RID: 18164 RVA: 0x001844DB File Offset: 0x001826DB
	// (set) Token: 0x060046F5 RID: 18165 RVA: 0x001844E3 File Offset: 0x001826E3
	public int SelectIndex { get; set; }
}
