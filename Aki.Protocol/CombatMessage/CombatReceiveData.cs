using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x02001689 RID: 5769
	public sealed class CombatReceiveData : IMessage<CombatReceiveData>, IMessage, IEquatable<CombatReceiveData>, IDeepCloneable<CombatReceiveData>, IBufferMessage
	{
		// Token: 0x0601CD61 RID: 118113 RVA: 0x00430E6D File Offset: 0x0042F06D
		[NullableContext(1)]
		public static CombatReceiveData Create()
		{
			return new CombatReceiveData();
		}

		// Token: 0x1700617D RID: 24957
		// (get) Token: 0x0601CD62 RID: 118114 RVA: 0x00430E74 File Offset: 0x0042F074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CombatReceiveData> Parser
		{
			get
			{
				return CombatReceiveData._parser;
			}
		}

		// Token: 0x1700617E RID: 24958
		// (get) Token: 0x0601CD63 RID: 118115 RVA: 0x00430E7B File Offset: 0x0042F07B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700617F RID: 24959
		// (get) Token: 0x0601CD64 RID: 118116 RVA: 0x00430E7E File Offset: 0x0042F07E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatReceiveData.Descriptor;
			}
		}

		// Token: 0x0601CD65 RID: 118117 RVA: 0x00430E85 File Offset: 0x0042F085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatReceiveData()
		{
		}

		// Token: 0x0601CD66 RID: 118118 RVA: 0x00430E90 File Offset: 0x0042F090
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

		// Token: 0x0601CD67 RID: 118119 RVA: 0x00430EE9 File Offset: 0x0042F0E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatReceiveData Clone()
		{
			return new CombatReceiveData(this);
		}

		// Token: 0x17006180 RID: 24960
		// (get) Token: 0x0601CD68 RID: 118120 RVA: 0x00430EF1 File Offset: 0x0042F0F1
		// (set) Token: 0x0601CD69 RID: 118121 RVA: 0x00430F09 File Offset: 0x0042F109
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

		// Token: 0x17006181 RID: 24961
		// (get) Token: 0x0601CD6A RID: 118122 RVA: 0x00430F1F File Offset: 0x0042F11F
		// (set) Token: 0x0601CD6B RID: 118123 RVA: 0x00430F37 File Offset: 0x0042F137
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

		// Token: 0x17006182 RID: 24962
		// (get) Token: 0x0601CD6C RID: 118124 RVA: 0x00430F4D File Offset: 0x0042F14D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatReceiveData.MessageOneofCase MessageCase
		{
			get
			{
				return this.messageCase_;
			}
		}

		// Token: 0x0601CD6D RID: 118125 RVA: 0x00430F55 File Offset: 0x0042F155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMessage()
		{
			this.messageCase_ = CombatReceiveData.MessageOneofCase.None;
			this.message_ = null;
		}

		// Token: 0x0601CD6E RID: 118126 RVA: 0x00430F65 File Offset: 0x0042F165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatReceiveData);
		}

		// Token: 0x0601CD6F RID: 118127 RVA: 0x00430F74 File Offset: 0x0042F174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatReceiveData other)
		{
			return other != null && (other == this || (object.Equals(this.CombatNotifyData, other.CombatNotifyData) && object.Equals(this.CombatResponseData, other.CombatResponseData) && this.MessageCase == other.MessageCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CD70 RID: 118128 RVA: 0x00430FD8 File Offset: 0x0042F1D8
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

		// Token: 0x0601CD71 RID: 118129 RVA: 0x00431035 File Offset: 0x0042F235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CD72 RID: 118130 RVA: 0x00431042 File Offset: 0x0042F242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CD73 RID: 118131 RVA: 0x0043104C File Offset: 0x0042F24C
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

		// Token: 0x0601CD74 RID: 118132 RVA: 0x004310A8 File Offset: 0x0042F2A8
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

		// Token: 0x0601CD75 RID: 118133 RVA: 0x00431100 File Offset: 0x0042F300
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

		// Token: 0x0601CD76 RID: 118134 RVA: 0x00431183 File Offset: 0x0042F383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CD77 RID: 118135 RVA: 0x0043118C File Offset: 0x0042F38C
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

		// Token: 0x0400C2B2 RID: 49842
		private static readonly MessageParser<CombatReceiveData> _parser = new MessageParser<CombatReceiveData>(() => new CombatReceiveData());

		// Token: 0x0400C2B3 RID: 49843
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C2B4 RID: 49844
		public const int CombatNotifyDataFieldNumber = 2;

		// Token: 0x0400C2B5 RID: 49845
		public const int CombatResponseDataFieldNumber = 3;

		// Token: 0x0400C2B6 RID: 49846
		private object message_;

		// Token: 0x0400C2B7 RID: 49847
		private CombatReceiveData.MessageOneofCase messageCase_;

		// Token: 0x020019FF RID: 6655
		public enum MessageOneofCase
		{
			// Token: 0x0400CB86 RID: 52102
			None,
			// Token: 0x0400CB87 RID: 52103
			CombatNotifyData = 2,
			// Token: 0x0400CB88 RID: 52104
			CombatResponseData
		}
	}
}
