using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A42 RID: 2626
	[NetMessage(EMessageId.MotorFightRankListSelfDataRequest)]
	public sealed class MotorFightRankListSelfDataRequest : IMessage<MotorFightRankListSelfDataRequest>, IMessage, IEquatable<MotorFightRankListSelfDataRequest>, IDeepCloneable<MotorFightRankListSelfDataRequest>, IBufferMessage
	{
		// Token: 0x0600E57F RID: 58751 RVA: 0x00218E56 File Offset: 0x00217056
		[NullableContext(1)]
		public static MotorFightRankListSelfDataRequest Create()
		{
			return new MotorFightRankListSelfDataRequest();
		}

		// Token: 0x17002E83 RID: 11907
		// (get) Token: 0x0600E580 RID: 58752 RVA: 0x00218E5D File Offset: 0x0021705D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E84 RID: 11908
		// (get) Token: 0x0600E581 RID: 58753 RVA: 0x00218E60 File Offset: 0x00217060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRankListSelfDataRequest.Descriptor;
			}
		}

		// Token: 0x0600E582 RID: 58754 RVA: 0x00218E67 File Offset: 0x00217067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRankListSelfDataRequest()
		{
		}

		// Token: 0x0600E583 RID: 58755 RVA: 0x00218E6F File Offset: 0x0021706F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRankListSelfDataRequest(MotorFightRankListSelfDataRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E584 RID: 58756 RVA: 0x00218E94 File Offset: 0x00217094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRankListSelfDataRequest Clone()
		{
			return new MotorFightRankListSelfDataRequest(this);
		}

		// Token: 0x17002E85 RID: 11909
		// (get) Token: 0x0600E585 RID: 58757 RVA: 0x00218E9C File Offset: 0x0021709C
		// (set) Token: 0x0600E586 RID: 58758 RVA: 0x00218EA4 File Offset: 0x002170A4
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

		// Token: 0x0600E587 RID: 58759 RVA: 0x00218EAD File Offset: 0x002170AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRankListSelfDataRequest);
		}

		// Token: 0x0600E588 RID: 58760 RVA: 0x00218EBB File Offset: 0x002170BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRankListSelfDataRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E589 RID: 58761 RVA: 0x00218EEC File Offset: 0x002170EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E58A RID: 58762 RVA: 0x00218F2B File Offset: 0x0021712B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E58B RID: 58763 RVA: 0x00218F38 File Offset: 0x00217138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E58C RID: 58764 RVA: 0x00218F41 File Offset: 0x00217141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E58D RID: 58765 RVA: 0x00218F74 File Offset: 0x00217174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E58E RID: 58766 RVA: 0x00218FB2 File Offset: 0x002171B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightRankListSelfDataRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E58F RID: 58767 RVA: 0x00218FE3 File Offset: 0x002171E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E590 RID: 58768 RVA: 0x00218FEC File Offset: 0x002171EC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005E15 RID: 24085
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E16 RID: 24086
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x04005E17 RID: 24087
		private int activityId_;
	}
}
