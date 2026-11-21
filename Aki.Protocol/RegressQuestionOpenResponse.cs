using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ED2 RID: 3794
	[NetMessage(EMessageId.RegressQuestionOpenResponse)]
	public sealed class RegressQuestionOpenResponse : IMessage<RegressQuestionOpenResponse>, IMessage, IEquatable<RegressQuestionOpenResponse>, IDeepCloneable<RegressQuestionOpenResponse>, IBufferMessage
	{
		// Token: 0x060145D9 RID: 83417 RVA: 0x002F65A5 File Offset: 0x002F47A5
		[NullableContext(1)]
		public static RegressQuestionOpenResponse Create()
		{
			return new RegressQuestionOpenResponse();
		}

		// Token: 0x170043C0 RID: 17344
		// (get) Token: 0x060145DA RID: 83418 RVA: 0x002F65AC File Offset: 0x002F47AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043C1 RID: 17345
		// (get) Token: 0x060145DB RID: 83419 RVA: 0x002F65AF File Offset: 0x002F47AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressQuestionOpenResponse.Descriptor;
			}
		}

		// Token: 0x060145DC RID: 83420 RVA: 0x002F65B6 File Offset: 0x002F47B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressQuestionOpenResponse()
		{
		}

		// Token: 0x060145DD RID: 83421 RVA: 0x002F65BE File Offset: 0x002F47BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressQuestionOpenResponse(RegressQuestionOpenResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060145DE RID: 83422 RVA: 0x002F65E3 File Offset: 0x002F47E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressQuestionOpenResponse Clone()
		{
			return new RegressQuestionOpenResponse(this);
		}

		// Token: 0x170043C2 RID: 17346
		// (get) Token: 0x060145DF RID: 83423 RVA: 0x002F65EB File Offset: 0x002F47EB
		// (set) Token: 0x060145E0 RID: 83424 RVA: 0x002F65F3 File Offset: 0x002F47F3
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

		// Token: 0x060145E1 RID: 83425 RVA: 0x002F65FC File Offset: 0x002F47FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressQuestionOpenResponse);
		}

		// Token: 0x060145E2 RID: 83426 RVA: 0x002F660A File Offset: 0x002F480A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressQuestionOpenResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060145E3 RID: 83427 RVA: 0x002F6638 File Offset: 0x002F4838
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

		// Token: 0x060145E4 RID: 83428 RVA: 0x002F667D File Offset: 0x002F487D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060145E5 RID: 83429 RVA: 0x002F668A File Offset: 0x002F488A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060145E6 RID: 83430 RVA: 0x002F6693 File Offset: 0x002F4893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060145E7 RID: 83431 RVA: 0x002F66C8 File Offset: 0x002F48C8
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

		// Token: 0x060145E8 RID: 83432 RVA: 0x002F6706 File Offset: 0x002F4906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressQuestionOpenResponse other)
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

		// Token: 0x060145E9 RID: 83433 RVA: 0x002F6737 File Offset: 0x002F4937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060145EA RID: 83434 RVA: 0x002F6740 File Offset: 0x002F4940
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007C20 RID: 31776
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C21 RID: 31777
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04007C22 RID: 31778
		private ErrorCode errorCode_;
	}
}
