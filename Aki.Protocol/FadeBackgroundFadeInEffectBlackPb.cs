using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000512 RID: 1298
	public sealed class FadeBackgroundFadeInEffectBlackPb : IMessage<FadeBackgroundFadeInEffectBlackPb>, IMessage, IEquatable<FadeBackgroundFadeInEffectBlackPb>, IDeepCloneable<FadeBackgroundFadeInEffectBlackPb>, IBufferMessage
	{
		// Token: 0x06007A0F RID: 31247 RVA: 0x0012885E File Offset: 0x00126A5E
		[NullableContext(1)]
		public static FadeBackgroundFadeInEffectBlackPb Create()
		{
			return new FadeBackgroundFadeInEffectBlackPb();
		}

		// Token: 0x170017A9 RID: 6057
		// (get) Token: 0x06007A10 RID: 31248 RVA: 0x00128865 File Offset: 0x00126A65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017AA RID: 6058
		// (get) Token: 0x06007A11 RID: 31249 RVA: 0x00128868 File Offset: 0x00126A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FadeBackgroundFadeInEffectBlackPb.Descriptor;
			}
		}

		// Token: 0x06007A12 RID: 31250 RVA: 0x0012886F File Offset: 0x00126A6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeInEffectBlackPb()
		{
		}

		// Token: 0x06007A13 RID: 31251 RVA: 0x00128878 File Offset: 0x00126A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeInEffectBlackPb(FadeBackgroundFadeInEffectBlackPb other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.fadeColor_ = other.fadeColor_;
			this.fadeInTime_ = other.fadeInTime_;
			this.fadeOutTime_ = other.fadeOutTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A14 RID: 31252 RVA: 0x001288CC File Offset: 0x00126ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeInEffectBlackPb Clone()
		{
			return new FadeBackgroundFadeInEffectBlackPb(this);
		}

		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x06007A15 RID: 31253 RVA: 0x001288D4 File Offset: 0x00126AD4
		// (set) Token: 0x06007A16 RID: 31254 RVA: 0x001288DC File Offset: 0x00126ADC
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

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x06007A17 RID: 31255 RVA: 0x001288E5 File Offset: 0x00126AE5
		// (set) Token: 0x06007A18 RID: 31256 RVA: 0x001288FD File Offset: 0x00126AFD
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
				return FadeBackgroundFadeInEffectBlackPb.FadeInTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.fadeInTime_ = value;
			}
		}

		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x06007A19 RID: 31257 RVA: 0x00128914 File Offset: 0x00126B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFadeInTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007A1A RID: 31258 RVA: 0x00128921 File Offset: 0x00126B21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFadeInTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x06007A1B RID: 31259 RVA: 0x00128932 File Offset: 0x00126B32
		// (set) Token: 0x06007A1C RID: 31260 RVA: 0x0012894A File Offset: 0x00126B4A
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
				return FadeBackgroundFadeInEffectBlackPb.FadeOutTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.fadeOutTime_ = value;
			}
		}

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x06007A1D RID: 31261 RVA: 0x00128961 File Offset: 0x00126B61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFadeOutTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007A1E RID: 31262 RVA: 0x0012896E File Offset: 0x00126B6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFadeOutTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06007A1F RID: 31263 RVA: 0x0012897F File Offset: 0x00126B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FadeBackgroundFadeInEffectBlackPb);
		}

		// Token: 0x06007A20 RID: 31264 RVA: 0x00128990 File Offset: 0x00126B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FadeBackgroundFadeInEffectBlackPb other)
		{
			return other != null && (other == this || (this.FadeColor == other.FadeColor && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.FadeInTime, other.FadeInTime) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.FadeOutTime, other.FadeOutTime) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007A21 RID: 31265 RVA: 0x00128A00 File Offset: 0x00126C00
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

		// Token: 0x06007A22 RID: 31266 RVA: 0x00128A75 File Offset: 0x00126C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007A23 RID: 31267 RVA: 0x00128A82 File Offset: 0x00126C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A24 RID: 31268 RVA: 0x00128A8C File Offset: 0x00126C8C
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

		// Token: 0x06007A25 RID: 31269 RVA: 0x00128B00 File Offset: 0x00126D00
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

		// Token: 0x06007A26 RID: 31270 RVA: 0x00128B58 File Offset: 0x00126D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FadeBackgroundFadeInEffectBlackPb other)
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

		// Token: 0x06007A27 RID: 31271 RVA: 0x00128BBC File Offset: 0x00126DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A28 RID: 31272 RVA: 0x00128BC8 File Offset: 0x00126DC8
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

		// Token: 0x04003ED2 RID: 16082
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003ED3 RID: 16083
		private int _hasBits0;

		// Token: 0x04003ED4 RID: 16084
		public const int FadeColorFieldNumber = 1;

		// Token: 0x04003ED5 RID: 16085
		private int fadeColor_;

		// Token: 0x04003ED6 RID: 16086
		public const int FadeInTimeFieldNumber = 2;

		// Token: 0x04003ED7 RID: 16087
		private static readonly float FadeInTimeDefaultValue;

		// Token: 0x04003ED8 RID: 16088
		private float fadeInTime_;

		// Token: 0x04003ED9 RID: 16089
		public const int FadeOutTimeFieldNumber = 3;

		// Token: 0x04003EDA RID: 16090
		private static readonly float FadeOutTimeDefaultValue;

		// Token: 0x04003EDB RID: 16091
		private float fadeOutTime_;
	}
}
