using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BAE RID: 2990
	[NetMessage(EMessageId.ParkourChallengeTakeResponse)]
	public sealed class ParkourChallengeTakeResponse : IMessage<ParkourChallengeTakeResponse>, IMessage, IEquatable<ParkourChallengeTakeResponse>, IDeepCloneable<ParkourChallengeTakeResponse>, IBufferMessage
	{
		// Token: 0x060103A5 RID: 66469 RVA: 0x0025EAE8 File Offset: 0x0025CCE8
		[NullableContext(1)]
		public static ParkourChallengeTakeResponse Create()
		{
			return new ParkourChallengeTakeResponse();
		}

		// Token: 0x17003536 RID: 13622
		// (get) Token: 0x060103A6 RID: 66470 RVA: 0x0025EAEF File Offset: 0x0025CCEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003537 RID: 13623
		// (get) Token: 0x060103A7 RID: 66471 RVA: 0x0025EAF2 File Offset: 0x0025CCF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParkourChallengeTakeResponse.Descriptor;
			}
		}

		// Token: 0x060103A8 RID: 66472 RVA: 0x0025EAF9 File Offset: 0x0025CCF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeTakeResponse()
		{
		}

		// Token: 0x060103A9 RID: 66473 RVA: 0x0025EB0C File Offset: 0x0025CD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeTakeResponse(ParkourChallengeTakeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rewards_ = other.rewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060103AA RID: 66474 RVA: 0x0025EB42 File Offset: 0x0025CD42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeTakeResponse Clone()
		{
			return new ParkourChallengeTakeResponse(this);
		}

		// Token: 0x17003538 RID: 13624
		// (get) Token: 0x060103AB RID: 66475 RVA: 0x0025EB4A File Offset: 0x0025CD4A
		// (set) Token: 0x060103AC RID: 66476 RVA: 0x0025EB52 File Offset: 0x0025CD52
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

		// Token: 0x17003539 RID: 13625
		// (get) Token: 0x060103AD RID: 66477 RVA: 0x0025EB5B File Offset: 0x0025CD5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Rewards
		{
			get
			{
				return this.rewards_;
			}
		}

		// Token: 0x060103AE RID: 66478 RVA: 0x0025EB63 File Offset: 0x0025CD63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParkourChallengeTakeResponse);
		}

		// Token: 0x060103AF RID: 66479 RVA: 0x0025EB74 File Offset: 0x0025CD74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ParkourChallengeTakeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Rewards.Equals(other.Rewards) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060103B0 RID: 66480 RVA: 0x0025EBC4 File Offset: 0x0025CDC4
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

		// Token: 0x060103B1 RID: 66481 RVA: 0x0025EC17 File Offset: 0x0025CE17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060103B2 RID: 66482 RVA: 0x0025EC24 File Offset: 0x0025CE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060103B3 RID: 66483 RVA: 0x0025EC30 File Offset: 0x0025CE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewards_.WriteTo(ref output, ParkourChallengeTakeResponse._map_rewards_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060103B4 RID: 66484 RVA: 0x0025EC80 File Offset: 0x0025CE80
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

		// Token: 0x060103B5 RID: 66485 RVA: 0x0025ECD4 File Offset: 0x0025CED4
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

		// Token: 0x060103B6 RID: 66486 RVA: 0x0025ED21 File Offset: 0x0025CF21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060103B7 RID: 66487 RVA: 0x0025ED2C File Offset: 0x0025CF2C
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
				if (num != 26U)
				{
					if (num != 88U)
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
					this.rewards_.AddEntriesFrom(ref input, ParkourChallengeTakeResponse._map_rewards_codec);
				}
			}
		}

		// Token: 0x040067AA RID: 26538
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067AB RID: 26539
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040067AC RID: 26540
		private ErrorCode errorCode_;

		// Token: 0x040067AD RID: 26541
		public const int RewardsFieldNumber = 3;

		// Token: 0x040067AE RID: 26542
		private static readonly MapField<int, int>.Codec _map_rewards_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 26U);

		// Token: 0x040067AF RID: 26543
		private readonly MapField<int, int> rewards_ = new MapField<int, int>();
	}
}
