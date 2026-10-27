using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200011E RID: 286
	[NetMessage(EMessageId.AtomicProcessTeleportResponse)]
	public sealed class AtomicProcessTeleportResponse : IMessage<AtomicProcessTeleportResponse>, IMessage, IEquatable<AtomicProcessTeleportResponse>, IDeepCloneable<AtomicProcessTeleportResponse>, IBufferMessage
	{
		// Token: 0x060026BB RID: 9915 RVA: 0x00066D54 File Offset: 0x00064F54
		[NullableContext(1)]
		public static AtomicProcessTeleportResponse Create()
		{
			return new AtomicProcessTeleportResponse();
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060026BC RID: 9916 RVA: 0x00066D5B File Offset: 0x00064F5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x060026BD RID: 9917 RVA: 0x00066D5E File Offset: 0x00064F5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AtomicProcessTeleportResponse.Descriptor;
			}
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x00066D65 File Offset: 0x00064F65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessTeleportResponse()
		{
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x00066D6D File Offset: 0x00064F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessTeleportResponse(AtomicProcessTeleportResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x00066D92 File Offset: 0x00064F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessTeleportResponse Clone()
		{
			return new AtomicProcessTeleportResponse(this);
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x060026C1 RID: 9921 RVA: 0x00066D9A File Offset: 0x00064F9A
		// (set) Token: 0x060026C2 RID: 9922 RVA: 0x00066DA2 File Offset: 0x00064FA2
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

		// Token: 0x060026C3 RID: 9923 RVA: 0x00066DAB File Offset: 0x00064FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AtomicProcessTeleportResponse);
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x00066DB9 File Offset: 0x00064FB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AtomicProcessTeleportResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x00066DE8 File Offset: 0x00064FE8
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

		// Token: 0x060026C6 RID: 9926 RVA: 0x00066E2D File Offset: 0x0006502D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x00066E3A File Offset: 0x0006503A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x00066E43 File Offset: 0x00065043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x00066E78 File Offset: 0x00065078
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

		// Token: 0x060026CA RID: 9930 RVA: 0x00066EB6 File Offset: 0x000650B6
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

		// Token: 0x060026CB RID: 9931 RVA: 0x00066EE7 File Offset: 0x000650E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x00066EF0 File Offset: 0x000650F0
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
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002630 RID: 9776
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002631 RID: 9777
		public const int ErrorIdFieldNumber = 3;

		// Token: 0x04002632 RID: 9778
		private ErrorCode errorId_;
	}
}
