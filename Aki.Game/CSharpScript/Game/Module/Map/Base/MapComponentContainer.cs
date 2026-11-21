using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Misc;

namespace CSharpScript.Game.Module.Map.Base
{
	// Token: 0x0200456D RID: 17773
	public class MapComponentContainer
	{
		// Token: 0x0602CC9C RID: 183452 RVA: 0x00C8A4CC File Offset: 0x00C886CC
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

		// Token: 0x0602CC9D RID: 183453 RVA: 0x00C8A53C File Offset: 0x00C8873C
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

		// Token: 0x0602CC9E RID: 183454 RVA: 0x00C8A5C0 File Offset: 0x00C887C0
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

		// Token: 0x0602CC9F RID: 183455 RVA: 0x00C8A640 File Offset: 0x00C88840
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

		// Token: 0x0602CCA0 RID: 183456 RVA: 0x00C8A6A4 File Offset: 0x00C888A4
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

		// Token: 0x0602CCA1 RID: 183457 RVA: 0x00C8A734 File Offset: 0x00C88934
		public void RemoveAll()
		{
			foreach (MapComponent mapComponent in this.ComponentIdMap.Values)
			{
				mapComponent.Enable = false;
				mapComponent.Remove();
			}
			this.ComponentIdMap.Clear();
			for (int i = 0; i < 12; i++)
			{
				List<MapComponent> list = this.ComponentTypeArray[i];
				if (list != null)
				{
					list.Clear();
				}
			}
		}

		// Token: 0x0602CCA2 RID: 183458 RVA: 0x00C8A7BC File Offset: 0x00C889BC
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

		// Token: 0x0602CCA3 RID: 183459 RVA: 0x00C8A81C File Offset: 0x00C88A1C
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

		// Token: 0x0602CCA4 RID: 183460 RVA: 0x00C8A880 File Offset: 0x00C88A80
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

		// Token: 0x04018006 RID: 98310
		private const int COMPONENT_TYPE_COUNT = 12;

		// Token: 0x04018007 RID: 98311
		[Nullable(1)]
		private readonly Dictionary<int, MapComponent> ComponentIdMap = new Dictionary<int, MapComponent>();

		// Token: 0x04018008 RID: 98312
		[Nullable(new byte[]
		{
			1,
			2,
			1
		})]
		private readonly List<MapComponent>[] ComponentTypeArray = new List<MapComponent>[12];

		// Token: 0x04018009 RID: 98313
		[Nullable(1)]
		private readonly List<MapComponent> TickSnapshot = new List<MapComponent>();
	}
}
