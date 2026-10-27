using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F96 RID: 3990
	[NetMessage(EMessageId.RoguelikeChooseDataResultRequest)]
	public sealed class RoguelikeChooseDataResultRequest : IMessage<RoguelikeChooseDataResultRequest>, IMessage, IEquatable<RoguelikeChooseDataResultRequest>, IDeepCloneable<RoguelikeChooseDataResultRequest>, IBufferMessage
	{
		// Token: 0x0601556C RID: 87404 RVA: 0x00318AD5 File Offset: 0x00316CD5
		[NullableContext(1)]
		public static RoguelikeChooseDataResultRequest Create()
		{
			return new RoguelikeChooseDataResultRequest();
		}

		// Token: 0x1700471B RID: 18203
		// (get) Token: 0x0601556D RID: 87405 RVA: 0x00318ADC File Offset: 0x00316CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700471C RID: 18204
		// (get) Token: 0x0601556E RID: 87406 RVA: 0x00318ADF File Offset: 0x00316CDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeChooseDataResultRequest.Descriptor;
			}
		}

		// Token: 0x0601556F RID: 87407 RVA: 0x00318AE6 File Offset: 0x00316CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataResultRequest()
		{
		}

		// Token: 0x06015570 RID: 87408 RVA: 0x00318AEE File Offset: 0x00316CEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataResultRequest(RoguelikeChooseDataResultRequest other) : this()
		{
			this.bindId_ = other.bindId_;
			this.index_ = other.index_;
			this.layer_ = other.layer_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015571 RID: 87409 RVA: 0x00318B2B File Offset: 0x00316D2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataResultRequest Clone()
		{
			return new RoguelikeChooseDataResultRequest(this);
		}

		// Token: 0x1700471D RID: 18205
		// (get) Token: 0x06015572 RID: 87410 RVA: 0x00318B33 File Offset: 0x00316D33
		// (set) Token: 0x06015573 RID: 87411 RVA: 0x00318B3B File Offset: 0x00316D3B
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

		// Token: 0x1700471E RID: 18206
		// (get) Token: 0x06015574 RID: 87412 RVA: 0x00318B44 File Offset: 0x00316D44
		// (set) Token: 0x06015575 RID: 87413 RVA: 0x00318B4C File Offset: 0x00316D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x1700471F RID: 18207
		// (get) Token: 0x06015576 RID: 87414 RVA: 0x00318B55 File Offset: 0x00316D55
		// (set) Token: 0x06015577 RID: 87415 RVA: 0x00318B5D File Offset: 0x00316D5D
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

		// Token: 0x06015578 RID: 87416 RVA: 0x00318B66 File Offset: 0x00316D66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeChooseDataResultRequest);
		}

		// Token: 0x06015579 RID: 87417 RVA: 0x00318B74 File Offset: 0x00316D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeChooseDataResultRequest other)
		{
			return other != null && (other == this || (this.BindId == other.BindId && this.Index == other.Index && this.Layer == other.Layer && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601557A RID: 87418 RVA: 0x00318BD0 File Offset: 0x00316DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BindId != 0)
			{
				num ^= this.BindId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
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

		// Token: 0x0601557B RID: 87419 RVA: 0x00318C41 File Offset: 0x00316E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601557C RID: 87420 RVA: 0x00318C4E File Offset: 0x00316E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601557D RID: 87421 RVA: 0x00318C58 File Offset: 0x00316E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Index);
			}
			if (this.BindId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.BindId);
			}
			if (this.Layer != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Layer);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601557E RID: 87422 RVA: 0x00318CCC File Offset: 0x00316ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BindId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BindId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
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

		// Token: 0x0601557F RID: 87423 RVA: 0x00318D3C File Offset: 0x00316F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeChooseDataResultRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BindId != 0)
			{
				this.BindId = other.BindId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.Layer != 0)
			{
				this.Layer = other.Layer;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015580 RID: 87424 RVA: 0x00318DA0 File Offset: 0x00316FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015581 RID: 87425 RVA: 0x00318DAC File Offset: 0x00316FAC
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
					if (num != 48U)
					{
						if (num != 72U)
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
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008061 RID: 32865
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008062 RID: 32866
		public const int BindIdFieldNumber = 6;

		// Token: 0x04008063 RID: 32867
		private int bindId_;

		// Token: 0x04008064 RID: 32868
		public const int IndexFieldNumber = 1;

		// Token: 0x04008065 RID: 32869
		private int index_;

		// Token: 0x04008066 RID: 32870
		public const int LayerFieldNumber = 9;

		// Token: 0x04008067 RID: 32871
		private int layer_;
	}
}
