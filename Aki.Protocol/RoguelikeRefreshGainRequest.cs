using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FAB RID: 4011
	[NetMessage(EMessageId.RoguelikeRefreshGainRequest)]
	public sealed class RoguelikeRefreshGainRequest : IMessage<RoguelikeRefreshGainRequest>, IMessage, IEquatable<RoguelikeRefreshGainRequest>, IDeepCloneable<RoguelikeRefreshGainRequest>, IBufferMessage
	{
		// Token: 0x06015721 RID: 87841 RVA: 0x0031CBDD File Offset: 0x0031ADDD
		[NullableContext(1)]
		public static RoguelikeRefreshGainRequest Create()
		{
			return new RoguelikeRefreshGainRequest();
		}

		// Token: 0x1700477B RID: 18299
		// (get) Token: 0x06015722 RID: 87842 RVA: 0x0031CBE4 File Offset: 0x0031ADE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700477C RID: 18300
		// (get) Token: 0x06015723 RID: 87843 RVA: 0x0031CBE7 File Offset: 0x0031ADE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeRefreshGainRequest.Descriptor;
			}
		}

		// Token: 0x06015724 RID: 87844 RVA: 0x0031CBEE File Offset: 0x0031ADEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRefreshGainRequest()
		{
		}

		// Token: 0x06015725 RID: 87845 RVA: 0x0031CBF6 File Offset: 0x0031ADF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRefreshGainRequest(RoguelikeRefreshGainRequest other) : this()
		{
			this.bindId_ = other.bindId_;
			this.layer_ = other.layer_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015726 RID: 87846 RVA: 0x0031CC27 File Offset: 0x0031AE27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRefreshGainRequest Clone()
		{
			return new RoguelikeRefreshGainRequest(this);
		}

		// Token: 0x1700477D RID: 18301
		// (get) Token: 0x06015727 RID: 87847 RVA: 0x0031CC2F File Offset: 0x0031AE2F
		// (set) Token: 0x06015728 RID: 87848 RVA: 0x0031CC37 File Offset: 0x0031AE37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BindId
		{
			get
			{
				return this.bindId_;
			}
			set
			{
				this.bindId_ = value;
			}
		}

		// Token: 0x1700477E RID: 18302
		// (get) Token: 0x06015729 RID: 87849 RVA: 0x0031CC40 File Offset: 0x0031AE40
		// (set) Token: 0x0601572A RID: 87850 RVA: 0x0031CC48 File Offset: 0x0031AE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Layer
		{
			get
			{
				return this.layer_;
			}
			set
			{
				this.layer_ = value;
			}
		}

		// Token: 0x0601572B RID: 87851 RVA: 0x0031CC51 File Offset: 0x0031AE51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeRefreshGainRequest);
		}

		// Token: 0x0601572C RID: 87852 RVA: 0x0031CC5F File Offset: 0x0031AE5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeRefreshGainRequest other)
		{
			return other != null && (other == this || (this.BindId == other.BindId && this.Layer == other.Layer && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601572D RID: 87853 RVA: 0x0031CCA0 File Offset: 0x0031AEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BindId != 0)
			{
				num ^= this.BindId.GetHashCode();
			}
			if (this.Layer != 0)
			{
				num ^= this.Layer.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601572E RID: 87854 RVA: 0x0031CCF8 File Offset: 0x0031AEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601572F RID: 87855 RVA: 0x0031CD05 File Offset: 0x0031AF05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015730 RID: 87856 RVA: 0x0031CD10 File Offset: 0x0031AF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Layer != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Layer);
			}
			if (this.BindId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.BindId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015731 RID: 87857 RVA: 0x0031CD6C File Offset: 0x0031AF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BindId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BindId);
			}
			if (this.Layer != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Layer);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015732 RID: 87858 RVA: 0x0031CDC4 File Offset: 0x0031AFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeRefreshGainRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BindId != 0)
			{
				this.BindId = other.BindId;
			}
			if (other.Layer != 0)
			{
				this.Layer = other.Layer;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015733 RID: 87859 RVA: 0x0031CE14 File Offset: 0x0031B014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015734 RID: 87860 RVA: 0x0031CE20 File Offset: 0x0031B020
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
				if (num != 32U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BindId = input.ReadInt32();
					}
				}
				else
				{
					this.Layer = input.ReadInt32();
				}
			}
		}

		// Token: 0x040080F2 RID: 33010
		private UnknownFieldSet _unknownFields;

		// Token: 0x040080F3 RID: 33011
		public const int BindIdFieldNumber = 9;

		// Token: 0x040080F4 RID: 33012
		private int bindId_;

		// Token: 0x040080F5 RID: 33013
		public const int LayerFieldNumber = 4;

		// Token: 0x040080F6 RID: 33014
		private int layer_;
	}
}
