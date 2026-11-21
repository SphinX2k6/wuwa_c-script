using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005466 RID: 21606
	public struct IBuildingBlockFoundation : IFlatbufferObject
	{
		// Token: 0x170099AA RID: 39338
		// (get) Token: 0x06021EF5 RID: 138997 RVA: 0x004AD604 File Offset: 0x004AB804
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021EF6 RID: 138998 RVA: 0x004AD611 File Offset: 0x004AB811
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021EF7 RID: 138999 RVA: 0x004AD618 File Offset: 0x004AB818
		public static IBuildingBlockFoundation GetRootAsIBuildingBlockFoundation(ByteBuffer _bb)
		{
			return IBuildingBlockFoundation.GetRootAsIBuildingBlockFoundation(_bb, default(IBuildingBlockFoundation));
		}

		// Token: 0x06021EF8 RID: 139000 RVA: 0x004AD634 File Offset: 0x004AB834
		public static IBuildingBlockFoundation GetRootAsIBuildingBlockFoundation(ByteBuffer _bb, IBuildingBlockFoundation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021EF9 RID: 139001 RVA: 0x004AD651 File Offset: 0x004AB851
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021EFA RID: 139002 RVA: 0x004AD660 File Offset: 0x004AB860
		public IBuildingBlockFoundation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099AB RID: 39339
		// (get) Token: 0x06021EFB RID: 139003 RVA: 0x004AD670 File Offset: 0x004AB870
		public EItemFoundation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EItemFoundation.CategoryMatching;
				}
				return (EItemFoundation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021EFC RID: 139004 RVA: 0x004AD6AC File Offset: 0x004AB8AC
		public static Offset<IBuildingBlockFoundation> CreateIBuildingBlockFoundation(FlatBufferBuilder builder, EItemFoundation Type = EItemFoundation.CategoryMatching)
		{
			builder.StartTable(1);
			IBuildingBlockFoundation.AddType(builder, Type);
			return IBuildingBlockFoundation.EndIBuildingBlockFoundation(builder);
		}

		// Token: 0x06021EFD RID: 139005 RVA: 0x004AD6C2 File Offset: 0x004AB8C2
		public static void StartIBuildingBlockFoundation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021EFE RID: 139006 RVA: 0x004AD6CB File Offset: 0x004AB8CB
		public static void AddType(FlatBufferBuilder builder, EItemFoundation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021EFF RID: 139007 RVA: 0x004AD6D6 File Offset: 0x004AB8D6
		public static Offset<IBuildingBlockFoundation> EndIBuildingBlockFoundation(FlatBufferBuilder builder)
		{
			return new Offset<IBuildingBlockFoundation>(builder.EndTable());
		}

		// Token: 0x06021F00 RID: 139008 RVA: 0x004AD6E4 File Offset: 0x004AB8E4
		public IBuildingBlockFoundationT UnPack()
		{
			IBuildingBlockFoundationT buildingBlockFoundationT = new IBuildingBlockFoundationT();
			this.UnPackTo(buildingBlockFoundationT);
			return buildingBlockFoundationT;
		}

		// Token: 0x06021F01 RID: 139009 RVA: 0x004AD6FF File Offset: 0x004AB8FF
		public void UnPackTo(IBuildingBlockFoundationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06021F02 RID: 139010 RVA: 0x004AD710 File Offset: 0x004AB910
		public static Offset<IBuildingBlockFoundation> Pack(FlatBufferBuilder builder, IBuildingBlockFoundationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBuildingBlockFoundation>);
			}
			return IBuildingBlockFoundation.CreateIBuildingBlockFoundation(builder, _o.Type);
		}

		// Token: 0x0400E94B RID: 59723
		private Table __p;
	}
}
