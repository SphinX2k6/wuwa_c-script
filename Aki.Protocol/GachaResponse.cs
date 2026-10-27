using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200069D RID: 1693
	[NetMessage(EMessageId.GachaResponse)]
	public sealed class GachaResponse : IMessage<GachaResponse>, IMessage, IEquatable<GachaResponse>, IDeepCloneable<GachaResponse>, IBufferMessage
	{
		// Token: 0x06009AFE RID: 39678 RVA: 0x00175F98 File Offset: 0x00174198
		[NullableContext(1)]
		public static GachaResponse Create()
		{
			return new GachaResponse();
		}

		// Token: 0x17001F02 RID: 7938
		// (get) Token: 0x06009AFF RID: 39679 RVA: 0x00175F9F File Offset: 0x0017419F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F03 RID: 7939
		// (get) Token: 0x06009B00 RID: 39680 RVA: 0x00175FA2 File Offset: 0x001741A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaResponse.Descriptor;
			}
		}

		// Token: 0x06009B01 RID: 39681 RVA: 0x00175FA9 File Offset: 0x001741A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaResponse()
		{
		}

		// Token: 0x06009B02 RID: 39682 RVA: 0x00175FBC File Offset: 0x001741BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaResponse(GachaResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.gachaResults_ = other.gachaResults_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B03 RID: 39683 RVA: 0x00175FF2 File Offset: 0x001741F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaResponse Clone()
		{
			return new GachaResponse(this);
		}

		// Token: 0x17001F04 RID: 7940
		// (get) Token: 0x06009B04 RID: 39684 RVA: 0x00175FFA File Offset: 0x001741FA
		// (set) Token: 0x06009B05 RID: 39685 RVA: 0x00176002 File Offset: 0x00174202
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

		// Token: 0x17001F05 RID: 7941
		// (get) Token: 0x06009B06 RID: 39686 RVA: 0x0017600B File Offset: 0x0017420B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaResult> GachaResults
		{
			get
			{
				return this.gachaResults_;
			}
		}

		// Token: 0x06009B07 RID: 39687 RVA: 0x00176013 File Offset: 0x00174213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaResponse);
		}

		// Token: 0x06009B08 RID: 39688 RVA: 0x00176024 File Offset: 0x00174224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.gachaResults_.Equals(other.gachaResults_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009B09 RID: 39689 RVA: 0x00176074 File Offset: 0x00174274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.gachaResults_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009B0A RID: 39690 RVA: 0x001760C7 File Offset: 0x001742C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009B0B RID: 39691 RVA: 0x001760D4 File Offset: 0x001742D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B0C RID: 39692 RVA: 0x001760E0 File Offset: 0x001742E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gachaResults_.WriteTo(ref output, GachaResponse._repeated_gachaResults_codec);
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

		// Token: 0x06009B0D RID: 39693 RVA: 0x00176130 File Offset: 0x00174330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.gachaResults_.CalculateSize(GachaResponse._repeated_gachaResults_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009B0E RID: 39694 RVA: 0x00176184 File Offset: 0x00174384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.gachaResults_.Add(other.gachaResults_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009B0F RID: 39695 RVA: 0x001761D1 File Offset: 0x001743D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B10 RID: 39696 RVA: 0x001761DC File Offset: 0x001743DC
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
				if (num != 74U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.gachaResults_.AddEntriesFrom(ref input, GachaResponse._repeated_gachaResults_codec);
				}
			}
		}

		// Token: 0x04004941 RID: 18753
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004942 RID: 18754
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04004943 RID: 18755
		private ErrorCode errorCode_;

		// Token: 0x04004944 RID: 18756
		public const int GachaResultsFieldNumber = 9;

		// Token: 0x04004945 RID: 18757
		private static readonly FieldCodec<GachaResult> _repeated_gachaResults_codec = FieldCodec.ForMessage<GachaResult>(74U, GachaResult.Parser);

		// Token: 0x04004946 RID: 18758
		private readonly RepeatedField<GachaResult> gachaResults_ = new RepeatedField<GachaResult>();
	}
}
