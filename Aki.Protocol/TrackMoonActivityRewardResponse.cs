using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200144F RID: 5199
	[NetMessage(EMessageId.TrackMoonActivityRewardResponse)]
	public sealed class TrackMoonActivityRewardResponse : IMessage<TrackMoonActivityRewardResponse>, IMessage, IEquatable<TrackMoonActivityRewardResponse>, IDeepCloneable<TrackMoonActivityRewardResponse>, IBufferMessage
	{
		// Token: 0x0601B9D6 RID: 113110 RVA: 0x00403190 File Offset: 0x00401390
		[NullableContext(1)]
		public static TrackMoonActivityRewardResponse Create()
		{
			return new TrackMoonActivityRewardResponse();
		}

		// Token: 0x17005D77 RID: 23927
		// (get) Token: 0x0601B9D7 RID: 113111 RVA: 0x00403197 File Offset: 0x00401397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D78 RID: 23928
		// (get) Token: 0x0601B9D8 RID: 113112 RVA: 0x0040319A File Offset: 0x0040139A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonActivityRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601B9D9 RID: 113113 RVA: 0x004031A1 File Offset: 0x004013A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonActivityRewardResponse()
		{
		}

		// Token: 0x0601B9DA RID: 113114 RVA: 0x004031A9 File Offset: 0x004013A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonActivityRewardResponse(TrackMoonActivityRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B9DB RID: 113115 RVA: 0x004031CE File Offset: 0x004013CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonActivityRewardResponse Clone()
		{
			return new TrackMoonActivityRewardResponse(this);
		}

		// Token: 0x17005D79 RID: 23929
		// (get) Token: 0x0601B9DC RID: 113116 RVA: 0x004031D6 File Offset: 0x004013D6
		// (set) Token: 0x0601B9DD RID: 113117 RVA: 0x004031DE File Offset: 0x004013DE
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

		// Token: 0x0601B9DE RID: 113118 RVA: 0x004031E7 File Offset: 0x004013E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonActivityRewardResponse);
		}

		// Token: 0x0601B9DF RID: 113119 RVA: 0x004031F5 File Offset: 0x004013F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonActivityRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B9E0 RID: 113120 RVA: 0x00403224 File Offset: 0x00401424
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

		// Token: 0x0601B9E1 RID: 113121 RVA: 0x00403269 File Offset: 0x00401469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B9E2 RID: 113122 RVA: 0x00403276 File Offset: 0x00401476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B9E3 RID: 113123 RVA: 0x0040327F File Offset: 0x0040147F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B9E4 RID: 113124 RVA: 0x004032B4 File Offset: 0x004014B4
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

		// Token: 0x0601B9E5 RID: 113125 RVA: 0x004032F2 File Offset: 0x004014F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonActivityRewardResponse other)
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

		// Token: 0x0601B9E6 RID: 113126 RVA: 0x00403323 File Offset: 0x00401523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B9E7 RID: 113127 RVA: 0x0040332C File Offset: 0x0040152C
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A07C RID: 41084
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A07D RID: 41085
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x0400A07E RID: 41086
		private ErrorCode errorCode_;
	}
}
