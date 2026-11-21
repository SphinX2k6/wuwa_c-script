using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000976 RID: 2422
	[NetMessage(EMessageId.MapMarkInfoNotify)]
	public sealed class MapMarkInfoNotify : IMessage<MapMarkInfoNotify>, IMessage, IEquatable<MapMarkInfoNotify>, IDeepCloneable<MapMarkInfoNotify>, IBufferMessage
	{
		// Token: 0x0600D556 RID: 54614 RVA: 0x001F664B File Offset: 0x001F484B
		[NullableContext(1)]
		public static MapMarkInfoNotify Create()
		{
			return new MapMarkInfoNotify();
		}

		// Token: 0x17002B2A RID: 11050
		// (get) Token: 0x0600D557 RID: 54615 RVA: 0x001F6652 File Offset: 0x001F4852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B2B RID: 11051
		// (get) Token: 0x0600D558 RID: 54616 RVA: 0x001F6655 File Offset: 0x001F4855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapMarkInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600D559 RID: 54617 RVA: 0x001F665C File Offset: 0x001F485C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoNotify()
		{
		}

		// Token: 0x0600D55A RID: 54618 RVA: 0x001F66B4 File Offset: 0x001F48B4
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

		// Token: 0x0600D55B RID: 54619 RVA: 0x001F673E File Offset: 0x001F493E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkInfoNotify Clone()
		{
			return new MapMarkInfoNotify(this);
		}

		// Token: 0x17002B2C RID: 11052
		// (get) Token: 0x0600D55C RID: 54620 RVA: 0x001F6746 File Offset: 0x001F4946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MarkPointInfo> InfoList
		{
			get
			{
				return this.infoList_;
			}
		}

		// Token: 0x17002B2D RID: 11053
		// (get) Token: 0x0600D55D RID: 54621 RVA: 0x001F674E File Offset: 0x001F494E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MapMarkShowInfo> ShowMarkIds
		{
			get
			{
				return this.showMarkIds_;
			}
		}

		// Token: 0x17002B2E RID: 11054
		// (get) Token: 0x0600D55E RID: 54622 RVA: 0x001F6756 File Offset: 0x001F4956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockMarkIds
		{
			get
			{
				return this.unlockMarkIds_;
			}
		}

		// Token: 0x17002B2F RID: 11055
		// (get) Token: 0x0600D55F RID: 54623 RVA: 0x001F675E File Offset: 0x001F495E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityMapMarkInfoPb> EntityMapMarkInfo
		{
			get
			{
				return this.entityMapMarkInfo_;
			}
		}

		// Token: 0x17002B30 RID: 11056
		// (get) Token: 0x0600D560 RID: 54624 RVA: 0x001F6766 File Offset: 0x001F4966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SystemMarkHideInfoPb> SystemMarkHideInfo
		{
			get
			{
				return this.systemMarkHideInfo_;
			}
		}

		// Token: 0x17002B31 RID: 11057
		// (get) Token: 0x0600D561 RID: 54625 RVA: 0x001F676E File Offset: 0x001F496E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CompleteMarkIds
		{
			get
			{
				return this.completeMarkIds_;
			}
		}

		// Token: 0x0600D562 RID: 54626 RVA: 0x001F6776 File Offset: 0x001F4976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapMarkInfoNotify);
		}

		// Token: 0x0600D563 RID: 54627 RVA: 0x001F6784 File Offset: 0x001F4984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapMarkInfoNotify other)
		{
			return other != null && (other == this || (this.infoList_.Equals(other.infoList_) && this.showMarkIds_.Equals(other.showMarkIds_) && this.unlockMarkIds_.Equals(other.unlockMarkIds_) && this.entityMapMarkInfo_.Equals(other.entityMapMarkInfo_) && this.systemMarkHideInfo_.Equals(other.systemMarkHideInfo_) && this.completeMarkIds_.Equals(other.completeMarkIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D564 RID: 54628 RVA: 0x001F682C File Offset: 0x001F4A2C
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

		// Token: 0x0600D565 RID: 54629 RVA: 0x001F68A6 File Offset: 0x001F4AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D566 RID: 54630 RVA: 0x001F68B3 File Offset: 0x001F4AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D567 RID: 54631 RVA: 0x001F68BC File Offset: 0x001F4ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.systemMarkHideInfo_.WriteTo(ref output, MapMarkInfoNotify._repeated_systemMarkHideInfo_codec);
			this.completeMarkIds_.WriteTo(ref output, MapMarkInfoNotify._repeated_completeMarkIds_codec);
			this.infoList_.WriteTo(ref output, MapMarkInfoNotify._repeated_infoList_codec);
			this.showMarkIds_.WriteTo(ref output, MapMarkInfoNotify._repeated_showMarkIds_codec);
			this.unlockMarkIds_.WriteTo(ref output, MapMarkInfoNotify._repeated_unlockMarkIds_codec);
			this.entityMapMarkInfo_.WriteTo(ref output, MapMarkInfoNotify._repeated_entityMapMarkInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D568 RID: 54632 RVA: 0x001F6944 File Offset: 0x001F4B44
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

		// Token: 0x0600D569 RID: 54633 RVA: 0x001F69DC File Offset: 0x001F4BDC
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

		// Token: 0x0600D56A RID: 54634 RVA: 0x001F6A6A File Offset: 0x001F4C6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D56B RID: 54635 RVA: 0x001F6A74 File Offset: 0x001F4C74
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
				if (num <= 42U)
				{
					if (num <= 32U)
					{
						if (num == 18U)
						{
							this.systemMarkHideInfo_.AddEntriesFrom(ref input, MapMarkInfoNotify._repeated_systemMarkHideInfo_codec);
							continue;
						}
						if (num != 32U)
						{
							goto IL_49;
						}
					}
					else if (num != 34U)
					{
						if (num != 42U)
						{
							goto IL_49;
						}
						this.infoList_.AddEntriesFrom(ref input, MapMarkInfoNotify._repeated_infoList_codec);
						continue;
					}
					this.completeMarkIds_.AddEntriesFrom(ref input, MapMarkInfoNotify._repeated_completeMarkIds_codec);
					continue;
				}
				if (num <= 72U)
				{
					if (num == 50U)
					{
						this.showMarkIds_.AddEntriesFrom(ref input, MapMarkInfoNotify._repeated_showMarkIds_codec);
						continue;
					}
					if (num != 72U)
					{
						goto IL_49;
					}
				}
				else if (num != 74U)
				{
					if (num != 114U)
					{
						goto IL_49;
					}
					this.entityMapMarkInfo_.AddEntriesFrom(ref input, MapMarkInfoNotify._repeated_entityMapMarkInfo_codec);
					continue;
				}
				this.unlockMarkIds_.AddEntriesFrom(ref input, MapMarkInfoNotify._repeated_unlockMarkIds_codec);
				continue;
				IL_49:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040059A5 RID: 22949
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059A6 RID: 22950
		public const int InfoListFieldNumber = 5;

		// Token: 0x040059A7 RID: 22951
		private static readonly FieldCodec<MarkPointInfo> _repeated_infoList_codec = FieldCodec.ForMessage<MarkPointInfo>(42U, MarkPointInfo.Parser);

		// Token: 0x040059A8 RID: 22952
		private readonly RepeatedField<MarkPointInfo> infoList_ = new RepeatedField<MarkPointInfo>();

		// Token: 0x040059A9 RID: 22953
		public const int ShowMarkIdsFieldNumber = 6;

		// Token: 0x040059AA RID: 22954
		private static readonly FieldCodec<MapMarkShowInfo> _repeated_showMarkIds_codec = FieldCodec.ForMessage<MapMarkShowInfo>(50U, MapMarkShowInfo.Parser);

		// Token: 0x040059AB RID: 22955
		private readonly RepeatedField<MapMarkShowInfo> showMarkIds_ = new RepeatedField<MapMarkShowInfo>();

		// Token: 0x040059AC RID: 22956
		public const int UnlockMarkIdsFieldNumber = 9;

		// Token: 0x040059AD RID: 22957
		private static readonly FieldCodec<int> _repeated_unlockMarkIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x040059AE RID: 22958
		private readonly RepeatedField<int> unlockMarkIds_ = new RepeatedField<int>();

		// Token: 0x040059AF RID: 22959
		public const int EntityMapMarkInfoFieldNumber = 14;

		// Token: 0x040059B0 RID: 22960
		private static readonly FieldCodec<EntityMapMarkInfoPb> _repeated_entityMapMarkInfo_codec = FieldCodec.ForMessage<EntityMapMarkInfoPb>(114U, EntityMapMarkInfoPb.Parser);

		// Token: 0x040059B1 RID: 22961
		private readonly RepeatedField<EntityMapMarkInfoPb> entityMapMarkInfo_ = new RepeatedField<EntityMapMarkInfoPb>();

		// Token: 0x040059B2 RID: 22962
		public const int SystemMarkHideInfoFieldNumber = 2;

		// Token: 0x040059B3 RID: 22963
		private static readonly FieldCodec<SystemMarkHideInfoPb> _repeated_systemMarkHideInfo_codec = FieldCodec.ForMessage<SystemMarkHideInfoPb>(18U, SystemMarkHideInfoPb.Parser);

		// Token: 0x040059B4 RID: 22964
		private readonly RepeatedField<SystemMarkHideInfoPb> systemMarkHideInfo_ = new RepeatedField<SystemMarkHideInfoPb>();

		// Token: 0x040059B5 RID: 22965
		public const int CompleteMarkIdsFieldNumber = 4;

		// Token: 0x040059B6 RID: 22966
		private static readonly FieldCodec<int> _repeated_completeMarkIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040059B7 RID: 22967
		private readonly RepeatedField<int> completeMarkIds_ = new RepeatedField<int>();
	}
}
