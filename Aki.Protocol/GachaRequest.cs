using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200069C RID: 1692
	[NetMessage(EMessageId.GachaRequest)]
	public sealed class GachaRequest : IMessage<GachaRequest>, IMessage, IEquatable<GachaRequest>, IDeepCloneable<GachaRequest>, IBufferMessage
	{
		// Token: 0x06009AEA RID: 39658 RVA: 0x00175CFF File Offset: 0x00173EFF
		[NullableContext(1)]
		public static GachaRequest Create()
		{
			return new GachaRequest();
		}

		// Token: 0x17001EFE RID: 7934
		// (get) Token: 0x06009AEB RID: 39659 RVA: 0x00175D06 File Offset: 0x00173F06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001EFF RID: 7935
		// (get) Token: 0x06009AEC RID: 39660 RVA: 0x00175D09 File Offset: 0x00173F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaRequest.Descriptor;
			}
		}

		// Token: 0x06009AED RID: 39661 RVA: 0x00175D10 File Offset: 0x00173F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRequest()
		{
		}

		// Token: 0x06009AEE RID: 39662 RVA: 0x00175D18 File Offset: 0x00173F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRequest(GachaRequest other) : this()
		{
			this.gachaId_ = other.gachaId_;
			this.gachaTimes_ = other.gachaTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009AEF RID: 39663 RVA: 0x00175D49 File Offset: 0x00173F49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRequest Clone()
		{
			return new GachaRequest(this);
		}

		// Token: 0x17001F00 RID: 7936
		// (get) Token: 0x06009AF0 RID: 39664 RVA: 0x00175D51 File Offset: 0x00173F51
		// (set) Token: 0x06009AF1 RID: 39665 RVA: 0x00175D59 File Offset: 0x00173F59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GachaId
		{
			get
			{
				return this.gachaId_;
			}
			set
			{
				this.gachaId_ = value;
			}
		}

		// Token: 0x17001F01 RID: 7937
		// (get) Token: 0x06009AF2 RID: 39666 RVA: 0x00175D62 File Offset: 0x00173F62
		// (set) Token: 0x06009AF3 RID: 39667 RVA: 0x00175D6A File Offset: 0x00173F6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GachaTimes
		{
			get
			{
				return this.gachaTimes_;
			}
			set
			{
				this.gachaTimes_ = value;
			}
		}

		// Token: 0x06009AF4 RID: 39668 RVA: 0x00175D73 File Offset: 0x00173F73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaRequest);
		}

		// Token: 0x06009AF5 RID: 39669 RVA: 0x00175D81 File Offset: 0x00173F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaRequest other)
		{
			return other != null && (other == this || (this.GachaId == other.GachaId && this.GachaTimes == other.GachaTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009AF6 RID: 39670 RVA: 0x00175DC0 File Offset: 0x00173FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GachaId != 0)
			{
				num ^= this.GachaId.GetHashCode();
			}
			if (this.GachaTimes != 0)
			{
				num ^= this.GachaTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009AF7 RID: 39671 RVA: 0x00175E18 File Offset: 0x00174018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009AF8 RID: 39672 RVA: 0x00175E25 File Offset: 0x00174025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009AF9 RID: 39673 RVA: 0x00175E30 File Offset: 0x00174030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GachaTimes != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.GachaTimes);
			}
			if (this.GachaId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.GachaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009AFA RID: 39674 RVA: 0x00175E8C File Offset: 0x0017408C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GachaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GachaId);
			}
			if (this.GachaTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GachaTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009AFB RID: 39675 RVA: 0x00175EE4 File Offset: 0x001740E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GachaId != 0)
			{
				this.GachaId = other.GachaId;
			}
			if (other.GachaTimes != 0)
			{
				this.GachaTimes = other.GachaTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009AFC RID: 39676 RVA: 0x00175F34 File Offset: 0x00174134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009AFD RID: 39677 RVA: 0x00175F40 File Offset: 0x00174140
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
				if (num != 24U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GachaId = input.ReadInt32();
					}
				}
				else
				{
					this.GachaTimes = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400493C RID: 18748
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400493D RID: 18749
		public const int GachaIdFieldNumber = 13;

		// Token: 0x0400493E RID: 18750
		private int gachaId_;

		// Token: 0x0400493F RID: 18751
		public const int GachaTimesFieldNumber = 3;

		// Token: 0x04004940 RID: 18752
		private int gachaTimes_;
	}
}
