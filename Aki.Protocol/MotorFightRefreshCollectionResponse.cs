using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A46 RID: 2630
	[NetMessage(EMessageId.MotorFightRefreshCollectionResponse)]
	public sealed class MotorFightRefreshCollectionResponse : IMessage<MotorFightRefreshCollectionResponse>, IMessage, IEquatable<MotorFightRefreshCollectionResponse>, IDeepCloneable<MotorFightRefreshCollectionResponse>, IBufferMessage
	{
		// Token: 0x0600E5D1 RID: 58833 RVA: 0x002199B7 File Offset: 0x00217BB7
		[NullableContext(1)]
		public static MotorFightRefreshCollectionResponse Create()
		{
			return new MotorFightRefreshCollectionResponse();
		}

		// Token: 0x17002E94 RID: 11924
		// (get) Token: 0x0600E5D2 RID: 58834 RVA: 0x002199BE File Offset: 0x00217BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E95 RID: 11925
		// (get) Token: 0x0600E5D3 RID: 58835 RVA: 0x002199C1 File Offset: 0x00217BC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRefreshCollectionResponse.Descriptor;
			}
		}

		// Token: 0x0600E5D4 RID: 58836 RVA: 0x002199C8 File Offset: 0x00217BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshCollectionResponse()
		{
		}

		// Token: 0x0600E5D5 RID: 58837 RVA: 0x002199DC File Offset: 0x00217BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshCollectionResponse(MotorFightRefreshCollectionResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.drops_ = other.drops_.Clone();
			this.refreshCollectionTimes_ = other.refreshCollectionTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E5D6 RID: 58838 RVA: 0x00219A29 File Offset: 0x00217C29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshCollectionResponse Clone()
		{
			return new MotorFightRefreshCollectionResponse(this);
		}

		// Token: 0x17002E96 RID: 11926
		// (get) Token: 0x0600E5D7 RID: 58839 RVA: 0x00219A31 File Offset: 0x00217C31
		// (set) Token: 0x0600E5D8 RID: 58840 RVA: 0x00219A39 File Offset: 0x00217C39
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

		// Token: 0x17002E97 RID: 11927
		// (get) Token: 0x0600E5D9 RID: 58841 RVA: 0x00219A42 File Offset: 0x00217C42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightCollectionDrop> Drops
		{
			get
			{
				return this.drops_;
			}
		}

		// Token: 0x17002E98 RID: 11928
		// (get) Token: 0x0600E5DA RID: 58842 RVA: 0x00219A4A File Offset: 0x00217C4A
		// (set) Token: 0x0600E5DB RID: 58843 RVA: 0x00219A52 File Offset: 0x00217C52
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

		// Token: 0x0600E5DC RID: 58844 RVA: 0x00219A5B File Offset: 0x00217C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRefreshCollectionResponse);
		}

		// Token: 0x0600E5DD RID: 58845 RVA: 0x00219A6C File Offset: 0x00217C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRefreshCollectionResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.drops_.Equals(other.drops_) && this.RefreshCollectionTimes == other.RefreshCollectionTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E5DE RID: 58846 RVA: 0x00219ACC File Offset: 0x00217CCC
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

		// Token: 0x0600E5DF RID: 58847 RVA: 0x00219B38 File Offset: 0x00217D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E5E0 RID: 58848 RVA: 0x00219B45 File Offset: 0x00217D45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E5E1 RID: 58849 RVA: 0x00219B50 File Offset: 0x00217D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.drops_.WriteTo(ref output, MotorFightRefreshCollectionResponse._repeated_drops_codec);
			if (this.RefreshCollectionTimes != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RefreshCollectionTimes);
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E5E2 RID: 58850 RVA: 0x00219BBC File Offset: 0x00217DBC
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

		// Token: 0x0600E5E3 RID: 58851 RVA: 0x00219C28 File Offset: 0x00217E28
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

		// Token: 0x0600E5E4 RID: 58852 RVA: 0x00219C89 File Offset: 0x00217E89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E5E5 RID: 58853 RVA: 0x00219C94 File Offset: 0x00217E94
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
				if (num != 10U)
				{
					if (num != 64U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrCode = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.RefreshCollectionTimes = input.ReadInt32();
					}
				}
				else
				{
					this.drops_.AddEntriesFrom(ref input, MotorFightRefreshCollectionResponse._repeated_drops_codec);
				}
			}
		}

		// Token: 0x04005E2B RID: 24107
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E2C RID: 24108
		public const int ErrCodeFieldNumber = 10;

		// Token: 0x04005E2D RID: 24109
		private ErrorCode errCode_;

		// Token: 0x04005E2E RID: 24110
		public const int DropsFieldNumber = 1;

		// Token: 0x04005E2F RID: 24111
		private static readonly FieldCodec<MotorFightCollectionDrop> _repeated_drops_codec = FieldCodec.ForMessage<MotorFightCollectionDrop>(10U, MotorFightCollectionDrop.Parser);

		// Token: 0x04005E30 RID: 24112
		private readonly RepeatedField<MotorFightCollectionDrop> drops_ = new RepeatedField<MotorFightCollectionDrop>();

		// Token: 0x04005E31 RID: 24113
		public const int RefreshCollectionTimesFieldNumber = 8;

		// Token: 0x04005E32 RID: 24114
		private int refreshCollectionTimes_;
	}
}
