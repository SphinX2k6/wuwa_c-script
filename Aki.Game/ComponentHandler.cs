using System;
using System.Runtime.CompilerServices;

// Token: 0x020017BD RID: 6077
public class ComponentHandler : IHandler
{
	// Token: 0x17000EB3 RID: 3763
	// (get) Token: 0x0600B162 RID: 45410 RVA: 0x00282410 File Offset: 0x00280610
	public EHandlerType Type
	{
		get
		{
			return EHandlerType.Component;
		}
	}

	// Token: 0x17000EB4 RID: 3764
	// (get) Token: 0x0600B163 RID: 45411 RVA: 0x00282413 File Offset: 0x00280613
	// (set) Token: 0x0600B164 RID: 45412 RVA: 0x0028241B File Offset: 0x0028061B
	public bool? IsSync { get; set; }

	// Token: 0x17000EB5 RID: 3765
	// (get) Token: 0x0600B165 RID: 45413 RVA: 0x00282424 File Offset: 0x00280624
	// (set) Token: 0x0600B166 RID: 45414 RVA: 0x0028242C File Offset: 0x0028062C
	public bool? IsCache { get; set; }

	// Token: 0x0400507F RID: 20607
	[Nullable(2)]
	public Type Component;
}
