using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf;

// Token: 0x02000C75 RID: 3189
public class StaticHandler : IHandler
{
	// Token: 0x17000ED3 RID: 3795
	// (get) Token: 0x06008544 RID: 34116 RVA: 0x0028C97B File Offset: 0x0028AB7B
	public EHandlerType Type
	{
		get
		{
			return EHandlerType.Static;
		}
	}

	// Token: 0x17000ED4 RID: 3796
	// (get) Token: 0x06008545 RID: 34117 RVA: 0x0028C97E File Offset: 0x0028AB7E
	// (set) Token: 0x06008546 RID: 34118 RVA: 0x0028C986 File Offset: 0x0028AB86
	public bool? IsSync { get; set; }

	// Token: 0x17000ED5 RID: 3797
	// (get) Token: 0x06008547 RID: 34119 RVA: 0x0028C98F File Offset: 0x0028AB8F
	// (set) Token: 0x06008548 RID: 34120 RVA: 0x0028C997 File Offset: 0x0028AB97
	public bool? IsCache { get; set; }

	// Token: 0x04005125 RID: 20773
	[Nullable(new byte[]
	{
		2,
		2,
		1,
		2
	})]
	public Func<Entity, IMessage, CombatCommon, bool> Preprocessor;

	// Token: 0x04005126 RID: 20774
	[Nullable(new byte[]
	{
		2,
		2,
		1,
		2
	})]
	public Action<Entity, IMessage, CombatCommon> Listener;
}
