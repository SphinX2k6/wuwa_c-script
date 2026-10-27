using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D2C RID: 3372
	[NetMessage(EMessageId.PhotoFightResultNotify)]
	public sealed class PhotoFightResultNotify : IMessage<PhotoFightResultNotify>, IMessage, IEquatable<PhotoFightResultNotify>, IDeepCloneable<PhotoFightResultNotify>, IBufferMessage
	{
		// Token: 0x06012353 RID: 74579 RVA: 0x002A8C13 File Offset: 0x002A6E13
		[NullableContext(1)]
		public static PhotoFightResultNotify Create()
		{
			return new PhotoFightResultNotify();
		}

		// Token: 0x17003C57 RID: 15447
		// (get) Token: 0x06012354 RID: 74580 RVA: 0x002A8C1A File Offset: 0x002A6E1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C58 RID: 15448
		// (get) Token: 0x06012355 RID: 74581 RVA: 0x002A8C1D File Offset: 0x002A6E1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoFightResultNotify.Descriptor;
			}
		}

		// Token: 0x06012356 RID: 74582 RVA: 0x002A8C24 File Offset: 0x002A6E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightResultNotify()
		{
		}

		// Token: 0x06012357 RID: 74583 RVA: 0x002A8C38 File Offset: 0x002A6E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightResultNotify(PhotoFightResultNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.activityId_ = other.activityId_;
			this.groupId_ = other.groupId_;
			this.levelId_ = other.levelId_;
			this.succ_ = other.succ_;
			this.targets_ = other.targets_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012358 RID: 74584 RVA: 0x002A8CA9 File Offset: 0x002A6EA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightResultNotify Clone()
		{
			return new PhotoFightResultNotify(this);
		}

		// Token: 0x17003C59 RID: 15449
		// (get) Token: 0x06012359 RID: 74585 RVA: 0x002A8CB1 File Offset: 0x002A6EB1
		// (set) Token: 0x0601235A RID: 74586 RVA: 0x002A8CB9 File Offset: 0x002A6EB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17003C5A RID: 15450
		// (get) Token: 0x0601235B RID: 74587 RVA: 0x002A8CC2 File Offset: 0x002A6EC2
		// (set) Token: 0x0601235C RID: 74588 RVA: 0x002A8CCA File Offset: 0x002A6ECA
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

		// Token: 0x17003C5B RID: 15451
		// (get) Token: 0x0601235D RID: 74589 RVA: 0x002A8CD3 File Offset: 0x002A6ED3
		// (set) Token: 0x0601235E RID: 74590 RVA: 0x002A8CDB File Offset: 0x002A6EDB
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

		// Token: 0x17003C5C RID: 15452
		// (get) Token: 0x0601235F RID: 74591 RVA: 0x002A8CE4 File Offset: 0x002A6EE4
		// (set) Token: 0x06012360 RID: 74592 RVA: 0x002A8CEC File Offset: 0x002A6EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x17003C5D RID: 15453
		// (get) Token: 0x06012361 RID: 74593 RVA: 0x002A8CF5 File Offset: 0x002A6EF5
		// (set) Token: 0x06012362 RID: 74594 RVA: 0x002A8CFD File Offset: 0x002A6EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Succ
		{
			get
			{
				return this.succ_;
			}
			set
			{
				this.succ_ = value;
			}
		}

		// Token: 0x17003C5E RID: 15454
		// (get) Token: 0x06012363 RID: 74595 RVA: 0x002A8D06 File Offset: 0x002A6F06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhotoFightTargetPb> Targets
		{
			get
			{
				return this.targets_;
			}
		}

		// Token: 0x06012364 RID: 74596 RVA: 0x002A8D0E File Offset: 0x002A6F0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoFightResultNotify);
		}

		// Token: 0x06012365 RID: 74597 RVA: 0x002A8D1C File Offset: 0x002A6F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoFightResultNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ActivityId == other.ActivityId && this.GroupId == other.GroupId && this.LevelId == other.LevelId && this.Succ == other.Succ && this.targets_.Equals(other.targets_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012366 RID: 74598 RVA: 0x002A8DAC File Offset: 0x002A6FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.Succ)
			{
				num ^= this.Succ.GetHashCode();
			}
			num ^= this.targets_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012367 RID: 74599 RVA: 0x002A8E63 File Offset: 0x002A7063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012368 RID: 74600 RVA: 0x002A8E70 File Offset: 0x002A7070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012369 RID: 74601 RVA: 0x002A8E7C File Offset: 0x002A707C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			if (this.LevelId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.LevelId);
			}
			if (this.Succ)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.Succ);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.GroupId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.GroupId);
			}
			this.targets_.WriteTo(ref output, PhotoFightResultNotify._repeated_targets_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601236A RID: 74602 RVA: 0x002A8F3C File Offset: 0x002A713C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.Succ)
			{
				num += 2;
			}
			num += this.targets_.CalculateSize(PhotoFightResultNotify._repeated_targets_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601236B RID: 74603 RVA: 0x002A8FE4 File Offset: 0x002A71E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotoFightResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.Succ)
			{
				this.Succ = other.Succ;
			}
			this.targets_.Add(other.targets_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601236C RID: 74604 RVA: 0x002A9081 File Offset: 0x002A7281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601236D RID: 74605 RVA: 0x002A908C File Offset: 0x002A728C
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
				if (num <= 72U)
				{
					if (num == 56U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.LevelId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.Succ = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 88U)
					{
						this.GroupId = input.ReadInt32();
						continue;
					}
					if (num == 114U)
					{
						this.targets_.AddEntriesFrom(ref input, PhotoFightResultNotify._repeated_targets_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040071B4 RID: 29108
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071B5 RID: 29109
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040071B6 RID: 29110
		private ErrorCode errorCode_;

		// Token: 0x040071B7 RID: 29111
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x040071B8 RID: 29112
		private int activityId_;

		// Token: 0x040071B9 RID: 29113
		public const int GroupIdFieldNumber = 11;

		// Token: 0x040071BA RID: 29114
		private int groupId_;

		// Token: 0x040071BB RID: 29115
		public const int LevelIdFieldNumber = 8;

		// Token: 0x040071BC RID: 29116
		private int levelId_;

		// Token: 0x040071BD RID: 29117
		public const int SuccFieldNumber = 9;

		// Token: 0x040071BE RID: 29118
		private bool succ_;

		// Token: 0x040071BF RID: 29119
		public const int TargetsFieldNumber = 14;

		// Token: 0x040071C0 RID: 29120
		private static readonly FieldCodec<PhotoFightTargetPb> _repeated_targets_codec = FieldCodec.ForMessage<PhotoFightTargetPb>(114U, PhotoFightTargetPb.Parser);

		// Token: 0x040071C1 RID: 29121
		private readonly RepeatedField<PhotoFightTargetPb> targets_ = new RepeatedField<PhotoFightTargetPb>();
	}
}
