using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005D3 RID: 1491
	[NetMessage(EMessageId.FloroRanchStartPlayResponse)]
	public sealed class FloroRanchStartPlayResponse : IMessage<FloroRanchStartPlayResponse>, IMessage, IEquatable<FloroRanchStartPlayResponse>, IDeepCloneable<FloroRanchStartPlayResponse>, IBufferMessage
	{
		// Token: 0x06008A82 RID: 35458 RVA: 0x0014FC6D File Offset: 0x0014DE6D
		[NullableContext(1)]
		public static FloroRanchStartPlayResponse Create()
		{
			return new FloroRanchStartPlayResponse();
		}

		// Token: 0x17001B5B RID: 7003
		// (get) Token: 0x06008A83 RID: 35459 RVA: 0x0014FC74 File Offset: 0x0014DE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B5C RID: 7004
		// (get) Token: 0x06008A84 RID: 35460 RVA: 0x0014FC77 File Offset: 0x0014DE77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchStartPlayResponse.Descriptor;
			}
		}

		// Token: 0x06008A85 RID: 35461 RVA: 0x0014FC7E File Offset: 0x0014DE7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchStartPlayResponse()
		{
		}

		// Token: 0x06008A86 RID: 35462 RVA: 0x0014FC94 File Offset: 0x0014DE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchStartPlayResponse(FloroRanchStartPlayResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.playInfo_ = ((other.playInfo_ != null) ? other.playInfo_.Clone() : null);
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008A87 RID: 35463 RVA: 0x0014FCF1 File Offset: 0x0014DEF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchStartPlayResponse Clone()
		{
			return new FloroRanchStartPlayResponse(this);
		}

		// Token: 0x17001B5D RID: 7005
		// (get) Token: 0x06008A88 RID: 35464 RVA: 0x0014FCF9 File Offset: 0x0014DEF9
		// (set) Token: 0x06008A89 RID: 35465 RVA: 0x0014FD01 File Offset: 0x0014DF01
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

		// Token: 0x17001B5E RID: 7006
		// (get) Token: 0x06008A8A RID: 35466 RVA: 0x0014FD0A File Offset: 0x0014DF0A
		// (set) Token: 0x06008A8B RID: 35467 RVA: 0x0014FD12 File Offset: 0x0014DF12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayInfo PlayInfo
		{
			get
			{
				return this.playInfo_;
			}
			set
			{
				this.playInfo_ = value;
			}
		}

		// Token: 0x17001B5F RID: 7007
		// (get) Token: 0x06008A8C RID: 35468 RVA: 0x0014FD1B File Offset: 0x0014DF1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x06008A8D RID: 35469 RVA: 0x0014FD23 File Offset: 0x0014DF23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchStartPlayResponse);
		}

		// Token: 0x06008A8E RID: 35470 RVA: 0x0014FD34 File Offset: 0x0014DF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchStartPlayResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PlayInfo, other.PlayInfo) && this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008A8F RID: 35471 RVA: 0x0014FD98 File Offset: 0x0014DF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.playInfo_ != null)
			{
				num ^= this.PlayInfo.GetHashCode();
			}
			num ^= this.task_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008A90 RID: 35472 RVA: 0x0014FE01 File Offset: 0x0014E001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008A91 RID: 35473 RVA: 0x0014FE0E File Offset: 0x0014E00E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A92 RID: 35474 RVA: 0x0014FE18 File Offset: 0x0014E018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.playInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.PlayInfo);
			}
			this.task_.WriteTo(ref output, FloroRanchStartPlayResponse._repeated_task_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008A93 RID: 35475 RVA: 0x0014FE84 File Offset: 0x0014E084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.playInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayInfo);
			}
			num += this.task_.CalculateSize(FloroRanchStartPlayResponse._repeated_task_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008A94 RID: 35476 RVA: 0x0014FEF0 File Offset: 0x0014E0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchStartPlayResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.playInfo_ != null)
			{
				if (this.playInfo_ == null)
				{
					this.PlayInfo = new FloroRanchPlayInfo();
				}
				this.PlayInfo.MergeFrom(other.PlayInfo);
			}
			this.task_.Add(other.task_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008A95 RID: 35477 RVA: 0x0014FF69 File Offset: 0x0014E169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A96 RID: 35478 RVA: 0x0014FF74 File Offset: 0x0014E174
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
					if (num != 82U)
					{
						if (num != 98U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.task_.AddEntriesFrom(ref input, FloroRanchStartPlayResponse._repeated_task_codec);
						}
					}
					else
					{
						if (this.playInfo_ == null)
						{
							this.PlayInfo = new FloroRanchPlayInfo();
						}
						input.ReadMessage(this.PlayInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004487 RID: 17543
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004488 RID: 17544
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04004489 RID: 17545
		private ErrorCode errorCode_;

		// Token: 0x0400448A RID: 17546
		public const int PlayInfoFieldNumber = 10;

		// Token: 0x0400448B RID: 17547
		private FloroRanchPlayInfo playInfo_;

		// Token: 0x0400448C RID: 17548
		public const int TaskFieldNumber = 12;

		// Token: 0x0400448D RID: 17549
		private static readonly FieldCodec<FloroRanchPlayTask> _repeated_task_codec = FieldCodec.ForMessage<FloroRanchPlayTask>(98U, FloroRanchPlayTask.Parser);

		// Token: 0x0400448E RID: 17550
		private readonly RepeatedField<FloroRanchPlayTask> task_ = new RepeatedField<FloroRanchPlayTask>();
	}
}
