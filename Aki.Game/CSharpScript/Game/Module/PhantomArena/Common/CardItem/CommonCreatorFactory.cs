using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem
{
	// Token: 0x020051CE RID: 20942
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonCreatorFactory<[Nullable(2)] TBase>
	{
		// Token: 0x060359B7 RID: 219575 RVA: 0x00CB35B8 File Offset: 0x00CB17B8
		[NullableContext(0)]
		public void Register<TChild>() where TChild : TBase, new()
		{
			Type typeFromHandle = typeof(TBase);
			Type typeFromHandle2 = typeof(TChild);
			this.FactoryMap[typeFromHandle2] = (() => Activator.CreateInstance<TChild>());
			this.TypeMapping[typeFromHandle2] = typeFromHandle;
		}

		// Token: 0x060359B8 RID: 219576 RVA: 0x00CB3614 File Offset: 0x00CB1814
		public TChild GetComponent<[Nullable(0)] TChild>() where TChild : TBase, new()
		{
			Type typeFromHandle = typeof(TChild);
			Type type;
			if (this.TypeMapping.TryGetValue(typeFromHandle, out type))
			{
				return (TChild)((object)this.FactoryMap[typeFromHandle]());
			}
			throw new InvalidOperationException("No factory registered for type " + typeFromHandle.FullName);
		}

		// Token: 0x060359B9 RID: 219577 RVA: 0x00CB3668 File Offset: 0x00CB1868
		public void RegisterWithKey<[Nullable(0)] TValue>(Enum key) where TValue : TBase, new()
		{
			Type typeFromHandle = typeof(TBase);
			Type typeFromHandle2 = typeof(TValue);
			this.FactoryMap[typeFromHandle2] = (() => Activator.CreateInstance<TValue>());
			this.TypeMapping[typeFromHandle2] = typeFromHandle;
			this.KeyMapping[key.ToString()] = typeFromHandle2;
		}

		// Token: 0x060359BA RID: 219578 RVA: 0x00CB36D8 File Offset: 0x00CB18D8
		public TValue GetComponentWithKey<[Nullable(0)] TValue>(Enum key) where TValue : TBase, new()
		{
			Type type;
			Func<object> func;
			if (this.KeyMapping.TryGetValue(key.ToString(), out type) && this.FactoryMap.TryGetValue(type, out func))
			{
				return (TValue)((object)this.FactoryMap[type]());
			}
			throw new InvalidOperationException("No factory registered for type " + type.FullName);
		}

		// Token: 0x0401C743 RID: 116547
		private Dictionary<Type, Func<object>> FactoryMap = new Dictionary<Type, Func<object>>();

		// Token: 0x0401C744 RID: 116548
		private Dictionary<Type, Type> TypeMapping = new Dictionary<Type, Type>();

		// Token: 0x0401C745 RID: 116549
		private Dictionary<string, Type> KeyMapping = new Dictionary<string, Type>();
	}
}
