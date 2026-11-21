using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000442 RID: 1090
	[NetMessage(EMessageId.EnterMatchInstResponse)]
	public sealed class EnterMatchInstResponse : IMessage<EnterMatchInstResponse>, IMessage, IEquatable<EnterMatchInstResponse>, IDeepCloneable<EnterMatchInstResponse>, IBufferMessage
	{
		// Token: 0x060068E0 RID: 26848 RVA: 0x000FDFA6 File Offset: 0x000FC1A6
		[NullableContext(1)]
		public static EnterMatchInstResponse Create()
		{
			return new EnterMatchInstResponse();
		}

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x060068E1 RID: 26849 RVA: 0x000FDFAD File Offset: 0x000FC1AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x060068E2 RID: 26850 RVA: 0x000FDFB0 File Offset: 0x000FC1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterMatchInstResponse.Descriptor;
			}
		}

		// Token: 0x060068E3 RID: 26851 RVA: 0x000FDFB7 File Offset: 0x000FC1B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterMatchInstResponse()
		{
		}

		// Token: 0x060068E4 RID: 26852 RVA: 0x000FDFBF File Offset: 0x000FC1BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterMatchInstResponse(EnterMatchInstResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060068E5 RID: 26853 RVA: 0x000FDFE4 File Offset: 0x000FC1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterMatchInstResponse Clone()
		{
			return new EnterMatchInstResponse(this);
		}

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x060068E6 RID: 26854 RVA: 0x000FDFEC File Offset: 0x000FC1EC
		// (set) Token: 0x060068E7 RID: 26855 RVA: 0x000FDFF4 File Offset: 0x000FC1F4
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

		// Token: 0x060068E8 RID: 26856 RVA: 0x000FDFFD File Offset: 0x000FC1FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterMatchInstResponse);
		}

		// Token: 0x060068E9 RID: 26857 RVA: 0x000FE00B File Offset: 0x000FC20B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterMatchInstResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060068EA RID: 26858 RVA: 0x000FE03C File Offset: 0x000FC23C
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

		// Token: 0x060068EB RID: 26859 RVA: 0x000FE081 File Offset: 0x000FC281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060068EC RID: 26860 RVA: 0x000FE08E File Offset: 0x000FC28E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060068ED RID: 26861 RVA: 0x000FE097 File Offset: 0x000FC297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060068EE RID: 26862 RVA: 0x000FE0CC File Offset: 0x000FC2CC
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

		// Token: 0x060068EF RID: 26863 RVA: 0x000FE10A File Offset: 0x000FC30A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterMatchInstResponse other)
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

		// Token: 0x060068F0 RID: 26864 RVA: 0x000FE13B File Offset: 0x000FC33B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060068F1 RID: 26865 RVA: 0x000FE144 File Offset: 0x000FC344
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003A3D RID: 14909
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A3E RID: 14910
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04003A3F RID: 14911
		private ErrorCode errorCode_;
	}
}
