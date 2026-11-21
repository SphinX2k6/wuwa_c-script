using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009D0 RID: 2512
	[NetMessage(EMessageId.MixDrinkTopicSelectResponse)]
	public sealed class MixDrinkTopicSelectResponse : IMessage<MixDrinkTopicSelectResponse>, IMessage, IEquatable<MixDrinkTopicSelectResponse>, IDeepCloneable<MixDrinkTopicSelectResponse>, IBufferMessage
	{
		// Token: 0x0600DC81 RID: 56449 RVA: 0x00205F69 File Offset: 0x00204169
		[NullableContext(1)]
		public static MixDrinkTopicSelectResponse Create()
		{
			return new MixDrinkTopicSelectResponse();
		}

		// Token: 0x17002CAB RID: 11435
		// (get) Token: 0x0600DC82 RID: 56450 RVA: 0x00205F70 File Offset: 0x00204170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CAC RID: 11436
		// (get) Token: 0x0600DC83 RID: 56451 RVA: 0x00205F73 File Offset: 0x00204173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MixDrinkTopicSelectResponse.Descriptor;
			}
		}

		// Token: 0x0600DC84 RID: 56452 RVA: 0x00205F7A File Offset: 0x0020417A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkTopicSelectResponse()
		{
		}

		// Token: 0x0600DC85 RID: 56453 RVA: 0x00205F82 File Offset: 0x00204182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkTopicSelectResponse(MixDrinkTopicSelectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DC86 RID: 56454 RVA: 0x00205FA7 File Offset: 0x002041A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkTopicSelectResponse Clone()
		{
			return new MixDrinkTopicSelectResponse(this);
		}

		// Token: 0x17002CAD RID: 11437
		// (get) Token: 0x0600DC87 RID: 56455 RVA: 0x00205FAF File Offset: 0x002041AF
		// (set) Token: 0x0600DC88 RID: 56456 RVA: 0x00205FB7 File Offset: 0x002041B7
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

		// Token: 0x0600DC89 RID: 56457 RVA: 0x00205FC0 File Offset: 0x002041C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MixDrinkTopicSelectResponse);
		}

		// Token: 0x0600DC8A RID: 56458 RVA: 0x00205FCE File Offset: 0x002041CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MixDrinkTopicSelectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DC8B RID: 56459 RVA: 0x00205FFC File Offset: 0x002041FC
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

		// Token: 0x0600DC8C RID: 56460 RVA: 0x00206041 File Offset: 0x00204241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DC8D RID: 56461 RVA: 0x0020604E File Offset: 0x0020424E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DC8E RID: 56462 RVA: 0x00206057 File Offset: 0x00204257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DC8F RID: 56463 RVA: 0x0020608C File Offset: 0x0020428C
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

		// Token: 0x0600DC90 RID: 56464 RVA: 0x002060CA File Offset: 0x002042CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MixDrinkTopicSelectResponse other)
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

		// Token: 0x0600DC91 RID: 56465 RVA: 0x002060FB File Offset: 0x002042FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DC92 RID: 56466 RVA: 0x00206104 File Offset: 0x00204304
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005BA4 RID: 23460
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BA5 RID: 23461
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04005BA6 RID: 23462
		private ErrorCode errorCode_;
	}
}
