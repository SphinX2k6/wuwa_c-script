using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001234 RID: 4660
	public sealed class ShoppMoneyInfo : IMessage<ShoppMoneyInfo>, IMessage, IEquatable<ShoppMoneyInfo>, IDeepCloneable<ShoppMoneyInfo>, IBufferMessage
	{
		// Token: 0x06018E47 RID: 101959 RVA: 0x003A1389 File Offset: 0x0039F589
		[NullableContext(1)]
		public static ShoppMoneyInfo Create()
		{
			return new ShoppMoneyInfo();
		}

		// Token: 0x1700541E RID: 21534
		// (get) Token: 0x06018E48 RID: 101960 RVA: 0x003A1390 File Offset: 0x0039F590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShoppMoneyInfo> Parser
		{
			get
			{
				return ShoppMoneyInfo._parser;
			}
		}

		// Token: 0x1700541F RID: 21535
		// (get) Token: 0x06018E49 RID: 101961 RVA: 0x003A1397 File Offset: 0x0039F597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005420 RID: 21536
		// (get) Token: 0x06018E4A RID: 101962 RVA: 0x003A139A File Offset: 0x0039F59A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShoppMoneyInfo.Descriptor;
			}
		}

		// Token: 0x06018E4B RID: 101963 RVA: 0x003A13A1 File Offset: 0x0039F5A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShoppMoneyInfo()
		{
		}

		// Token: 0x06018E4C RID: 101964 RVA: 0x003A13A9 File Offset: 0x0039F5A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShoppMoneyInfo(ShoppMoneyInfo other) : this()
		{
			this.moneyId_ = other.moneyId_;
			this.moneyNum_ = other.moneyNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018E4D RID: 101965 RVA: 0x003A13DA File Offset: 0x0039F5DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShoppMoneyInfo Clone()
		{
			return new ShoppMoneyInfo(this);
		}

		// Token: 0x17005421 RID: 21537
		// (get) Token: 0x06018E4E RID: 101966 RVA: 0x003A13E2 File Offset: 0x0039F5E2
		// (set) Token: 0x06018E4F RID: 101967 RVA: 0x003A13EA File Offset: 0x0039F5EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MoneyId
		{
			get
			{
				return this.moneyId_;
			}
			set
			{
				this.moneyId_ = value;
			}
		}

		// Token: 0x17005422 RID: 21538
		// (get) Token: 0x06018E50 RID: 101968 RVA: 0x003A13F3 File Offset: 0x0039F5F3
		// (set) Token: 0x06018E51 RID: 101969 RVA: 0x003A13FB File Offset: 0x0039F5FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MoneyNum
		{
			get
			{
				return this.moneyNum_;
			}
			set
			{
				this.moneyNum_ = value;
			}
		}

		// Token: 0x06018E52 RID: 101970 RVA: 0x003A1404 File Offset: 0x0039F604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShoppMoneyInfo);
		}

		// Token: 0x06018E53 RID: 101971 RVA: 0x003A1412 File Offset: 0x0039F612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShoppMoneyInfo other)
		{
			return other != null && (other == this || (this.MoneyId == other.MoneyId && this.MoneyNum == other.MoneyNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018E54 RID: 101972 RVA: 0x003A1450 File Offset: 0x0039F650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MoneyId != 0)
			{
				num ^= this.MoneyId.GetHashCode();
			}
			if (this.MoneyNum != 0)
			{
				num ^= this.MoneyNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018E55 RID: 101973 RVA: 0x003A14A8 File Offset: 0x0039F6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018E56 RID: 101974 RVA: 0x003A14B5 File Offset: 0x0039F6B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018E57 RID: 101975 RVA: 0x003A14C0 File Offset: 0x0039F6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MoneyId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MoneyId);
			}
			if (this.MoneyNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MoneyNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018E58 RID: 101976 RVA: 0x003A1518 File Offset: 0x0039F718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MoneyId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MoneyId);
			}
			if (this.MoneyNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MoneyNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018E59 RID: 101977 RVA: 0x003A1570 File Offset: 0x0039F770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShoppMoneyInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MoneyId != 0)
			{
				this.MoneyId = other.MoneyId;
			}
			if (other.MoneyNum != 0)
			{
				this.MoneyNum = other.MoneyNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018E5A RID: 101978 RVA: 0x003A15C0 File Offset: 0x0039F7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018E5B RID: 101979 RVA: 0x003A15CC File Offset: 0x0039F7CC
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
						this.MoneyNum = input.ReadInt32();
					}
				}
				else
				{
					this.MoneyId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040093B6 RID: 37814
		private static readonly MessageParser<ShoppMoneyInfo> _parser = new MessageParser<ShoppMoneyInfo>(() => new ShoppMoneyInfo());

		// Token: 0x040093B7 RID: 37815
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093B8 RID: 37816
		public const int MoneyIdFieldNumber = 1;

		// Token: 0x040093B9 RID: 37817
		private int moneyId_;

		// Token: 0x040093BA RID: 37818
		public const int MoneyNumFieldNumber = 2;

		// Token: 0x040093BB RID: 37819
		private int moneyNum_;
	}
}
