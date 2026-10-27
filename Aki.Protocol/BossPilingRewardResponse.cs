using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001C8 RID: 456
	[NetMessage(EMessageId.BossPilingRewardResponse)]
	public sealed class BossPilingRewardResponse : IMessage<BossPilingRewardResponse>, IMessage, IEquatable<BossPilingRewardResponse>, IDeepCloneable<BossPilingRewardResponse>, IBufferMessage
	{
		// Token: 0x0600343D RID: 13373 RVA: 0x00083E40 File Offset: 0x00082040
		[NullableContext(1)]
		public static BossPilingRewardResponse Create()
		{
			return new BossPilingRewardResponse();
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x0600343E RID: 13374 RVA: 0x00083E47 File Offset: 0x00082047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x0600343F RID: 13375 RVA: 0x00083E4A File Offset: 0x0008204A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossPilingRewardResponse.Descriptor;
			}
		}

		// Token: 0x06003440 RID: 13376 RVA: 0x00083E51 File Offset: 0x00082051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingRewardResponse()
		{
		}

		// Token: 0x06003441 RID: 13377 RVA: 0x00083E59 File Offset: 0x00082059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingRewardResponse(BossPilingRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003442 RID: 13378 RVA: 0x00083E7E File Offset: 0x0008207E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingRewardResponse Clone()
		{
			return new BossPilingRewardResponse(this);
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06003443 RID: 13379 RVA: 0x00083E86 File Offset: 0x00082086
		// (set) Token: 0x06003444 RID: 13380 RVA: 0x00083E8E File Offset: 0x0008208E
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

		// Token: 0x06003445 RID: 13381 RVA: 0x00083E97 File Offset: 0x00082097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossPilingRewardResponse);
		}

		// Token: 0x06003446 RID: 13382 RVA: 0x00083EA5 File Offset: 0x000820A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossPilingRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x00083ED4 File Offset: 0x000820D4
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

		// Token: 0x06003448 RID: 13384 RVA: 0x00083F19 File Offset: 0x00082119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003449 RID: 13385 RVA: 0x00083F26 File Offset: 0x00082126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600344A RID: 13386 RVA: 0x00083F2F File Offset: 0x0008212F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600344B RID: 13387 RVA: 0x00083F64 File Offset: 0x00082164
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

		// Token: 0x0600344C RID: 13388 RVA: 0x00083FA2 File Offset: 0x000821A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossPilingRewardResponse other)
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

		// Token: 0x0600344D RID: 13389 RVA: 0x00083FD3 File Offset: 0x000821D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600344E RID: 13390 RVA: 0x00083FDC File Offset: 0x000821DC
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040029FB RID: 10747
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029FC RID: 10748
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x040029FD RID: 10749
		private ErrorCode errorCode_;
	}
}
