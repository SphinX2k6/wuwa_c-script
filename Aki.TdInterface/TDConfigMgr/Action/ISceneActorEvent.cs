using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DD4 RID: 7636
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneActorEvent
	{
		// Token: 0x0600A381 RID: 41857 RVA: 0x00173388 File Offset: 0x00171588
		private ISceneActorEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneActorEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneActorEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneActorEvent_SetValue());
			}
			return result;
		}

		// Token: 0x0600A382 RID: 41858 RVA: 0x001733C0 File Offset: 0x001715C0
		public static ISceneActorEvent Create([Nullable(2)] ISceneActorEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneActorEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A383 RID: 41859 RVA: 0x001733D3 File Offset: 0x001715D3
		public static ISceneActorEvent CreateFromSetValue([Nullable(2)] ISceneActorEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneActorEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A384 RID: 41860 RVA: 0x001733E6 File Offset: 0x001715E6
		public ISceneActorEvent_SetValue ToSetValue()
		{
			return new ISceneActorEvent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003259 RID: 12889
		// (get) Token: 0x0600A385 RID: 41861 RVA: 0x001733F9 File Offset: 0x001715F9
		// (set) Token: 0x0600A386 RID: 41862 RVA: 0x00173424 File Offset: 0x00171624
		public virtual ESceneActorEventType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESceneActorEventType.PlayMusicPlants;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006204 RID: 25092
		[Nullable(2)]
		protected ISceneActorEvent FbInstance;

		// Token: 0x04006205 RID: 25093
		[Nullable(2)]
		protected ISceneActorEvent_SetValue PocoInterface;
	}
}
