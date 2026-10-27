using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000432 RID: 1074
	[NetMessage(EMessageId.ElevatorStateChangeResponse)]
	public sealed class ElevatorStateChangeResponse : IMessage<ElevatorStateChangeResponse>, IMessage, IEquatable<ElevatorStateChangeResponse>, IDeepCloneable<ElevatorStateChangeResponse>, IBufferMessage
	{
		// Token: 0x06006701 RID: 26369 RVA: 0x000F7913 File Offset: 0x000F5B13
		[NullableContext(1)]
		public static ElevatorStateChangeResponse Create()
		{
			return new ElevatorStateChangeResponse();
		}

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x06006702 RID: 26370 RVA: 0x000F791A File Offset: 0x000F5B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x06006703 RID: 26371 RVA: 0x000F791D File Offset: 0x000F5B1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ElevatorStateChangeResponse.Descriptor;
			}
		}

		// Token: 0x06006704 RID: 26372 RVA: 0x000F7924 File Offset: 0x000F5B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElevatorStateChangeResponse()
		{
		}

		// Token: 0x06006705 RID: 26373 RVA: 0x000F792C File Offset: 0x000F5B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElevatorStateChangeResponse(ElevatorStateChangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006706 RID: 26374 RVA: 0x000F7951 File Offset: 0x000F5B51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElevatorStateChangeResponse Clone()
		{
			return new ElevatorStateChangeResponse(this);
		}

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x06006707 RID: 26375 RVA: 0x000F7959 File Offset: 0x000F5B59
		// (set) Token: 0x06006708 RID: 26376 RVA: 0x000F7961 File Offset: 0x000F5B61
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

		// Token: 0x06006709 RID: 26377 RVA: 0x000F796A File Offset: 0x000F5B6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ElevatorStateChangeResponse);
		}

		// Token: 0x0600670A RID: 26378 RVA: 0x000F7978 File Offset: 0x000F5B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ElevatorStateChangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600670B RID: 26379 RVA: 0x000F79A8 File Offset: 0x000F5BA8
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

		// Token: 0x0600670C RID: 26380 RVA: 0x000F79ED File Offset: 0x000F5BED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600670D RID: 26381 RVA: 0x000F79FA File Offset: 0x000F5BFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600670E RID: 26382 RVA: 0x000F7A03 File Offset: 0x000F5C03
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

		// Token: 0x0600670F RID: 26383 RVA: 0x000F7A38 File Offset: 0x000F5C38
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

		// Token: 0x06006710 RID: 26384 RVA: 0x000F7A76 File Offset: 0x000F5C76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ElevatorStateChangeResponse other)
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

		// Token: 0x06006711 RID: 26385 RVA: 0x000F7AA7 File Offset: 0x000F5CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006712 RID: 26386 RVA: 0x000F7AB0 File Offset: 0x000F5CB0
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

		// Token: 0x04003949 RID: 14665
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400394A RID: 14666
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400394B RID: 14667
		private ErrorCode errorCode_;
	}
}
