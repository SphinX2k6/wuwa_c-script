using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004FD RID: 1277
	public sealed class FadeBackgroundFadeInEffectPb : IMessage<FadeBackgroundFadeInEffectPb>, IMessage, IEquatable<FadeBackgroundFadeInEffectPb>, IDeepCloneable<FadeBackgroundFadeInEffectPb>, IBufferMessage
	{
		// Token: 0x060078AD RID: 30893 RVA: 0x00125D9E File Offset: 0x00123F9E
		[NullableContext(1)]
		public static FadeBackgroundFadeInEffectPb Create()
		{
			return new FadeBackgroundFadeInEffectPb();
		}

		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x060078AE RID: 30894 RVA: 0x00125DA5 File Offset: 0x00123FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x060078AF RID: 30895 RVA: 0x00125DA8 File Offset: 0x00123FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FadeBackgroundFadeInEffectPb.Descriptor;
			}
		}

		// Token: 0x060078B0 RID: 30896 RVA: 0x00125DAF File Offset: 0x00123FAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeInEffectPb()
		{
		}

		// Token: 0x060078B1 RID: 30897 RVA: 0x00125DB8 File Offset: 0x00123FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeInEffectPb(FadeBackgroundFadeInEffectPb other) : this()
		{
			FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase fadeInEffectPbCase = other.FadeInEffectPbCase;
			if (fadeInEffectPbCase != FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase.FadeBackgroundFadeInEffectBlackPb)
			{
				if (fadeInEffectPbCase == FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase.FadeBackgroundFadeInEffectScreenPb)
				{
					this.FadeBackgroundFadeInEffectScreenPb = other.FadeBackgroundFadeInEffectScreenPb.Clone();
				}
			}
			else
			{
				this.FadeBackgroundFadeInEffectBlackPb = other.FadeBackgroundFadeInEffectBlackPb.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060078B2 RID: 30898 RVA: 0x00125E11 File Offset: 0x00124011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeInEffectPb Clone()
		{
			return new FadeBackgroundFadeInEffectPb(this);
		}

		// Token: 0x17001761 RID: 5985
		// (get) Token: 0x060078B3 RID: 30899 RVA: 0x00125E19 File Offset: 0x00124019
		// (set) Token: 0x060078B4 RID: 30900 RVA: 0x00125E31 File Offset: 0x00124031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeInEffectBlackPb FadeBackgroundFadeInEffectBlackPb
		{
			get
			{
				if (this.fadeInEffectPbCase_ != FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase.FadeBackgroundFadeInEffectBlackPb)
				{
					return null;
				}
				return (FadeBackgroundFadeInEffectBlackPb)this.fadeInEffectPb_;
			}
			set
			{
				this.fadeInEffectPb_ = value;
				this.fadeInEffectPbCase_ = ((value == null) ? FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase.None : FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase.FadeBackgroundFadeInEffectBlackPb);
			}
		}

		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x060078B5 RID: 30901 RVA: 0x00125E47 File Offset: 0x00124047
		// (set) Token: 0x060078B6 RID: 30902 RVA: 0x00125E5F File Offset: 0x0012405F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeInEffectScreenPb FadeBackgroundFadeInEffectScreenPb
		{
			get
			{
				if (this.fadeInEffectPbCase_ != FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase.FadeBackgroundFadeInEffectScreenPb)
				{
					return null;
				}
				return (FadeBackgroundFadeInEffectScreenPb)this.fadeInEffectPb_;
			}
			set
			{
				this.fadeInEffectPb_ = value;
				this.fadeInEffectPbCase_ = ((value == null) ? FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase.None : FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase.FadeBackgroundFadeInEffectScreenPb);
			}
		}

		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x060078B7 RID: 30903 RVA: 0x00125E75 File Offset: 0x00124075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase FadeInEffectPbCase
		{
			get
			{
				return this.fadeInEffectPbCase_;
			}
		}

		// Token: 0x060078B8 RID: 30904 RVA: 0x00125E7D File Offset: 0x0012407D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFadeInEffectPb()
		{
			this.fadeInEffectPbCase_ = FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase.None;
			this.fadeInEffectPb_ = null;
		}

		// Token: 0x060078B9 RID: 30905 RVA: 0x00125E8D File Offset: 0x0012408D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FadeBackgroundFadeInEffectPb);
		}

		// Token: 0x060078BA RID: 30906 RVA: 0x00125E9C File Offset: 0x0012409C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FadeBackgroundFadeInEffectPb other)
		{
			return other != null && (other == this || (object.Equals(this.FadeBackgroundFadeInEffectBlackPb, other.FadeBackgroundFadeInEffectBlackPb) && object.Equals(this.FadeBackgroundFadeInEffectScreenPb, other.FadeBackgroundFadeInEffectScreenPb) && this.FadeInEffectPbCase == other.FadeInEffectPbCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060078BB RID: 30907 RVA: 0x00125F00 File Offset: 0x00124100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.fadeInEffectPbCase_ == FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase.FadeBackgroundFadeInEffectBlackPb)
			{
				num ^= this.FadeBackgroundFadeInEffectBlackPb.GetHashCode();
			}
			if (this.fadeInEffectPbCase_ == FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase.FadeBackgroundFadeInEffectScreenPb)
			{
				num ^= this.FadeBackgroundFadeInEffectScreenPb.GetHashCode();
			}
			num ^= (int)this.fadeInEffectPbCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060078BC RID: 30908 RVA: 0x00125F5D File Offset: 0x0012415D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060078BD RID: 30909 RVA: 0x00125F6A File Offset: 0x0012416A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060078BE RID: 30910 RVA: 0x00125F74 File Offset: 0x00124174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fadeInEffectPbCase_ == FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase.FadeBackgroundFadeInEffectBlackPb)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.FadeBackgroundFadeInEffectBlackPb);
			}
			if (this.fadeInEffectPbCase_ == FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase.FadeBackgroundFadeInEffectScreenPb)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.FadeBackgroundFadeInEffectScreenPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060078BF RID: 30911 RVA: 0x00125FD0 File Offset: 0x001241D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.fadeInEffectPbCase_ == FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase.FadeBackgroundFadeInEffectBlackPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FadeBackgroundFadeInEffectBlackPb);
			}
			if (this.fadeInEffectPbCase_ == FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase.FadeBackgroundFadeInEffectScreenPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FadeBackgroundFadeInEffectScreenPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060078C0 RID: 30912 RVA: 0x00126028 File Offset: 0x00124228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FadeBackgroundFadeInEffectPb other)
		{
			if (other == null)
			{
				return;
			}
			FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase fadeInEffectPbCase = other.FadeInEffectPbCase;
			if (fadeInEffectPbCase != FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase.FadeBackgroundFadeInEffectBlackPb)
			{
				if (fadeInEffectPbCase == FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase.FadeBackgroundFadeInEffectScreenPb)
				{
					if (this.FadeBackgroundFadeInEffectScreenPb == null)
					{
						this.FadeBackgroundFadeInEffectScreenPb = new FadeBackgroundFadeInEffectScreenPb();
					}
					this.FadeBackgroundFadeInEffectScreenPb.MergeFrom(other.FadeBackgroundFadeInEffectScreenPb);
				}
			}
			else
			{
				if (this.FadeBackgroundFadeInEffectBlackPb == null)
				{
					this.FadeBackgroundFadeInEffectBlackPb = new FadeBackgroundFadeInEffectBlackPb();
				}
				this.FadeBackgroundFadeInEffectBlackPb.MergeFrom(other.FadeBackgroundFadeInEffectBlackPb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060078C1 RID: 30913 RVA: 0x001260AB File Offset: 0x001242AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060078C2 RID: 30914 RVA: 0x001260B4 File Offset: 0x001242B4
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						FadeBackgroundFadeInEffectScreenPb fadeBackgroundFadeInEffectScreenPb = new FadeBackgroundFadeInEffectScreenPb();
						if (this.fadeInEffectPbCase_ == FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase.FadeBackgroundFadeInEffectScreenPb)
						{
							fadeBackgroundFadeInEffectScreenPb.MergeFrom(this.FadeBackgroundFadeInEffectScreenPb);
						}
						input.ReadMessage(fadeBackgroundFadeInEffectScreenPb);
						this.FadeBackgroundFadeInEffectScreenPb = fadeBackgroundFadeInEffectScreenPb;
					}
				}
				else
				{
					FadeBackgroundFadeInEffectBlackPb fadeBackgroundFadeInEffectBlackPb = new FadeBackgroundFadeInEffectBlackPb();
					if (this.fadeInEffectPbCase_ == FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase.FadeBackgroundFadeInEffectBlackPb)
					{
						fadeBackgroundFadeInEffectBlackPb.MergeFrom(this.FadeBackgroundFadeInEffectBlackPb);
					}
					input.ReadMessage(fadeBackgroundFadeInEffectBlackPb);
					this.FadeBackgroundFadeInEffectBlackPb = fadeBackgroundFadeInEffectBlackPb;
				}
			}
		}

		// Token: 0x04003ECD RID: 16077
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003ECE RID: 16078
		public const int FadeBackgroundFadeInEffectBlackPbFieldNumber = 1;

		// Token: 0x04003ECF RID: 16079
		public const int FadeBackgroundFadeInEffectScreenPbFieldNumber = 2;

		// Token: 0x04003ED0 RID: 16080
		private object fadeInEffectPb_;

		// Token: 0x04003ED1 RID: 16081
		private FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase fadeInEffectPbCase_;

		// Token: 0x02001801 RID: 6145
		public enum FadeInEffectPbOneofCase
		{
			// Token: 0x0400CBD1 RID: 52177
			None,
			// Token: 0x0400CBD2 RID: 52178
			FadeBackgroundFadeInEffectBlackPb,
			// Token: 0x0400CBD3 RID: 52179
			FadeBackgroundFadeInEffectScreenPb
		}
	}
}
