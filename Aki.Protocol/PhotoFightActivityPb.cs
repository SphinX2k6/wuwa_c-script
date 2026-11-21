using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D17 RID: 3351
	public sealed class PhotoFightActivityPb : IMessage<PhotoFightActivityPb>, IMessage, IEquatable<PhotoFightActivityPb>, IDeepCloneable<PhotoFightActivityPb>, IBufferMessage
	{
		// Token: 0x060121E8 RID: 74216 RVA: 0x002A5F42 File Offset: 0x002A4142
		[NullableContext(1)]
		public static PhotoFightActivityPb Create()
		{
			return new PhotoFightActivityPb();
		}

		// Token: 0x17003C07 RID: 15367
		// (get) Token: 0x060121E9 RID: 74217 RVA: 0x002A5F49 File Offset: 0x002A4149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C08 RID: 15368
		// (get) Token: 0x060121EA RID: 74218 RVA: 0x002A5F4C File Offset: 0x002A414C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoFightActivityPb.Descriptor;
			}
		}

		// Token: 0x060121EB RID: 74219 RVA: 0x002A5F53 File Offset: 0x002A4153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightActivityPb()
		{
		}

		// Token: 0x060121EC RID: 74220 RVA: 0x002A5F74 File Offset: 0x002A4174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightActivityPb(PhotoFightActivityPb other) : this()
		{
			this.activityId_ = other.activityId_;
			this.photoFightLevelGroupInfo_ = other.photoFightLevelGroupInfo_.Clone();
			this.targets_ = other.targets_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060121ED RID: 74221 RVA: 0x002A5FC6 File Offset: 0x002A41C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightActivityPb Clone()
		{
			return new PhotoFightActivityPb(this);
		}

		// Token: 0x17003C09 RID: 15369
		// (get) Token: 0x060121EE RID: 74222 RVA: 0x002A5FCE File Offset: 0x002A41CE
		// (set) Token: 0x060121EF RID: 74223 RVA: 0x002A5FD6 File Offset: 0x002A41D6
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

		// Token: 0x17003C0A RID: 15370
		// (get) Token: 0x060121F0 RID: 74224 RVA: 0x002A5FDF File Offset: 0x002A41DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhotoFightLevelGroupPb> PhotoFightLevelGroupInfo
		{
			get
			{
				return this.photoFightLevelGroupInfo_;
			}
		}

		// Token: 0x17003C0B RID: 15371
		// (get) Token: 0x060121F1 RID: 74225 RVA: 0x002A5FE7 File Offset: 0x002A41E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhotoFightTargetPb> Targets
		{
			get
			{
				return this.targets_;
			}
		}

		// Token: 0x060121F2 RID: 74226 RVA: 0x002A5FEF File Offset: 0x002A41EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoFightActivityPb);
		}

		// Token: 0x060121F3 RID: 74227 RVA: 0x002A6000 File Offset: 0x002A4200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoFightActivityPb other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.photoFightLevelGroupInfo_.Equals(other.photoFightLevelGroupInfo_) && this.targets_.Equals(other.targets_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060121F4 RID: 74228 RVA: 0x002A6064 File Offset: 0x002A4264
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

		// Token: 0x060121F5 RID: 74229 RVA: 0x002A60BF File Offset: 0x002A42BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060121F6 RID: 74230 RVA: 0x002A60CC File Offset: 0x002A42CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060121F7 RID: 74231 RVA: 0x002A60D8 File Offset: 0x002A42D8
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

		// Token: 0x060121F8 RID: 74232 RVA: 0x002A6138 File Offset: 0x002A4338
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

		// Token: 0x060121F9 RID: 74233 RVA: 0x002A619C File Offset: 0x002A439C
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

		// Token: 0x060121FA RID: 74234 RVA: 0x002A61FA File Offset: 0x002A43FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060121FB RID: 74235 RVA: 0x002A6204 File Offset: 0x002A4404
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

		// Token: 0x040071A2 RID: 29090
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071A3 RID: 29091
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x040071A4 RID: 29092
		private int activityId_;

		// Token: 0x040071A5 RID: 29093
		public const int PhotoFightLevelGroupInfoFieldNumber = 2;

		// Token: 0x040071A6 RID: 29094
		private static readonly FieldCodec<PhotoFightLevelGroupPb> _repeated_photoFightLevelGroupInfo_codec = FieldCodec.ForMessage<PhotoFightLevelGroupPb>(18U, PhotoFightLevelGroupPb.Parser);

		// Token: 0x040071A7 RID: 29095
		private readonly RepeatedField<PhotoFightLevelGroupPb> photoFightLevelGroupInfo_ = new RepeatedField<PhotoFightLevelGroupPb>();

		// Token: 0x040071A8 RID: 29096
		public const int TargetsFieldNumber = 4;

		// Token: 0x040071A9 RID: 29097
		private static readonly FieldCodec<PhotoFightTargetPb> _repeated_targets_codec = FieldCodec.ForMessage<PhotoFightTargetPb>(34U, PhotoFightTargetPb.Parser);

		// Token: 0x040071AA RID: 29098
		private readonly RepeatedField<PhotoFightTargetPb> targets_ = new RepeatedField<PhotoFightTargetPb>();
	}
}
