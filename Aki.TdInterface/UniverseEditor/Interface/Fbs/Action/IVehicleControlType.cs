using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CEF RID: 31983
	public struct IVehicleControlType : IFlatbufferObject
	{
		// Token: 0x1700EF60 RID: 61280
		// (get) Token: 0x06039B4C RID: 236364 RVA: 0x007C8DE4 File Offset: 0x007C6FE4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039B4D RID: 236365 RVA: 0x007C8DF1 File Offset: 0x007C6FF1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039B4E RID: 236366 RVA: 0x007C8DF8 File Offset: 0x007C6FF8
		public static IVehicleControlType GetRootAsIVehicleControlType(ByteBuffer _bb)
		{
			return IVehicleControlType.GetRootAsIVehicleControlType(_bb, default(IVehicleControlType));
		}

		// Token: 0x06039B4F RID: 236367 RVA: 0x007C8E14 File Offset: 0x007C7014
		public static IVehicleControlType GetRootAsIVehicleControlType(ByteBuffer _bb, IVehicleControlType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039B50 RID: 236368 RVA: 0x007C8E31 File Offset: 0x007C7031
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039B51 RID: 236369 RVA: 0x007C8E40 File Offset: 0x007C7040
		public IVehicleControlType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EF61 RID: 61281
		// (get) Token: 0x06039B52 RID: 236370 RVA: 0x007C8E50 File Offset: 0x007C7050
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

		// Token: 0x06039B53 RID: 236371 RVA: 0x007C8E8C File Offset: 0x007C708C
		public static Offset<IVehicleControlType> CreateIVehicleControlType(FlatBufferBuilder builder, EVehicleControlType Type = EVehicleControlType.EnterPathMoving)
		{
			builder.StartTable(1);
			IVehicleControlType.AddType(builder, Type);
			return IVehicleControlType.EndIVehicleControlType(builder);
		}

		// Token: 0x06039B54 RID: 236372 RVA: 0x007C8EA2 File Offset: 0x007C70A2
		public static void StartIVehicleControlType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06039B55 RID: 236373 RVA: 0x007C8EAB File Offset: 0x007C70AB
		public static void AddType(FlatBufferBuilder builder, EVehicleControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039B56 RID: 236374 RVA: 0x007C8EB6 File Offset: 0x007C70B6
		public static Offset<IVehicleControlType> EndIVehicleControlType(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleControlType>(builder.EndTable());
		}

		// Token: 0x06039B57 RID: 236375 RVA: 0x007C8EC4 File Offset: 0x007C70C4
		public IVehicleControlTypeT UnPack()
		{
			IVehicleControlTypeT vehicleControlTypeT = new IVehicleControlTypeT();
			this.UnPackTo(vehicleControlTypeT);
			return vehicleControlTypeT;
		}

		// Token: 0x06039B58 RID: 236376 RVA: 0x007C8EDF File Offset: 0x007C70DF
		public void UnPackTo(IVehicleControlTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06039B59 RID: 236377 RVA: 0x007C8EF0 File Offset: 0x007C70F0
		public static Offset<IVehicleControlType> Pack(FlatBufferBuilder builder, IVehicleControlTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleControlType>);
			}
			return IVehicleControlType.CreateIVehicleControlType(builder, _o.Type);
		}

		// Token: 0x04013407 RID: 78855
		private Table __p;
	}
}
