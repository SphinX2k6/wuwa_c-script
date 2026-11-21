using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000DA RID: 218
[NullableContext(1)]
[Nullable(0)]
public class SwitchRef : IClear
{
	// Token: 0x06000708 RID: 1800 RVA: 0x00024612 File Offset: 0x00022812
	public SwitchRef(string group, string stateInternal)
	{
		this.Group = group;
		this.StateInternal = stateInternal;
	}

	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x06000709 RID: 1801 RVA: 0x00024628 File Offset: 0x00022828
	// (set) Token: 0x0600070A RID: 1802 RVA: 0x00024630 File Offset: 0x00022830
	public string State
	{
		get
		{
			return this.StateInternal;
		}
		set
		{
			AActor actor = this.Actor;
			if (actor == null || !actor.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Audio;
				ELogAuthor author = ELogAuthor.MSY;
				string message = "[Core.SwitchRef] 绑定对象无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Group", this.Group);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (this.StateInternal != value)
			{
				this.StateInternal = value;
				AudioSystem.Instance.SetSwitch(this.Group, this.State, this.Actor);
			}
		}
	}

	// Token: 0x0600070B RID: 1803 RVA: 0x000246B2 File Offset: 0x000228B2
	public void Bind(AActor actor)
	{
		this.Actor = actor;
		AudioSystem.Instance.SetSwitch(this.Group, this.State, this.Actor);
	}

	// Token: 0x0600070C RID: 1804 RVA: 0x000246D7 File Offset: 0x000228D7
	public bool ClearObject()
	{
		this.Actor = null;
		return true;
	}

	// Token: 0x0400057D RID: 1405
	[Nullable(2)]
	private AActor Actor;

	// Token: 0x0400057E RID: 1406
	private readonly string Group;

	// Token: 0x0400057F RID: 1407
	private string StateInternal;
}
