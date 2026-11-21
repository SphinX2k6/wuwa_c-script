using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200157D RID: 5501
	[NetMessage(EMessageId.WeekCardInfoResponse)]
	public sealed class WeekCardInfoResponse : IMessage<WeekCardInfoResponse>, IMessage, IEquatable<WeekCardInfoResponse>, IDeepCloneable<WeekCardInfoResponse>, IBufferMessage
	{
		// Token: 0x0601D205 RID: 119301 RVA: 0x00437BE0 File Offset: 0x00435DE0
		[NullableContext(1)]
		public static WeekCardInfoResponse Create()
		{
			return new WeekCardInfoResponse();
		}

		// Token: 0x1700628C RID: 25228
		// (get) Token: 0x0601D206 RID: 119302 RVA: 0x00437BE7 File Offset: 0x00435DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700628D RID: 25229
		// (get) Token: 0x0601D207 RID: 119303 RVA: 0x00437BEA File Offset: 0x00435DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeekCardInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601D208 RID: 119304 RVA: 0x00437BF1 File Offset: 0x00435DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardInfoResponse()
		{
		}

		// Token: 0x0601D209 RID: 119305 RVA: 0x00437C04 File Offset: 0x00435E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardInfoResponse(WeekCardInfoResponse other) : this()
		{
			this.infos_ = ((other.infos_ != null) ? other.infos_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this.weekCardInfos_ = other.weekCardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D20A RID: 119306 RVA: 0x00437C61 File Offset: 0x00435E61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardInfoResponse Clone()
		{
			return new WeekCardInfoResponse(this);
		}

		// Token: 0x1700628E RID: 25230
		// (get) Token: 0x0601D20B RID: 119307 RVA: 0x00437C69 File Offset: 0x00435E69
		// (set) Token: 0x0601D20C RID: 119308 RVA: 0x00437C71 File Offset: 0x00435E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardInfo Infos
		{
			get
			{
				return this.infos_;
			}
			set
			{
				this.infos_ = value;
			}
		}

		// Token: 0x1700628F RID: 25231
		// (get) Token: 0x0601D20D RID: 119309 RVA: 0x00437C7A File Offset: 0x00435E7A
		// (set) Token: 0x0601D20E RID: 119310 RVA: 0x00437C82 File Offset: 0x00435E82
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

		// Token: 0x17006290 RID: 25232
		// (get) Token: 0x0601D20F RID: 119311 RVA: 0x00437C8B File Offset: 0x00435E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WeekCardInfo> WeekCardInfos
		{
			get
			{
				return this.weekCardInfos_;
			}
		}

		// Token: 0x0601D210 RID: 119312 RVA: 0x00437C93 File Offset: 0x00435E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeekCardInfoResponse);
		}

		// Token: 0x0601D211 RID: 119313 RVA: 0x00437CA4 File Offset: 0x00435EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeekCardInfoResponse other)
		{
			return other != null && (other == this || (object.Equals(this.Infos, other.Infos) && this.ErrorCode == other.ErrorCode && this.weekCardInfos_.Equals(other.weekCardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D212 RID: 119314 RVA: 0x00437D08 File Offset: 0x00435F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.infos_ != null)
			{
				num ^= this.Infos.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.weekCardInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D213 RID: 119315 RVA: 0x00437D71 File Offset: 0x00435F71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D214 RID: 119316 RVA: 0x00437D7E File Offset: 0x00435F7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D215 RID: 119317 RVA: 0x00437D88 File Offset: 0x00435F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.infos_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Infos);
			}
			this.weekCardInfos_.WriteTo(ref output, WeekCardInfoResponse._repeated_weekCardInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D216 RID: 119318 RVA: 0x00437DF4 File Offset: 0x00435FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.infos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Infos);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.weekCardInfos_.CalculateSize(WeekCardInfoResponse._repeated_weekCardInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D217 RID: 119319 RVA: 0x00437E60 File Offset: 0x00436060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeekCardInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.infos_ != null)
			{
				if (this.infos_ == null)
				{
					this.Infos = new WeekCardInfo();
				}
				this.Infos.MergeFrom(other.Infos);
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.weekCardInfos_.Add(other.weekCardInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D218 RID: 119320 RVA: 0x00437ED9 File Offset: 0x004360D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D219 RID: 119321 RVA: 0x00437EE4 File Offset: 0x004360E4
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
				if (num != 50U)
				{
					if (num != 98U)
					{
						if (num != 112U)
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
						this.weekCardInfos_.AddEntriesFrom(ref input, WeekCardInfoResponse._repeated_weekCardInfos_codec);
					}
				}
				else
				{
					if (this.infos_ == null)
					{
						this.Infos = new WeekCardInfo();
					}
					input.ReadMessage(this.Infos);
				}
			}
		}

		// Token: 0x0400A73B RID: 42811
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A73C RID: 42812
		public const int InfosFieldNumber = 6;

		// Token: 0x0400A73D RID: 42813
		private WeekCardInfo infos_;

		// Token: 0x0400A73E RID: 42814
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400A73F RID: 42815
		private ErrorCode errorCode_;

		// Token: 0x0400A740 RID: 42816
		public const int WeekCardInfosFieldNumber = 12;

		// Token: 0x0400A741 RID: 42817
		private static readonly FieldCodec<WeekCardInfo> _repeated_weekCardInfos_codec = FieldCodec.ForMessage<WeekCardInfo>(98U, WeekCardInfo.Parser);

		// Token: 0x0400A742 RID: 42818
		private readonly RepeatedField<WeekCardInfo> weekCardInfos_ = new RepeatedField<WeekCardInfo>();
	}
}
