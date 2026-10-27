using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074F9 RID: 29945
	public struct IVehicleControlType : IFlatbufferObject
	{
		// Token: 0x1700E336 RID: 58166
		// (get) Token: 0x06036737 RID: 223031 RVA: 0x00765B94 File Offset: 0x00763D94
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036738 RID: 223032 RVA: 0x00765BA1 File Offset: 0x00763DA1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036739 RID: 223033 RVA: 0x00765BA8 File Offset: 0x00763DA8
		public static IVehicleControlType GetRootAsIVehicleControlType(ByteBuffer _bb)
		{
			return IVehicleControlType.GetRootAsIVehicleControlType(_bb, default(IVehicleControlType));
		}

		// Token: 0x0603673A RID: 223034 RVA: 0x00765BC4 File Offset: 0x00763DC4
		public static IVehicleControlType GetRootAsIVehicleControlType(ByteBuffer _bb, IVehicleControlType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603673B RID: 223035 RVA: 0x00765BE1 File Offset: 0x00763DE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603673C RID: 223036 RVA: 0x00765BF0 File Offset: 0x00763DF0
		public IVehicleControlType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E337 RID: 58167
		// (get) Token: 0x0603673D RID: 223037 RVA: 0x00765C00 File Offset: 0x00763E00
		public EVehicleControlType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVehicleControlType.EnterPathMoving;
				}
				return (EVehicleControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603673E RID: 223038 RVA: 0x00765C3C File Offset: 0x00763E3C
		public static Offset<IVehicleControlType> CreateIVehicleControlType(FlatBufferBuilder builder, EVehicleControlType Type = EVehicleControlType.EnterPathMoving)
		{
			builder.StartTable(1);
			IVehicleControlType.AddType(builder, Type);
			return IVehicleControlType.EndIVehicleControlType(builder);
		}

		// Token: 0x0603673F RID: 223039 RVA: 0x00765C52 File Offset: 0x00763E52
		public static void StartIVehicleControlType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036740 RID: 223040 RVA: 0x00765C5B File Offset: 0x00763E5B
		public static void AddType(FlatBufferBuilder builder, EVehicleControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036741 RID: 223041 RVA: 0x00765C66 File Offset: 0x00763E66
		public static Offset<IVehicleControlType> EndIVehicleControlType(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleControlType>(builder.EndTable());
		}

		// Token: 0x06036742 RID: 223042 RVA: 0x00765C74 File Offset: 0x00763E74
		public IVehicleControlTypeT UnPack()
		{
			IVehicleControlTypeT vehicleControlTypeT = new IVehicleControlTypeT();
			this.UnPackTo(vehicleControlTypeT);
			return vehicleControlTypeT;
		}

		// Token: 0x06036743 RID: 223043 RVA: 0x00765C8F File Offset: 0x00763E8F
		public void UnPackTo(IVehicleControlTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036744 RID: 223044 RVA: 0x00765CA0 File Offset: 0x00763EA0
		public static Offset<IVehicleControlType> Pack(FlatBufferBuilder builder, IVehicleControlTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleControlType>);
			}
			return IVehicleControlType.CreateIVehicleControlType(builder, _o.Type);
		}

		// Token: 0x040123D6 RID: 74710
		private Table __p;
	}
}
