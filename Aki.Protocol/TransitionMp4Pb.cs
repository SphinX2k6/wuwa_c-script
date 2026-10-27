using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013FA RID: 5114
	public sealed class TransitionMp4Pb : IMessage<TransitionMp4Pb>, IMessage, IEquatable<TransitionMp4Pb>, IDeepCloneable<TransitionMp4Pb>, IBufferMessage
	{
		// Token: 0x0601B1A5 RID: 111013 RVA: 0x003ECEAB File Offset: 0x003EB0AB
		[NullableContext(1)]
		public static TransitionMp4Pb Create()
		{
			return new TransitionMp4Pb();
		}

		// Token: 0x17005B5B RID: 23387
		// (get) Token: 0x0601B1A6 RID: 111014 RVA: 0x003ECEB2 File Offset: 0x003EB0B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B5C RID: 23388
		// (get) Token: 0x0601B1A7 RID: 111015 RVA: 0x003ECEB5 File Offset: 0x003EB0B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransitionMp4Pb.Descriptor;
			}
		}

		// Token: 0x0601B1A8 RID: 111016 RVA: 0x003ECEBC File Offset: 0x003EB0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionMp4Pb()
		{
		}

		// Token: 0x0601B1A9 RID: 111017 RVA: 0x003ECED0 File Offset: 0x003EB0D0
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

		// Token: 0x0601B1AA RID: 111018 RVA: 0x003ECF4C File Offset: 0x003EB14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionMp4Pb Clone()
		{
			return new TransitionMp4Pb(this);
		}

		// Token: 0x17005B5D RID: 23389
		// (get) Token: 0x0601B1AB RID: 111019 RVA: 0x003ECF54 File Offset: 0x003EB154
		// (set) Token: 0x0601B1AC RID: 111020 RVA: 0x003ECF5C File Offset: 0x003EB15C
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

		// Token: 0x17005B5E RID: 23390
		// (get) Token: 0x0601B1AD RID: 111021 RVA: 0x003ECF6F File Offset: 0x003EB16F
		// (set) Token: 0x0601B1AE RID: 111022 RVA: 0x003ECF77 File Offset: 0x003EB177
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

		// Token: 0x17005B5F RID: 23391
		// (get) Token: 0x0601B1AF RID: 111023 RVA: 0x003ECF80 File Offset: 0x003EB180
		// (set) Token: 0x0601B1B0 RID: 111024 RVA: 0x003ECF88 File Offset: 0x003EB188
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

		// Token: 0x17005B60 RID: 23392
		// (get) Token: 0x0601B1B1 RID: 111025 RVA: 0x003ECF91 File Offset: 0x003EB191
		// (set) Token: 0x0601B1B2 RID: 111026 RVA: 0x003ECF99 File Offset: 0x003EB199
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

		// Token: 0x17005B61 RID: 23393
		// (get) Token: 0x0601B1B3 RID: 111027 RVA: 0x003ECFA2 File Offset: 0x003EB1A2
		// (set) Token: 0x0601B1B4 RID: 111028 RVA: 0x003ECFBA File Offset: 0x003EB1BA
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

		// Token: 0x17005B62 RID: 23394
		// (get) Token: 0x0601B1B5 RID: 111029 RVA: 0x003ECFD1 File Offset: 0x003EB1D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasAfterTeleportScreenColor
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0601B1B6 RID: 111030 RVA: 0x003ECFDE File Offset: 0x003EB1DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearAfterTeleportScreenColor()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0601B1B7 RID: 111031 RVA: 0x003ECFEF File Offset: 0x003EB1EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransitionMp4Pb);
		}

		// Token: 0x0601B1B8 RID: 111032 RVA: 0x003ED000 File Offset: 0x003EB200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransitionMp4Pb other)
		{
			return other != null && (other == this || (!(this.ResourePath != other.ResourePath) && this.ReplayWhenReLogin == other.ReplayWhenReLogin && this.IsFadeInScreenAfterTeleport == other.IsFadeInScreenAfterTeleport && object.Equals(this.Mp4BackgroundColor, other.Mp4BackgroundColor) && this.AfterTeleportScreenColor == other.AfterTeleportScreenColor && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B1B9 RID: 111033 RVA: 0x003ED084 File Offset: 0x003EB284
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

		// Token: 0x0601B1BA RID: 111034 RVA: 0x003ED12C File Offset: 0x003EB32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B1BB RID: 111035 RVA: 0x003ED139 File Offset: 0x003EB339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B1BC RID: 111036 RVA: 0x003ED144 File Offset: 0x003EB344
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

		// Token: 0x0601B1BD RID: 111037 RVA: 0x003ED1F8 File Offset: 0x003EB3F8
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

		// Token: 0x0601B1BE RID: 111038 RVA: 0x003ED284 File Offset: 0x003EB484
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

		// Token: 0x0601B1BF RID: 111039 RVA: 0x003ED32D File Offset: 0x003EB52D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B1C0 RID: 111040 RVA: 0x003ED338 File Offset: 0x003EB538
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

		// Token: 0x04009CD0 RID: 40144
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CD1 RID: 40145
		private int _hasBits0;

		// Token: 0x04009CD2 RID: 40146
		public const int ResourePathFieldNumber = 1;

		// Token: 0x04009CD3 RID: 40147
		private string resourePath_ = "";

		// Token: 0x04009CD4 RID: 40148
		public const int ReplayWhenReLoginFieldNumber = 2;

		// Token: 0x04009CD5 RID: 40149
		private bool replayWhenReLogin_;

		// Token: 0x04009CD6 RID: 40150
		public const int IsFadeInScreenAfterTeleportFieldNumber = 3;

		// Token: 0x04009CD7 RID: 40151
		private bool isFadeInScreenAfterTeleport_;

		// Token: 0x04009CD8 RID: 40152
		public const int Mp4BackgroundColorFieldNumber = 4;

		// Token: 0x04009CD9 RID: 40153
		private Mp4BackgroundColorPb mp4BackgroundColor_;

		// Token: 0x04009CDA RID: 40154
		public const int AfterTeleportScreenColorFieldNumber = 5;

		// Token: 0x04009CDB RID: 40155
		private static readonly AfterTeleportScreenColor AfterTeleportScreenColorDefaultValue;

		// Token: 0x04009CDC RID: 40156
		private AfterTeleportScreenColor afterTeleportScreenColor_;
	}
}
