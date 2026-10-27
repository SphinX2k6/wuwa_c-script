using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012B2 RID: 4786
	[NetMessage(EMessageId.SummonRandomResponse)]
	public sealed class SummonRandomResponse : IMessage<SummonRandomResponse>, IMessage, IEquatable<SummonRandomResponse>, IDeepCloneable<SummonRandomResponse>, IBufferMessage
	{
		// Token: 0x0601977C RID: 104316 RVA: 0x003B3853 File Offset: 0x003B1A53
		[NullableContext(1)]
		public static SummonRandomResponse Create()
		{
			return new SummonRandomResponse();
		}

		// Token: 0x170055E1 RID: 21985
		// (get) Token: 0x0601977D RID: 104317 RVA: 0x003B385A File Offset: 0x003B1A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055E2 RID: 21986
		// (get) Token: 0x0601977E RID: 104318 RVA: 0x003B385D File Offset: 0x003B1A5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonRandomResponse.Descriptor;
			}
		}

		// Token: 0x0601977F RID: 104319 RVA: 0x003B3864 File Offset: 0x003B1A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRandomResponse()
		{
		}

		// Token: 0x06019780 RID: 104320 RVA: 0x003B386C File Offset: 0x003B1A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRandomResponse(SummonRandomResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019781 RID: 104321 RVA: 0x003B3891 File Offset: 0x003B1A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRandomResponse Clone()
		{
			return new SummonRandomResponse(this);
		}

		// Token: 0x170055E3 RID: 21987
		// (get) Token: 0x06019782 RID: 104322 RVA: 0x003B3899 File Offset: 0x003B1A99
		// (set) Token: 0x06019783 RID: 104323 RVA: 0x003B38A1 File Offset: 0x003B1AA1
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

		// Token: 0x06019784 RID: 104324 RVA: 0x003B38AA File Offset: 0x003B1AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonRandomResponse);
		}

		// Token: 0x06019785 RID: 104325 RVA: 0x003B38B8 File Offset: 0x003B1AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonRandomResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019786 RID: 104326 RVA: 0x003B38E8 File Offset: 0x003B1AE8
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

		// Token: 0x06019787 RID: 104327 RVA: 0x003B392D File Offset: 0x003B1B2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019788 RID: 104328 RVA: 0x003B393A File Offset: 0x003B1B3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019789 RID: 104329 RVA: 0x003B3943 File Offset: 0x003B1B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601978A RID: 104330 RVA: 0x003B3978 File Offset: 0x003B1B78
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

		// Token: 0x0601978B RID: 104331 RVA: 0x003B39B6 File Offset: 0x003B1BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SummonRandomResponse other)
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

		// Token: 0x0601978C RID: 104332 RVA: 0x003B39E7 File Offset: 0x003B1BE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601978D RID: 104333 RVA: 0x003B39F0 File Offset: 0x003B1BF0
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009573 RID: 38259
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009574 RID: 38260
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04009575 RID: 38261
		private ErrorCode errorCode_;
	}
}
