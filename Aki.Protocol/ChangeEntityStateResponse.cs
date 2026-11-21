using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000252 RID: 594
	[NetMessage(EMessageId.ChangeEntityStateResponse)]
	public sealed class ChangeEntityStateResponse : IMessage<ChangeEntityStateResponse>, IMessage, IEquatable<ChangeEntityStateResponse>, IDeepCloneable<ChangeEntityStateResponse>, IBufferMessage
	{
		// Token: 0x06003F8A RID: 16266 RVA: 0x0009CCA8 File Offset: 0x0009AEA8
		[NullableContext(1)]
		public static ChangeEntityStateResponse Create()
		{
			return new ChangeEntityStateResponse();
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06003F8B RID: 16267 RVA: 0x0009CCAF File Offset: 0x0009AEAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06003F8C RID: 16268 RVA: 0x0009CCB2 File Offset: 0x0009AEB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeEntityStateResponse.Descriptor;
			}
		}

		// Token: 0x06003F8D RID: 16269 RVA: 0x0009CCB9 File Offset: 0x0009AEB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEntityStateResponse()
		{
		}

		// Token: 0x06003F8E RID: 16270 RVA: 0x0009CCC1 File Offset: 0x0009AEC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEntityStateResponse(ChangeEntityStateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F8F RID: 16271 RVA: 0x0009CCE6 File Offset: 0x0009AEE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEntityStateResponse Clone()
		{
			return new ChangeEntityStateResponse(this);
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06003F90 RID: 16272 RVA: 0x0009CCEE File Offset: 0x0009AEEE
		// (set) Token: 0x06003F91 RID: 16273 RVA: 0x0009CCF6 File Offset: 0x0009AEF6
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

		// Token: 0x06003F92 RID: 16274 RVA: 0x0009CCFF File Offset: 0x0009AEFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeEntityStateResponse);
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x0009CD0D File Offset: 0x0009AF0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeEntityStateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003F94 RID: 16276 RVA: 0x0009CD3C File Offset: 0x0009AF3C
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

		// Token: 0x06003F95 RID: 16277 RVA: 0x0009CD81 File Offset: 0x0009AF81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003F96 RID: 16278 RVA: 0x0009CD8E File Offset: 0x0009AF8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F97 RID: 16279 RVA: 0x0009CD97 File Offset: 0x0009AF97
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

		// Token: 0x06003F98 RID: 16280 RVA: 0x0009CDCC File Offset: 0x0009AFCC
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

		// Token: 0x06003F99 RID: 16281 RVA: 0x0009CE0A File Offset: 0x0009B00A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeEntityStateResponse other)
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

		// Token: 0x06003F9A RID: 16282 RVA: 0x0009CE3B File Offset: 0x0009B03B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F9B RID: 16283 RVA: 0x0009CE44 File Offset: 0x0009B044
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

		// Token: 0x04002D81 RID: 11649
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D82 RID: 11650
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04002D83 RID: 11651
		private ErrorCode errorCode_;
	}
}
