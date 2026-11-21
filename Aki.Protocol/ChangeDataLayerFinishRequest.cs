using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200024D RID: 589
	[NetMessage(EMessageId.ChangeDataLayerFinishRequest)]
	public sealed class ChangeDataLayerFinishRequest : IMessage<ChangeDataLayerFinishRequest>, IMessage, IEquatable<ChangeDataLayerFinishRequest>, IDeepCloneable<ChangeDataLayerFinishRequest>, IBufferMessage
	{
		// Token: 0x06003F28 RID: 16168 RVA: 0x0009C081 File Offset: 0x0009A281
		[NullableContext(1)]
		public static ChangeDataLayerFinishRequest Create()
		{
			return new ChangeDataLayerFinishRequest();
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06003F29 RID: 16169 RVA: 0x0009C088 File Offset: 0x0009A288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06003F2A RID: 16170 RVA: 0x0009C08B File Offset: 0x0009A28B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeDataLayerFinishRequest.Descriptor;
			}
		}

		// Token: 0x06003F2B RID: 16171 RVA: 0x0009C092 File Offset: 0x0009A292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeDataLayerFinishRequest()
		{
		}

		// Token: 0x06003F2C RID: 16172 RVA: 0x0009C09A File Offset: 0x0009A29A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeDataLayerFinishRequest(ChangeDataLayerFinishRequest other) : this()
		{
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F2D RID: 16173 RVA: 0x0009C0BF File Offset: 0x0009A2BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeDataLayerFinishRequest Clone()
		{
			return new ChangeDataLayerFinishRequest(this);
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06003F2E RID: 16174 RVA: 0x0009C0C7 File Offset: 0x0009A2C7
		// (set) Token: 0x06003F2F RID: 16175 RVA: 0x0009C0CF File Offset: 0x0009A2CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x06003F30 RID: 16176 RVA: 0x0009C0D8 File Offset: 0x0009A2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeDataLayerFinishRequest);
		}

		// Token: 0x06003F31 RID: 16177 RVA: 0x0009C0E6 File Offset: 0x0009A2E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeDataLayerFinishRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003F32 RID: 16178 RVA: 0x0009C114 File Offset: 0x0009A314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x0009C153 File Offset: 0x0009A353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x0009C160 File Offset: 0x0009A360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x0009C169 File Offset: 0x0009A369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F36 RID: 16182 RVA: 0x0009C19C File Offset: 0x0009A39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003F37 RID: 16183 RVA: 0x0009C1DA File Offset: 0x0009A3DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeDataLayerFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003F38 RID: 16184 RVA: 0x0009C20B File Offset: 0x0009A40B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F39 RID: 16185 RVA: 0x0009C214 File Offset: 0x0009A414
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
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002D6A RID: 11626
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D6B RID: 11627
		public const int InstIdFieldNumber = 1;

		// Token: 0x04002D6C RID: 11628
		private int instId_;
	}
}
