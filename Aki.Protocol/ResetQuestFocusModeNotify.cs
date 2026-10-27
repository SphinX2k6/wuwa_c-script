using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F26 RID: 3878
	[NetMessage(EMessageId.ResetQuestFocusModeNotify)]
	public sealed class ResetQuestFocusModeNotify : IMessage<ResetQuestFocusModeNotify>, IMessage, IEquatable<ResetQuestFocusModeNotify>, IDeepCloneable<ResetQuestFocusModeNotify>, IBufferMessage
	{
		// Token: 0x06014C0E RID: 85006 RVA: 0x00302F75 File Offset: 0x00301175
		[NullableContext(1)]
		public static ResetQuestFocusModeNotify Create()
		{
			return new ResetQuestFocusModeNotify();
		}

		// Token: 0x170044FA RID: 17658
		// (get) Token: 0x06014C0F RID: 85007 RVA: 0x00302F7C File Offset: 0x0030117C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044FB RID: 17659
		// (get) Token: 0x06014C10 RID: 85008 RVA: 0x00302F7F File Offset: 0x0030117F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResetQuestFocusModeNotify.Descriptor;
			}
		}

		// Token: 0x06014C11 RID: 85009 RVA: 0x00302F86 File Offset: 0x00301186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetQuestFocusModeNotify()
		{
		}

		// Token: 0x06014C12 RID: 85010 RVA: 0x00302F8E File Offset: 0x0030118E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetQuestFocusModeNotify(ResetQuestFocusModeNotify other) : this()
		{
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014C13 RID: 85011 RVA: 0x00302FB3 File Offset: 0x003011B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetQuestFocusModeNotify Clone()
		{
			return new ResetQuestFocusModeNotify(this);
		}

		// Token: 0x170044FC RID: 17660
		// (get) Token: 0x06014C14 RID: 85012 RVA: 0x00302FBB File Offset: 0x003011BB
		// (set) Token: 0x06014C15 RID: 85013 RVA: 0x00302FC3 File Offset: 0x003011C3
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

		// Token: 0x06014C16 RID: 85014 RVA: 0x00302FCC File Offset: 0x003011CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResetQuestFocusModeNotify);
		}

		// Token: 0x06014C17 RID: 85015 RVA: 0x00302FDA File Offset: 0x003011DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResetQuestFocusModeNotify other)
		{
			return other != null && (other == this || (this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014C18 RID: 85016 RVA: 0x00303008 File Offset: 0x00301208
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

		// Token: 0x06014C19 RID: 85017 RVA: 0x0030304D File Offset: 0x0030124D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014C1A RID: 85018 RVA: 0x0030305A File Offset: 0x0030125A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014C1B RID: 85019 RVA: 0x00303063 File Offset: 0x00301263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != ResetQuestFocusModeReason.EnterSealedArea)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014C1C RID: 85020 RVA: 0x00303098 File Offset: 0x00301298
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

		// Token: 0x06014C1D RID: 85021 RVA: 0x003030D6 File Offset: 0x003012D6
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

		// Token: 0x06014C1E RID: 85022 RVA: 0x00303107 File Offset: 0x00301307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014C1F RID: 85023 RVA: 0x00303110 File Offset: 0x00301310
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Reason = (ResetQuestFocusModeReason)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007D53 RID: 32083
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D54 RID: 32084
		public const int ReasonFieldNumber = 13;

		// Token: 0x04007D55 RID: 32085
		private ResetQuestFocusModeReason reason_;
	}
}
