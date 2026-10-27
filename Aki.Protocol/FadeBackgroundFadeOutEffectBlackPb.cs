using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000515 RID: 1301
	public sealed class FadeBackgroundFadeOutEffectBlackPb : IMessage<FadeBackgroundFadeOutEffectBlackPb>, IMessage, IEquatable<FadeBackgroundFadeOutEffectBlackPb>, IDeepCloneable<FadeBackgroundFadeOutEffectBlackPb>, IBufferMessage
	{
		// Token: 0x06007A51 RID: 31313 RVA: 0x001291E5 File Offset: 0x001273E5
		[NullableContext(1)]
		public static FadeBackgroundFadeOutEffectBlackPb Create()
		{
			return new FadeBackgroundFadeOutEffectBlackPb();
		}

		// Token: 0x170017B8 RID: 6072
		// (get) Token: 0x06007A52 RID: 31314 RVA: 0x001291EC File Offset: 0x001273EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017B9 RID: 6073
		// (get) Token: 0x06007A53 RID: 31315 RVA: 0x001291EF File Offset: 0x001273EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FadeBackgroundFadeOutEffectBlackPb.Descriptor;
			}
		}

		// Token: 0x06007A54 RID: 31316 RVA: 0x001291F6 File Offset: 0x001273F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeOutEffectBlackPb()
		{
		}

		// Token: 0x06007A55 RID: 31317 RVA: 0x00129200 File Offset: 0x00127400
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

		// Token: 0x06007A56 RID: 31318 RVA: 0x00129254 File Offset: 0x00127454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeOutEffectBlackPb Clone()
		{
			return new FadeBackgroundFadeOutEffectBlackPb(this);
		}

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x06007A57 RID: 31319 RVA: 0x0012925C File Offset: 0x0012745C
		// (set) Token: 0x06007A58 RID: 31320 RVA: 0x00129264 File Offset: 0x00127464
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

		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x06007A59 RID: 31321 RVA: 0x0012926D File Offset: 0x0012746D
		// (set) Token: 0x06007A5A RID: 31322 RVA: 0x00129285 File Offset: 0x00127485
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

		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x06007A5B RID: 31323 RVA: 0x0012929C File Offset: 0x0012749C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFadeInTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007A5C RID: 31324 RVA: 0x001292A9 File Offset: 0x001274A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFadeInTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x06007A5D RID: 31325 RVA: 0x001292BA File Offset: 0x001274BA
		// (set) Token: 0x06007A5E RID: 31326 RVA: 0x001292D2 File Offset: 0x001274D2
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

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x06007A5F RID: 31327 RVA: 0x001292E9 File Offset: 0x001274E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFadeOutTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007A60 RID: 31328 RVA: 0x001292F6 File Offset: 0x001274F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFadeOutTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06007A61 RID: 31329 RVA: 0x00129307 File Offset: 0x00127507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FadeBackgroundFadeOutEffectBlackPb);
		}

		// Token: 0x06007A62 RID: 31330 RVA: 0x00129318 File Offset: 0x00127518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FadeBackgroundFadeOutEffectBlackPb other)
		{
			return other != null && (other == this || (this.FadeColor == other.FadeColor && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.FadeInTime, other.FadeInTime) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.FadeOutTime, other.FadeOutTime) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007A63 RID: 31331 RVA: 0x00129388 File Offset: 0x00127588
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

		// Token: 0x06007A64 RID: 31332 RVA: 0x001293FD File Offset: 0x001275FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007A65 RID: 31333 RVA: 0x0012940A File Offset: 0x0012760A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A66 RID: 31334 RVA: 0x00129414 File Offset: 0x00127614
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

		// Token: 0x06007A67 RID: 31335 RVA: 0x00129488 File Offset: 0x00127688
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

		// Token: 0x06007A68 RID: 31336 RVA: 0x001294E0 File Offset: 0x001276E0
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

		// Token: 0x06007A69 RID: 31337 RVA: 0x00129544 File Offset: 0x00127744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A6A RID: 31338 RVA: 0x00129550 File Offset: 0x00127750
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

		// Token: 0x04003EE4 RID: 16100
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EE5 RID: 16101
		private int _hasBits0;

		// Token: 0x04003EE6 RID: 16102
		public const int FadeColorFieldNumber = 1;

		// Token: 0x04003EE7 RID: 16103
		private int fadeColor_;

		// Token: 0x04003EE8 RID: 16104
		public const int FadeInTimeFieldNumber = 2;

		// Token: 0x04003EE9 RID: 16105
		private static readonly float FadeInTimeDefaultValue;

		// Token: 0x04003EEA RID: 16106
		private float fadeInTime_;

		// Token: 0x04003EEB RID: 16107
		public const int FadeOutTimeFieldNumber = 3;

		// Token: 0x04003EEC RID: 16108
		private static readonly float FadeOutTimeDefaultValue;

		// Token: 0x04003EED RID: 16109
		private float fadeOutTime_;
	}
}
