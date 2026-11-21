using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001CC RID: 460
	[NetMessage(EMessageId.BossPilingRewardResponse)]
	public sealed class BossPilingRewardResponse : IMessage<BossPilingRewardResponse>, IMessage, IEquatable<BossPilingRewardResponse>, IDeepCloneable<BossPilingRewardResponse>, IBufferMessage
	{
		// Token: 0x060034CA RID: 13514 RVA: 0x000855B0 File Offset: 0x000837B0
		[NullableContext(1)]
		public static BossPilingRewardResponse Create()
		{
			return new BossPilingRewardResponse();
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x060034CB RID: 13515 RVA: 0x000855B7 File Offset: 0x000837B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x060034CC RID: 13516 RVA: 0x000855BA File Offset: 0x000837BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossPilingRewardResponse.Descriptor;
			}
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x000855C1 File Offset: 0x000837C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingRewardResponse()
		{
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x000855C9 File Offset: 0x000837C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingRewardResponse(BossPilingRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x000855EE File Offset: 0x000837EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingRewardResponse Clone()
		{
			return new BossPilingRewardResponse(this);
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x060034D0 RID: 13520 RVA: 0x000855F6 File Offset: 0x000837F6
		// (set) Token: 0x060034D1 RID: 13521 RVA: 0x000855FE File Offset: 0x000837FE
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

		// Token: 0x060034D2 RID: 13522 RVA: 0x00085607 File Offset: 0x00083807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossPilingRewardResponse);
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x00085615 File Offset: 0x00083815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossPilingRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x00085644 File Offset: 0x00083844
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

		// Token: 0x060034D5 RID: 13525 RVA: 0x00085689 File Offset: 0x00083889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060034D6 RID: 13526 RVA: 0x00085696 File Offset: 0x00083896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060034D7 RID: 13527 RVA: 0x0008569F File Offset: 0x0008389F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060034D8 RID: 13528 RVA: 0x000856D4 File Offset: 0x000838D4
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

		// Token: 0x060034D9 RID: 13529 RVA: 0x00085712 File Offset: 0x00083912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossPilingRewardResponse other)
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

		// Token: 0x060034DA RID: 13530 RVA: 0x00085743 File Offset: 0x00083943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060034DB RID: 13531 RVA: 0x0008574C File Offset: 0x0008394C
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002A76 RID: 10870
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A77 RID: 10871
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04002A78 RID: 10872
		private ErrorCode errorCode_;
	}
}
