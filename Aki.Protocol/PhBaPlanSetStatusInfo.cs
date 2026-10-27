using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D21 RID: 3361
	public sealed class PhBaPlanSetStatusInfo : IMessage<PhBaPlanSetStatusInfo>, IMessage, IEquatable<PhBaPlanSetStatusInfo>, IDeepCloneable<PhBaPlanSetStatusInfo>, IBufferMessage
	{
		// Token: 0x06012267 RID: 74343 RVA: 0x002A6A58 File Offset: 0x002A4C58
		[NullableContext(1)]
		public static PhBaPlanSetStatusInfo Create()
		{
			return new PhBaPlanSetStatusInfo();
		}

		// Token: 0x17003C21 RID: 15393
		// (get) Token: 0x06012268 RID: 74344 RVA: 0x002A6A5F File Offset: 0x002A4C5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhBaPlanSetStatusInfo> Parser
		{
			get
			{
				return PhBaPlanSetStatusInfo._parser;
			}
		}

		// Token: 0x17003C22 RID: 15394
		// (get) Token: 0x06012269 RID: 74345 RVA: 0x002A6A66 File Offset: 0x002A4C66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C23 RID: 15395
		// (get) Token: 0x0601226A RID: 74346 RVA: 0x002A6A69 File Offset: 0x002A4C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanSetStatusInfo.Descriptor;
			}
		}

		// Token: 0x0601226B RID: 74347 RVA: 0x002A6A70 File Offset: 0x002A4C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetStatusInfo()
		{
		}

		// Token: 0x0601226C RID: 74348 RVA: 0x002A6A78 File Offset: 0x002A4C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetStatusInfo(PhBaPlanSetStatusInfo other) : this()
		{
			this.open_ = other.open_;
			this.suit_ = other.suit_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601226D RID: 74349 RVA: 0x002A6AA9 File Offset: 0x002A4CA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetStatusInfo Clone()
		{
			return new PhBaPlanSetStatusInfo(this);
		}

		// Token: 0x17003C24 RID: 15396
		// (get) Token: 0x0601226E RID: 74350 RVA: 0x002A6AB1 File Offset: 0x002A4CB1
		// (set) Token: 0x0601226F RID: 74351 RVA: 0x002A6AB9 File Offset: 0x002A4CB9
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

		// Token: 0x17003C25 RID: 15397
		// (get) Token: 0x06012270 RID: 74352 RVA: 0x002A6AC2 File Offset: 0x002A4CC2
		// (set) Token: 0x06012271 RID: 74353 RVA: 0x002A6ACA File Offset: 0x002A4CCA
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

		// Token: 0x06012272 RID: 74354 RVA: 0x002A6AD3 File Offset: 0x002A4CD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanSetStatusInfo);
		}

		// Token: 0x06012273 RID: 74355 RVA: 0x002A6AE1 File Offset: 0x002A4CE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanSetStatusInfo other)
		{
			return other != null && (other == this || (this.Open == other.Open && this.Suit == other.Suit && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012274 RID: 74356 RVA: 0x002A6B20 File Offset: 0x002A4D20
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

		// Token: 0x06012275 RID: 74357 RVA: 0x002A6B78 File Offset: 0x002A4D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012276 RID: 74358 RVA: 0x002A6B85 File Offset: 0x002A4D85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012277 RID: 74359 RVA: 0x002A6B90 File Offset: 0x002A4D90
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

		// Token: 0x06012278 RID: 74360 RVA: 0x002A6BE8 File Offset: 0x002A4DE8
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

		// Token: 0x06012279 RID: 74361 RVA: 0x002A6C34 File Offset: 0x002A4E34
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

		// Token: 0x0601227A RID: 74362 RVA: 0x002A6C84 File Offset: 0x002A4E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601227B RID: 74363 RVA: 0x002A6C90 File Offset: 0x002A4E90
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

		// Token: 0x04007167 RID: 29031
		private static readonly MessageParser<PhBaPlanSetStatusInfo> _parser = new MessageParser<PhBaPlanSetStatusInfo>(() => new PhBaPlanSetStatusInfo());

		// Token: 0x04007168 RID: 29032
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007169 RID: 29033
		public const int OpenFieldNumber = 1;

		// Token: 0x0400716A RID: 29034
		private bool open_;

		// Token: 0x0400716B RID: 29035
		public const int SuitFieldNumber = 2;

		// Token: 0x0400716C RID: 29036
		private int suit_;
	}
}
