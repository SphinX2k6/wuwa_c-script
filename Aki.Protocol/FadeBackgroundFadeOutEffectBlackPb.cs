using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004FF RID: 1279
	public sealed class FadeBackgroundFadeOutEffectBlackPb : IMessage<FadeBackgroundFadeOutEffectBlackPb>, IMessage, IEquatable<FadeBackgroundFadeOutEffectBlackPb>, IDeepCloneable<FadeBackgroundFadeOutEffectBlackPb>, IBufferMessage
	{
		// Token: 0x060078D5 RID: 30933 RVA: 0x00126351 File Offset: 0x00124551
		[NullableContext(1)]
		public static FadeBackgroundFadeOutEffectBlackPb Create()
		{
			return new FadeBackgroundFadeOutEffectBlackPb();
		}

		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x060078D6 RID: 30934 RVA: 0x00126358 File Offset: 0x00124558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x060078D7 RID: 30935 RVA: 0x0012635B File Offset: 0x0012455B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FadeBackgroundFadeOutEffectBlackPb.Descriptor;
			}
		}

		// Token: 0x060078D8 RID: 30936 RVA: 0x00126362 File Offset: 0x00124562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeOutEffectBlackPb()
		{
		}

		// Token: 0x060078D9 RID: 30937 RVA: 0x0012636C File Offset: 0x0012456C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeOutEffectBlackPb(FadeBackgroundFadeOutEffectBlackPb other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.fadeColor_ = other.fadeColor_;
			this.fadeInTime_ = other.fadeInTime_;
			this.fadeOutTime_ = other.fadeOutTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060078DA RID: 30938 RVA: 0x001263C0 File Offset: 0x001245C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeOutEffectBlackPb Clone()
		{
			return new FadeBackgroundFadeOutEffectBlackPb(this);
		}

		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x060078DB RID: 30939 RVA: 0x001263C8 File Offset: 0x001245C8
		// (set) Token: 0x060078DC RID: 30940 RVA: 0x001263D0 File Offset: 0x001245D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FadeColor
		{
			get
			{
				return this.fadeColor_;
			}
			set
			{
				this.fadeColor_ = value;
			}
		}

		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x060078DD RID: 30941 RVA: 0x001263D9 File Offset: 0x001245D9
		// (set) Token: 0x060078DE RID: 30942 RVA: 0x001263F1 File Offset: 0x001245F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float FadeInTime
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.fadeInTime_;
				}
				return FadeBackgroundFadeOutEffectBlackPb.FadeInTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.fadeInTime_ = value;
			}
		}

		// Token: 0x1700176B RID: 5995
		// (get) Token: 0x060078DF RID: 30943 RVA: 0x00126408 File Offset: 0x00124608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFadeInTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060078E0 RID: 30944 RVA: 0x00126415 File Offset: 0x00124615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFadeInTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x060078E1 RID: 30945 RVA: 0x00126426 File Offset: 0x00124626
		// (set) Token: 0x060078E2 RID: 30946 RVA: 0x0012643E File Offset: 0x0012463E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float FadeOutTime
		{
			get
			{
				if ((this._hasBits0 & 2) != 0)
				{
					return this.fadeOutTime_;
				}
				return FadeBackgroundFadeOutEffectBlackPb.FadeOutTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.fadeOutTime_ = value;
			}
		}

		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x060078E3 RID: 30947 RVA: 0x00126455 File Offset: 0x00124655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFadeOutTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060078E4 RID: 30948 RVA: 0x00126462 File Offset: 0x00124662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFadeOutTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060078E5 RID: 30949 RVA: 0x00126473 File Offset: 0x00124673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FadeBackgroundFadeOutEffectBlackPb);
		}

		// Token: 0x060078E6 RID: 30950 RVA: 0x00126484 File Offset: 0x00124684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FadeBackgroundFadeOutEffectBlackPb other)
		{
			return other != null && (other == this || (this.FadeColor == other.FadeColor && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.FadeInTime, other.FadeInTime) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.FadeOutTime, other.FadeOutTime) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060078E7 RID: 30951 RVA: 0x001264F4 File Offset: 0x001246F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FadeColor != 0)
			{
				num ^= this.FadeColor.GetHashCode();
			}
			if (this.HasFadeInTime)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.FadeInTime);
			}
			if (this.HasFadeOutTime)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.FadeOutTime);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060078E8 RID: 30952 RVA: 0x00126569 File Offset: 0x00124769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060078E9 RID: 30953 RVA: 0x00126576 File Offset: 0x00124776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060078EA RID: 30954 RVA: 0x00126580 File Offset: 0x00124780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FadeColor != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FadeColor);
			}
			if (this.HasFadeInTime)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.FadeInTime);
			}
			if (this.HasFadeOutTime)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.FadeOutTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060078EB RID: 30955 RVA: 0x001265F4 File Offset: 0x001247F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FadeColor != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FadeColor);
			}
			if (this.HasFadeInTime)
			{
				num += 5;
			}
			if (this.HasFadeOutTime)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060078EC RID: 30956 RVA: 0x0012664C File Offset: 0x0012484C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FadeBackgroundFadeOutEffectBlackPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FadeColor != 0)
			{
				this.FadeColor = other.FadeColor;
			}
			if (other.HasFadeInTime)
			{
				this.FadeInTime = other.FadeInTime;
			}
			if (other.HasFadeOutTime)
			{
				this.FadeOutTime = other.FadeOutTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060078ED RID: 30957 RVA: 0x001266B0 File Offset: 0x001248B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060078EE RID: 30958 RVA: 0x001266BC File Offset: 0x001248BC
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
				if (num != 8U)
				{
					if (num != 21U)
					{
						if (num != 29U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.FadeOutTime = input.ReadFloat();
						}
					}
					else
					{
						this.FadeInTime = input.ReadFloat();
					}
				}
				else
				{
					this.FadeColor = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003ED5 RID: 16085
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003ED6 RID: 16086
		private int _hasBits0;

		// Token: 0x04003ED7 RID: 16087
		public const int FadeColorFieldNumber = 1;

		// Token: 0x04003ED8 RID: 16088
		private int fadeColor_;

		// Token: 0x04003ED9 RID: 16089
		public const int FadeInTimeFieldNumber = 2;

		// Token: 0x04003EDA RID: 16090
		private static readonly float FadeInTimeDefaultValue;

		// Token: 0x04003EDB RID: 16091
		private float fadeInTime_;

		// Token: 0x04003EDC RID: 16092
		public const int FadeOutTimeFieldNumber = 3;

		// Token: 0x04003EDD RID: 16093
		private static readonly float FadeOutTimeDefaultValue;

		// Token: 0x04003EDE RID: 16094
		private float fadeOutTime_;
	}
}
