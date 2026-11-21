using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D11 RID: 3345
	public sealed class PhBaPlanSetStatusInfo : IMessage<PhBaPlanSetStatusInfo>, IMessage, IEquatable<PhBaPlanSetStatusInfo>, IDeepCloneable<PhBaPlanSetStatusInfo>, IBufferMessage
	{
		// Token: 0x0601216B RID: 74091 RVA: 0x002A4E34 File Offset: 0x002A3034
		[NullableContext(1)]
		public static PhBaPlanSetStatusInfo Create()
		{
			return new PhBaPlanSetStatusInfo();
		}

		// Token: 0x17003BEC RID: 15340
		// (get) Token: 0x0601216C RID: 74092 RVA: 0x002A4E3B File Offset: 0x002A303B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhBaPlanSetStatusInfo> Parser
		{
			get
			{
				return PhBaPlanSetStatusInfo._parser;
			}
		}

		// Token: 0x17003BED RID: 15341
		// (get) Token: 0x0601216D RID: 74093 RVA: 0x002A4E42 File Offset: 0x002A3042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BEE RID: 15342
		// (get) Token: 0x0601216E RID: 74094 RVA: 0x002A4E45 File Offset: 0x002A3045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanSetStatusInfo.Descriptor;
			}
		}

		// Token: 0x0601216F RID: 74095 RVA: 0x002A4E4C File Offset: 0x002A304C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetStatusInfo()
		{
		}

		// Token: 0x06012170 RID: 74096 RVA: 0x002A4E54 File Offset: 0x002A3054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetStatusInfo(PhBaPlanSetStatusInfo other) : this()
		{
			this.open_ = other.open_;
			this.suit_ = other.suit_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012171 RID: 74097 RVA: 0x002A4E85 File Offset: 0x002A3085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetStatusInfo Clone()
		{
			return new PhBaPlanSetStatusInfo(this);
		}

		// Token: 0x17003BEF RID: 15343
		// (get) Token: 0x06012172 RID: 74098 RVA: 0x002A4E8D File Offset: 0x002A308D
		// (set) Token: 0x06012173 RID: 74099 RVA: 0x002A4E95 File Offset: 0x002A3095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Open
		{
			get
			{
				return this.open_;
			}
			set
			{
				this.open_ = value;
			}
		}

		// Token: 0x17003BF0 RID: 15344
		// (get) Token: 0x06012174 RID: 74100 RVA: 0x002A4E9E File Offset: 0x002A309E
		// (set) Token: 0x06012175 RID: 74101 RVA: 0x002A4EA6 File Offset: 0x002A30A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Suit
		{
			get
			{
				return this.suit_;
			}
			set
			{
				this.suit_ = value;
			}
		}

		// Token: 0x06012176 RID: 74102 RVA: 0x002A4EAF File Offset: 0x002A30AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanSetStatusInfo);
		}

		// Token: 0x06012177 RID: 74103 RVA: 0x002A4EBD File Offset: 0x002A30BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanSetStatusInfo other)
		{
			return other != null && (other == this || (this.Open == other.Open && this.Suit == other.Suit && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012178 RID: 74104 RVA: 0x002A4EFC File Offset: 0x002A30FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Open)
			{
				num ^= this.Open.GetHashCode();
			}
			if (this.Suit != 0)
			{
				num ^= this.Suit.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012179 RID: 74105 RVA: 0x002A4F54 File Offset: 0x002A3154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601217A RID: 74106 RVA: 0x002A4F61 File Offset: 0x002A3161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601217B RID: 74107 RVA: 0x002A4F6C File Offset: 0x002A316C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Open)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Open);
			}
			if (this.Suit != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Suit);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601217C RID: 74108 RVA: 0x002A4FC4 File Offset: 0x002A31C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Open)
			{
				num += 2;
			}
			if (this.Suit != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Suit);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601217D RID: 74109 RVA: 0x002A5010 File Offset: 0x002A3210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaPlanSetStatusInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Open)
			{
				this.Open = other.Open;
			}
			if (other.Suit != 0)
			{
				this.Suit = other.Suit;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601217E RID: 74110 RVA: 0x002A5060 File Offset: 0x002A3260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601217F RID: 74111 RVA: 0x002A506C File Offset: 0x002A326C
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
						this.Suit = input.ReadInt32();
					}
				}
				else
				{
					this.Open = input.ReadBool();
				}
			}
		}

		// Token: 0x0400717F RID: 29055
		private static readonly MessageParser<PhBaPlanSetStatusInfo> _parser = new MessageParser<PhBaPlanSetStatusInfo>(() => new PhBaPlanSetStatusInfo());

		// Token: 0x04007180 RID: 29056
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007181 RID: 29057
		public const int OpenFieldNumber = 1;

		// Token: 0x04007182 RID: 29058
		private bool open_;

		// Token: 0x04007183 RID: 29059
		public const int SuitFieldNumber = 2;

		// Token: 0x04007184 RID: 29060
		private int suit_;
	}
}
