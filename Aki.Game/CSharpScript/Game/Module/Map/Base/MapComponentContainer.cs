using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Misc;

namespace CSharpScript.Game.Module.Map.Base
{
	// Token: 0x02005597 RID: 21911
	public class MapComponentContainer
	{
		// Token: 0x06037D9E RID: 228766 RVA: 0x00D3C784 File Offset: 0x00D3A984
		[return: Nullable(2)]
		public T AddComponent<T>(EMapComponent componentType, [Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity>? parent = null) where T : MapComponent
		{
			OneOf<MapComponent, MapComponentContainer, MapEntity> oneOf = parent ?? this;
			T t = (T)((object)Activator.CreateInstance(typeof(T), new object[]
			{
				oneOf
			}));
			if (t != null && this.AddInternal(componentType, t))
			{
				return t;
			}
			return default(T);
		}

		// Token: 0x06037D9F RID: 228767 RVA: 0x00D3C7F4 File Offset: 0x00D3A9F4
		[NullableContext(1)]
		private bool AddInternal(EMapComponent componentType, MapComponent component)
		{
			int componentId = component.ComponentId;
			if (!this.ComponentIdMap.TryAdd(componentId, component))
			{
				object key = componentId;
				ELogAuthor author = ELogAuthor.LYX;
				string message = "[世界地图]MapComponentContainer.AddInternal->添加组件失败，重复组件Id";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("componentId", componentId);
				MapLogger.WarnOnce(key, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			List<MapComponent> list = this.ComponentTypeArray[(int)componentType];
			if (list == null)
			{
				list = new List<MapComponent>(4);
				this.ComponentTypeArray[(int)componentType] = list;
			}
			list.Add(component);
			component.Add();
			component.Enable = true;
			return true;
		}

		// Token: 0x06037DA0 RID: 228768 RVA: 0x00D3C878 File Offset: 0x00D3AA78
		[return: Nullable(2)]
		public T GetComponent<T>(EMapComponent componentType) where T : MapComponent
		{
			List<MapComponent> list = this.ComponentTypeArray[(int)componentType];
			if (list == null || list.Count == 0)
			{
				return default(T);
			}
			T t = list[0] as T;
			if (t != null)
			{
				return t;
			}
			for (int i = 1; i < list.Count; i++)
			{
				T t2 = list[i] as T;
				if (t2 != null)
				{
					return t2;
				}
			}
			return default(T);
		}

		// Token: 0x06037DA1 RID: 228769 RVA: 0x00D3C8F8 File Offset: 0x00D3AAF8
		public void RemoveComponent(EMapComponent componentType)
		{
			List<MapComponent> list = this.ComponentTypeArray[(int)componentType];
			if (list == null || list.Count == 0)
			{
				return;
			}
			for (int i = list.Count - 1; i >= 0; i--)
			{
				MapComponent mapComponent = list[i];
				this.ComponentIdMap.Remove(mapComponent.ComponentId);
				mapComponent.Enable = false;
				mapComponent.Remove();
			}
			list.Clear();
		}

		// Token: 0x06037DA2 RID: 228770 RVA: 0x00D3C95C File Offset: 0x00D3AB5C
		public void RemoveById(int componentId)
		{
			MapComponent mapComponent;
			if (!this.ComponentIdMap.Remove(componentId, out mapComponent))
			{
				return;
			}
			int componentType = (int)mapComponent.ComponentType;
			List<MapComponent> list = this.ComponentTypeArray[componentType];
			if (list != null)
			{
				int num = -1;
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i] == mapComponent)
					{
						num = i;
						break;
					}
				}
				if (num >= 0)
				{
					int num2 = list.Count - 1;
					if (num < num2)
					{
						list[num] = list[num2];
					}
					list.RemoveAt(num2);
				}
			}
			mapComponent.Enable = false;
			mapComponent.Remove();
		}

		// Token: 0x06037DA3 RID: 228771 RVA: 0x00D3C9EC File Offset: 0x00D3ABEC
		public void RemoveAll()
		{
			foreach (MapComponent mapComponent in this.ComponentIdMap.Values)
			{
				mapComponent.Enable = false;
				mapComponent.Remove();
			}
			this.ComponentIdMap.Clear();
			for (int i = 0; i < 21; i++)
			{
				List<MapComponent> list = this.ComponentTypeArray[i];
				if (list != null)
				{
					list.Clear();
				}
			}
		}

		// Token: 0x06037DA4 RID: 228772 RVA: 0x00D3CA74 File Offset: 0x00D3AC74
		public void Init()
		{
			this.TickSnapshot.Clear();
			this.TickSnapshot.AddRange(this.ComponentIdMap.Values);
			for (int i = 0; i < this.TickSnapshot.Count; i++)
			{
				this.TickSnapshot[i].Init();
			}
			this.TickSnapshot.Clear();
		}

		// Token: 0x06037DA5 RID: 228773 RVA: 0x00D3CAD4 File Offset: 0x00D3ACD4
		public void Tick(float delta)
		{
			this.TickSnapshot.Clear();
			this.TickSnapshot.AddRange(this.ComponentIdMap.Values);
			for (int i = 0; i < this.TickSnapshot.Count; i++)
			{
				this.TickSnapshot[i].Tick(delta);
			}
			this.TickSnapshot.Clear();
		}

		// Token: 0x06037DA6 RID: 228774 RVA: 0x00D3CB38 File Offset: 0x00D3AD38
		public void Update()
		{
			this.TickSnapshot.Clear();
			this.TickSnapshot.AddRange(this.ComponentIdMap.Values);
			for (int i = 0; i < this.TickSnapshot.Count; i++)
			{
				this.TickSnapshot[i].Update();
			}
			this.TickSnapshot.Clear();
		}

		// Token: 0x0401D57B RID: 120187
		private const int COMPONENT_TYPE_COUNT = 21;

		// Token: 0x0401D57C RID: 120188
		[Nullable(1)]
		private readonly Dictionary<int, MapComponent> ComponentIdMap = new Dictionary<int, MapComponent>();

		// Token: 0x0401D57D RID: 120189
		[Nullable(new byte[]
		{
			1,
			2,
			1
		})]
		private readonly List<MapComponent>[] ComponentTypeArray = new List<MapComponent>[21];

		// Token: 0x0401D57E RID: 120190
		[Nullable(1)]
		private readonly List<MapComponent> TickSnapshot = new List<MapComponent>();
	}
}
