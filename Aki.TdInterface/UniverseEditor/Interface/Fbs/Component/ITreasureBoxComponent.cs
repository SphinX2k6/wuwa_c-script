using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060E8 RID: 24808
	public struct ITreasureBoxComponent : IFlatbufferObject
	{
		// Token: 0x1700B884 RID: 47236
		// (get) Token: 0x0602A038 RID: 172088 RVA: 0x005BC125 File Offset: 0x005BA325
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A039 RID: 172089 RVA: 0x005BC132 File Offset: 0x005BA332
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A03A RID: 172090 RVA: 0x005BC13C File Offset: 0x005BA33C
		public static ITreasureBoxComponent GetRootAsITreasureBoxComponent(ByteBuffer _bb)
		{
			return ITreasureBoxComponent.GetRootAsITreasureBoxComponent(_bb, default(ITreasureBoxComponent));
		}

		// Token: 0x0602A03B RID: 172091 RVA: 0x005BC158 File Offset: 0x005BA358
		public static ITreasureBoxComponent GetRootAsITreasureBoxComponent(ByteBuffer _bb, ITreasureBoxComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A03C RID: 172092 RVA: 0x005BC175 File Offset: 0x005BA375
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A03D RID: 172093 RVA: 0x005BC184 File Offset: 0x005BA384
		public ITreasureBoxComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B885 RID: 47237
		// (get) Token: 0x0602A03E RID: 172094 RVA: 0x005BC194 File Offset: 0x005BA394
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B886 RID: 47238
		// (get) Token: 0x0602A03F RID: 172095 RVA: 0x005BC1D4 File Offset: 0x005BA3D4
		public int TypeId
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

		// Token: 0x1700B887 RID: 47239
		// (get) Token: 0x0602A040 RID: 172096 RVA: 0x005BC210 File Offset: 0x005BA410
		public bool IsSupportDiscoverDevice
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B888 RID: 47240
		// (get) Token: 0x0602A041 RID: 172097 RVA: 0x005BC250 File Offset: 0x005BA450
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

		// Token: 0x0602A042 RID: 172098 RVA: 0x005BC28D File Offset: 0x005BA48D
		public static Offset<ITreasureBoxComponent> CreateITreasureBoxComponent(FlatBufferBuilder builder, bool Disabled = false, int TypeId = 0, bool IsSupportDiscoverDevice = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITreasureBoxComponent.AddTypeId(builder, TypeId);
			ITreasureBoxComponent.AddNullMask(builder, NullMask);
			ITreasureBoxComponent.AddIsSupportDiscoverDevice(builder, IsSupportDiscoverDevice);
			ITreasureBoxComponent.AddDisabled(builder, Disabled);
			return ITreasureBoxComponent.EndITreasureBoxComponent(builder);
		}

		// Token: 0x0602A043 RID: 172099 RVA: 0x005BC2B9 File Offset: 0x005BA4B9
		public static void StartITreasureBoxComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602A044 RID: 172100 RVA: 0x005BC2C2 File Offset: 0x005BA4C2
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602A045 RID: 172101 RVA: 0x005BC2CD File Offset: 0x005BA4CD
		public static void AddTypeId(FlatBufferBuilder builder, int typeId)
		{
			builder.AddInt(1, typeId, 0);
		}

		// Token: 0x0602A046 RID: 172102 RVA: 0x005BC2D8 File Offset: 0x005BA4D8
		public static void AddIsSupportDiscoverDevice(FlatBufferBuilder builder, bool isSupportDiscoverDevice)
		{
			builder.AddBool(2, isSupportDiscoverDevice, false);
		}

		// Token: 0x0602A047 RID: 172103 RVA: 0x005BC2E3 File Offset: 0x005BA4E3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602A048 RID: 172104 RVA: 0x005BC2EE File Offset: 0x005BA4EE
		public static Offset<ITreasureBoxComponent> EndITreasureBoxComponent(FlatBufferBuilder builder)
		{
			return new Offset<ITreasureBoxComponent>(builder.EndTable());
		}

		// Token: 0x0602A049 RID: 172105 RVA: 0x005BC2FC File Offset: 0x005BA4FC
		public ITreasureBoxComponentT UnPack()
		{
			ITreasureBoxComponentT treasureBoxComponentT = new ITreasureBoxComponentT();
			this.UnPackTo(treasureBoxComponentT);
			return treasureBoxComponentT;
		}

		// Token: 0x0602A04A RID: 172106 RVA: 0x005BC317 File Offset: 0x005BA517
		public void UnPackTo(ITreasureBoxComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.TypeId = this.TypeId;
			_o.IsSupportDiscoverDevice = this.IsSupportDiscoverDevice;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A04B RID: 172107 RVA: 0x005BC34C File Offset: 0x005BA54C
		public static Offset<ITreasureBoxComponent> Pack(FlatBufferBuilder builder, ITreasureBoxComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITreasureBoxComponent>);
			}
			return ITreasureBoxComponent.CreateITreasureBoxComponent(builder, _o.Disabled, _o.TypeId, _o.IsSupportDiscoverDevice, _o.NullMask);
		}

		// Token: 0x0400FEB5 RID: 65205
		private Table __p;
	}
}
