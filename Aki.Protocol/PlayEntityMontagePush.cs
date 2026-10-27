using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D78 RID: 3448
	[NetMessage(EMessageId.PlayEntityMontagePush)]
	public sealed class PlayEntityMontagePush : IMessage<PlayEntityMontagePush>, IMessage, IEquatable<PlayEntityMontagePush>, IDeepCloneable<PlayEntityMontagePush>, IBufferMessage
	{
		// Token: 0x06012960 RID: 76128 RVA: 0x002B5F72 File Offset: 0x002B4172
		[NullableContext(1)]
		public static PlayEntityMontagePush Create()
		{
			return new PlayEntityMontagePush();
		}

		// Token: 0x17003D9B RID: 15771
		// (get) Token: 0x06012961 RID: 76129 RVA: 0x002B5F79 File Offset: 0x002B4179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D9C RID: 15772
		// (get) Token: 0x06012962 RID: 76130 RVA: 0x002B5F7C File Offset: 0x002B417C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayEntityMontagePush.Descriptor;
			}
		}

		// Token: 0x06012963 RID: 76131 RVA: 0x002B5F83 File Offset: 0x002B4183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayEntityMontagePush()
		{
		}

		// Token: 0x06012964 RID: 76132 RVA: 0x002B5FA4 File Offset: 0x002B41A4
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

		// Token: 0x06012965 RID: 76133 RVA: 0x002B6004 File Offset: 0x002B4204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayEntityMontagePush Clone()
		{
			return new PlayEntityMontagePush(this);
		}

		// Token: 0x17003D9D RID: 15773
		// (get) Token: 0x06012966 RID: 76134 RVA: 0x002B600C File Offset: 0x002B420C
		// (set) Token: 0x06012967 RID: 76135 RVA: 0x002B6014 File Offset: 0x002B4214
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

		// Token: 0x17003D9E RID: 15774
		// (get) Token: 0x06012968 RID: 76136 RVA: 0x002B6027 File Offset: 0x002B4227
		// (set) Token: 0x06012969 RID: 76137 RVA: 0x002B602F File Offset: 0x002B422F
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

		// Token: 0x17003D9F RID: 15775
		// (get) Token: 0x0601296A RID: 76138 RVA: 0x002B6038 File Offset: 0x002B4238
		// (set) Token: 0x0601296B RID: 76139 RVA: 0x002B6040 File Offset: 0x002B4240
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

		// Token: 0x17003DA0 RID: 15776
		// (get) Token: 0x0601296C RID: 76140 RVA: 0x002B6049 File Offset: 0x002B4249
		// (set) Token: 0x0601296D RID: 76141 RVA: 0x002B6051 File Offset: 0x002B4251
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

		// Token: 0x17003DA1 RID: 15777
		// (get) Token: 0x0601296E RID: 76142 RVA: 0x002B6064 File Offset: 0x002B4264
		// (set) Token: 0x0601296F RID: 76143 RVA: 0x002B606C File Offset: 0x002B426C
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

		// Token: 0x06012970 RID: 76144 RVA: 0x002B6075 File Offset: 0x002B4275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayEntityMontagePush);
		}

		// Token: 0x06012971 RID: 76145 RVA: 0x002B6084 File Offset: 0x002B4284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayEntityMontagePush other)
		{
			return other != null && (other == this || (!(this.MontageName != other.MontageName) && this.MontageHashCode == other.MontageHashCode && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.SpeedRatio, other.SpeedRatio) && !(this.StartSection != other.StartSection) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.StartTimeSeconds, other.StartTimeSeconds) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012972 RID: 76146 RVA: 0x002B611C File Offset: 0x002B431C
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

		// Token: 0x06012973 RID: 76147 RVA: 0x002B61D1 File Offset: 0x002B43D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012974 RID: 76148 RVA: 0x002B61DE File Offset: 0x002B43DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012975 RID: 76149 RVA: 0x002B61E8 File Offset: 0x002B43E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StartSection.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.StartSection);
			}
			if (this.MontageHashCode != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MontageHashCode);
			}
			if (this.StartTimeSeconds != 0f)
			{
				output.WriteRawTag(61);
				output.WriteFloat(this.StartTimeSeconds);
			}
			if (this.SpeedRatio != 0f)
			{
				output.WriteRawTag(85);
				output.WriteFloat(this.SpeedRatio);
			}
			if (this.MontageName.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.MontageName);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012976 RID: 76150 RVA: 0x002B62AC File Offset: 0x002B44AC
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

		// Token: 0x06012977 RID: 76151 RVA: 0x002B6348 File Offset: 0x002B4548
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

		// Token: 0x06012978 RID: 76152 RVA: 0x002B63E8 File Offset: 0x002B45E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012979 RID: 76153 RVA: 0x002B63F4 File Offset: 0x002B45F4
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
				if (num <= 32U)
				{
					if (num == 10U)
					{
						this.StartSection = input.ReadString();
						continue;
					}
					if (num == 32U)
					{
						this.MontageHashCode = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 61U)
					{
						this.StartTimeSeconds = input.ReadFloat();
						continue;
					}
					if (num == 85U)
					{
						this.SpeedRatio = input.ReadFloat();
						continue;
					}
					if (num == 122U)
					{
						this.MontageName = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400735E RID: 29534
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400735F RID: 29535
		public const int MontageNameFieldNumber = 15;

		// Token: 0x04007360 RID: 29536
		private string montageName_ = "";

		// Token: 0x04007361 RID: 29537
		public const int MontageHashCodeFieldNumber = 4;

		// Token: 0x04007362 RID: 29538
		private int montageHashCode_;

		// Token: 0x04007363 RID: 29539
		public const int SpeedRatioFieldNumber = 10;

		// Token: 0x04007364 RID: 29540
		private float speedRatio_;

		// Token: 0x04007365 RID: 29541
		public const int StartSectionFieldNumber = 1;

		// Token: 0x04007366 RID: 29542
		private string startSection_ = "";

		// Token: 0x04007367 RID: 29543
		public const int StartTimeSecondsFieldNumber = 7;

		// Token: 0x04007368 RID: 29544
		private float startTimeSeconds_;
	}
}
