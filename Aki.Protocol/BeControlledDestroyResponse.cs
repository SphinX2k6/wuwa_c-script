using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200018A RID: 394
	[NetMessage(EMessageId.BeControlledDestroyResponse)]
	public sealed class BeControlledDestroyResponse : IMessage<BeControlledDestroyResponse>, IMessage, IEquatable<BeControlledDestroyResponse>, IDeepCloneable<BeControlledDestroyResponse>, IBufferMessage
	{
		// Token: 0x06002F84 RID: 12164 RVA: 0x0007A099 File Offset: 0x00078299
		[NullableContext(1)]
		public static BeControlledDestroyResponse Create()
		{
			return new BeControlledDestroyResponse();
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06002F85 RID: 12165 RVA: 0x0007A0A0 File Offset: 0x000782A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06002F86 RID: 12166 RVA: 0x0007A0A3 File Offset: 0x000782A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledDestroyResponse.Descriptor;
			}
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x0007A0AA File Offset: 0x000782AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledDestroyResponse()
		{
		}

		// Token: 0x06002F88 RID: 12168 RVA: 0x0007A0B2 File Offset: 0x000782B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledDestroyResponse(BeControlledDestroyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x0007A0D7 File Offset: 0x000782D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledDestroyResponse Clone()
		{
			return new BeControlledDestroyResponse(this);
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06002F8A RID: 12170 RVA: 0x0007A0DF File Offset: 0x000782DF
		// (set) Token: 0x06002F8B RID: 12171 RVA: 0x0007A0E7 File Offset: 0x000782E7
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

		// Token: 0x06002F8C RID: 12172 RVA: 0x0007A0F0 File Offset: 0x000782F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledDestroyResponse);
		}

		// Token: 0x06002F8D RID: 12173 RVA: 0x0007A0FE File Offset: 0x000782FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledDestroyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002F8E RID: 12174 RVA: 0x0007A12C File Offset: 0x0007832C
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

		// Token: 0x06002F8F RID: 12175 RVA: 0x0007A171 File Offset: 0x00078371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002F90 RID: 12176 RVA: 0x0007A17E File Offset: 0x0007837E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002F91 RID: 12177 RVA: 0x0007A187 File Offset: 0x00078387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x0007A1BC File Offset: 0x000783BC
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

		// Token: 0x06002F93 RID: 12179 RVA: 0x0007A1FA File Offset: 0x000783FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeControlledDestroyResponse other)
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

		// Token: 0x06002F94 RID: 12180 RVA: 0x0007A22B File Offset: 0x0007842B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002F95 RID: 12181 RVA: 0x0007A234 File Offset: 0x00078434
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400290D RID: 10509
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400290E RID: 10510
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400290F RID: 10511
		private ErrorCode errorCode_;
	}
}
