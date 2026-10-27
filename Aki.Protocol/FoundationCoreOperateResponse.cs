using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000639 RID: 1593
	[NetMessage(EMessageId.FoundationCoreOperateResponse)]
	public sealed class FoundationCoreOperateResponse : IMessage<FoundationCoreOperateResponse>, IMessage, IEquatable<FoundationCoreOperateResponse>, IDeepCloneable<FoundationCoreOperateResponse>, IBufferMessage
	{
		// Token: 0x060092C9 RID: 37577 RVA: 0x001631D4 File Offset: 0x001613D4
		[NullableContext(1)]
		public static FoundationCoreOperateResponse Create()
		{
			return new FoundationCoreOperateResponse();
		}

		// Token: 0x17001D36 RID: 7478
		// (get) Token: 0x060092CA RID: 37578 RVA: 0x001631DB File Offset: 0x001613DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D37 RID: 7479
		// (get) Token: 0x060092CB RID: 37579 RVA: 0x001631DE File Offset: 0x001613DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FoundationCoreOperateResponse.Descriptor;
			}
		}

		// Token: 0x060092CC RID: 37580 RVA: 0x001631E5 File Offset: 0x001613E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreOperateResponse()
		{
		}

		// Token: 0x060092CD RID: 37581 RVA: 0x001631F0 File Offset: 0x001613F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreOperateResponse(FoundationCoreOperateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.fromFoundationEntityId_ = other.fromFoundationEntityId_;
			this.foundationCoreInfo_ = ((other.foundationCoreInfo_ != null) ? other.foundationCoreInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060092CE RID: 37582 RVA: 0x00163248 File Offset: 0x00161448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreOperateResponse Clone()
		{
			return new FoundationCoreOperateResponse(this);
		}

		// Token: 0x17001D38 RID: 7480
		// (get) Token: 0x060092CF RID: 37583 RVA: 0x00163250 File Offset: 0x00161450
		// (set) Token: 0x060092D0 RID: 37584 RVA: 0x00163258 File Offset: 0x00161458
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

		// Token: 0x17001D39 RID: 7481
		// (get) Token: 0x060092D1 RID: 37585 RVA: 0x00163261 File Offset: 0x00161461
		// (set) Token: 0x060092D2 RID: 37586 RVA: 0x00163269 File Offset: 0x00161469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FromFoundationEntityId
		{
			get
			{
				return this.fromFoundationEntityId_;
			}
			set
			{
				this.fromFoundationEntityId_ = value;
			}
		}

		// Token: 0x17001D3A RID: 7482
		// (get) Token: 0x060092D3 RID: 37587 RVA: 0x00163272 File Offset: 0x00161472
		// (set) Token: 0x060092D4 RID: 37588 RVA: 0x0016327A File Offset: 0x0016147A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreInfo FoundationCoreInfo
		{
			get
			{
				return this.foundationCoreInfo_;
			}
			set
			{
				this.foundationCoreInfo_ = value;
			}
		}

		// Token: 0x060092D5 RID: 37589 RVA: 0x00163283 File Offset: 0x00161483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FoundationCoreOperateResponse);
		}

		// Token: 0x060092D6 RID: 37590 RVA: 0x00163294 File Offset: 0x00161494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FoundationCoreOperateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.FromFoundationEntityId == other.FromFoundationEntityId && object.Equals(this.FoundationCoreInfo, other.FoundationCoreInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060092D7 RID: 37591 RVA: 0x001632F4 File Offset: 0x001614F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.FromFoundationEntityId != 0)
			{
				num ^= this.FromFoundationEntityId.GetHashCode();
			}
			if (this.foundationCoreInfo_ != null)
			{
				num ^= this.FoundationCoreInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060092D8 RID: 37592 RVA: 0x00163368 File Offset: 0x00161568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060092D9 RID: 37593 RVA: 0x00163375 File Offset: 0x00161575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060092DA RID: 37594 RVA: 0x00163380 File Offset: 0x00161580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FromFoundationEntityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.FromFoundationEntityId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.foundationCoreInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.FoundationCoreInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060092DB RID: 37595 RVA: 0x001633F8 File Offset: 0x001615F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.FromFoundationEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FromFoundationEntityId);
			}
			if (this.foundationCoreInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FoundationCoreInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060092DC RID: 37596 RVA: 0x00163468 File Offset: 0x00161668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FoundationCoreOperateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.FromFoundationEntityId != 0)
			{
				this.FromFoundationEntityId = other.FromFoundationEntityId;
			}
			if (other.foundationCoreInfo_ != null)
			{
				if (this.foundationCoreInfo_ == null)
				{
					this.FoundationCoreInfo = new FoundationCoreInfo();
				}
				this.FoundationCoreInfo.MergeFrom(other.FoundationCoreInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060092DD RID: 37597 RVA: 0x001634E4 File Offset: 0x001616E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060092DE RID: 37598 RVA: 0x001634F0 File Offset: 0x001616F0
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
					if (num != 112U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.foundationCoreInfo_ == null)
							{
								this.FoundationCoreInfo = new FoundationCoreInfo();
							}
							input.ReadMessage(this.FoundationCoreInfo);
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.FromFoundationEntityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040046B5 RID: 18101
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046B6 RID: 18102
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040046B7 RID: 18103
		private ErrorCode errorCode_;

		// Token: 0x040046B8 RID: 18104
		public const int FromFoundationEntityIdFieldNumber = 12;

		// Token: 0x040046B9 RID: 18105
		private int fromFoundationEntityId_;

		// Token: 0x040046BA RID: 18106
		public const int FoundationCoreInfoFieldNumber = 15;

		// Token: 0x040046BB RID: 18107
		private FoundationCoreInfo foundationCoreInfo_;
	}
}
