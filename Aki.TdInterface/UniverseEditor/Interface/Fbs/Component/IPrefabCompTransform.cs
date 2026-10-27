using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005775 RID: 22389
	public struct IPrefabCompTransform : IFlatbufferObject
	{
		// Token: 0x1700A6FE RID: 42750
		// (get) Token: 0x0602586D RID: 153709 RVA: 0x0052D5A8 File Offset: 0x0052B7A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602586E RID: 153710 RVA: 0x0052D5B5 File Offset: 0x0052B7B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602586F RID: 153711 RVA: 0x0052D5BC File Offset: 0x0052B7BC
		public static IPrefabCompTransform GetRootAsIPrefabCompTransform(ByteBuffer _bb)
		{
			return IPrefabCompTransform.GetRootAsIPrefabCompTransform(_bb, default(IPrefabCompTransform));
		}

		// Token: 0x06025870 RID: 153712 RVA: 0x0052D5D8 File Offset: 0x0052B7D8
		public static IPrefabCompTransform GetRootAsIPrefabCompTransform(ByteBuffer _bb, IPrefabCompTransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025871 RID: 153713 RVA: 0x0052D5F5 File Offset: 0x0052B7F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025872 RID: 153714 RVA: 0x0052D604 File Offset: 0x0052B804
		public IPrefabCompTransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6FF RID: 42751
		// (get) Token: 0x06025873 RID: 153715 RVA: 0x0052D614 File Offset: 0x0052B814
		public string ReferenceActorKey
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

		// Token: 0x06025874 RID: 153716 RVA: 0x0052D64B File Offset: 0x0052B84B
		public Span<byte> GetReferenceActorKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06025875 RID: 153717 RVA: 0x0052D65A File Offset: 0x0052B85A
		public byte[] GetReferenceActorKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A700 RID: 42752
		// (get) Token: 0x06025876 RID: 153718 RVA: 0x0052D668 File Offset: 0x0052B868
		public IPrefabCompTransformItem? Location
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPrefabCompTransformItem?(default(IPrefabCompTransformItem).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A701 RID: 42753
		// (get) Token: 0x06025877 RID: 153719 RVA: 0x0052D6C8 File Offset: 0x0052B8C8
		public IPrefabCompTransformItem? Rotation
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IPrefabCompTransformItem?(default(IPrefabCompTransformItem).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A702 RID: 42754
		// (get) Token: 0x06025878 RID: 153720 RVA: 0x0052D728 File Offset: 0x0052B928
		public IPrefabCompTransformItem? Scale
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IPrefabCompTransformItem?(default(IPrefabCompTransformItem).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06025879 RID: 153721 RVA: 0x0052D786 File Offset: 0x0052B986
		public static Offset<IPrefabCompTransform> CreateIPrefabCompTransform(FlatBufferBuilder builder, StringOffset ReferenceActorKeyOffset = default(StringOffset), Offset<IPrefabCompTransformItem> LocationOffset = default(Offset<IPrefabCompTransformItem>), Offset<IPrefabCompTransformItem> RotationOffset = default(Offset<IPrefabCompTransformItem>), Offset<IPrefabCompTransformItem> ScaleOffset = default(Offset<IPrefabCompTransformItem>))
		{
			builder.StartTable(4);
			IPrefabCompTransform.AddScale(builder, ScaleOffset);
			IPrefabCompTransform.AddRotation(builder, RotationOffset);
			IPrefabCompTransform.AddLocation(builder, LocationOffset);
			IPrefabCompTransform.AddReferenceActorKey(builder, ReferenceActorKeyOffset);
			return IPrefabCompTransform.EndIPrefabCompTransform(builder);
		}

		// Token: 0x0602587A RID: 153722 RVA: 0x0052D7B2 File Offset: 0x0052B9B2
		public static void StartIPrefabCompTransform(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602587B RID: 153723 RVA: 0x0052D7BB File Offset: 0x0052B9BB
		public static void AddReferenceActorKey(FlatBufferBuilder builder, StringOffset referenceActorKeyOffset)
		{
			builder.AddOffset(0, referenceActorKeyOffset.Value, 0);
		}

		// Token: 0x0602587C RID: 153724 RVA: 0x0052D7CB File Offset: 0x0052B9CB
		public static void AddLocation(FlatBufferBuilder builder, Offset<IPrefabCompTransformItem> locationOffset)
		{
			builder.AddOffset(1, locationOffset.Value, 0);
		}

		// Token: 0x0602587D RID: 153725 RVA: 0x0052D7DB File Offset: 0x0052B9DB
		public static void AddRotation(FlatBufferBuilder builder, Offset<IPrefabCompTransformItem> rotationOffset)
		{
			builder.AddOffset(2, rotationOffset.Value, 0);
		}

		// Token: 0x0602587E RID: 153726 RVA: 0x0052D7EB File Offset: 0x0052B9EB
		public static void AddScale(FlatBufferBuilder builder, Offset<IPrefabCompTransformItem> scaleOffset)
		{
			builder.AddOffset(3, scaleOffset.Value, 0);
		}

		// Token: 0x0602587F RID: 153727 RVA: 0x0052D7FB File Offset: 0x0052B9FB
		public static Offset<IPrefabCompTransform> EndIPrefabCompTransform(FlatBufferBuilder builder)
		{
			return new Offset<IPrefabCompTransform>(builder.EndTable());
		}

		// Token: 0x06025880 RID: 153728 RVA: 0x0052D808 File Offset: 0x0052BA08
		public IPrefabCompTransformT UnPack()
		{
			IPrefabCompTransformT prefabCompTransformT = new IPrefabCompTransformT();
			this.UnPackTo(prefabCompTransformT);
			return prefabCompTransformT;
		}

		// Token: 0x06025881 RID: 153729 RVA: 0x0052D824 File Offset: 0x0052BA24
		public void UnPackTo(IPrefabCompTransformT _o)
		{
			_o.ReferenceActorKey = this.ReferenceActorKey;
			_o.Location = ((this.Location != null) ? this.Location.Value.UnPack() : null);
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
			_o.Scale = ((this.Scale != null) ? this.Scale.Value.UnPack() : null);
		}

		// Token: 0x06025882 RID: 153730 RVA: 0x0052D8CC File Offset: 0x0052BACC
		public static Offset<IPrefabCompTransform> Pack(FlatBufferBuilder builder, IPrefabCompTransformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPrefabCompTransform>);
			}
			StringOffset referenceActorKeyOffset = (_o.ReferenceActorKey == null) ? default(StringOffset) : builder.CreateString(_o.ReferenceActorKey);
			Offset<IPrefabCompTransformItem> locationOffset = (_o.Location == null) ? default(Offset<IPrefabCompTransformItem>) : IPrefabCompTransformItem.Pack(builder, _o.Location);
			Offset<IPrefabCompTransformItem> rotationOffset = (_o.Rotation == null) ? default(Offset<IPrefabCompTransformItem>) : IPrefabCompTransformItem.Pack(builder, _o.Rotation);
			Offset<IPrefabCompTransformItem> scaleOffset = (_o.Scale == null) ? default(Offset<IPrefabCompTransformItem>) : IPrefabCompTransformItem.Pack(builder, _o.Scale);
			return IPrefabCompTransform.CreateIPrefabCompTransform(builder, referenceActorKeyOffset, locationOffset, rotationOffset, scaleOffset);
		}

		// Token: 0x0400EC20 RID: 60448
		private Table __p;
	}
}
