using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F94 RID: 3988
	[NetMessage(EMessageId.RoguelikeChooseDataRequest)]
	public sealed class RoguelikeChooseDataRequest : IMessage<RoguelikeChooseDataRequest>, IMessage, IEquatable<RoguelikeChooseDataRequest>, IDeepCloneable<RoguelikeChooseDataRequest>, IBufferMessage
	{
		// Token: 0x06015542 RID: 87362 RVA: 0x003184A5 File Offset: 0x003166A5
		[NullableContext(1)]
		public static RoguelikeChooseDataRequest Create()
		{
			return new RoguelikeChooseDataRequest();
		}

		// Token: 0x17004712 RID: 18194
		// (get) Token: 0x06015543 RID: 87363 RVA: 0x003184AC File Offset: 0x003166AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004713 RID: 18195
		// (get) Token: 0x06015544 RID: 87364 RVA: 0x003184AF File Offset: 0x003166AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeChooseDataRequest.Descriptor;
			}
		}

		// Token: 0x06015545 RID: 87365 RVA: 0x003184B6 File Offset: 0x003166B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataRequest()
		{
		}

		// Token: 0x06015546 RID: 87366 RVA: 0x003184BE File Offset: 0x003166BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataRequest(RoguelikeChooseDataRequest other) : this()
		{
			this.index_ = other.index_;
			this.layer_ = other.layer_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015547 RID: 87367 RVA: 0x003184EF File Offset: 0x003166EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataRequest Clone()
		{
			return new RoguelikeChooseDataRequest(this);
		}

		// Token: 0x17004714 RID: 18196
		// (get) Token: 0x06015548 RID: 87368 RVA: 0x003184F7 File Offset: 0x003166F7
		// (set) Token: 0x06015549 RID: 87369 RVA: 0x003184FF File Offset: 0x003166FF
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

		// Token: 0x17004715 RID: 18197
		// (get) Token: 0x0601554A RID: 87370 RVA: 0x00318508 File Offset: 0x00316708
		// (set) Token: 0x0601554B RID: 87371 RVA: 0x00318510 File Offset: 0x00316710
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

		// Token: 0x0601554C RID: 87372 RVA: 0x00318519 File Offset: 0x00316719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeChooseDataRequest);
		}

		// Token: 0x0601554D RID: 87373 RVA: 0x00318527 File Offset: 0x00316727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeChooseDataRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.Layer == other.Layer && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601554E RID: 87374 RVA: 0x00318568 File Offset: 0x00316768
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

		// Token: 0x0601554F RID: 87375 RVA: 0x003185C0 File Offset: 0x003167C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015550 RID: 87376 RVA: 0x003185CD File Offset: 0x003167CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015551 RID: 87377 RVA: 0x003185D8 File Offset: 0x003167D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Layer != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Layer);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015552 RID: 87378 RVA: 0x00318634 File Offset: 0x00316834
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

		// Token: 0x06015553 RID: 87379 RVA: 0x0031868C File Offset: 0x0031688C
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

		// Token: 0x06015554 RID: 87380 RVA: 0x003186DC File Offset: 0x003168DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015555 RID: 87381 RVA: 0x003186E8 File Offset: 0x003168E8
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.Layer = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008054 RID: 32852
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008055 RID: 32853
		public const int IndexFieldNumber = 15;

		// Token: 0x04008056 RID: 32854
		private int index_;

		// Token: 0x04008057 RID: 32855
		public const int LayerFieldNumber = 2;

		// Token: 0x04008058 RID: 32856
		private int layer_;
	}
}
