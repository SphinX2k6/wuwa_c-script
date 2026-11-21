using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F16 RID: 3862
	[NetMessage(EMessageId.ResetQuestFocusModeNotify)]
	public sealed class ResetQuestFocusModeNotify : IMessage<ResetQuestFocusModeNotify>, IMessage, IEquatable<ResetQuestFocusModeNotify>, IDeepCloneable<ResetQuestFocusModeNotify>, IBufferMessage
	{
		// Token: 0x06014B29 RID: 84777 RVA: 0x003018B9 File Offset: 0x002FFAB9
		[NullableContext(1)]
		public static ResetQuestFocusModeNotify Create()
		{
			return new ResetQuestFocusModeNotify();
		}

		// Token: 0x170044D0 RID: 17616
		// (get) Token: 0x06014B2A RID: 84778 RVA: 0x003018C0 File Offset: 0x002FFAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044D1 RID: 17617
		// (get) Token: 0x06014B2B RID: 84779 RVA: 0x003018C3 File Offset: 0x002FFAC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResetQuestFocusModeNotify.Descriptor;
			}
		}

		// Token: 0x06014B2C RID: 84780 RVA: 0x003018CA File Offset: 0x002FFACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetQuestFocusModeNotify()
		{
		}

		// Token: 0x06014B2D RID: 84781 RVA: 0x003018D2 File Offset: 0x002FFAD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetQuestFocusModeNotify(ResetQuestFocusModeNotify other) : this()
		{
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014B2E RID: 84782 RVA: 0x003018F7 File Offset: 0x002FFAF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetQuestFocusModeNotify Clone()
		{
			return new ResetQuestFocusModeNotify(this);
		}

		// Token: 0x170044D2 RID: 17618
		// (get) Token: 0x06014B2F RID: 84783 RVA: 0x003018FF File Offset: 0x002FFAFF
		// (set) Token: 0x06014B30 RID: 84784 RVA: 0x00301907 File Offset: 0x002FFB07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetQuestFocusModeReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x06014B31 RID: 84785 RVA: 0x00301910 File Offset: 0x002FFB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResetQuestFocusModeNotify);
		}

		// Token: 0x06014B32 RID: 84786 RVA: 0x0030191E File Offset: 0x002FFB1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResetQuestFocusModeNotify other)
		{
			return other != null && (other == this || (this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014B33 RID: 84787 RVA: 0x0030194C File Offset: 0x002FFB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Reason != ResetQuestFocusModeReason.EnterSealedArea)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014B34 RID: 84788 RVA: 0x00301991 File Offset: 0x002FFB91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014B35 RID: 84789 RVA: 0x0030199E File Offset: 0x002FFB9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014B36 RID: 84790 RVA: 0x003019A7 File Offset: 0x002FFBA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != ResetQuestFocusModeReason.EnterSealedArea)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014B37 RID: 84791 RVA: 0x003019DC File Offset: 0x002FFBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Reason != ResetQuestFocusModeReason.EnterSealedArea)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014B38 RID: 84792 RVA: 0x00301A1A File Offset: 0x002FFC1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ResetQuestFocusModeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Reason != ResetQuestFocusModeReason.EnterSealedArea)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014B39 RID: 84793 RVA: 0x00301A4B File Offset: 0x002FFC4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014B3A RID: 84794 RVA: 0x00301A54 File Offset: 0x002FFC54
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
					this.Reason = (ResetQuestFocusModeReason)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007D7D RID: 32125
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D7E RID: 32126
		public const int ReasonFieldNumber = 11;

		// Token: 0x04007D7F RID: 32127
		private ResetQuestFocusModeReason reason_;
	}
}
