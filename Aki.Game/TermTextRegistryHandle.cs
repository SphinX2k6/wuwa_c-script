using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002B9D RID: 11165
[NullableContext(2)]
[Nullable(0)]
public class TermTextRegistryHandle
{
	// Token: 0x17001F2B RID: 7979
	// (get) Token: 0x06017230 RID: 94768 RVA: 0x005DE1CE File Offset: 0x005DC3CE
	public UUIText UiText
	{
		get
		{
			return this.UiTextInternal;
		}
	}

	// Token: 0x17001F2C RID: 7980
	// (get) Token: 0x06017231 RID: 94769 RVA: 0x005DE1D6 File Offset: 0x005DC3D6
	public bool Enable
	{
		get
		{
			return this.EnableInternal;
		}
	}

	// Token: 0x17001F2D RID: 7981
	// (get) Token: 0x06017232 RID: 94770 RVA: 0x005DE1DE File Offset: 0x005DC3DE
	public ETermExplanationViewType Type
	{
		get
		{
			return this.TypeInternal;
		}
	}

	// Token: 0x06017233 RID: 94771 RVA: 0x005DE1E6 File Offset: 0x005DC3E6
	public void SetEnable(bool enable)
	{
		this.EnableInternal = enable;
		this.IsEnableStateDirty = true;
	}

	// Token: 0x06017234 RID: 94772 RVA: 0x005DE1F6 File Offset: 0x005DC3F6
	public void SetUiText(UUIText uiText)
	{
		this.UiTextInternal = uiText;
	}

	// Token: 0x06017235 RID: 94773 RVA: 0x005DE1FF File Offset: 0x005DC3FF
	public void SetType(ETermExplanationViewType type)
	{
		this.TypeInternal = type;
	}

	// Token: 0x06017236 RID: 94774 RVA: 0x005DE208 File Offset: 0x005DC408
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

	// Token: 0x0400AD08 RID: 44296
	public int Id;

	// Token: 0x0400AD09 RID: 44297
	private UUIText UiTextInternal;

	// Token: 0x0400AD0A RID: 44298
	private bool EnableInternal = true;

	// Token: 0x0400AD0B RID: 44299
	private ETermExplanationViewType TypeInternal;

	// Token: 0x0400AD0C RID: 44300
	public int ViewId;

	// Token: 0x0400AD0D RID: 44301
	public ETermExplanationViewAttachDirection AttachDir;

	// Token: 0x0400AD0E RID: 44302
	public UUIItem AttachItem;

	// Token: 0x0400AD0F RID: 44303
	public Action OnDisableClick;

	// Token: 0x0400AD10 RID: 44304
	[Nullable(0)]
	public ValueTuple<float, float> Offset = new ValueTuple<float, float>(0f, 0f);

	// Token: 0x0400AD11 RID: 44305
	public bool NeedHighlight = true;

	// Token: 0x0400AD12 RID: 44306
	[Nullable(1)]
	public string LastText = "";

	// Token: 0x0400AD13 RID: 44307
	public bool LastHierarchyActive;

	// Token: 0x0400AD14 RID: 44308
	public ETermExplanationGroup Group;

	// Token: 0x0400AD15 RID: 44309
	public int Priority;

	// Token: 0x0400AD16 RID: 44310
	public bool IsEnableStateDirty;

	// Token: 0x0400AD17 RID: 44311
	public ETermExplanationViewStyle Style = ETermExplanationViewStyle.Default;

	// Token: 0x0400AD18 RID: 44312
	public ETermExplanationReportType? ReportType;
}
