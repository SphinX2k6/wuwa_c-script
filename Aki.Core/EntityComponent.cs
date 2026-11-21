using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;

// Token: 0x02000081 RID: 129
[NullableContext(1)]
[Nullable(0)]
[Obfuscation(Feature = "ClassName")]
[OverrideFunctionRoot]
public abstract class EntityComponent : IEntityComponentCleaner
{
	// Token: 0x1700008E RID: 142
	// (get) Token: 0x060003E4 RID: 996 RVA: 0x00017231 File Offset: 0x00015431
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public virtual Type[] Dependencies
	{
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		get
		{
			return null;
		}
	}

	// Token: 0x1700008F RID: 143
	// (get) Token: 0x060003E5 RID: 997 RVA: 0x00017234 File Offset: 0x00015434
	public bool Valid
	{
		get
		{
			return this.EntityInternal != null && !this.EntityInternal.IsClear;
		}
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x00017250 File Offset: 0x00015450
	public EntityComponent()
	{
		this.NeedEnable = this.NeedEnableInternal;
		this.NeedDisable = this.NeedDisableInternal;
		this.NeedTick = this.NeedTickInternal;
		this.NeedForceTick = this.NeedForceTickInternal;
		this.NeedAfterTick = this.NeedAfterTickInternal;
		this.NeedForceAfterTick = this.NeedForceAfterTickInternal;
		this.NeedChangeTimeDilation = this.NeedChangeTimeDilationInternal;
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x000172D4 File Offset: 0x000154D4
	private void ClearInternal()
	{
		this.DisableHandlesMap.Clear();
		this.DisableCount = 0;
		this.EntityInternal = null;
	}

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x060003E8 RID: 1000 RVA: 0x000172EF File Offset: 0x000154EF
	public Entity Entity
	{
		get
		{
			return this.EntityInternal;
		}
	}

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x060003E9 RID: 1001 RVA: 0x000172F7 File Offset: 0x000154F7
	public bool Active
	{
		get
		{
			Entity entityInternal = this.EntityInternal;
			return entityInternal != null && entityInternal.Active && this.ActiveInternal;
		}
	}

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x060003EA RID: 1002 RVA: 0x00017315 File Offset: 0x00015515
	public float TimeDilation
	{
		get
		{
			return this.Entity.TimeDilation;
		}
	}

	// Token: 0x060003EB RID: 1003 RVA: 0x00017324 File Offset: 0x00015524
	private unsafe bool Do(Func<EntityComponent, bool> handle, string name)
	{
		try
		{
			if (!handle(this))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Entity;
				ELogAuthor author = ELogAuthor.LCC;
				string message = "组件生命周期执行失败";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("name", name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Id", this.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("entity", this.Entity.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("component", base.GetType().Name);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				return false;
			}
		}
		catch (Exception ex) when (1)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.LCC;
			string message2 = "组件生命周期执行异常";
			Exception error = ex;
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("name", name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Id", this.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("entity", this.Entity.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("component", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("error", ex.Message);
			instance2.ErrorWithStack(module2, author2, message2, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 5));
			return false;
		}
		return true;
	}

	// Token: 0x060003EC RID: 1004 RVA: 0x000174E8 File Offset: 0x000156E8
	[NullableContext(2)]
	private unsafe bool Do<T>([Nullable(new byte[]
	{
		1,
		1,
		2
	})] Func<EntityComponent, T, bool> handle, [Nullable(1)] string name, T param = default(T))
	{
		try
		{
			if (!handle(this, param))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Entity;
				ELogAuthor author = ELogAuthor.LCC;
				string message = "组件生命周期执行失败";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("name", name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Id", this.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("entity", this.Entity.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("component", base.GetType().Name);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				return false;
			}
		}
		catch (Exception ex) when (1)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.LCC;
			string message2 = "组件生命周期执行异常";
			Exception error = ex;
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("name", name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Id", this.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("entity", this.Entity.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("component", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("error", ex.Message);
			instance2.ErrorWithStack(module2, author2, message2, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 5));
			return false;
		}
		return true;
	}

	// Token: 0x060003ED RID: 1005 RVA: 0x000176AC File Offset: 0x000158AC
	public bool Create(Entity entity, [Nullable(2)] IEntityArgs args = null)
	{
		this.EntityInternal = entity;
		if (!this.NeedCreateInternal)
		{
			return true;
		}
		return this.Do<IEntityArgs>((EntityComponent self, [Nullable(2)] IEntityArgs param) => self.OnCreate(param), "Create", args);
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x000176EA File Offset: 0x000158EA
	public bool Respawn(Entity entity, [Nullable(2)] IEntityArgs args = null)
	{
		this.EntityInternal = entity;
		if (!this.NeedCreateInternal)
		{
			return true;
		}
		return this.Do<IEntityArgs>((EntityComponent self, [Nullable(2)] IEntityArgs param) => self.OnCreate(param), "Create", args);
	}

	// Token: 0x060003EF RID: 1007 RVA: 0x00017728 File Offset: 0x00015928
	public bool RespawnNew(Entity entity)
	{
		this.EntityInternal = entity;
		return true;
	}

	// Token: 0x060003F0 RID: 1008 RVA: 0x00017732 File Offset: 0x00015932
	[NullableContext(2)]
	public bool InitData(IEntityArgs args = null)
	{
		return this.OnInitData(args);
	}

	// Token: 0x060003F1 RID: 1009 RVA: 0x0001773B File Offset: 0x0001593B
	public bool Init()
	{
		if (!this.NeedInitInternal)
		{
			return true;
		}
		return this.Do((EntityComponent self) => self.OnInit(), "OnInit");
	}

	// Token: 0x060003F2 RID: 1010 RVA: 0x00017771 File Offset: 0x00015971
	public bool Deinit()
	{
		if (!this.NeedDeinitInternal)
		{
			return true;
		}
		return this.Do((EntityComponent self) => self.OnDeinit(), "OnDeinit");
	}

	// Token: 0x060003F3 RID: 1011 RVA: 0x000177A8 File Offset: 0x000159A8
	public bool Clear()
	{
		if (!this.NeedClearInternal)
		{
			this.ClearInternal();
			return true;
		}
		bool result = this.Do((EntityComponent self) => self.OnClear(), "OnClear");
		this.ClearInternal();
		return result;
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x000177F5 File Offset: 0x000159F5
	public bool Start()
	{
		if (!this.NeedStartInternal)
		{
			return true;
		}
		return this.Do((EntityComponent self) => self.OnStart(), "OnStart");
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x0001782B File Offset: 0x00015A2B
	public void Activate()
	{
		if (!this.NeedActivateInternal)
		{
			return;
		}
		this.Do(delegate(EntityComponent self)
		{
			self.OnActivate();
			return true;
		}, "OnActivate");
	}

	// Token: 0x060003F6 RID: 1014 RVA: 0x00017861 File Offset: 0x00015A61
	public void PostActivate()
	{
		if (!this.NeedPostActivateInternal)
		{
			return;
		}
		this.Do(delegate(EntityComponent self)
		{
			self.OnPostActivate();
			return true;
		}, "OnPostActivate");
	}

	// Token: 0x060003F7 RID: 1015 RVA: 0x00017897 File Offset: 0x00015A97
	public virtual bool End()
	{
		if (!this.NeedEndInternal)
		{
			return true;
		}
		return this.Do((EntityComponent self) => self.OnEnd(), "OnEnd");
	}

	// Token: 0x060003F8 RID: 1016 RVA: 0x000178D0 File Offset: 0x00015AD0
	public void RefreshEnable(EEntityDisableKey reason)
	{
		bool activeInternal = this.ActiveInternal;
		this.ActiveInternal = (this.DisableHandlesMap.Count == 0 && this.DisableKeysMap.Count == 0);
		if (this.EntityInternal != null)
		{
			this.ActiveInternal = (this.ActiveInternal && this.EntityInternal.Active);
		}
		if (this.ActiveInternal == activeInternal)
		{
			return;
		}
		if (this.ActiveInternal)
		{
			if (this.NeedEnable)
			{
				this.Do(delegate(EntityComponent self)
				{
					self.OnEnable();
					return true;
				}, "OnEnable");
				return;
			}
		}
		else if (this.NeedDisable)
		{
			string param2 = reason.ToString();
			this.Do<string>(delegate(EntityComponent self, [Nullable(2)] string param)
			{
				self.OnDisable(param);
				return true;
			}, "OnDisable", param2);
		}
	}

	// Token: 0x060003F9 RID: 1017 RVA: 0x000179B4 File Offset: 0x00015BB4
	public void RefreshEnable(string reason)
	{
		bool activeInternal = this.ActiveInternal;
		this.ActiveInternal = (this.DisableHandlesMap.Count == 0 && this.DisableKeysMap.Count == 0);
		if (this.EntityInternal != null)
		{
			this.ActiveInternal = (this.ActiveInternal && this.EntityInternal.Active);
		}
		if (this.ActiveInternal == activeInternal)
		{
			return;
		}
		if (this.ActiveInternal)
		{
			if (this.NeedEnable)
			{
				this.Do(delegate(EntityComponent self)
				{
					self.OnEnable();
					return true;
				}, "OnEnable");
				return;
			}
		}
		else if (this.NeedDisable)
		{
			this.Do<string>(delegate(EntityComponent self, [Nullable(2)] string param)
			{
				self.OnDisable(param);
				return true;
			}, "OnDisable", reason);
		}
	}

	// Token: 0x060003FA RID: 1018 RVA: 0x00017A8C File Offset: 0x00015C8C
	public unsafe bool Enable(int? handle, string reason)
	{
		if (handle != null)
		{
			int? num = handle;
			int num2 = 0;
			if (!(num.GetValueOrDefault() == num2 & num != null) && this.DisableHandlesMap.Remove(handle.Value))
			{
				this.RefreshEnable(reason);
				return true;
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Entity;
		ELogAuthor author = ELogAuthor.LCC;
		string message = "组件激活失败句柄不存在";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", this.Entity.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityName", base.GetType().Name);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Handle", handle);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Reason", reason);
		instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		return false;
	}

	// Token: 0x060003FB RID: 1019 RVA: 0x00017B7C File Offset: 0x00015D7C
	public unsafe int Disable(string reason)
	{
		if (string.IsNullOrEmpty(reason))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "Disable的Reason不能使用undefined";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Component", base.GetType().Name);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		else if (reason.Length < 4)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "Disable的Reason字符串长度必须大于等于限制字符数量";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Component", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("限制的字符数量", 4);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		int num = this.DisableCount + 1;
		this.DisableCount = num;
		int num2 = num;
		this.DisableHandlesMap[num2] = reason;
		this.RefreshEnable(reason);
		return num2;
	}

	// Token: 0x060003FC RID: 1020 RVA: 0x00017C70 File Offset: 0x00015E70
	public void EnableByKey(EEntityDisableKey key, bool removeAll = true)
	{
		int num;
		if (!this.DisableKeysMap.TryGetValue(key, out num) || num <= 0)
		{
			this.DisableKeysMap.Remove(key);
			return;
		}
		if (!removeAll && num > 1)
		{
			this.DisableKeysMap[key] = num - 1;
		}
		else
		{
			this.DisableKeysMap.Remove(key);
		}
		this.RefreshEnable(key);
	}

	// Token: 0x060003FD RID: 1021 RVA: 0x00017CCC File Offset: 0x00015ECC
	public void DisableByKey(EEntityDisableKey reasonKey, bool noDuplicate = true)
	{
		int num = Math.Max(0, this.DisableKeysMap.GetValueOrDefault(reasonKey, 0));
		if (noDuplicate && num > 0)
		{
			return;
		}
		this.DisableKeysMap[reasonKey] = num + 1;
		this.RefreshEnable(reasonKey);
	}

	// Token: 0x060003FE RID: 1022 RVA: 0x00017D0C File Offset: 0x00015F0C
	public unsafe void Tick(float delta)
	{
		if (!this.Active)
		{
			return;
		}
		try
		{
			this.OnTick(delta);
		}
		catch (Exception ex) when (1)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "组件 Tick 异常";
			Exception error = ex;
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("entity", this.Entity.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("component", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("error", ex.Message);
			instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
	}

	// Token: 0x060003FF RID: 1023 RVA: 0x00017E08 File Offset: 0x00016008
	public unsafe void ForceTick(float delta)
	{
		if (!this.Active)
		{
			return;
		}
		try
		{
			this.OnForceTick(delta);
		}
		catch (Exception ex) when (1)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "组件 ForceTick 异常";
			Exception error = ex;
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("entity", this.Entity.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("component", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("error", ex.Message);
			instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
	}

	// Token: 0x06000400 RID: 1024 RVA: 0x00017F04 File Offset: 0x00016104
	public unsafe void AfterTick(float delta)
	{
		if (!this.Active)
		{
			return;
		}
		try
		{
			this.OnAfterTick(delta);
		}
		catch (Exception ex) when (1)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "组件 AfterTick 异常";
			Exception error = ex;
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("entity", this.Entity.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("component", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("error", ex.Message);
			instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
	}

	// Token: 0x06000401 RID: 1025 RVA: 0x00018000 File Offset: 0x00016200
	public unsafe void ForceAfterTick(float delta)
	{
		if (!this.Active)
		{
			return;
		}
		try
		{
			this.OnForceAfterTick(delta);
		}
		catch (Exception ex) when (1)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "组件 ForceAfterTick 异常";
			Exception error = ex;
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("entity", this.Entity.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("component", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("error", ex.Message);
			instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
	}

	// Token: 0x06000402 RID: 1026 RVA: 0x000180FC File Offset: 0x000162FC
	public void SetTimeDilation(float timeDilation)
	{
		if (!this.NeedChangeTimeDilation)
		{
			return;
		}
		this.Do<float>(delegate(EntityComponent self, float param)
		{
			self.OnChangeTimeDilation(param);
			return true;
		}, "OnChangeTimeDilation", timeDilation);
	}

	// Token: 0x06000403 RID: 1027 RVA: 0x00018133 File Offset: 0x00016333
	[NullableContext(2)]
	[OverrideFunction]
	protected virtual bool OnCreate(IEntityArgs args = null)
	{
		return true;
	}

	// Token: 0x06000404 RID: 1028 RVA: 0x00018136 File Offset: 0x00016336
	[NullableContext(2)]
	protected virtual bool OnInitData(IEntityArgs args = null)
	{
		return true;
	}

	// Token: 0x06000405 RID: 1029 RVA: 0x00018139 File Offset: 0x00016339
	[OverrideFunction]
	protected virtual bool OnInit()
	{
		return true;
	}

	// Token: 0x06000406 RID: 1030 RVA: 0x0001813C File Offset: 0x0001633C
	[OverrideFunction]
	protected virtual bool OnDeinit()
	{
		return true;
	}

	// Token: 0x06000407 RID: 1031 RVA: 0x0001813F File Offset: 0x0001633F
	[OverrideFunction]
	protected virtual bool OnClear()
	{
		return true;
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x00018142 File Offset: 0x00016342
	[OverrideFunction]
	protected virtual bool OnStart()
	{
		return true;
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x00018145 File Offset: 0x00016345
	[OverrideFunction]
	protected virtual void OnActivate()
	{
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x00018147 File Offset: 0x00016347
	[OverrideFunction]
	protected virtual void OnPostActivate()
	{
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x00018149 File Offset: 0x00016349
	[OverrideFunction]
	protected virtual bool OnEnd()
	{
		return true;
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x0001814C File Offset: 0x0001634C
	[OverrideFunction]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x0600040D RID: 1037 RVA: 0x0001814E File Offset: 0x0001634E
	[OverrideFunction]
	protected virtual void OnDisable(string reason)
	{
	}

	// Token: 0x0600040E RID: 1038 RVA: 0x00018150 File Offset: 0x00016350
	[OverrideFunction]
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x0600040F RID: 1039 RVA: 0x00018152 File Offset: 0x00016352
	[OverrideFunction]
	protected virtual void OnForceTick(float delta)
	{
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x00018154 File Offset: 0x00016354
	[OverrideFunction]
	protected virtual void OnAfterTick(float delta)
	{
	}

	// Token: 0x06000411 RID: 1041 RVA: 0x00018156 File Offset: 0x00016356
	[OverrideFunction]
	protected virtual void OnForceAfterTick(float delta)
	{
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x00018158 File Offset: 0x00016358
	[OverrideFunction]
	protected virtual void OnChangeTimeDilation(float timeDilation)
	{
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x0001815A File Offset: 0x0001635A
	[OverrideFunction]
	public virtual void OnEntityWasRecentlyRenderedOnScreenChange(bool wasRecentlyRenderedOnScreen)
	{
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x0001815C File Offset: 0x0001635C
	[OverrideFunction]
	public virtual void OnEntityBudgetTickEnableChange(bool enable)
	{
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x00018160 File Offset: 0x00016360
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 3);
		defaultInterpolatedStringHandler.AppendLiteral("[object ");
		defaultInterpolatedStringHandler.AppendFormatted(base.GetType().Name);
		defaultInterpolatedStringHandler.AppendLiteral("(Id=");
		Entity entityInternal = this.EntityInternal;
		defaultInterpolatedStringHandler.AppendFormatted<int?>((entityInternal != null) ? new int?(entityInternal.Id) : null);
		defaultInterpolatedStringHandler.AppendLiteral(")");
		defaultInterpolatedStringHandler.AppendFormatted(this.Valid ? "" : "(D)");
		defaultInterpolatedStringHandler.AppendLiteral("]");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06000416 RID: 1046 RVA: 0x00018204 File Offset: 0x00016404
	public string DumpDisableInfo()
	{
		List<string> list = new List<string>();
		string value = "";
		foreach (KeyValuePair<int, string> keyValuePair in this.DisableHandlesMap)
		{
			List<string> list2 = list;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 4);
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("{Component:");
			defaultInterpolatedStringHandler.AppendFormatted(base.GetType().Name);
			defaultInterpolatedStringHandler.AppendLiteral(",Handle:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(keyValuePair.Key);
			defaultInterpolatedStringHandler.AppendLiteral(",Reason:");
			defaultInterpolatedStringHandler.AppendFormatted(keyValuePair.Value);
			defaultInterpolatedStringHandler.AppendLiteral("}");
			list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
			value = " ";
		}
		return string.Join("", list);
	}

	// Token: 0x06000417 RID: 1047 RVA: 0x000182F0 File Offset: 0x000164F0
	protected unsafe bool CheckClearObject(bool success, string objectName)
	{
		if (success)
		{
			return true;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Entity;
		ELogAuthor author = ELogAuthor.CJH;
		string message = "组件存在未定义清理方式的Object";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Component", base.GetType().Name);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Object", objectName);
		instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return false;
	}

	// Token: 0x06000418 RID: 1048 RVA: 0x00018360 File Offset: 0x00016560
	[NullableContext(2)]
	public static bool operator !(EntityComponent component)
	{
		return component == null || !component.Valid;
	}

	// Token: 0x06000419 RID: 1049 RVA: 0x00018370 File Offset: 0x00016570
	public virtual bool ClearComponent(EntityComponent componentTemplate)
	{
		if (componentTemplate.EntityInternal == null)
		{
			this.EntityInternal = null;
		}
		else if (!this.CheckClearObject(EntityComponentSystem.ClearObject(this.EntityInternal), "EntityInternal"))
		{
			return false;
		}
		this.DisableCount = componentTemplate.DisableCount;
		if (componentTemplate.DisableHandlesMap != null && !this.CheckClearObject(EntityComponentSystem.ClearObject(this.DisableHandlesMap), "DisableHandlesMap"))
		{
			return false;
		}
		if (componentTemplate.DisableKeysMap != null && !this.CheckClearObject(EntityComponentSystem.ClearObject(this.DisableKeysMap), "DisableKeysMap"))
		{
			return false;
		}
		this.ActiveInternal = componentTemplate.ActiveInternal;
		return true;
	}

	// Token: 0x17000093 RID: 147
	// (get) Token: 0x0600041A RID: 1050 RVA: 0x00018407 File Offset: 0x00016607
	public virtual bool NeedCreateInternal
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x0600041B RID: 1051 RVA: 0x0001840A File Offset: 0x0001660A
	public virtual bool NeedInitInternal
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x0600041C RID: 1052 RVA: 0x0001840D File Offset: 0x0001660D
	public virtual bool NeedDeinitInternal
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x0600041D RID: 1053 RVA: 0x00018410 File Offset: 0x00016610
	public virtual bool NeedClearInternal
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x0600041E RID: 1054 RVA: 0x00018413 File Offset: 0x00016613
	public virtual bool NeedStartInternal
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x0600041F RID: 1055 RVA: 0x00018416 File Offset: 0x00016616
	public virtual bool NeedActivateInternal
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x06000420 RID: 1056 RVA: 0x00018419 File Offset: 0x00016619
	public virtual bool NeedPostActivateInternal
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x06000421 RID: 1057 RVA: 0x0001841C File Offset: 0x0001661C
	public virtual bool NeedEndInternal
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x06000422 RID: 1058 RVA: 0x0001841F File Offset: 0x0001661F
	public virtual bool NeedEnableInternal
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x06000423 RID: 1059 RVA: 0x00018422 File Offset: 0x00016622
	public virtual bool NeedDisableInternal
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x06000424 RID: 1060 RVA: 0x00018425 File Offset: 0x00016625
	public virtual bool NeedTickInternal
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x06000425 RID: 1061 RVA: 0x00018428 File Offset: 0x00016628
	public virtual bool NeedForceTickInternal
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x06000426 RID: 1062 RVA: 0x0001842B File Offset: 0x0001662B
	public virtual bool NeedAfterTickInternal
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x06000427 RID: 1063 RVA: 0x0001842E File Offset: 0x0001662E
	public virtual bool NeedForceAfterTickInternal
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x06000428 RID: 1064 RVA: 0x00018431 File Offset: 0x00016631
	public virtual bool NeedChangeTimeDilationInternal
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x06000429 RID: 1065 RVA: 0x00018434 File Offset: 0x00016634
	public virtual bool NeedEntityWasRecentlyRenderedOnScreenChangeInternal
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x0600042A RID: 1066 RVA: 0x00018437 File Offset: 0x00016637
	public virtual bool NeedEntityBudgetTickEnableChangeInternal
	{
		get
		{
			return false;
		}
	}

	// Token: 0x040003AA RID: 938
	public const int DISABLE_REASON_LENGTH_LIMIT = 4;

	// Token: 0x040003AB RID: 939
	[Nullable(2)]
	private Entity EntityInternal;

	// Token: 0x040003AC RID: 940
	private int DisableCount;

	// Token: 0x040003AD RID: 941
	private readonly Dictionary<int, string> DisableHandlesMap = new Dictionary<int, string>();

	// Token: 0x040003AE RID: 942
	private readonly Dictionary<EEntityDisableKey, int> DisableKeysMap = new Dictionary<EEntityDisableKey, int>();

	// Token: 0x040003AF RID: 943
	public readonly bool NeedEnable;

	// Token: 0x040003B0 RID: 944
	public readonly bool NeedDisable;

	// Token: 0x040003B1 RID: 945
	public readonly bool NeedTick;

	// Token: 0x040003B2 RID: 946
	public readonly bool NeedForceTick;

	// Token: 0x040003B3 RID: 947
	public readonly bool NeedAfterTick;

	// Token: 0x040003B4 RID: 948
	public readonly bool NeedForceAfterTick;

	// Token: 0x040003B5 RID: 949
	public readonly bool NeedChangeTimeDilation;

	// Token: 0x040003B6 RID: 950
	private bool ActiveInternal = true;
}
