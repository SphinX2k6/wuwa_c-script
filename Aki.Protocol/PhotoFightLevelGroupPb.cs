using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D29 RID: 3369
	public sealed class PhotoFightLevelGroupPb : IMessage<PhotoFightLevelGroupPb>, IMessage, IEquatable<PhotoFightLevelGroupPb>, IDeepCloneable<PhotoFightLevelGroupPb>, IBufferMessage
	{
		// Token: 0x0601230D RID: 74509 RVA: 0x002A8153 File Offset: 0x002A6353
		[NullableContext(1)]
		public static PhotoFightLevelGroupPb Create()
		{
			return new PhotoFightLevelGroupPb();
		}

		// Token: 0x17003C45 RID: 15429
		// (get) Token: 0x0601230E RID: 74510 RVA: 0x002A815A File Offset: 0x002A635A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhotoFightLevelGroupPb> Parser
		{
			get
			{
				return PhotoFightLevelGroupPb._parser;
			}
		}

		// Token: 0x17003C46 RID: 15430
		// (get) Token: 0x0601230F RID: 74511 RVA: 0x002A8161 File Offset: 0x002A6361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C47 RID: 15431
		// (get) Token: 0x06012310 RID: 74512 RVA: 0x002A8164 File Offset: 0x002A6364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoFightLevelGroupPb.Descriptor;
			}
		}

		// Token: 0x06012311 RID: 74513 RVA: 0x002A816B File Offset: 0x002A636B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightLevelGroupPb()
		{
		}

		// Token: 0x06012312 RID: 74514 RVA: 0x002A8180 File Offset: 0x002A6380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightLevelGroupPb(PhotoFightLevelGroupPb other) : this()
		{
			this.groupId_ = other.groupId_;
			this.openTime_ = other.openTime_;
			this.endTime_ = other.endTime_;
			this.photoFightLevelInfo_ = other.photoFightLevelInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012313 RID: 74515 RVA: 0x002A81D9 File Offset: 0x002A63D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightLevelGroupPb Clone()
		{
			return new PhotoFightLevelGroupPb(this);
		}

		// Token: 0x17003C48 RID: 15432
		// (get) Token: 0x06012314 RID: 74516 RVA: 0x002A81E1 File Offset: 0x002A63E1
		// (set) Token: 0x06012315 RID: 74517 RVA: 0x002A81E9 File Offset: 0x002A63E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x17003C49 RID: 15433
		// (get) Token: 0x06012316 RID: 74518 RVA: 0x002A81F2 File Offset: 0x002A63F2
		// (set) Token: 0x06012317 RID: 74519 RVA: 0x002A81FA File Offset: 0x002A63FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long OpenTime
		{
			get
			{
				return this.openTime_;
			}
			set
			{
				this.openTime_ = value;
			}
		}

		// Token: 0x17003C4A RID: 15434
		// (get) Token: 0x06012318 RID: 74520 RVA: 0x002A8203 File Offset: 0x002A6403
		// (set) Token: 0x06012319 RID: 74521 RVA: 0x002A820B File Offset: 0x002A640B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x17003C4B RID: 15435
		// (get) Token: 0x0601231A RID: 74522 RVA: 0x002A8214 File Offset: 0x002A6414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhotoFightLevelPb> PhotoFightLevelInfo
		{
			get
			{
				return this.photoFightLevelInfo_;
			}
		}

		// Token: 0x0601231B RID: 74523 RVA: 0x002A821C File Offset: 0x002A641C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoFightLevelGroupPb);
		}

		// Token: 0x0601231C RID: 74524 RVA: 0x002A822C File Offset: 0x002A642C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoFightLevelGroupPb other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.OpenTime == other.OpenTime && this.EndTime == other.EndTime && this.photoFightLevelInfo_.Equals(other.photoFightLevelInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601231D RID: 74525 RVA: 0x002A829C File Offset: 0x002A649C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.OpenTime != 0L)
			{
				num ^= this.OpenTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			num ^= this.photoFightLevelInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601231E RID: 74526 RVA: 0x002A831B File Offset: 0x002A651B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601231F RID: 74527 RVA: 0x002A8328 File Offset: 0x002A6528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012320 RID: 74528 RVA: 0x002A8334 File Offset: 0x002A6534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GroupId);
			}
			if (this.OpenTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.OpenTime);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EndTime);
			}
			this.photoFightLevelInfo_.WriteTo(ref output, PhotoFightLevelGroupPb._repeated_photoFightLevelInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012321 RID: 74529 RVA: 0x002A83BC File Offset: 0x002A65BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			if (this.OpenTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.OpenTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			num += this.photoFightLevelInfo_.CalculateSize(PhotoFightLevelGroupPb._repeated_photoFightLevelInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012322 RID: 74530 RVA: 0x002A8440 File Offset: 0x002A6640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotoFightLevelGroupPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			if (other.OpenTime != 0L)
			{
				this.OpenTime = other.OpenTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			this.photoFightLevelInfo_.Add(other.photoFightLevelInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012323 RID: 74531 RVA: 0x002A84B5 File Offset: 0x002A66B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012324 RID: 74532 RVA: 0x002A84C0 File Offset: 0x002A66C0
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
					if (num == 8U)
					{
						this.GroupId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.OpenTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
					if (num == 34U)
					{
						this.photoFightLevelInfo_.AddEntriesFrom(ref input, PhotoFightLevelGroupPb._repeated_photoFightLevelInfo_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007198 RID: 29080
		private static readonly MessageParser<PhotoFightLevelGroupPb> _parser = new MessageParser<PhotoFightLevelGroupPb>(() => new PhotoFightLevelGroupPb());

		// Token: 0x04007199 RID: 29081
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400719A RID: 29082
		public const int GroupIdFieldNumber = 1;

		// Token: 0x0400719B RID: 29083
		private int groupId_;

		// Token: 0x0400719C RID: 29084
		public const int OpenTimeFieldNumber = 2;

		// Token: 0x0400719D RID: 29085
		private long openTime_;

		// Token: 0x0400719E RID: 29086
		public const int EndTimeFieldNumber = 3;

		// Token: 0x0400719F RID: 29087
		private long endTime_;

		// Token: 0x040071A0 RID: 29088
		public const int PhotoFightLevelInfoFieldNumber = 4;

		// Token: 0x040071A1 RID: 29089
		private static readonly FieldCodec<PhotoFightLevelPb> _repeated_photoFightLevelInfo_codec = FieldCodec.ForMessage<PhotoFightLevelPb>(34U, PhotoFightLevelPb.Parser);

		// Token: 0x040071A2 RID: 29090
		private readonly RepeatedField<PhotoFightLevelPb> photoFightLevelInfo_ = new RepeatedField<PhotoFightLevelPb>();
	}
}
