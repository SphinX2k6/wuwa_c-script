using System;
using System.Runtime.CompilerServices;

// Token: 0x020016AB RID: 5803
[NullableContext(1)]
[Nullable(0)]
public class MailParamHandler : IMailParamHandler
{
	// Token: 0x0600E172 RID: 57714 RVA: 0x004217C0 File Offset: 0x0041F9C0
	public MailParamHandler(Action<MailData, string> handler)
	{
		this._handler = handler;
	}

	// Token: 0x0600E173 RID: 57715 RVA: 0x004217CF File Offset: 0x0041F9CF
	public void Handler(MailData instance, string value)
	{
		this._handler(instance, value);
	}

	// Token: 0x04008117 RID: 33047
	private readonly Action<MailData, string> _handler;
}
