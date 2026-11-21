using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace System.Threading
{
	// Token: 0x020003D6 RID: 982
	public readonly struct CancellationTokenRegistration : IEquatable<CancellationTokenRegistration>, IDisposable, IAsyncDisposable
	{
		// Token: 0x06003FAB RID: 16299 RVA: 0x000D4C87 File Offset: 0x000D2E87
		internal CancellationTokenRegistration(long id, CancellationTokenSource.CallbackNode node)
		{
			this._id = id;
			this._node = node;
		}

		// Token: 0x06003FAC RID: 16300 RVA: 0x000D4C98 File Offset: 0x000D2E98
		public void Dispose()
		{
			CancellationTokenSource.CallbackNode node = this._node;
			if (node != null && !node.Registrations.Unregister(this._id, node))
			{
				CancellationTokenRegistration.<Dispose>g__WaitForCallbackIfNecessary|3_0(this._id, node);
			}
		}

		// Token: 0x06003FAD RID: 16301 RVA: 0x000D4CD0 File Offset: 0x000D2ED0
		public ValueTask DisposeAsync()
		{
			CancellationTokenSource.CallbackNode node = this._node;
			if (node == null || node.Registrations.Unregister(this._id, node))
			{
				return default(ValueTask);
			}
			return CancellationTokenRegistration.<DisposeAsync>g__WaitForCallbackIfNecessaryAsync|4_0(this._id, node);
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06003FAE RID: 16302 RVA: 0x000D4D14 File Offset: 0x000D2F14
		public CancellationToken Token
		{
			get
			{
				CancellationTokenSource.CallbackNode node = this._node;
				if (node == null)
				{
					return default(CancellationToken);
				}
				return new CancellationToken(node.Registrations.Source);
			}
		}

		// Token: 0x06003FAF RID: 16303 RVA: 0x000D4D48 File Offset: 0x000D2F48
		public bool Unregister()
		{
			CancellationTokenSource.CallbackNode node = this._node;
			return node != null && node.Registrations.Unregister(this._id, node);
		}

		// Token: 0x06003FB0 RID: 16304 RVA: 0x000D4D73 File Offset: 0x000D2F73
		public static bool operator ==(CancellationTokenRegistration left, CancellationTokenRegistration right)
		{
			return left.Equals(right);
		}

		// Token: 0x06003FB1 RID: 16305 RVA: 0x000D4D7D File Offset: 0x000D2F7D
		public static bool operator !=(CancellationTokenRegistration left, CancellationTokenRegistration right)
		{
			return !left.Equals(right);
		}

		// Token: 0x06003FB2 RID: 16306 RVA: 0x000D4D8C File Offset: 0x000D2F8C
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is CancellationTokenRegistration)
			{
				CancellationTokenRegistration other = (CancellationTokenRegistration)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06003FB3 RID: 16307 RVA: 0x000D4DB1 File Offset: 0x000D2FB1
		public bool Equals(CancellationTokenRegistration other)
		{
			return this._node == other._node && this._id == other._id;
		}

		// Token: 0x06003FB4 RID: 16308 RVA: 0x000D4DD1 File Offset: 0x000D2FD1
		public override int GetHashCode()
		{
			if (this._node == null)
			{
				return this._id.GetHashCode();
			}
			return this._node.GetHashCode() ^ this._id.GetHashCode();
		}

		// Token: 0x06003FB5 RID: 16309 RVA: 0x000D4E00 File Offset: 0x000D3000
		[CompilerGenerated]
		internal static void <Dispose>g__WaitForCallbackIfNecessary|3_0(long id, CancellationTokenSource.CallbackNode node)
		{
			CancellationTokenSource source = node.Registrations.Source;
			if (source.IsCancellationRequested && !source.IsCancellationCompleted && node.Registrations.ThreadIDExecutingCallbacks != Environment.CurrentManagedThreadId)
			{
				node.Registrations.WaitForCallbackToComplete(id);
			}
		}

		// Token: 0x06003FB6 RID: 16310 RVA: 0x000D4E4C File Offset: 0x000D304C
		[CompilerGenerated]
		internal static ValueTask <DisposeAsync>g__WaitForCallbackIfNecessaryAsync|4_0(long id, CancellationTokenSource.CallbackNode node)
		{
			CancellationTokenSource source = node.Registrations.Source;
			if (source.IsCancellationRequested && !source.IsCancellationCompleted && node.Registrations.ThreadIDExecutingCallbacks != Environment.CurrentManagedThreadId)
			{
				return node.Registrations.WaitForCallbackToCompleteAsync(id);
			}
			return default(ValueTask);
		}

		// Token: 0x04000D29 RID: 3369
		private readonly long _id;

		// Token: 0x04000D2A RID: 3370
		private readonly CancellationTokenSource.CallbackNode _node;
	}
}
