using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056B5 RID: 22197
	public struct IEntityAttachPoint : IFlatbufferObject
	{
		// Token: 0x17009FBE RID: 40894
		// (get) Token: 0x060238E2 RID: 145634 RVA: 0x004E3B4E File Offset: 0x004E1D4E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060238E3 RID: 145635 RVA: 0x004E3B5B File Offset: 0x004E1D5B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060238E4 RID: 145636 RVA: 0x004E3B64 File Offset: 0x004E1D64
		public static IEntityAttachPoint GetRootAsIEntityAttachPoint(ByteBuffer _bb)
		{
			return IEntityAttachPoint.GetRootAsIEntityAttachPoint(_bb, default(IEntityAttachPoint));
		}

		// Token: 0x060238E5 RID: 145637 RVA: 0x004E3B80 File Offset: 0x004E1D80
		public static IEntityAttachPoint GetRootAsIEntityAttachPoint(ByteBuffer _bb, IEntityAttachPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060238E6 RID: 145638 RVA: 0x004E3B9D File Offset: 0x004E1D9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060238E7 RID: 145639 RVA: 0x004E3BAC File Offset: 0x004E1DAC
		public IEntityAttachPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009FBF RID: 40895
		// (get) Token: 0x060238E8 RID: 145640 RVA: 0x004E3BBC File Offset: 0x004E1DBC
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

		// Token: 0x060238E9 RID: 145641 RVA: 0x004E3BF3 File Offset: 0x004E1DF3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060238EA RID: 145642 RVA: 0x004E3C02 File Offset: 0x004E1E02
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009FC0 RID: 40896
		// (get) Token: 0x060238EB RID: 145643 RVA: 0x004E3C10 File Offset: 0x004E1E10
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

		// Token: 0x060238EC RID: 145644 RVA: 0x004E3C6D File Offset: 0x004E1E6D
		public static Offset<IEntityAttachPoint> CreateIEntityAttachPoint(FlatBufferBuilder builder, StringOffset NameOffset = default(StringOffset), Offset<IVectorInfo> AttachPointOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IEntityAttachPoint.AddAttachPoint(builder, AttachPointOffset);
			IEntityAttachPoint.AddName(builder, NameOffset);
			return IEntityAttachPoint.EndIEntityAttachPoint(builder);
		}

		// Token: 0x060238ED RID: 145645 RVA: 0x004E3C8A File Offset: 0x004E1E8A
		public static void StartIEntityAttachPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060238EE RID: 145646 RVA: 0x004E3C93 File Offset: 0x004E1E93
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(0, nameOffset.Value, 0);
		}

		// Token: 0x060238EF RID: 145647 RVA: 0x004E3CA3 File Offset: 0x004E1EA3
		public static void AddAttachPoint(FlatBufferBuilder builder, Offset<IVectorInfo> attachPointOffset)
		{
			builder.AddOffset(1, attachPointOffset.Value, 0);
		}

		// Token: 0x060238F0 RID: 145648 RVA: 0x004E3CB3 File Offset: 0x004E1EB3
		public static Offset<IEntityAttachPoint> EndIEntityAttachPoint(FlatBufferBuilder builder)
		{
			return new Offset<IEntityAttachPoint>(builder.EndTable());
		}

		// Token: 0x060238F1 RID: 145649 RVA: 0x004E3CC0 File Offset: 0x004E1EC0
		public IEntityAttachPointT UnPack()
		{
			IEntityAttachPointT entityAttachPointT = new IEntityAttachPointT();
			this.UnPackTo(entityAttachPointT);
			return entityAttachPointT;
		}

		// Token: 0x060238F2 RID: 145650 RVA: 0x004E3CDC File Offset: 0x004E1EDC
		public void UnPackTo(IEntityAttachPointT _o)
		{
			_o.Name = this.Name;
			_o.AttachPoint = ((this.AttachPoint != null) ? this.AttachPoint.Value.UnPack() : null);
		}

		// Token: 0x060238F3 RID: 145651 RVA: 0x004E3D24 File Offset: 0x004E1F24
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

		// Token: 0x0400EDE9 RID: 60905
		private Table __p;
	}
}
