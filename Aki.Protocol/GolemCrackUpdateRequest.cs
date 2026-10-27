using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000704 RID: 1796
	[NetMessage(EMessageId.GolemCrackUpdateRequest)]
	public sealed class GolemCrackUpdateRequest : IMessage<GolemCrackUpdateRequest>, IMessage, IEquatable<GolemCrackUpdateRequest>, IDeepCloneable<GolemCrackUpdateRequest>, IBufferMessage
	{
		// Token: 0x0600A378 RID: 41848 RVA: 0x0018ADDB File Offset: 0x00188FDB
		[NullableContext(1)]
		public static GolemCrackUpdateRequest Create()
		{
			return new GolemCrackUpdateRequest();
		}

		// Token: 0x170020DC RID: 8412
		// (get) Token: 0x0600A379 RID: 41849 RVA: 0x0018ADE2 File Offset: 0x00188FE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020DD RID: 8413
		// (get) Token: 0x0600A37A RID: 41850 RVA: 0x0018ADE5 File Offset: 0x00188FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GolemCrackUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0600A37B RID: 41851 RVA: 0x0018ADEC File Offset: 0x00188FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackUpdateRequest()
		{
		}

		// Token: 0x0600A37C RID: 41852 RVA: 0x0018ADF4 File Offset: 0x00188FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackUpdateRequest(GolemCrackUpdateRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.golemCrackLevelInfo_ = ((other.golemCrackLevelInfo_ != null) ? other.golemCrackLevelInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A37D RID: 41853 RVA: 0x0018AE40 File Offset: 0x00189040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackUpdateRequest Clone()
		{
			return new GolemCrackUpdateRequest(this);
		}

		// Token: 0x170020DE RID: 8414
		// (get) Token: 0x0600A37E RID: 41854 RVA: 0x0018AE48 File Offset: 0x00189048
		// (set) Token: 0x0600A37F RID: 41855 RVA: 0x0018AE50 File Offset: 0x00189050
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

		// Token: 0x170020DF RID: 8415
		// (get) Token: 0x0600A380 RID: 41856 RVA: 0x0018AE59 File Offset: 0x00189059
		// (set) Token: 0x0600A381 RID: 41857 RVA: 0x0018AE61 File Offset: 0x00189061
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

		// Token: 0x0600A382 RID: 41858 RVA: 0x0018AE6A File Offset: 0x0018906A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GolemCrackUpdateRequest);
		}

		// Token: 0x0600A383 RID: 41859 RVA: 0x0018AE78 File Offset: 0x00189078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GolemCrackUpdateRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.GolemCrackLevelInfo, other.GolemCrackLevelInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A384 RID: 41860 RVA: 0x0018AEC8 File Offset: 0x001890C8
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

		// Token: 0x0600A385 RID: 41861 RVA: 0x0018AF1D File Offset: 0x0018911D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A386 RID: 41862 RVA: 0x0018AF2A File Offset: 0x0018912A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A387 RID: 41863 RVA: 0x0018AF34 File Offset: 0x00189134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.golemCrackLevelInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.GolemCrackLevelInfo);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A388 RID: 41864 RVA: 0x0018AF90 File Offset: 0x00189190
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

		// Token: 0x0600A389 RID: 41865 RVA: 0x0018AFE8 File Offset: 0x001891E8
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

		// Token: 0x0600A38A RID: 41866 RVA: 0x0018B050 File Offset: 0x00189250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A38B RID: 41867 RVA: 0x0018B05C File Offset: 0x0018925C
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
				if (num != 58U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
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
		}

		// Token: 0x04004B8B RID: 19339
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B8C RID: 19340
		public const int ActivityIdFieldNumber = 9;

		// Token: 0x04004B8D RID: 19341
		private int activityId_;

		// Token: 0x04004B8E RID: 19342
		public const int GolemCrackLevelInfoFieldNumber = 7;

		// Token: 0x04004B8F RID: 19343
		private GolemCrackLevelInfo golemCrackLevelInfo_;
	}
}
