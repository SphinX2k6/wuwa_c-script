using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002119 RID: 8473
[NullableContext(2)]
[Nullable(0)]
public class TermTextRegistryHandle
{
	// Token: 0x17001F83 RID: 8067
	// (get) Token: 0x06014C61 RID: 85089 RVA: 0x0060ADA2 File Offset: 0x00608FA2
	public UUIText UiText
	{
		get
		{
			return this.UiTextInternal;
		}
	}

	// Token: 0x17001F84 RID: 8068
	// (get) Token: 0x06014C62 RID: 85090 RVA: 0x0060ADAA File Offset: 0x00608FAA
	public bool Enable
	{
		get
		{
			return this.EnableInternal;
		}
	}

	// Token: 0x17001F85 RID: 8069
	// (get) Token: 0x06014C63 RID: 85091 RVA: 0x0060ADB2 File Offset: 0x00608FB2
	public ETermExplanationViewType Type
	{
		get
		{
			return this.TypeInternal;
		}
	}

	// Token: 0x06014C64 RID: 85092 RVA: 0x0060ADBA File Offset: 0x00608FBA
	public void SetEnable(bool enable)
	{
		this.EnableInternal = enable;
		this.IsEnableStateDirty = true;
	}

	// Token: 0x06014C65 RID: 85093 RVA: 0x0060ADCA File Offset: 0x00608FCA
	public void SetUiText(UUIText uiText)
	{
		this.UiTextInternal = uiText;
	}

	// Token: 0x06014C66 RID: 85094 RVA: 0x0060ADD3 File Offset: 0x00608FD3
	public void SetType(ETermExplanationViewType type)
	{
		this.TypeInternal = type;
	}

	// Token: 0x06014C67 RID: 85095 RVA: 0x0060ADDC File Offset: 0x00608FDC
	public void Clear()
	{
		UUIText uiText = this.UiText;
		AUIBaseActor auibaseActor = ((uiText != null) ? uiText.GetOwner() : null) as AUIBaseActor;
		if (auibaseActor != null)
		{
			FUIBaseActorPreDestroyedSignature onPreDestroyed = auibaseActor.OnPreDestroyed;
			if (onPreDestroyed != null)
			{
				onPreDestroyed.Clear();
			}
		}
		UUIText uiText2 = this.UiText;
		if (uiText2 != null && uiText2.IsValid())
		{
			this.UiText.OnHyperLinkClickCallBack.Unbind();
		}
		this.SetEnable(true);
		this.SetUiText(null);
		this.SetType(ETermExplanationViewType.Center);
		this.OnDisableClick = null;
		this.ViewId = 0;
		this.AttachDir = ETermExplanationViewAttachDirection.None;
		this.AttachItem = null;
		this.Offset = new ValueTuple<float, float>(0f, 0f);
		this.NeedHighlight = true;
		this.Group = ETermExplanationGroup.Default;
		this.Priority = 0;
		this.IsEnableStateDirty = false;
		this.Style = ETermExplanationViewStyle.Default;
		this.ReportType = null;
		this.Id = 0;
	}

	// Token: 0x0400B10F RID: 45327
	public int Id;

	// Token: 0x0400B110 RID: 45328
	private UUIText UiTextInternal;

	// Token: 0x0400B111 RID: 45329
	private bool EnableInternal = true;

	// Token: 0x0400B112 RID: 45330
	private ETermExplanationViewType TypeInternal;

	// Token: 0x0400B113 RID: 45331
	public int ViewId;

	// Token: 0x0400B114 RID: 45332
	public ETermExplanationViewAttachDirection AttachDir;

	// Token: 0x0400B115 RID: 45333
	public UUIItem AttachItem;

	// Token: 0x0400B116 RID: 45334
	public Action OnDisableClick;

	// Token: 0x0400B117 RID: 45335
	[Nullable(0)]
	public ValueTuple<float, float> Offset = new ValueTuple<float, float>(0f, 0f);

	// Token: 0x0400B118 RID: 45336
	public bool NeedHighlight = true;

	// Token: 0x0400B119 RID: 45337
	[Nullable(1)]
	public string LastText = "";

	// Token: 0x0400B11A RID: 45338
	public bool LastHierarchyActive;

	// Token: 0x0400B11B RID: 45339
	public ETermExplanationGroup Group;

	// Token: 0x0400B11C RID: 45340
	public int Priority;

	// Token: 0x0400B11D RID: 45341
	public bool IsEnableStateDirty;

	// Token: 0x0400B11E RID: 45342
	public ETermExplanationViewStyle Style = ETermExplanationViewStyle.Default;

	// Token: 0x0400B11F RID: 45343
	public ETermExplanationReportType? ReportType;
}
