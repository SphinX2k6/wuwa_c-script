using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200004F RID: 79
	[NetMessage(EMessageId.AcceptFocusWaitQuestResponse)]
	public sealed class AcceptFocusWaitQuestResponse : IMessage<AcceptFocusWaitQuestResponse>, IMessage, IEquatable<AcceptFocusWaitQuestResponse>, IDeepCloneable<AcceptFocusWaitQuestResponse>, IBufferMessage
	{
		// Token: 0x060014C3 RID: 5315 RVA: 0x000378D9 File Offset: 0x00035AD9
		[NullableContext(1)]
		public static AcceptFocusWaitQuestResponse Create()
		{
			return new AcceptFocusWaitQuestResponse();
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x000378E0 File Offset: 0x00035AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060014C5 RID: 5317 RVA: 0x000378E3 File Offset: 0x00035AE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptFocusWaitQuestResponse.Descriptor;
			}
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x000378EA File Offset: 0x00035AEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptFocusWaitQuestResponse()
		{
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x000378F2 File Offset: 0x00035AF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptFocusWaitQuestResponse(AcceptFocusWaitQuestResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x00037917 File Offset: 0x00035B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptFocusWaitQuestResponse Clone()
		{
			return new AcceptFocusWaitQuestResponse(this);
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060014C9 RID: 5321 RVA: 0x0003791F File Offset: 0x00035B1F
		// (set) Token: 0x060014CA RID: 5322 RVA: 0x00037927 File Offset: 0x00035B27
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

		// Token: 0x060014CB RID: 5323 RVA: 0x00037930 File Offset: 0x00035B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptFocusWaitQuestResponse);
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x0003793E File Offset: 0x00035B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AcceptFocusWaitQuestResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x0003796C File Offset: 0x00035B6C
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

		// Token: 0x060014CE RID: 5326 RVA: 0x000379B1 File Offset: 0x00035BB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x000379BE File Offset: 0x00035BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x000379C7 File Offset: 0x00035BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x000379FC File Offset: 0x00035BFC
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

		// Token: 0x060014D2 RID: 5330 RVA: 0x00037A3A File Offset: 0x00035C3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AcceptFocusWaitQuestResponse other)
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

		// Token: 0x060014D3 RID: 5331 RVA: 0x00037A6B File Offset: 0x00035C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x00037A74 File Offset: 0x00035C74
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002076 RID: 8310
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002077 RID: 8311
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04002078 RID: 8312
		private ErrorCode errorCode_;
	}
}
