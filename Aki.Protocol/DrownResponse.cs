using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000401 RID: 1025
	[NetMessage(EMessageId.DrownResponse)]
	public sealed class DrownResponse : IMessage<DrownResponse>, IMessage, IEquatable<DrownResponse>, IDeepCloneable<DrownResponse>, IBufferMessage
	{
		// Token: 0x0600632A RID: 25386 RVA: 0x000EE7C2 File Offset: 0x000EC9C2
		[NullableContext(1)]
		public static DrownResponse Create()
		{
			return new DrownResponse();
		}

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x0600632B RID: 25387 RVA: 0x000EE7C9 File Offset: 0x000EC9C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x0600632C RID: 25388 RVA: 0x000EE7CC File Offset: 0x000EC9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DrownResponse.Descriptor;
			}
		}

		// Token: 0x0600632D RID: 25389 RVA: 0x000EE7D3 File Offset: 0x000EC9D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownResponse()
		{
		}

		// Token: 0x0600632E RID: 25390 RVA: 0x000EE7DB File Offset: 0x000EC9DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownResponse(DrownResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600632F RID: 25391 RVA: 0x000EE800 File Offset: 0x000ECA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownResponse Clone()
		{
			return new DrownResponse(this);
		}

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x06006330 RID: 25392 RVA: 0x000EE808 File Offset: 0x000ECA08
		// (set) Token: 0x06006331 RID: 25393 RVA: 0x000EE810 File Offset: 0x000ECA10
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

		// Token: 0x06006332 RID: 25394 RVA: 0x000EE819 File Offset: 0x000ECA19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DrownResponse);
		}

		// Token: 0x06006333 RID: 25395 RVA: 0x000EE827 File Offset: 0x000ECA27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DrownResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006334 RID: 25396 RVA: 0x000EE858 File Offset: 0x000ECA58
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

		// Token: 0x06006335 RID: 25397 RVA: 0x000EE89D File Offset: 0x000ECA9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006336 RID: 25398 RVA: 0x000EE8AA File Offset: 0x000ECAAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006337 RID: 25399 RVA: 0x000EE8B3 File Offset: 0x000ECAB3
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

		// Token: 0x06006338 RID: 25400 RVA: 0x000EE8E8 File Offset: 0x000ECAE8
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

		// Token: 0x06006339 RID: 25401 RVA: 0x000EE926 File Offset: 0x000ECB26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DrownResponse other)
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

		// Token: 0x0600633A RID: 25402 RVA: 0x000EE957 File Offset: 0x000ECB57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600633B RID: 25403 RVA: 0x000EE960 File Offset: 0x000ECB60
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

		// Token: 0x0400385A RID: 14426
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400385B RID: 14427
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400385C RID: 14428
		private ErrorCode errorCode_;
	}
}
