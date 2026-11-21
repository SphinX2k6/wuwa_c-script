using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057A8 RID: 22440
	public struct IFightInteractComponent : IFlatbufferObject
	{
		// Token: 0x1700A23C RID: 41532
		// (get) Token: 0x06024385 RID: 148357 RVA: 0x004FAA70 File Offset: 0x004F8C70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024386 RID: 148358 RVA: 0x004FAA7D File Offset: 0x004F8C7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024387 RID: 148359 RVA: 0x004FAA84 File Offset: 0x004F8C84
		public static IFightInteractComponent GetRootAsIFightInteractComponent(ByteBuffer _bb)
		{
			return IFightInteractComponent.GetRootAsIFightInteractComponent(_bb, default(IFightInteractComponent));
		}

		// Token: 0x06024388 RID: 148360 RVA: 0x004FAAA0 File Offset: 0x004F8CA0
		public static IFightInteractComponent GetRootAsIFightInteractComponent(ByteBuffer _bb, IFightInteractComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024389 RID: 148361 RVA: 0x004FAABD File Offset: 0x004F8CBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602438A RID: 148362 RVA: 0x004FAACC File Offset: 0x004F8CCC
		public IFightInteractComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A23D RID: 41533
		// (get) Token: 0x0602438B RID: 148363 RVA: 0x004FAADC File Offset: 0x004F8CDC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A23E RID: 41534
		// (get) Token: 0x0602438C RID: 148364 RVA: 0x004FAB1C File Offset: 0x004F8D1C
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

		// Token: 0x1700A23F RID: 41535
		// (get) Token: 0x0602438D RID: 148365 RVA: 0x004FAB58 File Offset: 0x004F8D58
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

		// Token: 0x1700A240 RID: 41536
		// (get) Token: 0x0602438E RID: 148366 RVA: 0x004FABB8 File Offset: 0x004F8DB8
		public bool DisableLock
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A241 RID: 41537
		// (get) Token: 0x0602438F RID: 148367 RVA: 0x004FABF8 File Offset: 0x004F8DF8
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

		// Token: 0x1700A242 RID: 41538
		// (get) Token: 0x06024390 RID: 148368 RVA: 0x004FAC58 File Offset: 0x004F8E58
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

		// Token: 0x06024391 RID: 148369 RVA: 0x004FAC95 File Offset: 0x004F8E95
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

		// Token: 0x06024392 RID: 148370 RVA: 0x004FACD1 File Offset: 0x004F8ED1
		public static void StartIFightInteractComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06024393 RID: 148371 RVA: 0x004FACDA File Offset: 0x004F8EDA
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06024394 RID: 148372 RVA: 0x004FACE5 File Offset: 0x004F8EE5
		public static void AddLockRange(FlatBufferBuilder builder, int lockRange)
		{
			builder.AddInt(1, lockRange, 0);
		}

		// Token: 0x06024395 RID: 148373 RVA: 0x004FACF0 File Offset: 0x004F8EF0
		public static void AddLockOffset(FlatBufferBuilder builder, Offset<IVectorInfo> lockOffsetOffset)
		{
			builder.AddOffset(2, lockOffsetOffset.Value, 0);
		}

		// Token: 0x06024396 RID: 148374 RVA: 0x004FAD00 File Offset: 0x004F8F00
		public static void AddDisableLock(FlatBufferBuilder builder, bool disableLock)
		{
			builder.AddBool(3, disableLock, false);
		}

		// Token: 0x06024397 RID: 148375 RVA: 0x004FAD0B File Offset: 0x004F8F0B
		public static void AddLockControl(FlatBufferBuilder builder, Offset<IAutoLockControl> lockControlOffset)
		{
			builder.AddOffset(4, lockControlOffset.Value, 0);
		}

		// Token: 0x06024398 RID: 148376 RVA: 0x004FAD1B File Offset: 0x004F8F1B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06024399 RID: 148377 RVA: 0x004FAD26 File Offset: 0x004F8F26
		public static Offset<IFightInteractComponent> EndIFightInteractComponent(FlatBufferBuilder builder)
		{
			return new Offset<IFightInteractComponent>(builder.EndTable());
		}

		// Token: 0x0602439A RID: 148378 RVA: 0x004FAD34 File Offset: 0x004F8F34
		public IFightInteractComponentT UnPack()
		{
			IFightInteractComponentT fightInteractComponentT = new IFightInteractComponentT();
			this.UnPackTo(fightInteractComponentT);
			return fightInteractComponentT;
		}

		// Token: 0x0602439B RID: 148379 RVA: 0x004FAD50 File Offset: 0x004F8F50
		public void UnPackTo(IFightInteractComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.LockRange = this.LockRange;
			_o.LockOffset = ((this.LockOffset != null) ? this.LockOffset.Value.UnPack() : null);
			_o.DisableLock = this.DisableLock;
			_o.LockControl = ((this.LockControl != null) ? this.LockControl.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602439C RID: 148380 RVA: 0x004FADEC File Offset: 0x004F8FEC
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

		// Token: 0x0400EF8E RID: 61326
		private Table __p;
	}
}
