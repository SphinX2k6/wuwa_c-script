using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F15 RID: 24341
	public struct ISharingVehicleFeature : IFlatbufferObject
	{
		// Token: 0x1700B40A RID: 46090
		// (get) Token: 0x06028DB0 RID: 167344 RVA: 0x00595443 File Offset: 0x00593643
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028DB1 RID: 167345 RVA: 0x00595450 File Offset: 0x00593650
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028DB2 RID: 167346 RVA: 0x00595458 File Offset: 0x00593658
		public static ISharingVehicleFeature GetRootAsISharingVehicleFeature(ByteBuffer _bb)
		{
			return ISharingVehicleFeature.GetRootAsISharingVehicleFeature(_bb, default(ISharingVehicleFeature));
		}

		// Token: 0x06028DB3 RID: 167347 RVA: 0x00595474 File Offset: 0x00593674
		public static ISharingVehicleFeature GetRootAsISharingVehicleFeature(ByteBuffer _bb, ISharingVehicleFeature obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028DB4 RID: 167348 RVA: 0x00595491 File Offset: 0x00593691
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028DB5 RID: 167349 RVA: 0x005954A0 File Offset: 0x005936A0
		public ISharingVehicleFeature __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B40B RID: 46091
		// (get) Token: 0x06028DB6 RID: 167350 RVA: 0x005954B0 File Offset: 0x005936B0
		public EVehicleFeatureFlag Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVehicleFeatureFlag.None;
				}
				return (EVehicleFeatureFlag)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B40C RID: 46092
		// (get) Token: 0x06028DB7 RID: 167351 RVA: 0x005954EC File Offset: 0x005936EC
		public EAffectionDegreeSourceType AffectionDegreeSourceType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EAffectionDegreeSourceType.CyberpunkCollaboration;
				}
				return (EAffectionDegreeSourceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B40D RID: 46093
		// (get) Token: 0x06028DB8 RID: 167352 RVA: 0x00595528 File Offset: 0x00593728
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028DB9 RID: 167353 RVA: 0x00595564 File Offset: 0x00593764
		public static Offset<ISharingVehicleFeature> CreateISharingVehicleFeature(FlatBufferBuilder builder, EVehicleFeatureFlag Type = EVehicleFeatureFlag.None, EAffectionDegreeSourceType AffectionDegreeSourceType = EAffectionDegreeSourceType.CyberpunkCollaboration, byte NullMask = 0)
		{
			builder.StartTable(3);
			ISharingVehicleFeature.AddNullMask(builder, NullMask);
			ISharingVehicleFeature.AddAffectionDegreeSourceType(builder, AffectionDegreeSourceType);
			ISharingVehicleFeature.AddType(builder, Type);
			return ISharingVehicleFeature.EndISharingVehicleFeature(builder);
		}

		// Token: 0x06028DBA RID: 167354 RVA: 0x00595588 File Offset: 0x00593788
		public static void StartISharingVehicleFeature(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028DBB RID: 167355 RVA: 0x00595591 File Offset: 0x00593791
		public static void AddType(FlatBufferBuilder builder, EVehicleFeatureFlag type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028DBC RID: 167356 RVA: 0x0059559C File Offset: 0x0059379C
		public static void AddAffectionDegreeSourceType(FlatBufferBuilder builder, EAffectionDegreeSourceType affectionDegreeSourceType)
		{
			builder.AddByte(1, (byte)affectionDegreeSourceType, 0);
		}

		// Token: 0x06028DBD RID: 167357 RVA: 0x005955A7 File Offset: 0x005937A7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06028DBE RID: 167358 RVA: 0x005955B2 File Offset: 0x005937B2
		public static Offset<ISharingVehicleFeature> EndISharingVehicleFeature(FlatBufferBuilder builder)
		{
			return new Offset<ISharingVehicleFeature>(builder.EndTable());
		}

		// Token: 0x06028DBF RID: 167359 RVA: 0x005955C0 File Offset: 0x005937C0
		public ISharingVehicleFeatureT UnPack()
		{
			ISharingVehicleFeatureT sharingVehicleFeatureT = new ISharingVehicleFeatureT();
			this.UnPackTo(sharingVehicleFeatureT);
			return sharingVehicleFeatureT;
		}

		// Token: 0x06028DC0 RID: 167360 RVA: 0x005955DB File Offset: 0x005937DB
		public void UnPackTo(ISharingVehicleFeatureT _o)
		{
			_o.Type = this.Type;
			_o.AffectionDegreeSourceType = this.AffectionDegreeSourceType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028DC1 RID: 167361 RVA: 0x00595604 File Offset: 0x00593804
		public static Offset<ISharingVehicleFeature> Pack(FlatBufferBuilder builder, ISharingVehicleFeatureT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISharingVehicleFeature>);
			}
			return ISharingVehicleFeature.CreateISharingVehicleFeature(builder, _o.Type, _o.AffectionDegreeSourceType, _o.NullMask);
		}

		// Token: 0x0400FB9E RID: 64414
		private Table __p;
	}
}
