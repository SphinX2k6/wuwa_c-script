using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002CC4 RID: 11460
[NullableContext(1)]
[Nullable(0)]
public class UiModelBase
{
	// Token: 0x06017F41 RID: 98113 RVA: 0x006176E4 File Offset: 0x006158E4
	public UiModelBase(int id, EUiModelUseWay useWay)
	{
		this.Id = id;
		this.UseWay = useWay;
	}

	// Token: 0x06017F42 RID: 98114 RVA: 0x0061773C File Offset: 0x0061593C
	[NullableContext(0)]
	[return: Nullable(2)]
	public T GetComponent<T>() where T : UiModelComponentBase
	{
		UiModelComponentBase uiModelComponentBase;
		if (this.ComponentMap.TryGetValue(typeof(T), out uiModelComponentBase))
		{
			return uiModelComponentBase as T;
		}
		return default(T);
	}

	// Token: 0x06017F43 RID: 98115 RVA: 0x00617778 File Offset: 0x00615978
	[NullableContext(0)]
	[return: Nullable(2)]
	public T GetComponentByCtor<T>() where T : UiModelComponentBase
	{
		foreach (KeyValuePair<Type, UiModelComponentBase> keyValuePair in this.ComponentMap)
		{
			T t = keyValuePair.Value as T;
			if (t != null)
			{
				return t;
			}
		}
		return default(T);
	}

	// Token: 0x06017F44 RID: 98116 RVA: 0x006177F0 File Offset: 0x006159F0
	[NullableContext(0)]
	[return: Nullable(2)]
	public unsafe T CheckGetComponent<T>() where T : UiModelComponentBase
	{
		T component = this.GetComponent<T>();
		if (component == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "获取组件失败";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("uiModelName", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("component", typeof(T).Name);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		return component;
	}

	// Token: 0x06017F45 RID: 98117 RVA: 0x0061789C File Offset: 0x00615A9C
	public unsafe void AddComponent(Type componentType)
	{
		if (this.ComponentMap.ContainsKey(componentType))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiComponent;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "添加组件失败：组件已存在，请勿重复添加！";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("uiModelName", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("componentName", componentType.Name);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		UiModelComponentHandler uiModelComponentHandler;
		if (UiModelComponentDefine.Handlers.TryGetValue(componentType, out uiModelComponentHandler))
		{
			UiModelComponentBase uiModelComponentBase = uiModelComponentHandler(this);
			this.ComponentMap[componentType] = uiModelComponentBase;
			IUiModelVisible uiModelVisible = uiModelComponentBase as IUiModelVisible;
			if (uiModelVisible != null)
			{
				this.VisibleComponents.Add(uiModelVisible);
			}
			IUiModelSetDitherEffect uiModelSetDitherEffect = uiModelComponentBase as IUiModelSetDitherEffect;
			if (uiModelSetDitherEffect != null)
			{
				this.DitherComponents.Add(uiModelSetDitherEffect);
			}
			IUiModelRenderingMaterialChange uiModelRenderingMaterialChange = uiModelComponentBase as IUiModelRenderingMaterialChange;
			if (uiModelRenderingMaterialChange != null)
			{
				this.RenderingMaterialChangeComponents.Add(uiModelRenderingMaterialChange);
			}
			IUiModelSetPlanarReflectionRenderOffset uiModelSetPlanarReflectionRenderOffset = uiModelComponentBase as IUiModelSetPlanarReflectionRenderOffset;
			if (uiModelSetPlanarReflectionRenderOffset != null)
			{
				this.PlanarReflectionRenderOffsetComponents.Add(uiModelSetPlanarReflectionRenderOffset);
			}
		}
	}

	// Token: 0x06017F46 RID: 98118 RVA: 0x006179A0 File Offset: 0x00615BA0
	public void Init()
	{
		foreach (KeyValuePair<Type, UiModelComponentBase> keyValuePair in this.ComponentMap)
		{
			keyValuePair.Value.Init();
		}
	}

	// Token: 0x06017F47 RID: 98119 RVA: 0x006179F8 File Offset: 0x00615BF8
	public void Start()
	{
		foreach (KeyValuePair<Type, UiModelComponentBase> keyValuePair in this.ComponentMap)
		{
			keyValuePair.Value.Start();
		}
	}

	// Token: 0x06017F48 RID: 98120 RVA: 0x00617A50 File Offset: 0x00615C50
	public void Tick(float deltaTime)
	{
		foreach (KeyValuePair<Type, UiModelComponentBase> keyValuePair in this.ComponentMap)
		{
			if (keyValuePair.Value.NeedTick)
			{
				keyValuePair.Value.Tick(deltaTime);
			}
		}
	}

	// Token: 0x06017F49 RID: 98121 RVA: 0x00617AB8 File Offset: 0x00615CB8
	public void End()
	{
		foreach (KeyValuePair<Type, UiModelComponentBase> keyValuePair in this.ComponentMap)
		{
			keyValuePair.Value.End();
		}
	}

	// Token: 0x06017F4A RID: 98122 RVA: 0x00617B10 File Offset: 0x00615D10
	public void Clear()
	{
		foreach (KeyValuePair<Type, UiModelComponentBase> keyValuePair in this.ComponentMap)
		{
			keyValuePair.Value.Clear();
		}
		this.VisibleComponents.Clear();
		this.DitherComponents.Clear();
		this.PlanarReflectionRenderOffsetComponents.Clear();
	}

	// Token: 0x06017F4B RID: 98123 RVA: 0x00617B8C File Offset: 0x00615D8C
	public void OnVisibleChange(bool visible)
	{
		this.VisibleComponents.ForEach(delegate(IUiModelVisible c)
		{
			c.OnModelVisibleChange(visible);
		});
	}

	// Token: 0x06017F4C RID: 98124 RVA: 0x00617BC0 File Offset: 0x00615DC0
	public void OnSetDitherEffect(float value)
	{
		this.DitherComponents.ForEach(delegate(IUiModelSetDitherEffect c)
		{
			c.OnModelDitherEffectChange(value);
		});
	}

	// Token: 0x06017F4D RID: 98125 RVA: 0x00617BF4 File Offset: 0x00615DF4
	public void OnPlanarReflectionRenderOffsetChange(bool enable, FVector? offset)
	{
		this.PlanarReflectionRenderOffsetComponents.ForEach(delegate(IUiModelSetPlanarReflectionRenderOffset c)
		{
			c.OnModelPlanarReflectionRenderOffsetChange(enable, offset);
		});
	}

	// Token: 0x06017F4E RID: 98126 RVA: 0x00617C2C File Offset: 0x00615E2C
	public void OnRenderingMaterialAdd(int materialId, UObject data, bool isGroup, bool withAnimObject)
	{
		this.RenderingMaterialChangeComponents.ForEach(delegate(IUiModelRenderingMaterialChange c)
		{
			c.OnRenderingMaterialAdd(materialId, data, isGroup, withAnimObject);
		});
	}

	// Token: 0x06017F4F RID: 98127 RVA: 0x00617C74 File Offset: 0x00615E74
	public void OnRenderingMaterialRemove(int materialId, bool isGroup, bool withAnimObject)
	{
		this.RenderingMaterialChangeComponents.ForEach(delegate(IUiModelRenderingMaterialChange c)
		{
			c.OnRenderingMaterialRemove(materialId, isGroup, withAnimObject);
		});
	}

	// Token: 0x0400B27E RID: 45694
	private readonly OrderedDictionary<Type, UiModelComponentBase> ComponentMap = new OrderedDictionary<Type, UiModelComponentBase>();

	// Token: 0x0400B27F RID: 45695
	public readonly EUiModelUseWay UseWay;

	// Token: 0x0400B280 RID: 45696
	public readonly int Id;

	// Token: 0x0400B281 RID: 45697
	private readonly List<IUiModelVisible> VisibleComponents = new List<IUiModelVisible>();

	// Token: 0x0400B282 RID: 45698
	private readonly List<IUiModelSetDitherEffect> DitherComponents = new List<IUiModelSetDitherEffect>();

	// Token: 0x0400B283 RID: 45699
	private readonly List<IUiModelRenderingMaterialChange> RenderingMaterialChangeComponents = new List<IUiModelRenderingMaterialChange>();

	// Token: 0x0400B284 RID: 45700
	private readonly List<IUiModelSetPlanarReflectionRenderOffset> PlanarReflectionRenderOffsetComponents = new List<IUiModelSetPlanarReflectionRenderOffset>();
}
