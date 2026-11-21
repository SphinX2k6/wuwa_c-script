using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F8C RID: 3980
	[NetMessage(EMessageId.RoguelikeGiveUpGainRequest)]
	public sealed class RoguelikeGiveUpGainRequest : IMessage<RoguelikeGiveUpGainRequest>, IMessage, IEquatable<RoguelikeGiveUpGainRequest>, IDeepCloneable<RoguelikeGiveUpGainRequest>, IBufferMessage
	{
		// Token: 0x06015508 RID: 87304 RVA: 0x00318894 File Offset: 0x00316A94
		[NullableContext(1)]
		public static RoguelikeGiveUpGainRequest Create()
		{
			return new RoguelikeGiveUpGainRequest();
		}

		// Token: 0x1700470F RID: 18191
		// (get) Token: 0x06015509 RID: 87305 RVA: 0x0031889B File Offset: 0x00316A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004710 RID: 18192
		// (get) Token: 0x0601550A RID: 87306 RVA: 0x0031889E File Offset: 0x00316A9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeGiveUpGainRequest.Descriptor;
			}
		}

		// Token: 0x0601550B RID: 87307 RVA: 0x003188A5 File Offset: 0x00316AA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGiveUpGainRequest()
		{
		}

		// Token: 0x0601550C RID: 87308 RVA: 0x003188AD File Offset: 0x00316AAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGiveUpGainRequest(RoguelikeGiveUpGainRequest other) : this()
		{
			this.bindId_ = other.bindId_;
			this.layer_ = other.layer_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601550D RID: 87309 RVA: 0x003188DE File Offset: 0x00316ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGiveUpGainRequest Clone()
		{
			return new RoguelikeGiveUpGainRequest(this);
		}

		// Token: 0x17004711 RID: 18193
		// (get) Token: 0x0601550E RID: 87310 RVA: 0x003188E6 File Offset: 0x00316AE6
		// (set) Token: 0x0601550F RID: 87311 RVA: 0x003188EE File Offset: 0x00316AEE
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

		// Token: 0x17004712 RID: 18194
		// (get) Token: 0x06015510 RID: 87312 RVA: 0x003188F7 File Offset: 0x00316AF7
		// (set) Token: 0x06015511 RID: 87313 RVA: 0x003188FF File Offset: 0x00316AFF
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

		// Token: 0x06015512 RID: 87314 RVA: 0x00318908 File Offset: 0x00316B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeGiveUpGainRequest);
		}

		// Token: 0x06015513 RID: 87315 RVA: 0x00318916 File Offset: 0x00316B16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeGiveUpGainRequest other)
		{
			return other != null && (other == this || (this.BindId == other.BindId && this.Layer == other.Layer && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015514 RID: 87316 RVA: 0x00318954 File Offset: 0x00316B54
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

		// Token: 0x06015515 RID: 87317 RVA: 0x003189AC File Offset: 0x00316BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015516 RID: 87318 RVA: 0x003189B9 File Offset: 0x00316BB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015517 RID: 87319 RVA: 0x003189C4 File Offset: 0x00316BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BindId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.BindId);
			}
			if (this.Layer != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Layer);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015518 RID: 87320 RVA: 0x00318A20 File Offset: 0x00316C20
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

		// Token: 0x06015519 RID: 87321 RVA: 0x00318A78 File Offset: 0x00316C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeGiveUpGainRequest other)
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

		// Token: 0x0601551A RID: 87322 RVA: 0x00318AC8 File Offset: 0x00316CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601551B RID: 87323 RVA: 0x00318AD4 File Offset: 0x00316CD4
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
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Layer = input.ReadInt32();
					}
				}
				else
				{
					this.BindId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040080BD RID: 32957
		private UnknownFieldSet _unknownFields;

		// Token: 0x040080BE RID: 32958
		public const int BindIdFieldNumber = 5;

		// Token: 0x040080BF RID: 32959
		private int bindId_;

		// Token: 0x040080C0 RID: 32960
		public const int LayerFieldNumber = 8;

		// Token: 0x040080C1 RID: 32961
		private int layer_;
	}
}
