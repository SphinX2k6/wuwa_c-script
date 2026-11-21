using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F81 RID: 3969
	[NetMessage(EMessageId.RoguelikeBossInstStartResponse)]
	public sealed class RoguelikeBossInstStartResponse : IMessage<RoguelikeBossInstStartResponse>, IMessage, IEquatable<RoguelikeBossInstStartResponse>, IDeepCloneable<RoguelikeBossInstStartResponse>, IBufferMessage
	{
		// Token: 0x06015417 RID: 87063 RVA: 0x003162D0 File Offset: 0x003144D0
		[NullableContext(1)]
		public static RoguelikeBossInstStartResponse Create()
		{
			return new RoguelikeBossInstStartResponse();
		}

		// Token: 0x170046D6 RID: 18134
		// (get) Token: 0x06015418 RID: 87064 RVA: 0x003162D7 File Offset: 0x003144D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046D7 RID: 18135
		// (get) Token: 0x06015419 RID: 87065 RVA: 0x003162DA File Offset: 0x003144DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeBossInstStartResponse.Descriptor;
			}
		}

		// Token: 0x0601541A RID: 87066 RVA: 0x003162E1 File Offset: 0x003144E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeBossInstStartResponse()
		{
		}

		// Token: 0x0601541B RID: 87067 RVA: 0x003162E9 File Offset: 0x003144E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeBossInstStartResponse(RoguelikeBossInstStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601541C RID: 87068 RVA: 0x0031630E File Offset: 0x0031450E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeBossInstStartResponse Clone()
		{
			return new RoguelikeBossInstStartResponse(this);
		}

		// Token: 0x170046D8 RID: 18136
		// (get) Token: 0x0601541D RID: 87069 RVA: 0x00316316 File Offset: 0x00314516
		// (set) Token: 0x0601541E RID: 87070 RVA: 0x0031631E File Offset: 0x0031451E
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

		// Token: 0x0601541F RID: 87071 RVA: 0x00316327 File Offset: 0x00314527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeBossInstStartResponse);
		}

		// Token: 0x06015420 RID: 87072 RVA: 0x00316335 File Offset: 0x00314535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeBossInstStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015421 RID: 87073 RVA: 0x00316364 File Offset: 0x00314564
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

		// Token: 0x06015422 RID: 87074 RVA: 0x003163A9 File Offset: 0x003145A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015423 RID: 87075 RVA: 0x003163B6 File Offset: 0x003145B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015424 RID: 87076 RVA: 0x003163BF File Offset: 0x003145BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015425 RID: 87077 RVA: 0x003163F4 File Offset: 0x003145F4
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

		// Token: 0x06015426 RID: 87078 RVA: 0x00316432 File Offset: 0x00314632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeBossInstStartResponse other)
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

		// Token: 0x06015427 RID: 87079 RVA: 0x00316463 File Offset: 0x00314663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015428 RID: 87080 RVA: 0x0031646C File Offset: 0x0031466C
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008061 RID: 32865
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008062 RID: 32866
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04008063 RID: 32867
		private ErrorCode errorCode_;
	}
}
