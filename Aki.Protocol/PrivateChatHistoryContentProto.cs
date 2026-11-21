using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DCE RID: 3534
	public sealed class PrivateChatHistoryContentProto : IMessage<PrivateChatHistoryContentProto>, IMessage, IEquatable<PrivateChatHistoryContentProto>, IDeepCloneable<PrivateChatHistoryContentProto>, IBufferMessage
	{
		// Token: 0x060130BA RID: 78010 RVA: 0x002C6EB9 File Offset: 0x002C50B9
		[NullableContext(1)]
		public static PrivateChatHistoryContentProto Create()
		{
			return new PrivateChatHistoryContentProto();
		}

		// Token: 0x17003F33 RID: 16179
		// (get) Token: 0x060130BB RID: 78011 RVA: 0x002C6EC0 File Offset: 0x002C50C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PrivateChatHistoryContentProto> Parser
		{
			get
			{
				return PrivateChatHistoryContentProto._parser;
			}
		}

		// Token: 0x17003F34 RID: 16180
		// (get) Token: 0x060130BC RID: 78012 RVA: 0x002C6EC7 File Offset: 0x002C50C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F35 RID: 16181
		// (get) Token: 0x060130BD RID: 78013 RVA: 0x002C6ECA File Offset: 0x002C50CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateChatHistoryContentProto.Descriptor;
			}
		}

		// Token: 0x060130BE RID: 78014 RVA: 0x002C6ED1 File Offset: 0x002C50D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryContentProto()
		{
		}

		// Token: 0x060130BF RID: 78015 RVA: 0x002C6EE4 File Offset: 0x002C50E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryContentProto(PrivateChatHistoryContentProto other) : this()
		{
			this.targetUID_ = other.targetUID_;
			this.chats_ = other.chats_.Clone();
			this.historyIsEnd_ = other.historyIsEnd_;
			this.totalNums_ = other.totalNums_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060130C0 RID: 78016 RVA: 0x002C6F3D File Offset: 0x002C513D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryContentProto Clone()
		{
			return new PrivateChatHistoryContentProto(this);
		}

		// Token: 0x17003F36 RID: 16182
		// (get) Token: 0x060130C1 RID: 78017 RVA: 0x002C6F45 File Offset: 0x002C5145
		// (set) Token: 0x060130C2 RID: 78018 RVA: 0x002C6F4D File Offset: 0x002C514D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetUID
		{
			get
			{
				return this.targetUID_;
			}
			set
			{
				this.targetUID_ = value;
			}
		}

		// Token: 0x17003F37 RID: 16183
		// (get) Token: 0x060130C3 RID: 78019 RVA: 0x002C6F56 File Offset: 0x002C5156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChatContentProto> Chats
		{
			get
			{
				return this.chats_;
			}
		}

		// Token: 0x17003F38 RID: 16184
		// (get) Token: 0x060130C4 RID: 78020 RVA: 0x002C6F5E File Offset: 0x002C515E
		// (set) Token: 0x060130C5 RID: 78021 RVA: 0x002C6F66 File Offset: 0x002C5166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HistoryIsEnd
		{
			get
			{
				return this.historyIsEnd_;
			}
			set
			{
				this.historyIsEnd_ = value;
			}
		}

		// Token: 0x17003F39 RID: 16185
		// (get) Token: 0x060130C6 RID: 78022 RVA: 0x002C6F6F File Offset: 0x002C516F
		// (set) Token: 0x060130C7 RID: 78023 RVA: 0x002C6F77 File Offset: 0x002C5177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalNums
		{
			get
			{
				return this.totalNums_;
			}
			set
			{
				this.totalNums_ = value;
			}
		}

		// Token: 0x060130C8 RID: 78024 RVA: 0x002C6F80 File Offset: 0x002C5180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateChatHistoryContentProto);
		}

		// Token: 0x060130C9 RID: 78025 RVA: 0x002C6F90 File Offset: 0x002C5190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateChatHistoryContentProto other)
		{
			return other != null && (other == this || (this.TargetUID == other.TargetUID && this.chats_.Equals(other.chats_) && this.HistoryIsEnd == other.HistoryIsEnd && this.TotalNums == other.TotalNums && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060130CA RID: 78026 RVA: 0x002C7000 File Offset: 0x002C5200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetUID != 0)
			{
				num ^= this.TargetUID.GetHashCode();
			}
			num ^= this.chats_.GetHashCode();
			if (this.HistoryIsEnd)
			{
				num ^= this.HistoryIsEnd.GetHashCode();
			}
			if (this.TotalNums != 0)
			{
				num ^= this.TotalNums.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060130CB RID: 78027 RVA: 0x002C707F File Offset: 0x002C527F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060130CC RID: 78028 RVA: 0x002C708C File Offset: 0x002C528C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060130CD RID: 78029 RVA: 0x002C7098 File Offset: 0x002C5298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetUID != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TargetUID);
			}
			this.chats_.WriteTo(ref output, PrivateChatHistoryContentProto._repeated_chats_codec);
			if (this.HistoryIsEnd)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.HistoryIsEnd);
			}
			if (this.TotalNums != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TotalNums);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060130CE RID: 78030 RVA: 0x002C7120 File Offset: 0x002C5320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetUID != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetUID);
			}
			num += this.chats_.CalculateSize(PrivateChatHistoryContentProto._repeated_chats_codec);
			if (this.HistoryIsEnd)
			{
				num += 2;
			}
			if (this.TotalNums != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalNums);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060130CF RID: 78031 RVA: 0x002C7198 File Offset: 0x002C5398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrivateChatHistoryContentProto other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetUID != 0)
			{
				this.TargetUID = other.TargetUID;
			}
			this.chats_.Add(other.chats_);
			if (other.HistoryIsEnd)
			{
				this.HistoryIsEnd = other.HistoryIsEnd;
			}
			if (other.TotalNums != 0)
			{
				this.TotalNums = other.TotalNums;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060130D0 RID: 78032 RVA: 0x002C720D File Offset: 0x002C540D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060130D1 RID: 78033 RVA: 0x002C7218 File Offset: 0x002C5418
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.TargetUID = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.chats_.AddEntriesFrom(ref input, PrivateChatHistoryContentProto._repeated_chats_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.HistoryIsEnd = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.TotalNums = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040075EA RID: 30186
		private static readonly MessageParser<PrivateChatHistoryContentProto> _parser = new MessageParser<PrivateChatHistoryContentProto>(() => new PrivateChatHistoryContentProto());

		// Token: 0x040075EB RID: 30187
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075EC RID: 30188
		public const int TargetUIDFieldNumber = 1;

		// Token: 0x040075ED RID: 30189
		private int targetUID_;

		// Token: 0x040075EE RID: 30190
		public const int ChatsFieldNumber = 2;

		// Token: 0x040075EF RID: 30191
		private static readonly FieldCodec<ChatContentProto> _repeated_chats_codec = FieldCodec.ForMessage<ChatContentProto>(18U, ChatContentProto.Parser);

		// Token: 0x040075F0 RID: 30192
		private readonly RepeatedField<ChatContentProto> chats_ = new RepeatedField<ChatContentProto>();

		// Token: 0x040075F1 RID: 30193
		public const int HistoryIsEndFieldNumber = 3;

		// Token: 0x040075F2 RID: 30194
		private bool historyIsEnd_;

		// Token: 0x040075F3 RID: 30195
		public const int TotalNumsFieldNumber = 4;

		// Token: 0x040075F4 RID: 30196
		private int totalNums_;
	}
}
