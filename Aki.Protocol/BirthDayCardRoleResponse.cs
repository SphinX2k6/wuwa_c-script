using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200019D RID: 413
	[NetMessage(EMessageId.BirthDayCardRoleResponse)]
	public sealed class BirthDayCardRoleResponse : IMessage<BirthDayCardRoleResponse>, IMessage, IEquatable<BirthDayCardRoleResponse>, IDeepCloneable<BirthDayCardRoleResponse>, IBufferMessage
	{
		// Token: 0x06003102 RID: 12546 RVA: 0x0007D250 File Offset: 0x0007B450
		[NullableContext(1)]
		public static BirthDayCardRoleResponse Create()
		{
			return new BirthDayCardRoleResponse();
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06003103 RID: 12547 RVA: 0x0007D257 File Offset: 0x0007B457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06003104 RID: 12548 RVA: 0x0007D25A File Offset: 0x0007B45A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BirthDayCardRoleResponse.Descriptor;
			}
		}

		// Token: 0x06003105 RID: 12549 RVA: 0x0007D261 File Offset: 0x0007B461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayCardRoleResponse()
		{
		}

		// Token: 0x06003106 RID: 12550 RVA: 0x0007D269 File Offset: 0x0007B469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayCardRoleResponse(BirthDayCardRoleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003107 RID: 12551 RVA: 0x0007D28E File Offset: 0x0007B48E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayCardRoleResponse Clone()
		{
			return new BirthDayCardRoleResponse(this);
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06003108 RID: 12552 RVA: 0x0007D296 File Offset: 0x0007B496
		// (set) Token: 0x06003109 RID: 12553 RVA: 0x0007D29E File Offset: 0x0007B49E
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

		// Token: 0x0600310A RID: 12554 RVA: 0x0007D2A7 File Offset: 0x0007B4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BirthDayCardRoleResponse);
		}

		// Token: 0x0600310B RID: 12555 RVA: 0x0007D2B5 File Offset: 0x0007B4B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BirthDayCardRoleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600310C RID: 12556 RVA: 0x0007D2E4 File Offset: 0x0007B4E4
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

		// Token: 0x0600310D RID: 12557 RVA: 0x0007D329 File Offset: 0x0007B529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600310E RID: 12558 RVA: 0x0007D336 File Offset: 0x0007B536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600310F RID: 12559 RVA: 0x0007D33F File Offset: 0x0007B53F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003110 RID: 12560 RVA: 0x0007D374 File Offset: 0x0007B574
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

		// Token: 0x06003111 RID: 12561 RVA: 0x0007D3B2 File Offset: 0x0007B5B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BirthDayCardRoleResponse other)
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

		// Token: 0x06003112 RID: 12562 RVA: 0x0007D3E3 File Offset: 0x0007B5E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003113 RID: 12563 RVA: 0x0007D3EC File Offset: 0x0007B5EC
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002970 RID: 10608
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002971 RID: 10609
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04002972 RID: 10610
		private ErrorCode errorCode_;
	}
}
