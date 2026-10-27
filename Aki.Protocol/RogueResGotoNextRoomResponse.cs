using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FE3 RID: 4067
	[NetMessage(EMessageId.RogueResGotoNextRoomResponse)]
	public sealed class RogueResGotoNextRoomResponse : IMessage<RogueResGotoNextRoomResponse>, IMessage, IEquatable<RogueResGotoNextRoomResponse>, IDeepCloneable<RogueResGotoNextRoomResponse>, IBufferMessage
	{
		// Token: 0x06015BC1 RID: 89025 RVA: 0x00327B62 File Offset: 0x00325D62
		[NullableContext(1)]
		public static RogueResGotoNextRoomResponse Create()
		{
			return new RogueResGotoNextRoomResponse();
		}

		// Token: 0x17004880 RID: 18560
		// (get) Token: 0x06015BC2 RID: 89026 RVA: 0x00327B69 File Offset: 0x00325D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004881 RID: 18561
		// (get) Token: 0x06015BC3 RID: 89027 RVA: 0x00327B6C File Offset: 0x00325D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResGotoNextRoomResponse.Descriptor;
			}
		}

		// Token: 0x06015BC4 RID: 89028 RVA: 0x00327B73 File Offset: 0x00325D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGotoNextRoomResponse()
		{
		}

		// Token: 0x06015BC5 RID: 89029 RVA: 0x00327B7B File Offset: 0x00325D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGotoNextRoomResponse(RogueResGotoNextRoomResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015BC6 RID: 89030 RVA: 0x00327BA0 File Offset: 0x00325DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGotoNextRoomResponse Clone()
		{
			return new RogueResGotoNextRoomResponse(this);
		}

		// Token: 0x17004882 RID: 18562
		// (get) Token: 0x06015BC7 RID: 89031 RVA: 0x00327BA8 File Offset: 0x00325DA8
		// (set) Token: 0x06015BC8 RID: 89032 RVA: 0x00327BB0 File Offset: 0x00325DB0
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

		// Token: 0x06015BC9 RID: 89033 RVA: 0x00327BB9 File Offset: 0x00325DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResGotoNextRoomResponse);
		}

		// Token: 0x06015BCA RID: 89034 RVA: 0x00327BC7 File Offset: 0x00325DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResGotoNextRoomResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015BCB RID: 89035 RVA: 0x00327BF8 File Offset: 0x00325DF8
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

		// Token: 0x06015BCC RID: 89036 RVA: 0x00327C3D File Offset: 0x00325E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015BCD RID: 89037 RVA: 0x00327C4A File Offset: 0x00325E4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015BCE RID: 89038 RVA: 0x00327C53 File Offset: 0x00325E53
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

		// Token: 0x06015BCF RID: 89039 RVA: 0x00327C88 File Offset: 0x00325E88
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

		// Token: 0x06015BD0 RID: 89040 RVA: 0x00327CC6 File Offset: 0x00325EC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResGotoNextRoomResponse other)
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

		// Token: 0x06015BD1 RID: 89041 RVA: 0x00327CF7 File Offset: 0x00325EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015BD2 RID: 89042 RVA: 0x00327D00 File Offset: 0x00325F00
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

		// Token: 0x04008268 RID: 33384
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008269 RID: 33385
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x0400826A RID: 33386
		private ErrorCode errorCode_;
	}
}
