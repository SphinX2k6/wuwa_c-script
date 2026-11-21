using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200146D RID: 5229
	public sealed class TransitionMp4Pb : IMessage<TransitionMp4Pb>, IMessage, IEquatable<TransitionMp4Pb>, IDeepCloneable<TransitionMp4Pb>, IBufferMessage
	{
		// Token: 0x0601BC30 RID: 113712 RVA: 0x0040817F File Offset: 0x0040637F
		[NullableContext(1)]
		public static TransitionMp4Pb Create()
		{
			return new TransitionMp4Pb();
		}

		// Token: 0x17005DF0 RID: 24048
		// (get) Token: 0x0601BC31 RID: 113713 RVA: 0x00408186 File Offset: 0x00406386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DF1 RID: 24049
		// (get) Token: 0x0601BC32 RID: 113714 RVA: 0x00408189 File Offset: 0x00406389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransitionMp4Pb.Descriptor;
			}
		}

		// Token: 0x0601BC33 RID: 113715 RVA: 0x00408190 File Offset: 0x00406390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionMp4Pb()
		{
		}

		// Token: 0x0601BC34 RID: 113716 RVA: 0x004081A4 File Offset: 0x004063A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionMp4Pb(TransitionMp4Pb other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.resourePath_ = other.resourePath_;
			this.replayWhenReLogin_ = other.replayWhenReLogin_;
			this.isFadeInScreenAfterTeleport_ = other.isFadeInScreenAfterTeleport_;
			this.mp4BackgroundColor_ = ((other.mp4BackgroundColor_ != null) ? other.mp4BackgroundColor_.Clone() : null);
			this.afterTeleportScreenColor_ = other.afterTeleportScreenColor_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BC35 RID: 113717 RVA: 0x00408220 File Offset: 0x00406420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionMp4Pb Clone()
		{
			return new TransitionMp4Pb(this);
		}

		// Token: 0x17005DF2 RID: 24050
		// (get) Token: 0x0601BC36 RID: 113718 RVA: 0x00408228 File Offset: 0x00406428
		// (set) Token: 0x0601BC37 RID: 113719 RVA: 0x00408230 File Offset: 0x00406430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ResourePath
		{
			get
			{
				return this.resourePath_;
			}
			set
			{
				this.resourePath_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17005DF3 RID: 24051
		// (get) Token: 0x0601BC38 RID: 113720 RVA: 0x00408243 File Offset: 0x00406443
		// (set) Token: 0x0601BC39 RID: 113721 RVA: 0x0040824B File Offset: 0x0040644B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ReplayWhenReLogin
		{
			get
			{
				return this.replayWhenReLogin_;
			}
			set
			{
				this.replayWhenReLogin_ = value;
			}
		}

		// Token: 0x17005DF4 RID: 24052
		// (get) Token: 0x0601BC3A RID: 113722 RVA: 0x00408254 File Offset: 0x00406454
		// (set) Token: 0x0601BC3B RID: 113723 RVA: 0x0040825C File Offset: 0x0040645C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFadeInScreenAfterTeleport
		{
			get
			{
				return this.isFadeInScreenAfterTeleport_;
			}
			set
			{
				this.isFadeInScreenAfterTeleport_ = value;
			}
		}

		// Token: 0x17005DF5 RID: 24053
		// (get) Token: 0x0601BC3C RID: 113724 RVA: 0x00408265 File Offset: 0x00406465
		// (set) Token: 0x0601BC3D RID: 113725 RVA: 0x0040826D File Offset: 0x0040646D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Mp4BackgroundColorPb Mp4BackgroundColor
		{
			get
			{
				return this.mp4BackgroundColor_;
			}
			set
			{
				this.mp4BackgroundColor_ = value;
			}
		}

		// Token: 0x17005DF6 RID: 24054
		// (get) Token: 0x0601BC3E RID: 113726 RVA: 0x00408276 File Offset: 0x00406476
		// (set) Token: 0x0601BC3F RID: 113727 RVA: 0x0040828E File Offset: 0x0040648E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AfterTeleportScreenColor AfterTeleportScreenColor
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.afterTeleportScreenColor_;
				}
				return TransitionMp4Pb.AfterTeleportScreenColorDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.afterTeleportScreenColor_ = value;
			}
		}

		// Token: 0x17005DF7 RID: 24055
		// (get) Token: 0x0601BC40 RID: 113728 RVA: 0x004082A5 File Offset: 0x004064A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasAfterTeleportScreenColor
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0601BC41 RID: 113729 RVA: 0x004082B2 File Offset: 0x004064B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearAfterTeleportScreenColor()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0601BC42 RID: 113730 RVA: 0x004082C3 File Offset: 0x004064C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransitionMp4Pb);
		}

		// Token: 0x0601BC43 RID: 113731 RVA: 0x004082D4 File Offset: 0x004064D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransitionMp4Pb other)
		{
			return other != null && (other == this || (!(this.ResourePath != other.ResourePath) && this.ReplayWhenReLogin == other.ReplayWhenReLogin && this.IsFadeInScreenAfterTeleport == other.IsFadeInScreenAfterTeleport && object.Equals(this.Mp4BackgroundColor, other.Mp4BackgroundColor) && this.AfterTeleportScreenColor == other.AfterTeleportScreenColor && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BC44 RID: 113732 RVA: 0x00408358 File Offset: 0x00406558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ResourePath.Length != 0)
			{
				num ^= this.ResourePath.GetHashCode();
			}
			if (this.ReplayWhenReLogin)
			{
				num ^= this.ReplayWhenReLogin.GetHashCode();
			}
			if (this.IsFadeInScreenAfterTeleport)
			{
				num ^= this.IsFadeInScreenAfterTeleport.GetHashCode();
			}
			if (this.mp4BackgroundColor_ != null)
			{
				num ^= this.Mp4BackgroundColor.GetHashCode();
			}
			if (this.HasAfterTeleportScreenColor)
			{
				num ^= this.AfterTeleportScreenColor.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BC45 RID: 113733 RVA: 0x00408400 File Offset: 0x00406600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BC46 RID: 113734 RVA: 0x0040840D File Offset: 0x0040660D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BC47 RID: 113735 RVA: 0x00408418 File Offset: 0x00406618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ResourePath.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ResourePath);
			}
			if (this.ReplayWhenReLogin)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.ReplayWhenReLogin);
			}
			if (this.IsFadeInScreenAfterTeleport)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsFadeInScreenAfterTeleport);
			}
			if (this.mp4BackgroundColor_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Mp4BackgroundColor);
			}
			if (this.HasAfterTeleportScreenColor)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.AfterTeleportScreenColor);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BC48 RID: 113736 RVA: 0x004084CC File Offset: 0x004066CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ResourePath.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ResourePath);
			}
			if (this.ReplayWhenReLogin)
			{
				num += 2;
			}
			if (this.IsFadeInScreenAfterTeleport)
			{
				num += 2;
			}
			if (this.mp4BackgroundColor_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Mp4BackgroundColor);
			}
			if (this.HasAfterTeleportScreenColor)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AfterTeleportScreenColor);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BC49 RID: 113737 RVA: 0x00408558 File Offset: 0x00406758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TransitionMp4Pb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ResourePath.Length != 0)
			{
				this.ResourePath = other.ResourePath;
			}
			if (other.ReplayWhenReLogin)
			{
				this.ReplayWhenReLogin = other.ReplayWhenReLogin;
			}
			if (other.IsFadeInScreenAfterTeleport)
			{
				this.IsFadeInScreenAfterTeleport = other.IsFadeInScreenAfterTeleport;
			}
			if (other.mp4BackgroundColor_ != null)
			{
				if (this.mp4BackgroundColor_ == null)
				{
					this.Mp4BackgroundColor = new Mp4BackgroundColorPb();
				}
				this.Mp4BackgroundColor.MergeFrom(other.Mp4BackgroundColor);
			}
			if (other.HasAfterTeleportScreenColor)
			{
				this.AfterTeleportScreenColor = other.AfterTeleportScreenColor;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BC4A RID: 113738 RVA: 0x00408601 File Offset: 0x00406801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BC4B RID: 113739 RVA: 0x0040860C File Offset: 0x0040680C
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
					if (num == 10U)
					{
						this.ResourePath = input.ReadString();
						continue;
					}
					if (num == 16U)
					{
						this.ReplayWhenReLogin = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.IsFadeInScreenAfterTeleport = input.ReadBool();
						continue;
					}
					if (num == 34U)
					{
						if (this.mp4BackgroundColor_ == null)
						{
							this.Mp4BackgroundColor = new Mp4BackgroundColorPb();
						}
						input.ReadMessage(this.Mp4BackgroundColor);
						continue;
					}
					if (num == 40U)
					{
						this.AfterTeleportScreenColor = (AfterTeleportScreenColor)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A117 RID: 41239
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A118 RID: 41240
		private int _hasBits0;

		// Token: 0x0400A119 RID: 41241
		public const int ResourePathFieldNumber = 1;

		// Token: 0x0400A11A RID: 41242
		private string resourePath_ = "";

		// Token: 0x0400A11B RID: 41243
		public const int ReplayWhenReLoginFieldNumber = 2;

		// Token: 0x0400A11C RID: 41244
		private bool replayWhenReLogin_;

		// Token: 0x0400A11D RID: 41245
		public const int IsFadeInScreenAfterTeleportFieldNumber = 3;

		// Token: 0x0400A11E RID: 41246
		private bool isFadeInScreenAfterTeleport_;

		// Token: 0x0400A11F RID: 41247
		public const int Mp4BackgroundColorFieldNumber = 4;

		// Token: 0x0400A120 RID: 41248
		private Mp4BackgroundColorPb mp4BackgroundColor_;

		// Token: 0x0400A121 RID: 41249
		public const int AfterTeleportScreenColorFieldNumber = 5;

		// Token: 0x0400A122 RID: 41250
		private static readonly AfterTeleportScreenColor AfterTeleportScreenColorDefaultValue;

		// Token: 0x0400A123 RID: 41251
		private AfterTeleportScreenColor afterTeleportScreenColor_;
	}
}
