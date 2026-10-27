using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014FD RID: 5373
	[NetMessage(EMessageId.WeatherControlInfoResponse)]
	public sealed class WeatherControlInfoResponse : IMessage<WeatherControlInfoResponse>, IMessage, IEquatable<WeatherControlInfoResponse>, IDeepCloneable<WeatherControlInfoResponse>, IBufferMessage
	{
		// Token: 0x0601C670 RID: 116336 RVA: 0x0041A57A File Offset: 0x0041877A
		[NullableContext(1)]
		public static WeatherControlInfoResponse Create()
		{
			return new WeatherControlInfoResponse();
		}

		// Token: 0x17005FBF RID: 24511
		// (get) Token: 0x0601C671 RID: 116337 RVA: 0x0041A581 File Offset: 0x00418781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FC0 RID: 24512
		// (get) Token: 0x0601C672 RID: 116338 RVA: 0x0041A584 File Offset: 0x00418784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeatherControlInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601C673 RID: 116339 RVA: 0x0041A58B File Offset: 0x0041878B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlInfoResponse()
		{
		}

		// Token: 0x0601C674 RID: 116340 RVA: 0x0041A5A0 File Offset: 0x004187A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlInfoResponse(WeatherControlInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.unlockedSwitchIds_ = other.unlockedSwitchIds_.Clone();
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C675 RID: 116341 RVA: 0x0041A5ED File Offset: 0x004187ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlInfoResponse Clone()
		{
			return new WeatherControlInfoResponse(this);
		}

		// Token: 0x17005FC1 RID: 24513
		// (get) Token: 0x0601C676 RID: 116342 RVA: 0x0041A5F5 File Offset: 0x004187F5
		// (set) Token: 0x0601C677 RID: 116343 RVA: 0x0041A5FD File Offset: 0x004187FD
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

		// Token: 0x17005FC2 RID: 24514
		// (get) Token: 0x0601C678 RID: 116344 RVA: 0x0041A606 File Offset: 0x00418806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedSwitchIds
		{
			get
			{
				return this.unlockedSwitchIds_;
			}
		}

		// Token: 0x17005FC3 RID: 24515
		// (get) Token: 0x0601C679 RID: 116345 RVA: 0x0041A60E File Offset: 0x0041880E
		// (set) Token: 0x0601C67A RID: 116346 RVA: 0x0041A616 File Offset: 0x00418816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x0601C67B RID: 116347 RVA: 0x0041A61F File Offset: 0x0041881F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeatherControlInfoResponse);
		}

		// Token: 0x0601C67C RID: 116348 RVA: 0x0041A630 File Offset: 0x00418830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeatherControlInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.unlockedSwitchIds_.Equals(other.unlockedSwitchIds_) && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C67D RID: 116349 RVA: 0x0041A690 File Offset: 0x00418890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.unlockedSwitchIds_.GetHashCode();
			if (this.IncId != 0L)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C67E RID: 116350 RVA: 0x0041A6FC File Offset: 0x004188FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C67F RID: 116351 RVA: 0x0041A709 File Offset: 0x00418909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C680 RID: 116352 RVA: 0x0041A714 File Offset: 0x00418914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.IncId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.IncId);
			}
			this.unlockedSwitchIds_.WriteTo(ref output, WeatherControlInfoResponse._repeated_unlockedSwitchIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C681 RID: 116353 RVA: 0x0041A780 File Offset: 0x00418980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.unlockedSwitchIds_.CalculateSize(WeatherControlInfoResponse._repeated_unlockedSwitchIds_codec);
			if (this.IncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C682 RID: 116354 RVA: 0x0041A7EC File Offset: 0x004189EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeatherControlInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.unlockedSwitchIds_.Add(other.unlockedSwitchIds_);
			if (other.IncId != 0L)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C683 RID: 116355 RVA: 0x0041A84D File Offset: 0x00418A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C684 RID: 116356 RVA: 0x0041A858 File Offset: 0x00418A58
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
				if (num <= 72U)
				{
					if (num == 48U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 72U)
					{
						this.IncId = input.ReadInt64();
						continue;
					}
				}
				else if (num == 80U || num == 82U)
				{
					this.unlockedSwitchIds_.AddEntriesFrom(ref input, WeatherControlInfoResponse._repeated_unlockedSwitchIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A2A5 RID: 41637
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2A6 RID: 41638
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x0400A2A7 RID: 41639
		private ErrorCode errorCode_;

		// Token: 0x0400A2A8 RID: 41640
		public const int UnlockedSwitchIdsFieldNumber = 10;

		// Token: 0x0400A2A9 RID: 41641
		private static readonly FieldCodec<int> _repeated_unlockedSwitchIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x0400A2AA RID: 41642
		private readonly RepeatedField<int> unlockedSwitchIds_ = new RepeatedField<int>();

		// Token: 0x0400A2AB RID: 41643
		public const int IncIdFieldNumber = 9;

		// Token: 0x0400A2AC RID: 41644
		private long incId_;
	}
}
