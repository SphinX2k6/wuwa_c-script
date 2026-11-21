using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001161 RID: 4449
	[NetMessage(EMessageId.RoverRogueShopRefreshResponse)]
	public sealed class RoverRogueShopRefreshResponse : IMessage<RoverRogueShopRefreshResponse>, IMessage, IEquatable<RoverRogueShopRefreshResponse>, IDeepCloneable<RoverRogueShopRefreshResponse>, IBufferMessage
	{
		// Token: 0x06017C6B RID: 97387 RVA: 0x00376401 File Offset: 0x00374601
		[NullableContext(1)]
		public static RoverRogueShopRefreshResponse Create()
		{
			return new RoverRogueShopRefreshResponse();
		}

		// Token: 0x1700500B RID: 20491
		// (get) Token: 0x06017C6C RID: 97388 RVA: 0x00376408 File Offset: 0x00374608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700500C RID: 20492
		// (get) Token: 0x06017C6D RID: 97389 RVA: 0x0037640B File Offset: 0x0037460B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueShopRefreshResponse.Descriptor;
			}
		}

		// Token: 0x06017C6E RID: 97390 RVA: 0x00376412 File Offset: 0x00374612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopRefreshResponse()
		{
		}

		// Token: 0x06017C6F RID: 97391 RVA: 0x0037641C File Offset: 0x0037461C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopRefreshResponse(RoverRogueShopRefreshResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.snapshot_ = ((other.snapshot_ != null) ? other.snapshot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017C70 RID: 97392 RVA: 0x00376468 File Offset: 0x00374668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopRefreshResponse Clone()
		{
			return new RoverRogueShopRefreshResponse(this);
		}

		// Token: 0x1700500D RID: 20493
		// (get) Token: 0x06017C71 RID: 97393 RVA: 0x00376470 File Offset: 0x00374670
		// (set) Token: 0x06017C72 RID: 97394 RVA: 0x00376478 File Offset: 0x00374678
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

		// Token: 0x1700500E RID: 20494
		// (get) Token: 0x06017C73 RID: 97395 RVA: 0x00376481 File Offset: 0x00374681
		// (set) Token: 0x06017C74 RID: 97396 RVA: 0x00376489 File Offset: 0x00374689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopSnapshot Snapshot
		{
			get
			{
				return this.snapshot_;
			}
			set
			{
				this.snapshot_ = value;
			}
		}

		// Token: 0x06017C75 RID: 97397 RVA: 0x00376492 File Offset: 0x00374692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueShopRefreshResponse);
		}

		// Token: 0x06017C76 RID: 97398 RVA: 0x003764A0 File Offset: 0x003746A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueShopRefreshResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Snapshot, other.Snapshot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017C77 RID: 97399 RVA: 0x003764F0 File Offset: 0x003746F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.snapshot_ != null)
			{
				num ^= this.Snapshot.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017C78 RID: 97400 RVA: 0x0037654B File Offset: 0x0037474B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017C79 RID: 97401 RVA: 0x00376558 File Offset: 0x00374758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017C7A RID: 97402 RVA: 0x00376564 File Offset: 0x00374764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.snapshot_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Snapshot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017C7B RID: 97403 RVA: 0x003765C0 File Offset: 0x003747C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.snapshot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Snapshot);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017C7C RID: 97404 RVA: 0x00376618 File Offset: 0x00374818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueShopRefreshResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.snapshot_ != null)
			{
				if (this.snapshot_ == null)
				{
					this.Snapshot = new RoverRogueShopSnapshot();
				}
				this.Snapshot.MergeFrom(other.Snapshot);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017C7D RID: 97405 RVA: 0x00376680 File Offset: 0x00374880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017C7E RID: 97406 RVA: 0x0037668C File Offset: 0x0037488C
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
				if (num != 32U)
				{
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.snapshot_ == null)
						{
							this.Snapshot = new RoverRogueShopSnapshot();
						}
						input.ReadMessage(this.Snapshot);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008DE3 RID: 36323
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DE4 RID: 36324
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04008DE5 RID: 36325
		private ErrorCode errorCode_;

		// Token: 0x04008DE6 RID: 36326
		public const int SnapshotFieldNumber = 6;

		// Token: 0x04008DE7 RID: 36327
		private RoverRogueShopSnapshot snapshot_;
	}
}
