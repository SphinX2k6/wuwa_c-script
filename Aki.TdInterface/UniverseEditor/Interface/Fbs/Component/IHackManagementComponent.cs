using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058E5 RID: 22757
	public struct IHackManagementComponent : IFlatbufferObject
	{
		// Token: 0x1700A507 RID: 42247
		// (get) Token: 0x06024F5A RID: 151386 RVA: 0x00512EA1 File Offset: 0x005110A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024F5B RID: 151387 RVA: 0x00512EAE File Offset: 0x005110AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024F5C RID: 151388 RVA: 0x00512EB8 File Offset: 0x005110B8
		public static IHackManagementComponent GetRootAsIHackManagementComponent(ByteBuffer _bb)
		{
			return IHackManagementComponent.GetRootAsIHackManagementComponent(_bb, default(IHackManagementComponent));
		}

		// Token: 0x06024F5D RID: 151389 RVA: 0x00512ED4 File Offset: 0x005110D4
		public static IHackManagementComponent GetRootAsIHackManagementComponent(ByteBuffer _bb, IHackManagementComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024F5E RID: 151390 RVA: 0x00512EF1 File Offset: 0x005110F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024F5F RID: 151391 RVA: 0x00512F00 File Offset: 0x00511100
		public IHackManagementComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A508 RID: 42248
		// (get) Token: 0x06024F60 RID: 151392 RVA: 0x00512F10 File Offset: 0x00511110
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A509 RID: 42249
		// (get) Token: 0x06024F61 RID: 151393 RVA: 0x00512F50 File Offset: 0x00511150
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

		// Token: 0x1700A50A RID: 42250
		// (get) Token: 0x06024F62 RID: 151394 RVA: 0x00512F8C File Offset: 0x0051118C
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

		// Token: 0x1700A50B RID: 42251
		// (get) Token: 0x06024F63 RID: 151395 RVA: 0x00512FCC File Offset: 0x005111CC
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

		// Token: 0x06024F64 RID: 151396 RVA: 0x00513009 File Offset: 0x00511209
		public static Offset<IHackManagementComponent> CreateIHackManagementComponent(FlatBufferBuilder builder, bool Disabled = false, int MaxHackingCount = 0, float ValidDistance = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IHackManagementComponent.AddValidDistance(builder, ValidDistance);
			IHackManagementComponent.AddMaxHackingCount(builder, MaxHackingCount);
			IHackManagementComponent.AddNullMask(builder, NullMask);
			IHackManagementComponent.AddDisabled(builder, Disabled);
			return IHackManagementComponent.EndIHackManagementComponent(builder);
		}

		// Token: 0x06024F65 RID: 151397 RVA: 0x00513035 File Offset: 0x00511235
		public static void StartIHackManagementComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06024F66 RID: 151398 RVA: 0x0051303E File Offset: 0x0051123E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06024F67 RID: 151399 RVA: 0x00513049 File Offset: 0x00511249
		public static void AddMaxHackingCount(FlatBufferBuilder builder, int maxHackingCount)
		{
			builder.AddInt(1, maxHackingCount, 0);
		}

		// Token: 0x06024F68 RID: 151400 RVA: 0x00513054 File Offset: 0x00511254
		public static void AddValidDistance(FlatBufferBuilder builder, float validDistance)
		{
			builder.AddFloat(2, validDistance, 0.0);
		}

		// Token: 0x06024F69 RID: 151401 RVA: 0x00513067 File Offset: 0x00511267
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06024F6A RID: 151402 RVA: 0x00513072 File Offset: 0x00511272
		public static Offset<IHackManagementComponent> EndIHackManagementComponent(FlatBufferBuilder builder)
		{
			return new Offset<IHackManagementComponent>(builder.EndTable());
		}

		// Token: 0x06024F6B RID: 151403 RVA: 0x00513080 File Offset: 0x00511280
		public IHackManagementComponentT UnPack()
		{
			IHackManagementComponentT hackManagementComponentT = new IHackManagementComponentT();
			this.UnPackTo(hackManagementComponentT);
			return hackManagementComponentT;
		}

		// Token: 0x06024F6C RID: 151404 RVA: 0x0051309B File Offset: 0x0051129B
		public void UnPackTo(IHackManagementComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.MaxHackingCount = this.MaxHackingCount;
			_o.ValidDistance = this.ValidDistance;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024F6D RID: 151405 RVA: 0x005130D0 File Offset: 0x005112D0
		public static Offset<IHackManagementComponent> Pack(FlatBufferBuilder builder, IHackManagementComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHackManagementComponent>);
			}
			return IHackManagementComponent.CreateIHackManagementComponent(builder, _o.Disabled, _o.MaxHackingCount, _o.ValidDistance, _o.NullMask);
		}

		// Token: 0x0400F168 RID: 61800
		private Table __p;
	}
}
