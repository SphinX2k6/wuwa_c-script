using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000987 RID: 2439
	[NetMessage(EMessageId.MapMarkInfoNotify)]
	public sealed class MapMarkInfoNotify : IMessage<MapMarkInfoNotify>, IMessage, IEquatable<MapMarkInfoNotify>, IDeepCloneable<MapMarkInfoNotify>, IBufferMessage
	{
		// Token: 0x0600D670 RID: 54896 RVA: 0x001F882E File Offset: 0x001F6A2E
		[NullableContext(1)]
		public static MapMarkInfoNotify Create()
		{
			return new MapMarkInfoNotify();
		}

		// Token: 0x17002B68 RID: 11112
		// (get) Token: 0x0600D671 RID: 54897 RVA: 0x001F8835 File Offset: 0x001F6A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B69 RID: 11113
		// (get) Token: 0x0600D672 RID: 54898 RVA: 0x001F8838 File Offset: 0x001F6A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapMarkInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600D673 RID: 54899 RVA: 0x001F8840 File Offset: 0x001F6A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoNotify()
		{
		}

		// Token: 0x0600D674 RID: 54900 RVA: 0x001F8898 File Offset: 0x001F6A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoNotify(MapMarkInfoNotify other) : this()
		{
			this.infoList_ = other.infoList_.Clone();
			this.showMarkIds_ = other.showMarkIds_.Clone();
			this.unlockMarkIds_ = other.unlockMarkIds_.Clone();
			this.entityMapMarkInfo_ = other.entityMapMarkInfo_.Clone();
			this.systemMarkHideInfo_ = other.systemMarkHideInfo_.Clone();
			this.completeMarkIds_ = other.completeMarkIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D675 RID: 54901 RVA: 0x001F8922 File Offset: 0x001F6B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoNotify Clone()
		{
			return new MapMarkInfoNotify(this);
		}

		// Token: 0x17002B6A RID: 11114
		// (get) Token: 0x0600D676 RID: 54902 RVA: 0x001F892A File Offset: 0x001F6B2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MarkPointInfo> InfoList
		{
			get
			{
				return this.infoList_;
			}
		}

		// Token: 0x17002B6B RID: 11115
		// (get) Token: 0x0600D677 RID: 54903 RVA: 0x001F8932 File Offset: 0x001F6B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MapMarkShowInfo> ShowMarkIds
		{
			get
			{
				return this.showMarkIds_;
			}
		}

		// Token: 0x17002B6C RID: 11116
		// (get) Token: 0x0600D678 RID: 54904 RVA: 0x001F893A File Offset: 0x001F6B3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockMarkIds
		{
			get
			{
				return this.unlockMarkIds_;
			}
		}

		// Token: 0x17002B6D RID: 11117
		// (get) Token: 0x0600D679 RID: 54905 RVA: 0x001F8942 File Offset: 0x001F6B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityMapMarkInfoPb> EntityMapMarkInfo
		{
			get
			{
				return this.entityMapMarkInfo_;
			}
		}

		// Token: 0x17002B6E RID: 11118
		// (get) Token: 0x0600D67A RID: 54906 RVA: 0x001F894A File Offset: 0x001F6B4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SystemMarkHideInfoPb> SystemMarkHideInfo
		{
			get
			{
				return this.systemMarkHideInfo_;
			}
		}

		// Token: 0x17002B6F RID: 11119
		// (get) Token: 0x0600D67B RID: 54907 RVA: 0x001F8952 File Offset: 0x001F6B52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CompleteMarkIds
		{
			get
			{
				return this.completeMarkIds_;
			}
		}

		// Token: 0x0600D67C RID: 54908 RVA: 0x001F895A File Offset: 0x001F6B5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapMarkInfoNotify);
		}

		// Token: 0x0600D67D RID: 54909 RVA: 0x001F8968 File Offset: 0x001F6B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapMarkInfoNotify other)
		{
			return other != null && (other == this || (this.infoList_.Equals(other.infoList_) && this.showMarkIds_.Equals(other.showMarkIds_) && this.unlockMarkIds_.Equals(other.unlockMarkIds_) && this.entityMapMarkInfo_.Equals(other.entityMapMarkInfo_) && this.systemMarkHideInfo_.Equals(other.systemMarkHideInfo_) && this.completeMarkIds_.Equals(other.completeMarkIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D67E RID: 54910 RVA: 0x001F8A10 File Offset: 0x001F6C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.infoList_.GetHashCode();
			num ^= this.showMarkIds_.GetHashCode();
			num ^= this.unlockMarkIds_.GetHashCode();
			num ^= this.entityMapMarkInfo_.GetHashCode();
			num ^= this.systemMarkHideInfo_.GetHashCode();
			num ^= this.completeMarkIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D67F RID: 54911 RVA: 0x001F8A8A File Offset: 0x001F6C8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D680 RID: 54912 RVA: 0x001F8A97 File Offset: 0x001F6C97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D681 RID: 54913 RVA: 0x001F8AA0 File Offset: 0x001F6CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.completeMarkIds_.WriteTo(ref output, MapMarkInfoNotify._repeated_completeMarkIds_codec);
			this.showMarkIds_.WriteTo(ref output, MapMarkInfoNotify._repeated_showMarkIds_codec);
			this.entityMapMarkInfo_.WriteTo(ref output, MapMarkInfoNotify._repeated_entityMapMarkInfo_codec);
			this.unlockMarkIds_.WriteTo(ref output, MapMarkInfoNotify._repeated_unlockMarkIds_codec);
			this.systemMarkHideInfo_.WriteTo(ref output, MapMarkInfoNotify._repeated_systemMarkHideInfo_codec);
			this.infoList_.WriteTo(ref output, MapMarkInfoNotify._repeated_infoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D682 RID: 54914 RVA: 0x001F8B28 File Offset: 0x001F6D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.infoList_.CalculateSize(MapMarkInfoNotify._repeated_infoList_codec);
			num += this.showMarkIds_.CalculateSize(MapMarkInfoNotify._repeated_showMarkIds_codec);
			num += this.unlockMarkIds_.CalculateSize(MapMarkInfoNotify._repeated_unlockMarkIds_codec);
			num += this.entityMapMarkInfo_.CalculateSize(MapMarkInfoNotify._repeated_entityMapMarkInfo_codec);
			num += this.systemMarkHideInfo_.CalculateSize(MapMarkInfoNotify._repeated_systemMarkHideInfo_codec);
			num += this.completeMarkIds_.CalculateSize(MapMarkInfoNotify._repeated_completeMarkIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D683 RID: 54915 RVA: 0x001F8BC0 File Offset: 0x001F6DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapMarkInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.infoList_.Add(other.infoList_);
			this.showMarkIds_.Add(other.showMarkIds_);
			this.unlockMarkIds_.Add(other.unlockMarkIds_);
			this.entityMapMarkInfo_.Add(other.entityMapMarkInfo_);
			this.systemMarkHideInfo_.Add(other.systemMarkHideInfo_);
			this.completeMarkIds_.Add(other.completeMarkIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D684 RID: 54916 RVA: 0x001F8C4E File Offset: 0x001F6E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D685 RID: 54917 RVA: 0x001F8C58 File Offset: 0x001F6E58
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
				if (num <= 34U)
				{
					if (num <= 10U)
					{
						if (num == 8U || num == 10U)
						{
							this.completeMarkIds_.AddEntriesFrom(ref input, MapMarkInfoNotify._repeated_completeMarkIds_codec);
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							this.showMarkIds_.AddEntriesFrom(ref input, MapMarkInfoNotify._repeated_showMarkIds_codec);
							continue;
						}
						if (num == 34U)
						{
							this.entityMapMarkInfo_.AddEntriesFrom(ref input, MapMarkInfoNotify._repeated_entityMapMarkInfo_codec);
							continue;
						}
					}
				}
				else if (num <= 42U)
				{
					if (num == 40U || num == 42U)
					{
						this.unlockMarkIds_.AddEntriesFrom(ref input, MapMarkInfoNotify._repeated_unlockMarkIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						this.systemMarkHideInfo_.AddEntriesFrom(ref input, MapMarkInfoNotify._repeated_systemMarkHideInfo_codec);
						continue;
					}
					if (num == 106U)
					{
						this.infoList_.AddEntriesFrom(ref input, MapMarkInfoNotify._repeated_infoList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400599C RID: 22940
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400599D RID: 22941
		public const int InfoListFieldNumber = 13;

		// Token: 0x0400599E RID: 22942
		private static readonly FieldCodec<MarkPointInfo> _repeated_infoList_codec = FieldCodec.ForMessage<MarkPointInfo>(106U, MarkPointInfo.Parser);

		// Token: 0x0400599F RID: 22943
		private readonly RepeatedField<MarkPointInfo> infoList_ = new RepeatedField<MarkPointInfo>();

		// Token: 0x040059A0 RID: 22944
		public const int ShowMarkIdsFieldNumber = 3;

		// Token: 0x040059A1 RID: 22945
		private static readonly FieldCodec<MapMarkShowInfo> _repeated_showMarkIds_codec = FieldCodec.ForMessage<MapMarkShowInfo>(26U, MapMarkShowInfo.Parser);

		// Token: 0x040059A2 RID: 22946
		private readonly RepeatedField<MapMarkShowInfo> showMarkIds_ = new RepeatedField<MapMarkShowInfo>();

		// Token: 0x040059A3 RID: 22947
		public const int UnlockMarkIdsFieldNumber = 5;

		// Token: 0x040059A4 RID: 22948
		private static readonly FieldCodec<int> _repeated_unlockMarkIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x040059A5 RID: 22949
		private readonly RepeatedField<int> unlockMarkIds_ = new RepeatedField<int>();

		// Token: 0x040059A6 RID: 22950
		public const int EntityMapMarkInfoFieldNumber = 4;

		// Token: 0x040059A7 RID: 22951
		private static readonly FieldCodec<EntityMapMarkInfoPb> _repeated_entityMapMarkInfo_codec = FieldCodec.ForMessage<EntityMapMarkInfoPb>(34U, EntityMapMarkInfoPb.Parser);

		// Token: 0x040059A8 RID: 22952
		private readonly RepeatedField<EntityMapMarkInfoPb> entityMapMarkInfo_ = new RepeatedField<EntityMapMarkInfoPb>();

		// Token: 0x040059A9 RID: 22953
		public const int SystemMarkHideInfoFieldNumber = 7;

		// Token: 0x040059AA RID: 22954
		private static readonly FieldCodec<SystemMarkHideInfoPb> _repeated_systemMarkHideInfo_codec = FieldCodec.ForMessage<SystemMarkHideInfoPb>(58U, SystemMarkHideInfoPb.Parser);

		// Token: 0x040059AB RID: 22955
		private readonly RepeatedField<SystemMarkHideInfoPb> systemMarkHideInfo_ = new RepeatedField<SystemMarkHideInfoPb>();

		// Token: 0x040059AC RID: 22956
		public const int CompleteMarkIdsFieldNumber = 1;

		// Token: 0x040059AD RID: 22957
		private static readonly FieldCodec<int> _repeated_completeMarkIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040059AE RID: 22958
		private readonly RepeatedField<int> completeMarkIds_ = new RepeatedField<int>();
	}
}
