using System;
using System.Runtime.CompilerServices;

// Token: 0x020021C7 RID: 8647
[NullableContext(1)]
[Nullable(0)]
public class MailParamHandler : IMailParamHandler
{
	// Token: 0x06010CE1 RID: 68833 RVA: 0x00414EE0 File Offset: 0x004130E0
	public MailParamHandler(Action<MailData, string> handler)
	{
		this._handler = handler;
	}

	// Token: 0x06010CE2 RID: 68834 RVA: 0x00414EEF File Offset: 0x004130EF
	public void Handler(MailData instance, string value)
	{
		this._handler(instance, value);
	}

	// Token: 0x04007FD0 RID: 32720
	private readonly Action<MailData, string> _handler;
}
