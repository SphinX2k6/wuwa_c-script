using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007F9 RID: 2041
	[NetMessage(EMessageId.InfrV2InfoNotify)]
	public sealed class InfrV2InfoNotify : IMessage<InfrV2InfoNotify>, IMessage, IEquatable<InfrV2InfoNotify>, IDeepCloneable<InfrV2InfoNotify>, IBufferMessage
	{
		// Token: 0x0600B6E4 RID: 46820 RVA: 0x001B461F File Offset: 0x001B281F
		[NullableContext(1)]
		public static InfrV2InfoNotify Create()
		{
			return new InfrV2InfoNotify();
		}

		// Token: 0x170024E0 RID: 9440
		// (get) Token: 0x0600B6E5 RID: 46821 RVA: 0x001B4626 File Offset: 0x001B2826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024E1 RID: 9441
		// (get) Token: 0x0600B6E6 RID: 46822 RVA: 0x001B4629 File Offset: 0x001B2829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2InfoNotify.Descriptor;
			}
		}

		// Token: 0x0600B6E7 RID: 46823 RVA: 0x001B4630 File Offset: 0x001B2830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2InfoNotify()
		{
		}

		// Token: 0x0600B6E8 RID: 46824 RVA: 0x001B4638 File Offset: 0x001B2838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2InfoNotify(InfrV2InfoNotify other) : this()
		{
			this.infrInfo_ = ((other.infrInfo_ != null) ? other.infrInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B6E9 RID: 46825 RVA: 0x001B466D File Offset: 0x001B286D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2InfoNotify Clone()
		{
			return new InfrV2InfoNotify(this);
		}

		// Token: 0x170024E2 RID: 9442
		// (get) Token: 0x0600B6EA RID: 46826 RVA: 0x001B4675 File Offset: 0x001B2875
		// (set) Token: 0x0600B6EB RID: 46827 RVA: 0x001B467D File Offset: 0x001B287D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2Pb InfrInfo
		{
			get
			{
				return this.infrInfo_;
			}
			set
			{
				this.infrInfo_ = value;
			}
		}

		// Token: 0x0600B6EC RID: 46828 RVA: 0x001B4686 File Offset: 0x001B2886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2InfoNotify);
		}

		// Token: 0x0600B6ED RID: 46829 RVA: 0x001B4694 File Offset: 0x001B2894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2InfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.InfrInfo, other.InfrInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B6EE RID: 46830 RVA: 0x001B46C8 File Offset: 0x001B28C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.infrInfo_ != null)
			{
				num ^= this.InfrInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B6EF RID: 46831 RVA: 0x001B4704 File Offset: 0x001B2904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B6F0 RID: 46832 RVA: 0x001B4711 File Offset: 0x001B2911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B6F1 RID: 46833 RVA: 0x001B471A File Offset: 0x001B291A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.infrInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.InfrInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B6F2 RID: 46834 RVA: 0x001B474C File Offset: 0x001B294C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.infrInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InfrInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B6F3 RID: 46835 RVA: 0x001B478C File Offset: 0x001B298C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2InfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.infrInfo_ != null)
			{
				if (this.infrInfo_ == null)
				{
					this.InfrInfo = new InfrV2Pb();
				}
				this.InfrInfo.MergeFrom(other.InfrInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B6F4 RID: 46836 RVA: 0x001B47E0 File Offset: 0x001B29E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B6F5 RID: 46837 RVA: 0x001B47EC File Offset: 0x001B29EC
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
					if (this.infrInfo_ == null)
					{
						this.InfrInfo = new InfrV2Pb();
					}
					input.ReadMessage(this.InfrInfo);
				}
			}
		}

		// Token: 0x040050E6 RID: 20710
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050E7 RID: 20711
		public const int InfrInfoFieldNumber = 14;

		// Token: 0x040050E8 RID: 20712
		private InfrV2Pb infrInfo_;
	}
}
