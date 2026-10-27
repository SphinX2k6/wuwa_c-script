using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010E5 RID: 4325
	[NetMessage(EMessageId.RollBlockResetGamePlayResponse)]
	public sealed class RollBlockResetGamePlayResponse : IMessage<RollBlockResetGamePlayResponse>, IMessage, IEquatable<RollBlockResetGamePlayResponse>, IDeepCloneable<RollBlockResetGamePlayResponse>, IBufferMessage
	{
		// Token: 0x06017117 RID: 94487 RVA: 0x00358FC9 File Offset: 0x003571C9
		[NullableContext(1)]
		public static RollBlockResetGamePlayResponse Create()
		{
			return new RollBlockResetGamePlayResponse();
		}

		// Token: 0x17004D44 RID: 19780
		// (get) Token: 0x06017118 RID: 94488 RVA: 0x00358FD0 File Offset: 0x003571D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D45 RID: 19781
		// (get) Token: 0x06017119 RID: 94489 RVA: 0x00358FD3 File Offset: 0x003571D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockResetGamePlayResponse.Descriptor;
			}
		}

		// Token: 0x0601711A RID: 94490 RVA: 0x00358FDA File Offset: 0x003571DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockResetGamePlayResponse()
		{
		}

		// Token: 0x0601711B RID: 94491 RVA: 0x00358FE2 File Offset: 0x003571E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockResetGamePlayResponse(RollBlockResetGamePlayResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601711C RID: 94492 RVA: 0x00359007 File Offset: 0x00357207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockResetGamePlayResponse Clone()
		{
			return new RollBlockResetGamePlayResponse(this);
		}

		// Token: 0x17004D46 RID: 19782
		// (get) Token: 0x0601711D RID: 94493 RVA: 0x0035900F File Offset: 0x0035720F
		// (set) Token: 0x0601711E RID: 94494 RVA: 0x00359017 File Offset: 0x00357217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x0601711F RID: 94495 RVA: 0x00359020 File Offset: 0x00357220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockResetGamePlayResponse);
		}

		// Token: 0x06017120 RID: 94496 RVA: 0x0035902E File Offset: 0x0035722E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockResetGamePlayResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017121 RID: 94497 RVA: 0x0035905C File Offset: 0x0035725C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017122 RID: 94498 RVA: 0x003590A1 File Offset: 0x003572A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017123 RID: 94499 RVA: 0x003590AE File Offset: 0x003572AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017124 RID: 94500 RVA: 0x003590B7 File Offset: 0x003572B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017125 RID: 94501 RVA: 0x003590EC File Offset: 0x003572EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017126 RID: 94502 RVA: 0x0035912A File Offset: 0x0035732A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockResetGamePlayResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017127 RID: 94503 RVA: 0x0035915B File Offset: 0x0035735B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017128 RID: 94504 RVA: 0x00359164 File Offset: 0x00357364
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
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400893D RID: 35133
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400893E RID: 35134
		public const int CodeFieldNumber = 5;

		// Token: 0x0400893F RID: 35135
		private ErrorCode code_;
	}
}
