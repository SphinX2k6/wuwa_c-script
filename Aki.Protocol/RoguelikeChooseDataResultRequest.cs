using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F86 RID: 3974
	[NetMessage(EMessageId.RoguelikeChooseDataResultRequest)]
	public sealed class RoguelikeChooseDataResultRequest : IMessage<RoguelikeChooseDataResultRequest>, IMessage, IEquatable<RoguelikeChooseDataResultRequest>, IDeepCloneable<RoguelikeChooseDataResultRequest>, IBufferMessage
	{
		// Token: 0x06015487 RID: 87175 RVA: 0x00317421 File Offset: 0x00315621
		[NullableContext(1)]
		public static RoguelikeChooseDataResultRequest Create()
		{
			return new RoguelikeChooseDataResultRequest();
		}

		// Token: 0x170046F1 RID: 18161
		// (get) Token: 0x06015488 RID: 87176 RVA: 0x00317428 File Offset: 0x00315628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046F2 RID: 18162
		// (get) Token: 0x06015489 RID: 87177 RVA: 0x0031742B File Offset: 0x0031562B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeChooseDataResultRequest.Descriptor;
			}
		}

		// Token: 0x0601548A RID: 87178 RVA: 0x00317432 File Offset: 0x00315632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataResultRequest()
		{
		}

		// Token: 0x0601548B RID: 87179 RVA: 0x0031743A File Offset: 0x0031563A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataResultRequest(RoguelikeChooseDataResultRequest other) : this()
		{
			this.bindId_ = other.bindId_;
			this.index_ = other.index_;
			this.layer_ = other.layer_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601548C RID: 87180 RVA: 0x00317477 File Offset: 0x00315677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseDataResultRequest Clone()
		{
			return new RoguelikeChooseDataResultRequest(this);
		}

		// Token: 0x170046F3 RID: 18163
		// (get) Token: 0x0601548D RID: 87181 RVA: 0x0031747F File Offset: 0x0031567F
		// (set) Token: 0x0601548E RID: 87182 RVA: 0x00317487 File Offset: 0x00315687
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

		// Token: 0x170046F4 RID: 18164
		// (get) Token: 0x0601548F RID: 87183 RVA: 0x00317490 File Offset: 0x00315690
		// (set) Token: 0x06015490 RID: 87184 RVA: 0x00317498 File Offset: 0x00315698
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

		// Token: 0x170046F5 RID: 18165
		// (get) Token: 0x06015491 RID: 87185 RVA: 0x003174A1 File Offset: 0x003156A1
		// (set) Token: 0x06015492 RID: 87186 RVA: 0x003174A9 File Offset: 0x003156A9
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

		// Token: 0x06015493 RID: 87187 RVA: 0x003174B2 File Offset: 0x003156B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeChooseDataResultRequest);
		}

		// Token: 0x06015494 RID: 87188 RVA: 0x003174C0 File Offset: 0x003156C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeChooseDataResultRequest other)
		{
			return other != null && (other == this || (this.BindId == other.BindId && this.Index == other.Index && this.Layer == other.Layer && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015495 RID: 87189 RVA: 0x0031751C File Offset: 0x0031571C
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

		// Token: 0x06015496 RID: 87190 RVA: 0x0031758D File Offset: 0x0031578D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015497 RID: 87191 RVA: 0x0031759A File Offset: 0x0031579A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015498 RID: 87192 RVA: 0x003175A4 File Offset: 0x003157A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Layer != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Layer);
			}
			if (this.BindId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.BindId);
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

		// Token: 0x06015499 RID: 87193 RVA: 0x0031761C File Offset: 0x0031581C
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

		// Token: 0x0601549A RID: 87194 RVA: 0x0031768C File Offset: 0x0031588C
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

		// Token: 0x0601549B RID: 87195 RVA: 0x003176F0 File Offset: 0x003158F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601549C RID: 87196 RVA: 0x003176FC File Offset: 0x003158FC
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
				if (num != 64U)
				{
					if (num != 88U)
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
						this.BindId = input.ReadInt32();
					}
				}
				else
				{
					this.Layer = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400808B RID: 32907
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400808C RID: 32908
		public const int BindIdFieldNumber = 11;

		// Token: 0x0400808D RID: 32909
		private int bindId_;

		// Token: 0x0400808E RID: 32910
		public const int IndexFieldNumber = 15;

		// Token: 0x0400808F RID: 32911
		private int index_;

		// Token: 0x04008090 RID: 32912
		public const int LayerFieldNumber = 8;

		// Token: 0x04008091 RID: 32913
		private int layer_;
	}
}
