using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006D8 RID: 1752
	[NetMessage(EMessageId.GiantDeliveryItemResponse)]
	public sealed class GiantDeliveryItemResponse : IMessage<GiantDeliveryItemResponse>, IMessage, IEquatable<GiantDeliveryItemResponse>, IDeepCloneable<GiantDeliveryItemResponse>, IBufferMessage
	{
		// Token: 0x06009FF7 RID: 40951 RVA: 0x001836F2 File Offset: 0x001818F2
		[NullableContext(1)]
		public static GiantDeliveryItemResponse Create()
		{
			return new GiantDeliveryItemResponse();
		}

		// Token: 0x1700201F RID: 8223
		// (get) Token: 0x06009FF8 RID: 40952 RVA: 0x001836F9 File Offset: 0x001818F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002020 RID: 8224
		// (get) Token: 0x06009FF9 RID: 40953 RVA: 0x001836FC File Offset: 0x001818FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantDeliveryItemResponse.Descriptor;
			}
		}

		// Token: 0x06009FFA RID: 40954 RVA: 0x00183703 File Offset: 0x00181903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantDeliveryItemResponse()
		{
		}

		// Token: 0x06009FFB RID: 40955 RVA: 0x0018370C File Offset: 0x0018190C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantDeliveryItemResponse(GiantDeliveryItemResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.giantEcoInfo_ = ((other.giantEcoInfo_ != null) ? other.giantEcoInfo_.Clone() : null);
			this.topQuality_ = other.topQuality_;
			this.hasReward_ = other.hasReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009FFC RID: 40956 RVA: 0x00183770 File Offset: 0x00181970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantDeliveryItemResponse Clone()
		{
			return new GiantDeliveryItemResponse(this);
		}

		// Token: 0x17002021 RID: 8225
		// (get) Token: 0x06009FFD RID: 40957 RVA: 0x00183778 File Offset: 0x00181978
		// (set) Token: 0x06009FFE RID: 40958 RVA: 0x00183780 File Offset: 0x00181980
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

		// Token: 0x17002022 RID: 8226
		// (get) Token: 0x06009FFF RID: 40959 RVA: 0x00183789 File Offset: 0x00181989
		// (set) Token: 0x0600A000 RID: 40960 RVA: 0x00183791 File Offset: 0x00181991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantEcoInfoPb GiantEcoInfo
		{
			get
			{
				return this.giantEcoInfo_;
			}
			set
			{
				this.giantEcoInfo_ = value;
			}
		}

		// Token: 0x17002023 RID: 8227
		// (get) Token: 0x0600A001 RID: 40961 RVA: 0x0018379A File Offset: 0x0018199A
		// (set) Token: 0x0600A002 RID: 40962 RVA: 0x001837A2 File Offset: 0x001819A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TopQuality
		{
			get
			{
				return this.topQuality_;
			}
			set
			{
				this.topQuality_ = value;
			}
		}

		// Token: 0x17002024 RID: 8228
		// (get) Token: 0x0600A003 RID: 40963 RVA: 0x001837AB File Offset: 0x001819AB
		// (set) Token: 0x0600A004 RID: 40964 RVA: 0x001837B3 File Offset: 0x001819B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasReward
		{
			get
			{
				return this.hasReward_;
			}
			set
			{
				this.hasReward_ = value;
			}
		}

		// Token: 0x0600A005 RID: 40965 RVA: 0x001837BC File Offset: 0x001819BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantDeliveryItemResponse);
		}

		// Token: 0x0600A006 RID: 40966 RVA: 0x001837CC File Offset: 0x001819CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantDeliveryItemResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.GiantEcoInfo, other.GiantEcoInfo) && this.TopQuality == other.TopQuality && this.HasReward == other.HasReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A007 RID: 40967 RVA: 0x0018383C File Offset: 0x00181A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.giantEcoInfo_ != null)
			{
				num ^= this.GiantEcoInfo.GetHashCode();
			}
			if (this.TopQuality != 0)
			{
				num ^= this.TopQuality.GetHashCode();
			}
			if (this.HasReward)
			{
				num ^= this.HasReward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A008 RID: 40968 RVA: 0x001838C9 File Offset: 0x00181AC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A009 RID: 40969 RVA: 0x001838D6 File Offset: 0x00181AD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A00A RID: 40970 RVA: 0x001838E0 File Offset: 0x00181AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TopQuality != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TopQuality);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.HasReward)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.HasReward);
			}
			if (this.giantEcoInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.GiantEcoInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A00B RID: 40971 RVA: 0x00183974 File Offset: 0x00181B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.giantEcoInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GiantEcoInfo);
			}
			if (this.TopQuality != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TopQuality);
			}
			if (this.HasReward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A00C RID: 40972 RVA: 0x001839F0 File Offset: 0x00181BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantDeliveryItemResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.giantEcoInfo_ != null)
			{
				if (this.giantEcoInfo_ == null)
				{
					this.GiantEcoInfo = new GiantEcoInfoPb();
				}
				this.GiantEcoInfo.MergeFrom(other.GiantEcoInfo);
			}
			if (other.TopQuality != 0)
			{
				this.TopQuality = other.TopQuality;
			}
			if (other.HasReward)
			{
				this.HasReward = other.HasReward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A00D RID: 40973 RVA: 0x00183A80 File Offset: 0x00181C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A00E RID: 40974 RVA: 0x00183A8C File Offset: 0x00181C8C
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
				if (num <= 56U)
				{
					if (num == 24U)
					{
						this.TopQuality = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.HasReward = input.ReadBool();
						continue;
					}
					if (num == 98U)
					{
						if (this.giantEcoInfo_ == null)
						{
							this.GiantEcoInfo = new GiantEcoInfoPb();
						}
						input.ReadMessage(this.GiantEcoInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004A8C RID: 19084
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A8D RID: 19085
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04004A8E RID: 19086
		private ErrorCode errorCode_;

		// Token: 0x04004A8F RID: 19087
		public const int GiantEcoInfoFieldNumber = 12;

		// Token: 0x04004A90 RID: 19088
		private GiantEcoInfoPb giantEcoInfo_;

		// Token: 0x04004A91 RID: 19089
		public const int TopQualityFieldNumber = 3;

		// Token: 0x04004A92 RID: 19090
		private int topQuality_;

		// Token: 0x04004A93 RID: 19091
		public const int HasRewardFieldNumber = 9;

		// Token: 0x04004A94 RID: 19092
		private bool hasReward_;
	}
}
