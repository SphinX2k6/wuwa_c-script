using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003B1 RID: 945
	[NetMessage(EMessageId.DestroyBulletResponse)]
	public sealed class DestroyBulletResponse : IMessage<DestroyBulletResponse>, IMessage, IEquatable<DestroyBulletResponse>, IDeepCloneable<DestroyBulletResponse>, IBufferMessage
	{
		// Token: 0x06005CFB RID: 23803 RVA: 0x000E1EBA File Offset: 0x000E00BA
		[NullableContext(1)]
		public static DestroyBulletResponse Create()
		{
			return new DestroyBulletResponse();
		}

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x06005CFC RID: 23804 RVA: 0x000E1EC1 File Offset: 0x000E00C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x06005CFD RID: 23805 RVA: 0x000E1EC4 File Offset: 0x000E00C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DestroyBulletResponse.Descriptor;
			}
		}

		// Token: 0x06005CFE RID: 23806 RVA: 0x000E1ECB File Offset: 0x000E00CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletResponse()
		{
		}

		// Token: 0x06005CFF RID: 23807 RVA: 0x000E1ED3 File Offset: 0x000E00D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletResponse(DestroyBulletResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D00 RID: 23808 RVA: 0x000E1EF8 File Offset: 0x000E00F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyBulletResponse Clone()
		{
			return new DestroyBulletResponse(this);
		}

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x06005D01 RID: 23809 RVA: 0x000E1F00 File Offset: 0x000E0100
		// (set) Token: 0x06005D02 RID: 23810 RVA: 0x000E1F08 File Offset: 0x000E0108
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

		// Token: 0x06005D03 RID: 23811 RVA: 0x000E1F11 File Offset: 0x000E0111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DestroyBulletResponse);
		}

		// Token: 0x06005D04 RID: 23812 RVA: 0x000E1F1F File Offset: 0x000E011F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DestroyBulletResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005D05 RID: 23813 RVA: 0x000E1F50 File Offset: 0x000E0150
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

		// Token: 0x06005D06 RID: 23814 RVA: 0x000E1F95 File Offset: 0x000E0195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005D07 RID: 23815 RVA: 0x000E1FA2 File Offset: 0x000E01A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D08 RID: 23816 RVA: 0x000E1FAB File Offset: 0x000E01AB
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

		// Token: 0x06005D09 RID: 23817 RVA: 0x000E1FE0 File Offset: 0x000E01E0
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

		// Token: 0x06005D0A RID: 23818 RVA: 0x000E201E File Offset: 0x000E021E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DestroyBulletResponse other)
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

		// Token: 0x06005D0B RID: 23819 RVA: 0x000E204F File Offset: 0x000E024F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D0C RID: 23820 RVA: 0x000E2058 File Offset: 0x000E0258
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

		// Token: 0x040036BF RID: 14015
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036C0 RID: 14016
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040036C1 RID: 14017
		private ErrorCode errorCode_;
	}
}
