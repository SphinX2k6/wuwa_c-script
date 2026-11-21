using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F13 RID: 3859
	[NetMessage(EMessageId.ResetBabelTowerLevelResponse)]
	public sealed class ResetBabelTowerLevelResponse : IMessage<ResetBabelTowerLevelResponse>, IMessage, IEquatable<ResetBabelTowerLevelResponse>, IDeepCloneable<ResetBabelTowerLevelResponse>, IBufferMessage
	{
		// Token: 0x06014AEB RID: 84715 RVA: 0x00300FFD File Offset: 0x002FF1FD
		[NullableContext(1)]
		public static ResetBabelTowerLevelResponse Create()
		{
			return new ResetBabelTowerLevelResponse();
		}

		// Token: 0x170044C3 RID: 17603
		// (get) Token: 0x06014AEC RID: 84716 RVA: 0x00301004 File Offset: 0x002FF204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044C4 RID: 17604
		// (get) Token: 0x06014AED RID: 84717 RVA: 0x00301007 File Offset: 0x002FF207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResetBabelTowerLevelResponse.Descriptor;
			}
		}

		// Token: 0x06014AEE RID: 84718 RVA: 0x0030100E File Offset: 0x002FF20E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetBabelTowerLevelResponse()
		{
		}

		// Token: 0x06014AEF RID: 84719 RVA: 0x00301016 File Offset: 0x002FF216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetBabelTowerLevelResponse(ResetBabelTowerLevelResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014AF0 RID: 84720 RVA: 0x0030103B File Offset: 0x002FF23B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetBabelTowerLevelResponse Clone()
		{
			return new ResetBabelTowerLevelResponse(this);
		}

		// Token: 0x170044C5 RID: 17605
		// (get) Token: 0x06014AF1 RID: 84721 RVA: 0x00301043 File Offset: 0x002FF243
		// (set) Token: 0x06014AF2 RID: 84722 RVA: 0x0030104B File Offset: 0x002FF24B
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

		// Token: 0x06014AF3 RID: 84723 RVA: 0x00301054 File Offset: 0x002FF254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResetBabelTowerLevelResponse);
		}

		// Token: 0x06014AF4 RID: 84724 RVA: 0x00301062 File Offset: 0x002FF262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResetBabelTowerLevelResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014AF5 RID: 84725 RVA: 0x00301090 File Offset: 0x002FF290
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

		// Token: 0x06014AF6 RID: 84726 RVA: 0x003010D5 File Offset: 0x002FF2D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014AF7 RID: 84727 RVA: 0x003010E2 File Offset: 0x002FF2E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014AF8 RID: 84728 RVA: 0x003010EB File Offset: 0x002FF2EB
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

		// Token: 0x06014AF9 RID: 84729 RVA: 0x00301120 File Offset: 0x002FF320
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

		// Token: 0x06014AFA RID: 84730 RVA: 0x0030115E File Offset: 0x002FF35E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ResetBabelTowerLevelResponse other)
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

		// Token: 0x06014AFB RID: 84731 RVA: 0x0030118F File Offset: 0x002FF38F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014AFC RID: 84732 RVA: 0x00301198 File Offset: 0x002FF398
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

		// Token: 0x04007D6C RID: 32108
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D6D RID: 32109
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04007D6E RID: 32110
		private ErrorCode errorCode_;
	}
}
