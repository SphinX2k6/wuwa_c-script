using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DB8 RID: 28088
	public struct IExitVehicleType : IFlatbufferObject
	{
		// Token: 0x1700CDEF RID: 52719
		// (get) Token: 0x060307B1 RID: 198577 RVA: 0x00695DA2 File Offset: 0x00693FA2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060307B2 RID: 198578 RVA: 0x00695DAF File Offset: 0x00693FAF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060307B3 RID: 198579 RVA: 0x00695DB8 File Offset: 0x00693FB8
		public static IExitVehicleType GetRootAsIExitVehicleType(ByteBuffer _bb)
		{
			return IExitVehicleType.GetRootAsIExitVehicleType(_bb, default(IExitVehicleType));
		}

		// Token: 0x060307B4 RID: 198580 RVA: 0x00695DD4 File Offset: 0x00693FD4
		public static IExitVehicleType GetRootAsIExitVehicleType(ByteBuffer _bb, IExitVehicleType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060307B5 RID: 198581 RVA: 0x00695DF1 File Offset: 0x00693FF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060307B6 RID: 198582 RVA: 0x00695E00 File Offset: 0x00694000
		public IExitVehicleType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDF0 RID: 52720
		// (get) Token: 0x060307B7 RID: 198583 RVA: 0x00695E10 File Offset: 0x00694010
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

		// Token: 0x060307B8 RID: 198584 RVA: 0x00695E4C File Offset: 0x0069404C
		public static Offset<IExitVehicleType> CreateIExitVehicleType(FlatBufferBuilder builder, EExitVehicleType Type = EExitVehicleType.Launch)
		{
			builder.StartTable(1);
			IExitVehicleType.AddType(builder, Type);
			return IExitVehicleType.EndIExitVehicleType(builder);
		}

		// Token: 0x060307B9 RID: 198585 RVA: 0x00695E62 File Offset: 0x00694062
		public static void StartIExitVehicleType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060307BA RID: 198586 RVA: 0x00695E6B File Offset: 0x0069406B
		public static void AddType(FlatBufferBuilder builder, EExitVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060307BB RID: 198587 RVA: 0x00695E76 File Offset: 0x00694076
		public static Offset<IExitVehicleType> EndIExitVehicleType(FlatBufferBuilder builder)
		{
			return new Offset<IExitVehicleType>(builder.EndTable());
		}

		// Token: 0x060307BC RID: 198588 RVA: 0x00695E84 File Offset: 0x00694084
		public IExitVehicleTypeT UnPack()
		{
			IExitVehicleTypeT exitVehicleTypeT = new IExitVehicleTypeT();
			this.UnPackTo(exitVehicleTypeT);
			return exitVehicleTypeT;
		}

		// Token: 0x060307BD RID: 198589 RVA: 0x00695E9F File Offset: 0x0069409F
		public void UnPackTo(IExitVehicleTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060307BE RID: 198590 RVA: 0x00695EB0 File Offset: 0x006940B0
		public static Offset<IExitVehicleType> Pack(FlatBufferBuilder builder, IExitVehicleTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExitVehicleType>);
			}
			return IExitVehicleType.CreateIExitVehicleType(builder, _o.Type);
		}

		// Token: 0x04011C4D RID: 72781
		private Table __p;
	}
}
