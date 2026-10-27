using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002FC9 RID: 12233
public class GameplayCueMaterial : GameplayCueMagnitude
{
	// Token: 0x06019EEB RID: 106219 RVA: 0x006C8973 File Offset: 0x006C6B73
	protected override void OnInit()
	{
		base.OnInit();
		this.Resource = null;
	}

	// Token: 0x06019EEC RID: 106220 RVA: 0x006C8982 File Offset: 0x006C6B82
	protected override void OnTick(float delta)
	{
		base.OnTick(delta);
	}

	// Token: 0x06019EED RID: 106221 RVA: 0x006C898B File Offset: 0x006C6B8B
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

	// Token: 0x06019EEE RID: 106222 RVA: 0x006C89B1 File Offset: 0x006C6BB1
	protected override void OnDestroy()
	{
		this.Resource = null;
		base.OnDestroy();
		this.RemoveMaterialController();
		this.OnMaterialEnd(this.MaterialId);
	}

	// Token: 0x06019EEF RID: 106223 RVA: 0x006C89D4 File Offset: 0x006C6BD4
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

	// Token: 0x06019EF0 RID: 106224 RVA: 0x006C8A72 File Offset: 0x006C6C72
	protected override void OnSetMagnitude(float normalizedValue)
	{
		base.GetCharRenderingComponent().SetEffectProgress(normalizedValue, this.MaterialId);
	}

	// Token: 0x06019EF1 RID: 106225 RVA: 0x006C8A86 File Offset: 0x006C6C86
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

	// Token: 0x06019EF2 RID: 106226 RVA: 0x006C8ABC File Offset: 0x006C6CBC
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

	// Token: 0x06019EF3 RID: 106227 RVA: 0x006C8BCC File Offset: 0x006C6DCC
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

	// Token: 0x06019EF4 RID: 106228 RVA: 0x006C8C40 File Offset: 0x006C6E40
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

	// Token: 0x06019EF5 RID: 106229 RVA: 0x006C8CE2 File Offset: 0x006C6EE2
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

	// Token: 0x0400C445 RID: 50245
	private int MaterialId = -1;

	// Token: 0x0400C446 RID: 50246
	private EMaterial MaterialType;

	// Token: 0x0400C447 RID: 50247
	[Nullable(2)]
	private UObject Resource;

	// Token: 0x0400C448 RID: 50248
	private bool InChangeRole;
}
