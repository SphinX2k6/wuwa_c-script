using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004FC RID: 1276
	public sealed class FadeBackgroundFadeInEffectBlackPb : IMessage<FadeBackgroundFadeInEffectBlackPb>, IMessage, IEquatable<FadeBackgroundFadeInEffectBlackPb>, IDeepCloneable<FadeBackgroundFadeInEffectBlackPb>, IBufferMessage
	{
		// Token: 0x06007893 RID: 30867 RVA: 0x001259CA File Offset: 0x00123BCA
		[NullableContext(1)]
		public static FadeBackgroundFadeInEffectBlackPb Create()
		{
			return new FadeBackgroundFadeInEffectBlackPb();
		}

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x06007894 RID: 30868 RVA: 0x001259D1 File Offset: 0x00123BD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x06007895 RID: 30869 RVA: 0x001259D4 File Offset: 0x00123BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FadeBackgroundFadeInEffectBlackPb.Descriptor;
			}
		}

		// Token: 0x06007896 RID: 30870 RVA: 0x001259DB File Offset: 0x00123BDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeInEffectBlackPb()
		{
		}

		// Token: 0x06007897 RID: 30871 RVA: 0x001259E4 File Offset: 0x00123BE4
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

		// Token: 0x06007898 RID: 30872 RVA: 0x00125A38 File Offset: 0x00123C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeInEffectBlackPb Clone()
		{
			return new FadeBackgroundFadeInEffectBlackPb(this);
		}

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x06007899 RID: 30873 RVA: 0x00125A40 File Offset: 0x00123C40
		// (set) Token: 0x0600789A RID: 30874 RVA: 0x00125A48 File Offset: 0x00123C48
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

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x0600789B RID: 30875 RVA: 0x00125A51 File Offset: 0x00123C51
		// (set) Token: 0x0600789C RID: 30876 RVA: 0x00125A69 File Offset: 0x00123C69
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

		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x0600789D RID: 30877 RVA: 0x00125A80 File Offset: 0x00123C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFadeInTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600789E RID: 30878 RVA: 0x00125A8D File Offset: 0x00123C8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFadeInTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x0600789F RID: 30879 RVA: 0x00125A9E File Offset: 0x00123C9E
		// (set) Token: 0x060078A0 RID: 30880 RVA: 0x00125AB6 File Offset: 0x00123CB6
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

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x060078A1 RID: 30881 RVA: 0x00125ACD File Offset: 0x00123CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFadeOutTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060078A2 RID: 30882 RVA: 0x00125ADA File Offset: 0x00123CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFadeOutTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060078A3 RID: 30883 RVA: 0x00125AEB File Offset: 0x00123CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FadeBackgroundFadeInEffectBlackPb);
		}

		// Token: 0x060078A4 RID: 30884 RVA: 0x00125AFC File Offset: 0x00123CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FadeBackgroundFadeInEffectBlackPb other)
		{
			return other != null && (other == this || (this.FadeColor == other.FadeColor && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.FadeInTime, other.FadeInTime) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.FadeOutTime, other.FadeOutTime) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060078A5 RID: 30885 RVA: 0x00125B6C File Offset: 0x00123D6C
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

		// Token: 0x060078A6 RID: 30886 RVA: 0x00125BE1 File Offset: 0x00123DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060078A7 RID: 30887 RVA: 0x00125BEE File Offset: 0x00123DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060078A8 RID: 30888 RVA: 0x00125BF8 File Offset: 0x00123DF8
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

		// Token: 0x060078A9 RID: 30889 RVA: 0x00125C6C File Offset: 0x00123E6C
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

		// Token: 0x060078AA RID: 30890 RVA: 0x00125CC4 File Offset: 0x00123EC4
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

		// Token: 0x060078AB RID: 30891 RVA: 0x00125D28 File Offset: 0x00123F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060078AC RID: 30892 RVA: 0x00125D34 File Offset: 0x00123F34
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

		// Token: 0x04003EC3 RID: 16067
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EC4 RID: 16068
		private int _hasBits0;

		// Token: 0x04003EC5 RID: 16069
		public const int FadeColorFieldNumber = 1;

		// Token: 0x04003EC6 RID: 16070
		private int fadeColor_;

		// Token: 0x04003EC7 RID: 16071
		public const int FadeInTimeFieldNumber = 2;

		// Token: 0x04003EC8 RID: 16072
		private static readonly float FadeInTimeDefaultValue;

		// Token: 0x04003EC9 RID: 16073
		private float fadeInTime_;

		// Token: 0x04003ECA RID: 16074
		public const int FadeOutTimeFieldNumber = 3;

		// Token: 0x04003ECB RID: 16075
		private static readonly float FadeOutTimeDefaultValue;

		// Token: 0x04003ECC RID: 16076
		private float fadeOutTime_;
	}
}
