using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E46 RID: 3654
	public sealed class RacingBetPlayerInfo : IMessage<RacingBetPlayerInfo>, IMessage, IEquatable<RacingBetPlayerInfo>, IDeepCloneable<RacingBetPlayerInfo>, IBufferMessage
	{
		// Token: 0x060139D9 RID: 80345 RVA: 0x002D9CA2 File Offset: 0x002D7EA2
		[NullableContext(1)]
		public static RacingBetPlayerInfo Create()
		{
			return new RacingBetPlayerInfo();
		}

		// Token: 0x17004110 RID: 16656
		// (get) Token: 0x060139DA RID: 80346 RVA: 0x002D9CA9 File Offset: 0x002D7EA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004111 RID: 16657
		// (get) Token: 0x060139DB RID: 80347 RVA: 0x002D9CAC File Offset: 0x002D7EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetPlayerInfo.Descriptor;
			}
		}

		// Token: 0x060139DC RID: 80348 RVA: 0x002D9CB3 File Offset: 0x002D7EB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetPlayerInfo()
		{
		}

		// Token: 0x060139DD RID: 80349 RVA: 0x002D9CC8 File Offset: 0x002D7EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetPlayerInfo(RacingBetPlayerInfo other) : this()
		{
			this.curCash_ = other.curCash_;
			this.totalCash_ = other.totalCash_;
			this.gearInfo_ = other.gearInfo_.Clone();
			this.hitNum_ = other.hitNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060139DE RID: 80350 RVA: 0x002D9D21 File Offset: 0x002D7F21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetPlayerInfo Clone()
		{
			return new RacingBetPlayerInfo(this);
		}

		// Token: 0x17004112 RID: 16658
		// (get) Token: 0x060139DF RID: 80351 RVA: 0x002D9D29 File Offset: 0x002D7F29
		// (set) Token: 0x060139E0 RID: 80352 RVA: 0x002D9D31 File Offset: 0x002D7F31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurCash
		{
			get
			{
				return this.curCash_;
			}
			set
			{
				this.curCash_ = value;
			}
		}

		// Token: 0x17004113 RID: 16659
		// (get) Token: 0x060139E1 RID: 80353 RVA: 0x002D9D3A File Offset: 0x002D7F3A
		// (set) Token: 0x060139E2 RID: 80354 RVA: 0x002D9D42 File Offset: 0x002D7F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalCash
		{
			get
			{
				return this.totalCash_;
			}
			set
			{
				this.totalCash_ = value;
			}
		}

		// Token: 0x17004114 RID: 16660
		// (get) Token: 0x060139E3 RID: 80355 RVA: 0x002D9D4B File Offset: 0x002D7F4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsGearInfo> GearInfo
		{
			get
			{
				return this.gearInfo_;
			}
		}

		// Token: 0x17004115 RID: 16661
		// (get) Token: 0x060139E4 RID: 80356 RVA: 0x002D9D53 File Offset: 0x002D7F53
		// (set) Token: 0x060139E5 RID: 80357 RVA: 0x002D9D5B File Offset: 0x002D7F5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HitNum
		{
			get
			{
				return this.hitNum_;
			}
			set
			{
				this.hitNum_ = value;
			}
		}

		// Token: 0x060139E6 RID: 80358 RVA: 0x002D9D64 File Offset: 0x002D7F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetPlayerInfo);
		}

		// Token: 0x060139E7 RID: 80359 RVA: 0x002D9D74 File Offset: 0x002D7F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetPlayerInfo other)
		{
			return other != null && (other == this || (this.CurCash == other.CurCash && this.TotalCash == other.TotalCash && this.gearInfo_.Equals(other.gearInfo_) && this.HitNum == other.HitNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060139E8 RID: 80360 RVA: 0x002D9DE4 File Offset: 0x002D7FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurCash != 0)
			{
				num ^= this.CurCash.GetHashCode();
			}
			if (this.TotalCash != 0)
			{
				num ^= this.TotalCash.GetHashCode();
			}
			num ^= this.gearInfo_.GetHashCode();
			if (this.HitNum != 0)
			{
				num ^= this.HitNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060139E9 RID: 80361 RVA: 0x002D9E63 File Offset: 0x002D8063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060139EA RID: 80362 RVA: 0x002D9E70 File Offset: 0x002D8070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060139EB RID: 80363 RVA: 0x002D9E7C File Offset: 0x002D807C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurCash != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurCash);
			}
			if (this.TotalCash != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TotalCash);
			}
			this.gearInfo_.WriteTo(ref output, RacingBetPlayerInfo._repeated_gearInfo_codec);
			if (this.HitNum != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.HitNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060139EC RID: 80364 RVA: 0x002D9F04 File Offset: 0x002D8104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurCash != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurCash);
			}
			if (this.TotalCash != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalCash);
			}
			num += this.gearInfo_.CalculateSize(RacingBetPlayerInfo._repeated_gearInfo_codec);
			if (this.HitNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HitNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060139ED RID: 80365 RVA: 0x002D9F88 File Offset: 0x002D8188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetPlayerInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurCash != 0)
			{
				this.CurCash = other.CurCash;
			}
			if (other.TotalCash != 0)
			{
				this.TotalCash = other.TotalCash;
			}
			this.gearInfo_.Add(other.gearInfo_);
			if (other.HitNum != 0)
			{
				this.HitNum = other.HitNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060139EE RID: 80366 RVA: 0x002D9FFD File Offset: 0x002D81FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060139EF RID: 80367 RVA: 0x002DA008 File Offset: 0x002D8208
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
						this.CurCash = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.TotalCash = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.gearInfo_.AddEntriesFrom(ref input, RacingBetPlayerInfo._repeated_gearInfo_codec);
						continue;
					}
					if (num == 32U)
					{
						this.HitNum = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007808 RID: 30728
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007809 RID: 30729
		public const int CurCashFieldNumber = 1;

		// Token: 0x0400780A RID: 30730
		private int curCash_;

		// Token: 0x0400780B RID: 30731
		public const int TotalCashFieldNumber = 2;

		// Token: 0x0400780C RID: 30732
		private int totalCash_;

		// Token: 0x0400780D RID: 30733
		public const int GearInfoFieldNumber = 3;

		// Token: 0x0400780E RID: 30734
		private static readonly FieldCodec<RacingBetsGearInfo> _repeated_gearInfo_codec = FieldCodec.ForMessage<RacingBetsGearInfo>(26U, RacingBetsGearInfo.Parser);

		// Token: 0x0400780F RID: 30735
		private readonly RepeatedField<RacingBetsGearInfo> gearInfo_ = new RepeatedField<RacingBetsGearInfo>();

		// Token: 0x04007810 RID: 30736
		public const int HitNumFieldNumber = 4;

		// Token: 0x04007811 RID: 30737
		private int hitNum_;
	}
}
