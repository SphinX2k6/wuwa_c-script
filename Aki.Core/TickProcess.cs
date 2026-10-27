using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000CD RID: 205
public class TickProcess : IStaticVariableResetter
{
	// Token: 0x06000656 RID: 1622 RVA: 0x00021FA9 File Offset: 0x000201A9
	static TickProcess()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TickProcess.CreateStaticDefaultValue), new Action(TickProcess.ResetStaticDefaultValue));
	}

	// Token: 0x06000657 RID: 1623 RVA: 0x00021FC8 File Offset: 0x000201C8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06000658 RID: 1624 RVA: 0x00021FCA File Offset: 0x000201CA
	public static void ResetStaticDefaultValue()
	{
		TickProcess.Increment = 0;
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x00021FD2 File Offset: 0x000201D2
	public TickProcess()
	{
		this.Id = ++TickProcess.Increment;
	}

	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x0600065A RID: 1626 RVA: 0x00021FF4 File Offset: 0x000201F4
	public ETickingGroup Group
	{
		get
		{
			return this.GroupInternal;
		}
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x00021FFC File Offset: 0x000201FC
	[NullableContext(1)]
	public void Init(Action<float> callback, ETickingGroup group, ETickProcessLifeType lifeType, float lifeTime = 0f, [Nullable(2)] string createReason = null)
	{
		this.TickCallback = callback;
		this.GroupInternal = group;
		this.LifeType = lifeType;
		this.LifeTime = lifeTime;
		this.PassTime = 0f;
		this.CreateReason = createReason;
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x00022030 File Offset: 0x00020230
	public bool Tick(float deltaTime)
	{
		if (this.TickCallback == null)
		{
			if (this.LifeType == ETickProcessLifeType.Forever)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Tick;
				ELogAuthor author = ELogAuthor.WLJ;
				string message = "[TickProcessSystem] Callback Invalid. 可能存在ForeverCallback未及时注销的情况";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CreateReason", this.CreateReason);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return true;
		}
		this.TickCallback(deltaTime);
		if (this.LifeType == ETickProcessLifeType.Once)
		{
			return true;
		}
		if (this.LifeType == ETickProcessLifeType.Delay)
		{
			this.PassTime += deltaTime;
			if (this.PassTime >= this.LifeTime)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x04000520 RID: 1312
	public readonly int Id;

	// Token: 0x04000521 RID: 1313
	private static int Increment;

	// Token: 0x04000522 RID: 1314
	[Nullable(2)]
	private Action<float> TickCallback;

	// Token: 0x04000523 RID: 1315
	private ETickProcessLifeType LifeType;

	// Token: 0x04000524 RID: 1316
	private float LifeTime;

	// Token: 0x04000525 RID: 1317
	private float PassTime;

	// Token: 0x04000526 RID: 1318
	private ETickingGroup GroupInternal = ETickingGroup.TG_MAX;

	// Token: 0x04000527 RID: 1319
	[Nullable(2)]
	private string CreateReason;
}
