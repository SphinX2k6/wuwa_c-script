using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000908 RID: 2312
	[NetMessage(EMessageId.LevelPlayRewardResponse)]
	public sealed class LevelPlayRewardResponse : IMessage<LevelPlayRewardResponse>, IMessage, IEquatable<LevelPlayRewardResponse>, IDeepCloneable<LevelPlayRewardResponse>, IBufferMessage
	{
		// Token: 0x0600CC24 RID: 52260 RVA: 0x001E17E4 File Offset: 0x001DF9E4
		[NullableContext(1)]
		public static LevelPlayRewardResponse Create()
		{
			return new LevelPlayRewardResponse();
		}

		// Token: 0x17002937 RID: 10551
		// (get) Token: 0x0600CC25 RID: 52261 RVA: 0x001E17EB File Offset: 0x001DF9EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002938 RID: 10552
		// (get) Token: 0x0600CC26 RID: 52262 RVA: 0x001E17EE File Offset: 0x001DF9EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600CC27 RID: 52263 RVA: 0x001E17F5 File Offset: 0x001DF9F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardResponse()
		{
		}

		// Token: 0x0600CC28 RID: 52264 RVA: 0x001E17FD File Offset: 0x001DF9FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardResponse(LevelPlayRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CC29 RID: 52265 RVA: 0x001E1822 File Offset: 0x001DFA22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardResponse Clone()
		{
			return new LevelPlayRewardResponse(this);
		}

		// Token: 0x17002939 RID: 10553
		// (get) Token: 0x0600CC2A RID: 52266 RVA: 0x001E182A File Offset: 0x001DFA2A
		// (set) Token: 0x0600CC2B RID: 52267 RVA: 0x001E1832 File Offset: 0x001DFA32
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

		// Token: 0x0600CC2C RID: 52268 RVA: 0x001E183B File Offset: 0x001DFA3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayRewardResponse);
		}

		// Token: 0x0600CC2D RID: 52269 RVA: 0x001E1849 File Offset: 0x001DFA49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CC2E RID: 52270 RVA: 0x001E1878 File Offset: 0x001DFA78
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

		// Token: 0x0600CC2F RID: 52271 RVA: 0x001E18BD File Offset: 0x001DFABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CC30 RID: 52272 RVA: 0x001E18CA File Offset: 0x001DFACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CC31 RID: 52273 RVA: 0x001E18D3 File Offset: 0x001DFAD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CC32 RID: 52274 RVA: 0x001E1908 File Offset: 0x001DFB08
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

		// Token: 0x0600CC33 RID: 52275 RVA: 0x001E1946 File Offset: 0x001DFB46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayRewardResponse other)
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

		// Token: 0x0600CC34 RID: 52276 RVA: 0x001E1977 File Offset: 0x001DFB77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CC35 RID: 52277 RVA: 0x001E1980 File Offset: 0x001DFB80
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005695 RID: 22165
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005696 RID: 22166
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04005697 RID: 22167
		private ErrorCode errorCode_;
	}
}
