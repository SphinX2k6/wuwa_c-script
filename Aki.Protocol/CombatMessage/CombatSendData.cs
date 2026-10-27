using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x0200168D RID: 5773
	public sealed class CombatSendData : IMessage<CombatSendData>, IMessage, IEquatable<CombatSendData>, IDeepCloneable<CombatSendData>, IBufferMessage
	{
		// Token: 0x0601CEC3 RID: 118467 RVA: 0x0043B40F File Offset: 0x0043960F
		[NullableContext(1)]
		public static CombatSendData Create()
		{
			return new CombatSendData();
		}

		// Token: 0x17006216 RID: 25110
		// (get) Token: 0x0601CEC4 RID: 118468 RVA: 0x0043B416 File Offset: 0x00439616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CombatSendData> Parser
		{
			get
			{
				return CombatSendData._parser;
			}
		}

		// Token: 0x17006217 RID: 25111
		// (get) Token: 0x0601CEC5 RID: 118469 RVA: 0x0043B41D File Offset: 0x0043961D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006218 RID: 25112
		// (get) Token: 0x0601CEC6 RID: 118470 RVA: 0x0043B420 File Offset: 0x00439620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatSendData.Descriptor;
			}
		}

		// Token: 0x0601CEC7 RID: 118471 RVA: 0x0043B427 File Offset: 0x00439627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatSendData()
		{
		}

		// Token: 0x0601CEC8 RID: 118472 RVA: 0x0043B430 File Offset: 0x00439630
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

		// Token: 0x0601CEC9 RID: 118473 RVA: 0x0043B489 File Offset: 0x00439689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatSendData Clone()
		{
			return new CombatSendData(this);
		}

		// Token: 0x17006219 RID: 25113
		// (get) Token: 0x0601CECA RID: 118474 RVA: 0x0043B491 File Offset: 0x00439691
		// (set) Token: 0x0601CECB RID: 118475 RVA: 0x0043B4A9 File Offset: 0x004396A9
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

		// Token: 0x1700621A RID: 25114
		// (get) Token: 0x0601CECC RID: 118476 RVA: 0x0043B4BF File Offset: 0x004396BF
		// (set) Token: 0x0601CECD RID: 118477 RVA: 0x0043B4D7 File Offset: 0x004396D7
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

		// Token: 0x1700621B RID: 25115
		// (get) Token: 0x0601CECE RID: 118478 RVA: 0x0043B4ED File Offset: 0x004396ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatSendData.MessageOneofCase MessageCase
		{
			get
			{
				return this.messageCase_;
			}
		}

		// Token: 0x0601CECF RID: 118479 RVA: 0x0043B4F5 File Offset: 0x004396F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMessage()
		{
			this.messageCase_ = CombatSendData.MessageOneofCase.None;
			this.message_ = null;
		}

		// Token: 0x0601CED0 RID: 118480 RVA: 0x0043B505 File Offset: 0x00439705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatSendData);
		}

		// Token: 0x0601CED1 RID: 118481 RVA: 0x0043B514 File Offset: 0x00439714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatSendData other)
		{
			return other != null && (other == this || (object.Equals(this.Push, other.Push) && object.Equals(this.Request, other.Request) && this.MessageCase == other.MessageCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CED2 RID: 118482 RVA: 0x0043B578 File Offset: 0x00439778
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

		// Token: 0x0601CED3 RID: 118483 RVA: 0x0043B5D5 File Offset: 0x004397D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CED4 RID: 118484 RVA: 0x0043B5E2 File Offset: 0x004397E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CED5 RID: 118485 RVA: 0x0043B5EC File Offset: 0x004397EC
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

		// Token: 0x0601CED6 RID: 118486 RVA: 0x0043B648 File Offset: 0x00439848
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

		// Token: 0x0601CED7 RID: 118487 RVA: 0x0043B6A0 File Offset: 0x004398A0
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

		// Token: 0x0601CED8 RID: 118488 RVA: 0x0043B723 File Offset: 0x00439923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CED9 RID: 118489 RVA: 0x0043B72C File Offset: 0x0043992C
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

		// Token: 0x0400C350 RID: 50000
		private static readonly MessageParser<CombatSendData> _parser = new MessageParser<CombatSendData>(() => new CombatSendData());

		// Token: 0x0400C351 RID: 50001
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C352 RID: 50002
		public const int PushFieldNumber = 2;

		// Token: 0x0400C353 RID: 50003
		public const int RequestFieldNumber = 3;

		// Token: 0x0400C354 RID: 50004
		private object message_;

		// Token: 0x0400C355 RID: 50005
		private CombatSendData.MessageOneofCase messageCase_;

		// Token: 0x02001A03 RID: 6659
		public enum MessageOneofCase
		{
			// Token: 0x0400CC15 RID: 52245
			None,
			// Token: 0x0400CC16 RID: 52246
			Push = 2,
			// Token: 0x0400CC17 RID: 52247
			Request
		}
	}
}
