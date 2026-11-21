using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x0200008C RID: 140
	[NullableContext(1)]
	[Nullable(0)]
	[StructLayout(LayoutKind.Sequential)]
	public abstract class MulticastDelegate : Delegate, ISerializable
	{
		// Token: 0x06000532 RID: 1330 RVA: 0x000111C5 File Offset: 0x0000F3C5
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new SerializationException(SR.Serialization_DelegatesNotSupported);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x000111D4 File Offset: 0x0000F3D4
		[NullableContext(2)]
		protected sealed override object DynamicInvokeImpl(object[] args)
		{
			if (this.delegates == null)
			{
				return base.DynamicInvokeImpl(args);
			}
			int num = 0;
			int num2 = this.delegates.Length;
			object result;
			do
			{
				result = this.delegates[num].DynamicInvoke(args);
			}
			while (++num < num2);
			return result;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00011214 File Offset: 0x0000F414
		[NullableContext(2)]
		public sealed override bool Equals([NotNullWhen(true)] object obj)
		{
			if (!base.Equals(obj))
			{
				return false;
			}
			MulticastDelegate multicastDelegate = obj as MulticastDelegate;
			if (multicastDelegate == null)
			{
				return false;
			}
			if (this.delegates == null && multicastDelegate.delegates == null)
			{
				return true;
			}
			if (this.delegates == null ^ multicastDelegate.delegates == null)
			{
				return false;
			}
			if (this.delegates.Length != multicastDelegate.delegates.Length)
			{
				return false;
			}
			for (int i = 0; i < this.delegates.Length; i++)
			{
				if (!this.delegates[i].Equals(multicastDelegate.delegates[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x000112A2 File Offset: 0x0000F4A2
		public sealed override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x000112AA File Offset: 0x0000F4AA
		protected override MethodInfo GetMethodImpl()
		{
			if (this.delegates != null)
			{
				return this.delegates[this.delegates.Length - 1].Method;
			}
			return base.GetMethodImpl();
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x000112D1 File Offset: 0x0000F4D1
		public sealed override Delegate[] GetInvocationList()
		{
			if (this.delegates != null)
			{
				return (Delegate[])this.delegates.Clone();
			}
			return new Delegate[]
			{
				this
			};
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x000112F6 File Offset: 0x0000F4F6
		internal new bool HasSingleTarget
		{
			get
			{
				return this.delegates == null || this.delegates.Length == 1;
			}
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0001130D File Offset: 0x0000F50D
		internal Delegate TryGetAt(int index)
		{
			if (this.delegates == null)
			{
				if (index != 0)
				{
					return null;
				}
				return this;
			}
			else
			{
				if (index >= this.delegates.Length)
				{
					return null;
				}
				return this.delegates[index];
			}
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00011334 File Offset: 0x0000F534
		protected sealed override Delegate CombineImpl([Nullable(2)] Delegate follow)
		{
			if (follow == null)
			{
				return this;
			}
			if (!Delegate.InternalEqualTypes(this, follow))
			{
				throw new ArgumentException(SR.Arg_DlgtTypeMis);
			}
			MulticastDelegate multicastDelegate = (MulticastDelegate)follow;
			MulticastDelegate multicastDelegate2 = Delegate.AllocDelegateLike_internal(this);
			if (this.delegates == null && multicastDelegate.delegates == null)
			{
				multicastDelegate2.delegates = new Delegate[]
				{
					this,
					multicastDelegate
				};
			}
			else if (this.delegates == null)
			{
				multicastDelegate2.delegates = new Delegate[1 + multicastDelegate.delegates.Length];
				multicastDelegate2.delegates[0] = this;
				Array.Copy(multicastDelegate.delegates, 0, multicastDelegate2.delegates, 1, multicastDelegate.delegates.Length);
			}
			else if (multicastDelegate.delegates == null)
			{
				multicastDelegate2.delegates = new Delegate[this.delegates.Length + 1];
				Array.Copy(this.delegates, 0, multicastDelegate2.delegates, 0, this.delegates.Length);
				multicastDelegate2.delegates[multicastDelegate2.delegates.Length - 1] = multicastDelegate;
			}
			else
			{
				multicastDelegate2.delegates = new Delegate[this.delegates.Length + multicastDelegate.delegates.Length];
				Array.Copy(this.delegates, 0, multicastDelegate2.delegates, 0, this.delegates.Length);
				Array.Copy(multicastDelegate.delegates, 0, multicastDelegate2.delegates, this.delegates.Length, multicastDelegate.delegates.Length);
			}
			return multicastDelegate2;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00011480 File Offset: 0x0000F680
		private static int LastIndexOf(Delegate[] haystack, Delegate[] needle)
		{
			if (haystack.Length < needle.Length)
			{
				return -1;
			}
			if (haystack.Length == needle.Length)
			{
				for (int i = 0; i < haystack.Length; i++)
				{
					if (!haystack[i].Equals(needle[i]))
					{
						return -1;
					}
				}
				return 0;
			}
			int num;
			for (int j = haystack.Length - needle.Length; j >= 0; j -= num + 1)
			{
				num = 0;
				while (needle[num].Equals(haystack[j]))
				{
					if (num == needle.Length - 1)
					{
						return j - num;
					}
					j++;
					num++;
				}
			}
			return -1;
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x000114F8 File Offset: 0x0000F6F8
		[return: Nullable(2)]
		protected sealed override Delegate RemoveImpl(Delegate value)
		{
			if (value == null)
			{
				return this;
			}
			MulticastDelegate multicastDelegate = (MulticastDelegate)value;
			if (this.delegates == null && multicastDelegate.delegates == null)
			{
				if (!this.Equals(multicastDelegate))
				{
					return this;
				}
				return null;
			}
			else
			{
				if (this.delegates == null)
				{
					foreach (Delegate obj in multicastDelegate.delegates)
					{
						if (this.Equals(obj))
						{
							return null;
						}
					}
					return this;
				}
				if (multicastDelegate.delegates == null)
				{
					int num = Array.LastIndexOf<Delegate>(this.delegates, multicastDelegate);
					if (num == -1)
					{
						return this;
					}
					if (this.delegates.Length <= 1)
					{
						throw new InvalidOperationException();
					}
					if (this.delegates.Length == 2)
					{
						return this.delegates[(num == 0) ? 1 : 0];
					}
					MulticastDelegate multicastDelegate2 = Delegate.AllocDelegateLike_internal(this);
					multicastDelegate2.delegates = new Delegate[this.delegates.Length - 1];
					Array.Copy(this.delegates, multicastDelegate2.delegates, num);
					Array.Copy(this.delegates, num + 1, multicastDelegate2.delegates, num, this.delegates.Length - num - 1);
					return multicastDelegate2;
				}
				else
				{
					if (this.delegates.Equals(multicastDelegate.delegates))
					{
						return null;
					}
					int num2 = MulticastDelegate.LastIndexOf(this.delegates, multicastDelegate.delegates);
					if (num2 == -1)
					{
						return this;
					}
					MulticastDelegate multicastDelegate3 = Delegate.AllocDelegateLike_internal(this);
					multicastDelegate3.delegates = new Delegate[this.delegates.Length - multicastDelegate.delegates.Length];
					Array.Copy(this.delegates, multicastDelegate3.delegates, num2);
					Array.Copy(this.delegates, num2 + multicastDelegate.delegates.Length, multicastDelegate3.delegates, num2, this.delegates.Length - num2 - multicastDelegate.delegates.Length);
					return multicastDelegate3;
				}
			}
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0001169C File Offset: 0x0000F89C
		internal override object GetTarget()
		{
			Delegate[] array = this.delegates;
			if (array == null || array.Length == 0)
			{
				return base.GetTarget();
			}
			return this.delegates[this.delegates.Length - 1].GetTarget();
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x000116CE File Offset: 0x0000F8CE
		[RequiresUnreferencedCode("The target method might be removed")]
		protected MulticastDelegate(object target, string method) : base(target, method)
		{
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x000116D8 File Offset: 0x0000F8D8
		protected MulticastDelegate([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type target, string method) : base(target, method)
		{
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0000AD46 File Offset: 0x00008F46
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(MulticastDelegate d1, MulticastDelegate d2)
		{
			if (d2 == null)
			{
				return d1 == null;
			}
			return d2 == d1 || d2.Equals(d1);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0000AD5D File Offset: 0x00008F5D
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(MulticastDelegate d1, MulticastDelegate d2)
		{
			if (d2 == null)
			{
				return d1 != null;
			}
			return d2 != d1 && !d2.Equals(d1);
		}

		// Token: 0x0400026D RID: 621
		private Delegate[] delegates;
	}
}
