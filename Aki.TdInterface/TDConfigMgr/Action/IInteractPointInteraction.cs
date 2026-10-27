using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B56 RID: 6998
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractPointInteraction
	{
		// Token: 0x060095D9 RID: 38361 RVA: 0x0015A5C0 File Offset: 0x001587C0
		private IInteractPointInteraction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractPointInteraction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractPointInteraction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractPointInteraction_SetValue());
			}
			return result;
		}

		// Token: 0x060095DA RID: 38362 RVA: 0x0015A5F8 File Offset: 0x001587F8
		public static IInteractPointInteraction Create([Nullable(2)] IInteractPointInteraction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractPointInteraction
			{
				FbInstance = instance
			};
		}

		// Token: 0x060095DB RID: 38363 RVA: 0x0015A60B File Offset: 0x0015880B
		public static IInteractPointInteraction CreateFromSetValue([Nullable(2)] IInteractPointInteraction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractPointInteraction
			{
				PocoInterface = value
			};
		}

		// Token: 0x060095DC RID: 38364 RVA: 0x0015A61E File Offset: 0x0015881E
		public IInteractPointInteraction_SetValue ToSetValue()
		{
			return new IInteractPointInteraction_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F42 RID: 12098
		// (get) Token: 0x060095DD RID: 38365 RVA: 0x0015A631 File Offset: 0x00158831
		// (set) Token: 0x060095DE RID: 38366 RVA: 0x0015A65C File Offset: 0x0015885C
		public virtual EInteractPointInteractionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractPointInteractionType.Drag;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005BAF RID: 23471
		[Nullable(2)]
		protected IInteractPointInteraction FbInstance;

		// Token: 0x04005BB0 RID: 23472
		[Nullable(2)]
		protected IInteractPointInteraction_SetValue PocoInterface;
	}
}
