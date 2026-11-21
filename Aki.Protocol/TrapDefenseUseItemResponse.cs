using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014D1 RID: 5329
	[NetMessage(EMessageId.TrapDefenseUseItemResponse)]
	public sealed class TrapDefenseUseItemResponse : IMessage<TrapDefenseUseItemResponse>, IMessage, IEquatable<TrapDefenseUseItemResponse>, IDeepCloneable<TrapDefenseUseItemResponse>, IBufferMessage
	{
		// Token: 0x0601C43D RID: 115773 RVA: 0x0041A069 File Offset: 0x00418269
		[NullableContext(1)]
		public static TrapDefenseUseItemResponse Create()
		{
			return new TrapDefenseUseItemResponse();
		}

		// Token: 0x17005FA8 RID: 24488
		// (get) Token: 0x0601C43E RID: 115774 RVA: 0x0041A070 File Offset: 0x00418270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FA9 RID: 24489
		// (get) Token: 0x0601C43F RID: 115775 RVA: 0x0041A073 File Offset: 0x00418273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseUseItemResponse.Descriptor;
			}
		}

		// Token: 0x0601C440 RID: 115776 RVA: 0x0041A07A File Offset: 0x0041827A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseUseItemResponse()
		{
		}

		// Token: 0x0601C441 RID: 115777 RVA: 0x0041A082 File Offset: 0x00418282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseUseItemResponse(TrapDefenseUseItemResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C442 RID: 115778 RVA: 0x0041A0A7 File Offset: 0x004182A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseUseItemResponse Clone()
		{
			return new TrapDefenseUseItemResponse(this);
		}

		// Token: 0x17005FAA RID: 24490
		// (get) Token: 0x0601C443 RID: 115779 RVA: 0x0041A0AF File Offset: 0x004182AF
		// (set) Token: 0x0601C444 RID: 115780 RVA: 0x0041A0B7 File Offset: 0x004182B7
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

		// Token: 0x0601C445 RID: 115781 RVA: 0x0041A0C0 File Offset: 0x004182C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseUseItemResponse);
		}

		// Token: 0x0601C446 RID: 115782 RVA: 0x0041A0CE File Offset: 0x004182CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseUseItemResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C447 RID: 115783 RVA: 0x0041A0FC File Offset: 0x004182FC
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

		// Token: 0x0601C448 RID: 115784 RVA: 0x0041A141 File Offset: 0x00418341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C449 RID: 115785 RVA: 0x0041A14E File Offset: 0x0041834E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C44A RID: 115786 RVA: 0x0041A157 File Offset: 0x00418357
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

		// Token: 0x0601C44B RID: 115787 RVA: 0x0041A188 File Offset: 0x00418388
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

		// Token: 0x0601C44C RID: 115788 RVA: 0x0041A1C6 File Offset: 0x004183C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseUseItemResponse other)
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

		// Token: 0x0601C44D RID: 115789 RVA: 0x0041A1F7 File Offset: 0x004183F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C44E RID: 115790 RVA: 0x0041A200 File Offset: 0x00418400
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

		// Token: 0x0400A35C RID: 41820
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A35D RID: 41821
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400A35E RID: 41822
		private ErrorCode errorCode_;
	}
}
