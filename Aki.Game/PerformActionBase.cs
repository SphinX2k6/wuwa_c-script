using System;
using System.Runtime.CompilerServices;

// Token: 0x0200266D RID: 9837
[NullableContext(2)]
[Nullable(0)]
public class PerformActionBase : IPerformActionBase
{
	// Token: 0x06018A66 RID: 100966 RVA: 0x0077ABFF File Offset: 0x00778DFF
	public PerformActionBase(EPerformAction name)
	{
		this.Name = name;
	}

	// Token: 0x17002701 RID: 9985
	// (get) Token: 0x06018A67 RID: 100967 RVA: 0x0077AC0E File Offset: 0x00778E0E
	// (set) Token: 0x06018A68 RID: 100968 RVA: 0x0077AC16 File Offset: 0x00778E16
	public EPerformAction Name { get; private set; }

	// Token: 0x17002702 RID: 9986
	// (get) Token: 0x06018A69 RID: 100969 RVA: 0x0077AC1F File Offset: 0x00778E1F
	// (set) Token: 0x06018A6A RID: 100970 RVA: 0x0077AC27 File Offset: 0x00778E27
	public int Id { get; set; }

	// Token: 0x17002703 RID: 9987
	// (get) Token: 0x06018A6B RID: 100971 RVA: 0x0077AC30 File Offset: 0x00778E30
	// (set) Token: 0x06018A6C RID: 100972 RVA: 0x0077AC38 File Offset: 0x00778E38
	public EPerformMode Mode { get; set; }

	// Token: 0x17002704 RID: 9988
	// (get) Token: 0x06018A6D RID: 100973 RVA: 0x0077AC41 File Offset: 0x00778E41
	// (set) Token: 0x06018A6E RID: 100974 RVA: 0x0077AC49 File Offset: 0x00778E49
	public EPerformGroup Group { get; set; }

	// Token: 0x17002705 RID: 9989
	// (get) Token: 0x06018A6F RID: 100975 RVA: 0x0077AC52 File Offset: 0x00778E52
	// (set) Token: 0x06018A70 RID: 100976 RVA: 0x0077AC5A File Offset: 0x00778E5A
	public bool Executed { get; set; }

	// Token: 0x17002706 RID: 9990
	// (get) Token: 0x06018A71 RID: 100977 RVA: 0x0077AC63 File Offset: 0x00778E63
	public virtual bool IsAtomic { get; }

	// Token: 0x17002707 RID: 9991
	// (get) Token: 0x06018A72 RID: 100978 RVA: 0x0077AC6B File Offset: 0x00778E6B
	// (set) Token: 0x06018A73 RID: 100979 RVA: 0x0077AC73 File Offset: 0x00778E73
	public bool IsValid { get; set; }

	// Token: 0x17002708 RID: 9992
	// (get) Token: 0x06018A74 RID: 100980 RVA: 0x0077AC7C File Offset: 0x00778E7C
	// (set) Token: 0x06018A75 RID: 100981 RVA: 0x0077AC84 File Offset: 0x00778E84
	public bool IsPersistent { get; set; }

	// Token: 0x06018A76 RID: 100982 RVA: 0x0077AC90 File Offset: 0x00778E90
	public void Execute()
	{
		if (this.IsValid)
		{
			if (this.Executed)
			{
				this.OnRestore();
				return;
			}
			this.Executed = true;
			Action<int> onBeforeExecute = this.OnBeforeExecute;
			if (onBeforeExecute != null)
			{
				onBeforeExecute(this.Id);
			}
			this.OnExecute();
			return;
		}
		else
		{
			Action onFinish = this.OnFinish;
			if (onFinish == null)
			{
				return;
			}
			onFinish();
			return;
		}
	}

	// Token: 0x06018A77 RID: 100983 RVA: 0x0077ACE9 File Offset: 0x00778EE9
	protected void FinishExecute()
	{
		Action<int> onAfterExecute = this.OnAfterExecute;
		if (onAfterExecute != null)
		{
			onAfterExecute(this.Id);
		}
		Action onFinish = this.OnFinish;
		if (onFinish == null)
		{
			return;
		}
		onFinish();
	}

	// Token: 0x06018A78 RID: 100984 RVA: 0x0077AD12 File Offset: 0x00778F12
	public void Interrupt()
	{
		this.OnInterrupt();
	}

	// Token: 0x06018A79 RID: 100985 RVA: 0x0077AD1C File Offset: 0x00778F1C
	public void Reset()
	{
		this.IsValid = false;
		this.Id = 0;
		this.Executed = false;
		this.Param = null;
		this.PerformComp = null;
		this.Mode = EPerformMode.Undetermined;
		this.Group = EPerformGroup.DefaultGroup;
		this.IsPersistent = false;
		this.OnFinish = null;
		this.OnBeforeExecute = null;
		this.OnReset();
	}

	// Token: 0x06018A7A RID: 100986 RVA: 0x0077AD75 File Offset: 0x00778F75
	protected virtual void OnExecute()
	{
	}

	// Token: 0x06018A7B RID: 100987 RVA: 0x0077AD77 File Offset: 0x00778F77
	protected virtual void OnInterrupt()
	{
	}

	// Token: 0x06018A7C RID: 100988 RVA: 0x0077AD79 File Offset: 0x00778F79
	protected virtual void OnRestore()
	{
		this.OnExecute();
	}

	// Token: 0x06018A7D RID: 100989 RVA: 0x0077AD81 File Offset: 0x00778F81
	protected virtual void OnReset()
	{
	}

	// Token: 0x0400D61E RID: 54814
	public IActionParamMap Param;

	// Token: 0x0400D61F RID: 54815
	public BasePerformComponent PerformComp;

	// Token: 0x0400D620 RID: 54816
	public Action OnFinish;

	// Token: 0x0400D621 RID: 54817
	public Action<int> OnBeforeExecute;

	// Token: 0x0400D622 RID: 54818
	public Action<int> OnAfterExecute;
}
