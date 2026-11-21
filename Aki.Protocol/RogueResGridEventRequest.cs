using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FD6 RID: 4054
	[NetMessage(EMessageId.RogueResGridEventRequest)]
	public sealed class RogueResGridEventRequest : IMessage<RogueResGridEventRequest>, IMessage, IEquatable<RogueResGridEventRequest>, IDeepCloneable<RogueResGridEventRequest>, IBufferMessage
	{
		// Token: 0x06015B3A RID: 88890 RVA: 0x003277BA File Offset: 0x003259BA
		[NullableContext(1)]
		public static RogueResGridEventRequest Create()
		{
			return new RogueResGridEventRequest();
		}

		// Token: 0x17004874 RID: 18548
		// (get) Token: 0x06015B3B RID: 88891 RVA: 0x003277C1 File Offset: 0x003259C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004875 RID: 18549
		// (get) Token: 0x06015B3C RID: 88892 RVA: 0x003277C4 File Offset: 0x003259C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResGridEventRequest.Descriptor;
			}
		}

		// Token: 0x06015B3D RID: 88893 RVA: 0x003277CB File Offset: 0x003259CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridEventRequest()
		{
		}

		// Token: 0x06015B3E RID: 88894 RVA: 0x003277D3 File Offset: 0x003259D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridEventRequest(RogueResGridEventRequest other) : this()
		{
			this.gridIndex_ = other.gridIndex_;
			this.optionIndex_ = other.optionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015B3F RID: 88895 RVA: 0x00327804 File Offset: 0x00325A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridEventRequest Clone()
		{
			return new RogueResGridEventRequest(this);
		}

		// Token: 0x17004876 RID: 18550
		// (get) Token: 0x06015B40 RID: 88896 RVA: 0x0032780C File Offset: 0x00325A0C
		// (set) Token: 0x06015B41 RID: 88897 RVA: 0x00327814 File Offset: 0x00325A14
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

		// Token: 0x17004877 RID: 18551
		// (get) Token: 0x06015B42 RID: 88898 RVA: 0x0032781D File Offset: 0x00325A1D
		// (set) Token: 0x06015B43 RID: 88899 RVA: 0x00327825 File Offset: 0x00325A25
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

		// Token: 0x06015B44 RID: 88900 RVA: 0x0032782E File Offset: 0x00325A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResGridEventRequest);
		}

		// Token: 0x06015B45 RID: 88901 RVA: 0x0032783C File Offset: 0x00325A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResGridEventRequest other)
		{
			return other != null && (other == this || (this.GridIndex == other.GridIndex && this.OptionIndex == other.OptionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015B46 RID: 88902 RVA: 0x0032787C File Offset: 0x00325A7C
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

		// Token: 0x06015B47 RID: 88903 RVA: 0x003278D4 File Offset: 0x00325AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015B48 RID: 88904 RVA: 0x003278E1 File Offset: 0x00325AE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015B49 RID: 88905 RVA: 0x003278EC File Offset: 0x00325AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OptionIndex != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.OptionIndex);
			}
			if (this.GridIndex != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.GridIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015B4A RID: 88906 RVA: 0x00327948 File Offset: 0x00325B48
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

		// Token: 0x06015B4B RID: 88907 RVA: 0x003279A0 File Offset: 0x00325BA0
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

		// Token: 0x06015B4C RID: 88908 RVA: 0x003279F0 File Offset: 0x00325BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015B4D RID: 88909 RVA: 0x003279FC File Offset: 0x00325BFC
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
					if (num != 112U)
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

		// Token: 0x040082C3 RID: 33475
		private UnknownFieldSet _unknownFields;

		// Token: 0x040082C4 RID: 33476
		public const int GridIndexFieldNumber = 14;

		// Token: 0x040082C5 RID: 33477
		private int gridIndex_;

		// Token: 0x040082C6 RID: 33478
		public const int OptionIndexFieldNumber = 8;

		// Token: 0x040082C7 RID: 33479
		private int optionIndex_;
	}
}
