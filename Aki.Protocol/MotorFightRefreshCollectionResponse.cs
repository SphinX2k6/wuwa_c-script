using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A57 RID: 2647
	[NetMessage(EMessageId.MotorFightRefreshCollectionResponse)]
	public sealed class MotorFightRefreshCollectionResponse : IMessage<MotorFightRefreshCollectionResponse>, IMessage, IEquatable<MotorFightRefreshCollectionResponse>, IDeepCloneable<MotorFightRefreshCollectionResponse>, IBufferMessage
	{
		// Token: 0x0600E6EB RID: 59115 RVA: 0x0021BBAB File Offset: 0x00219DAB
		[NullableContext(1)]
		public static MotorFightRefreshCollectionResponse Create()
		{
			return new MotorFightRefreshCollectionResponse();
		}

		// Token: 0x17002ED2 RID: 11986
		// (get) Token: 0x0600E6EC RID: 59116 RVA: 0x0021BBB2 File Offset: 0x00219DB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002ED3 RID: 11987
		// (get) Token: 0x0600E6ED RID: 59117 RVA: 0x0021BBB5 File Offset: 0x00219DB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRefreshCollectionResponse.Descriptor;
			}
		}

		// Token: 0x0600E6EE RID: 59118 RVA: 0x0021BBBC File Offset: 0x00219DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshCollectionResponse()
		{
		}

		// Token: 0x0600E6EF RID: 59119 RVA: 0x0021BBD0 File Offset: 0x00219DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshCollectionResponse(MotorFightRefreshCollectionResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.drops_ = other.drops_.Clone();
			this.refreshCollectionTimes_ = other.refreshCollectionTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E6F0 RID: 59120 RVA: 0x0021BC1D File Offset: 0x00219E1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshCollectionResponse Clone()
		{
			return new MotorFightRefreshCollectionResponse(this);
		}

		// Token: 0x17002ED4 RID: 11988
		// (get) Token: 0x0600E6F1 RID: 59121 RVA: 0x0021BC25 File Offset: 0x00219E25
		// (set) Token: 0x0600E6F2 RID: 59122 RVA: 0x0021BC2D File Offset: 0x00219E2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x17002ED5 RID: 11989
		// (get) Token: 0x0600E6F3 RID: 59123 RVA: 0x0021BC36 File Offset: 0x00219E36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightCollectionDrop> Drops
		{
			get
			{
				return this.drops_;
			}
		}

		// Token: 0x17002ED6 RID: 11990
		// (get) Token: 0x0600E6F4 RID: 59124 RVA: 0x0021BC3E File Offset: 0x00219E3E
		// (set) Token: 0x0600E6F5 RID: 59125 RVA: 0x0021BC46 File Offset: 0x00219E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RefreshCollectionTimes
		{
			get
			{
				return this.refreshCollectionTimes_;
			}
			set
			{
				this.refreshCollectionTimes_ = value;
			}
		}

		// Token: 0x0600E6F6 RID: 59126 RVA: 0x0021BC4F File Offset: 0x00219E4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRefreshCollectionResponse);
		}

		// Token: 0x0600E6F7 RID: 59127 RVA: 0x0021BC60 File Offset: 0x00219E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRefreshCollectionResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.drops_.Equals(other.drops_) && this.RefreshCollectionTimes == other.RefreshCollectionTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E6F8 RID: 59128 RVA: 0x0021BCC0 File Offset: 0x00219EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			num ^= this.drops_.GetHashCode();
			if (this.RefreshCollectionTimes != 0)
			{
				num ^= this.RefreshCollectionTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E6F9 RID: 59129 RVA: 0x0021BD2C File Offset: 0x00219F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E6FA RID: 59130 RVA: 0x0021BD39 File Offset: 0x00219F39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E6FB RID: 59131 RVA: 0x0021BD44 File Offset: 0x00219F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this.RefreshCollectionTimes != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RefreshCollectionTimes);
			}
			this.drops_.WriteTo(ref output, MotorFightRefreshCollectionResponse._repeated_drops_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E6FC RID: 59132 RVA: 0x0021BDB0 File Offset: 0x00219FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			num += this.drops_.CalculateSize(MotorFightRefreshCollectionResponse._repeated_drops_codec);
			if (this.RefreshCollectionTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RefreshCollectionTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E6FD RID: 59133 RVA: 0x0021BE1C File Offset: 0x0021A01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightRefreshCollectionResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this.drops_.Add(other.drops_);
			if (other.RefreshCollectionTimes != 0)
			{
				this.RefreshCollectionTimes = other.RefreshCollectionTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E6FE RID: 59134 RVA: 0x0021BE7D File Offset: 0x0021A07D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E6FF RID: 59135 RVA: 0x0021BE88 File Offset: 0x0021A088
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
				if (num != 56U)
				{
					if (num != 64U)
					{
						if (num != 82U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.drops_.AddEntriesFrom(ref input, MotorFightRefreshCollectionResponse._repeated_drops_codec);
						}
					}
					else
					{
						this.RefreshCollectionTimes = input.ReadInt32();
					}
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005E22 RID: 24098
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E23 RID: 24099
		public const int ErrCodeFieldNumber = 7;

		// Token: 0x04005E24 RID: 24100
		private ErrorCode errCode_;

		// Token: 0x04005E25 RID: 24101
		public const int DropsFieldNumber = 10;

		// Token: 0x04005E26 RID: 24102
		private static readonly FieldCodec<MotorFightCollectionDrop> _repeated_drops_codec = FieldCodec.ForMessage<MotorFightCollectionDrop>(82U, MotorFightCollectionDrop.Parser);

		// Token: 0x04005E27 RID: 24103
		private readonly RepeatedField<MotorFightCollectionDrop> drops_ = new RepeatedField<MotorFightCollectionDrop>();

		// Token: 0x04005E28 RID: 24104
		public const int RefreshCollectionTimesFieldNumber = 8;

		// Token: 0x04005E29 RID: 24105
		private int refreshCollectionTimes_;
	}
}
