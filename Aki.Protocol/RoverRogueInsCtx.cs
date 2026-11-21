using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001141 RID: 4417
	public sealed class RoverRogueInsCtx : IMessage<RoverRogueInsCtx>, IMessage, IEquatable<RoverRogueInsCtx>, IDeepCloneable<RoverRogueInsCtx>, IBufferMessage
	{
		// Token: 0x06017999 RID: 96665 RVA: 0x0036F5F2 File Offset: 0x0036D7F2
		[NullableContext(1)]
		public static RoverRogueInsCtx Create()
		{
			return new RoverRogueInsCtx();
		}

		// Token: 0x17004F5F RID: 20319
		// (get) Token: 0x0601799A RID: 96666 RVA: 0x0036F5F9 File Offset: 0x0036D7F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F60 RID: 20320
		// (get) Token: 0x0601799B RID: 96667 RVA: 0x0036F5FC File Offset: 0x0036D7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueInsCtx.Descriptor;
			}
		}

		// Token: 0x0601799C RID: 96668 RVA: 0x0036F603 File Offset: 0x0036D803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInsCtx()
		{
		}

		// Token: 0x0601799D RID: 96669 RVA: 0x0036F618 File Offset: 0x0036D818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInsCtx(RoverRogueInsCtx other) : this()
		{
			this.roverId_ = other.roverId_;
			this.continueLastProgress_ = other.continueLastProgress_;
			this.equippedLootIds_ = other.equippedLootIds_.Clone();
			this.roverRoleType_ = other.roverRoleType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601799E RID: 96670 RVA: 0x0036F671 File Offset: 0x0036D871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInsCtx Clone()
		{
			return new RoverRogueInsCtx(this);
		}

		// Token: 0x17004F61 RID: 20321
		// (get) Token: 0x0601799F RID: 96671 RVA: 0x0036F679 File Offset: 0x0036D879
		// (set) Token: 0x060179A0 RID: 96672 RVA: 0x0036F681 File Offset: 0x0036D881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoverId
		{
			get
			{
				return this.roverId_;
			}
			set
			{
				this.roverId_ = value;
			}
		}

		// Token: 0x17004F62 RID: 20322
		// (get) Token: 0x060179A1 RID: 96673 RVA: 0x0036F68A File Offset: 0x0036D88A
		// (set) Token: 0x060179A2 RID: 96674 RVA: 0x0036F692 File Offset: 0x0036D892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ContinueLastProgress
		{
			get
			{
				return this.continueLastProgress_;
			}
			set
			{
				this.continueLastProgress_ = value;
			}
		}

		// Token: 0x17004F63 RID: 20323
		// (get) Token: 0x060179A3 RID: 96675 RVA: 0x0036F69B File Offset: 0x0036D89B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EquippedLootIds
		{
			get
			{
				return this.equippedLootIds_;
			}
		}

		// Token: 0x17004F64 RID: 20324
		// (get) Token: 0x060179A4 RID: 96676 RVA: 0x0036F6A3 File Offset: 0x0036D8A3
		// (set) Token: 0x060179A5 RID: 96677 RVA: 0x0036F6AB File Offset: 0x0036D8AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoverRoleType
		{
			get
			{
				return this.roverRoleType_;
			}
			set
			{
				this.roverRoleType_ = value;
			}
		}

		// Token: 0x060179A6 RID: 96678 RVA: 0x0036F6B4 File Offset: 0x0036D8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueInsCtx);
		}

		// Token: 0x060179A7 RID: 96679 RVA: 0x0036F6C4 File Offset: 0x0036D8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueInsCtx other)
		{
			return other != null && (other == this || (this.RoverId == other.RoverId && this.ContinueLastProgress == other.ContinueLastProgress && this.equippedLootIds_.Equals(other.equippedLootIds_) && this.RoverRoleType == other.RoverRoleType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060179A8 RID: 96680 RVA: 0x0036F734 File Offset: 0x0036D934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoverId != 0)
			{
				num ^= this.RoverId.GetHashCode();
			}
			if (this.ContinueLastProgress)
			{
				num ^= this.ContinueLastProgress.GetHashCode();
			}
			num ^= this.equippedLootIds_.GetHashCode();
			if (this.RoverRoleType != 0)
			{
				num ^= this.RoverRoleType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060179A9 RID: 96681 RVA: 0x0036F7B3 File Offset: 0x0036D9B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060179AA RID: 96682 RVA: 0x0036F7C0 File Offset: 0x0036D9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060179AB RID: 96683 RVA: 0x0036F7CC File Offset: 0x0036D9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoverId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoverId);
			}
			if (this.ContinueLastProgress)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.ContinueLastProgress);
			}
			this.equippedLootIds_.WriteTo(ref output, RoverRogueInsCtx._repeated_equippedLootIds_codec);
			if (this.RoverRoleType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoverRoleType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060179AC RID: 96684 RVA: 0x0036F854 File Offset: 0x0036DA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoverId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoverId);
			}
			if (this.ContinueLastProgress)
			{
				num += 2;
			}
			num += this.equippedLootIds_.CalculateSize(RoverRogueInsCtx._repeated_equippedLootIds_codec);
			if (this.RoverRoleType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoverRoleType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060179AD RID: 96685 RVA: 0x0036F8CC File Offset: 0x0036DACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueInsCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoverId != 0)
			{
				this.RoverId = other.RoverId;
			}
			if (other.ContinueLastProgress)
			{
				this.ContinueLastProgress = other.ContinueLastProgress;
			}
			this.equippedLootIds_.Add(other.equippedLootIds_);
			if (other.RoverRoleType != 0)
			{
				this.RoverRoleType = other.RoverRoleType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060179AE RID: 96686 RVA: 0x0036F941 File Offset: 0x0036DB41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060179AF RID: 96687 RVA: 0x0036F94C File Offset: 0x0036DB4C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.RoverId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ContinueLastProgress = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U || num == 26U)
					{
						this.equippedLootIds_.AddEntriesFrom(ref input, RoverRogueInsCtx._repeated_equippedLootIds_codec);
						continue;
					}
					if (num == 32U)
					{
						this.RoverRoleType = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008CE5 RID: 36069
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008CE6 RID: 36070
		public const int RoverIdFieldNumber = 1;

		// Token: 0x04008CE7 RID: 36071
		private int roverId_;

		// Token: 0x04008CE8 RID: 36072
		public const int ContinueLastProgressFieldNumber = 2;

		// Token: 0x04008CE9 RID: 36073
		private bool continueLastProgress_;

		// Token: 0x04008CEA RID: 36074
		public const int EquippedLootIdsFieldNumber = 3;

		// Token: 0x04008CEB RID: 36075
		private static readonly FieldCodec<int> _repeated_equippedLootIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04008CEC RID: 36076
		private readonly RepeatedField<int> equippedLootIds_ = new RepeatedField<int>();

		// Token: 0x04008CED RID: 36077
		public const int RoverRoleTypeFieldNumber = 4;

		// Token: 0x04008CEE RID: 36078
		private int roverRoleType_;
	}
}
