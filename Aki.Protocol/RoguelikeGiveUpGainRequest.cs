using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F9C RID: 3996
	[NetMessage(EMessageId.RoguelikeGiveUpGainRequest)]
	public sealed class RoguelikeGiveUpGainRequest : IMessage<RoguelikeGiveUpGainRequest>, IMessage, IEquatable<RoguelikeGiveUpGainRequest>, IDeepCloneable<RoguelikeGiveUpGainRequest>, IBufferMessage
	{
		// Token: 0x060155ED RID: 87533 RVA: 0x00319F3C File Offset: 0x0031813C
		[NullableContext(1)]
		public static RoguelikeGiveUpGainRequest Create()
		{
			return new RoguelikeGiveUpGainRequest();
		}

		// Token: 0x17004739 RID: 18233
		// (get) Token: 0x060155EE RID: 87534 RVA: 0x00319F43 File Offset: 0x00318143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700473A RID: 18234
		// (get) Token: 0x060155EF RID: 87535 RVA: 0x00319F46 File Offset: 0x00318146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeGiveUpGainRequest.Descriptor;
			}
		}

		// Token: 0x060155F0 RID: 87536 RVA: 0x00319F4D File Offset: 0x0031814D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGiveUpGainRequest()
		{
		}

		// Token: 0x060155F1 RID: 87537 RVA: 0x00319F55 File Offset: 0x00318155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGiveUpGainRequest(RoguelikeGiveUpGainRequest other) : this()
		{
			this.bindId_ = other.bindId_;
			this.layer_ = other.layer_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060155F2 RID: 87538 RVA: 0x00319F86 File Offset: 0x00318186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGiveUpGainRequest Clone()
		{
			return new RoguelikeGiveUpGainRequest(this);
		}

		// Token: 0x1700473B RID: 18235
		// (get) Token: 0x060155F3 RID: 87539 RVA: 0x00319F8E File Offset: 0x0031818E
		// (set) Token: 0x060155F4 RID: 87540 RVA: 0x00319F96 File Offset: 0x00318196
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

		// Token: 0x1700473C RID: 18236
		// (get) Token: 0x060155F5 RID: 87541 RVA: 0x00319F9F File Offset: 0x0031819F
		// (set) Token: 0x060155F6 RID: 87542 RVA: 0x00319FA7 File Offset: 0x003181A7
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

		// Token: 0x060155F7 RID: 87543 RVA: 0x00319FB0 File Offset: 0x003181B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeGiveUpGainRequest);
		}

		// Token: 0x060155F8 RID: 87544 RVA: 0x00319FBE File Offset: 0x003181BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeGiveUpGainRequest other)
		{
			return other != null && (other == this || (this.BindId == other.BindId && this.Layer == other.Layer && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060155F9 RID: 87545 RVA: 0x00319FFC File Offset: 0x003181FC
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

		// Token: 0x060155FA RID: 87546 RVA: 0x0031A054 File Offset: 0x00318254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060155FB RID: 87547 RVA: 0x0031A061 File Offset: 0x00318261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060155FC RID: 87548 RVA: 0x0031A06C File Offset: 0x0031826C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BindId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BindId);
			}
			if (this.Layer != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Layer);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060155FD RID: 87549 RVA: 0x0031A0C8 File Offset: 0x003182C8
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

		// Token: 0x060155FE RID: 87550 RVA: 0x0031A120 File Offset: 0x00318320
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

		// Token: 0x060155FF RID: 87551 RVA: 0x0031A170 File Offset: 0x00318370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015600 RID: 87552 RVA: 0x0031A17C File Offset: 0x0031837C
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
				if (num != 16U)
				{
					if (num != 56U)
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

		// Token: 0x04008093 RID: 32915
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008094 RID: 32916
		public const int BindIdFieldNumber = 2;

		// Token: 0x04008095 RID: 32917
		private int bindId_;

		// Token: 0x04008096 RID: 32918
		public const int LayerFieldNumber = 7;

		// Token: 0x04008097 RID: 32919
		private int layer_;
	}
}
