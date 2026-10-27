using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A31 RID: 18993
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapMapComponentContainer
	{
		// Token: 0x06031512 RID: 202002 RVA: 0x00B70CBC File Offset: 0x00B6EEBC
		[return: Nullable(2)]
		public TrapMapComponentBase AddComponent(ETrapDefenseMapComponent componentType, TrapMapEntity parent)
		{
			TrapMapComponentBase trapMapComponentBase = TrapDefenseDefine.towerMapComponentConstructors[componentType](parent);
			this.AddInternal(componentType, trapMapComponentBase);
			return trapMapComponentBase;
		}

		// Token: 0x06031513 RID: 202003 RVA: 0x00B70CE8 File Offset: 0x00B6EEE8
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

		// Token: 0x06031514 RID: 202004 RVA: 0x00B70D8C File Offset: 0x00B6EF8C
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

		// Token: 0x06031515 RID: 202005 RVA: 0x00B70DC0 File Offset: 0x00B6EFC0
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

		// Token: 0x06031516 RID: 202006 RVA: 0x00B70E18 File Offset: 0x00B6F018
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

		// Token: 0x06031517 RID: 202007 RVA: 0x00B70E64 File Offset: 0x00B6F064
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

		// Token: 0x06031518 RID: 202008 RVA: 0x00B70EB8 File Offset: 0x00B6F0B8
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

		// Token: 0x06031519 RID: 202009 RVA: 0x00B70F5C File Offset: 0x00B6F15C
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

		// Token: 0x0603151A RID: 202010 RVA: 0x00B70FB8 File Offset: 0x00B6F1B8
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

		// Token: 0x0603151B RID: 202011 RVA: 0x00B71034 File Offset: 0x00B6F234
		public void Init()
		{
			foreach (KeyValuePair<int, TrapMapComponentBase> keyValuePair in this.ComponentIdMap)
			{
				keyValuePair.Value.Init();
			}
		}

		// Token: 0x0603151C RID: 202012 RVA: 0x00B7108C File Offset: 0x00B6F28C
		public void Tick(float delta)
		{
			foreach (KeyValuePair<int, TrapMapComponentBase> keyValuePair in this.ComponentIdMap)
			{
				keyValuePair.Value.Tick(delta);
			}
		}

		// Token: 0x0401A5BF RID: 107967
		private readonly Dictionary<int, TrapMapComponentBase> ComponentIdMap = new Dictionary<int, TrapMapComponentBase>();

		// Token: 0x0401A5C0 RID: 107968
		private readonly Dictionary<ETrapDefenseMapComponent, List<TrapMapComponentBase>> ComponentTypeMap = new Dictionary<ETrapDefenseMapComponent, List<TrapMapComponentBase>>();
	}
}
