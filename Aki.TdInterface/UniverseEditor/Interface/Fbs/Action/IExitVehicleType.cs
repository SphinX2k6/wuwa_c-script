using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006738 RID: 26424
	public struct IExitVehicleType : IFlatbufferObject
	{
		// Token: 0x1700C439 RID: 50233
		// (get) Token: 0x0602DF6B RID: 188267 RVA: 0x0064865E File Offset: 0x0064685E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DF6C RID: 188268 RVA: 0x0064866B File Offset: 0x0064686B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DF6D RID: 188269 RVA: 0x00648674 File Offset: 0x00646874
		public static IExitVehicleType GetRootAsIExitVehicleType(ByteBuffer _bb)
		{
			return IExitVehicleType.GetRootAsIExitVehicleType(_bb, default(IExitVehicleType));
		}

		// Token: 0x0602DF6E RID: 188270 RVA: 0x00648690 File Offset: 0x00646890
		public static IExitVehicleType GetRootAsIExitVehicleType(ByteBuffer _bb, IExitVehicleType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DF6F RID: 188271 RVA: 0x006486AD File Offset: 0x006468AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DF70 RID: 188272 RVA: 0x006486BC File Offset: 0x006468BC
		public IExitVehicleType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C43A RID: 50234
		// (get) Token: 0x0602DF71 RID: 188273 RVA: 0x006486CC File Offset: 0x006468CC
		public EExitVehicleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExitVehicleType.Launch;
				}
				return (EExitVehicleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DF72 RID: 188274 RVA: 0x00648708 File Offset: 0x00646908
		public static Offset<IExitVehicleType> CreateIExitVehicleType(FlatBufferBuilder builder, EExitVehicleType Type = EExitVehicleType.Launch)
		{
			builder.StartTable(1);
			IExitVehicleType.AddType(builder, Type);
			return IExitVehicleType.EndIExitVehicleType(builder);
		}

		// Token: 0x0602DF73 RID: 188275 RVA: 0x0064871E File Offset: 0x0064691E
		public static void StartIExitVehicleType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DF74 RID: 188276 RVA: 0x00648727 File Offset: 0x00646927
		public static void AddType(FlatBufferBuilder builder, EExitVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DF75 RID: 188277 RVA: 0x00648732 File Offset: 0x00646932
		public static Offset<IExitVehicleType> EndIExitVehicleType(FlatBufferBuilder builder)
		{
			return new Offset<IExitVehicleType>(builder.EndTable());
		}

		// Token: 0x0602DF76 RID: 188278 RVA: 0x00648740 File Offset: 0x00646940
		public IExitVehicleTypeT UnPack()
		{
			IExitVehicleTypeT exitVehicleTypeT = new IExitVehicleTypeT();
			this.UnPackTo(exitVehicleTypeT);
			return exitVehicleTypeT;
		}

		// Token: 0x0602DF77 RID: 188279 RVA: 0x0064875B File Offset: 0x0064695B
		public void UnPackTo(IExitVehicleTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DF78 RID: 188280 RVA: 0x0064876C File Offset: 0x0064696C
		public static Offset<IExitVehicleType> Pack(FlatBufferBuilder builder, IExitVehicleTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExitVehicleType>);
			}
			return IExitVehicleType.CreateIExitVehicleType(builder, _o.Type);
		}

		// Token: 0x04010E1B RID: 69147
		private Table __p;
	}
}
