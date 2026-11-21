using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000AE RID: 174
	[NetMessage(EMessageId.AddReviveRegionResponse)]
	public sealed class AddReviveRegionResponse : IMessage<AddReviveRegionResponse>, IMessage, IEquatable<AddReviveRegionResponse>, IDeepCloneable<AddReviveRegionResponse>, IBufferMessage
	{
		// Token: 0x06001D8A RID: 7562 RVA: 0x000515E9 File Offset: 0x0004F7E9
		[NullableContext(1)]
		public static AddReviveRegionResponse Create()
		{
			return new AddReviveRegionResponse();
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06001D8B RID: 7563 RVA: 0x000515F0 File Offset: 0x0004F7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06001D8C RID: 7564 RVA: 0x000515F3 File Offset: 0x0004F7F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddReviveRegionResponse.Descriptor;
			}
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x000515FA File Offset: 0x0004F7FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddReviveRegionResponse()
		{
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x00051602 File Offset: 0x0004F802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddReviveRegionResponse(AddReviveRegionResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x00051627 File Offset: 0x0004F827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddReviveRegionResponse Clone()
		{
			return new AddReviveRegionResponse(this);
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06001D90 RID: 7568 RVA: 0x0005162F File Offset: 0x0004F82F
		// (set) Token: 0x06001D91 RID: 7569 RVA: 0x00051637 File Offset: 0x0004F837
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

		// Token: 0x06001D92 RID: 7570 RVA: 0x00051640 File Offset: 0x0004F840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddReviveRegionResponse);
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x0005164E File Offset: 0x0004F84E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddReviveRegionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x0005167C File Offset: 0x0004F87C
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

		// Token: 0x06001D95 RID: 7573 RVA: 0x000516C1 File Offset: 0x0004F8C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x000516CE File Offset: 0x0004F8CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x000516D7 File Offset: 0x0004F8D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x0005170C File Offset: 0x0004F90C
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

		// Token: 0x06001D99 RID: 7577 RVA: 0x0005174A File Offset: 0x0004F94A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddReviveRegionResponse other)
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

		// Token: 0x06001D9A RID: 7578 RVA: 0x0005177B File Offset: 0x0004F97B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x00051784 File Offset: 0x0004F984
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002374 RID: 9076
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002375 RID: 9077
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04002376 RID: 9078
		private ErrorCode errorCode_;
	}
}
