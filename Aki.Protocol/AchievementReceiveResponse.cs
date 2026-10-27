using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000066 RID: 102
	[NetMessage(EMessageId.AchievementReceiveResponse)]
	public sealed class AchievementReceiveResponse : IMessage<AchievementReceiveResponse>, IMessage, IEquatable<AchievementReceiveResponse>, IDeepCloneable<AchievementReceiveResponse>, IBufferMessage
	{
		// Token: 0x06001689 RID: 5769 RVA: 0x0003B240 File Offset: 0x00039440
		[NullableContext(1)]
		public static AchievementReceiveResponse Create()
		{
			return new AchievementReceiveResponse();
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600168A RID: 5770 RVA: 0x0003B247 File Offset: 0x00039447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600168B RID: 5771 RVA: 0x0003B24A File Offset: 0x0003944A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementReceiveResponse.Descriptor;
			}
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x0003B251 File Offset: 0x00039451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementReceiveResponse()
		{
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x0003B270 File Offset: 0x00039470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementReceiveResponse(AchievementReceiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x0003B2C2 File Offset: 0x000394C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementReceiveResponse Clone()
		{
			return new AchievementReceiveResponse(this);
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600168F RID: 5775 RVA: 0x0003B2CA File Offset: 0x000394CA
		// (set) Token: 0x06001690 RID: 5776 RVA: 0x0003B2D2 File Offset: 0x000394D2
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

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06001691 RID: 5777 RVA: 0x0003B2DB File Offset: 0x000394DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06001692 RID: 5778 RVA: 0x0003B2E3 File Offset: 0x000394E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x0003B2EB File Offset: 0x000394EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementReceiveResponse);
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x0003B2FC File Offset: 0x000394FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementReceiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x0003B360 File Offset: 0x00039560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.errorParams_.GetHashCode();
			num ^= this.ItemMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x0003B3C1 File Offset: 0x000395C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x0003B3CE File Offset: 0x000395CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x0003B3D8 File Offset: 0x000395D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.errorParams_.WriteTo(ref output, AchievementReceiveResponse._repeated_errorParams_codec);
			this.itemMap_.WriteTo(ref output, AchievementReceiveResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x0003B438 File Offset: 0x00039638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(AchievementReceiveResponse._repeated_errorParams_codec);
			num += this.itemMap_.CalculateSize(AchievementReceiveResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x0003B49C File Offset: 0x0003969C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AchievementReceiveResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.errorParams_.Add(other.errorParams_);
			this.itemMap_.MergeFrom(other.itemMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x0003B4FA File Offset: 0x000396FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x0003B504 File Offset: 0x00039704
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
					if (num != 74U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.itemMap_.AddEntriesFrom(ref input, AchievementReceiveResponse._map_itemMap_codec);
						}
					}
					else
					{
						this.errorParams_.AddEntriesFrom(ref input, AchievementReceiveResponse._repeated_errorParams_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040020E6 RID: 8422
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020E7 RID: 8423
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x040020E8 RID: 8424
		private ErrorCode errorCode_;

		// Token: 0x040020E9 RID: 8425
		public const int ErrorParamsFieldNumber = 9;

		// Token: 0x040020EA RID: 8426
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(74U);

		// Token: 0x040020EB RID: 8427
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();

		// Token: 0x040020EC RID: 8428
		public const int ItemMapFieldNumber = 11;

		// Token: 0x040020ED RID: 8429
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 90U);

		// Token: 0x040020EE RID: 8430
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
