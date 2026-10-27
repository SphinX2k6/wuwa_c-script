using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf;

// Token: 0x020017BC RID: 6076
public class StaticHandler : IHandler
{
	// Token: 0x17000EB0 RID: 3760
	// (get) Token: 0x0600B15C RID: 45404 RVA: 0x002823E3 File Offset: 0x002805E3
	public EHandlerType Type
	{
		get
		{
			return EHandlerType.Static;
		}
	}

	// Token: 0x17000EB1 RID: 3761
	// (get) Token: 0x0600B15D RID: 45405 RVA: 0x002823E6 File Offset: 0x002805E6
	// (set) Token: 0x0600B15E RID: 45406 RVA: 0x002823EE File Offset: 0x002805EE
	public bool? IsSync { get; set; }

	// Token: 0x17000EB2 RID: 3762
	// (get) Token: 0x0600B15F RID: 45407 RVA: 0x002823F7 File Offset: 0x002805F7
	// (set) Token: 0x0600B160 RID: 45408 RVA: 0x002823FF File Offset: 0x002805FF
	public bool? IsCache { get; set; }

	// Token: 0x0400507B RID: 20603
	[Nullable(new byte[]
	{
		2,
		2,
		1,
		2
	})]
	public Func<Entity, IMessage, CombatCommon, bool> Preprocessor;

	// Token: 0x0400507C RID: 20604
	[Nullable(new byte[]
	{
		2,
		2,
		1,
		2
	})]
	public Action<Entity, IMessage, CombatCommon> Listener;
}
