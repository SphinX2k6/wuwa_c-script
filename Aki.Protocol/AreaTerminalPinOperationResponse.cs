using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000110 RID: 272
	[NetMessage(EMessageId.AreaTerminalPinOperationResponse)]
	public sealed class AreaTerminalPinOperationResponse : IMessage<AreaTerminalPinOperationResponse>, IMessage, IEquatable<AreaTerminalPinOperationResponse>, IDeepCloneable<AreaTerminalPinOperationResponse>, IBufferMessage
	{
		// Token: 0x0600258D RID: 9613 RVA: 0x00064318 File Offset: 0x00062518
		[NullableContext(1)]
		public static AreaTerminalPinOperationResponse Create()
		{
			return new AreaTerminalPinOperationResponse();
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x0600258E RID: 9614 RVA: 0x0006431F File Offset: 0x0006251F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x0600258F RID: 9615 RVA: 0x00064322 File Offset: 0x00062522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AreaTerminalPinOperationResponse.Descriptor;
			}
		}

		// Token: 0x06002590 RID: 9616 RVA: 0x00064329 File Offset: 0x00062529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaTerminalPinOperationResponse()
		{
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x00064331 File Offset: 0x00062531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaTerminalPinOperationResponse(AreaTerminalPinOperationResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002592 RID: 9618 RVA: 0x00064356 File Offset: 0x00062556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaTerminalPinOperationResponse Clone()
		{
			return new AreaTerminalPinOperationResponse(this);
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06002593 RID: 9619 RVA: 0x0006435E File Offset: 0x0006255E
		// (set) Token: 0x06002594 RID: 9620 RVA: 0x00064366 File Offset: 0x00062566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x0006436F File Offset: 0x0006256F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AreaTerminalPinOperationResponse);
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x0006437D File Offset: 0x0006257D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AreaTerminalPinOperationResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x000643AC File Offset: 0x000625AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x000643F1 File Offset: 0x000625F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x000643FE File Offset: 0x000625FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x00064407 File Offset: 0x00062607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x0006443C File Offset: 0x0006263C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x0006447A File Offset: 0x0006267A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AreaTerminalPinOperationResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x000644AB File Offset: 0x000626AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x000644B4 File Offset: 0x000626B4
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
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040025D5 RID: 9685
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025D6 RID: 9686
		public const int CodeFieldNumber = 7;

		// Token: 0x040025D7 RID: 9687
		private ErrorCode code_;
	}
}
