using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000584 RID: 1412
	[NetMessage(EMessageId.FlagChallengePerRoleLevelNotify)]
	public sealed class FlagChallengePerRoleLevelNotify : IMessage<FlagChallengePerRoleLevelNotify>, IMessage, IEquatable<FlagChallengePerRoleLevelNotify>, IDeepCloneable<FlagChallengePerRoleLevelNotify>, IBufferMessage
	{
		// Token: 0x06008349 RID: 33609 RVA: 0x0013C821 File Offset: 0x0013AA21
		[NullableContext(1)]
		public static FlagChallengePerRoleLevelNotify Create()
		{
			return new FlagChallengePerRoleLevelNotify();
		}

		// Token: 0x17001990 RID: 6544
		// (get) Token: 0x0600834A RID: 33610 RVA: 0x0013C828 File Offset: 0x0013AA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x0600834B RID: 33611 RVA: 0x0013C82B File Offset: 0x0013AA2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengePerRoleLevelNotify.Descriptor;
			}
		}

		// Token: 0x0600834C RID: 33612 RVA: 0x0013C832 File Offset: 0x0013AA32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengePerRoleLevelNotify()
		{
		}

		// Token: 0x0600834D RID: 33613 RVA: 0x0013C83C File Offset: 0x0013AA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengePerRoleLevelNotify(FlagChallengePerRoleLevelNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.flagChallengeRoleLevelInfo_ = ((other.flagChallengeRoleLevelInfo_ != null) ? other.flagChallengeRoleLevelInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600834E RID: 33614 RVA: 0x0013C888 File Offset: 0x0013AA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengePerRoleLevelNotify Clone()
		{
			return new FlagChallengePerRoleLevelNotify(this);
		}

		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x0600834F RID: 33615 RVA: 0x0013C890 File Offset: 0x0013AA90
		// (set) Token: 0x06008350 RID: 33616 RVA: 0x0013C898 File Offset: 0x0013AA98
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

		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x06008351 RID: 33617 RVA: 0x0013C8A1 File Offset: 0x0013AAA1
		// (set) Token: 0x06008352 RID: 33618 RVA: 0x0013C8A9 File Offset: 0x0013AAA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRoleLevelInfo FlagChallengeRoleLevelInfo
		{
			get
			{
				return this.flagChallengeRoleLevelInfo_;
			}
			set
			{
				this.flagChallengeRoleLevelInfo_ = value;
			}
		}

		// Token: 0x06008353 RID: 33619 RVA: 0x0013C8B2 File Offset: 0x0013AAB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengePerRoleLevelNotify);
		}

		// Token: 0x06008354 RID: 33620 RVA: 0x0013C8C0 File Offset: 0x0013AAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengePerRoleLevelNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.FlagChallengeRoleLevelInfo, other.FlagChallengeRoleLevelInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008355 RID: 33621 RVA: 0x0013C910 File Offset: 0x0013AB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.flagChallengeRoleLevelInfo_ != null)
			{
				num ^= this.FlagChallengeRoleLevelInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008356 RID: 33622 RVA: 0x0013C965 File Offset: 0x0013AB65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008357 RID: 33623 RVA: 0x0013C972 File Offset: 0x0013AB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008358 RID: 33624 RVA: 0x0013C97C File Offset: 0x0013AB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this.flagChallengeRoleLevelInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.FlagChallengeRoleLevelInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008359 RID: 33625 RVA: 0x0013C9D8 File Offset: 0x0013ABD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.flagChallengeRoleLevelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FlagChallengeRoleLevelInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600835A RID: 33626 RVA: 0x0013CA30 File Offset: 0x0013AC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagChallengePerRoleLevelNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.flagChallengeRoleLevelInfo_ != null)
			{
				if (this.flagChallengeRoleLevelInfo_ == null)
				{
					this.FlagChallengeRoleLevelInfo = new FlagChallengeRoleLevelInfo();
				}
				this.FlagChallengeRoleLevelInfo.MergeFrom(other.FlagChallengeRoleLevelInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600835B RID: 33627 RVA: 0x0013CA98 File Offset: 0x0013AC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600835C RID: 33628 RVA: 0x0013CAA4 File Offset: 0x0013ACA4
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
				if (num != 88U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.flagChallengeRoleLevelInfo_ == null)
						{
							this.FlagChallengeRoleLevelInfo = new FlagChallengeRoleLevelInfo();
						}
						input.ReadMessage(this.FlagChallengeRoleLevelInfo);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040041C3 RID: 16835
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041C4 RID: 16836
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x040041C5 RID: 16837
		private int activityId_;

		// Token: 0x040041C6 RID: 16838
		public const int FlagChallengeRoleLevelInfoFieldNumber = 12;

		// Token: 0x040041C7 RID: 16839
		private FlagChallengeRoleLevelInfo flagChallengeRoleLevelInfo_;
	}
}
