using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200535F RID: 21343
	public struct IHackManagementComponent : IFlatbufferObject
	{
		// Token: 0x17009CCF RID: 40143
		// (get) Token: 0x06022EA6 RID: 143014 RVA: 0x004D5FCD File Offset: 0x004D41CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022EA7 RID: 143015 RVA: 0x004D5FDA File Offset: 0x004D41DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022EA8 RID: 143016 RVA: 0x004D5FE4 File Offset: 0x004D41E4
		public static IHackManagementComponent GetRootAsIHackManagementComponent(ByteBuffer _bb)
		{
			return IHackManagementComponent.GetRootAsIHackManagementComponent(_bb, default(IHackManagementComponent));
		}

		// Token: 0x06022EA9 RID: 143017 RVA: 0x004D6000 File Offset: 0x004D4200
		public static IHackManagementComponent GetRootAsIHackManagementComponent(ByteBuffer _bb, IHackManagementComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022EAA RID: 143018 RVA: 0x004D601D File Offset: 0x004D421D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022EAB RID: 143019 RVA: 0x004D602C File Offset: 0x004D422C
		public IHackManagementComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CD0 RID: 40144
		// (get) Token: 0x06022EAC RID: 143020 RVA: 0x004D603C File Offset: 0x004D423C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009CD1 RID: 40145
		// (get) Token: 0x06022EAD RID: 143021 RVA: 0x004D607C File Offset: 0x004D427C
		public int MaxHackingCount
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

		// Token: 0x17009CD2 RID: 40146
		// (get) Token: 0x06022EAE RID: 143022 RVA: 0x004D60B8 File Offset: 0x004D42B8
		public float ValidDistance
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009CD3 RID: 40147
		// (get) Token: 0x06022EAF RID: 143023 RVA: 0x004D60F8 File Offset: 0x004D42F8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022EB0 RID: 143024 RVA: 0x004D6135 File Offset: 0x004D4335
		public static Offset<IHackManagementComponent> CreateIHackManagementComponent(FlatBufferBuilder builder, bool Disabled = false, int MaxHackingCount = 0, float ValidDistance = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IHackManagementComponent.AddValidDistance(builder, ValidDistance);
			IHackManagementComponent.AddMaxHackingCount(builder, MaxHackingCount);
			IHackManagementComponent.AddNullMask(builder, NullMask);
			IHackManagementComponent.AddDisabled(builder, Disabled);
			return IHackManagementComponent.EndIHackManagementComponent(builder);
		}

		// Token: 0x06022EB1 RID: 143025 RVA: 0x004D6161 File Offset: 0x004D4361
		public static void StartIHackManagementComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06022EB2 RID: 143026 RVA: 0x004D616A File Offset: 0x004D436A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022EB3 RID: 143027 RVA: 0x004D6175 File Offset: 0x004D4375
		public static void AddMaxHackingCount(FlatBufferBuilder builder, int maxHackingCount)
		{
			builder.AddInt(1, maxHackingCount, 0);
		}

		// Token: 0x06022EB4 RID: 143028 RVA: 0x004D6180 File Offset: 0x004D4380
		public static void AddValidDistance(FlatBufferBuilder builder, float validDistance)
		{
			builder.AddFloat(2, validDistance, 0.0);
		}

		// Token: 0x06022EB5 RID: 143029 RVA: 0x004D6193 File Offset: 0x004D4393
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06022EB6 RID: 143030 RVA: 0x004D619E File Offset: 0x004D439E
		public static Offset<IHackManagementComponent> EndIHackManagementComponent(FlatBufferBuilder builder)
		{
			return new Offset<IHackManagementComponent>(builder.EndTable());
		}

		// Token: 0x06022EB7 RID: 143031 RVA: 0x004D61AC File Offset: 0x004D43AC
		public IHackManagementComponentT UnPack()
		{
			IHackManagementComponentT hackManagementComponentT = new IHackManagementComponentT();
			this.UnPackTo(hackManagementComponentT);
			return hackManagementComponentT;
		}

		// Token: 0x06022EB8 RID: 143032 RVA: 0x004D61C7 File Offset: 0x004D43C7
		public void UnPackTo(IHackManagementComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.MaxHackingCount = this.MaxHackingCount;
			_o.ValidDistance = this.ValidDistance;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022EB9 RID: 143033 RVA: 0x004D61FC File Offset: 0x004D43FC
		public static Offset<IHackManagementComponent> Pack(FlatBufferBuilder builder, IHackManagementComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHackManagementComponent>);
			}
			return IHackManagementComponent.CreateIHackManagementComponent(builder, _o.Disabled, _o.MaxHackingCount, _o.ValidDistance, _o.NullMask);
		}

		// Token: 0x0400E538 RID: 58680
		private Table __p;
	}
}
