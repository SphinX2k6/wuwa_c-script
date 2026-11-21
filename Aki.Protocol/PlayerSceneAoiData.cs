using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D9B RID: 3483
	public sealed class PlayerSceneAoiData : IMessage<PlayerSceneAoiData>, IMessage, IEquatable<PlayerSceneAoiData>, IDeepCloneable<PlayerSceneAoiData>, IBufferMessage
	{
		// Token: 0x06012CA2 RID: 76962 RVA: 0x002BE145 File Offset: 0x002BC345
		[NullableContext(1)]
		public static PlayerSceneAoiData Create()
		{
			return new PlayerSceneAoiData();
		}

		// Token: 0x17003E56 RID: 15958
		// (get) Token: 0x06012CA3 RID: 76963 RVA: 0x002BE14C File Offset: 0x002BC34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E57 RID: 15959
		// (get) Token: 0x06012CA4 RID: 76964 RVA: 0x002BE14F File Offset: 0x002BC34F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerSceneAoiData.Descriptor;
			}
		}

		// Token: 0x06012CA5 RID: 76965 RVA: 0x002BE156 File Offset: 0x002BC356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSceneAoiData()
		{
		}

		// Token: 0x06012CA6 RID: 76966 RVA: 0x002BE180 File Offset: 0x002BC380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSceneAoiData(PlayerSceneAoiData other) : this()
		{
			this.dynamicEntityList_ = other.dynamicEntityList_.Clone();
			this.genIds_ = other.genIds_.Clone();
			this.entities_ = other.entities_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012CA7 RID: 76967 RVA: 0x002BE1D7 File Offset: 0x002BC3D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSceneAoiData Clone()
		{
			return new PlayerSceneAoiData(this);
		}

		// Token: 0x17003E58 RID: 15960
		// (get) Token: 0x06012CA8 RID: 76968 RVA: 0x002BE1DF File Offset: 0x002BC3DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DynamicEntityInformation> DynamicEntityList
		{
			get
			{
				return this.dynamicEntityList_;
			}
		}

		// Token: 0x17003E59 RID: 15961
		// (get) Token: 0x06012CA9 RID: 76969 RVA: 0x002BE1E7 File Offset: 0x002BC3E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> GenIds
		{
			get
			{
				return this.genIds_;
			}
		}

		// Token: 0x17003E5A RID: 15962
		// (get) Token: 0x06012CAA RID: 76970 RVA: 0x002BE1EF File Offset: 0x002BC3EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityPb> Entities
		{
			get
			{
				return this.entities_;
			}
		}

		// Token: 0x06012CAB RID: 76971 RVA: 0x002BE1F7 File Offset: 0x002BC3F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerSceneAoiData);
		}

		// Token: 0x06012CAC RID: 76972 RVA: 0x002BE208 File Offset: 0x002BC408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerSceneAoiData other)
		{
			return other != null && (other == this || (this.dynamicEntityList_.Equals(other.dynamicEntityList_) && this.genIds_.Equals(other.genIds_) && this.entities_.Equals(other.entities_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012CAD RID: 76973 RVA: 0x002BE270 File Offset: 0x002BC470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.dynamicEntityList_.GetHashCode();
			num ^= this.genIds_.GetHashCode();
			num ^= this.entities_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012CAE RID: 76974 RVA: 0x002BE2C0 File Offset: 0x002BC4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012CAF RID: 76975 RVA: 0x002BE2CD File Offset: 0x002BC4CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012CB0 RID: 76976 RVA: 0x002BE2D8 File Offset: 0x002BC4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dynamicEntityList_.WriteTo(ref output, PlayerSceneAoiData._repeated_dynamicEntityList_codec);
			this.genIds_.WriteTo(ref output, PlayerSceneAoiData._repeated_genIds_codec);
			this.entities_.WriteTo(ref output, PlayerSceneAoiData._repeated_entities_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012CB1 RID: 76977 RVA: 0x002BE32C File Offset: 0x002BC52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dynamicEntityList_.CalculateSize(PlayerSceneAoiData._repeated_dynamicEntityList_codec);
			num += this.genIds_.CalculateSize(PlayerSceneAoiData._repeated_genIds_codec);
			num += this.entities_.CalculateSize(PlayerSceneAoiData._repeated_entities_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012CB2 RID: 76978 RVA: 0x002BE38C File Offset: 0x002BC58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerSceneAoiData other)
		{
			if (other == null)
			{
				return;
			}
			this.dynamicEntityList_.Add(other.dynamicEntityList_);
			this.genIds_.Add(other.genIds_);
			this.entities_.Add(other.entities_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012CB3 RID: 76979 RVA: 0x002BE3E7 File Offset: 0x002BC5E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012CB4 RID: 76980 RVA: 0x002BE3F0 File Offset: 0x002BC5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.dynamicEntityList_.AddEntriesFrom(ref input, PlayerSceneAoiData._repeated_dynamicEntityList_codec);
						continue;
					}
					if (num == 16U)
					{
						goto IL_4B;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_4B;
					}
					if (num == 26U)
					{
						this.entities_.AddEntriesFrom(ref input, PlayerSceneAoiData._repeated_entities_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4B:
				this.genIds_.AddEntriesFrom(ref input, PlayerSceneAoiData._repeated_genIds_codec);
			}
		}

		// Token: 0x040074C2 RID: 29890
		private UnknownFieldSet _unknownFields;

		// Token: 0x040074C3 RID: 29891
		public const int DynamicEntityListFieldNumber = 1;

		// Token: 0x040074C4 RID: 29892
		private static readonly FieldCodec<DynamicEntityInformation> _repeated_dynamicEntityList_codec = FieldCodec.ForMessage<DynamicEntityInformation>(10U, DynamicEntityInformation.Parser);

		// Token: 0x040074C5 RID: 29893
		private readonly RepeatedField<DynamicEntityInformation> dynamicEntityList_ = new RepeatedField<DynamicEntityInformation>();

		// Token: 0x040074C6 RID: 29894
		public const int GenIdsFieldNumber = 2;

		// Token: 0x040074C7 RID: 29895
		private static readonly FieldCodec<long> _repeated_genIds_codec = FieldCodec.ForInt64(18U);

		// Token: 0x040074C8 RID: 29896
		private readonly RepeatedField<long> genIds_ = new RepeatedField<long>();

		// Token: 0x040074C9 RID: 29897
		public const int EntitiesFieldNumber = 3;

		// Token: 0x040074CA RID: 29898
		private static readonly FieldCodec<EntityPb> _repeated_entities_codec = FieldCodec.ForMessage<EntityPb>(26U, EntityPb.Parser);

		// Token: 0x040074CB RID: 29899
		private readonly RepeatedField<EntityPb> entities_ = new RepeatedField<EntityPb>();
	}
}
