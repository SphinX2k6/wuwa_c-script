using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000513 RID: 1299
	public sealed class FadeBackgroundFadeInEffectPb : IMessage<FadeBackgroundFadeInEffectPb>, IMessage, IEquatable<FadeBackgroundFadeInEffectPb>, IDeepCloneable<FadeBackgroundFadeInEffectPb>, IBufferMessage
	{
		// Token: 0x06007A29 RID: 31273 RVA: 0x00128C32 File Offset: 0x00126E32
		[NullableContext(1)]
		public static FadeBackgroundFadeInEffectPb Create()
		{
			return new FadeBackgroundFadeInEffectPb();
		}

		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x06007A2A RID: 31274 RVA: 0x00128C39 File Offset: 0x00126E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017B1 RID: 6065
		// (get) Token: 0x06007A2B RID: 31275 RVA: 0x00128C3C File Offset: 0x00126E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FadeBackgroundFadeInEffectPb.Descriptor;
			}
		}

		// Token: 0x06007A2C RID: 31276 RVA: 0x00128C43 File Offset: 0x00126E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeInEffectPb()
		{
		}

		// Token: 0x06007A2D RID: 31277 RVA: 0x00128C4C File Offset: 0x00126E4C
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

		// Token: 0x06007A2E RID: 31278 RVA: 0x00128CA5 File Offset: 0x00126EA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeInEffectPb Clone()
		{
			return new FadeBackgroundFadeInEffectPb(this);
		}

		// Token: 0x170017B2 RID: 6066
		// (get) Token: 0x06007A2F RID: 31279 RVA: 0x00128CAD File Offset: 0x00126EAD
		// (set) Token: 0x06007A30 RID: 31280 RVA: 0x00128CC5 File Offset: 0x00126EC5
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

		// Token: 0x170017B3 RID: 6067
		// (get) Token: 0x06007A31 RID: 31281 RVA: 0x00128CDB File Offset: 0x00126EDB
		// (set) Token: 0x06007A32 RID: 31282 RVA: 0x00128CF3 File Offset: 0x00126EF3
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

		// Token: 0x170017B4 RID: 6068
		// (get) Token: 0x06007A33 RID: 31283 RVA: 0x00128D09 File Offset: 0x00126F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase FadeInEffectPbCase
		{
			get
			{
				return this.fadeInEffectPbCase_;
			}
		}

		// Token: 0x06007A34 RID: 31284 RVA: 0x00128D11 File Offset: 0x00126F11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFadeInEffectPb()
		{
			this.fadeInEffectPbCase_ = FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase.None;
			this.fadeInEffectPb_ = null;
		}

		// Token: 0x06007A35 RID: 31285 RVA: 0x00128D21 File Offset: 0x00126F21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FadeBackgroundFadeInEffectPb);
		}

		// Token: 0x06007A36 RID: 31286 RVA: 0x00128D30 File Offset: 0x00126F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FadeBackgroundFadeInEffectPb other)
		{
			return other != null && (other == this || (object.Equals(this.FadeBackgroundFadeInEffectBlackPb, other.FadeBackgroundFadeInEffectBlackPb) && object.Equals(this.FadeBackgroundFadeInEffectScreenPb, other.FadeBackgroundFadeInEffectScreenPb) && this.FadeInEffectPbCase == other.FadeInEffectPbCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007A37 RID: 31287 RVA: 0x00128D94 File Offset: 0x00126F94
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

		// Token: 0x06007A38 RID: 31288 RVA: 0x00128DF1 File Offset: 0x00126FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007A39 RID: 31289 RVA: 0x00128DFE File Offset: 0x00126FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A3A RID: 31290 RVA: 0x00128E08 File Offset: 0x00127008
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

		// Token: 0x06007A3B RID: 31291 RVA: 0x00128E64 File Offset: 0x00127064
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

		// Token: 0x06007A3C RID: 31292 RVA: 0x00128EBC File Offset: 0x001270BC
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

		// Token: 0x06007A3D RID: 31293 RVA: 0x00128F3F File Offset: 0x0012713F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A3E RID: 31294 RVA: 0x00128F48 File Offset: 0x00127148
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

		// Token: 0x04003EDC RID: 16092
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EDD RID: 16093
		public const int FadeBackgroundFadeInEffectBlackPbFieldNumber = 1;

		// Token: 0x04003EDE RID: 16094
		public const int FadeBackgroundFadeInEffectScreenPbFieldNumber = 2;

		// Token: 0x04003EDF RID: 16095
		private object fadeInEffectPb_;

		// Token: 0x04003EE0 RID: 16096
		private FadeBackgroundFadeInEffectPb.FadeInEffectPbOneofCase fadeInEffectPbCase_;

		// Token: 0x02001789 RID: 6025
		public enum FadeInEffectPbOneofCase
		{
			// Token: 0x0400C6A6 RID: 50854
			None,
			// Token: 0x0400C6A7 RID: 50855
			FadeBackgroundFadeInEffectBlackPb,
			// Token: 0x0400C6A8 RID: 50856
			FadeBackgroundFadeInEffectScreenPb
		}
	}
}
