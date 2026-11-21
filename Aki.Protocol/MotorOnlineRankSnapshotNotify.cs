using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A6C RID: 2668
	[NetMessage(EMessageId.MotorOnlineRankSnapshotNotify)]
	public sealed class MotorOnlineRankSnapshotNotify : IMessage<MotorOnlineRankSnapshotNotify>, IMessage, IEquatable<MotorOnlineRankSnapshotNotify>, IDeepCloneable<MotorOnlineRankSnapshotNotify>, IBufferMessage
	{
		// Token: 0x0600E8E6 RID: 59622 RVA: 0x00220670 File Offset: 0x0021E870
		[NullableContext(1)]
		public static MotorOnlineRankSnapshotNotify Create()
		{
			return new MotorOnlineRankSnapshotNotify();
		}

		// Token: 0x17002F3E RID: 12094
		// (get) Token: 0x0600E8E7 RID: 59623 RVA: 0x00220677 File Offset: 0x0021E877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F3F RID: 12095
		// (get) Token: 0x0600E8E8 RID: 59624 RVA: 0x0022067A File Offset: 0x0021E87A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOnlineRankSnapshotNotify.Descriptor;
			}
		}

		// Token: 0x0600E8E9 RID: 59625 RVA: 0x00220681 File Offset: 0x0021E881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineRankSnapshotNotify()
		{
		}

		// Token: 0x0600E8EA RID: 59626 RVA: 0x00220694 File Offset: 0x0021E894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineRankSnapshotNotify(MotorOnlineRankSnapshotNotify other) : this()
		{
			this.instId_ = other.instId_;
			this.snapShotVersion_ = other.snapShotVersion_;
			this.motorOnlinePlayerInfoList_ = other.motorOnlinePlayerInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E8EB RID: 59627 RVA: 0x002206E1 File Offset: 0x0021E8E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineRankSnapshotNotify Clone()
		{
			return new MotorOnlineRankSnapshotNotify(this);
		}

		// Token: 0x17002F40 RID: 12096
		// (get) Token: 0x0600E8EC RID: 59628 RVA: 0x002206E9 File Offset: 0x0021E8E9
		// (set) Token: 0x0600E8ED RID: 59629 RVA: 0x002206F1 File Offset: 0x0021E8F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17002F41 RID: 12097
		// (get) Token: 0x0600E8EE RID: 59630 RVA: 0x002206FA File Offset: 0x0021E8FA
		// (set) Token: 0x0600E8EF RID: 59631 RVA: 0x00220702 File Offset: 0x0021E902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SnapShotVersion
		{
			get
			{
				return this.snapShotVersion_;
			}
			set
			{
				this.snapShotVersion_ = value;
			}
		}

		// Token: 0x17002F42 RID: 12098
		// (get) Token: 0x0600E8F0 RID: 59632 RVA: 0x0022070B File Offset: 0x0021E90B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorOnlineRankPlayerInfo> MotorOnlinePlayerInfoList
		{
			get
			{
				return this.motorOnlinePlayerInfoList_;
			}
		}

		// Token: 0x0600E8F1 RID: 59633 RVA: 0x00220713 File Offset: 0x0021E913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOnlineRankSnapshotNotify);
		}

		// Token: 0x0600E8F2 RID: 59634 RVA: 0x00220724 File Offset: 0x0021E924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOnlineRankSnapshotNotify other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.SnapShotVersion == other.SnapShotVersion && this.motorOnlinePlayerInfoList_.Equals(other.motorOnlinePlayerInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E8F3 RID: 59635 RVA: 0x00220784 File Offset: 0x0021E984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.SnapShotVersion != 0)
			{
				num ^= this.SnapShotVersion.GetHashCode();
			}
			num ^= this.motorOnlinePlayerInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E8F4 RID: 59636 RVA: 0x002207EA File Offset: 0x0021E9EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E8F5 RID: 59637 RVA: 0x002207F7 File Offset: 0x0021E9F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E8F6 RID: 59638 RVA: 0x00220800 File Offset: 0x0021EA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SnapShotVersion != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SnapShotVersion);
			}
			this.motorOnlinePlayerInfoList_.WriteTo(ref output, MotorOnlineRankSnapshotNotify._repeated_motorOnlinePlayerInfoList_codec);
			if (this.InstId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E8F7 RID: 59639 RVA: 0x0022086C File Offset: 0x0021EA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.SnapShotVersion != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnapShotVersion);
			}
			num += this.motorOnlinePlayerInfoList_.CalculateSize(MotorOnlineRankSnapshotNotify._repeated_motorOnlinePlayerInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E8F8 RID: 59640 RVA: 0x002208D8 File Offset: 0x0021EAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOnlineRankSnapshotNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.SnapShotVersion != 0)
			{
				this.SnapShotVersion = other.SnapShotVersion;
			}
			this.motorOnlinePlayerInfoList_.Add(other.motorOnlinePlayerInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E8F9 RID: 59641 RVA: 0x00220939 File Offset: 0x0021EB39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E8FA RID: 59642 RVA: 0x00220944 File Offset: 0x0021EB44
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
				if (num != 56U)
				{
					if (num != 66U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.InstId = input.ReadInt32();
						}
					}
					else
					{
						this.motorOnlinePlayerInfoList_.AddEntriesFrom(ref input, MotorOnlineRankSnapshotNotify._repeated_motorOnlinePlayerInfoList_codec);
					}
				}
				else
				{
					this.SnapShotVersion = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005F1B RID: 24347
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F1C RID: 24348
		public const int InstIdFieldNumber = 15;

		// Token: 0x04005F1D RID: 24349
		private int instId_;

		// Token: 0x04005F1E RID: 24350
		public const int SnapShotVersionFieldNumber = 7;

		// Token: 0x04005F1F RID: 24351
		private int snapShotVersion_;

		// Token: 0x04005F20 RID: 24352
		public const int MotorOnlinePlayerInfoListFieldNumber = 8;

		// Token: 0x04005F21 RID: 24353
		private static readonly FieldCodec<MotorOnlineRankPlayerInfo> _repeated_motorOnlinePlayerInfoList_codec = FieldCodec.ForMessage<MotorOnlineRankPlayerInfo>(66U, MotorOnlineRankPlayerInfo.Parser);

		// Token: 0x04005F22 RID: 24354
		private readonly RepeatedField<MotorOnlineRankPlayerInfo> motorOnlinePlayerInfoList_ = new RepeatedField<MotorOnlineRankPlayerInfo>();
	}
}
