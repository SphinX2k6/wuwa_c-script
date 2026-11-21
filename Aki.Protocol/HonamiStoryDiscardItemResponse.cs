using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200075E RID: 1886
	[NetMessage(EMessageId.HonamiStoryDiscardItemResponse)]
	public sealed class HonamiStoryDiscardItemResponse : IMessage<HonamiStoryDiscardItemResponse>, IMessage, IEquatable<HonamiStoryDiscardItemResponse>, IDeepCloneable<HonamiStoryDiscardItemResponse>, IBufferMessage
	{
		// Token: 0x0600AAF7 RID: 43767 RVA: 0x0019B9F4 File Offset: 0x00199BF4
		[NullableContext(1)]
		public static HonamiStoryDiscardItemResponse Create()
		{
			return new HonamiStoryDiscardItemResponse();
		}

		// Token: 0x17002270 RID: 8816
		// (get) Token: 0x0600AAF8 RID: 43768 RVA: 0x0019B9FB File Offset: 0x00199BFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002271 RID: 8817
		// (get) Token: 0x0600AAF9 RID: 43769 RVA: 0x0019B9FE File Offset: 0x00199BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryDiscardItemResponse.Descriptor;
			}
		}

		// Token: 0x0600AAFA RID: 43770 RVA: 0x0019BA05 File Offset: 0x00199C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryDiscardItemResponse()
		{
		}

		// Token: 0x0600AAFB RID: 43771 RVA: 0x0019BA0D File Offset: 0x00199C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryDiscardItemResponse(HonamiStoryDiscardItemResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AAFC RID: 43772 RVA: 0x0019BA32 File Offset: 0x00199C32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryDiscardItemResponse Clone()
		{
			return new HonamiStoryDiscardItemResponse(this);
		}

		// Token: 0x17002272 RID: 8818
		// (get) Token: 0x0600AAFD RID: 43773 RVA: 0x0019BA3A File Offset: 0x00199C3A
		// (set) Token: 0x0600AAFE RID: 43774 RVA: 0x0019BA42 File Offset: 0x00199C42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0600AAFF RID: 43775 RVA: 0x0019BA4B File Offset: 0x00199C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryDiscardItemResponse);
		}

		// Token: 0x0600AB00 RID: 43776 RVA: 0x0019BA59 File Offset: 0x00199C59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryDiscardItemResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AB01 RID: 43777 RVA: 0x0019BA88 File Offset: 0x00199C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AB02 RID: 43778 RVA: 0x0019BACD File Offset: 0x00199CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AB03 RID: 43779 RVA: 0x0019BADA File Offset: 0x00199CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB04 RID: 43780 RVA: 0x0019BAE3 File Offset: 0x00199CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB05 RID: 43781 RVA: 0x0019BB18 File Offset: 0x00199D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AB06 RID: 43782 RVA: 0x0019BB56 File Offset: 0x00199D56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryDiscardItemResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AB07 RID: 43783 RVA: 0x0019BB87 File Offset: 0x00199D87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB08 RID: 43784 RVA: 0x0019BB90 File Offset: 0x00199D90
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004E09 RID: 19977
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E0A RID: 19978
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04004E0B RID: 19979
		private ErrorCode errorCode_;
	}
}
