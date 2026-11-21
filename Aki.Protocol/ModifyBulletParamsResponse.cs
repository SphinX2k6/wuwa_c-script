using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009D9 RID: 2521
	[NetMessage(EMessageId.ModifyBulletParamsResponse)]
	public sealed class ModifyBulletParamsResponse : IMessage<ModifyBulletParamsResponse>, IMessage, IEquatable<ModifyBulletParamsResponse>, IDeepCloneable<ModifyBulletParamsResponse>, IBufferMessage
	{
		// Token: 0x0600DD3D RID: 56637 RVA: 0x00207A2C File Offset: 0x00205C2C
		[NullableContext(1)]
		public static ModifyBulletParamsResponse Create()
		{
			return new ModifyBulletParamsResponse();
		}

		// Token: 0x17002CD3 RID: 11475
		// (get) Token: 0x0600DD3E RID: 56638 RVA: 0x00207A33 File Offset: 0x00205C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CD4 RID: 11476
		// (get) Token: 0x0600DD3F RID: 56639 RVA: 0x00207A36 File Offset: 0x00205C36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModifyBulletParamsResponse.Descriptor;
			}
		}

		// Token: 0x0600DD40 RID: 56640 RVA: 0x00207A3D File Offset: 0x00205C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsResponse()
		{
		}

		// Token: 0x0600DD41 RID: 56641 RVA: 0x00207A45 File Offset: 0x00205C45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsResponse(ModifyBulletParamsResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DD42 RID: 56642 RVA: 0x00207A6A File Offset: 0x00205C6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsResponse Clone()
		{
			return new ModifyBulletParamsResponse(this);
		}

		// Token: 0x17002CD5 RID: 11477
		// (get) Token: 0x0600DD43 RID: 56643 RVA: 0x00207A72 File Offset: 0x00205C72
		// (set) Token: 0x0600DD44 RID: 56644 RVA: 0x00207A7A File Offset: 0x00205C7A
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

		// Token: 0x0600DD45 RID: 56645 RVA: 0x00207A83 File Offset: 0x00205C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModifyBulletParamsResponse);
		}

		// Token: 0x0600DD46 RID: 56646 RVA: 0x00207A91 File Offset: 0x00205C91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ModifyBulletParamsResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DD47 RID: 56647 RVA: 0x00207AC0 File Offset: 0x00205CC0
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

		// Token: 0x0600DD48 RID: 56648 RVA: 0x00207B05 File Offset: 0x00205D05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DD49 RID: 56649 RVA: 0x00207B12 File Offset: 0x00205D12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DD4A RID: 56650 RVA: 0x00207B1B File Offset: 0x00205D1B
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

		// Token: 0x0600DD4B RID: 56651 RVA: 0x00207B50 File Offset: 0x00205D50
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

		// Token: 0x0600DD4C RID: 56652 RVA: 0x00207B8E File Offset: 0x00205D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ModifyBulletParamsResponse other)
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

		// Token: 0x0600DD4D RID: 56653 RVA: 0x00207BBF File Offset: 0x00205DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD4E RID: 56654 RVA: 0x00207BC8 File Offset: 0x00205DC8
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

		// Token: 0x04005BD9 RID: 23513
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BDA RID: 23514
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04005BDB RID: 23515
		private ErrorCode errorCode_;
	}
}
