using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006732 RID: 26418
	public struct IExitVehicleStandUp : IFlatbufferObject
	{
		// Token: 0x1700C42F RID: 50223
		// (get) Token: 0x0602DF3F RID: 188223 RVA: 0x00648151 File Offset: 0x00646351
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DF40 RID: 188224 RVA: 0x0064815E File Offset: 0x0064635E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DF41 RID: 188225 RVA: 0x00648168 File Offset: 0x00646368
		public static IExitVehicleStandUp GetRootAsIExitVehicleStandUp(ByteBuffer _bb)
		{
			return IExitVehicleStandUp.GetRootAsIExitVehicleStandUp(_bb, default(IExitVehicleStandUp));
		}

		// Token: 0x0602DF42 RID: 188226 RVA: 0x00648184 File Offset: 0x00646384
		public static IExitVehicleStandUp GetRootAsIExitVehicleStandUp(ByteBuffer _bb, IExitVehicleStandUp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DF43 RID: 188227 RVA: 0x006481A1 File Offset: 0x006463A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DF44 RID: 188228 RVA: 0x006481B0 File Offset: 0x006463B0
		public IExitVehicleStandUp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C430 RID: 50224
		// (get) Token: 0x0602DF45 RID: 188229 RVA: 0x006481C0 File Offset: 0x006463C0
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

		// Token: 0x0602DF46 RID: 188230 RVA: 0x006481FC File Offset: 0x006463FC
		public static Offset<IExitVehicleStandUp> CreateIExitVehicleStandUp(FlatBufferBuilder builder, EExitVehicleType Type = EExitVehicleType.Launch)
		{
			builder.StartTable(1);
			IExitVehicleStandUp.AddType(builder, Type);
			return IExitVehicleStandUp.EndIExitVehicleStandUp(builder);
		}

		// Token: 0x0602DF47 RID: 188231 RVA: 0x00648212 File Offset: 0x00646412
		public static void StartIExitVehicleStandUp(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DF48 RID: 188232 RVA: 0x0064821B File Offset: 0x0064641B
		public static void AddType(FlatBufferBuilder builder, EExitVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DF49 RID: 188233 RVA: 0x00648226 File Offset: 0x00646426
		public static Offset<IExitVehicleStandUp> EndIExitVehicleStandUp(FlatBufferBuilder builder)
		{
			return new Offset<IExitVehicleStandUp>(builder.EndTable());
		}

		// Token: 0x0602DF4A RID: 188234 RVA: 0x00648234 File Offset: 0x00646434
		public IExitVehicleStandUpT UnPack()
		{
			IExitVehicleStandUpT exitVehicleStandUpT = new IExitVehicleStandUpT();
			this.UnPackTo(exitVehicleStandUpT);
			return exitVehicleStandUpT;
		}

		// Token: 0x0602DF4B RID: 188235 RVA: 0x0064824F File Offset: 0x0064644F
		public void UnPackTo(IExitVehicleStandUpT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DF4C RID: 188236 RVA: 0x00648260 File Offset: 0x00646460
		public static Offset<IExitVehicleStandUp> Pack(FlatBufferBuilder builder, IExitVehicleStandUpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExitVehicleStandUp>);
			}
			return IExitVehicleStandUp.CreateIExitVehicleStandUp(builder, _o.Type);
		}

		// Token: 0x04010E15 RID: 69141
		private Table __p;
	}
}
