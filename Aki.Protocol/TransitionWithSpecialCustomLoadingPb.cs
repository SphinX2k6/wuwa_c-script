using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001400 RID: 5120
	public sealed class TransitionWithSpecialCustomLoadingPb : IMessage<TransitionWithSpecialCustomLoadingPb>, IMessage, IEquatable<TransitionWithSpecialCustomLoadingPb>, IDeepCloneable<TransitionWithSpecialCustomLoadingPb>, IBufferMessage
	{
		// Token: 0x0601B23B RID: 111163 RVA: 0x003EEBBC File Offset: 0x003ECDBC
		[NullableContext(1)]
		public static TransitionWithSpecialCustomLoadingPb Create()
		{
			return new TransitionWithSpecialCustomLoadingPb();
		}

		// Token: 0x17005B82 RID: 23426
		// (get) Token: 0x0601B23C RID: 111164 RVA: 0x003EEBC3 File Offset: 0x003ECDC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B83 RID: 23427
		// (get) Token: 0x0601B23D RID: 111165 RVA: 0x003EEBC6 File Offset: 0x003ECDC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransitionWithSpecialCustomLoadingPb.Descriptor;
			}
		}

		// Token: 0x0601B23E RID: 111166 RVA: 0x003EEBCD File Offset: 0x003ECDCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithSpecialCustomLoadingPb()
		{
		}

		// Token: 0x0601B23F RID: 111167 RVA: 0x003EEBD5 File Offset: 0x003ECDD5
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

		// Token: 0x0601B240 RID: 111168 RVA: 0x003EEC08 File Offset: 0x003ECE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithSpecialCustomLoadingPb Clone()
		{
			return new TransitionWithSpecialCustomLoadingPb(this);
		}

		// Token: 0x17005B84 RID: 23428
		// (get) Token: 0x0601B241 RID: 111169 RVA: 0x003EEC10 File Offset: 0x003ECE10
		// (set) Token: 0x0601B242 RID: 111170 RVA: 0x003EEC28 File Offset: 0x003ECE28
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

		// Token: 0x17005B85 RID: 23429
		// (get) Token: 0x0601B243 RID: 111171 RVA: 0x003EEC3E File Offset: 0x003ECE3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionWithSpecialCustomLoadingPb.LoadingTypeOneofCase LoadingTypeCase
		{
			get
			{
				return this.loadingTypeCase_;
			}
		}

		// Token: 0x0601B244 RID: 111172 RVA: 0x003EEC46 File Offset: 0x003ECE46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearLoadingType()
		{
			this.loadingTypeCase_ = TransitionWithSpecialCustomLoadingPb.LoadingTypeOneofCase.None;
			this.loadingType_ = null;
		}

		// Token: 0x0601B245 RID: 111173 RVA: 0x003EEC56 File Offset: 0x003ECE56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransitionWithSpecialCustomLoadingPb);
		}

		// Token: 0x0601B246 RID: 111174 RVA: 0x003EEC64 File Offset: 0x003ECE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransitionWithSpecialCustomLoadingPb other)
		{
			return other != null && (other == this || (object.Equals(this.HonamiStoryCustomLoadingPb, other.HonamiStoryCustomLoadingPb) && this.LoadingTypeCase == other.LoadingTypeCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B247 RID: 111175 RVA: 0x003EECB4 File Offset: 0x003ECEB4
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

		// Token: 0x0601B248 RID: 111176 RVA: 0x003EECFA File Offset: 0x003ECEFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B249 RID: 111177 RVA: 0x003EED07 File Offset: 0x003ECF07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B24A RID: 111178 RVA: 0x003EED10 File Offset: 0x003ECF10
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

		// Token: 0x0601B24B RID: 111179 RVA: 0x003EED44 File Offset: 0x003ECF44
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

		// Token: 0x0601B24C RID: 111180 RVA: 0x003EED84 File Offset: 0x003ECF84
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

		// Token: 0x0601B24D RID: 111181 RVA: 0x003EEDD9 File Offset: 0x003ECFD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B24E RID: 111182 RVA: 0x003EEDE4 File Offset: 0x003ECFE4
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

		// Token: 0x04009D01 RID: 40193
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D02 RID: 40194
		public const int HonamiStoryCustomLoadingPbFieldNumber = 1;

		// Token: 0x04009D03 RID: 40195
		private object loadingType_;

		// Token: 0x04009D04 RID: 40196
		private TransitionWithSpecialCustomLoadingPb.LoadingTypeOneofCase loadingTypeCase_;

		// Token: 0x020019D3 RID: 6611
		public enum LoadingTypeOneofCase
		{
			// Token: 0x0400CA98 RID: 51864
			None,
			// Token: 0x0400CA99 RID: 51865
			HonamiStoryCustomLoadingPb
		}
	}
}
