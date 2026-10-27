using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BBE RID: 3006
	[NetMessage(EMessageId.ParkourChallengeTakeResponse)]
	public sealed class ParkourChallengeTakeResponse : IMessage<ParkourChallengeTakeResponse>, IMessage, IEquatable<ParkourChallengeTakeResponse>, IDeepCloneable<ParkourChallengeTakeResponse>, IBufferMessage
	{
		// Token: 0x060104A9 RID: 66729 RVA: 0x002609A0 File Offset: 0x0025EBA0
		[NullableContext(1)]
		public static ParkourChallengeTakeResponse Create()
		{
			return new ParkourChallengeTakeResponse();
		}

		// Token: 0x1700356F RID: 13679
		// (get) Token: 0x060104AA RID: 66730 RVA: 0x002609A7 File Offset: 0x0025EBA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003570 RID: 13680
		// (get) Token: 0x060104AB RID: 66731 RVA: 0x002609AA File Offset: 0x0025EBAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParkourChallengeTakeResponse.Descriptor;
			}
		}

		// Token: 0x060104AC RID: 66732 RVA: 0x002609B1 File Offset: 0x0025EBB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeTakeResponse()
		{
		}

		// Token: 0x060104AD RID: 66733 RVA: 0x002609C4 File Offset: 0x0025EBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeTakeResponse(ParkourChallengeTakeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rewards_ = other.rewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060104AE RID: 66734 RVA: 0x002609FA File Offset: 0x0025EBFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeTakeResponse Clone()
		{
			return new ParkourChallengeTakeResponse(this);
		}

		// Token: 0x17003571 RID: 13681
		// (get) Token: 0x060104AF RID: 66735 RVA: 0x00260A02 File Offset: 0x0025EC02
		// (set) Token: 0x060104B0 RID: 66736 RVA: 0x00260A0A File Offset: 0x0025EC0A
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

		// Token: 0x17003572 RID: 13682
		// (get) Token: 0x060104B1 RID: 66737 RVA: 0x00260A13 File Offset: 0x0025EC13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Rewards
		{
			get
			{
				return this.rewards_;
			}
		}

		// Token: 0x060104B2 RID: 66738 RVA: 0x00260A1B File Offset: 0x0025EC1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParkourChallengeTakeResponse);
		}

		// Token: 0x060104B3 RID: 66739 RVA: 0x00260A2C File Offset: 0x0025EC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ParkourChallengeTakeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Rewards.Equals(other.Rewards) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060104B4 RID: 66740 RVA: 0x00260A7C File Offset: 0x0025EC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.Rewards.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060104B5 RID: 66741 RVA: 0x00260ACF File Offset: 0x0025ECCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060104B6 RID: 66742 RVA: 0x00260ADC File Offset: 0x0025ECDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060104B7 RID: 66743 RVA: 0x00260AE8 File Offset: 0x0025ECE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.rewards_.WriteTo(ref output, ParkourChallengeTakeResponse._map_rewards_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060104B8 RID: 66744 RVA: 0x00260B38 File Offset: 0x0025ED38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.rewards_.CalculateSize(ParkourChallengeTakeResponse._map_rewards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060104B9 RID: 66745 RVA: 0x00260B8C File Offset: 0x0025ED8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ParkourChallengeTakeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.rewards_.MergeFrom(other.rewards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060104BA RID: 66746 RVA: 0x00260BD9 File Offset: 0x0025EDD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060104BB RID: 66747 RVA: 0x00260BE4 File Offset: 0x0025EDE4
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
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.rewards_.AddEntriesFrom(ref input, ParkourChallengeTakeResponse._map_rewards_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400679A RID: 26522
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400679B RID: 26523
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400679C RID: 26524
		private ErrorCode errorCode_;

		// Token: 0x0400679D RID: 26525
		public const int RewardsFieldNumber = 13;

		// Token: 0x0400679E RID: 26526
		private static readonly MapField<int, int>.Codec _map_rewards_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 106U);

		// Token: 0x0400679F RID: 26527
		private readonly MapField<int, int> rewards_ = new MapField<int, int>();
	}
}
