using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x0200170D RID: 5901
	[NetMessage(EMessageId.CheatInputResponse)]
	public sealed class CheatInputResponse : IMessage<CheatInputResponse>, IMessage, IEquatable<CheatInputResponse>, IDeepCloneable<CheatInputResponse>, IBufferMessage
	{
		// Token: 0x0601D9E4 RID: 121316 RVA: 0x00457C92 File Offset: 0x00455E92
		[NullableContext(1)]
		public static CheatInputResponse Create()
		{
			return new CheatInputResponse();
		}

		// Token: 0x170064CC RID: 25804
		// (get) Token: 0x0601D9E5 RID: 121317 RVA: 0x00457C99 File Offset: 0x00455E99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170064CD RID: 25805
		// (get) Token: 0x0601D9E6 RID: 121318 RVA: 0x00457C9C File Offset: 0x00455E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CheatInputResponse.Descriptor;
			}
		}

		// Token: 0x0601D9E7 RID: 121319 RVA: 0x00457CA3 File Offset: 0x00455EA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheatInputResponse()
		{
		}

		// Token: 0x0601D9E8 RID: 121320 RVA: 0x00457CAB File Offset: 0x00455EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheatInputResponse(CheatInputResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D9E9 RID: 121321 RVA: 0x00457CD0 File Offset: 0x00455ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheatInputResponse Clone()
		{
			return new CheatInputResponse(this);
		}

		// Token: 0x170064CE RID: 25806
		// (get) Token: 0x0601D9EA RID: 121322 RVA: 0x00457CD8 File Offset: 0x00455ED8
		// (set) Token: 0x0601D9EB RID: 121323 RVA: 0x00457CE0 File Offset: 0x00455EE0
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

		// Token: 0x0601D9EC RID: 121324 RVA: 0x00457CE9 File Offset: 0x00455EE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CheatInputResponse);
		}

		// Token: 0x0601D9ED RID: 121325 RVA: 0x00457CF7 File Offset: 0x00455EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CheatInputResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D9EE RID: 121326 RVA: 0x00457D28 File Offset: 0x00455F28
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

		// Token: 0x0601D9EF RID: 121327 RVA: 0x00457D6D File Offset: 0x00455F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D9F0 RID: 121328 RVA: 0x00457D7A File Offset: 0x00455F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D9F1 RID: 121329 RVA: 0x00457D83 File Offset: 0x00455F83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D9F2 RID: 121330 RVA: 0x00457DB8 File Offset: 0x00455FB8
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

		// Token: 0x0601D9F3 RID: 121331 RVA: 0x00457DF6 File Offset: 0x00455FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CheatInputResponse other)
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

		// Token: 0x0601D9F4 RID: 121332 RVA: 0x00457E27 File Offset: 0x00456027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D9F5 RID: 121333 RVA: 0x00457E30 File Offset: 0x00456030
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400C894 RID: 51348
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C895 RID: 51349
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x0400C896 RID: 51350
		private ErrorCode errorCode_;
	}
}
