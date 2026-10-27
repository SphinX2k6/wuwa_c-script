using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005908 RID: 22792
	public struct ISharingVehicleFeature : IFlatbufferObject
	{
		// Token: 0x1700AAD6 RID: 43734
		// (get) Token: 0x06026846 RID: 157766 RVA: 0x0054E7D7 File Offset: 0x0054C9D7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026847 RID: 157767 RVA: 0x0054E7E4 File Offset: 0x0054C9E4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026848 RID: 157768 RVA: 0x0054E7EC File Offset: 0x0054C9EC
		public static ISharingVehicleFeature GetRootAsISharingVehicleFeature(ByteBuffer _bb)
		{
			return ISharingVehicleFeature.GetRootAsISharingVehicleFeature(_bb, default(ISharingVehicleFeature));
		}

		// Token: 0x06026849 RID: 157769 RVA: 0x0054E808 File Offset: 0x0054CA08
		public static ISharingVehicleFeature GetRootAsISharingVehicleFeature(ByteBuffer _bb, ISharingVehicleFeature obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602684A RID: 157770 RVA: 0x0054E825 File Offset: 0x0054CA25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602684B RID: 157771 RVA: 0x0054E834 File Offset: 0x0054CA34
		public ISharingVehicleFeature __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AAD7 RID: 43735
		// (get) Token: 0x0602684C RID: 157772 RVA: 0x0054E844 File Offset: 0x0054CA44
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

		// Token: 0x1700AAD8 RID: 43736
		// (get) Token: 0x0602684D RID: 157773 RVA: 0x0054E880 File Offset: 0x0054CA80
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

		// Token: 0x1700AAD9 RID: 43737
		// (get) Token: 0x0602684E RID: 157774 RVA: 0x0054E8BC File Offset: 0x0054CABC
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

		// Token: 0x0602684F RID: 157775 RVA: 0x0054E8F8 File Offset: 0x0054CAF8
		public static Offset<ISharingVehicleFeature> CreateISharingVehicleFeature(FlatBufferBuilder builder, EVehicleFeatureFlag Type = EVehicleFeatureFlag.None, EAffectionDegreeSourceType AffectionDegreeSourceType = EAffectionDegreeSourceType.CyberpunkCollaboration, byte NullMask = 0)
		{
			builder.StartTable(3);
			ISharingVehicleFeature.AddNullMask(builder, NullMask);
			ISharingVehicleFeature.AddAffectionDegreeSourceType(builder, AffectionDegreeSourceType);
			ISharingVehicleFeature.AddType(builder, Type);
			return ISharingVehicleFeature.EndISharingVehicleFeature(builder);
		}

		// Token: 0x06026850 RID: 157776 RVA: 0x0054E91C File Offset: 0x0054CB1C
		public static void StartISharingVehicleFeature(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06026851 RID: 157777 RVA: 0x0054E925 File Offset: 0x0054CB25
		public static void AddType(FlatBufferBuilder builder, EVehicleFeatureFlag type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026852 RID: 157778 RVA: 0x0054E930 File Offset: 0x0054CB30
		public static void AddAffectionDegreeSourceType(FlatBufferBuilder builder, EAffectionDegreeSourceType affectionDegreeSourceType)
		{
			builder.AddByte(1, (byte)affectionDegreeSourceType, 0);
		}

		// Token: 0x06026853 RID: 157779 RVA: 0x0054E93B File Offset: 0x0054CB3B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06026854 RID: 157780 RVA: 0x0054E946 File Offset: 0x0054CB46
		public static Offset<ISharingVehicleFeature> EndISharingVehicleFeature(FlatBufferBuilder builder)
		{
			return new Offset<ISharingVehicleFeature>(builder.EndTable());
		}

		// Token: 0x06026855 RID: 157781 RVA: 0x0054E954 File Offset: 0x0054CB54
		public ISharingVehicleFeatureT UnPack()
		{
			ISharingVehicleFeatureT sharingVehicleFeatureT = new ISharingVehicleFeatureT();
			this.UnPackTo(sharingVehicleFeatureT);
			return sharingVehicleFeatureT;
		}

		// Token: 0x06026856 RID: 157782 RVA: 0x0054E96F File Offset: 0x0054CB6F
		public void UnPackTo(ISharingVehicleFeatureT _o)
		{
			_o.Type = this.Type;
			_o.AffectionDegreeSourceType = this.AffectionDegreeSourceType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026857 RID: 157783 RVA: 0x0054E998 File Offset: 0x0054CB98
		public static Offset<ISharingVehicleFeature> Pack(FlatBufferBuilder builder, ISharingVehicleFeatureT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISharingVehicleFeature>);
			}
			return ISharingVehicleFeature.CreateISharingVehicleFeature(builder, _o.Type, _o.AffectionDegreeSourceType, _o.NullMask);
		}

		// Token: 0x0400EEA9 RID: 61097
		private Table __p;
	}
}
