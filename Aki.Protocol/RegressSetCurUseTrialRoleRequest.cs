using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ED5 RID: 3797
	[NetMessage(EMessageId.RegressSetCurUseTrialRoleRequest)]
	public sealed class RegressSetCurUseTrialRoleRequest : IMessage<RegressSetCurUseTrialRoleRequest>, IMessage, IEquatable<RegressSetCurUseTrialRoleRequest>, IDeepCloneable<RegressSetCurUseTrialRoleRequest>, IBufferMessage
	{
		// Token: 0x06014611 RID: 83473 RVA: 0x002F6C11 File Offset: 0x002F4E11
		[NullableContext(1)]
		public static RegressSetCurUseTrialRoleRequest Create()
		{
			return new RegressSetCurUseTrialRoleRequest();
		}

		// Token: 0x170043CA RID: 17354
		// (get) Token: 0x06014612 RID: 83474 RVA: 0x002F6C18 File Offset: 0x002F4E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043CB RID: 17355
		// (get) Token: 0x06014613 RID: 83475 RVA: 0x002F6C1B File Offset: 0x002F4E1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressSetCurUseTrialRoleRequest.Descriptor;
			}
		}

		// Token: 0x06014614 RID: 83476 RVA: 0x002F6C22 File Offset: 0x002F4E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressSetCurUseTrialRoleRequest()
		{
		}

		// Token: 0x06014615 RID: 83477 RVA: 0x002F6C2A File Offset: 0x002F4E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressSetCurUseTrialRoleRequest(RegressSetCurUseTrialRoleRequest other) : this()
		{
			this.trialRoleId_ = other.trialRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014616 RID: 83478 RVA: 0x002F6C4F File Offset: 0x002F4E4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressSetCurUseTrialRoleRequest Clone()
		{
			return new RegressSetCurUseTrialRoleRequest(this);
		}

		// Token: 0x170043CC RID: 17356
		// (get) Token: 0x06014617 RID: 83479 RVA: 0x002F6C57 File Offset: 0x002F4E57
		// (set) Token: 0x06014618 RID: 83480 RVA: 0x002F6C5F File Offset: 0x002F4E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TrialRoleId
		{
			get
			{
				return this.trialRoleId_;
			}
			set
			{
				this.trialRoleId_ = value;
			}
		}

		// Token: 0x06014619 RID: 83481 RVA: 0x002F6C68 File Offset: 0x002F4E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressSetCurUseTrialRoleRequest);
		}

		// Token: 0x0601461A RID: 83482 RVA: 0x002F6C76 File Offset: 0x002F4E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressSetCurUseTrialRoleRequest other)
		{
			return other != null && (other == this || (this.TrialRoleId == other.TrialRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601461B RID: 83483 RVA: 0x002F6CA4 File Offset: 0x002F4EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TrialRoleId != 0)
			{
				num ^= this.TrialRoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601461C RID: 83484 RVA: 0x002F6CE3 File Offset: 0x002F4EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601461D RID: 83485 RVA: 0x002F6CF0 File Offset: 0x002F4EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601461E RID: 83486 RVA: 0x002F6CF9 File Offset: 0x002F4EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TrialRoleId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.TrialRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601461F RID: 83487 RVA: 0x002F6D2C File Offset: 0x002F4F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TrialRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TrialRoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014620 RID: 83488 RVA: 0x002F6D6A File Offset: 0x002F4F6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressSetCurUseTrialRoleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TrialRoleId != 0)
			{
				this.TrialRoleId = other.TrialRoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014621 RID: 83489 RVA: 0x002F6D9B File Offset: 0x002F4F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014622 RID: 83490 RVA: 0x002F6DA4 File Offset: 0x002F4FA4
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TrialRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007C2C RID: 31788
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C2D RID: 31789
		public const int TrialRoleIdFieldNumber = 14;

		// Token: 0x04007C2E RID: 31790
		private int trialRoleId_;
	}
}
