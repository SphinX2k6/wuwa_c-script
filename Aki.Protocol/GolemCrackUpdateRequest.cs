using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006F0 RID: 1776
	[NetMessage(EMessageId.GolemCrackUpdateRequest)]
	public sealed class GolemCrackUpdateRequest : IMessage<GolemCrackUpdateRequest>, IMessage, IEquatable<GolemCrackUpdateRequest>, IDeepCloneable<GolemCrackUpdateRequest>, IBufferMessage
	{
		// Token: 0x0600A222 RID: 41506 RVA: 0x001883A7 File Offset: 0x001865A7
		[NullableContext(1)]
		public static GolemCrackUpdateRequest Create()
		{
			return new GolemCrackUpdateRequest();
		}

		// Token: 0x17002092 RID: 8338
		// (get) Token: 0x0600A223 RID: 41507 RVA: 0x001883AE File Offset: 0x001865AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002093 RID: 8339
		// (get) Token: 0x0600A224 RID: 41508 RVA: 0x001883B1 File Offset: 0x001865B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GolemCrackUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0600A225 RID: 41509 RVA: 0x001883B8 File Offset: 0x001865B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackUpdateRequest()
		{
		}

		// Token: 0x0600A226 RID: 41510 RVA: 0x001883C0 File Offset: 0x001865C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackUpdateRequest(GolemCrackUpdateRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.golemCrackLevelInfo_ = ((other.golemCrackLevelInfo_ != null) ? other.golemCrackLevelInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A227 RID: 41511 RVA: 0x0018840C File Offset: 0x0018660C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackUpdateRequest Clone()
		{
			return new GolemCrackUpdateRequest(this);
		}

		// Token: 0x17002094 RID: 8340
		// (get) Token: 0x0600A228 RID: 41512 RVA: 0x00188414 File Offset: 0x00186614
		// (set) Token: 0x0600A229 RID: 41513 RVA: 0x0018841C File Offset: 0x0018661C
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

		// Token: 0x17002095 RID: 8341
		// (get) Token: 0x0600A22A RID: 41514 RVA: 0x00188425 File Offset: 0x00186625
		// (set) Token: 0x0600A22B RID: 41515 RVA: 0x0018842D File Offset: 0x0018662D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackLevelInfo GolemCrackLevelInfo
		{
			get
			{
				return this.golemCrackLevelInfo_;
			}
			set
			{
				this.golemCrackLevelInfo_ = value;
			}
		}

		// Token: 0x0600A22C RID: 41516 RVA: 0x00188436 File Offset: 0x00186636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GolemCrackUpdateRequest);
		}

		// Token: 0x0600A22D RID: 41517 RVA: 0x00188444 File Offset: 0x00186644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GolemCrackUpdateRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.GolemCrackLevelInfo, other.GolemCrackLevelInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A22E RID: 41518 RVA: 0x00188494 File Offset: 0x00186694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.golemCrackLevelInfo_ != null)
			{
				num ^= this.GolemCrackLevelInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A22F RID: 41519 RVA: 0x001884E9 File Offset: 0x001866E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A230 RID: 41520 RVA: 0x001884F6 File Offset: 0x001866F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A231 RID: 41521 RVA: 0x00188500 File Offset: 0x00186700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			if (this.golemCrackLevelInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.GolemCrackLevelInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A232 RID: 41522 RVA: 0x0018855C File Offset: 0x0018675C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.golemCrackLevelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GolemCrackLevelInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A233 RID: 41523 RVA: 0x001885B4 File Offset: 0x001867B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GolemCrackUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.golemCrackLevelInfo_ != null)
			{
				if (this.golemCrackLevelInfo_ == null)
				{
					this.GolemCrackLevelInfo = new GolemCrackLevelInfo();
				}
				this.GolemCrackLevelInfo.MergeFrom(other.GolemCrackLevelInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A234 RID: 41524 RVA: 0x0018861C File Offset: 0x0018681C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A235 RID: 41525 RVA: 0x00188628 File Offset: 0x00186828
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
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.golemCrackLevelInfo_ == null)
						{
							this.GolemCrackLevelInfo = new GolemCrackLevelInfo();
						}
						input.ReadMessage(this.GolemCrackLevelInfo);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004B84 RID: 19332
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B85 RID: 19333
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x04004B86 RID: 19334
		private int activityId_;

		// Token: 0x04004B87 RID: 19335
		public const int GolemCrackLevelInfoFieldNumber = 11;

		// Token: 0x04004B88 RID: 19336
		private GolemCrackLevelInfo golemCrackLevelInfo_;
	}
}
