using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005240 RID: 21056
	public struct IFightInteractComponent : IFlatbufferObject
	{
		// Token: 0x17009A40 RID: 39488
		// (get) Token: 0x060223EF RID: 140271 RVA: 0x004BFFAC File Offset: 0x004BE1AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060223F0 RID: 140272 RVA: 0x004BFFB9 File Offset: 0x004BE1B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060223F1 RID: 140273 RVA: 0x004BFFC0 File Offset: 0x004BE1C0
		public static IFightInteractComponent GetRootAsIFightInteractComponent(ByteBuffer _bb)
		{
			return IFightInteractComponent.GetRootAsIFightInteractComponent(_bb, default(IFightInteractComponent));
		}

		// Token: 0x060223F2 RID: 140274 RVA: 0x004BFFDC File Offset: 0x004BE1DC
		public static IFightInteractComponent GetRootAsIFightInteractComponent(ByteBuffer _bb, IFightInteractComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060223F3 RID: 140275 RVA: 0x004BFFF9 File Offset: 0x004BE1F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060223F4 RID: 140276 RVA: 0x004C0008 File Offset: 0x004BE208
		public IFightInteractComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A41 RID: 39489
		// (get) Token: 0x060223F5 RID: 140277 RVA: 0x004C0018 File Offset: 0x004BE218
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009A42 RID: 39490
		// (get) Token: 0x060223F6 RID: 140278 RVA: 0x004C0058 File Offset: 0x004BE258
		public int LockRange
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009A43 RID: 39491
		// (get) Token: 0x060223F7 RID: 140279 RVA: 0x004C0094 File Offset: 0x004BE294
		public IVectorInfo? LockOffset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009A44 RID: 39492
		// (get) Token: 0x060223F8 RID: 140280 RVA: 0x004C00F4 File Offset: 0x004BE2F4
		public bool DisableLock
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009A45 RID: 39493
		// (get) Token: 0x060223F9 RID: 140281 RVA: 0x004C0134 File Offset: 0x004BE334
		public IAutoLockControl? LockControl
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IAutoLockControl?(default(IAutoLockControl).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009A46 RID: 39494
		// (get) Token: 0x060223FA RID: 140282 RVA: 0x004C0194 File Offset: 0x004BE394
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060223FB RID: 140283 RVA: 0x004C01D1 File Offset: 0x004BE3D1
		public static Offset<IFightInteractComponent> CreateIFightInteractComponent(FlatBufferBuilder builder, bool Disabled = false, int LockRange = 0, Offset<IVectorInfo> LockOffsetOffset = default(Offset<IVectorInfo>), bool DisableLock = false, Offset<IAutoLockControl> LockControlOffset = default(Offset<IAutoLockControl>), byte NullMask = 0)
		{
			builder.StartTable(6);
			IFightInteractComponent.AddLockControl(builder, LockControlOffset);
			IFightInteractComponent.AddLockOffset(builder, LockOffsetOffset);
			IFightInteractComponent.AddLockRange(builder, LockRange);
			IFightInteractComponent.AddNullMask(builder, NullMask);
			IFightInteractComponent.AddDisableLock(builder, DisableLock);
			IFightInteractComponent.AddDisabled(builder, Disabled);
			return IFightInteractComponent.EndIFightInteractComponent(builder);
		}

		// Token: 0x060223FC RID: 140284 RVA: 0x004C020D File Offset: 0x004BE40D
		public static void StartIFightInteractComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060223FD RID: 140285 RVA: 0x004C0216 File Offset: 0x004BE416
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060223FE RID: 140286 RVA: 0x004C0221 File Offset: 0x004BE421
		public static void AddLockRange(FlatBufferBuilder builder, int lockRange)
		{
			builder.AddInt(1, lockRange, 0);
		}

		// Token: 0x060223FF RID: 140287 RVA: 0x004C022C File Offset: 0x004BE42C
		public static void AddLockOffset(FlatBufferBuilder builder, Offset<IVectorInfo> lockOffsetOffset)
		{
			builder.AddOffset(2, lockOffsetOffset.Value, 0);
		}

		// Token: 0x06022400 RID: 140288 RVA: 0x004C023C File Offset: 0x004BE43C
		public static void AddDisableLock(FlatBufferBuilder builder, bool disableLock)
		{
			builder.AddBool(3, disableLock, false);
		}

		// Token: 0x06022401 RID: 140289 RVA: 0x004C0247 File Offset: 0x004BE447
		public static void AddLockControl(FlatBufferBuilder builder, Offset<IAutoLockControl> lockControlOffset)
		{
			builder.AddOffset(4, lockControlOffset.Value, 0);
		}

		// Token: 0x06022402 RID: 140290 RVA: 0x004C0257 File Offset: 0x004BE457
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06022403 RID: 140291 RVA: 0x004C0262 File Offset: 0x004BE462
		public static Offset<IFightInteractComponent> EndIFightInteractComponent(FlatBufferBuilder builder)
		{
			return new Offset<IFightInteractComponent>(builder.EndTable());
		}

		// Token: 0x06022404 RID: 140292 RVA: 0x004C0270 File Offset: 0x004BE470
		public IFightInteractComponentT UnPack()
		{
			IFightInteractComponentT fightInteractComponentT = new IFightInteractComponentT();
			this.UnPackTo(fightInteractComponentT);
			return fightInteractComponentT;
		}

		// Token: 0x06022405 RID: 140293 RVA: 0x004C028C File Offset: 0x004BE48C
		public void UnPackTo(IFightInteractComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.LockRange = this.LockRange;
			_o.LockOffset = ((this.LockOffset != null) ? this.LockOffset.Value.UnPack() : null);
			_o.DisableLock = this.DisableLock;
			_o.LockControl = ((this.LockControl != null) ? this.LockControl.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022406 RID: 140294 RVA: 0x004C0328 File Offset: 0x004BE528
		public static Offset<IFightInteractComponent> Pack(FlatBufferBuilder builder, IFightInteractComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFightInteractComponent>);
			}
			Offset<IVectorInfo> lockOffsetOffset = (_o.LockOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.LockOffset);
			Offset<IAutoLockControl> lockControlOffset = (_o.LockControl == null) ? default(Offset<IAutoLockControl>) : IAutoLockControl.Pack(builder, _o.LockControl);
			return IFightInteractComponent.CreateIFightInteractComponent(builder, _o.Disabled, _o.LockRange, lockOffsetOffset, _o.DisableLock, lockControlOffset, _o.NullMask);
		}

		// Token: 0x0400E388 RID: 58248
		private Table __p;
	}
}
