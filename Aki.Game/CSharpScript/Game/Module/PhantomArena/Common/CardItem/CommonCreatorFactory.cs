using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem
{
	// Token: 0x0200419E RID: 16798
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonCreatorFactory<[Nullable(2)] TBase>
	{
		// Token: 0x0602A8B2 RID: 174258 RVA: 0x00C00BF4 File Offset: 0x00BFEDF4
		[NullableContext(0)]
		public void Register<TChild>() where TChild : TBase, new()
		{
			Type typeFromHandle = typeof(TBase);
			Type typeFromHandle2 = typeof(TChild);
			this.FactoryMap[typeFromHandle2] = (() => Activator.CreateInstance<TChild>());
			this.TypeMapping[typeFromHandle2] = typeFromHandle;
		}

		// Token: 0x0602A8B3 RID: 174259 RVA: 0x00C00C50 File Offset: 0x00BFEE50
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

		// Token: 0x0602A8B4 RID: 174260 RVA: 0x00C00CA4 File Offset: 0x00BFEEA4
		public void RegisterWithKey<[Nullable(0)] TValue>(Enum key) where TValue : TBase, new()
		{
			Type typeFromHandle = typeof(TBase);
			Type typeFromHandle2 = typeof(TValue);
			this.FactoryMap[typeFromHandle2] = (() => Activator.CreateInstance<TValue>());
			this.TypeMapping[typeFromHandle2] = typeFromHandle;
			this.KeyMapping[key.ToString()] = typeFromHandle2;
		}

		// Token: 0x0602A8B5 RID: 174261 RVA: 0x00C00D14 File Offset: 0x00BFEF14
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

		// Token: 0x04017178 RID: 94584
		private Dictionary<Type, Func<object>> FactoryMap = new Dictionary<Type, Func<object>>();

		// Token: 0x04017179 RID: 94585
		private Dictionary<Type, Type> TypeMapping = new Dictionary<Type, Type>();

		// Token: 0x0401717A RID: 94586
		private Dictionary<string, Type> KeyMapping = new Dictionary<string, Type>();
	}
}
