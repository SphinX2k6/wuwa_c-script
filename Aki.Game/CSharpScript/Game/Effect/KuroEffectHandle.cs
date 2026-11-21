using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Effect
{
	// Token: 0x020063F0 RID: 25584
	[NullableContext(2)]
	[Nullable(0)]
	public class KuroEffectHandle
	{
		// Token: 0x170075E9 RID: 30185
		// (get) Token: 0x0603E05A RID: 254042 RVA: 0x011FDF9D File Offset: 0x011FC19D
		// (set) Token: 0x0603E05B RID: 254043 RVA: 0x011FDFA5 File Offset: 0x011FC1A5
		public int Id { get; set; }

		// Token: 0x170075EA RID: 30186
		// (get) Token: 0x0603E05C RID: 254044 RVA: 0x011FDFAE File Offset: 0x011FC1AE
		// (set) Token: 0x0603E05D RID: 254045 RVA: 0x011FDFB6 File Offset: 0x011FC1B6
		public bool IsLoop { get; set; }

		// Token: 0x0603E05E RID: 254046 RVA: 0x011FDFBF File Offset: 0x011FC1BF
		public void Init(EffectContext context, Action<int> beforeInitCallback = null, Action<ELoadEffectResult, int> callback = null, Action<int> beforePlayCallback = null)
		{
			this.Context = context;
			this.BeforeInitCallback = beforeInitCallback;
			this.EffectInitCallback = callback;
			this.BeforePlayCallback = beforePlayCallback;
		}

		// Token: 0x0603E05F RID: 254047 RVA: 0x011FDFDE File Offset: 0x011FC1DE
		public void OnAfterSpawn(int effectId)
		{
			this.Id = effectId;
			this.IsLoop = UKuroEffectSystemFunctionLibrary.EffectIsLoop(effectId);
			this.RegisterFinishCallback();
		}

		// Token: 0x0603E060 RID: 254048 RVA: 0x011FDFF9 File Offset: 0x011FC1F9
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

		// Token: 0x0603E061 RID: 254049 RVA: 0x011FE034 File Offset: 0x011FC234
		internal void OnSpawnDelegatesRegistered(FKuroEffectBeforeInitCallback beforeInitDelegate, FKuroEffectInitCallback initDelegate, FKuroEffectBeforePlayCallback beforePlayDelegate, FKuroEffectOnClearCallback clearDelegate)
		{
			this._beforeInitDelegate = beforeInitDelegate;
			this._initDelegate = initDelegate;
			this._beforePlayDelegate = beforePlayDelegate;
			this._clearDelegate = clearDelegate;
		}

		// Token: 0x0603E062 RID: 254050 RVA: 0x011FE054 File Offset: 0x011FC254
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

		// Token: 0x0603E063 RID: 254051 RVA: 0x011FE164 File Offset: 0x011FC364
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

		// Token: 0x0603E064 RID: 254052 RVA: 0x011FE21E File Offset: 0x011FC41E
		public bool IsDone()
		{
			return this.IsDoneInternal;
		}

		// Token: 0x0603E065 RID: 254053 RVA: 0x011FE226 File Offset: 0x011FC426
		public void SetNotRecord(bool value)
		{
			this.NotRecordInternal = value;
		}

		// Token: 0x0603E066 RID: 254054 RVA: 0x011FE22F File Offset: 0x011FC42F
		public bool GetNotRecord()
		{
			return this.NotRecordInternal;
		}

		// Token: 0x0603E067 RID: 254055 RVA: 0x011FE238 File Offset: 0x011FC438
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

		// Token: 0x0603E068 RID: 254056 RVA: 0x011FE29A File Offset: 0x011FC49A
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

		// Token: 0x0603E069 RID: 254057 RVA: 0x011FE2C8 File Offset: 0x011FC4C8
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

		// Token: 0x0603E06A RID: 254058 RVA: 0x011FE324 File Offset: 0x011FC524
		private void OnEffectFinish(int handle)
		{
			if (handle != this.Id && this.Id != 0)
			{
				return;
			}
			if (this.OnFinishCallbackSet != null)
			{
				Action<int>[] array = new Action<int>[this.OnFinishCallbackSet.Count];
				this.OnFinishCallbackSet.CopyTo(array);
				Action<int>[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i](handle);
				}
			}
			EventSystem.Instance.Emit<int, string, bool>(EEventName.FinishEffect, this.Id, "KuroEffectHandle.OnAfterFinish", true);
			EffectSystem.Instance.RemoveKuroEffectHandle(this.Id);
		}

		// Token: 0x0603E06B RID: 254059 RVA: 0x011FE3AD File Offset: 0x011FC5AD
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

		// Token: 0x0603E06C RID: 254060 RVA: 0x011FE3E1 File Offset: 0x011FC5E1
		[NullableContext(1)]
		public bool RemoveFinishCallback(Action<int> callback)
		{
			return this.OnFinishCallbackSet != null && this.OnFinishCallbackSet.Remove(callback);
		}

		// Token: 0x0603E06D RID: 254061 RVA: 0x011FE3F9 File Offset: 0x011FC5F9
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

		// Token: 0x0603E06E RID: 254062 RVA: 0x011FE41E File Offset: 0x011FC61E
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

		// Token: 0x0603E06F RID: 254063 RVA: 0x011FE444 File Offset: 0x011FC644
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

		// Token: 0x0603E070 RID: 254064 RVA: 0x011FE498 File Offset: 0x011FC698
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

		// Token: 0x0603E071 RID: 254065 RVA: 0x011FE53C File Offset: 0x011FC73C
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

		// Token: 0x0603E072 RID: 254066 RVA: 0x011FE5CD File Offset: 0x011FC7CD
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

		// Token: 0x0603E073 RID: 254067 RVA: 0x011FE5F4 File Offset: 0x011FC7F4
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

		// Token: 0x04020E93 RID: 134803
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private HashSet<Action<int>> OnFinishCallbackSet;

		// Token: 0x04020E94 RID: 134804
		private Action<int> BeforeInitCallback;

		// Token: 0x04020E95 RID: 134805
		private Action<ELoadEffectResult, int> EffectInitCallback;

		// Token: 0x04020E96 RID: 134806
		private Action<int> BeforePlayCallback;

		// Token: 0x04020E97 RID: 134807
		private Action<ELoadEffectResult, int> DynamicEffectInitCallback;

		// Token: 0x04020E98 RID: 134808
		private EffectContext Context;

		// Token: 0x04020E99 RID: 134809
		public Func<int, bool> OnCustomCheckOwner;

		// Token: 0x04020E9A RID: 134810
		private FKuroEffectBeforeInitCallback _beforeInitDelegate;

		// Token: 0x04020E9B RID: 134811
		private FKuroEffectInitCallback _initDelegate;

		// Token: 0x04020E9C RID: 134812
		private FKuroEffectBeforePlayCallback _beforePlayDelegate;

		// Token: 0x04020E9D RID: 134813
		private FKuroEffectOnClearCallback _clearDelegate;

		// Token: 0x04020E9E RID: 134814
		private FKuroEffectFinishCallback _finishDelegate;

		// Token: 0x04020E9F RID: 134815
		private FKuroEffectOnClearCallback _finishClearDelegate;

		// Token: 0x04020EA0 RID: 134816
		private FKuroEffectInitCallback _dynamicInitDelegate;

		// Token: 0x04020EA1 RID: 134817
		private FKuroEffectOnClearCallback _dynamicClearDelegate;

		// Token: 0x04020EA2 RID: 134818
		private bool IsDoneInternal;

		// Token: 0x04020EA3 RID: 134819
		private bool NotRecordInternal;

		// Token: 0x04020EA4 RID: 134820
		private bool HasRegisterFinishCallback;
	}
}
