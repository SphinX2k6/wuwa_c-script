using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Effect
{
	// Token: 0x02007271 RID: 29297
	[NullableContext(2)]
	[Nullable(0)]
	public class KuroEffectHandle
	{
		// Token: 0x17009E90 RID: 40592
		// (get) Token: 0x06047C9D RID: 294045 RVA: 0x0125D60D File Offset: 0x0125B80D
		// (set) Token: 0x06047C9E RID: 294046 RVA: 0x0125D615 File Offset: 0x0125B815
		public int Id { get; set; }

		// Token: 0x17009E91 RID: 40593
		// (get) Token: 0x06047C9F RID: 294047 RVA: 0x0125D61E File Offset: 0x0125B81E
		// (set) Token: 0x06047CA0 RID: 294048 RVA: 0x0125D626 File Offset: 0x0125B826
		public bool IsLoop { get; set; }

		// Token: 0x06047CA1 RID: 294049 RVA: 0x0125D62F File Offset: 0x0125B82F
		public void Init(EffectContext context, Action<int> beforeInitCallback = null, Action<ELoadEffectResult, int> callback = null, Action<int> beforePlayCallback = null)
		{
			this.Context = context;
			this.BeforeInitCallback = beforeInitCallback;
			this.EffectInitCallback = callback;
			this.BeforePlayCallback = beforePlayCallback;
		}

		// Token: 0x06047CA2 RID: 294050 RVA: 0x0125D64E File Offset: 0x0125B84E
		public void OnAfterSpawn(int effectId)
		{
			this.Id = effectId;
			this.IsLoop = UKuroEffectSystemFunctionLibrary.EffectIsLoop(effectId);
			this.RegisterFinishCallback();
		}

		// Token: 0x06047CA3 RID: 294051 RVA: 0x0125D669 File Offset: 0x0125B869
		public void Clear(bool unbind = false)
		{
			this.UnregisterFinishCallback();
			if (unbind)
			{
				this.UnbindDelegates();
			}
			this.BeforeInitCallback = null;
			this.EffectInitCallback = null;
			this.BeforePlayCallback = null;
			this.DynamicEffectInitCallback = null;
			this.Context = null;
			this.OnCustomCheckOwner = null;
		}

		// Token: 0x06047CA4 RID: 294052 RVA: 0x0125D6A4 File Offset: 0x0125B8A4
		internal void OnSpawnDelegatesRegistered(FKuroEffectBeforeInitCallback beforeInitDelegate, FKuroEffectInitCallback initDelegate, FKuroEffectBeforePlayCallback beforePlayDelegate, FKuroEffectOnClearCallback clearDelegate)
		{
			this._beforeInitDelegate = beforeInitDelegate;
			this._initDelegate = initDelegate;
			this._beforePlayDelegate = beforePlayDelegate;
			this._clearDelegate = clearDelegate;
		}

		// Token: 0x06047CA5 RID: 294053 RVA: 0x0125D6C4 File Offset: 0x0125B8C4
		private void UnbindDelegates()
		{
			if (this._beforeInitDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<int>(this.OnBeforeInitCallback));
				this._beforeInitDelegate = null;
			}
			if (this._initDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<byte, int>(this.OnEffectInitCallback));
				this._initDelegate = null;
			}
			if (this._beforePlayDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<int>(this.OnBeforePlayCallback));
				this._beforePlayDelegate = null;
			}
			if (this._clearDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.OnInitCallbackClear));
				this._clearDelegate = null;
			}
			if (this._finishDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<int>(this.OnEffectFinish));
				this._finishDelegate = null;
			}
			if (this._finishClearDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.OnEffectFinishClear));
				this._finishClearDelegate = null;
			}
			if (this._dynamicInitDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<byte, int>(this.OnDynamicEffectInitCallback));
				this._dynamicInitDelegate = null;
			}
			if (this._dynamicClearDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.OnDynamicEffectInitCallbackClear));
				this._dynamicClearDelegate = null;
			}
		}

		// Token: 0x06047CA6 RID: 294054 RVA: 0x0125D7D4 File Offset: 0x0125B9D4
		public bool CheckOwner()
		{
			if (this.OnCustomCheckOwner != null)
			{
				return this.OnCustomCheckOwner(this.Id);
			}
			if (this.Context == null)
			{
				return true;
			}
			if (this.Context.EntityId != null)
			{
				int? entityId = this.Context.EntityId;
				int num = 0;
				if (!(entityId.GetValueOrDefault() == num & entityId != null))
				{
					Entity entity = EntitySystem.Instance.Get(this.Context.EntityId.Value);
					if (entity == null || !entity.Valid)
					{
						return false;
					}
				}
			}
			return this.Context.SourceObject == null || this.Context.SourceObject.IsValid();
		}

		// Token: 0x06047CA7 RID: 294055 RVA: 0x0125D88E File Offset: 0x0125BA8E
		public bool IsDone()
		{
			return this.IsDoneInternal;
		}

		// Token: 0x06047CA8 RID: 294056 RVA: 0x0125D896 File Offset: 0x0125BA96
		public void SetNotRecord(bool value)
		{
			this.NotRecordInternal = value;
		}

		// Token: 0x06047CA9 RID: 294057 RVA: 0x0125D89F File Offset: 0x0125BA9F
		public bool GetNotRecord()
		{
			return this.NotRecordInternal;
		}

		// Token: 0x06047CAA RID: 294058 RVA: 0x0125D8A8 File Offset: 0x0125BAA8
		public void RegisterFinishCallback()
		{
			if (this.HasRegisterFinishCallback)
			{
				return;
			}
			this.HasRegisterFinishCallback = true;
			this._finishDelegate = DelegateUtils.ToManualReleaseDelegate<FKuroEffectFinishCallback>(new Action<int>(this.OnEffectFinish));
			this._finishClearDelegate = DelegateUtils.ToManualReleaseDelegate<FKuroEffectOnClearCallback>(new Action(this.OnEffectFinishClear));
			UKuroEffectSystemFunctionLibrary.AddFinishCallback(this.Id, this._finishDelegate, this._finishClearDelegate);
		}

		// Token: 0x06047CAB RID: 294059 RVA: 0x0125D90A File Offset: 0x0125BB0A
		private void UnregisterFinishCallback()
		{
			if (!this.HasRegisterFinishCallback)
			{
				return;
			}
			this.HasRegisterFinishCallback = false;
			UKuroEffectSystemFunctionLibrary.RemoveFinishCallback(this.Id);
			HashSet<Action<int>> onFinishCallbackSet = this.OnFinishCallbackSet;
			if (onFinishCallbackSet == null)
			{
				return;
			}
			onFinishCallbackSet.Clear();
		}

		// Token: 0x06047CAC RID: 294060 RVA: 0x0125D938 File Offset: 0x0125BB38
		private void OnEffectFinishClear()
		{
			if (this._finishDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<int>(this.OnEffectFinish));
				this._finishDelegate = null;
			}
			if (this._finishClearDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.OnEffectFinishClear));
				this._finishClearDelegate = null;
			}
			if (this.HasRegisterFinishCallback)
			{
				this.UnregisterFinishCallback();
			}
		}

		// Token: 0x06047CAD RID: 294061 RVA: 0x0125D994 File Offset: 0x0125BB94
		private void OnEffectFinish(int handle)
		{
			if (handle != this.Id && this.Id != 0)
			{
				return;
			}
			if (this.OnFinishCallbackSet != null)
			{
				Action<int>[] array = this.OnFinishCallbackSet.ToArray<Action<int>>();
				for (int i = 0; i < array.Length; i++)
				{
					array[i](handle);
				}
			}
			EventSystem.Instance.Emit<int, string, bool>(EEventName.FinishEffect, this.Id, "KuroEffectHandle.OnAfterFinish", true);
			EffectSystem.Instance.RemoveKuroEffectHandle(this.Id);
		}

		// Token: 0x06047CAE RID: 294062 RVA: 0x0125DA0A File Offset: 0x0125BC0A
		[NullableContext(1)]
		public void AddFinishCallback(Action<int> callback)
		{
			if (callback == null)
			{
				return;
			}
			if (this.OnFinishCallbackSet == null)
			{
				this.OnFinishCallbackSet = new HashSet<Action<int>>();
			}
			if (!this.OnFinishCallbackSet.Contains(callback))
			{
				this.OnFinishCallbackSet.Add(callback);
			}
		}

		// Token: 0x06047CAF RID: 294063 RVA: 0x0125DA3E File Offset: 0x0125BC3E
		[NullableContext(1)]
		public bool RemoveFinishCallback(Action<int> callback)
		{
			return this.OnFinishCallbackSet != null && this.OnFinishCallbackSet.Remove(callback);
		}

		// Token: 0x06047CB0 RID: 294064 RVA: 0x0125DA56 File Offset: 0x0125BC56
		public void OnBeforeInitCallback(int handle)
		{
			if (handle != this.Id && this.Id != 0)
			{
				return;
			}
			Action<int> beforeInitCallback = this.BeforeInitCallback;
			if (beforeInitCallback == null)
			{
				return;
			}
			beforeInitCallback(handle);
		}

		// Token: 0x06047CB1 RID: 294065 RVA: 0x0125DA7B File Offset: 0x0125BC7B
		public void OnEffectInitCallback(byte result, int handle)
		{
			if (handle != this.Id && this.Id != 0)
			{
				return;
			}
			Action<ELoadEffectResult, int> effectInitCallback = this.EffectInitCallback;
			if (effectInitCallback == null)
			{
				return;
			}
			effectInitCallback((ELoadEffectResult)result, handle);
		}

		// Token: 0x06047CB2 RID: 294066 RVA: 0x0125DAA4 File Offset: 0x0125BCA4
		public void OnBeforePlayCallback(int handle)
		{
			if (handle != this.Id && this.Id != 0)
			{
				return;
			}
			this.IsDoneInternal = true;
			Action<int> beforePlayCallback = this.BeforePlayCallback;
			if (beforePlayCallback != null)
			{
				beforePlayCallback(handle);
			}
			EventSystem.Instance.Emit<int, string>(EEventName.BeforePlayEffect, this.Id, "KuroEffectHandle.OnBeforePlay");
		}

		// Token: 0x06047CB3 RID: 294067 RVA: 0x0125DAF8 File Offset: 0x0125BCF8
		public void OnInitCallbackClear()
		{
			if (this._beforeInitDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<int>(this.OnBeforeInitCallback));
				this._beforeInitDelegate = null;
			}
			if (this._initDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<byte, int>(this.OnEffectInitCallback));
				this._initDelegate = null;
			}
			if (this._beforePlayDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<int>(this.OnBeforePlayCallback));
				this._beforePlayDelegate = null;
			}
			if (this._clearDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.OnInitCallbackClear));
				this._clearDelegate = null;
			}
			this.BeforeInitCallback = null;
			this.EffectInitCallback = null;
			this.BeforePlayCallback = null;
		}

		// Token: 0x06047CB4 RID: 294068 RVA: 0x0125DB9C File Offset: 0x0125BD9C
		[NullableContext(1)]
		public void RegisterDynamicEffectInitCallback(Action<ELoadEffectResult, int> callback)
		{
			if (this._dynamicInitDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<byte, int>(this.OnDynamicEffectInitCallback));
				DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.OnDynamicEffectInitCallbackClear));
				this._dynamicInitDelegate = null;
				this._dynamicClearDelegate = null;
			}
			this.DynamicEffectInitCallback = callback;
			this._dynamicInitDelegate = DelegateUtils.ToManualReleaseDelegate<FKuroEffectInitCallback>(new Action<byte, int>(this.OnDynamicEffectInitCallback));
			this._dynamicClearDelegate = DelegateUtils.ToManualReleaseDelegate<FKuroEffectOnClearCallback>(new Action(this.OnDynamicEffectInitCallbackClear));
			UKuroEffectSystemFunctionLibrary.DynamicRegisterSpawnCallback(this.Id, this._dynamicInitDelegate, this._dynamicClearDelegate);
		}

		// Token: 0x06047CB5 RID: 294069 RVA: 0x0125DC2D File Offset: 0x0125BE2D
		private void OnDynamicEffectInitCallback(byte result, int handle)
		{
			if (handle != this.Id && this.Id != 0)
			{
				return;
			}
			Action<ELoadEffectResult, int> dynamicEffectInitCallback = this.DynamicEffectInitCallback;
			if (dynamicEffectInitCallback == null)
			{
				return;
			}
			dynamicEffectInitCallback((ELoadEffectResult)result, handle);
		}

		// Token: 0x06047CB6 RID: 294070 RVA: 0x0125DC54 File Offset: 0x0125BE54
		private void OnDynamicEffectInitCallbackClear()
		{
			if (this._dynamicInitDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<byte, int>(this.OnDynamicEffectInitCallback));
				this._dynamicInitDelegate = null;
			}
			if (this._dynamicClearDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.OnDynamicEffectInitCallbackClear));
				this._dynamicClearDelegate = null;
			}
			this.DynamicEffectInitCallback = null;
		}

		// Token: 0x04025BD4 RID: 154580
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private HashSet<Action<int>> OnFinishCallbackSet;

		// Token: 0x04025BD5 RID: 154581
		private Action<int> BeforeInitCallback;

		// Token: 0x04025BD6 RID: 154582
		private Action<ELoadEffectResult, int> EffectInitCallback;

		// Token: 0x04025BD7 RID: 154583
		private Action<int> BeforePlayCallback;

		// Token: 0x04025BD8 RID: 154584
		private Action<ELoadEffectResult, int> DynamicEffectInitCallback;

		// Token: 0x04025BD9 RID: 154585
		private EffectContext Context;

		// Token: 0x04025BDA RID: 154586
		public Func<int, bool> OnCustomCheckOwner;

		// Token: 0x04025BDB RID: 154587
		private FKuroEffectBeforeInitCallback _beforeInitDelegate;

		// Token: 0x04025BDC RID: 154588
		private FKuroEffectInitCallback _initDelegate;

		// Token: 0x04025BDD RID: 154589
		private FKuroEffectBeforePlayCallback _beforePlayDelegate;

		// Token: 0x04025BDE RID: 154590
		private FKuroEffectOnClearCallback _clearDelegate;

		// Token: 0x04025BDF RID: 154591
		private FKuroEffectFinishCallback _finishDelegate;

		// Token: 0x04025BE0 RID: 154592
		private FKuroEffectOnClearCallback _finishClearDelegate;

		// Token: 0x04025BE1 RID: 154593
		private FKuroEffectInitCallback _dynamicInitDelegate;

		// Token: 0x04025BE2 RID: 154594
		private FKuroEffectOnClearCallback _dynamicClearDelegate;

		// Token: 0x04025BE3 RID: 154595
		private bool IsDoneInternal;

		// Token: 0x04025BE4 RID: 154596
		private bool NotRecordInternal;

		// Token: 0x04025BE5 RID: 154597
		private bool HasRegisterFinishCallback;
	}
}
