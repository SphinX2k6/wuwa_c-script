using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Sharphereal.AOTRedirector.Attributes;

namespace Sharphereal.AOTRedirector
{
	// Token: 0x02000007 RID: 7
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class Backend
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002274 File Offset: 0x00000474
		public Backend(string assemblyName)
		{
			this.assemblyName = assemblyName;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002300 File Offset: 0x00000500
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool HasMethodChunkRedirect(int cid)
		{
			return true;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002314 File Offset: 0x00000514
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool HasMethodRedirect(int chunkID, int methodID)
		{
			bool flag = !this.HasMethodChunkRedirect(chunkID);
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				byte b = this.MethodSwitches[methodID / 8];
				result = (b != 0 && ((int)b & 1 << methodID % 8) != 0);
			}
			return result;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002358 File Offset: 0x00000558
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetMethodRedirect(int mid)
		{
			ref byte ptr = ref this.MethodSwitches[mid / 8];
			ptr = (byte)((int)ptr | 1 << mid % 8);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002383 File Offset: 0x00000583
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetRedirectDelegate(int mid, Delegate @delegate)
		{
			this.MethodRedirectDelegates.Add(mid, @delegate);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002394 File Offset: 0x00000594
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetRedirectGenericMethodInfo(int mid, MethodInfo methodInfo)
		{
			this.GenericRedirectMethodInfos.Add(mid, methodInfo);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000023A5 File Offset: 0x000005A5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetRedirectGenericType(Type sourceGenericDefinitionType, Type destinationGenericDefinitionType)
		{
			this.SourceGenericTypeToRedirectGenericDefinitionTypes.Add(sourceGenericDefinitionType, destinationGenericDefinitionType);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000023B8 File Offset: 0x000005B8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T GetRedirectDelegate<[Nullable(0)] T>(int mid) where T : Delegate
		{
			return (T)((object)this.MethodRedirectDelegates[mid]);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000023DC File Offset: 0x000005DC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public TDelegate GetRedirectGenericMethodDelegate<[Nullable(0)] TDelegate>(int mid) where TDelegate : Delegate
		{
			Type typeFromHandle = typeof(TDelegate);
			ValueTuple<Type, int> key = new ValueTuple<Type, int>(typeFromHandle, mid);
			Delegate @delegate;
			bool flag = this.GenericMethodRedirectDelegates.TryGetValue(key, out @delegate);
			TDelegate result;
			if (flag)
			{
				result = (TDelegate)((object)@delegate);
			}
			else
			{
				MethodInfo methodInfo = this.GenericRedirectMethodInfos[mid];
				MethodInfo methodInfo2 = methodInfo.MakeGenericMethod(typeFromHandle.GenericTypeArguments);
				@delegate = methodInfo2.CreateDelegate(typeFromHandle);
				this.GenericMethodRedirectDelegates.Add(key, @delegate);
				result = (TDelegate)((object)@delegate);
			}
			return result;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000245C File Offset: 0x0000065C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public TDelegate GetRedirectGenericMethodDelegate<[Nullable(0)] TDelegate, [Nullable(2)] TMethodGenericTypeProvider>(int mid) where TDelegate : Delegate
		{
			Type typeFromHandle = typeof(TMethodGenericTypeProvider);
			ValueTuple<Type, int> key = new ValueTuple<Type, int>(typeFromHandle, mid);
			Delegate @delegate;
			bool flag = this.GenericMethodRedirectDelegates.TryGetValue(key, out @delegate);
			TDelegate result;
			if (flag)
			{
				result = (TDelegate)((object)@delegate);
			}
			else
			{
				MethodInfo methodInfo = this.GenericRedirectMethodInfos[mid];
				MethodInfo methodInfo2 = methodInfo.MakeGenericMethod(typeFromHandle.GenericTypeArguments);
				result = (TDelegate)((object)methodInfo2.CreateDelegate(typeof(TDelegate)));
			}
			return result;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000024D4 File Offset: 0x000006D4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private ValueTuple<Type, int> FindRedirectGenericType(int mid, Type sourceGenericInstanceType)
		{
			Type type;
			bool flag = this.SourceGenericTypeToRedirectGenericInstanceTypes.TryGetValue(sourceGenericInstanceType, out type);
			ValueTuple<Type, int> result;
			if (flag)
			{
				result = new ValueTuple<Type, int>(type, mid);
			}
			else
			{
				type = this.SourceGenericTypeToRedirectGenericDefinitionTypes[sourceGenericInstanceType.GetGenericTypeDefinition()].MakeGenericType(sourceGenericInstanceType.GenericTypeArguments);
				this.SourceGenericTypeToRedirectGenericInstanceTypes.Add(sourceGenericInstanceType, type);
				result = new ValueTuple<Type, int>(type, mid);
			}
			return result;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002538 File Offset: 0x00000738
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private MethodInfo FindRedirectGenericTypeMethodInfo(int mid, Type sourceGenericInstanceType, Type redirectGenericInstanceType)
		{
			foreach (MethodInfo methodInfo in redirectGenericInstanceType.GetMethods())
			{
				RedirectAttribute redirectAttribute = methodInfo.GetCustomAttribute(typeof(RedirectAttribute)) as RedirectAttribute;
				bool flag = redirectAttribute == null;
				if (!flag)
				{
					bool flag2 = redirectAttribute.RRID == mid;
					if (flag2)
					{
						return methodInfo;
					}
				}
			}
			MethodInfo methodInfo2 = sourceGenericInstanceType.GetMethods().First(delegate(MethodInfo x)
			{
				int metadataToken = x.MetadataToken;
				int num = metadataToken & 16777215;
				return num == mid;
			});
			return redirectGenericInstanceType.GetMethod(methodInfo2.Name, BindingFlags.Static | BindingFlags.Public);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000025E0 File Offset: 0x000007E0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public TDelegate GetRedirectGenericTypeMethodDelegate<[Nullable(0)] TDelegate, [Nullable(2)] TGenericType>(int mid) where TDelegate : Delegate
		{
			Type typeFromHandle = typeof(TDelegate);
			Type typeFromHandle2 = typeof(TGenericType);
			ValueTuple<Type, int> valueTuple = this.FindRedirectGenericType(mid, typeFromHandle2);
			Delegate @delegate;
			bool flag = this.GenericTypeMethodRedirectDelegates.TryGetValue(valueTuple, out @delegate);
			TDelegate result;
			if (flag)
			{
				result = (TDelegate)((object)@delegate);
			}
			else
			{
				MethodInfo methodInfo = this.FindRedirectGenericTypeMethodInfo(mid, typeFromHandle2, valueTuple.Item1);
				@delegate = methodInfo.CreateDelegate(typeFromHandle);
				bool flag2 = @delegate == null;
				if (flag2)
				{
					throw new Exception(string.Format("Unable to create redirect delegate by method RRID: {0}", mid));
				}
				this.GenericTypeMethodRedirectDelegates.Add(valueTuple, @delegate);
				result = (TDelegate)((object)@delegate);
			}
			return result;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002680 File Offset: 0x00000880
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public TDelegate GetRedirectGenericTypeGenericMethodDelegate<[Nullable(0)] TDelegate, [Nullable(2)] TGenericType, [Nullable(2)] TMethodGenericTypeProvider>(int mid) where TDelegate : Delegate
		{
			Type typeFromHandle = typeof(TGenericType);
			ValueTuple<Type, int> valueTuple = this.FindRedirectGenericType(mid, typeFromHandle);
			Delegate @delegate;
			bool flag = this.GenericTypeMethodRedirectDelegates.TryGetValue(valueTuple, out @delegate);
			TDelegate result;
			if (flag)
			{
				result = (TDelegate)((object)@delegate);
			}
			else
			{
				MethodInfo methodInfo = this.FindRedirectGenericTypeMethodInfo(mid, typeFromHandle, valueTuple.Item1);
				MethodInfo methodInfo2 = methodInfo.MakeGenericMethod(typeof(TMethodGenericTypeProvider).GenericTypeArguments);
				@delegate = methodInfo2.CreateDelegate(typeof(TDelegate));
				bool flag2 = @delegate == null;
				if (flag2)
				{
					throw new Exception(string.Format("Unable to create redirect delegate by method RRID: {0}", mid));
				}
				this.GenericTypeMethodRedirectDelegates.Add(valueTuple, @delegate);
				result = (TDelegate)((object)@delegate);
			}
			return result;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002734 File Offset: 0x00000934
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T GetFieldRedirectExtensionObject<[Nullable(2)] T>(object key) where T : new()
		{
			object obj;
			this.FieldRedirectExtensions.TryGetValue(key, out obj);
			bool flag = obj == null;
			if (flag)
			{
				obj = Activator.CreateInstance<T>();
				this.FieldRedirectExtensions.Add(key, obj);
			}
			return (T)((object)obj);
		}

		// Token: 0x04000005 RID: 5
		public string assemblyName;

		// Token: 0x04000006 RID: 6
		public bool patchSwitch;

		// Token: 0x04000007 RID: 7
		private byte[] MethodChunkSwitches = new byte[1288];

		// Token: 0x04000008 RID: 8
		private byte[] MethodSwitches = new byte[10086];

		// Token: 0x04000009 RID: 9
		private Dictionary<int, Delegate> MethodRedirectDelegates = new Dictionary<int, Delegate>();

		// Token: 0x0400000A RID: 10
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		private Dictionary<ValueTuple<Type, int>, Delegate> GenericMethodRedirectDelegates = new Dictionary<ValueTuple<Type, int>, Delegate>();

		// Token: 0x0400000B RID: 11
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		private Dictionary<ValueTuple<Type, int>, Delegate> GenericTypeMethodRedirectDelegates = new Dictionary<ValueTuple<Type, int>, Delegate>();

		// Token: 0x0400000C RID: 12
		private Dictionary<int, MethodInfo> GenericRedirectMethodInfos = new Dictionary<int, MethodInfo>();

		// Token: 0x0400000D RID: 13
		private Dictionary<Type, Type> SourceGenericTypeToRedirectGenericDefinitionTypes = new Dictionary<Type, Type>();

		// Token: 0x0400000E RID: 14
		private Dictionary<Type, Type> SourceGenericTypeToRedirectGenericInstanceTypes = new Dictionary<Type, Type>();

		// Token: 0x0400000F RID: 15
		private ConditionalWeakTable<object, object> FieldRedirectExtensions = new ConditionalWeakTable<object, object>();
	}
}
