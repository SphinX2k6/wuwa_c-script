using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200066D RID: 1645
	[NetMessage(EMessageId.FsmPlayMontagePush)]
	public sealed class FsmPlayMontagePush : IMessage<FsmPlayMontagePush>, IMessage, IEquatable<FsmPlayMontagePush>, IDeepCloneable<FsmPlayMontagePush>, IBufferMessage
	{
		// Token: 0x060096DD RID: 38621 RVA: 0x0016BD10 File Offset: 0x00169F10
		[NullableContext(1)]
		public static FsmPlayMontagePush Create()
		{
			return new FsmPlayMontagePush();
		}

		// Token: 0x17001E0A RID: 7690
		// (get) Token: 0x060096DE RID: 38622 RVA: 0x0016BD17 File Offset: 0x00169F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E0B RID: 7691
		// (get) Token: 0x060096DF RID: 38623 RVA: 0x0016BD1A File Offset: 0x00169F1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmPlayMontagePush.Descriptor;
			}
		}

		// Token: 0x060096E0 RID: 38624 RVA: 0x0016BD21 File Offset: 0x00169F21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmPlayMontagePush()
		{
		}

		// Token: 0x060096E1 RID: 38625 RVA: 0x0016BD40 File Offset: 0x00169F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmPlayMontagePush(FsmPlayMontagePush other) : this()
		{
			this.montageName_ = other.montageName_;
			this.montageHashCode_ = other.montageHashCode_;
			this.speedRatio_ = other.speedRatio_;
			this.startSection_ = other.startSection_;
			this.startTimeSeconds_ = other.startTimeSeconds_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060096E2 RID: 38626 RVA: 0x0016BDA0 File Offset: 0x00169FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmPlayMontagePush Clone()
		{
			return new FsmPlayMontagePush(this);
		}

		// Token: 0x17001E0C RID: 7692
		// (get) Token: 0x060096E3 RID: 38627 RVA: 0x0016BDA8 File Offset: 0x00169FA8
		// (set) Token: 0x060096E4 RID: 38628 RVA: 0x0016BDB0 File Offset: 0x00169FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string MontageName
		{
			get
			{
				return this.montageName_;
			}
			set
			{
				this.montageName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001E0D RID: 7693
		// (get) Token: 0x060096E5 RID: 38629 RVA: 0x0016BDC3 File Offset: 0x00169FC3
		// (set) Token: 0x060096E6 RID: 38630 RVA: 0x0016BDCB File Offset: 0x00169FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MontageHashCode
		{
			get
			{
				return this.montageHashCode_;
			}
			set
			{
				this.montageHashCode_ = value;
			}
		}

		// Token: 0x17001E0E RID: 7694
		// (get) Token: 0x060096E7 RID: 38631 RVA: 0x0016BDD4 File Offset: 0x00169FD4
		// (set) Token: 0x060096E8 RID: 38632 RVA: 0x0016BDDC File Offset: 0x00169FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float SpeedRatio
		{
			get
			{
				return this.speedRatio_;
			}
			set
			{
				this.speedRatio_ = value;
			}
		}

		// Token: 0x17001E0F RID: 7695
		// (get) Token: 0x060096E9 RID: 38633 RVA: 0x0016BDE5 File Offset: 0x00169FE5
		// (set) Token: 0x060096EA RID: 38634 RVA: 0x0016BDED File Offset: 0x00169FED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string StartSection
		{
			get
			{
				return this.startSection_;
			}
			set
			{
				this.startSection_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001E10 RID: 7696
		// (get) Token: 0x060096EB RID: 38635 RVA: 0x0016BE00 File Offset: 0x0016A000
		// (set) Token: 0x060096EC RID: 38636 RVA: 0x0016BE08 File Offset: 0x0016A008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float StartTimeSeconds
		{
			get
			{
				return this.startTimeSeconds_;
			}
			set
			{
				this.startTimeSeconds_ = value;
			}
		}

		// Token: 0x060096ED RID: 38637 RVA: 0x0016BE11 File Offset: 0x0016A011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmPlayMontagePush);
		}

		// Token: 0x060096EE RID: 38638 RVA: 0x0016BE20 File Offset: 0x0016A020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmPlayMontagePush other)
		{
			return other != null && (other == this || (!(this.MontageName != other.MontageName) && this.MontageHashCode == other.MontageHashCode && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.SpeedRatio, other.SpeedRatio) && !(this.StartSection != other.StartSection) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.StartTimeSeconds, other.StartTimeSeconds) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060096EF RID: 38639 RVA: 0x0016BEB8 File Offset: 0x0016A0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MontageName.Length != 0)
			{
				num ^= this.MontageName.GetHashCode();
			}
			if (this.MontageHashCode != 0)
			{
				num ^= this.MontageHashCode.GetHashCode();
			}
			if (this.SpeedRatio != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.SpeedRatio);
			}
			if (this.StartSection.Length != 0)
			{
				num ^= this.StartSection.GetHashCode();
			}
			if (this.StartTimeSeconds != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.StartTimeSeconds);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060096F0 RID: 38640 RVA: 0x0016BF6D File Offset: 0x0016A16D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060096F1 RID: 38641 RVA: 0x0016BF7A File Offset: 0x0016A17A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060096F2 RID: 38642 RVA: 0x0016BF84 File Offset: 0x0016A184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StartSection.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.StartSection);
			}
			if (this.MontageName.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.MontageName);
			}
			if (this.MontageHashCode != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.MontageHashCode);
			}
			if (this.StartTimeSeconds != 0f)
			{
				output.WriteRawTag(85);
				output.WriteFloat(this.StartTimeSeconds);
			}
			if (this.SpeedRatio != 0f)
			{
				output.WriteRawTag(93);
				output.WriteFloat(this.SpeedRatio);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060096F3 RID: 38643 RVA: 0x0016C048 File Offset: 0x0016A248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MontageName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MontageName);
			}
			if (this.MontageHashCode != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MontageHashCode);
			}
			if (this.SpeedRatio != 0f)
			{
				num += 5;
			}
			if (this.StartSection.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.StartSection);
			}
			if (this.StartTimeSeconds != 0f)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060096F4 RID: 38644 RVA: 0x0016C0E4 File Offset: 0x0016A2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FsmPlayMontagePush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MontageName.Length != 0)
			{
				this.MontageName = other.MontageName;
			}
			if (other.MontageHashCode != 0)
			{
				this.MontageHashCode = other.MontageHashCode;
			}
			if (other.SpeedRatio != 0f)
			{
				this.SpeedRatio = other.SpeedRatio;
			}
			if (other.StartSection.Length != 0)
			{
				this.StartSection = other.StartSection;
			}
			if (other.StartTimeSeconds != 0f)
			{
				this.StartTimeSeconds = other.StartTimeSeconds;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060096F5 RID: 38645 RVA: 0x0016C184 File Offset: 0x0016A384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060096F6 RID: 38646 RVA: 0x0016C190 File Offset: 0x0016A390
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
				if (num <= 42U)
				{
					if (num == 18U)
					{
						this.StartSection = input.ReadString();
						continue;
					}
					if (num == 42U)
					{
						this.MontageName = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.MontageHashCode = input.ReadInt32();
						continue;
					}
					if (num == 85U)
					{
						this.StartTimeSeconds = input.ReadFloat();
						continue;
					}
					if (num == 93U)
					{
						this.SpeedRatio = input.ReadFloat();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040047CE RID: 18382
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047CF RID: 18383
		public const int MontageNameFieldNumber = 5;

		// Token: 0x040047D0 RID: 18384
		private string montageName_ = "";

		// Token: 0x040047D1 RID: 18385
		public const int MontageHashCodeFieldNumber = 7;

		// Token: 0x040047D2 RID: 18386
		private int montageHashCode_;

		// Token: 0x040047D3 RID: 18387
		public const int SpeedRatioFieldNumber = 11;

		// Token: 0x040047D4 RID: 18388
		private float speedRatio_;

		// Token: 0x040047D5 RID: 18389
		public const int StartSectionFieldNumber = 2;

		// Token: 0x040047D6 RID: 18390
		private string startSection_ = "";

		// Token: 0x040047D7 RID: 18391
		public const int StartTimeSecondsFieldNumber = 10;

		// Token: 0x040047D8 RID: 18392
		private float startTimeSeconds_;
	}
}
