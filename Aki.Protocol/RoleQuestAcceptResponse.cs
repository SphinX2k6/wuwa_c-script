using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001091 RID: 4241
	[NetMessage(EMessageId.RoleQuestAcceptResponse)]
	public sealed class RoleQuestAcceptResponse : IMessage<RoleQuestAcceptResponse>, IMessage, IEquatable<RoleQuestAcceptResponse>, IDeepCloneable<RoleQuestAcceptResponse>, IBufferMessage
	{
		// Token: 0x06016AE1 RID: 92897 RVA: 0x0034C7BD File Offset: 0x0034A9BD
		[NullableContext(1)]
		public static RoleQuestAcceptResponse Create()
		{
			return new RoleQuestAcceptResponse();
		}

		// Token: 0x17004C04 RID: 19460
		// (get) Token: 0x06016AE2 RID: 92898 RVA: 0x0034C7C4 File Offset: 0x0034A9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C05 RID: 19461
		// (get) Token: 0x06016AE3 RID: 92899 RVA: 0x0034C7C7 File Offset: 0x0034A9C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleQuestAcceptResponse.Descriptor;
			}
		}

		// Token: 0x06016AE4 RID: 92900 RVA: 0x0034C7CE File Offset: 0x0034A9CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestAcceptResponse()
		{
		}

		// Token: 0x06016AE5 RID: 92901 RVA: 0x0034C7D6 File Offset: 0x0034A9D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestAcceptResponse(RoleQuestAcceptResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016AE6 RID: 92902 RVA: 0x0034C7FB File Offset: 0x0034A9FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestAcceptResponse Clone()
		{
			return new RoleQuestAcceptResponse(this);
		}

		// Token: 0x17004C06 RID: 19462
		// (get) Token: 0x06016AE7 RID: 92903 RVA: 0x0034C803 File Offset: 0x0034AA03
		// (set) Token: 0x06016AE8 RID: 92904 RVA: 0x0034C80B File Offset: 0x0034AA0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x06016AE9 RID: 92905 RVA: 0x0034C814 File Offset: 0x0034AA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleQuestAcceptResponse);
		}

		// Token: 0x06016AEA RID: 92906 RVA: 0x0034C822 File Offset: 0x0034AA22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleQuestAcceptResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016AEB RID: 92907 RVA: 0x0034C850 File Offset: 0x0034AA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016AEC RID: 92908 RVA: 0x0034C895 File Offset: 0x0034AA95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016AED RID: 92909 RVA: 0x0034C8A2 File Offset: 0x0034AAA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016AEE RID: 92910 RVA: 0x0034C8AB File Offset: 0x0034AAAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016AEF RID: 92911 RVA: 0x0034C8E0 File Offset: 0x0034AAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016AF0 RID: 92912 RVA: 0x0034C91E File Offset: 0x0034AB1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleQuestAcceptResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016AF1 RID: 92913 RVA: 0x0034C94F File Offset: 0x0034AB4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016AF2 RID: 92914 RVA: 0x0034C958 File Offset: 0x0034AB58
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
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040087F7 RID: 34807
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087F8 RID: 34808
		public const int ErrorIdFieldNumber = 9;

		// Token: 0x040087F9 RID: 34809
		private ErrorCode errorId_;
	}
}
