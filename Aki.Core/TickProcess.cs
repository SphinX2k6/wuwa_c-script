using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000CF RID: 207
public class TickProcess : IStaticVariableResetter
{
	// Token: 0x06000697 RID: 1687 RVA: 0x00022481 File Offset: 0x00020681
	static TickProcess()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TickProcess.CreateStaticDefaultValue), new Action(TickProcess.ResetStaticDefaultValue));
	}

	// Token: 0x06000698 RID: 1688 RVA: 0x000224A0 File Offset: 0x000206A0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06000699 RID: 1689 RVA: 0x000224A2 File Offset: 0x000206A2
	public static void ResetStaticDefaultValue()
	{
		TickProcess.Increment = 0;
	}

	// Token: 0x0600069A RID: 1690 RVA: 0x000224AA File Offset: 0x000206AA
	public TickProcess()
	{
		this.Id = ++TickProcess.Increment;
	}

	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x0600069B RID: 1691 RVA: 0x000224CC File Offset: 0x000206CC
	public ETickingGroup Group
	{
		get
		{
			return this.GroupInternal;
		}
	}

	// Token: 0x0600069C RID: 1692 RVA: 0x000224D4 File Offset: 0x000206D4
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

	// Token: 0x0600069D RID: 1693 RVA: 0x00022508 File Offset: 0x00020708
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

	// Token: 0x0400052E RID: 1326
	public readonly int Id;

	// Token: 0x0400052F RID: 1327
	private static int Increment;

	// Token: 0x04000530 RID: 1328
	[Nullable(2)]
	private Action<float> TickCallback;

	// Token: 0x04000531 RID: 1329
	private ETickProcessLifeType LifeType;

	// Token: 0x04000532 RID: 1330
	private float LifeTime;

	// Token: 0x04000533 RID: 1331
	private float PassTime;

	// Token: 0x04000534 RID: 1332
	private ETickingGroup GroupInternal = ETickingGroup.TG_MAX;

	// Token: 0x04000535 RID: 1333
	[Nullable(2)]
	private string CreateReason;
}
