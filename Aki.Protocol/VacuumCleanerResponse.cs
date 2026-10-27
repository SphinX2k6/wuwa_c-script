using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014BF RID: 5311
	[NetMessage(EMessageId.VacuumCleanerResponse)]
	public sealed class VacuumCleanerResponse : IMessage<VacuumCleanerResponse>, IMessage, IEquatable<VacuumCleanerResponse>, IDeepCloneable<VacuumCleanerResponse>, IBufferMessage
	{
		// Token: 0x0601C165 RID: 115045 RVA: 0x0040F889 File Offset: 0x0040DA89
		[NullableContext(1)]
		public static VacuumCleanerResponse Create()
		{
			return new VacuumCleanerResponse();
		}

		// Token: 0x17005EAD RID: 24237
		// (get) Token: 0x0601C166 RID: 115046 RVA: 0x0040F890 File Offset: 0x0040DA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EAE RID: 24238
		// (get) Token: 0x0601C167 RID: 115047 RVA: 0x0040F893 File Offset: 0x0040DA93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VacuumCleanerResponse.Descriptor;
			}
		}

		// Token: 0x0601C168 RID: 115048 RVA: 0x0040F89A File Offset: 0x0040DA9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VacuumCleanerResponse()
		{
		}

		// Token: 0x0601C169 RID: 115049 RVA: 0x0040F8A2 File Offset: 0x0040DAA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VacuumCleanerResponse(VacuumCleanerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C16A RID: 115050 RVA: 0x0040F8C7 File Offset: 0x0040DAC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VacuumCleanerResponse Clone()
		{
			return new VacuumCleanerResponse(this);
		}

		// Token: 0x17005EAF RID: 24239
		// (get) Token: 0x0601C16B RID: 115051 RVA: 0x0040F8CF File Offset: 0x0040DACF
		// (set) Token: 0x0601C16C RID: 115052 RVA: 0x0040F8D7 File Offset: 0x0040DAD7
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

		// Token: 0x0601C16D RID: 115053 RVA: 0x0040F8E0 File Offset: 0x0040DAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VacuumCleanerResponse);
		}

		// Token: 0x0601C16E RID: 115054 RVA: 0x0040F8EE File Offset: 0x0040DAEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VacuumCleanerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C16F RID: 115055 RVA: 0x0040F91C File Offset: 0x0040DB1C
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

		// Token: 0x0601C170 RID: 115056 RVA: 0x0040F961 File Offset: 0x0040DB61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C171 RID: 115057 RVA: 0x0040F96E File Offset: 0x0040DB6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C172 RID: 115058 RVA: 0x0040F977 File Offset: 0x0040DB77
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

		// Token: 0x0601C173 RID: 115059 RVA: 0x0040F9AC File Offset: 0x0040DBAC
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

		// Token: 0x0601C174 RID: 115060 RVA: 0x0040F9EA File Offset: 0x0040DBEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VacuumCleanerResponse other)
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

		// Token: 0x0601C175 RID: 115061 RVA: 0x0040FA1B File Offset: 0x0040DC1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C176 RID: 115062 RVA: 0x0040FA24 File Offset: 0x0040DC24
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

		// Token: 0x0400A149 RID: 41289
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A14A RID: 41290
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400A14B RID: 41291
		private ErrorCode errorCode_;
	}
}
