using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064EF RID: 25839
	public struct ICurrentVehicle : IFlatbufferObject
	{
		// Token: 0x1700C033 RID: 49203
		// (get) Token: 0x0602CD2B RID: 183595 RVA: 0x00628AD4 File Offset: 0x00626CD4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CD2C RID: 183596 RVA: 0x00628AE1 File Offset: 0x00626CE1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CD2D RID: 183597 RVA: 0x00628AE8 File Offset: 0x00626CE8
		public static ICurrentVehicle GetRootAsICurrentVehicle(ByteBuffer _bb)
		{
			return ICurrentVehicle.GetRootAsICurrentVehicle(_bb, default(ICurrentVehicle));
		}

		// Token: 0x0602CD2E RID: 183598 RVA: 0x00628B04 File Offset: 0x00626D04
		public static ICurrentVehicle GetRootAsICurrentVehicle(ByteBuffer _bb, ICurrentVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CD2F RID: 183599 RVA: 0x00628B21 File Offset: 0x00626D21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CD30 RID: 183600 RVA: 0x00628B30 File Offset: 0x00626D30
		public ICurrentVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C034 RID: 49204
		// (get) Token: 0x0602CD31 RID: 183601 RVA: 0x00628B40 File Offset: 0x00626D40
		public ETargetVehicle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetVehicle.Current;
				}
				return (ETargetVehicle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CD32 RID: 183602 RVA: 0x00628B7C File Offset: 0x00626D7C
		public static Offset<ICurrentVehicle> CreateICurrentVehicle(FlatBufferBuilder builder, ETargetVehicle Type = ETargetVehicle.Current)
		{
			builder.StartTable(1);
			ICurrentVehicle.AddType(builder, Type);
			return ICurrentVehicle.EndICurrentVehicle(builder);
		}

		// Token: 0x0602CD33 RID: 183603 RVA: 0x00628B92 File Offset: 0x00626D92
		public static void StartICurrentVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CD34 RID: 183604 RVA: 0x00628B9B File Offset: 0x00626D9B
		public static void AddType(FlatBufferBuilder builder, ETargetVehicle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CD35 RID: 183605 RVA: 0x00628BA6 File Offset: 0x00626DA6
		public static Offset<ICurrentVehicle> EndICurrentVehicle(FlatBufferBuilder builder)
		{
			return new Offset<ICurrentVehicle>(builder.EndTable());
		}

		// Token: 0x0602CD36 RID: 183606 RVA: 0x00628BB4 File Offset: 0x00626DB4
		public ICurrentVehicleT UnPack()
		{
			ICurrentVehicleT currentVehicleT = new ICurrentVehicleT();
			this.UnPackTo(currentVehicleT);
			return currentVehicleT;
		}

		// Token: 0x0602CD37 RID: 183607 RVA: 0x00628BCF File Offset: 0x00626DCF
		public void UnPackTo(ICurrentVehicleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CD38 RID: 183608 RVA: 0x00628BE0 File Offset: 0x00626DE0
		public static Offset<ICurrentVehicle> Pack(FlatBufferBuilder builder, ICurrentVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICurrentVehicle>);
			}
			return ICurrentVehicle.CreateICurrentVehicle(builder, _o.Type);
		}

		// Token: 0x04010B33 RID: 68403
		private Table __p;
	}
}
