using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000FE1 RID: 4065
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchEntityBase
{
	// Token: 0x0600A23B RID: 41531 RVA: 0x002F9F3F File Offset: 0x002F813F
	public FloroRanchEntityBase(FloroRanchPlayUnit entityData)
	{
		this.EntityId = entityData.PlayIncId;
		this.EntityType = (EFloroRanchEntityType)entityData.Type;
	}

	// Token: 0x0600A23C RID: 41532 RVA: 0x002F9F6C File Offset: 0x002F816C
	[NullableContext(0)]
	public unsafe void AddComponent<T>() where T : FloroRanchEntityComponentBase, new()
	{
		int index = FloroRanchEntityComponentIndexGetter<T>.Index;
		if (index < 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.BB;
			string message = "组件未注册, 请检查是否使用在EFloroRanchEntityComponent注册";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entityName", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("componentName", typeof(T).Name);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		if (index >= this.ComponentList.Count)
		{
			for (int i = this.ComponentList.Count; i <= index; i++)
			{
				this.ComponentList.Add(null);
			}
		}
		if (this.ComponentList[index] != null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.FloroRanchGamePlay;
			ELogAuthor author2 = ELogAuthor.BB;
			string message2 = "添加组件失败：组件已存在，请勿重复添加！";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("entityName", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("componentName", typeof(T).Name);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return;
		}
		T t = Activator.CreateInstance<T>();
		t.Create(this);
		this.ComponentList[index] = t;
	}

	// Token: 0x0600A23D RID: 41533 RVA: 0x002FA0C8 File Offset: 0x002F82C8
	public unsafe void AddComponent(Type componentType, Func<FloroRanchEntityComponentBase> ctor)
	{
		int byType = FloroRanchEntityComponentIndexGetter<FloroRanchEntityComponentBase>.GetByType(componentType.Name, false);
		if (byType < 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.BB;
			string message = "组件未注册, 请检查是否使用在EFloroRanchEntityComponent注册";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entityName", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("componentName", componentType.Name);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		if (byType >= this.ComponentList.Count)
		{
			for (int i = this.ComponentList.Count; i <= byType; i++)
			{
				this.ComponentList.Add(null);
			}
		}
		if (this.ComponentList[byType] != null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.FloroRanchGamePlay;
			ELogAuthor author2 = ELogAuthor.BB;
			string message2 = "添加组件失败：组件已存在，请勿重复添加！";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("entityName", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("componentName", componentType.Name);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return;
		}
		FloroRanchEntityComponentBase floroRanchEntityComponentBase = ctor();
		floroRanchEntityComponentBase.Create(this);
		this.ComponentList[byType] = floroRanchEntityComponentBase;
	}

	// Token: 0x0600A23E RID: 41534 RVA: 0x002FA210 File Offset: 0x002F8410
	[NullableContext(0)]
	[return: Nullable(2)]
	public T GetComponent<T>() where T : FloroRanchEntityComponentBase
	{
		int index = FloroRanchEntityComponentIndexGetter<T>.Index;
		return this.ComponentList[index] as T;
	}

	// Token: 0x0600A23F RID: 41535 RVA: 0x002FA23C File Offset: 0x002F843C
	[NullableContext(0)]
	[return: Nullable(2)]
	public unsafe T CheckGetComponent<T>() where T : FloroRanchEntityComponentBase
	{
		T component = this.GetComponent<T>();
		if (component == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.BB;
			string message = "获取组件失败";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entityId", this.EntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("entityName", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("component", FloroRanchEntityComponentIndexGetter<T>.Index);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		return component;
	}

	// Token: 0x0600A240 RID: 41536 RVA: 0x002FA2E8 File Offset: 0x002F84E8
	public List<FloroRanchEntityDataBaseComponent> GetDataComponentList()
	{
		List<FloroRanchEntityDataBaseComponent> list = new List<FloroRanchEntityDataBaseComponent>();
		foreach (FloroRanchEntityComponentBase floroRanchEntityComponentBase in this.ComponentList)
		{
			if (floroRanchEntityComponentBase != null)
			{
				FloroRanchEntityDataBaseComponent floroRanchEntityDataBaseComponent = floroRanchEntityComponentBase as FloroRanchEntityDataBaseComponent;
				if (floroRanchEntityDataBaseComponent != null)
				{
					list.Add(floroRanchEntityDataBaseComponent);
				}
			}
		}
		return list;
	}

	// Token: 0x0600A241 RID: 41537 RVA: 0x002FA350 File Offset: 0x002F8550
	[NullableContext(2)]
	public unsafe FloroRanchUiItemBaseComponent GetUiItemComponent()
	{
		foreach (FloroRanchEntityComponentBase floroRanchEntityComponentBase in this.ComponentList)
		{
			if (floroRanchEntityComponentBase != null)
			{
				FloroRanchUiItemBaseComponent floroRanchUiItemBaseComponent = floroRanchEntityComponentBase as FloroRanchUiItemBaseComponent;
				if (floroRanchUiItemBaseComponent != null)
				{
					return floroRanchUiItemBaseComponent;
				}
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.FloroRanchGamePlay;
		ELogAuthor author = ELogAuthor.BB;
		string message = "获取组件失败";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entityId", this.EntityId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("entityName", base.GetType().Name);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("component", "FloroRanchUiItemBaseComponent");
		instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		return null;
	}

	// Token: 0x0600A242 RID: 41538 RVA: 0x002FA43C File Offset: 0x002F863C
	public void Init()
	{
		foreach (FloroRanchEntityComponentBase floroRanchEntityComponentBase in this.ComponentList)
		{
			if (floroRanchEntityComponentBase != null)
			{
				floroRanchEntityComponentBase.Init();
			}
		}
	}

	// Token: 0x0600A243 RID: 41539 RVA: 0x002FA494 File Offset: 0x002F8694
	public void Tick(float deltaTime)
	{
		foreach (FloroRanchEntityComponentBase floroRanchEntityComponentBase in this.ComponentList)
		{
			if (floroRanchEntityComponentBase != null)
			{
				floroRanchEntityComponentBase.Tick(deltaTime);
			}
		}
	}

	// Token: 0x0600A244 RID: 41540 RVA: 0x002FA4EC File Offset: 0x002F86EC
	public void End()
	{
		foreach (FloroRanchEntityComponentBase floroRanchEntityComponentBase in this.ComponentList)
		{
			if (floroRanchEntityComponentBase != null)
			{
				floroRanchEntityComponentBase.End();
			}
		}
	}

	// Token: 0x0600A245 RID: 41541 RVA: 0x002FA544 File Offset: 0x002F8744
	public void RefreshEntityData(FloroRanchPlayUnit entityData)
	{
		foreach (FloroRanchEntityDataBaseComponent floroRanchEntityDataBaseComponent in this.GetDataComponentList())
		{
			floroRanchEntityDataBaseComponent.RefreshEntityData(entityData);
		}
	}

	// Token: 0x0600A246 RID: 41542 RVA: 0x002FA598 File Offset: 0x002F8798
	public int GetPoint()
	{
		FloroRanchEntityDataComponent floroRanchEntityDataComponent = this.CheckGetComponent<FloroRanchEntityDataComponent>();
		if (floroRanchEntityDataComponent == null)
		{
			return -1;
		}
		return floroRanchEntityDataComponent.Point;
	}

	// Token: 0x0600A247 RID: 41543 RVA: 0x002FA5B8 File Offset: 0x002F87B8
	public int GetRarity()
	{
		int result = -1;
		EFloroRanchEntityType entityType = this.EntityType;
		if (entityType != EFloroRanchEntityType.Card)
		{
			if (entityType == EFloroRanchEntityType.Toy)
			{
				FloroRanchToyDataComponent floroRanchToyDataComponent = this.CheckGetComponent<FloroRanchToyDataComponent>();
				if (floroRanchToyDataComponent != null && floroRanchToyDataComponent.ToyData != null)
				{
					result = floroRanchToyDataComponent.ToyData.GetRarity();
				}
			}
		}
		else
		{
			FloroRanchCardDataComponent floroRanchCardDataComponent = this.CheckGetComponent<FloroRanchCardDataComponent>();
			if (floroRanchCardDataComponent != null && floroRanchCardDataComponent.CardData != null)
			{
				result = floroRanchCardDataComponent.CardData.GetRarity();
			}
		}
		return result;
	}

	// Token: 0x0600A248 RID: 41544 RVA: 0x002FA618 File Offset: 0x002F8818
	public int GetRace()
	{
		int result = -1;
		EFloroRanchEntityType entityType = this.EntityType;
		if (entityType != EFloroRanchEntityType.Card)
		{
			if (entityType == EFloroRanchEntityType.Toy)
			{
				FloroRanchToyDataComponent floroRanchToyDataComponent = this.CheckGetComponent<FloroRanchToyDataComponent>();
				if (floroRanchToyDataComponent != null && floroRanchToyDataComponent.ToyData != null)
				{
					result = floroRanchToyDataComponent.ToyData.GetRace();
				}
			}
		}
		else
		{
			FloroRanchCardDataComponent floroRanchCardDataComponent = this.CheckGetComponent<FloroRanchCardDataComponent>();
			if (floroRanchCardDataComponent != null && floroRanchCardDataComponent.CardData != null)
			{
				result = floroRanchCardDataComponent.CardData.GetRace();
			}
		}
		return result;
	}

	// Token: 0x0600A249 RID: 41545 RVA: 0x002FA678 File Offset: 0x002F8878
	public string Info()
	{
		List<FloroRanchEntityDataBaseComponent> dataComponentList = this.GetDataComponentList();
		List<string> list = new List<string>();
		for (int i = dataComponentList.Count - 1; i >= 0; i--)
		{
			FloroRanchEntityDataBaseComponent floroRanchEntityDataBaseComponent = dataComponentList[i];
			list.Add(floroRanchEntityDataBaseComponent.Info());
		}
		return string.Join(" ", list);
	}

	// Token: 0x0600A24A RID: 41546 RVA: 0x002FA6C4 File Offset: 0x002F88C4
	public string DebugInfo()
	{
		List<FloroRanchEntityDataBaseComponent> dataComponentList = this.GetDataComponentList();
		List<string> list = new List<string>();
		foreach (FloroRanchEntityDataBaseComponent floroRanchEntityDataBaseComponent in dataComponentList)
		{
			list.Add(floroRanchEntityDataBaseComponent.DebugInfo());
		}
		string str = string.Join(" ", list);
		return "<color=Orange>【" + str + "】</color>";
	}

	// Token: 0x0600A24B RID: 41547 RVA: 0x002FA740 File Offset: 0x002F8940
	public string DebugUiShowInfo()
	{
		List<FloroRanchEntityDataBaseComponent> dataComponentList = this.GetDataComponentList();
		List<string> list = new List<string>();
		foreach (FloroRanchEntityDataBaseComponent floroRanchEntityDataBaseComponent in dataComponentList)
		{
			list.Add(floroRanchEntityDataBaseComponent.DebugInfo());
		}
		string str = string.Join("\n", list);
		return "<color=Red>" + str + "</color>";
	}

	// Token: 0x04005F3D RID: 24381
	public readonly int EntityId;

	// Token: 0x04005F3E RID: 24382
	public readonly EFloroRanchEntityType EntityType;

	// Token: 0x04005F3F RID: 24383
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly List<FloroRanchEntityComponentBase> ComponentList = new List<FloroRanchEntityComponentBase>();
}
