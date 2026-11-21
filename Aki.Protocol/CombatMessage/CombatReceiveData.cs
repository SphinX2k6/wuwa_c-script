using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x02001705 RID: 5893
	public sealed class CombatReceiveData : IMessage<CombatReceiveData>, IMessage, IEquatable<CombatReceiveData>, IDeepCloneable<CombatReceiveData>, IBufferMessage
	{
		// Token: 0x0601D82C RID: 120876 RVA: 0x0044CA1B File Offset: 0x0044AC1B
		[NullableContext(1)]
		public static CombatReceiveData Create()
		{
			return new CombatReceiveData();
		}

		// Token: 0x17006420 RID: 25632
		// (get) Token: 0x0601D82D RID: 120877 RVA: 0x0044CA22 File Offset: 0x0044AC22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CombatReceiveData> Parser
		{
			get
			{
				return CombatReceiveData._parser;
			}
		}

		// Token: 0x17006421 RID: 25633
		// (get) Token: 0x0601D82E RID: 120878 RVA: 0x0044CA29 File Offset: 0x0044AC29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006422 RID: 25634
		// (get) Token: 0x0601D82F RID: 120879 RVA: 0x0044CA2C File Offset: 0x0044AC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatReceiveData.Descriptor;
			}
		}

		// Token: 0x0601D830 RID: 120880 RVA: 0x0044CA33 File Offset: 0x0044AC33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatReceiveData()
		{
		}

		// Token: 0x0601D831 RID: 120881 RVA: 0x0044CA3C File Offset: 0x0044AC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatReceiveData(CombatReceiveData other) : this()
		{
			CombatReceiveData.MessageOneofCase messageCase = other.MessageCase;
			if (messageCase != CombatReceiveData.MessageOneofCase.CombatNotifyData)
			{
				if (messageCase == CombatReceiveData.MessageOneofCase.CombatResponseData)
				{
					this.CombatResponseData = other.CombatResponseData.Clone();
				}
			}
			else
			{
				this.CombatNotifyData = other.CombatNotifyData.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D832 RID: 120882 RVA: 0x0044CA95 File Offset: 0x0044AC95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatReceiveData Clone()
		{
			return new CombatReceiveData(this);
		}

		// Token: 0x17006423 RID: 25635
		// (get) Token: 0x0601D833 RID: 120883 RVA: 0x0044CA9D File Offset: 0x0044AC9D
		// (set) Token: 0x0601D834 RID: 120884 RVA: 0x0044CAB5 File Offset: 0x0044ACB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatNotifyData CombatNotifyData
		{
			get
			{
				if (this.messageCase_ != CombatReceiveData.MessageOneofCase.CombatNotifyData)
				{
					return null;
				}
				return (CombatNotifyData)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatReceiveData.MessageOneofCase.None : CombatReceiveData.MessageOneofCase.CombatNotifyData);
			}
		}

		// Token: 0x17006424 RID: 25636
		// (get) Token: 0x0601D835 RID: 120885 RVA: 0x0044CACB File Offset: 0x0044ACCB
		// (set) Token: 0x0601D836 RID: 120886 RVA: 0x0044CAE3 File Offset: 0x0044ACE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatResponseData CombatResponseData
		{
			get
			{
				if (this.messageCase_ != CombatReceiveData.MessageOneofCase.CombatResponseData)
				{
					return null;
				}
				return (CombatResponseData)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatReceiveData.MessageOneofCase.None : CombatReceiveData.MessageOneofCase.CombatResponseData);
			}
		}

		// Token: 0x17006425 RID: 25637
		// (get) Token: 0x0601D837 RID: 120887 RVA: 0x0044CAF9 File Offset: 0x0044ACF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatReceiveData.MessageOneofCase MessageCase
		{
			get
			{
				return this.messageCase_;
			}
		}

		// Token: 0x0601D838 RID: 120888 RVA: 0x0044CB01 File Offset: 0x0044AD01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMessage()
		{
			this.messageCase_ = CombatReceiveData.MessageOneofCase.None;
			this.message_ = null;
		}

		// Token: 0x0601D839 RID: 120889 RVA: 0x0044CB11 File Offset: 0x0044AD11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatReceiveData);
		}

		// Token: 0x0601D83A RID: 120890 RVA: 0x0044CB20 File Offset: 0x0044AD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatReceiveData other)
		{
			return other != null && (other == this || (object.Equals(this.CombatNotifyData, other.CombatNotifyData) && object.Equals(this.CombatResponseData, other.CombatResponseData) && this.MessageCase == other.MessageCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D83B RID: 120891 RVA: 0x0044CB84 File Offset: 0x0044AD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.messageCase_ == CombatReceiveData.MessageOneofCase.CombatNotifyData)
			{
				num ^= this.CombatNotifyData.GetHashCode();
			}
			if (this.messageCase_ == CombatReceiveData.MessageOneofCase.CombatResponseData)
			{
				num ^= this.CombatResponseData.GetHashCode();
			}
			num ^= (int)this.messageCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D83C RID: 120892 RVA: 0x0044CBE1 File Offset: 0x0044ADE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D83D RID: 120893 RVA: 0x0044CBEE File Offset: 0x0044ADEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D83E RID: 120894 RVA: 0x0044CBF8 File Offset: 0x0044ADF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.messageCase_ == CombatReceiveData.MessageOneofCase.CombatNotifyData)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.CombatNotifyData);
			}
			if (this.messageCase_ == CombatReceiveData.MessageOneofCase.CombatResponseData)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.CombatResponseData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D83F RID: 120895 RVA: 0x0044CC54 File Offset: 0x0044AE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.messageCase_ == CombatReceiveData.MessageOneofCase.CombatNotifyData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatNotifyData);
			}
			if (this.messageCase_ == CombatReceiveData.MessageOneofCase.CombatResponseData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatResponseData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D840 RID: 120896 RVA: 0x0044CCAC File Offset: 0x0044AEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatReceiveData other)
		{
			if (other == null)
			{
				return;
			}
			CombatReceiveData.MessageOneofCase messageCase = other.MessageCase;
			if (messageCase != CombatReceiveData.MessageOneofCase.CombatNotifyData)
			{
				if (messageCase == CombatReceiveData.MessageOneofCase.CombatResponseData)
				{
					if (this.CombatResponseData == null)
					{
						this.CombatResponseData = new CombatResponseData();
					}
					this.CombatResponseData.MergeFrom(other.CombatResponseData);
				}
			}
			else
			{
				if (this.CombatNotifyData == null)
				{
					this.CombatNotifyData = new CombatNotifyData();
				}
				this.CombatNotifyData.MergeFrom(other.CombatNotifyData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D841 RID: 120897 RVA: 0x0044CD2F File Offset: 0x0044AF2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D842 RID: 120898 RVA: 0x0044CD38 File Offset: 0x0044AF38
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
				if (num != 18U)
				{
					if (num != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						CombatResponseData combatResponseData = new CombatResponseData();
						if (this.messageCase_ == CombatReceiveData.MessageOneofCase.CombatResponseData)
						{
							combatResponseData.MergeFrom(this.CombatResponseData);
						}
						input.ReadMessage(combatResponseData);
						this.CombatResponseData = combatResponseData;
					}
				}
				else
				{
					CombatNotifyData combatNotifyData = new CombatNotifyData();
					if (this.messageCase_ == CombatReceiveData.MessageOneofCase.CombatNotifyData)
					{
						combatNotifyData.MergeFrom(this.CombatNotifyData);
					}
					input.ReadMessage(combatNotifyData);
					this.CombatNotifyData = combatNotifyData;
				}
			}
		}

		// Token: 0x0400C7DD RID: 51165
		private static readonly MessageParser<CombatReceiveData> _parser = new MessageParser<CombatReceiveData>(() => new CombatReceiveData());

		// Token: 0x0400C7DE RID: 51166
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C7DF RID: 51167
		public const int CombatNotifyDataFieldNumber = 2;

		// Token: 0x0400C7E0 RID: 51168
		public const int CombatResponseDataFieldNumber = 3;

		// Token: 0x0400C7E1 RID: 51169
		private object message_;

		// Token: 0x0400C7E2 RID: 51170
		private CombatReceiveData.MessageOneofCase messageCase_;

		// Token: 0x02001AA1 RID: 6817
		public enum MessageOneofCase
		{
			// Token: 0x0400D0F0 RID: 53488
			None,
			// Token: 0x0400D0F1 RID: 53489
			CombatNotifyData = 2,
			// Token: 0x0400D0F2 RID: 53490
			CombatResponseData
		}
	}
}
