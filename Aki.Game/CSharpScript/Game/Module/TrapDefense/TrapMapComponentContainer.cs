using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039D9 RID: 14809
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapMapComponentContainer
	{
		// Token: 0x060262A2 RID: 156322 RVA: 0x00AB4C30 File Offset: 0x00AB2E30
		[return: Nullable(2)]
		public TrapMapComponentBase AddComponent(ETrapDefenseMapComponent componentType, TrapMapEntity parent)
		{
			TrapMapComponentBase trapMapComponentBase = TrapDefenseDefine.towerMapComponentConstructors[componentType](parent);
			this.AddInternal(componentType, trapMapComponentBase);
			return trapMapComponentBase;
		}

		// Token: 0x060262A3 RID: 156323 RVA: 0x00AB4C5C File Offset: 0x00AB2E5C
		private bool AddInternal(ETrapDefenseMapComponent componentType, TrapMapComponentBase component)
		{
			int componentId = component.ComponentId;
			if (this.ComponentIdMap.ContainsKey(componentId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TowerDefense;
				ELogAuthor author = ELogAuthor.LYX;
				string message = "[塔防地图]TrapMapComponentContainer.AddInternal->添加组件失败，重复组件Id";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("componentId", componentId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this.ComponentIdMap[componentId] = component;
			if (!this.ComponentTypeMap.ContainsKey(componentType))
			{
				List<TrapMapComponentBase> value = new List<TrapMapComponentBase>();
				this.ComponentTypeMap[componentType] = value;
			}
			this.ComponentTypeMap[componentType].Add(component);
			component.Add();
			component.Enable = true;
			return true;
		}

		// Token: 0x060262A4 RID: 156324 RVA: 0x00AB4D00 File Offset: 0x00AB2F00
		[NullableContext(0)]
		[return: Nullable(2)]
		public T GetComponent<T>(ETrapDefenseMapComponent componentType) where T : TrapMapComponentBase
		{
			List<T> allGeneric = this.GetAllGeneric<T>(componentType);
			if (allGeneric != null && allGeneric.Count > 0)
			{
				return allGeneric[0];
			}
			return default(T);
		}

		// Token: 0x060262A5 RID: 156325 RVA: 0x00AB4D34 File Offset: 0x00AB2F34
		[NullableContext(2)]
		public TrapMapComponentBase GetComponentById(int componentId)
		{
			if (!this.ComponentIdMap.ContainsKey(componentId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TowerDefense;
				ELogAuthor author = ELogAuthor.LYX;
				string message = "[塔防地图]TrapMapComponentContainer.GetById->获取组件失败，不存在该组件Id";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("componentId", componentId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return this.ComponentIdMap[componentId];
		}

		// Token: 0x060262A6 RID: 156326 RVA: 0x00AB4D8C File Offset: 0x00AB2F8C
		[return: Nullable(2)]
		public T GetComponentByFilter<[Nullable(0)] T>(ETrapDefenseMapComponent componentType, Func<T, bool> filterFunc) where T : TrapMapComponentBase
		{
			List<T> allGeneric = this.GetAllGeneric<T>(componentType);
			if (allGeneric != null)
			{
				for (int i = 0; i < allGeneric.Count; i++)
				{
					if (filterFunc(allGeneric[i]))
					{
						return allGeneric[i];
					}
				}
			}
			return default(T);
		}

		// Token: 0x060262A7 RID: 156327 RVA: 0x00AB4DD8 File Offset: 0x00AB2FD8
		[NullableContext(0)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<T> GetAllGeneric<T>(ETrapDefenseMapComponent componentType) where T : TrapMapComponentBase
		{
			List<TrapMapComponentBase> all = this.GetAll(componentType);
			if (all != null)
			{
				List<T> list = new List<T>();
				for (int i = 0; i < all.Count; i++)
				{
					T t = all[i] as T;
					if (t != null)
					{
						list.Add(t);
					}
				}
				return list;
			}
			return null;
		}

		// Token: 0x060262A8 RID: 156328 RVA: 0x00AB4E2C File Offset: 0x00AB302C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<TrapMapComponentBase> GetAll(ETrapDefenseMapComponent componentType)
		{
			if (!this.ComponentTypeMap.ContainsKey(componentType))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TowerDefense;
				ELogAuthor author = ELogAuthor.LYX;
				string message = "[塔防地图]MapComponentContainer.Get->获取组件失败，不存在该类型组件";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("componentType", componentType);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			List<TrapMapComponentBase> list = this.ComponentTypeMap[componentType];
			if (list.Count <= 0 && !this.ComponentTypeMap.ContainsKey(componentType))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.TowerDefense;
				ELogAuthor author2 = ELogAuthor.LYX;
				string message2 = "[塔防地图]MapComponentContainer.Get->获取组件失败，不存在该类型组件";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("componentType", componentType);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return null;
			}
			return list;
		}

		// Token: 0x060262A9 RID: 156329 RVA: 0x00AB4ED0 File Offset: 0x00AB30D0
		public void RemoveComponent(ETrapDefenseMapComponent componentType)
		{
			List<TrapMapComponentBase> all = this.GetAll(componentType);
			if (all != null)
			{
				for (int i = all.Count - 1; i >= 0; i--)
				{
					TrapMapComponentBase trapMapComponentBase = all[i];
					int componentId = trapMapComponentBase.ComponentId;
					this.ComponentIdMap.Remove(componentId);
					all.RemoveAt(i);
					trapMapComponentBase.Enable = false;
					trapMapComponentBase.Remove();
				}
			}
		}

		// Token: 0x060262AA RID: 156330 RVA: 0x00AB4F2C File Offset: 0x00AB312C
		public void RemoveAll()
		{
			foreach (KeyValuePair<int, TrapMapComponentBase> keyValuePair in this.ComponentIdMap)
			{
				keyValuePair.Value.Enable = false;
				keyValuePair.Value.Remove();
			}
			this.ComponentIdMap.Clear();
			this.ComponentTypeMap.Clear();
		}

		// Token: 0x060262AB RID: 156331 RVA: 0x00AB4FA8 File Offset: 0x00AB31A8
		public void Init()
		{
			foreach (KeyValuePair<int, TrapMapComponentBase> keyValuePair in this.ComponentIdMap)
			{
				keyValuePair.Value.Init();
			}
		}

		// Token: 0x060262AC RID: 156332 RVA: 0x00AB5000 File Offset: 0x00AB3200
		public void Tick(float delta)
		{
			foreach (KeyValuePair<int, TrapMapComponentBase> keyValuePair in this.ComponentIdMap)
			{
				keyValuePair.Value.Tick(delta);
			}
		}

		// Token: 0x04014F11 RID: 85777
		private readonly Dictionary<int, TrapMapComponentBase> ComponentIdMap = new Dictionary<int, TrapMapComponentBase>();

		// Token: 0x04014F12 RID: 85778
		private readonly Dictionary<ETrapDefenseMapComponent, List<TrapMapComponentBase>> ComponentTypeMap = new Dictionary<ETrapDefenseMapComponent, List<TrapMapComponentBase>>();
	}
}
