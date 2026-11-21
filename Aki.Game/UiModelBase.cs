using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200221D RID: 8733
[NullableContext(1)]
[Nullable(0)]
public class UiModelBase
{
	// Token: 0x060157BA RID: 87994 RVA: 0x0063D3A4 File Offset: 0x0063B5A4
	public UiModelBase(int id, EUiModelUseWay useWay)
	{
		this.Id = id;
		this.UseWay = useWay;
	}

	// Token: 0x060157BB RID: 87995 RVA: 0x0063D3FC File Offset: 0x0063B5FC
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

	// Token: 0x060157BC RID: 87996 RVA: 0x0063D438 File Offset: 0x0063B638
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

	// Token: 0x060157BD RID: 87997 RVA: 0x0063D4B0 File Offset: 0x0063B6B0
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

	// Token: 0x060157BE RID: 87998 RVA: 0x0063D55C File Offset: 0x0063B75C
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

	// Token: 0x060157BF RID: 87999 RVA: 0x0063D660 File Offset: 0x0063B860
	public void Init()
	{
		foreach (KeyValuePair<Type, UiModelComponentBase> keyValuePair in this.ComponentMap)
		{
			keyValuePair.Value.Init();
		}
	}

	// Token: 0x060157C0 RID: 88000 RVA: 0x0063D6B8 File Offset: 0x0063B8B8
	public void Start()
	{
		foreach (KeyValuePair<Type, UiModelComponentBase> keyValuePair in this.ComponentMap)
		{
			keyValuePair.Value.Start();
		}
	}

	// Token: 0x060157C1 RID: 88001 RVA: 0x0063D710 File Offset: 0x0063B910
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

	// Token: 0x060157C2 RID: 88002 RVA: 0x0063D778 File Offset: 0x0063B978
	public void End()
	{
		foreach (KeyValuePair<Type, UiModelComponentBase> keyValuePair in this.ComponentMap)
		{
			keyValuePair.Value.End();
		}
	}

	// Token: 0x060157C3 RID: 88003 RVA: 0x0063D7D0 File Offset: 0x0063B9D0
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

	// Token: 0x060157C4 RID: 88004 RVA: 0x0063D84C File Offset: 0x0063BA4C
	public void OnVisibleChange(bool visible)
	{
		this.VisibleComponents.ForEach(delegate(IUiModelVisible c)
		{
			c.OnModelVisibleChange(visible);
		});
	}

	// Token: 0x060157C5 RID: 88005 RVA: 0x0063D880 File Offset: 0x0063BA80
	public void OnSetDitherEffect(float value)
	{
		this.DitherComponents.ForEach(delegate(IUiModelSetDitherEffect c)
		{
			c.OnModelDitherEffectChange(value);
		});
	}

	// Token: 0x060157C6 RID: 88006 RVA: 0x0063D8B4 File Offset: 0x0063BAB4
	public void OnPlanarReflectionRenderOffsetChange(bool enable, FVector? offset)
	{
		this.PlanarReflectionRenderOffsetComponents.ForEach(delegate(IUiModelSetPlanarReflectionRenderOffset c)
		{
			c.OnModelPlanarReflectionRenderOffsetChange(enable, offset);
		});
	}

	// Token: 0x060157C7 RID: 88007 RVA: 0x0063D8EC File Offset: 0x0063BAEC
	public void OnRenderingMaterialAdd(int materialId, UObject data, bool isGroup, bool withAnimObject)
	{
		this.RenderingMaterialChangeComponents.ForEach(delegate(IUiModelRenderingMaterialChange c)
		{
			c.OnRenderingMaterialAdd(materialId, data, isGroup, withAnimObject);
		});
	}

	// Token: 0x060157C8 RID: 88008 RVA: 0x0063D934 File Offset: 0x0063BB34
	public void OnRenderingMaterialRemove(int materialId, bool isGroup, bool withAnimObject)
	{
		this.RenderingMaterialChangeComponents.ForEach(delegate(IUiModelRenderingMaterialChange c)
		{
			c.OnRenderingMaterialRemove(materialId, isGroup, withAnimObject);
		});
	}

	// Token: 0x0400B5E9 RID: 46569
	private readonly OrderedDictionary<Type, UiModelComponentBase> ComponentMap = new OrderedDictionary<Type, UiModelComponentBase>();

	// Token: 0x0400B5EA RID: 46570
	public readonly EUiModelUseWay UseWay;

	// Token: 0x0400B5EB RID: 46571
	public readonly int Id;

	// Token: 0x0400B5EC RID: 46572
	private readonly List<IUiModelVisible> VisibleComponents = new List<IUiModelVisible>();

	// Token: 0x0400B5ED RID: 46573
	private readonly List<IUiModelSetDitherEffect> DitherComponents = new List<IUiModelSetDitherEffect>();

	// Token: 0x0400B5EE RID: 46574
	private readonly List<IUiModelRenderingMaterialChange> RenderingMaterialChangeComponents = new List<IUiModelRenderingMaterialChange>();

	// Token: 0x0400B5EF RID: 46575
	private readonly List<IUiModelSetPlanarReflectionRenderOffset> PlanarReflectionRenderOffsetComponents = new List<IUiModelSetPlanarReflectionRenderOffset>();
}
