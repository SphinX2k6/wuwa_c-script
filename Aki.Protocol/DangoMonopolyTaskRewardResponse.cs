using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000393 RID: 915
	[NetMessage(EMessageId.DangoMonopolyTaskRewardResponse)]
	public sealed class DangoMonopolyTaskRewardResponse : IMessage<DangoMonopolyTaskRewardResponse>, IMessage, IEquatable<DangoMonopolyTaskRewardResponse>, IDeepCloneable<DangoMonopolyTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x06005A57 RID: 23127 RVA: 0x000DBDD8 File Offset: 0x000D9FD8
		[NullableContext(1)]
		public static DangoMonopolyTaskRewardResponse Create()
		{
			return new DangoMonopolyTaskRewardResponse();
		}

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x06005A58 RID: 23128 RVA: 0x000DBDDF File Offset: 0x000D9FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x06005A59 RID: 23129 RVA: 0x000DBDE2 File Offset: 0x000D9FE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x06005A5A RID: 23130 RVA: 0x000DBDE9 File Offset: 0x000D9FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskRewardResponse()
		{
		}

		// Token: 0x06005A5B RID: 23131 RVA: 0x000DBDF1 File Offset: 0x000D9FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskRewardResponse(DangoMonopolyTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A5C RID: 23132 RVA: 0x000DBE16 File Offset: 0x000DA016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskRewardResponse Clone()
		{
			return new DangoMonopolyTaskRewardResponse(this);
		}

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x06005A5D RID: 23133 RVA: 0x000DBE1E File Offset: 0x000DA01E
		// (set) Token: 0x06005A5E RID: 23134 RVA: 0x000DBE26 File Offset: 0x000DA026
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

		// Token: 0x06005A5F RID: 23135 RVA: 0x000DBE2F File Offset: 0x000DA02F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyTaskRewardResponse);
		}

		// Token: 0x06005A60 RID: 23136 RVA: 0x000DBE3D File Offset: 0x000DA03D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005A61 RID: 23137 RVA: 0x000DBE6C File Offset: 0x000DA06C
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

		// Token: 0x06005A62 RID: 23138 RVA: 0x000DBEB1 File Offset: 0x000DA0B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005A63 RID: 23139 RVA: 0x000DBEBE File Offset: 0x000DA0BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A64 RID: 23140 RVA: 0x000DBEC7 File Offset: 0x000DA0C7
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

		// Token: 0x06005A65 RID: 23141 RVA: 0x000DBEFC File Offset: 0x000DA0FC
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

		// Token: 0x06005A66 RID: 23142 RVA: 0x000DBF3A File Offset: 0x000DA13A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyTaskRewardResponse other)
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

		// Token: 0x06005A67 RID: 23143 RVA: 0x000DBF6B File Offset: 0x000DA16B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A68 RID: 23144 RVA: 0x000DBF74 File Offset: 0x000DA174
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

		// Token: 0x040035AE RID: 13742
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035AF RID: 13743
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040035B0 RID: 13744
		private ErrorCode errorCode_;
	}
}
