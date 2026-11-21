using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D7C RID: 23932
	public struct IPrefabCompTransform : IFlatbufferObject
	{
		// Token: 0x1700B022 RID: 45090
		// (get) Token: 0x06027D8D RID: 163213 RVA: 0x00573734 File Offset: 0x00571934
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027D8E RID: 163214 RVA: 0x00573741 File Offset: 0x00571941
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027D8F RID: 163215 RVA: 0x00573748 File Offset: 0x00571948
		public static IPrefabCompTransform GetRootAsIPrefabCompTransform(ByteBuffer _bb)
		{
			return IPrefabCompTransform.GetRootAsIPrefabCompTransform(_bb, default(IPrefabCompTransform));
		}

		// Token: 0x06027D90 RID: 163216 RVA: 0x00573764 File Offset: 0x00571964
		public static IPrefabCompTransform GetRootAsIPrefabCompTransform(ByteBuffer _bb, IPrefabCompTransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027D91 RID: 163217 RVA: 0x00573781 File Offset: 0x00571981
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027D92 RID: 163218 RVA: 0x00573790 File Offset: 0x00571990
		public IPrefabCompTransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B023 RID: 45091
		// (get) Token: 0x06027D93 RID: 163219 RVA: 0x005737A0 File Offset: 0x005719A0
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

		// Token: 0x06027D94 RID: 163220 RVA: 0x005737D7 File Offset: 0x005719D7
		public Span<byte> GetReferenceActorKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06027D95 RID: 163221 RVA: 0x005737E6 File Offset: 0x005719E6
		public byte[] GetReferenceActorKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B024 RID: 45092
		// (get) Token: 0x06027D96 RID: 163222 RVA: 0x005737F4 File Offset: 0x005719F4
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

		// Token: 0x1700B025 RID: 45093
		// (get) Token: 0x06027D97 RID: 163223 RVA: 0x00573854 File Offset: 0x00571A54
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

		// Token: 0x1700B026 RID: 45094
		// (get) Token: 0x06027D98 RID: 163224 RVA: 0x005738B4 File Offset: 0x00571AB4
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

		// Token: 0x06027D99 RID: 163225 RVA: 0x00573912 File Offset: 0x00571B12
		public static Offset<IPrefabCompTransform> CreateIPrefabCompTransform(FlatBufferBuilder builder, StringOffset ReferenceActorKeyOffset = default(StringOffset), Offset<IPrefabCompTransformItem> LocationOffset = default(Offset<IPrefabCompTransformItem>), Offset<IPrefabCompTransformItem> RotationOffset = default(Offset<IPrefabCompTransformItem>), Offset<IPrefabCompTransformItem> ScaleOffset = default(Offset<IPrefabCompTransformItem>))
		{
			builder.StartTable(4);
			IPrefabCompTransform.AddScale(builder, ScaleOffset);
			IPrefabCompTransform.AddRotation(builder, RotationOffset);
			IPrefabCompTransform.AddLocation(builder, LocationOffset);
			IPrefabCompTransform.AddReferenceActorKey(builder, ReferenceActorKeyOffset);
			return IPrefabCompTransform.EndIPrefabCompTransform(builder);
		}

		// Token: 0x06027D9A RID: 163226 RVA: 0x0057393E File Offset: 0x00571B3E
		public static void StartIPrefabCompTransform(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06027D9B RID: 163227 RVA: 0x00573947 File Offset: 0x00571B47
		public static void AddReferenceActorKey(FlatBufferBuilder builder, StringOffset referenceActorKeyOffset)
		{
			builder.AddOffset(0, referenceActorKeyOffset.Value, 0);
		}

		// Token: 0x06027D9C RID: 163228 RVA: 0x00573957 File Offset: 0x00571B57
		public static void AddLocation(FlatBufferBuilder builder, Offset<IPrefabCompTransformItem> locationOffset)
		{
			builder.AddOffset(1, locationOffset.Value, 0);
		}

		// Token: 0x06027D9D RID: 163229 RVA: 0x00573967 File Offset: 0x00571B67
		public static void AddRotation(FlatBufferBuilder builder, Offset<IPrefabCompTransformItem> rotationOffset)
		{
			builder.AddOffset(2, rotationOffset.Value, 0);
		}

		// Token: 0x06027D9E RID: 163230 RVA: 0x00573977 File Offset: 0x00571B77
		public static void AddScale(FlatBufferBuilder builder, Offset<IPrefabCompTransformItem> scaleOffset)
		{
			builder.AddOffset(3, scaleOffset.Value, 0);
		}

		// Token: 0x06027D9F RID: 163231 RVA: 0x00573987 File Offset: 0x00571B87
		public static Offset<IPrefabCompTransform> EndIPrefabCompTransform(FlatBufferBuilder builder)
		{
			return new Offset<IPrefabCompTransform>(builder.EndTable());
		}

		// Token: 0x06027DA0 RID: 163232 RVA: 0x00573994 File Offset: 0x00571B94
		public IPrefabCompTransformT UnPack()
		{
			IPrefabCompTransformT prefabCompTransformT = new IPrefabCompTransformT();
			this.UnPackTo(prefabCompTransformT);
			return prefabCompTransformT;
		}

		// Token: 0x06027DA1 RID: 163233 RVA: 0x005739B0 File Offset: 0x00571BB0
		public void UnPackTo(IPrefabCompTransformT _o)
		{
			_o.ReferenceActorKey = this.ReferenceActorKey;
			_o.Location = ((this.Location != null) ? this.Location.Value.UnPack() : null);
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
			_o.Scale = ((this.Scale != null) ? this.Scale.Value.UnPack() : null);
		}

		// Token: 0x06027DA2 RID: 163234 RVA: 0x00573A58 File Offset: 0x00571C58
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

		// Token: 0x0400F90B RID: 63755
		private Table __p;
	}
}
