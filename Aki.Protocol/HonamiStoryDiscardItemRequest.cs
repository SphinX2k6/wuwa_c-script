using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200075D RID: 1885
	[NetMessage(EMessageId.HonamiStoryDiscardItemRequest)]
	public sealed class HonamiStoryDiscardItemRequest : IMessage<HonamiStoryDiscardItemRequest>, IMessage, IEquatable<HonamiStoryDiscardItemRequest>, IDeepCloneable<HonamiStoryDiscardItemRequest>, IBufferMessage
	{
		// Token: 0x0600AAE5 RID: 43749 RVA: 0x0019B7D0 File Offset: 0x001999D0
		[NullableContext(1)]
		public static HonamiStoryDiscardItemRequest Create()
		{
			return new HonamiStoryDiscardItemRequest();
		}

		// Token: 0x1700226D RID: 8813
		// (get) Token: 0x0600AAE6 RID: 43750 RVA: 0x0019B7D7 File Offset: 0x001999D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700226E RID: 8814
		// (get) Token: 0x0600AAE7 RID: 43751 RVA: 0x0019B7DA File Offset: 0x001999DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryDiscardItemRequest.Descriptor;
			}
		}

		// Token: 0x0600AAE8 RID: 43752 RVA: 0x0019B7E1 File Offset: 0x001999E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryDiscardItemRequest()
		{
		}

		// Token: 0x0600AAE9 RID: 43753 RVA: 0x0019B7E9 File Offset: 0x001999E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryDiscardItemRequest(HonamiStoryDiscardItemRequest other) : this()
		{
			this.honamiStoryBagUpdateContext_ = ((other.honamiStoryBagUpdateContext_ != null) ? other.honamiStoryBagUpdateContext_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AAEA RID: 43754 RVA: 0x0019B81E File Offset: 0x00199A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryDiscardItemRequest Clone()
		{
			return new HonamiStoryDiscardItemRequest(this);
		}

		// Token: 0x1700226F RID: 8815
		// (get) Token: 0x0600AAEB RID: 43755 RVA: 0x0019B826 File Offset: 0x00199A26
		// (set) Token: 0x0600AAEC RID: 43756 RVA: 0x0019B82E File Offset: 0x00199A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagUpdateContext HonamiStoryBagUpdateContext
		{
			get
			{
				return this.honamiStoryBagUpdateContext_;
			}
			set
			{
				this.honamiStoryBagUpdateContext_ = value;
			}
		}

		// Token: 0x0600AAED RID: 43757 RVA: 0x0019B837 File Offset: 0x00199A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryDiscardItemRequest);
		}

		// Token: 0x0600AAEE RID: 43758 RVA: 0x0019B845 File Offset: 0x00199A45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryDiscardItemRequest other)
		{
			return other != null && (other == this || (object.Equals(this.HonamiStoryBagUpdateContext, other.HonamiStoryBagUpdateContext) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AAEF RID: 43759 RVA: 0x0019B878 File Offset: 0x00199A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.honamiStoryBagUpdateContext_ != null)
			{
				num ^= this.HonamiStoryBagUpdateContext.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AAF0 RID: 43760 RVA: 0x0019B8B4 File Offset: 0x00199AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AAF1 RID: 43761 RVA: 0x0019B8C1 File Offset: 0x00199AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AAF2 RID: 43762 RVA: 0x0019B8CA File Offset: 0x00199ACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.honamiStoryBagUpdateContext_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.HonamiStoryBagUpdateContext);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AAF3 RID: 43763 RVA: 0x0019B8FC File Offset: 0x00199AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.honamiStoryBagUpdateContext_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HonamiStoryBagUpdateContext);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AAF4 RID: 43764 RVA: 0x0019B93C File Offset: 0x00199B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryDiscardItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.honamiStoryBagUpdateContext_ != null)
			{
				if (this.honamiStoryBagUpdateContext_ == null)
				{
					this.HonamiStoryBagUpdateContext = new HonamiStoryBagUpdateContext();
				}
				this.HonamiStoryBagUpdateContext.MergeFrom(other.HonamiStoryBagUpdateContext);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AAF5 RID: 43765 RVA: 0x0019B990 File Offset: 0x00199B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AAF6 RID: 43766 RVA: 0x0019B99C File Offset: 0x00199B9C
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.honamiStoryBagUpdateContext_ == null)
					{
						this.HonamiStoryBagUpdateContext = new HonamiStoryBagUpdateContext();
					}
					input.ReadMessage(this.HonamiStoryBagUpdateContext);
				}
			}
		}

		// Token: 0x04004E06 RID: 19974
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E07 RID: 19975
		public const int HonamiStoryBagUpdateContextFieldNumber = 14;

		// Token: 0x04004E08 RID: 19976
		private HonamiStoryBagUpdateContext honamiStoryBagUpdateContext_;
	}
}
