using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000500 RID: 1280
	public sealed class FadeBackgroundFadeOutEffectPb : IMessage<FadeBackgroundFadeOutEffectPb>, IMessage, IEquatable<FadeBackgroundFadeOutEffectPb>, IDeepCloneable<FadeBackgroundFadeOutEffectPb>, IBufferMessage
	{
		// Token: 0x060078EF RID: 30959 RVA: 0x00126726 File Offset: 0x00124926
		[NullableContext(1)]
		public static FadeBackgroundFadeOutEffectPb Create()
		{
			return new FadeBackgroundFadeOutEffectPb();
		}

		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x060078F0 RID: 30960 RVA: 0x0012672D File Offset: 0x0012492D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x060078F1 RID: 30961 RVA: 0x00126730 File Offset: 0x00124930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FadeBackgroundFadeOutEffectPb.Descriptor;
			}
		}

		// Token: 0x060078F2 RID: 30962 RVA: 0x00126737 File Offset: 0x00124937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeOutEffectPb()
		{
		}

		// Token: 0x060078F3 RID: 30963 RVA: 0x00126740 File Offset: 0x00124940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeOutEffectPb(FadeBackgroundFadeOutEffectPb other) : this()
		{
			FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase fadeOutEffectCase = other.FadeOutEffectCase;
			if (fadeOutEffectCase != FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectBlackPb)
			{
				if (fadeOutEffectCase == FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectSceenPb)
				{
					this.FadeBackgroundFadeOutEffectSceenPb = other.FadeBackgroundFadeOutEffectSceenPb.Clone();
				}
			}
			else
			{
				this.FadeBackgroundFadeOutEffectBlackPb = other.FadeBackgroundFadeOutEffectBlackPb.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060078F4 RID: 30964 RVA: 0x00126799 File Offset: 0x00124999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeOutEffectPb Clone()
		{
			return new FadeBackgroundFadeOutEffectPb(this);
		}

		// Token: 0x17001770 RID: 6000
		// (get) Token: 0x060078F5 RID: 30965 RVA: 0x001267A1 File Offset: 0x001249A1
		// (set) Token: 0x060078F6 RID: 30966 RVA: 0x001267B9 File Offset: 0x001249B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeOutEffectBlackPb FadeBackgroundFadeOutEffectBlackPb
		{
			get
			{
				if (this.fadeOutEffectCase_ != FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectBlackPb)
				{
					return null;
				}
				return (FadeBackgroundFadeOutEffectBlackPb)this.fadeOutEffect_;
			}
			set
			{
				this.fadeOutEffect_ = value;
				this.fadeOutEffectCase_ = ((value == null) ? FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.None : FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectBlackPb);
			}
		}

		// Token: 0x17001771 RID: 6001
		// (get) Token: 0x060078F7 RID: 30967 RVA: 0x001267CF File Offset: 0x001249CF
		// (set) Token: 0x060078F8 RID: 30968 RVA: 0x001267E7 File Offset: 0x001249E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeOutEffectSceenPb FadeBackgroundFadeOutEffectSceenPb
		{
			get
			{
				if (this.fadeOutEffectCase_ != FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectSceenPb)
				{
					return null;
				}
				return (FadeBackgroundFadeOutEffectSceenPb)this.fadeOutEffect_;
			}
			set
			{
				this.fadeOutEffect_ = value;
				this.fadeOutEffectCase_ = ((value == null) ? FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.None : FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectSceenPb);
			}
		}

		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x060078F9 RID: 30969 RVA: 0x001267FD File Offset: 0x001249FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase FadeOutEffectCase
		{
			get
			{
				return this.fadeOutEffectCase_;
			}
		}

		// Token: 0x060078FA RID: 30970 RVA: 0x00126805 File Offset: 0x00124A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFadeOutEffect()
		{
			this.fadeOutEffectCase_ = FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.None;
			this.fadeOutEffect_ = null;
		}

		// Token: 0x060078FB RID: 30971 RVA: 0x00126815 File Offset: 0x00124A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FadeBackgroundFadeOutEffectPb);
		}

		// Token: 0x060078FC RID: 30972 RVA: 0x00126824 File Offset: 0x00124A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FadeBackgroundFadeOutEffectPb other)
		{
			return other != null && (other == this || (object.Equals(this.FadeBackgroundFadeOutEffectBlackPb, other.FadeBackgroundFadeOutEffectBlackPb) && object.Equals(this.FadeBackgroundFadeOutEffectSceenPb, other.FadeBackgroundFadeOutEffectSceenPb) && this.FadeOutEffectCase == other.FadeOutEffectCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060078FD RID: 30973 RVA: 0x00126888 File Offset: 0x00124A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.fadeOutEffectCase_ == FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectBlackPb)
			{
				num ^= this.FadeBackgroundFadeOutEffectBlackPb.GetHashCode();
			}
			if (this.fadeOutEffectCase_ == FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectSceenPb)
			{
				num ^= this.FadeBackgroundFadeOutEffectSceenPb.GetHashCode();
			}
			num ^= (int)this.fadeOutEffectCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060078FE RID: 30974 RVA: 0x001268E5 File Offset: 0x00124AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060078FF RID: 30975 RVA: 0x001268F2 File Offset: 0x00124AF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007900 RID: 30976 RVA: 0x001268FC File Offset: 0x00124AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fadeOutEffectCase_ == FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectBlackPb)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.FadeBackgroundFadeOutEffectBlackPb);
			}
			if (this.fadeOutEffectCase_ == FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectSceenPb)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.FadeBackgroundFadeOutEffectSceenPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007901 RID: 30977 RVA: 0x00126958 File Offset: 0x00124B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.fadeOutEffectCase_ == FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectBlackPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FadeBackgroundFadeOutEffectBlackPb);
			}
			if (this.fadeOutEffectCase_ == FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectSceenPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FadeBackgroundFadeOutEffectSceenPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007902 RID: 30978 RVA: 0x001269B0 File Offset: 0x00124BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FadeBackgroundFadeOutEffectPb other)
		{
			if (other == null)
			{
				return;
			}
			FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase fadeOutEffectCase = other.FadeOutEffectCase;
			if (fadeOutEffectCase != FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectBlackPb)
			{
				if (fadeOutEffectCase == FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectSceenPb)
				{
					if (this.FadeBackgroundFadeOutEffectSceenPb == null)
					{
						this.FadeBackgroundFadeOutEffectSceenPb = new FadeBackgroundFadeOutEffectSceenPb();
					}
					this.FadeBackgroundFadeOutEffectSceenPb.MergeFrom(other.FadeBackgroundFadeOutEffectSceenPb);
				}
			}
			else
			{
				if (this.FadeBackgroundFadeOutEffectBlackPb == null)
				{
					this.FadeBackgroundFadeOutEffectBlackPb = new FadeBackgroundFadeOutEffectBlackPb();
				}
				this.FadeBackgroundFadeOutEffectBlackPb.MergeFrom(other.FadeBackgroundFadeOutEffectBlackPb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007903 RID: 30979 RVA: 0x00126A33 File Offset: 0x00124C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007904 RID: 30980 RVA: 0x00126A3C File Offset: 0x00124C3C
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
						FadeBackgroundFadeOutEffectSceenPb fadeBackgroundFadeOutEffectSceenPb = new FadeBackgroundFadeOutEffectSceenPb();
						if (this.fadeOutEffectCase_ == FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectSceenPb)
						{
							fadeBackgroundFadeOutEffectSceenPb.MergeFrom(this.FadeBackgroundFadeOutEffectSceenPb);
						}
						input.ReadMessage(fadeBackgroundFadeOutEffectSceenPb);
						this.FadeBackgroundFadeOutEffectSceenPb = fadeBackgroundFadeOutEffectSceenPb;
					}
				}
				else
				{
					FadeBackgroundFadeOutEffectBlackPb fadeBackgroundFadeOutEffectBlackPb = new FadeBackgroundFadeOutEffectBlackPb();
					if (this.fadeOutEffectCase_ == FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase.FadeBackgroundFadeOutEffectBlackPb)
					{
						fadeBackgroundFadeOutEffectBlackPb.MergeFrom(this.FadeBackgroundFadeOutEffectBlackPb);
					}
					input.ReadMessage(fadeBackgroundFadeOutEffectBlackPb);
					this.FadeBackgroundFadeOutEffectBlackPb = fadeBackgroundFadeOutEffectBlackPb;
				}
			}
		}

		// Token: 0x04003EDF RID: 16095
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EE0 RID: 16096
		public const int FadeBackgroundFadeOutEffectBlackPbFieldNumber = 1;

		// Token: 0x04003EE1 RID: 16097
		public const int FadeBackgroundFadeOutEffectSceenPbFieldNumber = 2;

		// Token: 0x04003EE2 RID: 16098
		private object fadeOutEffect_;

		// Token: 0x04003EE3 RID: 16099
		private FadeBackgroundFadeOutEffectPb.FadeOutEffectOneofCase fadeOutEffectCase_;

		// Token: 0x02001802 RID: 6146
		public enum FadeOutEffectOneofCase
		{
			// Token: 0x0400CBD5 RID: 52181
			None,
			// Token: 0x0400CBD6 RID: 52182
			FadeBackgroundFadeOutEffectBlackPb,
			// Token: 0x0400CBD7 RID: 52183
			FadeBackgroundFadeOutEffectSceenPb
		}
	}
}
