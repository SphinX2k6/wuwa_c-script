using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000296 RID: 662
	[NetMessage(EMessageId.CircumFluenceTaskRewardResponse)]
	public sealed class CircumFluenceTaskRewardResponse : IMessage<CircumFluenceTaskRewardResponse>, IMessage, IEquatable<CircumFluenceTaskRewardResponse>, IDeepCloneable<CircumFluenceTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x060044FC RID: 17660 RVA: 0x000A9466 File Offset: 0x000A7666
		[NullableContext(1)]
		public static CircumFluenceTaskRewardResponse Create()
		{
			return new CircumFluenceTaskRewardResponse();
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x060044FD RID: 17661 RVA: 0x000A946D File Offset: 0x000A766D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x060044FE RID: 17662 RVA: 0x000A9470 File Offset: 0x000A7670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CircumFluenceTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x000A9477 File Offset: 0x000A7677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CircumFluenceTaskRewardResponse()
		{
		}

		// Token: 0x06004500 RID: 17664 RVA: 0x000A947F File Offset: 0x000A767F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CircumFluenceTaskRewardResponse(CircumFluenceTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x000A94A4 File Offset: 0x000A76A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CircumFluenceTaskRewardResponse Clone()
		{
			return new CircumFluenceTaskRewardResponse(this);
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06004502 RID: 17666 RVA: 0x000A94AC File Offset: 0x000A76AC
		// (set) Token: 0x06004503 RID: 17667 RVA: 0x000A94B4 File Offset: 0x000A76B4
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

		// Token: 0x06004504 RID: 17668 RVA: 0x000A94BD File Offset: 0x000A76BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CircumFluenceTaskRewardResponse);
		}

		// Token: 0x06004505 RID: 17669 RVA: 0x000A94CB File Offset: 0x000A76CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CircumFluenceTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004506 RID: 17670 RVA: 0x000A94FC File Offset: 0x000A76FC
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

		// Token: 0x06004507 RID: 17671 RVA: 0x000A9541 File Offset: 0x000A7741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004508 RID: 17672 RVA: 0x000A954E File Offset: 0x000A774E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004509 RID: 17673 RVA: 0x000A9557 File Offset: 0x000A7757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600450A RID: 17674 RVA: 0x000A9588 File Offset: 0x000A7788
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

		// Token: 0x0600450B RID: 17675 RVA: 0x000A95C6 File Offset: 0x000A77C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CircumFluenceTaskRewardResponse other)
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

		// Token: 0x0600450C RID: 17676 RVA: 0x000A95F7 File Offset: 0x000A77F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600450D RID: 17677 RVA: 0x000A9600 File Offset: 0x000A7800
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002ED8 RID: 11992
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002ED9 RID: 11993
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04002EDA RID: 11994
		private ErrorCode errorCode_;
	}
}
