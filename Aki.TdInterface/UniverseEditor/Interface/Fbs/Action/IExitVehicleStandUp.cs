using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DB2 RID: 28082
	public struct IExitVehicleStandUp : IFlatbufferObject
	{
		// Token: 0x1700CDE5 RID: 52709
		// (get) Token: 0x06030785 RID: 198533 RVA: 0x00695895 File Offset: 0x00693A95
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030786 RID: 198534 RVA: 0x006958A2 File Offset: 0x00693AA2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030787 RID: 198535 RVA: 0x006958AC File Offset: 0x00693AAC
		public static IExitVehicleStandUp GetRootAsIExitVehicleStandUp(ByteBuffer _bb)
		{
			return IExitVehicleStandUp.GetRootAsIExitVehicleStandUp(_bb, default(IExitVehicleStandUp));
		}

		// Token: 0x06030788 RID: 198536 RVA: 0x006958C8 File Offset: 0x00693AC8
		public static IExitVehicleStandUp GetRootAsIExitVehicleStandUp(ByteBuffer _bb, IExitVehicleStandUp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030789 RID: 198537 RVA: 0x006958E5 File Offset: 0x00693AE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603078A RID: 198538 RVA: 0x006958F4 File Offset: 0x00693AF4
		public IExitVehicleStandUp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDE6 RID: 52710
		// (get) Token: 0x0603078B RID: 198539 RVA: 0x00695904 File Offset: 0x00693B04
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

		// Token: 0x0603078C RID: 198540 RVA: 0x00695940 File Offset: 0x00693B40
		public static Offset<IExitVehicleStandUp> CreateIExitVehicleStandUp(FlatBufferBuilder builder, EExitVehicleType Type = EExitVehicleType.Launch)
		{
			builder.StartTable(1);
			IExitVehicleStandUp.AddType(builder, Type);
			return IExitVehicleStandUp.EndIExitVehicleStandUp(builder);
		}

		// Token: 0x0603078D RID: 198541 RVA: 0x00695956 File Offset: 0x00693B56
		public static void StartIExitVehicleStandUp(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603078E RID: 198542 RVA: 0x0069595F File Offset: 0x00693B5F
		public static void AddType(FlatBufferBuilder builder, EExitVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603078F RID: 198543 RVA: 0x0069596A File Offset: 0x00693B6A
		public static Offset<IExitVehicleStandUp> EndIExitVehicleStandUp(FlatBufferBuilder builder)
		{
			return new Offset<IExitVehicleStandUp>(builder.EndTable());
		}

		// Token: 0x06030790 RID: 198544 RVA: 0x00695978 File Offset: 0x00693B78
		public IExitVehicleStandUpT UnPack()
		{
			IExitVehicleStandUpT exitVehicleStandUpT = new IExitVehicleStandUpT();
			this.UnPackTo(exitVehicleStandUpT);
			return exitVehicleStandUpT;
		}

		// Token: 0x06030791 RID: 198545 RVA: 0x00695993 File Offset: 0x00693B93
		public void UnPackTo(IExitVehicleStandUpT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030792 RID: 198546 RVA: 0x006959A4 File Offset: 0x00693BA4
		public static Offset<IExitVehicleStandUp> Pack(FlatBufferBuilder builder, IExitVehicleStandUpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExitVehicleStandUp>);
			}
			return IExitVehicleStandUp.CreateIExitVehicleStandUp(builder, _o.Type);
		}

		// Token: 0x04011C47 RID: 72775
		private Table __p;
	}
}
