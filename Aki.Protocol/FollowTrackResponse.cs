using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200061A RID: 1562
	[NetMessage(EMessageId.FollowTrackResponse)]
	public sealed class FollowTrackResponse : IMessage<FollowTrackResponse>, IMessage, IEquatable<FollowTrackResponse>, IDeepCloneable<FollowTrackResponse>, IBufferMessage
	{
		// Token: 0x06009030 RID: 36912 RVA: 0x0015D0DD File Offset: 0x0015B2DD
		[NullableContext(1)]
		public static FollowTrackResponse Create()
		{
			return new FollowTrackResponse();
		}

		// Token: 0x17001CA0 RID: 7328
		// (get) Token: 0x06009031 RID: 36913 RVA: 0x0015D0E4 File Offset: 0x0015B2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CA1 RID: 7329
		// (get) Token: 0x06009032 RID: 36914 RVA: 0x0015D0E7 File Offset: 0x0015B2E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FollowTrackResponse.Descriptor;
			}
		}

		// Token: 0x06009033 RID: 36915 RVA: 0x0015D0EE File Offset: 0x0015B2EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowTrackResponse()
		{
		}

		// Token: 0x06009034 RID: 36916 RVA: 0x0015D0F6 File Offset: 0x0015B2F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowTrackResponse(FollowTrackResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009035 RID: 36917 RVA: 0x0015D11B File Offset: 0x0015B31B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowTrackResponse Clone()
		{
			return new FollowTrackResponse(this);
		}

		// Token: 0x17001CA2 RID: 7330
		// (get) Token: 0x06009036 RID: 36918 RVA: 0x0015D123 File Offset: 0x0015B323
		// (set) Token: 0x06009037 RID: 36919 RVA: 0x0015D12B File Offset: 0x0015B32B
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

		// Token: 0x06009038 RID: 36920 RVA: 0x0015D134 File Offset: 0x0015B334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FollowTrackResponse);
		}

		// Token: 0x06009039 RID: 36921 RVA: 0x0015D142 File Offset: 0x0015B342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FollowTrackResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600903A RID: 36922 RVA: 0x0015D170 File Offset: 0x0015B370
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

		// Token: 0x0600903B RID: 36923 RVA: 0x0015D1B5 File Offset: 0x0015B3B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600903C RID: 36924 RVA: 0x0015D1C2 File Offset: 0x0015B3C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600903D RID: 36925 RVA: 0x0015D1CB File Offset: 0x0015B3CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600903E RID: 36926 RVA: 0x0015D200 File Offset: 0x0015B400
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

		// Token: 0x0600903F RID: 36927 RVA: 0x0015D23E File Offset: 0x0015B43E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FollowTrackResponse other)
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

		// Token: 0x06009040 RID: 36928 RVA: 0x0015D26F File Offset: 0x0015B46F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009041 RID: 36929 RVA: 0x0015D278 File Offset: 0x0015B478
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040045D6 RID: 17878
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045D7 RID: 17879
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040045D8 RID: 17880
		private ErrorCode errorCode_;
	}
}
