using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x02001735 RID: 5941
	public sealed class Int2Long : IMessage<Int2Long>, IMessage, IEquatable<Int2Long>, IDeepCloneable<Int2Long>, IBufferMessage
	{
		// Token: 0x0601DD12 RID: 122130 RVA: 0x0045F14B File Offset: 0x0045D34B
		[NullableContext(1)]
		public static Int2Long Create()
		{
			return new Int2Long();
		}

		// Token: 0x1700657E RID: 25982
		// (get) Token: 0x0601DD13 RID: 122131 RVA: 0x0045F152 File Offset: 0x0045D352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Int2Long> Parser
		{
			get
			{
				return Int2Long._parser;
			}
		}

		// Token: 0x1700657F RID: 25983
		// (get) Token: 0x0601DD14 RID: 122132 RVA: 0x0045F159 File Offset: 0x0045D359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006580 RID: 25984
		// (get) Token: 0x0601DD15 RID: 122133 RVA: 0x0045F15C File Offset: 0x0045D35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Int2Long.Descriptor;
			}
		}

		// Token: 0x0601DD16 RID: 122134 RVA: 0x0045F163 File Offset: 0x0045D363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Int2Long()
		{
		}

		// Token: 0x0601DD17 RID: 122135 RVA: 0x0045F16B File Offset: 0x0045D36B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Int2Long(Int2Long other) : this()
		{
			this.first_ = other.first_;
			this.second_ = other.second_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DD18 RID: 122136 RVA: 0x0045F19C File Offset: 0x0045D39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Int2Long Clone()
		{
			return new Int2Long(this);
		}

		// Token: 0x17006581 RID: 25985
		// (get) Token: 0x0601DD19 RID: 122137 RVA: 0x0045F1A4 File Offset: 0x0045D3A4
		// (set) Token: 0x0601DD1A RID: 122138 RVA: 0x0045F1AC File Offset: 0x0045D3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int First
		{
			get
			{
				return this.first_;
			}
			set
			{
				this.first_ = value;
			}
		}

		// Token: 0x17006582 RID: 25986
		// (get) Token: 0x0601DD1B RID: 122139 RVA: 0x0045F1B5 File Offset: 0x0045D3B5
		// (set) Token: 0x0601DD1C RID: 122140 RVA: 0x0045F1BD File Offset: 0x0045D3BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Second
		{
			get
			{
				return this.second_;
			}
			set
			{
				this.second_ = value;
			}
		}

		// Token: 0x0601DD1D RID: 122141 RVA: 0x0045F1C6 File Offset: 0x0045D3C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Int2Long);
		}

		// Token: 0x0601DD1E RID: 122142 RVA: 0x0045F1D4 File Offset: 0x0045D3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Int2Long other)
		{
			return other != null && (other == this || (this.First == other.First && this.Second == other.Second && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DD1F RID: 122143 RVA: 0x0045F214 File Offset: 0x0045D414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.First != 0)
			{
				num ^= this.First.GetHashCode();
			}
			if (this.Second != 0L)
			{
				num ^= this.Second.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DD20 RID: 122144 RVA: 0x0045F26C File Offset: 0x0045D46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DD21 RID: 122145 RVA: 0x0045F279 File Offset: 0x0045D479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DD22 RID: 122146 RVA: 0x0045F284 File Offset: 0x0045D484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.First != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.First);
			}
			if (this.Second != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.Second);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DD23 RID: 122147 RVA: 0x0045F2DC File Offset: 0x0045D4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.First != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.First);
			}
			if (this.Second != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Second);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DD24 RID: 122148 RVA: 0x0045F334 File Offset: 0x0045D534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Int2Long other)
		{
			if (other == null)
			{
				return;
			}
			if (other.First != 0)
			{
				this.First = other.First;
			}
			if (other.Second != 0L)
			{
				this.Second = other.Second;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DD25 RID: 122149 RVA: 0x0045F384 File Offset: 0x0045D584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DD26 RID: 122150 RVA: 0x0045F390 File Offset: 0x0045D590
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Second = input.ReadInt64();
					}
				}
				else
				{
					this.First = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400C99B RID: 51611
		private static readonly MessageParser<Int2Long> _parser = new MessageParser<Int2Long>(() => new Int2Long());

		// Token: 0x0400C99C RID: 51612
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C99D RID: 51613
		public const int FirstFieldNumber = 1;

		// Token: 0x0400C99E RID: 51614
		private int first_;

		// Token: 0x0400C99F RID: 51615
		public const int SecondFieldNumber = 2;

		// Token: 0x0400C9A0 RID: 51616
		private long second_;
	}
}
