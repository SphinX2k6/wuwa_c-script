using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005150 RID: 20816
	public struct IEntityAttachPoint : IFlatbufferObject
	{
		// Token: 0x170097D1 RID: 38865
		// (get) Token: 0x0602198E RID: 137614 RVA: 0x004A9BC2 File Offset: 0x004A7DC2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602198F RID: 137615 RVA: 0x004A9BCF File Offset: 0x004A7DCF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021990 RID: 137616 RVA: 0x004A9BD8 File Offset: 0x004A7DD8
		public static IEntityAttachPoint GetRootAsIEntityAttachPoint(ByteBuffer _bb)
		{
			return IEntityAttachPoint.GetRootAsIEntityAttachPoint(_bb, default(IEntityAttachPoint));
		}

		// Token: 0x06021991 RID: 137617 RVA: 0x004A9BF4 File Offset: 0x004A7DF4
		public static IEntityAttachPoint GetRootAsIEntityAttachPoint(ByteBuffer _bb, IEntityAttachPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021992 RID: 137618 RVA: 0x004A9C11 File Offset: 0x004A7E11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021993 RID: 137619 RVA: 0x004A9C20 File Offset: 0x004A7E20
		public IEntityAttachPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097D2 RID: 38866
		// (get) Token: 0x06021994 RID: 137620 RVA: 0x004A9C30 File Offset: 0x004A7E30
		public string Name
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021995 RID: 137621 RVA: 0x004A9C67 File Offset: 0x004A7E67
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06021996 RID: 137622 RVA: 0x004A9C76 File Offset: 0x004A7E76
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170097D3 RID: 38867
		// (get) Token: 0x06021997 RID: 137623 RVA: 0x004A9C84 File Offset: 0x004A7E84
		public IVectorInfo? AttachPoint
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06021998 RID: 137624 RVA: 0x004A9CE1 File Offset: 0x004A7EE1
		public static Offset<IEntityAttachPoint> CreateIEntityAttachPoint(FlatBufferBuilder builder, StringOffset NameOffset = default(StringOffset), Offset<IVectorInfo> AttachPointOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IEntityAttachPoint.AddAttachPoint(builder, AttachPointOffset);
			IEntityAttachPoint.AddName(builder, NameOffset);
			return IEntityAttachPoint.EndIEntityAttachPoint(builder);
		}

		// Token: 0x06021999 RID: 137625 RVA: 0x004A9CFE File Offset: 0x004A7EFE
		public static void StartIEntityAttachPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602199A RID: 137626 RVA: 0x004A9D07 File Offset: 0x004A7F07
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(0, nameOffset.Value, 0);
		}

		// Token: 0x0602199B RID: 137627 RVA: 0x004A9D17 File Offset: 0x004A7F17
		public static void AddAttachPoint(FlatBufferBuilder builder, Offset<IVectorInfo> attachPointOffset)
		{
			builder.AddOffset(1, attachPointOffset.Value, 0);
		}

		// Token: 0x0602199C RID: 137628 RVA: 0x004A9D27 File Offset: 0x004A7F27
		public static Offset<IEntityAttachPoint> EndIEntityAttachPoint(FlatBufferBuilder builder)
		{
			return new Offset<IEntityAttachPoint>(builder.EndTable());
		}

		// Token: 0x0602199D RID: 137629 RVA: 0x004A9D34 File Offset: 0x004A7F34
		public IEntityAttachPointT UnPack()
		{
			IEntityAttachPointT entityAttachPointT = new IEntityAttachPointT();
			this.UnPackTo(entityAttachPointT);
			return entityAttachPointT;
		}

		// Token: 0x0602199E RID: 137630 RVA: 0x004A9D50 File Offset: 0x004A7F50
		public void UnPackTo(IEntityAttachPointT _o)
		{
			_o.Name = this.Name;
			_o.AttachPoint = ((this.AttachPoint != null) ? this.AttachPoint.Value.UnPack() : null);
		}

		// Token: 0x0602199F RID: 137631 RVA: 0x004A9D98 File Offset: 0x004A7F98
		public static Offset<IEntityAttachPoint> Pack(FlatBufferBuilder builder, IEntityAttachPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityAttachPoint>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			Offset<IVectorInfo> attachPointOffset = (_o.AttachPoint == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.AttachPoint);
			return IEntityAttachPoint.CreateIEntityAttachPoint(builder, nameOffset, attachPointOffset);
		}

		// Token: 0x0400E1EC RID: 57836
		private Table __p;
	}
}
