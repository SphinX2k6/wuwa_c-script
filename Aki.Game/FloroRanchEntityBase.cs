using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001B22 RID: 6946
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchEntityBase
{
	// Token: 0x0600CE2A RID: 52778 RVA: 0x002EEE5F File Offset: 0x002ED05F
	public FloroRanchEntityBase(FloroRanchPlayUnit entityData)
	{
		this.EntityId = entityData.PlayIncId;
		this.EntityType = (EFloroRanchEntityType)entityData.Type;
	}

	// Token: 0x0600CE2B RID: 52779 RVA: 0x002EEE8C File Offset: 0x002ED08C
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

	// Token: 0x0600CE2C RID: 52780 RVA: 0x002EEFE8 File Offset: 0x002ED1E8
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

	// Token: 0x0600CE2D RID: 52781 RVA: 0x002EF130 File Offset: 0x002ED330
	[NullableContext(0)]
	[return: Nullable(2)]
	public T GetComponent<T>() where T : FloroRanchEntityComponentBase
	{
		int index = FloroRanchEntityComponentIndexGetter<T>.Index;
		return this.ComponentList[index] as T;
	}

	// Token: 0x0600CE2E RID: 52782 RVA: 0x002EF15C File Offset: 0x002ED35C
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

	// Token: 0x0600CE2F RID: 52783 RVA: 0x002EF208 File Offset: 0x002ED408
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

	// Token: 0x0600CE30 RID: 52784 RVA: 0x002EF270 File Offset: 0x002ED470
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

	// Token: 0x0600CE31 RID: 52785 RVA: 0x002EF35C File Offset: 0x002ED55C
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

	// Token: 0x0600CE32 RID: 52786 RVA: 0x002EF3B4 File Offset: 0x002ED5B4
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

	// Token: 0x0600CE33 RID: 52787 RVA: 0x002EF40C File Offset: 0x002ED60C
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

	// Token: 0x0600CE34 RID: 52788 RVA: 0x002EF464 File Offset: 0x002ED664
	public void RefreshEntityData(FloroRanchPlayUnit entityData)
	{
		foreach (FloroRanchEntityDataBaseComponent floroRanchEntityDataBaseComponent in this.GetDataComponentList())
		{
			floroRanchEntityDataBaseComponent.RefreshEntityData(entityData);
		}
	}

	// Token: 0x0600CE35 RID: 52789 RVA: 0x002EF4B8 File Offset: 0x002ED6B8
	public int GetPoint()
	{
		FloroRanchEntityDataComponent floroRanchEntityDataComponent = this.CheckGetComponent<FloroRanchEntityDataComponent>();
		if (floroRanchEntityDataComponent == null)
		{
			return -1;
		}
		return floroRanchEntityDataComponent.Point;
	}

	// Token: 0x0600CE36 RID: 52790 RVA: 0x002EF4D8 File Offset: 0x002ED6D8
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

	// Token: 0x0600CE37 RID: 52791 RVA: 0x002EF538 File Offset: 0x002ED738
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

	// Token: 0x0600CE38 RID: 52792 RVA: 0x002EF598 File Offset: 0x002ED798
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

	// Token: 0x0600CE39 RID: 52793 RVA: 0x002EF5E4 File Offset: 0x002ED7E4
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

	// Token: 0x0600CE3A RID: 52794 RVA: 0x002EF660 File Offset: 0x002ED860
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

	// Token: 0x04005E6E RID: 24174
	public readonly int EntityId;

	// Token: 0x04005E6F RID: 24175
	public readonly EFloroRanchEntityType EntityType;

	// Token: 0x04005E70 RID: 24176
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly List<FloroRanchEntityComponentBase> ComponentList = new List<FloroRanchEntityComponentBase>();
}
