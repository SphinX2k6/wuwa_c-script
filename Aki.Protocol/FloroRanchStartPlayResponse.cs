using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005E8 RID: 1512
	[NetMessage(EMessageId.FloroRanchStartPlayResponse)]
	public sealed class FloroRanchStartPlayResponse : IMessage<FloroRanchStartPlayResponse>, IMessage, IEquatable<FloroRanchStartPlayResponse>, IDeepCloneable<FloroRanchStartPlayResponse>, IBufferMessage
	{
		// Token: 0x06008BEA RID: 35818 RVA: 0x00152881 File Offset: 0x00150A81
		[NullableContext(1)]
		public static FloroRanchStartPlayResponse Create()
		{
			return new FloroRanchStartPlayResponse();
		}

		// Token: 0x17001BA8 RID: 7080
		// (get) Token: 0x06008BEB RID: 35819 RVA: 0x00152888 File Offset: 0x00150A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BA9 RID: 7081
		// (get) Token: 0x06008BEC RID: 35820 RVA: 0x0015288B File Offset: 0x00150A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchStartPlayResponse.Descriptor;
			}
		}

		// Token: 0x06008BED RID: 35821 RVA: 0x00152892 File Offset: 0x00150A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchStartPlayResponse()
		{
		}

		// Token: 0x06008BEE RID: 35822 RVA: 0x001528A8 File Offset: 0x00150AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchStartPlayResponse(FloroRanchStartPlayResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.playInfo_ = ((other.playInfo_ != null) ? other.playInfo_.Clone() : null);
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008BEF RID: 35823 RVA: 0x00152905 File Offset: 0x00150B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchStartPlayResponse Clone()
		{
			return new FloroRanchStartPlayResponse(this);
		}

		// Token: 0x17001BAA RID: 7082
		// (get) Token: 0x06008BF0 RID: 35824 RVA: 0x0015290D File Offset: 0x00150B0D
		// (set) Token: 0x06008BF1 RID: 35825 RVA: 0x00152915 File Offset: 0x00150B15
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

		// Token: 0x17001BAB RID: 7083
		// (get) Token: 0x06008BF2 RID: 35826 RVA: 0x0015291E File Offset: 0x00150B1E
		// (set) Token: 0x06008BF3 RID: 35827 RVA: 0x00152926 File Offset: 0x00150B26
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

		// Token: 0x17001BAC RID: 7084
		// (get) Token: 0x06008BF4 RID: 35828 RVA: 0x0015292F File Offset: 0x00150B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x06008BF5 RID: 35829 RVA: 0x00152937 File Offset: 0x00150B37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchStartPlayResponse);
		}

		// Token: 0x06008BF6 RID: 35830 RVA: 0x00152948 File Offset: 0x00150B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchStartPlayResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PlayInfo, other.PlayInfo) && this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008BF7 RID: 35831 RVA: 0x001529AC File Offset: 0x00150BAC
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

		// Token: 0x06008BF8 RID: 35832 RVA: 0x00152A15 File Offset: 0x00150C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008BF9 RID: 35833 RVA: 0x00152A22 File Offset: 0x00150C22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008BFA RID: 35834 RVA: 0x00152A2C File Offset: 0x00150C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.playInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.PlayInfo);
			}
			this.task_.WriteTo(ref output, FloroRanchStartPlayResponse._repeated_task_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008BFB RID: 35835 RVA: 0x00152A98 File Offset: 0x00150C98
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

		// Token: 0x06008BFC RID: 35836 RVA: 0x00152B04 File Offset: 0x00150D04
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

		// Token: 0x06008BFD RID: 35837 RVA: 0x00152B7D File Offset: 0x00150D7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008BFE RID: 35838 RVA: 0x00152B88 File Offset: 0x00150D88
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
					if (num != 34U)
					{
						if (num != 66U)
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

		// Token: 0x04004491 RID: 17553
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004492 RID: 17554
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04004493 RID: 17555
		private ErrorCode errorCode_;

		// Token: 0x04004494 RID: 17556
		public const int PlayInfoFieldNumber = 4;

		// Token: 0x04004495 RID: 17557
		private FloroRanchPlayInfo playInfo_;

		// Token: 0x04004496 RID: 17558
		public const int TaskFieldNumber = 8;

		// Token: 0x04004497 RID: 17559
		private static readonly FieldCodec<FloroRanchPlayTask> _repeated_task_codec = FieldCodec.ForMessage<FloroRanchPlayTask>(66U, FloroRanchPlayTask.Parser);

		// Token: 0x04004498 RID: 17560
		private readonly RepeatedField<FloroRanchPlayTask> task_ = new RepeatedField<FloroRanchPlayTask>();
	}
}
