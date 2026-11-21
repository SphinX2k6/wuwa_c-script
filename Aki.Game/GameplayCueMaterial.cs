using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x0200251D RID: 9501
public class GameplayCueMaterial : GameplayCueMagnitude
{
	// Token: 0x060177FD RID: 96253 RVA: 0x006EF247 File Offset: 0x006ED447
	protected override void OnInit()
	{
		base.OnInit();
		this.Resource = null;
	}

	// Token: 0x060177FE RID: 96254 RVA: 0x006EF256 File Offset: 0x006ED456
	protected override void OnTick(float delta)
	{
		base.OnTick(delta);
	}

	// Token: 0x060177FF RID: 96255 RVA: 0x006EF25F File Offset: 0x006ED45F
	protected override void OnCreate()
	{
		ResourceSystem.Instance.LoadAsync<UObject>(base.GetPath(), delegate([Nullable(2)] UObject res, string _)
		{
			if (!this.IsActive)
			{
				return;
			}
			Action beginCallback = this.BeginCallback;
			if (beginCallback != null)
			{
				beginCallback();
			}
			this.Resource = res;
			this.AddMaterial();
			this.AddFinishCallback();
			base.OnCreate();
		}, 100, "js_undefined");
	}

	// Token: 0x06017800 RID: 96256 RVA: 0x006EF285 File Offset: 0x006ED485
	protected override void OnDestroy()
	{
		this.Resource = null;
		base.OnDestroy();
		this.RemoveMaterialController();
		this.OnMaterialEnd(this.MaterialId);
	}

	// Token: 0x06017801 RID: 96257 RVA: 0x006EF2A8 File Offset: 0x006ED4A8
	private void RemoveMaterialController()
	{
		if (this.MaterialId < 0)
		{
			return;
		}
		CharRenderingComponent charRenderingComponent = base.GetCharRenderingComponent();
		if (charRenderingComponent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.WWJ;
			string message = "RemoveMaterialController CharRenderingComponent为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", this.CueConfig.Id);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.MaterialId = -1;
			return;
		}
		charRenderingComponent.SetEffectPause(this.MaterialId, false);
		EMaterial materialType = this.MaterialType;
		if (materialType != EMaterial.Data)
		{
			if (materialType == EMaterial.DataGroup)
			{
				charRenderingComponent.RemoveMaterialControllerDataGroupWithEnding(this.MaterialId);
			}
		}
		else
		{
			charRenderingComponent.RemoveMaterialControllerDataWithEnding(this.MaterialId);
		}
		this.MaterialId = -1;
	}

	// Token: 0x06017802 RID: 96258 RVA: 0x006EF346 File Offset: 0x006ED546
	protected override void OnSetMagnitude(float normalizedValue)
	{
		base.GetCharRenderingComponent().SetEffectProgress(normalizedValue, this.MaterialId);
	}

	// Token: 0x06017803 RID: 96259 RVA: 0x006EF35A File Offset: 0x006ED55A
	[NullableContext(1)]
	public override void OnChangeRole(EntityHandle newEntityHandle)
	{
		this.InChangeRole = true;
		if (this.Resource != null && this.MaterialId != -1)
		{
			this.RemoveMaterialController();
		}
		this.InChangeRole = false;
		base.OnChangeRole(newEntityHandle);
		this.AddMaterial();
	}

	// Token: 0x06017804 RID: 96260 RVA: 0x006EF390 File Offset: 0x006ED590
	private unsafe void AddMaterial()
	{
		if (!this.ActorInternal.IsValid() || this.Resource == null)
		{
			return;
		}
		UObject resource = this.Resource;
		CharRenderingComponent charRenderingComponent = base.GetCharRenderingComponent();
		switch (GameplayCueController.GetMaterialType(resource))
		{
		case EMaterial.Other:
		{
			this.MaterialType = EMaterial.Other;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.HXY;
			string message = "附加材质类型错误:";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Buff特效Id", this.CueConfig.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("材质路径", this.CueConfig.Path);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			break;
		}
		case EMaterial.Data:
			this.MaterialType = EMaterial.Data;
			this.MaterialId = charRenderingComponent.AddMaterialControllerData(resource);
			break;
		case EMaterial.DataGroup:
			this.MaterialType = EMaterial.DataGroup;
			this.MaterialId = charRenderingComponent.AddMaterialControllerDataGroup(resource);
			break;
		}
		if (this.MaterialId >= 0 && this.UseMagnitude())
		{
			charRenderingComponent.SetEffectPause(this.MaterialId, true);
		}
	}

	// Token: 0x06017805 RID: 96261 RVA: 0x006EF4A0 File Offset: 0x006ED6A0
	private void AddFinishCallback()
	{
		if (this.EndCallback != null && !this.IsInstant)
		{
			EMaterial materialType = this.MaterialType;
			if (materialType == EMaterial.Data)
			{
				EventSystem.Instance.AddWithTarget(base.GetCharRenderingComponent(), EEventName.OnRemoveMaterialController, new Action<int>(this.OnMaterialEnd));
				return;
			}
			if (materialType != EMaterial.DataGroup)
			{
				return;
			}
			EventSystem.Instance.AddWithTarget(base.GetCharRenderingComponent(), EEventName.OnRemoveMaterialControllerGroup, new Action<int>(this.OnMaterialEnd));
		}
	}

	// Token: 0x06017806 RID: 96262 RVA: 0x006EF514 File Offset: 0x006ED714
	private void RemoveFinishCallback()
	{
		EMaterial materialType = this.MaterialType;
		if (materialType != EMaterial.Data)
		{
			if (materialType != EMaterial.DataGroup)
			{
				return;
			}
			CharRenderingComponent charRenderingComponent = base.GetCharRenderingComponent();
			if (EventSystem.Instance.HasWithTarget<int>(charRenderingComponent, EEventName.OnRemoveMaterialControllerGroup, new Action<int>(this.OnMaterialEnd)))
			{
				EventSystem.Instance.RemoveWithTarget<int>(charRenderingComponent, EEventName.OnRemoveMaterialControllerGroup, new Action<int>(this.OnMaterialEnd));
			}
		}
		else
		{
			CharRenderingComponent charRenderingComponent2 = base.GetCharRenderingComponent();
			if (EventSystem.Instance.HasWithTarget<int>(charRenderingComponent2, EEventName.OnRemoveMaterialController, new Action<int>(this.OnMaterialEnd)))
			{
				EventSystem.Instance.RemoveWithTarget<int>(charRenderingComponent2, EEventName.OnRemoveMaterialController, new Action<int>(this.OnMaterialEnd));
				return;
			}
		}
	}

	// Token: 0x06017807 RID: 96263 RVA: 0x006EF5B6 File Offset: 0x006ED7B6
	private void OnMaterialEnd(int mId)
	{
		if (mId == this.MaterialId && this.EndCallback != null && !this.InChangeRole)
		{
			this.RemoveFinishCallback();
			Action endCallback = this.EndCallback;
			this.EndCallback = null;
			endCallback();
		}
	}

	// Token: 0x0400C7EE RID: 51182
	private int MaterialId = -1;

	// Token: 0x0400C7EF RID: 51183
	private EMaterial MaterialType;

	// Token: 0x0400C7F0 RID: 51184
	[Nullable(2)]
	private UObject Resource;

	// Token: 0x0400C7F1 RID: 51185
	private bool InChangeRole;
}
