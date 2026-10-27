using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FE6 RID: 4070
	[NetMessage(EMessageId.RogueResGridEventRequest)]
	public sealed class RogueResGridEventRequest : IMessage<RogueResGridEventRequest>, IMessage, IEquatable<RogueResGridEventRequest>, IDeepCloneable<RogueResGridEventRequest>, IBufferMessage
	{
		// Token: 0x06015C1F RID: 89119 RVA: 0x00328E72 File Offset: 0x00327072
		[NullableContext(1)]
		public static RogueResGridEventRequest Create()
		{
			return new RogueResGridEventRequest();
		}

		// Token: 0x1700489E RID: 18590
		// (get) Token: 0x06015C20 RID: 89120 RVA: 0x00328E79 File Offset: 0x00327079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700489F RID: 18591
		// (get) Token: 0x06015C21 RID: 89121 RVA: 0x00328E7C File Offset: 0x0032707C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResGridEventRequest.Descriptor;
			}
		}

		// Token: 0x06015C22 RID: 89122 RVA: 0x00328E83 File Offset: 0x00327083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridEventRequest()
		{
		}

		// Token: 0x06015C23 RID: 89123 RVA: 0x00328E8B File Offset: 0x0032708B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridEventRequest(RogueResGridEventRequest other) : this()
		{
			this.gridIndex_ = other.gridIndex_;
			this.optionIndex_ = other.optionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015C24 RID: 89124 RVA: 0x00328EBC File Offset: 0x003270BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridEventRequest Clone()
		{
			return new RogueResGridEventRequest(this);
		}

		// Token: 0x170048A0 RID: 18592
		// (get) Token: 0x06015C25 RID: 89125 RVA: 0x00328EC4 File Offset: 0x003270C4
		// (set) Token: 0x06015C26 RID: 89126 RVA: 0x00328ECC File Offset: 0x003270CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GridIndex
		{
			get
			{
				return this.gridIndex_;
			}
			set
			{
				this.gridIndex_ = value;
			}
		}

		// Token: 0x170048A1 RID: 18593
		// (get) Token: 0x06015C27 RID: 89127 RVA: 0x00328ED5 File Offset: 0x003270D5
		// (set) Token: 0x06015C28 RID: 89128 RVA: 0x00328EDD File Offset: 0x003270DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OptionIndex
		{
			get
			{
				return this.optionIndex_;
			}
			set
			{
				this.optionIndex_ = value;
			}
		}

		// Token: 0x06015C29 RID: 89129 RVA: 0x00328EE6 File Offset: 0x003270E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResGridEventRequest);
		}

		// Token: 0x06015C2A RID: 89130 RVA: 0x00328EF4 File Offset: 0x003270F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResGridEventRequest other)
		{
			return other != null && (other == this || (this.GridIndex == other.GridIndex && this.OptionIndex == other.OptionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015C2B RID: 89131 RVA: 0x00328F34 File Offset: 0x00327134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GridIndex != 0)
			{
				num ^= this.GridIndex.GetHashCode();
			}
			if (this.OptionIndex != 0)
			{
				num ^= this.OptionIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015C2C RID: 89132 RVA: 0x00328F8C File Offset: 0x0032718C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015C2D RID: 89133 RVA: 0x00328F99 File Offset: 0x00327199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015C2E RID: 89134 RVA: 0x00328FA4 File Offset: 0x003271A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OptionIndex != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.OptionIndex);
			}
			if (this.GridIndex != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.GridIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015C2F RID: 89135 RVA: 0x00329000 File Offset: 0x00327200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GridIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GridIndex);
			}
			if (this.OptionIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OptionIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015C30 RID: 89136 RVA: 0x00329058 File Offset: 0x00327258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResGridEventRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GridIndex != 0)
			{
				this.GridIndex = other.GridIndex;
			}
			if (other.OptionIndex != 0)
			{
				this.OptionIndex = other.OptionIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015C31 RID: 89137 RVA: 0x003290A8 File Offset: 0x003272A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015C32 RID: 89138 RVA: 0x003290B4 File Offset: 0x003272B4
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
						this.GridIndex = input.ReadInt32();
					}
				}
				else
				{
					this.OptionIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008299 RID: 33433
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400829A RID: 33434
		public const int GridIndexFieldNumber = 9;

		// Token: 0x0400829B RID: 33435
		private int gridIndex_;

		// Token: 0x0400829C RID: 33436
		public const int OptionIndexFieldNumber = 4;

		// Token: 0x0400829D RID: 33437
		private int optionIndex_;
	}
}
