using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000678 RID: 1656
	[NetMessage(EMessageId.FuncShowResponse)]
	public sealed class FuncShowResponse : IMessage<FuncShowResponse>, IMessage, IEquatable<FuncShowResponse>, IDeepCloneable<FuncShowResponse>, IBufferMessage
	{
		// Token: 0x060097C7 RID: 38855 RVA: 0x0016DFA9 File Offset: 0x0016C1A9
		[NullableContext(1)]
		public static FuncShowResponse Create()
		{
			return new FuncShowResponse();
		}

		// Token: 0x17001E3D RID: 7741
		// (get) Token: 0x060097C8 RID: 38856 RVA: 0x0016DFB0 File Offset: 0x0016C1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E3E RID: 7742
		// (get) Token: 0x060097C9 RID: 38857 RVA: 0x0016DFB3 File Offset: 0x0016C1B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FuncShowResponse.Descriptor;
			}
		}

		// Token: 0x060097CA RID: 38858 RVA: 0x0016DFBA File Offset: 0x0016C1BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncShowResponse()
		{
		}

		// Token: 0x060097CB RID: 38859 RVA: 0x0016DFC2 File Offset: 0x0016C1C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncShowResponse(FuncShowResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060097CC RID: 38860 RVA: 0x0016DFE7 File Offset: 0x0016C1E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncShowResponse Clone()
		{
			return new FuncShowResponse(this);
		}

		// Token: 0x17001E3F RID: 7743
		// (get) Token: 0x060097CD RID: 38861 RVA: 0x0016DFEF File Offset: 0x0016C1EF
		// (set) Token: 0x060097CE RID: 38862 RVA: 0x0016DFF7 File Offset: 0x0016C1F7
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

		// Token: 0x060097CF RID: 38863 RVA: 0x0016E000 File Offset: 0x0016C200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FuncShowResponse);
		}

		// Token: 0x060097D0 RID: 38864 RVA: 0x0016E00E File Offset: 0x0016C20E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FuncShowResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060097D1 RID: 38865 RVA: 0x0016E03C File Offset: 0x0016C23C
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

		// Token: 0x060097D2 RID: 38866 RVA: 0x0016E081 File Offset: 0x0016C281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060097D3 RID: 38867 RVA: 0x0016E08E File Offset: 0x0016C28E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060097D4 RID: 38868 RVA: 0x0016E097 File Offset: 0x0016C297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060097D5 RID: 38869 RVA: 0x0016E0CC File Offset: 0x0016C2CC
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

		// Token: 0x060097D6 RID: 38870 RVA: 0x0016E10A File Offset: 0x0016C30A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FuncShowResponse other)
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

		// Token: 0x060097D7 RID: 38871 RVA: 0x0016E13B File Offset: 0x0016C33B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060097D8 RID: 38872 RVA: 0x0016E144 File Offset: 0x0016C344
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004816 RID: 18454
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004817 RID: 18455
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04004818 RID: 18456
		private ErrorCode errorCode_;
	}
}
