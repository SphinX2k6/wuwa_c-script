using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x02001709 RID: 5897
	public sealed class CombatSendData : IMessage<CombatSendData>, IMessage, IEquatable<CombatSendData>, IDeepCloneable<CombatSendData>, IBufferMessage
	{
		// Token: 0x0601D98E RID: 121230 RVA: 0x00456FBB File Offset: 0x004551BB
		[NullableContext(1)]
		public static CombatSendData Create()
		{
			return new CombatSendData();
		}

		// Token: 0x170064B9 RID: 25785
		// (get) Token: 0x0601D98F RID: 121231 RVA: 0x00456FC2 File Offset: 0x004551C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CombatSendData> Parser
		{
			get
			{
				return CombatSendData._parser;
			}
		}

		// Token: 0x170064BA RID: 25786
		// (get) Token: 0x0601D990 RID: 121232 RVA: 0x00456FC9 File Offset: 0x004551C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170064BB RID: 25787
		// (get) Token: 0x0601D991 RID: 121233 RVA: 0x00456FCC File Offset: 0x004551CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatSendData.Descriptor;
			}
		}

		// Token: 0x0601D992 RID: 121234 RVA: 0x00456FD3 File Offset: 0x004551D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatSendData()
		{
		}

		// Token: 0x0601D993 RID: 121235 RVA: 0x00456FDC File Offset: 0x004551DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatSendData(CombatSendData other) : this()
		{
			CombatSendData.MessageOneofCase messageCase = other.MessageCase;
			if (messageCase != CombatSendData.MessageOneofCase.Push)
			{
				if (messageCase == CombatSendData.MessageOneofCase.Request)
				{
					this.Request = other.Request.Clone();
				}
			}
			else
			{
				this.Push = other.Push.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D994 RID: 121236 RVA: 0x00457035 File Offset: 0x00455235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatSendData Clone()
		{
			return new CombatSendData(this);
		}

		// Token: 0x170064BC RID: 25788
		// (get) Token: 0x0601D995 RID: 121237 RVA: 0x0045703D File Offset: 0x0045523D
		// (set) Token: 0x0601D996 RID: 121238 RVA: 0x00457055 File Offset: 0x00455255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatPushData Push
		{
			get
			{
				if (this.messageCase_ != CombatSendData.MessageOneofCase.Push)
				{
					return null;
				}
				return (CombatPushData)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatSendData.MessageOneofCase.None : CombatSendData.MessageOneofCase.Push);
			}
		}

		// Token: 0x170064BD RID: 25789
		// (get) Token: 0x0601D997 RID: 121239 RVA: 0x0045706B File Offset: 0x0045526B
		// (set) Token: 0x0601D998 RID: 121240 RVA: 0x00457083 File Offset: 0x00455283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatRequestData Request
		{
			get
			{
				if (this.messageCase_ != CombatSendData.MessageOneofCase.Request)
				{
					return null;
				}
				return (CombatRequestData)this.message_;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? CombatSendData.MessageOneofCase.None : CombatSendData.MessageOneofCase.Request);
			}
		}

		// Token: 0x170064BE RID: 25790
		// (get) Token: 0x0601D999 RID: 121241 RVA: 0x00457099 File Offset: 0x00455299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatSendData.MessageOneofCase MessageCase
		{
			get
			{
				return this.messageCase_;
			}
		}

		// Token: 0x0601D99A RID: 121242 RVA: 0x004570A1 File Offset: 0x004552A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMessage()
		{
			this.messageCase_ = CombatSendData.MessageOneofCase.None;
			this.message_ = null;
		}

		// Token: 0x0601D99B RID: 121243 RVA: 0x004570B1 File Offset: 0x004552B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatSendData);
		}

		// Token: 0x0601D99C RID: 121244 RVA: 0x004570C0 File Offset: 0x004552C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatSendData other)
		{
			return other != null && (other == this || (object.Equals(this.Push, other.Push) && object.Equals(this.Request, other.Request) && this.MessageCase == other.MessageCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D99D RID: 121245 RVA: 0x00457124 File Offset: 0x00455324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.messageCase_ == CombatSendData.MessageOneofCase.Push)
			{
				num ^= this.Push.GetHashCode();
			}
			if (this.messageCase_ == CombatSendData.MessageOneofCase.Request)
			{
				num ^= this.Request.GetHashCode();
			}
			num ^= (int)this.messageCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D99E RID: 121246 RVA: 0x00457181 File Offset: 0x00455381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D99F RID: 121247 RVA: 0x0045718E File Offset: 0x0045538E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D9A0 RID: 121248 RVA: 0x00457198 File Offset: 0x00455398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.messageCase_ == CombatSendData.MessageOneofCase.Push)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Push);
			}
			if (this.messageCase_ == CombatSendData.MessageOneofCase.Request)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Request);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D9A1 RID: 121249 RVA: 0x004571F4 File Offset: 0x004553F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.messageCase_ == CombatSendData.MessageOneofCase.Push)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Push);
			}
			if (this.messageCase_ == CombatSendData.MessageOneofCase.Request)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Request);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D9A2 RID: 121250 RVA: 0x0045724C File Offset: 0x0045544C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatSendData other)
		{
			if (other == null)
			{
				return;
			}
			CombatSendData.MessageOneofCase messageCase = other.MessageCase;
			if (messageCase != CombatSendData.MessageOneofCase.Push)
			{
				if (messageCase == CombatSendData.MessageOneofCase.Request)
				{
					if (this.Request == null)
					{
						this.Request = new CombatRequestData();
					}
					this.Request.MergeFrom(other.Request);
				}
			}
			else
			{
				if (this.Push == null)
				{
					this.Push = new CombatPushData();
				}
				this.Push.MergeFrom(other.Push);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D9A3 RID: 121251 RVA: 0x004572CF File Offset: 0x004554CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D9A4 RID: 121252 RVA: 0x004572D8 File Offset: 0x004554D8
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
						CombatRequestData combatRequestData = new CombatRequestData();
						if (this.messageCase_ == CombatSendData.MessageOneofCase.Request)
						{
							combatRequestData.MergeFrom(this.Request);
						}
						input.ReadMessage(combatRequestData);
						this.Request = combatRequestData;
					}
				}
				else
				{
					CombatPushData combatPushData = new CombatPushData();
					if (this.messageCase_ == CombatSendData.MessageOneofCase.Push)
					{
						combatPushData.MergeFrom(this.Push);
					}
					input.ReadMessage(combatPushData);
					this.Push = combatPushData;
				}
			}
		}

		// Token: 0x0400C87B RID: 51323
		private static readonly MessageParser<CombatSendData> _parser = new MessageParser<CombatSendData>(() => new CombatSendData());

		// Token: 0x0400C87C RID: 51324
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C87D RID: 51325
		public const int PushFieldNumber = 2;

		// Token: 0x0400C87E RID: 51326
		public const int RequestFieldNumber = 3;

		// Token: 0x0400C87F RID: 51327
		private object message_;

		// Token: 0x0400C880 RID: 51328
		private CombatSendData.MessageOneofCase messageCase_;

		// Token: 0x02001AA5 RID: 6821
		public enum MessageOneofCase
		{
			// Token: 0x0400D17F RID: 53631
			None,
			// Token: 0x0400D180 RID: 53632
			Push = 2,
			// Token: 0x0400D181 RID: 53633
			Request
		}
	}
}
