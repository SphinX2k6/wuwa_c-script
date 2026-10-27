using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000873 RID: 2163
	[NetMessage(EMessageId.JokerGuessRewardResponse)]
	public sealed class JokerGuessRewardResponse : IMessage<JokerGuessRewardResponse>, IMessage, IEquatable<JokerGuessRewardResponse>, IDeepCloneable<JokerGuessRewardResponse>, IBufferMessage
	{
		// Token: 0x0600C0A5 RID: 49317 RVA: 0x001C9A9D File Offset: 0x001C7C9D
		[NullableContext(1)]
		public static JokerGuessRewardResponse Create()
		{
			return new JokerGuessRewardResponse();
		}

		// Token: 0x170026ED RID: 9965
		// (get) Token: 0x0600C0A6 RID: 49318 RVA: 0x001C9AA4 File Offset: 0x001C7CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026EE RID: 9966
		// (get) Token: 0x0600C0A7 RID: 49319 RVA: 0x001C9AA7 File Offset: 0x001C7CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600C0A8 RID: 49320 RVA: 0x001C9AAE File Offset: 0x001C7CAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessRewardResponse()
		{
		}

		// Token: 0x0600C0A9 RID: 49321 RVA: 0x001C9AB6 File Offset: 0x001C7CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessRewardResponse(JokerGuessRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C0AA RID: 49322 RVA: 0x001C9ADB File Offset: 0x001C7CDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessRewardResponse Clone()
		{
			return new JokerGuessRewardResponse(this);
		}

		// Token: 0x170026EF RID: 9967
		// (get) Token: 0x0600C0AB RID: 49323 RVA: 0x001C9AE3 File Offset: 0x001C7CE3
		// (set) Token: 0x0600C0AC RID: 49324 RVA: 0x001C9AEB File Offset: 0x001C7CEB
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

		// Token: 0x0600C0AD RID: 49325 RVA: 0x001C9AF4 File Offset: 0x001C7CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessRewardResponse);
		}

		// Token: 0x0600C0AE RID: 49326 RVA: 0x001C9B02 File Offset: 0x001C7D02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C0AF RID: 49327 RVA: 0x001C9B30 File Offset: 0x001C7D30
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

		// Token: 0x0600C0B0 RID: 49328 RVA: 0x001C9B75 File Offset: 0x001C7D75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C0B1 RID: 49329 RVA: 0x001C9B82 File Offset: 0x001C7D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C0B2 RID: 49330 RVA: 0x001C9B8B File Offset: 0x001C7D8B
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

		// Token: 0x0600C0B3 RID: 49331 RVA: 0x001C9BC0 File Offset: 0x001C7DC0
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

		// Token: 0x0600C0B4 RID: 49332 RVA: 0x001C9BFE File Offset: 0x001C7DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JokerGuessRewardResponse other)
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

		// Token: 0x0600C0B5 RID: 49333 RVA: 0x001C9C2F File Offset: 0x001C7E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C0B6 RID: 49334 RVA: 0x001C9C38 File Offset: 0x001C7E38
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

		// Token: 0x040053AA RID: 21418
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053AB RID: 21419
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040053AC RID: 21420
		private ErrorCode errorCode_;
	}
}
