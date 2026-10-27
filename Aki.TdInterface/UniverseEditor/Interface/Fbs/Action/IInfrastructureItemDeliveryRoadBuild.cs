using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200695A RID: 26970
	public struct IInfrastructureItemDeliveryRoadBuild : IFlatbufferObject
	{
		// Token: 0x1700C80B RID: 51211
		// (get) Token: 0x0602F16C RID: 192876 RVA: 0x0066AB9E File Offset: 0x00668D9E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F16D RID: 192877 RVA: 0x0066ABAB File Offset: 0x00668DAB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F16E RID: 192878 RVA: 0x0066ABB4 File Offset: 0x00668DB4
		public static IInfrastructureItemDeliveryRoadBuild GetRootAsIInfrastructureItemDeliveryRoadBuild(ByteBuffer _bb)
		{
			return IInfrastructureItemDeliveryRoadBuild.GetRootAsIInfrastructureItemDeliveryRoadBuild(_bb, default(IInfrastructureItemDeliveryRoadBuild));
		}

		// Token: 0x0602F16F RID: 192879 RVA: 0x0066ABD0 File Offset: 0x00668DD0
		public static IInfrastructureItemDeliveryRoadBuild GetRootAsIInfrastructureItemDeliveryRoadBuild(ByteBuffer _bb, IInfrastructureItemDeliveryRoadBuild obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F170 RID: 192880 RVA: 0x0066ABED File Offset: 0x00668DED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F171 RID: 192881 RVA: 0x0066ABFC File Offset: 0x00668DFC
		public IInfrastructureItemDeliveryRoadBuild __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C80C RID: 51212
		// (get) Token: 0x0602F172 RID: 192882 RVA: 0x0066AC0C File Offset: 0x00668E0C
		public EInfrastructureItemDeliveryType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInfrastructureItemDeliveryType.Observatory;
				}
				return (EInfrastructureItemDeliveryType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C80D RID: 51213
		// (get) Token: 0x0602F173 RID: 192883 RVA: 0x0066AC48 File Offset: 0x00668E48
		public int Id
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

		// Token: 0x0602F174 RID: 192884 RVA: 0x0066AC84 File Offset: 0x00668E84
		public static Offset<IInfrastructureItemDeliveryRoadBuild> CreateIInfrastructureItemDeliveryRoadBuild(FlatBufferBuilder builder, EInfrastructureItemDeliveryType Type = EInfrastructureItemDeliveryType.Observatory, int Id = 0)
		{
			builder.StartTable(2);
			IInfrastructureItemDeliveryRoadBuild.AddId(builder, Id);
			IInfrastructureItemDeliveryRoadBuild.AddType(builder, Type);
			return IInfrastructureItemDeliveryRoadBuild.EndIInfrastructureItemDeliveryRoadBuild(builder);
		}

		// Token: 0x0602F175 RID: 192885 RVA: 0x0066ACA1 File Offset: 0x00668EA1
		public static void StartIInfrastructureItemDeliveryRoadBuild(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F176 RID: 192886 RVA: 0x0066ACAA File Offset: 0x00668EAA
		public static void AddType(FlatBufferBuilder builder, EInfrastructureItemDeliveryType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F177 RID: 192887 RVA: 0x0066ACB5 File Offset: 0x00668EB5
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602F178 RID: 192888 RVA: 0x0066ACC0 File Offset: 0x00668EC0
		public static Offset<IInfrastructureItemDeliveryRoadBuild> EndIInfrastructureItemDeliveryRoadBuild(FlatBufferBuilder builder)
		{
			return new Offset<IInfrastructureItemDeliveryRoadBuild>(builder.EndTable());
		}

		// Token: 0x0602F179 RID: 192889 RVA: 0x0066ACD0 File Offset: 0x00668ED0
		public IInfrastructureItemDeliveryRoadBuildT UnPack()
		{
			IInfrastructureItemDeliveryRoadBuildT infrastructureItemDeliveryRoadBuildT = new IInfrastructureItemDeliveryRoadBuildT();
			this.UnPackTo(infrastructureItemDeliveryRoadBuildT);
			return infrastructureItemDeliveryRoadBuildT;
		}

		// Token: 0x0602F17A RID: 192890 RVA: 0x0066ACEB File Offset: 0x00668EEB
		public void UnPackTo(IInfrastructureItemDeliveryRoadBuildT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0602F17B RID: 192891 RVA: 0x0066AD08 File Offset: 0x00668F08
		public static Offset<IInfrastructureItemDeliveryRoadBuild> Pack(FlatBufferBuilder builder, IInfrastructureItemDeliveryRoadBuildT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInfrastructureItemDeliveryRoadBuild>);
			}
			return IInfrastructureItemDeliveryRoadBuild.CreateIInfrastructureItemDeliveryRoadBuild(builder, _o.Type, _o.Id);
		}

		// Token: 0x040110DA RID: 69850
		private Table __p;
	}
}
