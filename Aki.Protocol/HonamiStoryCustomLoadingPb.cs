using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200075C RID: 1884
	public sealed class HonamiStoryCustomLoadingPb : IMessage<HonamiStoryCustomLoadingPb>, IMessage, IEquatable<HonamiStoryCustomLoadingPb>, IDeepCloneable<HonamiStoryCustomLoadingPb>, IBufferMessage
	{
		// Token: 0x0600AAD3 RID: 43731 RVA: 0x0019B5F8 File Offset: 0x001997F8
		[NullableContext(1)]
		public static HonamiStoryCustomLoadingPb Create()
		{
			return new HonamiStoryCustomLoadingPb();
		}

		// Token: 0x1700226A RID: 8810
		// (get) Token: 0x0600AAD4 RID: 43732 RVA: 0x0019B5FF File Offset: 0x001997FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700226B RID: 8811
		// (get) Token: 0x0600AAD5 RID: 43733 RVA: 0x0019B602 File Offset: 0x00199802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryCustomLoadingPb.Descriptor;
			}
		}

		// Token: 0x0600AAD6 RID: 43734 RVA: 0x0019B609 File Offset: 0x00199809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryCustomLoadingPb()
		{
		}

		// Token: 0x0600AAD7 RID: 43735 RVA: 0x0019B611 File Offset: 0x00199811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryCustomLoadingPb(HonamiStoryCustomLoadingPb other) : this()
		{
			this.loadingId_ = other.loadingId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AAD8 RID: 43736 RVA: 0x0019B636 File Offset: 0x00199836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryCustomLoadingPb Clone()
		{
			return new HonamiStoryCustomLoadingPb(this);
		}

		// Token: 0x1700226C RID: 8812
		// (get) Token: 0x0600AAD9 RID: 43737 RVA: 0x0019B63E File Offset: 0x0019983E
		// (set) Token: 0x0600AADA RID: 43738 RVA: 0x0019B646 File Offset: 0x00199846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LoadingId
		{
			get
			{
				return this.loadingId_;
			}
			set
			{
				this.loadingId_ = value;
			}
		}

		// Token: 0x0600AADB RID: 43739 RVA: 0x0019B64F File Offset: 0x0019984F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryCustomLoadingPb);
		}

		// Token: 0x0600AADC RID: 43740 RVA: 0x0019B65D File Offset: 0x0019985D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryCustomLoadingPb other)
		{
			return other != null && (other == this || (this.LoadingId == other.LoadingId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AADD RID: 43741 RVA: 0x0019B68C File Offset: 0x0019988C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LoadingId != 0)
			{
				num ^= this.LoadingId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AADE RID: 43742 RVA: 0x0019B6CB File Offset: 0x001998CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AADF RID: 43743 RVA: 0x0019B6D8 File Offset: 0x001998D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AAE0 RID: 43744 RVA: 0x0019B6E1 File Offset: 0x001998E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LoadingId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LoadingId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AAE1 RID: 43745 RVA: 0x0019B714 File Offset: 0x00199914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LoadingId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LoadingId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AAE2 RID: 43746 RVA: 0x0019B752 File Offset: 0x00199952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryCustomLoadingPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LoadingId != 0)
			{
				this.LoadingId = other.LoadingId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AAE3 RID: 43747 RVA: 0x0019B783 File Offset: 0x00199983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AAE4 RID: 43748 RVA: 0x0019B78C File Offset: 0x0019998C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LoadingId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004E03 RID: 19971
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E04 RID: 19972
		public const int LoadingIdFieldNumber = 1;

		// Token: 0x04004E05 RID: 19973
		private int loadingId_;
	}
}
