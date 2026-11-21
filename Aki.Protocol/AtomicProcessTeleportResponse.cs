using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000120 RID: 288
	[NetMessage(EMessageId.AtomicProcessTeleportResponse)]
	public sealed class AtomicProcessTeleportResponse : IMessage<AtomicProcessTeleportResponse>, IMessage, IEquatable<AtomicProcessTeleportResponse>, IDeepCloneable<AtomicProcessTeleportResponse>, IBufferMessage
	{
		// Token: 0x0600271A RID: 10010 RVA: 0x00067D78 File Offset: 0x00065F78
		[NullableContext(1)]
		public static AtomicProcessTeleportResponse Create()
		{
			return new AtomicProcessTeleportResponse();
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x0600271B RID: 10011 RVA: 0x00067D7F File Offset: 0x00065F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x0600271C RID: 10012 RVA: 0x00067D82 File Offset: 0x00065F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AtomicProcessTeleportResponse.Descriptor;
			}
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x00067D89 File Offset: 0x00065F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessTeleportResponse()
		{
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x00067D91 File Offset: 0x00065F91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessTeleportResponse(AtomicProcessTeleportResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x00067DB6 File Offset: 0x00065FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessTeleportResponse Clone()
		{
			return new AtomicProcessTeleportResponse(this);
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06002720 RID: 10016 RVA: 0x00067DBE File Offset: 0x00065FBE
		// (set) Token: 0x06002721 RID: 10017 RVA: 0x00067DC6 File Offset: 0x00065FC6
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

		// Token: 0x06002722 RID: 10018 RVA: 0x00067DCF File Offset: 0x00065FCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AtomicProcessTeleportResponse);
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x00067DDD File Offset: 0x00065FDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AtomicProcessTeleportResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x00067E0C File Offset: 0x0006600C
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

		// Token: 0x06002725 RID: 10021 RVA: 0x00067E51 File Offset: 0x00066051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x00067E5E File Offset: 0x0006605E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x00067E67 File Offset: 0x00066067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x00067E9C File Offset: 0x0006609C
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

		// Token: 0x06002729 RID: 10025 RVA: 0x00067EDA File Offset: 0x000660DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AtomicProcessTeleportResponse other)
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

		// Token: 0x0600272A RID: 10026 RVA: 0x00067F0B File Offset: 0x0006610B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x00067F14 File Offset: 0x00066114
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
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400269B RID: 9883
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400269C RID: 9884
		public const int ErrorIdFieldNumber = 10;

		// Token: 0x0400269D RID: 9885
		private ErrorCode errorId_;
	}
}
