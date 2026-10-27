using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001490 RID: 5264
	[NetMessage(EMessageId.UnOpenedAreaPullbackResponse)]
	public sealed class UnOpenedAreaPullbackResponse : IMessage<UnOpenedAreaPullbackResponse>, IMessage, IEquatable<UnOpenedAreaPullbackResponse>, IDeepCloneable<UnOpenedAreaPullbackResponse>, IBufferMessage
	{
		// Token: 0x0601BD9D RID: 114077 RVA: 0x00406F0C File Offset: 0x0040510C
		[NullableContext(1)]
		public static UnOpenedAreaPullbackResponse Create()
		{
			return new UnOpenedAreaPullbackResponse();
		}

		// Token: 0x17005DE2 RID: 24034
		// (get) Token: 0x0601BD9E RID: 114078 RVA: 0x00406F13 File Offset: 0x00405113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DE3 RID: 24035
		// (get) Token: 0x0601BD9F RID: 114079 RVA: 0x00406F16 File Offset: 0x00405116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnOpenedAreaPullbackResponse.Descriptor;
			}
		}

		// Token: 0x0601BDA0 RID: 114080 RVA: 0x00406F1D File Offset: 0x0040511D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnOpenedAreaPullbackResponse()
		{
		}

		// Token: 0x0601BDA1 RID: 114081 RVA: 0x00406F25 File Offset: 0x00405125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnOpenedAreaPullbackResponse(UnOpenedAreaPullbackResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BDA2 RID: 114082 RVA: 0x00406F4A File Offset: 0x0040514A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnOpenedAreaPullbackResponse Clone()
		{
			return new UnOpenedAreaPullbackResponse(this);
		}

		// Token: 0x17005DE4 RID: 24036
		// (get) Token: 0x0601BDA3 RID: 114083 RVA: 0x00406F52 File Offset: 0x00405152
		// (set) Token: 0x0601BDA4 RID: 114084 RVA: 0x00406F5A File Offset: 0x0040515A
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

		// Token: 0x0601BDA5 RID: 114085 RVA: 0x00406F63 File Offset: 0x00405163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnOpenedAreaPullbackResponse);
		}

		// Token: 0x0601BDA6 RID: 114086 RVA: 0x00406F71 File Offset: 0x00405171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnOpenedAreaPullbackResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BDA7 RID: 114087 RVA: 0x00406FA0 File Offset: 0x004051A0
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

		// Token: 0x0601BDA8 RID: 114088 RVA: 0x00406FE5 File Offset: 0x004051E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BDA9 RID: 114089 RVA: 0x00406FF2 File Offset: 0x004051F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BDAA RID: 114090 RVA: 0x00406FFB File Offset: 0x004051FB
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

		// Token: 0x0601BDAB RID: 114091 RVA: 0x00407030 File Offset: 0x00405230
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

		// Token: 0x0601BDAC RID: 114092 RVA: 0x0040706E File Offset: 0x0040526E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnOpenedAreaPullbackResponse other)
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

		// Token: 0x0601BDAD RID: 114093 RVA: 0x0040709F File Offset: 0x0040529F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BDAE RID: 114094 RVA: 0x004070A8 File Offset: 0x004052A8
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

		// Token: 0x0400A02C RID: 41004
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A02D RID: 41005
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400A02E RID: 41006
		private ErrorCode errorCode_;
	}
}
