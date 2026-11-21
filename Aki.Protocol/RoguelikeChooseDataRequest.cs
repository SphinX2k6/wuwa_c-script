using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F84 RID: 3972
	[NetMessage(EMessageId.RoguelikeChooseDataRequest)]
	public sealed class RoguelikeChooseDataRequest : IMessage<RoguelikeChooseDataRequest>, IMessage, IEquatable<RoguelikeChooseDataRequest>, IDeepCloneable<RoguelikeChooseDataRequest>, IBufferMessage
	{
		// Token: 0x0601545D RID: 87133 RVA: 0x00316DF1 File Offset: 0x00314FF1
		[NullableContext(1)]
		public static RoguelikeChooseDataRequest Create()
		{
			return new RoguelikeChooseDataRequest();
		}

		// Token: 0x170046E8 RID: 18152
		// (get) Token: 0x0601545E RID: 87134 RVA: 0x00316DF8 File Offset: 0x00314FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046E9 RID: 18153
		// (get) Token: 0x0601545F RID: 87135 RVA: 0x00316DFB File Offset: 0x00314FFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeChooseDataRequest.Descriptor;
			}
		}

		// Token: 0x06015460 RID: 87136 RVA: 0x00316E02 File Offset: 0x00315002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataRequest()
		{
		}

		// Token: 0x06015461 RID: 87137 RVA: 0x00316E0A File Offset: 0x0031500A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataRequest(RoguelikeChooseDataRequest other) : this()
		{
			this.index_ = other.index_;
			this.layer_ = other.layer_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015462 RID: 87138 RVA: 0x00316E3B File Offset: 0x0031503B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataRequest Clone()
		{
			return new RoguelikeChooseDataRequest(this);
		}

		// Token: 0x170046EA RID: 18154
		// (get) Token: 0x06015463 RID: 87139 RVA: 0x00316E43 File Offset: 0x00315043
		// (set) Token: 0x06015464 RID: 87140 RVA: 0x00316E4B File Offset: 0x0031504B
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

		// Token: 0x170046EB RID: 18155
		// (get) Token: 0x06015465 RID: 87141 RVA: 0x00316E54 File Offset: 0x00315054
		// (set) Token: 0x06015466 RID: 87142 RVA: 0x00316E5C File Offset: 0x0031505C
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

		// Token: 0x06015467 RID: 87143 RVA: 0x00316E65 File Offset: 0x00315065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeChooseDataRequest);
		}

		// Token: 0x06015468 RID: 87144 RVA: 0x00316E73 File Offset: 0x00315073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeChooseDataRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.Layer == other.Layer && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015469 RID: 87145 RVA: 0x00316EB4 File Offset: 0x003150B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0601546A RID: 87146 RVA: 0x00316F0C File Offset: 0x0031510C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601546B RID: 87147 RVA: 0x00316F19 File Offset: 0x00315119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601546C RID: 87148 RVA: 0x00316F24 File Offset: 0x00315124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Index);
			}
			if (this.Layer != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Layer);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601546D RID: 87149 RVA: 0x00316F80 File Offset: 0x00315180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0601546E RID: 87150 RVA: 0x00316FD8 File Offset: 0x003151D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeChooseDataRequest other)
		{
			if (other == null)
			{
				return;
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

		// Token: 0x0601546F RID: 87151 RVA: 0x00317028 File Offset: 0x00315228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015470 RID: 87152 RVA: 0x00317034 File Offset: 0x00315234
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
				if (num != 96U)
				{
					if (num != 120U)
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
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400807E RID: 32894
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400807F RID: 32895
		public const int IndexFieldNumber = 12;

		// Token: 0x04008080 RID: 32896
		private int index_;

		// Token: 0x04008081 RID: 32897
		public const int LayerFieldNumber = 15;

		// Token: 0x04008082 RID: 32898
		private int layer_;
	}
}
