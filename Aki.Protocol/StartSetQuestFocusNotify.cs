using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012FF RID: 4863
	[NetMessage(EMessageId.StartSetQuestFocusNotify)]
	public sealed class StartSetQuestFocusNotify : IMessage<StartSetQuestFocusNotify>, IMessage, IEquatable<StartSetQuestFocusNotify>, IDeepCloneable<StartSetQuestFocusNotify>, IBufferMessage
	{
		// Token: 0x06019F0C RID: 106252 RVA: 0x003C85D3 File Offset: 0x003C67D3
		[NullableContext(1)]
		public static StartSetQuestFocusNotify Create()
		{
			return new StartSetQuestFocusNotify();
		}

		// Token: 0x170057DA RID: 22490
		// (get) Token: 0x06019F0D RID: 106253 RVA: 0x003C85DA File Offset: 0x003C67DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057DB RID: 22491
		// (get) Token: 0x06019F0E RID: 106254 RVA: 0x003C85DD File Offset: 0x003C67DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartSetQuestFocusNotify.Descriptor;
			}
		}

		// Token: 0x06019F0F RID: 106255 RVA: 0x003C85E4 File Offset: 0x003C67E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartSetQuestFocusNotify()
		{
		}

		// Token: 0x06019F10 RID: 106256 RVA: 0x003C85EC File Offset: 0x003C67EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartSetQuestFocusNotify(StartSetQuestFocusNotify other) : this()
		{
			this.focusQuestId_ = other.focusQuestId_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019F11 RID: 106257 RVA: 0x003C861D File Offset: 0x003C681D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartSetQuestFocusNotify Clone()
		{
			return new StartSetQuestFocusNotify(this);
		}

		// Token: 0x170057DC RID: 22492
		// (get) Token: 0x06019F12 RID: 106258 RVA: 0x003C8625 File Offset: 0x003C6825
		// (set) Token: 0x06019F13 RID: 106259 RVA: 0x003C862D File Offset: 0x003C682D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FocusQuestId
		{
			get
			{
				return this.focusQuestId_;
			}
			set
			{
				this.focusQuestId_ = value;
			}
		}

		// Token: 0x170057DD RID: 22493
		// (get) Token: 0x06019F14 RID: 106260 RVA: 0x003C8636 File Offset: 0x003C6836
		// (set) Token: 0x06019F15 RID: 106261 RVA: 0x003C863E File Offset: 0x003C683E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFocusReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x06019F16 RID: 106262 RVA: 0x003C8647 File Offset: 0x003C6847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartSetQuestFocusNotify);
		}

		// Token: 0x06019F17 RID: 106263 RVA: 0x003C8655 File Offset: 0x003C6855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartSetQuestFocusNotify other)
		{
			return other != null && (other == this || (this.FocusQuestId == other.FocusQuestId && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019F18 RID: 106264 RVA: 0x003C8694 File Offset: 0x003C6894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FocusQuestId != 0)
			{
				num ^= this.FocusQuestId.GetHashCode();
			}
			if (this.Reason != QuestFocusReason.Request)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019F19 RID: 106265 RVA: 0x003C86F2 File Offset: 0x003C68F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019F1A RID: 106266 RVA: 0x003C86FF File Offset: 0x003C68FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019F1B RID: 106267 RVA: 0x003C8708 File Offset: 0x003C6908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != QuestFocusReason.Request)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Reason);
			}
			if (this.FocusQuestId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.FocusQuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019F1C RID: 106268 RVA: 0x003C8764 File Offset: 0x003C6964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FocusQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FocusQuestId);
			}
			if (this.Reason != QuestFocusReason.Request)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019F1D RID: 106269 RVA: 0x003C87BC File Offset: 0x003C69BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartSetQuestFocusNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FocusQuestId != 0)
			{
				this.FocusQuestId = other.FocusQuestId;
			}
			if (other.Reason != QuestFocusReason.Request)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019F1E RID: 106270 RVA: 0x003C880C File Offset: 0x003C6A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019F1F RID: 106271 RVA: 0x003C8818 File Offset: 0x003C6A18
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
				if (num != 48U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FocusQuestId = input.ReadInt32();
					}
				}
				else
				{
					this.Reason = (QuestFocusReason)input.ReadEnum();
				}
			}
		}

		// Token: 0x040098E9 RID: 39145
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098EA RID: 39146
		public const int FocusQuestIdFieldNumber = 7;

		// Token: 0x040098EB RID: 39147
		private int focusQuestId_;

		// Token: 0x040098EC RID: 39148
		public const int ReasonFieldNumber = 6;

		// Token: 0x040098ED RID: 39149
		private QuestFocusReason reason_;
	}
}
