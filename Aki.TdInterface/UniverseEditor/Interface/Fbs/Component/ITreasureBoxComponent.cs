using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ADB RID: 23259
	public struct ITreasureBoxComponent : IFlatbufferObject
	{
		// Token: 0x1700AF48 RID: 44872
		// (get) Token: 0x06027AAC RID: 162476 RVA: 0x00574CA9 File Offset: 0x00572EA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027AAD RID: 162477 RVA: 0x00574CB6 File Offset: 0x00572EB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027AAE RID: 162478 RVA: 0x00574CC0 File Offset: 0x00572EC0
		public static ITreasureBoxComponent GetRootAsITreasureBoxComponent(ByteBuffer _bb)
		{
			return ITreasureBoxComponent.GetRootAsITreasureBoxComponent(_bb, default(ITreasureBoxComponent));
		}

		// Token: 0x06027AAF RID: 162479 RVA: 0x00574CDC File Offset: 0x00572EDC
		public static ITreasureBoxComponent GetRootAsITreasureBoxComponent(ByteBuffer _bb, ITreasureBoxComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027AB0 RID: 162480 RVA: 0x00574CF9 File Offset: 0x00572EF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027AB1 RID: 162481 RVA: 0x00574D08 File Offset: 0x00572F08
		public ITreasureBoxComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF49 RID: 44873
		// (get) Token: 0x06027AB2 RID: 162482 RVA: 0x00574D18 File Offset: 0x00572F18
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AF4A RID: 44874
		// (get) Token: 0x06027AB3 RID: 162483 RVA: 0x00574D58 File Offset: 0x00572F58
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

		// Token: 0x1700AF4B RID: 44875
		// (get) Token: 0x06027AB4 RID: 162484 RVA: 0x00574D94 File Offset: 0x00572F94
		public bool IsSupportDiscoverDevice
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AF4C RID: 44876
		// (get) Token: 0x06027AB5 RID: 162485 RVA: 0x00574DD4 File Offset: 0x00572FD4
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

		// Token: 0x06027AB6 RID: 162486 RVA: 0x00574E11 File Offset: 0x00573011
		public static Offset<ITreasureBoxComponent> CreateITreasureBoxComponent(FlatBufferBuilder builder, bool Disabled = false, int TypeId = 0, bool IsSupportDiscoverDevice = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITreasureBoxComponent.AddTypeId(builder, TypeId);
			ITreasureBoxComponent.AddNullMask(builder, NullMask);
			ITreasureBoxComponent.AddIsSupportDiscoverDevice(builder, IsSupportDiscoverDevice);
			ITreasureBoxComponent.AddDisabled(builder, Disabled);
			return ITreasureBoxComponent.EndITreasureBoxComponent(builder);
		}

		// Token: 0x06027AB7 RID: 162487 RVA: 0x00574E3D File Offset: 0x0057303D
		public static void StartITreasureBoxComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06027AB8 RID: 162488 RVA: 0x00574E46 File Offset: 0x00573046
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027AB9 RID: 162489 RVA: 0x00574E51 File Offset: 0x00573051
		public static void AddTypeId(FlatBufferBuilder builder, int typeId)
		{
			builder.AddInt(1, typeId, 0);
		}

		// Token: 0x06027ABA RID: 162490 RVA: 0x00574E5C File Offset: 0x0057305C
		public static void AddIsSupportDiscoverDevice(FlatBufferBuilder builder, bool isSupportDiscoverDevice)
		{
			builder.AddBool(2, isSupportDiscoverDevice, false);
		}

		// Token: 0x06027ABB RID: 162491 RVA: 0x00574E67 File Offset: 0x00573067
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06027ABC RID: 162492 RVA: 0x00574E72 File Offset: 0x00573072
		public static Offset<ITreasureBoxComponent> EndITreasureBoxComponent(FlatBufferBuilder builder)
		{
			return new Offset<ITreasureBoxComponent>(builder.EndTable());
		}

		// Token: 0x06027ABD RID: 162493 RVA: 0x00574E80 File Offset: 0x00573080
		public ITreasureBoxComponentT UnPack()
		{
			ITreasureBoxComponentT treasureBoxComponentT = new ITreasureBoxComponentT();
			this.UnPackTo(treasureBoxComponentT);
			return treasureBoxComponentT;
		}

		// Token: 0x06027ABE RID: 162494 RVA: 0x00574E9B File Offset: 0x0057309B
		public void UnPackTo(ITreasureBoxComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.TypeId = this.TypeId;
			_o.IsSupportDiscoverDevice = this.IsSupportDiscoverDevice;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027ABF RID: 162495 RVA: 0x00574ED0 File Offset: 0x005730D0
		public static Offset<ITreasureBoxComponent> Pack(FlatBufferBuilder builder, ITreasureBoxComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITreasureBoxComponent>);
			}
			return ITreasureBoxComponent.CreateITreasureBoxComponent(builder, _o.Disabled, _o.TypeId, _o.IsSupportDiscoverDevice, _o.NullMask);
		}

		// Token: 0x0400F1BB RID: 61883
		private Table __p;
	}
}
