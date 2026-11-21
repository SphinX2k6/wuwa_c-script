using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D68 RID: 3432
	[NetMessage(EMessageId.PlayEntityMontagePush)]
	public sealed class PlayEntityMontagePush : IMessage<PlayEntityMontagePush>, IMessage, IEquatable<PlayEntityMontagePush>, IDeepCloneable<PlayEntityMontagePush>, IBufferMessage
	{
		// Token: 0x06012864 RID: 75876 RVA: 0x002B4356 File Offset: 0x002B2556
		[NullableContext(1)]
		public static PlayEntityMontagePush Create()
		{
			return new PlayEntityMontagePush();
		}

		// Token: 0x17003D66 RID: 15718
		// (get) Token: 0x06012865 RID: 75877 RVA: 0x002B435D File Offset: 0x002B255D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D67 RID: 15719
		// (get) Token: 0x06012866 RID: 75878 RVA: 0x002B4360 File Offset: 0x002B2560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayEntityMontagePush.Descriptor;
			}
		}

		// Token: 0x06012867 RID: 75879 RVA: 0x002B4367 File Offset: 0x002B2567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayEntityMontagePush()
		{
		}

		// Token: 0x06012868 RID: 75880 RVA: 0x002B4388 File Offset: 0x002B2588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayEntityMontagePush(PlayEntityMontagePush other) : this()
		{
			this.montageName_ = other.montageName_;
			this.montageHashCode_ = other.montageHashCode_;
			this.speedRatio_ = other.speedRatio_;
			this.startSection_ = other.startSection_;
			this.startTimeSeconds_ = other.startTimeSeconds_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012869 RID: 75881 RVA: 0x002B43E8 File Offset: 0x002B25E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayEntityMontagePush Clone()
		{
			return new PlayEntityMontagePush(this);
		}

		// Token: 0x17003D68 RID: 15720
		// (get) Token: 0x0601286A RID: 75882 RVA: 0x002B43F0 File Offset: 0x002B25F0
		// (set) Token: 0x0601286B RID: 75883 RVA: 0x002B43F8 File Offset: 0x002B25F8
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

		// Token: 0x17003D69 RID: 15721
		// (get) Token: 0x0601286C RID: 75884 RVA: 0x002B440B File Offset: 0x002B260B
		// (set) Token: 0x0601286D RID: 75885 RVA: 0x002B4413 File Offset: 0x002B2613
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

		// Token: 0x17003D6A RID: 15722
		// (get) Token: 0x0601286E RID: 75886 RVA: 0x002B441C File Offset: 0x002B261C
		// (set) Token: 0x0601286F RID: 75887 RVA: 0x002B4424 File Offset: 0x002B2624
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

		// Token: 0x17003D6B RID: 15723
		// (get) Token: 0x06012870 RID: 75888 RVA: 0x002B442D File Offset: 0x002B262D
		// (set) Token: 0x06012871 RID: 75889 RVA: 0x002B4435 File Offset: 0x002B2635
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

		// Token: 0x17003D6C RID: 15724
		// (get) Token: 0x06012872 RID: 75890 RVA: 0x002B4448 File Offset: 0x002B2648
		// (set) Token: 0x06012873 RID: 75891 RVA: 0x002B4450 File Offset: 0x002B2650
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

		// Token: 0x06012874 RID: 75892 RVA: 0x002B4459 File Offset: 0x002B2659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayEntityMontagePush);
		}

		// Token: 0x06012875 RID: 75893 RVA: 0x002B4468 File Offset: 0x002B2668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayEntityMontagePush other)
		{
			return other != null && (other == this || (!(this.MontageName != other.MontageName) && this.MontageHashCode == other.MontageHashCode && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.SpeedRatio, other.SpeedRatio) && !(this.StartSection != other.StartSection) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.StartTimeSeconds, other.StartTimeSeconds) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012876 RID: 75894 RVA: 0x002B4500 File Offset: 0x002B2700
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

		// Token: 0x06012877 RID: 75895 RVA: 0x002B45B5 File Offset: 0x002B27B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012878 RID: 75896 RVA: 0x002B45C2 File Offset: 0x002B27C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012879 RID: 75897 RVA: 0x002B45CC File Offset: 0x002B27CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StartTimeSeconds != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.StartTimeSeconds);
			}
			if (this.MontageName.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.MontageName);
			}
			if (this.StartSection.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.StartSection);
			}
			if (this.MontageHashCode != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.MontageHashCode);
			}
			if (this.SpeedRatio != 0f)
			{
				output.WriteRawTag(109);
				output.WriteFloat(this.SpeedRatio);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601287A RID: 75898 RVA: 0x002B4690 File Offset: 0x002B2890
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

		// Token: 0x0601287B RID: 75899 RVA: 0x002B472C File Offset: 0x002B292C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayEntityMontagePush other)
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

		// Token: 0x0601287C RID: 75900 RVA: 0x002B47CC File Offset: 0x002B29CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601287D RID: 75901 RVA: 0x002B47D8 File Offset: 0x002B29D8
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
				if (num <= 34U)
				{
					if (num == 21U)
					{
						this.StartTimeSeconds = input.ReadFloat();
						continue;
					}
					if (num == 34U)
					{
						this.MontageName = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 42U)
					{
						this.StartSection = input.ReadString();
						continue;
					}
					if (num == 80U)
					{
						this.MontageHashCode = input.ReadInt32();
						continue;
					}
					if (num == 109U)
					{
						this.SpeedRatio = input.ReadFloat();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007376 RID: 29558
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007377 RID: 29559
		public const int MontageNameFieldNumber = 4;

		// Token: 0x04007378 RID: 29560
		private string montageName_ = "";

		// Token: 0x04007379 RID: 29561
		public const int MontageHashCodeFieldNumber = 10;

		// Token: 0x0400737A RID: 29562
		private int montageHashCode_;

		// Token: 0x0400737B RID: 29563
		public const int SpeedRatioFieldNumber = 13;

		// Token: 0x0400737C RID: 29564
		private float speedRatio_;

		// Token: 0x0400737D RID: 29565
		public const int StartSectionFieldNumber = 5;

		// Token: 0x0400737E RID: 29566
		private string startSection_ = "";

		// Token: 0x0400737F RID: 29567
		public const int StartTimeSecondsFieldNumber = 2;

		// Token: 0x04007380 RID: 29568
		private float startTimeSeconds_;
	}
}
