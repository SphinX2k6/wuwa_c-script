using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D27 RID: 3367
	public sealed class PhotoFightActivityPb : IMessage<PhotoFightActivityPb>, IMessage, IEquatable<PhotoFightActivityPb>, IDeepCloneable<PhotoFightActivityPb>, IBufferMessage
	{
		// Token: 0x060122E4 RID: 74468 RVA: 0x002A7B66 File Offset: 0x002A5D66
		[NullableContext(1)]
		public static PhotoFightActivityPb Create()
		{
			return new PhotoFightActivityPb();
		}

		// Token: 0x17003C3C RID: 15420
		// (get) Token: 0x060122E5 RID: 74469 RVA: 0x002A7B6D File Offset: 0x002A5D6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C3D RID: 15421
		// (get) Token: 0x060122E6 RID: 74470 RVA: 0x002A7B70 File Offset: 0x002A5D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoFightActivityPb.Descriptor;
			}
		}

		// Token: 0x060122E7 RID: 74471 RVA: 0x002A7B77 File Offset: 0x002A5D77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightActivityPb()
		{
		}

		// Token: 0x060122E8 RID: 74472 RVA: 0x002A7B98 File Offset: 0x002A5D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightActivityPb(PhotoFightActivityPb other) : this()
		{
			this.activityId_ = other.activityId_;
			this.photoFightLevelGroupInfo_ = other.photoFightLevelGroupInfo_.Clone();
			this.targets_ = other.targets_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060122E9 RID: 74473 RVA: 0x002A7BEA File Offset: 0x002A5DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightActivityPb Clone()
		{
			return new PhotoFightActivityPb(this);
		}

		// Token: 0x17003C3E RID: 15422
		// (get) Token: 0x060122EA RID: 74474 RVA: 0x002A7BF2 File Offset: 0x002A5DF2
		// (set) Token: 0x060122EB RID: 74475 RVA: 0x002A7BFA File Offset: 0x002A5DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17003C3F RID: 15423
		// (get) Token: 0x060122EC RID: 74476 RVA: 0x002A7C03 File Offset: 0x002A5E03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhotoFightLevelGroupPb> PhotoFightLevelGroupInfo
		{
			get
			{
				return this.photoFightLevelGroupInfo_;
			}
		}

		// Token: 0x17003C40 RID: 15424
		// (get) Token: 0x060122ED RID: 74477 RVA: 0x002A7C0B File Offset: 0x002A5E0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhotoFightTargetPb> Targets
		{
			get
			{
				return this.targets_;
			}
		}

		// Token: 0x060122EE RID: 74478 RVA: 0x002A7C13 File Offset: 0x002A5E13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoFightActivityPb);
		}

		// Token: 0x060122EF RID: 74479 RVA: 0x002A7C24 File Offset: 0x002A5E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoFightActivityPb other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.photoFightLevelGroupInfo_.Equals(other.photoFightLevelGroupInfo_) && this.targets_.Equals(other.targets_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060122F0 RID: 74480 RVA: 0x002A7C88 File Offset: 0x002A5E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.photoFightLevelGroupInfo_.GetHashCode();
			num ^= this.targets_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060122F1 RID: 74481 RVA: 0x002A7CE3 File Offset: 0x002A5EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060122F2 RID: 74482 RVA: 0x002A7CF0 File Offset: 0x002A5EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060122F3 RID: 74483 RVA: 0x002A7CFC File Offset: 0x002A5EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			this.photoFightLevelGroupInfo_.WriteTo(ref output, PhotoFightActivityPb._repeated_photoFightLevelGroupInfo_codec);
			this.targets_.WriteTo(ref output, PhotoFightActivityPb._repeated_targets_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060122F4 RID: 74484 RVA: 0x002A7D5C File Offset: 0x002A5F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.photoFightLevelGroupInfo_.CalculateSize(PhotoFightActivityPb._repeated_photoFightLevelGroupInfo_codec);
			num += this.targets_.CalculateSize(PhotoFightActivityPb._repeated_targets_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060122F5 RID: 74485 RVA: 0x002A7DC0 File Offset: 0x002A5FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotoFightActivityPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.photoFightLevelGroupInfo_.Add(other.photoFightLevelGroupInfo_);
			this.targets_.Add(other.targets_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060122F6 RID: 74486 RVA: 0x002A7E1E File Offset: 0x002A601E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060122F7 RID: 74487 RVA: 0x002A7E28 File Offset: 0x002A6028
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						if (num != 34U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.targets_.AddEntriesFrom(ref input, PhotoFightActivityPb._repeated_targets_codec);
						}
					}
					else
					{
						this.photoFightLevelGroupInfo_.AddEntriesFrom(ref input, PhotoFightActivityPb._repeated_photoFightLevelGroupInfo_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400718A RID: 29066
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400718B RID: 29067
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x0400718C RID: 29068
		private int activityId_;

		// Token: 0x0400718D RID: 29069
		public const int PhotoFightLevelGroupInfoFieldNumber = 2;

		// Token: 0x0400718E RID: 29070
		private static readonly FieldCodec<PhotoFightLevelGroupPb> _repeated_photoFightLevelGroupInfo_codec = FieldCodec.ForMessage<PhotoFightLevelGroupPb>(18U, PhotoFightLevelGroupPb.Parser);

		// Token: 0x0400718F RID: 29071
		private readonly RepeatedField<PhotoFightLevelGroupPb> photoFightLevelGroupInfo_ = new RepeatedField<PhotoFightLevelGroupPb>();

		// Token: 0x04007190 RID: 29072
		public const int TargetsFieldNumber = 4;

		// Token: 0x04007191 RID: 29073
		private static readonly FieldCodec<PhotoFightTargetPb> _repeated_targets_codec = FieldCodec.ForMessage<PhotoFightTargetPb>(34U, PhotoFightTargetPb.Parser);

		// Token: 0x04007192 RID: 29074
		private readonly RepeatedField<PhotoFightTargetPb> targets_ = new RepeatedField<PhotoFightTargetPb>();
	}
}
