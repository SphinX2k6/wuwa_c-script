using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010A1 RID: 4257
	[NetMessage(EMessageId.RoleQuestAcceptResponse)]
	public sealed class RoleQuestAcceptResponse : IMessage<RoleQuestAcceptResponse>, IMessage, IEquatable<RoleQuestAcceptResponse>, IDeepCloneable<RoleQuestAcceptResponse>, IBufferMessage
	{
		// Token: 0x06016BC6 RID: 93126 RVA: 0x0034DE99 File Offset: 0x0034C099
		[NullableContext(1)]
		public static RoleQuestAcceptResponse Create()
		{
			return new RoleQuestAcceptResponse();
		}

		// Token: 0x17004C2E RID: 19502
		// (get) Token: 0x06016BC7 RID: 93127 RVA: 0x0034DEA0 File Offset: 0x0034C0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C2F RID: 19503
		// (get) Token: 0x06016BC8 RID: 93128 RVA: 0x0034DEA3 File Offset: 0x0034C0A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleQuestAcceptResponse.Descriptor;
			}
		}

		// Token: 0x06016BC9 RID: 93129 RVA: 0x0034DEAA File Offset: 0x0034C0AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestAcceptResponse()
		{
		}

		// Token: 0x06016BCA RID: 93130 RVA: 0x0034DEB2 File Offset: 0x0034C0B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestAcceptResponse(RoleQuestAcceptResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016BCB RID: 93131 RVA: 0x0034DED7 File Offset: 0x0034C0D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestAcceptResponse Clone()
		{
			return new RoleQuestAcceptResponse(this);
		}

		// Token: 0x17004C30 RID: 19504
		// (get) Token: 0x06016BCC RID: 93132 RVA: 0x0034DEDF File Offset: 0x0034C0DF
		// (set) Token: 0x06016BCD RID: 93133 RVA: 0x0034DEE7 File Offset: 0x0034C0E7
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

		// Token: 0x06016BCE RID: 93134 RVA: 0x0034DEF0 File Offset: 0x0034C0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleQuestAcceptResponse);
		}

		// Token: 0x06016BCF RID: 93135 RVA: 0x0034DEFE File Offset: 0x0034C0FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleQuestAcceptResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016BD0 RID: 93136 RVA: 0x0034DF2C File Offset: 0x0034C12C
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

		// Token: 0x06016BD1 RID: 93137 RVA: 0x0034DF71 File Offset: 0x0034C171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016BD2 RID: 93138 RVA: 0x0034DF7E File Offset: 0x0034C17E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016BD3 RID: 93139 RVA: 0x0034DF87 File Offset: 0x0034C187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016BD4 RID: 93140 RVA: 0x0034DFBC File Offset: 0x0034C1BC
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

		// Token: 0x06016BD5 RID: 93141 RVA: 0x0034DFFA File Offset: 0x0034C1FA
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

		// Token: 0x06016BD6 RID: 93142 RVA: 0x0034E02B File Offset: 0x0034C22B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016BD7 RID: 93143 RVA: 0x0034E034 File Offset: 0x0034C234
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040087CD RID: 34765
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087CE RID: 34766
		public const int ErrorIdFieldNumber = 15;

		// Token: 0x040087CF RID: 34767
		private ErrorCode errorId_;
	}
}
