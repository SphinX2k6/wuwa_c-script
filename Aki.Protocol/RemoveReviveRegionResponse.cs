using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F09 RID: 3849
	[NetMessage(EMessageId.RemoveReviveRegionResponse)]
	public sealed class RemoveReviveRegionResponse : IMessage<RemoveReviveRegionResponse>, IMessage, IEquatable<RemoveReviveRegionResponse>, IDeepCloneable<RemoveReviveRegionResponse>, IBufferMessage
	{
		// Token: 0x060149D0 RID: 84432 RVA: 0x002FE4D5 File Offset: 0x002FC6D5
		[NullableContext(1)]
		public static RemoveReviveRegionResponse Create()
		{
			return new RemoveReviveRegionResponse();
		}

		// Token: 0x17004489 RID: 17545
		// (get) Token: 0x060149D1 RID: 84433 RVA: 0x002FE4DC File Offset: 0x002FC6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700448A RID: 17546
		// (get) Token: 0x060149D2 RID: 84434 RVA: 0x002FE4DF File Offset: 0x002FC6DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveReviveRegionResponse.Descriptor;
			}
		}

		// Token: 0x060149D3 RID: 84435 RVA: 0x002FE4E6 File Offset: 0x002FC6E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveReviveRegionResponse()
		{
		}

		// Token: 0x060149D4 RID: 84436 RVA: 0x002FE4EE File Offset: 0x002FC6EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveReviveRegionResponse(RemoveReviveRegionResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060149D5 RID: 84437 RVA: 0x002FE513 File Offset: 0x002FC713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveReviveRegionResponse Clone()
		{
			return new RemoveReviveRegionResponse(this);
		}

		// Token: 0x1700448B RID: 17547
		// (get) Token: 0x060149D6 RID: 84438 RVA: 0x002FE51B File Offset: 0x002FC71B
		// (set) Token: 0x060149D7 RID: 84439 RVA: 0x002FE523 File Offset: 0x002FC723
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

		// Token: 0x060149D8 RID: 84440 RVA: 0x002FE52C File Offset: 0x002FC72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveReviveRegionResponse);
		}

		// Token: 0x060149D9 RID: 84441 RVA: 0x002FE53A File Offset: 0x002FC73A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveReviveRegionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060149DA RID: 84442 RVA: 0x002FE568 File Offset: 0x002FC768
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

		// Token: 0x060149DB RID: 84443 RVA: 0x002FE5AD File Offset: 0x002FC7AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060149DC RID: 84444 RVA: 0x002FE5BA File Offset: 0x002FC7BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060149DD RID: 84445 RVA: 0x002FE5C3 File Offset: 0x002FC7C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060149DE RID: 84446 RVA: 0x002FE5F8 File Offset: 0x002FC7F8
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

		// Token: 0x060149DF RID: 84447 RVA: 0x002FE636 File Offset: 0x002FC836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveReviveRegionResponse other)
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

		// Token: 0x060149E0 RID: 84448 RVA: 0x002FE667 File Offset: 0x002FC867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060149E1 RID: 84449 RVA: 0x002FE670 File Offset: 0x002FC870
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007CC7 RID: 31943
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CC8 RID: 31944
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04007CC9 RID: 31945
		private ErrorCode errorCode_;
	}
}
