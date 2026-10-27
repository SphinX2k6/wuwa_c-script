using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A7D RID: 2685
	[NetMessage(EMessageId.MotorOnlineRankSnapshotNotify)]
	public sealed class MotorOnlineRankSnapshotNotify : IMessage<MotorOnlineRankSnapshotNotify>, IMessage, IEquatable<MotorOnlineRankSnapshotNotify>, IDeepCloneable<MotorOnlineRankSnapshotNotify>, IBufferMessage
	{
		// Token: 0x0600EA00 RID: 59904 RVA: 0x00222868 File Offset: 0x00220A68
		[NullableContext(1)]
		public static MotorOnlineRankSnapshotNotify Create()
		{
			return new MotorOnlineRankSnapshotNotify();
		}

		// Token: 0x17002F7C RID: 12156
		// (get) Token: 0x0600EA01 RID: 59905 RVA: 0x0022286F File Offset: 0x00220A6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F7D RID: 12157
		// (get) Token: 0x0600EA02 RID: 59906 RVA: 0x00222872 File Offset: 0x00220A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOnlineRankSnapshotNotify.Descriptor;
			}
		}

		// Token: 0x0600EA03 RID: 59907 RVA: 0x00222879 File Offset: 0x00220A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineRankSnapshotNotify()
		{
		}

		// Token: 0x0600EA04 RID: 59908 RVA: 0x0022288C File Offset: 0x00220A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineRankSnapshotNotify(MotorOnlineRankSnapshotNotify other) : this()
		{
			this.instId_ = other.instId_;
			this.snapShotVersion_ = other.snapShotVersion_;
			this.motorOnlinePlayerInfoList_ = other.motorOnlinePlayerInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EA05 RID: 59909 RVA: 0x002228D9 File Offset: 0x00220AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineRankSnapshotNotify Clone()
		{
			return new MotorOnlineRankSnapshotNotify(this);
		}

		// Token: 0x17002F7E RID: 12158
		// (get) Token: 0x0600EA06 RID: 59910 RVA: 0x002228E1 File Offset: 0x00220AE1
		// (set) Token: 0x0600EA07 RID: 59911 RVA: 0x002228E9 File Offset: 0x00220AE9
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

		// Token: 0x17002F7F RID: 12159
		// (get) Token: 0x0600EA08 RID: 59912 RVA: 0x002228F2 File Offset: 0x00220AF2
		// (set) Token: 0x0600EA09 RID: 59913 RVA: 0x002228FA File Offset: 0x00220AFA
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

		// Token: 0x17002F80 RID: 12160
		// (get) Token: 0x0600EA0A RID: 59914 RVA: 0x00222903 File Offset: 0x00220B03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorOnlineRankPlayerInfo> MotorOnlinePlayerInfoList
		{
			get
			{
				return this.motorOnlinePlayerInfoList_;
			}
		}

		// Token: 0x0600EA0B RID: 59915 RVA: 0x0022290B File Offset: 0x00220B0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOnlineRankSnapshotNotify);
		}

		// Token: 0x0600EA0C RID: 59916 RVA: 0x0022291C File Offset: 0x00220B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOnlineRankSnapshotNotify other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.SnapShotVersion == other.SnapShotVersion && this.motorOnlinePlayerInfoList_.Equals(other.motorOnlinePlayerInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EA0D RID: 59917 RVA: 0x0022297C File Offset: 0x00220B7C
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

		// Token: 0x0600EA0E RID: 59918 RVA: 0x002229E2 File Offset: 0x00220BE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EA0F RID: 59919 RVA: 0x002229EF File Offset: 0x00220BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EA10 RID: 59920 RVA: 0x002229F8 File Offset: 0x00220BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SnapShotVersion != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SnapShotVersion);
			}
			this.motorOnlinePlayerInfoList_.WriteTo(ref output, MotorOnlineRankSnapshotNotify._repeated_motorOnlinePlayerInfoList_codec);
			if (this.InstId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EA11 RID: 59921 RVA: 0x00222A64 File Offset: 0x00220C64
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

		// Token: 0x0600EA12 RID: 59922 RVA: 0x00222AD0 File Offset: 0x00220CD0
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

		// Token: 0x0600EA13 RID: 59923 RVA: 0x00222B31 File Offset: 0x00220D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EA14 RID: 59924 RVA: 0x00222B3C File Offset: 0x00220D3C
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
				if (num != 16U)
				{
					if (num != 74U)
					{
						if (num != 112U)
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

		// Token: 0x04005F12 RID: 24338
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F13 RID: 24339
		public const int InstIdFieldNumber = 14;

		// Token: 0x04005F14 RID: 24340
		private int instId_;

		// Token: 0x04005F15 RID: 24341
		public const int SnapShotVersionFieldNumber = 2;

		// Token: 0x04005F16 RID: 24342
		private int snapShotVersion_;

		// Token: 0x04005F17 RID: 24343
		public const int MotorOnlinePlayerInfoListFieldNumber = 9;

		// Token: 0x04005F18 RID: 24344
		private static readonly FieldCodec<MotorOnlineRankPlayerInfo> _repeated_motorOnlinePlayerInfoList_codec = FieldCodec.ForMessage<MotorOnlineRankPlayerInfo>(74U, MotorOnlineRankPlayerInfo.Parser);

		// Token: 0x04005F19 RID: 24345
		private readonly RepeatedField<MotorOnlineRankPlayerInfo> motorOnlinePlayerInfoList_ = new RepeatedField<MotorOnlineRankPlayerInfo>();
	}
}
