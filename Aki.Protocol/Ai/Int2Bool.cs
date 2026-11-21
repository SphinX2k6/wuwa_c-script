using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x02001734 RID: 5940
	public sealed class Int2Bool : IMessage<Int2Bool>, IMessage, IEquatable<Int2Bool>, IDeepCloneable<Int2Bool>, IBufferMessage
	{
		// Token: 0x0601DCFC RID: 122108 RVA: 0x0045EEA1 File Offset: 0x0045D0A1
		[NullableContext(1)]
		public static Int2Bool Create()
		{
			return new Int2Bool();
		}

		// Token: 0x17006579 RID: 25977
		// (get) Token: 0x0601DCFD RID: 122109 RVA: 0x0045EEA8 File Offset: 0x0045D0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Int2Bool> Parser
		{
			get
			{
				return Int2Bool._parser;
			}
		}

		// Token: 0x1700657A RID: 25978
		// (get) Token: 0x0601DCFE RID: 122110 RVA: 0x0045EEAF File Offset: 0x0045D0AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700657B RID: 25979
		// (get) Token: 0x0601DCFF RID: 122111 RVA: 0x0045EEB2 File Offset: 0x0045D0B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Int2Bool.Descriptor;
			}
		}

		// Token: 0x0601DD00 RID: 122112 RVA: 0x0045EEB9 File Offset: 0x0045D0B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Int2Bool()
		{
		}

		// Token: 0x0601DD01 RID: 122113 RVA: 0x0045EEC1 File Offset: 0x0045D0C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Int2Bool(Int2Bool other) : this()
		{
			this.first_ = other.first_;
			this.second_ = other.second_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DD02 RID: 122114 RVA: 0x0045EEF2 File Offset: 0x0045D0F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Int2Bool Clone()
		{
			return new Int2Bool(this);
		}

		// Token: 0x1700657C RID: 25980
		// (get) Token: 0x0601DD03 RID: 122115 RVA: 0x0045EEFA File Offset: 0x0045D0FA
		// (set) Token: 0x0601DD04 RID: 122116 RVA: 0x0045EF02 File Offset: 0x0045D102
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

		// Token: 0x1700657D RID: 25981
		// (get) Token: 0x0601DD05 RID: 122117 RVA: 0x0045EF0B File Offset: 0x0045D10B
		// (set) Token: 0x0601DD06 RID: 122118 RVA: 0x0045EF13 File Offset: 0x0045D113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Second
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

		// Token: 0x0601DD07 RID: 122119 RVA: 0x0045EF1C File Offset: 0x0045D11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Int2Bool);
		}

		// Token: 0x0601DD08 RID: 122120 RVA: 0x0045EF2A File Offset: 0x0045D12A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Int2Bool other)
		{
			return other != null && (other == this || (this.First == other.First && this.Second == other.Second && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DD09 RID: 122121 RVA: 0x0045EF68 File Offset: 0x0045D168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.First != 0)
			{
				num ^= this.First.GetHashCode();
			}
			if (this.Second)
			{
				num ^= this.Second.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DD0A RID: 122122 RVA: 0x0045EFC0 File Offset: 0x0045D1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DD0B RID: 122123 RVA: 0x0045EFCD File Offset: 0x0045D1CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DD0C RID: 122124 RVA: 0x0045EFD8 File Offset: 0x0045D1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.First != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.First);
			}
			if (this.Second)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Second);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DD0D RID: 122125 RVA: 0x0045F030 File Offset: 0x0045D230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.First != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.First);
			}
			if (this.Second)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DD0E RID: 122126 RVA: 0x0045F07C File Offset: 0x0045D27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Int2Bool other)
		{
			if (other == null)
			{
				return;
			}
			if (other.First != 0)
			{
				this.First = other.First;
			}
			if (other.Second)
			{
				this.Second = other.Second;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DD0F RID: 122127 RVA: 0x0045F0CC File Offset: 0x0045D2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DD10 RID: 122128 RVA: 0x0045F0D8 File Offset: 0x0045D2D8
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
						this.Second = input.ReadBool();
					}
				}
				else
				{
					this.First = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400C995 RID: 51605
		private static readonly MessageParser<Int2Bool> _parser = new MessageParser<Int2Bool>(() => new Int2Bool());

		// Token: 0x0400C996 RID: 51606
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C997 RID: 51607
		public const int FirstFieldNumber = 1;

		// Token: 0x0400C998 RID: 51608
		private int first_;

		// Token: 0x0400C999 RID: 51609
		public const int SecondFieldNumber = 2;

		// Token: 0x0400C99A RID: 51610
		private bool second_;
	}
}
