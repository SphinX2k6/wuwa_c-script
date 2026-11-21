using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001030 RID: 4144
	[NetMessage(EMessageId.RogueWeeklyOptionSelectRequest)]
	public sealed class RogueWeeklyOptionSelectRequest : IMessage<RogueWeeklyOptionSelectRequest>, IMessage, IEquatable<RogueWeeklyOptionSelectRequest>, IDeepCloneable<RogueWeeklyOptionSelectRequest>, IBufferMessage
	{
		// Token: 0x060162CA RID: 90826 RVA: 0x00339566 File Offset: 0x00337766
		[NullableContext(1)]
		public static RogueWeeklyOptionSelectRequest Create()
		{
			return new RogueWeeklyOptionSelectRequest();
		}

		// Token: 0x17004A28 RID: 18984
		// (get) Token: 0x060162CB RID: 90827 RVA: 0x0033956D File Offset: 0x0033776D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A29 RID: 18985
		// (get) Token: 0x060162CC RID: 90828 RVA: 0x00339570 File Offset: 0x00337770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyOptionSelectRequest.Descriptor;
			}
		}

		// Token: 0x060162CD RID: 90829 RVA: 0x00339577 File Offset: 0x00337777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyOptionSelectRequest()
		{
		}

		// Token: 0x060162CE RID: 90830 RVA: 0x0033957F File Offset: 0x0033777F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyOptionSelectRequest(RogueWeeklyOptionSelectRequest other) : this()
		{
			this.bindId_ = other.bindId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060162CF RID: 90831 RVA: 0x003395B0 File Offset: 0x003377B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyOptionSelectRequest Clone()
		{
			return new RogueWeeklyOptionSelectRequest(this);
		}

		// Token: 0x17004A2A RID: 18986
		// (get) Token: 0x060162D0 RID: 90832 RVA: 0x003395B8 File Offset: 0x003377B8
		// (set) Token: 0x060162D1 RID: 90833 RVA: 0x003395C0 File Offset: 0x003377C0
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

		// Token: 0x17004A2B RID: 18987
		// (get) Token: 0x060162D2 RID: 90834 RVA: 0x003395C9 File Offset: 0x003377C9
		// (set) Token: 0x060162D3 RID: 90835 RVA: 0x003395D1 File Offset: 0x003377D1
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

		// Token: 0x060162D4 RID: 90836 RVA: 0x003395DA File Offset: 0x003377DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyOptionSelectRequest);
		}

		// Token: 0x060162D5 RID: 90837 RVA: 0x003395E8 File Offset: 0x003377E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyOptionSelectRequest other)
		{
			return other != null && (other == this || (this.BindId == other.BindId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060162D6 RID: 90838 RVA: 0x00339628 File Offset: 0x00337828
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060162D7 RID: 90839 RVA: 0x00339680 File Offset: 0x00337880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060162D8 RID: 90840 RVA: 0x0033968D File Offset: 0x0033788D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060162D9 RID: 90841 RVA: 0x00339698 File Offset: 0x00337898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Index);
			}
			if (this.BindId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.BindId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060162DA RID: 90842 RVA: 0x003396F4 File Offset: 0x003378F4
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060162DB RID: 90843 RVA: 0x0033974C File Offset: 0x0033794C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyOptionSelectRequest other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060162DC RID: 90844 RVA: 0x0033979C File Offset: 0x0033799C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060162DD RID: 90845 RVA: 0x003397A8 File Offset: 0x003379A8
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
				if (num != 48U)
				{
					if (num != 120U)
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
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400852C RID: 34092
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400852D RID: 34093
		public const int BindIdFieldNumber = 15;

		// Token: 0x0400852E RID: 34094
		private int bindId_;

		// Token: 0x0400852F RID: 34095
		public const int IndexFieldNumber = 6;

		// Token: 0x04008530 RID: 34096
		private int index_;
	}
}
