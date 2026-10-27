using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011D8 RID: 4568
	[NetMessage(EMessageId.SetMatchTeamMatchFlagResponse)]
	public sealed class SetMatchTeamMatchFlagResponse : IMessage<SetMatchTeamMatchFlagResponse>, IMessage, IEquatable<SetMatchTeamMatchFlagResponse>, IDeepCloneable<SetMatchTeamMatchFlagResponse>, IBufferMessage
	{
		// Token: 0x060185B6 RID: 99766 RVA: 0x0038AF31 File Offset: 0x00389131
		[NullableContext(1)]
		public static SetMatchTeamMatchFlagResponse Create()
		{
			return new SetMatchTeamMatchFlagResponse();
		}

		// Token: 0x17005202 RID: 20994
		// (get) Token: 0x060185B7 RID: 99767 RVA: 0x0038AF38 File Offset: 0x00389138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005203 RID: 20995
		// (get) Token: 0x060185B8 RID: 99768 RVA: 0x0038AF3B File Offset: 0x0038913B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetMatchTeamMatchFlagResponse.Descriptor;
			}
		}

		// Token: 0x060185B9 RID: 99769 RVA: 0x0038AF42 File Offset: 0x00389142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMatchTeamMatchFlagResponse()
		{
		}

		// Token: 0x060185BA RID: 99770 RVA: 0x0038AF4A File Offset: 0x0038914A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMatchTeamMatchFlagResponse(SetMatchTeamMatchFlagResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060185BB RID: 99771 RVA: 0x0038AF6F File Offset: 0x0038916F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMatchTeamMatchFlagResponse Clone()
		{
			return new SetMatchTeamMatchFlagResponse(this);
		}

		// Token: 0x17005204 RID: 20996
		// (get) Token: 0x060185BC RID: 99772 RVA: 0x0038AF77 File Offset: 0x00389177
		// (set) Token: 0x060185BD RID: 99773 RVA: 0x0038AF7F File Offset: 0x0038917F
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

		// Token: 0x060185BE RID: 99774 RVA: 0x0038AF88 File Offset: 0x00389188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetMatchTeamMatchFlagResponse);
		}

		// Token: 0x060185BF RID: 99775 RVA: 0x0038AF96 File Offset: 0x00389196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetMatchTeamMatchFlagResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060185C0 RID: 99776 RVA: 0x0038AFC4 File Offset: 0x003891C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060185C1 RID: 99777 RVA: 0x0038B009 File Offset: 0x00389209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060185C2 RID: 99778 RVA: 0x0038B016 File Offset: 0x00389216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060185C3 RID: 99779 RVA: 0x0038B01F File Offset: 0x0038921F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060185C4 RID: 99780 RVA: 0x0038B054 File Offset: 0x00389254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060185C5 RID: 99781 RVA: 0x0038B092 File Offset: 0x00389292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetMatchTeamMatchFlagResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060185C6 RID: 99782 RVA: 0x0038B0C3 File Offset: 0x003892C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060185C7 RID: 99783 RVA: 0x0038B0CC File Offset: 0x003892CC
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400901E RID: 36894
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400901F RID: 36895
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04009020 RID: 36896
		private ErrorCode errorCode_;
	}
}
