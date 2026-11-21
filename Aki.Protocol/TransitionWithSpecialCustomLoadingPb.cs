using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001473 RID: 5235
	public sealed class TransitionWithSpecialCustomLoadingPb : IMessage<TransitionWithSpecialCustomLoadingPb>, IMessage, IEquatable<TransitionWithSpecialCustomLoadingPb>, IDeepCloneable<TransitionWithSpecialCustomLoadingPb>, IBufferMessage
	{
		// Token: 0x0601BCC6 RID: 113862 RVA: 0x00409E90 File Offset: 0x00408090
		[NullableContext(1)]
		public static TransitionWithSpecialCustomLoadingPb Create()
		{
			return new TransitionWithSpecialCustomLoadingPb();
		}

		// Token: 0x17005E17 RID: 24087
		// (get) Token: 0x0601BCC7 RID: 113863 RVA: 0x00409E97 File Offset: 0x00408097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E18 RID: 24088
		// (get) Token: 0x0601BCC8 RID: 113864 RVA: 0x00409E9A File Offset: 0x0040809A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransitionWithSpecialCustomLoadingPb.Descriptor;
			}
		}

		// Token: 0x0601BCC9 RID: 113865 RVA: 0x00409EA1 File Offset: 0x004080A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithSpecialCustomLoadingPb()
		{
		}

		// Token: 0x0601BCCA RID: 113866 RVA: 0x00409EA9 File Offset: 0x004080A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithSpecialCustomLoadingPb(TransitionWithSpecialCustomLoadingPb other) : this()
		{
			if (other.LoadingTypeCase == TransitionWithSpecialCustomLoadingPb.LoadingTypeOneofCase.HonamiStoryCustomLoadingPb)
			{
				this.HonamiStoryCustomLoadingPb = other.HonamiStoryCustomLoadingPb.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BCCB RID: 113867 RVA: 0x00409EDC File Offset: 0x004080DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithSpecialCustomLoadingPb Clone()
		{
			return new TransitionWithSpecialCustomLoadingPb(this);
		}

		// Token: 0x17005E19 RID: 24089
		// (get) Token: 0x0601BCCC RID: 113868 RVA: 0x00409EE4 File Offset: 0x004080E4
		// (set) Token: 0x0601BCCD RID: 113869 RVA: 0x00409EFC File Offset: 0x004080FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryCustomLoadingPb HonamiStoryCustomLoadingPb
		{
			get
			{
				if (this.loadingTypeCase_ != TransitionWithSpecialCustomLoadingPb.LoadingTypeOneofCase.HonamiStoryCustomLoadingPb)
				{
					return null;
				}
				return (HonamiStoryCustomLoadingPb)this.loadingType_;
			}
			set
			{
				this.loadingType_ = value;
				this.loadingTypeCase_ = ((value == null) ? TransitionWithSpecialCustomLoadingPb.LoadingTypeOneofCase.None : TransitionWithSpecialCustomLoadingPb.LoadingTypeOneofCase.HonamiStoryCustomLoadingPb);
			}
		}

		// Token: 0x17005E1A RID: 24090
		// (get) Token: 0x0601BCCE RID: 113870 RVA: 0x00409F12 File Offset: 0x00408112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithSpecialCustomLoadingPb.LoadingTypeOneofCase LoadingTypeCase
		{
			get
			{
				return this.loadingTypeCase_;
			}
		}

		// Token: 0x0601BCCF RID: 113871 RVA: 0x00409F1A File Offset: 0x0040811A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearLoadingType()
		{
			this.loadingTypeCase_ = TransitionWithSpecialCustomLoadingPb.LoadingTypeOneofCase.None;
			this.loadingType_ = null;
		}

		// Token: 0x0601BCD0 RID: 113872 RVA: 0x00409F2A File Offset: 0x0040812A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransitionWithSpecialCustomLoadingPb);
		}

		// Token: 0x0601BCD1 RID: 113873 RVA: 0x00409F38 File Offset: 0x00408138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransitionWithSpecialCustomLoadingPb other)
		{
			return other != null && (other == this || (object.Equals(this.HonamiStoryCustomLoadingPb, other.HonamiStoryCustomLoadingPb) && this.LoadingTypeCase == other.LoadingTypeCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BCD2 RID: 113874 RVA: 0x00409F88 File Offset: 0x00408188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.loadingTypeCase_ == TransitionWithSpecialCustomLoadingPb.LoadingTypeOneofCase.HonamiStoryCustomLoadingPb)
			{
				num ^= this.HonamiStoryCustomLoadingPb.GetHashCode();
			}
			num ^= (int)this.loadingTypeCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BCD3 RID: 113875 RVA: 0x00409FCE File Offset: 0x004081CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BCD4 RID: 113876 RVA: 0x00409FDB File Offset: 0x004081DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BCD5 RID: 113877 RVA: 0x00409FE4 File Offset: 0x004081E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.loadingTypeCase_ == TransitionWithSpecialCustomLoadingPb.LoadingTypeOneofCase.HonamiStoryCustomLoadingPb)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.HonamiStoryCustomLoadingPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BCD6 RID: 113878 RVA: 0x0040A018 File Offset: 0x00408218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.loadingTypeCase_ == TransitionWithSpecialCustomLoadingPb.LoadingTypeOneofCase.HonamiStoryCustomLoadingPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HonamiStoryCustomLoadingPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BCD7 RID: 113879 RVA: 0x0040A058 File Offset: 0x00408258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TransitionWithSpecialCustomLoadingPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LoadingTypeCase == TransitionWithSpecialCustomLoadingPb.LoadingTypeOneofCase.HonamiStoryCustomLoadingPb)
			{
				if (this.HonamiStoryCustomLoadingPb == null)
				{
					this.HonamiStoryCustomLoadingPb = new HonamiStoryCustomLoadingPb();
				}
				this.HonamiStoryCustomLoadingPb.MergeFrom(other.HonamiStoryCustomLoadingPb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BCD8 RID: 113880 RVA: 0x0040A0AD File Offset: 0x004082AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BCD9 RID: 113881 RVA: 0x0040A0B8 File Offset: 0x004082B8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					HonamiStoryCustomLoadingPb honamiStoryCustomLoadingPb = new HonamiStoryCustomLoadingPb();
					if (this.loadingTypeCase_ == TransitionWithSpecialCustomLoadingPb.LoadingTypeOneofCase.HonamiStoryCustomLoadingPb)
					{
						honamiStoryCustomLoadingPb.MergeFrom(this.HonamiStoryCustomLoadingPb);
					}
					input.ReadMessage(honamiStoryCustomLoadingPb);
					this.HonamiStoryCustomLoadingPb = honamiStoryCustomLoadingPb;
				}
			}
		}

		// Token: 0x0400A148 RID: 41288
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A149 RID: 41289
		public const int HonamiStoryCustomLoadingPbFieldNumber = 1;

		// Token: 0x0400A14A RID: 41290
		private object loadingType_;

		// Token: 0x0400A14B RID: 41291
		private TransitionWithSpecialCustomLoadingPb.LoadingTypeOneofCase loadingTypeCase_;

		// Token: 0x02001A75 RID: 6773
		public enum LoadingTypeOneofCase
		{
			// Token: 0x0400D003 RID: 53251
			None,
			// Token: 0x0400D004 RID: 53252
			HonamiStoryCustomLoadingPb
		}
	}
}
