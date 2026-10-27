using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200066E RID: 1646
	[NetMessage(EMessageId.FsmPlayMontageRequest)]
	public sealed class FsmPlayMontageRequest : IMessage<FsmPlayMontageRequest>, IMessage, IEquatable<FsmPlayMontageRequest>, IDeepCloneable<FsmPlayMontageRequest>, IBufferMessage
	{
		// Token: 0x060096F7 RID: 38647 RVA: 0x0016C22B File Offset: 0x0016A42B
		[NullableContext(1)]
		public static FsmPlayMontageRequest Create()
		{
			return new FsmPlayMontageRequest();
		}

		// Token: 0x17001E11 RID: 7697
		// (get) Token: 0x060096F8 RID: 38648 RVA: 0x0016C232 File Offset: 0x0016A432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E12 RID: 7698
		// (get) Token: 0x060096F9 RID: 38649 RVA: 0x0016C235 File Offset: 0x0016A435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmPlayMontageRequest.Descriptor;
			}
		}

		// Token: 0x060096FA RID: 38650 RVA: 0x0016C23C File Offset: 0x0016A43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmPlayMontageRequest()
		{
		}

		// Token: 0x060096FB RID: 38651 RVA: 0x0016C25C File Offset: 0x0016A45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmPlayMontageRequest(FsmPlayMontageRequest other) : this()
		{
			this.montageName_ = other.montageName_;
			this.montageHashCode_ = other.montageHashCode_;
			this.speedRatio_ = other.speedRatio_;
			this.startSection_ = other.startSection_;
			this.startTimeSeconds_ = other.startTimeSeconds_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060096FC RID: 38652 RVA: 0x0016C2BC File Offset: 0x0016A4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmPlayMontageRequest Clone()
		{
			return new FsmPlayMontageRequest(this);
		}

		// Token: 0x17001E13 RID: 7699
		// (get) Token: 0x060096FD RID: 38653 RVA: 0x0016C2C4 File Offset: 0x0016A4C4
		// (set) Token: 0x060096FE RID: 38654 RVA: 0x0016C2CC File Offset: 0x0016A4CC
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

		// Token: 0x17001E14 RID: 7700
		// (get) Token: 0x060096FF RID: 38655 RVA: 0x0016C2DF File Offset: 0x0016A4DF
		// (set) Token: 0x06009700 RID: 38656 RVA: 0x0016C2E7 File Offset: 0x0016A4E7
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

		// Token: 0x17001E15 RID: 7701
		// (get) Token: 0x06009701 RID: 38657 RVA: 0x0016C2F0 File Offset: 0x0016A4F0
		// (set) Token: 0x06009702 RID: 38658 RVA: 0x0016C2F8 File Offset: 0x0016A4F8
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

		// Token: 0x17001E16 RID: 7702
		// (get) Token: 0x06009703 RID: 38659 RVA: 0x0016C301 File Offset: 0x0016A501
		// (set) Token: 0x06009704 RID: 38660 RVA: 0x0016C309 File Offset: 0x0016A509
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

		// Token: 0x17001E17 RID: 7703
		// (get) Token: 0x06009705 RID: 38661 RVA: 0x0016C31C File Offset: 0x0016A51C
		// (set) Token: 0x06009706 RID: 38662 RVA: 0x0016C324 File Offset: 0x0016A524
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

		// Token: 0x06009707 RID: 38663 RVA: 0x0016C32D File Offset: 0x0016A52D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmPlayMontageRequest);
		}

		// Token: 0x06009708 RID: 38664 RVA: 0x0016C33C File Offset: 0x0016A53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmPlayMontageRequest other)
		{
			return other != null && (other == this || (!(this.MontageName != other.MontageName) && this.MontageHashCode == other.MontageHashCode && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.SpeedRatio, other.SpeedRatio) && !(this.StartSection != other.StartSection) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.StartTimeSeconds, other.StartTimeSeconds) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009709 RID: 38665 RVA: 0x0016C3D4 File Offset: 0x0016A5D4
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

		// Token: 0x0600970A RID: 38666 RVA: 0x0016C489 File Offset: 0x0016A689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600970B RID: 38667 RVA: 0x0016C496 File Offset: 0x0016A696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600970C RID: 38668 RVA: 0x0016C4A0 File Offset: 0x0016A6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SpeedRatio != 0f)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.SpeedRatio);
			}
			if (this.StartSection.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.StartSection);
			}
			if (this.MontageName.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.MontageName);
			}
			if (this.StartTimeSeconds != 0f)
			{
				output.WriteRawTag(101);
				output.WriteFloat(this.StartTimeSeconds);
			}
			if (this.MontageHashCode != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.MontageHashCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600970D RID: 38669 RVA: 0x0016C564 File Offset: 0x0016A764
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

		// Token: 0x0600970E RID: 38670 RVA: 0x0016C600 File Offset: 0x0016A800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FsmPlayMontageRequest other)
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

		// Token: 0x0600970F RID: 38671 RVA: 0x0016C6A0 File Offset: 0x0016A8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009710 RID: 38672 RVA: 0x0016C6AC File Offset: 0x0016A8AC
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
				if (num <= 26U)
				{
					if (num == 13U)
					{
						this.SpeedRatio = input.ReadFloat();
						continue;
					}
					if (num == 26U)
					{
						this.StartSection = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.MontageName = input.ReadString();
						continue;
					}
					if (num == 101U)
					{
						this.StartTimeSeconds = input.ReadFloat();
						continue;
					}
					if (num == 120U)
					{
						this.MontageHashCode = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040047D9 RID: 18393
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047DA RID: 18394
		public const int MontageNameFieldNumber = 6;

		// Token: 0x040047DB RID: 18395
		private string montageName_ = "";

		// Token: 0x040047DC RID: 18396
		public const int MontageHashCodeFieldNumber = 15;

		// Token: 0x040047DD RID: 18397
		private int montageHashCode_;

		// Token: 0x040047DE RID: 18398
		public const int SpeedRatioFieldNumber = 1;

		// Token: 0x040047DF RID: 18399
		private float speedRatio_;

		// Token: 0x040047E0 RID: 18400
		public const int StartSectionFieldNumber = 3;

		// Token: 0x040047E1 RID: 18401
		private string startSection_ = "";

		// Token: 0x040047E2 RID: 18402
		public const int StartTimeSecondsFieldNumber = 12;

		// Token: 0x040047E3 RID: 18403
		private float startTimeSeconds_;
	}
}
