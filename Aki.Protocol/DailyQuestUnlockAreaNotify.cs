using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000333 RID: 819
	[NetMessage(EMessageId.DailyQuestUnlockAreaNotify)]
	public sealed class DailyQuestUnlockAreaNotify : IMessage<DailyQuestUnlockAreaNotify>, IMessage, IEquatable<DailyQuestUnlockAreaNotify>, IDeepCloneable<DailyQuestUnlockAreaNotify>, IBufferMessage
	{
		// Token: 0x06005244 RID: 21060 RVA: 0x000C8390 File Offset: 0x000C6590
		[NullableContext(1)]
		public static DailyQuestUnlockAreaNotify Create()
		{
			return new DailyQuestUnlockAreaNotify();
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x06005245 RID: 21061 RVA: 0x000C8397 File Offset: 0x000C6597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x06005246 RID: 21062 RVA: 0x000C839A File Offset: 0x000C659A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyQuestUnlockAreaNotify.Descriptor;
			}
		}

		// Token: 0x06005247 RID: 21063 RVA: 0x000C83A1 File Offset: 0x000C65A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestUnlockAreaNotify()
		{
		}

		// Token: 0x06005248 RID: 21064 RVA: 0x000C83C0 File Offset: 0x000C65C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestUnlockAreaNotify(DailyQuestUnlockAreaNotify other) : this()
		{
			this.unlockAreaIds_ = other.unlockAreaIds_.Clone();
			this.unlockInfluenceIds_ = other.unlockInfluenceIds_.Clone();
			this.currChoosedArea_ = other.currChoosedArea_;
			this.currChoosedInfluence_ = other.currChoosedInfluence_;
			this.isInit_ = other.isInit_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005249 RID: 21065 RVA: 0x000C842A File Offset: 0x000C662A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestUnlockAreaNotify Clone()
		{
			return new DailyQuestUnlockAreaNotify(this);
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x0600524A RID: 21066 RVA: 0x000C8432 File Offset: 0x000C6632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockAreaIds
		{
			get
			{
				return this.unlockAreaIds_;
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x0600524B RID: 21067 RVA: 0x000C843A File Offset: 0x000C663A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockInfluenceIds
		{
			get
			{
				return this.unlockInfluenceIds_;
			}
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x0600524C RID: 21068 RVA: 0x000C8442 File Offset: 0x000C6642
		// (set) Token: 0x0600524D RID: 21069 RVA: 0x000C844A File Offset: 0x000C664A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurrChoosedArea
		{
			get
			{
				return this.currChoosedArea_;
			}
			set
			{
				this.currChoosedArea_ = value;
			}
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x0600524E RID: 21070 RVA: 0x000C8453 File Offset: 0x000C6653
		// (set) Token: 0x0600524F RID: 21071 RVA: 0x000C845B File Offset: 0x000C665B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurrChoosedInfluence
		{
			get
			{
				return this.currChoosedInfluence_;
			}
			set
			{
				this.currChoosedInfluence_ = value;
			}
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06005250 RID: 21072 RVA: 0x000C8464 File Offset: 0x000C6664
		// (set) Token: 0x06005251 RID: 21073 RVA: 0x000C846C File Offset: 0x000C666C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsInit
		{
			get
			{
				return this.isInit_;
			}
			set
			{
				this.isInit_ = value;
			}
		}

		// Token: 0x06005252 RID: 21074 RVA: 0x000C8475 File Offset: 0x000C6675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyQuestUnlockAreaNotify);
		}

		// Token: 0x06005253 RID: 21075 RVA: 0x000C8484 File Offset: 0x000C6684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyQuestUnlockAreaNotify other)
		{
			return other != null && (other == this || (this.unlockAreaIds_.Equals(other.unlockAreaIds_) && this.unlockInfluenceIds_.Equals(other.unlockInfluenceIds_) && this.CurrChoosedArea == other.CurrChoosedArea && this.CurrChoosedInfluence == other.CurrChoosedInfluence && this.IsInit == other.IsInit && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005254 RID: 21076 RVA: 0x000C8508 File Offset: 0x000C6708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockAreaIds_.GetHashCode();
			num ^= this.unlockInfluenceIds_.GetHashCode();
			if (this.CurrChoosedArea != 0)
			{
				num ^= this.CurrChoosedArea.GetHashCode();
			}
			if (this.CurrChoosedInfluence != 0)
			{
				num ^= this.CurrChoosedInfluence.GetHashCode();
			}
			if (this.IsInit)
			{
				num ^= this.IsInit.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005255 RID: 21077 RVA: 0x000C8595 File Offset: 0x000C6795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005256 RID: 21078 RVA: 0x000C85A2 File Offset: 0x000C67A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005257 RID: 21079 RVA: 0x000C85AC File Offset: 0x000C67AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurrChoosedArea != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CurrChoosedArea);
			}
			this.unlockAreaIds_.WriteTo(ref output, DailyQuestUnlockAreaNotify._repeated_unlockAreaIds_codec);
			if (this.IsInit)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsInit);
			}
			this.unlockInfluenceIds_.WriteTo(ref output, DailyQuestUnlockAreaNotify._repeated_unlockInfluenceIds_codec);
			if (this.CurrChoosedInfluence != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.CurrChoosedInfluence);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005258 RID: 21080 RVA: 0x000C8644 File Offset: 0x000C6844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockAreaIds_.CalculateSize(DailyQuestUnlockAreaNotify._repeated_unlockAreaIds_codec);
			num += this.unlockInfluenceIds_.CalculateSize(DailyQuestUnlockAreaNotify._repeated_unlockInfluenceIds_codec);
			if (this.CurrChoosedArea != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrChoosedArea);
			}
			if (this.CurrChoosedInfluence != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrChoosedInfluence);
			}
			if (this.IsInit)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005259 RID: 21081 RVA: 0x000C86CC File Offset: 0x000C68CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyQuestUnlockAreaNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockAreaIds_.Add(other.unlockAreaIds_);
			this.unlockInfluenceIds_.Add(other.unlockInfluenceIds_);
			if (other.CurrChoosedArea != 0)
			{
				this.CurrChoosedArea = other.CurrChoosedArea;
			}
			if (other.CurrChoosedInfluence != 0)
			{
				this.CurrChoosedInfluence = other.CurrChoosedInfluence;
			}
			if (other.IsInit)
			{
				this.IsInit = other.IsInit;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600525A RID: 21082 RVA: 0x000C8752 File Offset: 0x000C6952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600525B RID: 21083 RVA: 0x000C875C File Offset: 0x000C695C
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
				if (num > 50U)
				{
					if (num <= 96U)
					{
						if (num == 72U)
						{
							this.IsInit = input.ReadBool();
							continue;
						}
						if (num != 96U)
						{
							goto IL_3D;
						}
					}
					else if (num != 98U)
					{
						if (num != 104U)
						{
							goto IL_3D;
						}
						this.CurrChoosedInfluence = input.ReadInt32();
						continue;
					}
					this.unlockInfluenceIds_.AddEntriesFrom(ref input, DailyQuestUnlockAreaNotify._repeated_unlockInfluenceIds_codec);
					continue;
				}
				if (num == 40U)
				{
					this.CurrChoosedArea = input.ReadInt32();
					continue;
				}
				if (num == 48U || num == 50U)
				{
					this.unlockAreaIds_.AddEntriesFrom(ref input, DailyQuestUnlockAreaNotify._repeated_unlockAreaIds_codec);
					continue;
				}
				IL_3D:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003339 RID: 13113
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400333A RID: 13114
		public const int UnlockAreaIdsFieldNumber = 6;

		// Token: 0x0400333B RID: 13115
		private static readonly FieldCodec<int> _repeated_unlockAreaIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x0400333C RID: 13116
		private readonly RepeatedField<int> unlockAreaIds_ = new RepeatedField<int>();

		// Token: 0x0400333D RID: 13117
		public const int UnlockInfluenceIdsFieldNumber = 12;

		// Token: 0x0400333E RID: 13118
		private static readonly FieldCodec<int> _repeated_unlockInfluenceIds_codec = FieldCodec.ForInt32(98U);

		// Token: 0x0400333F RID: 13119
		private readonly RepeatedField<int> unlockInfluenceIds_ = new RepeatedField<int>();

		// Token: 0x04003340 RID: 13120
		public const int CurrChoosedAreaFieldNumber = 5;

		// Token: 0x04003341 RID: 13121
		private int currChoosedArea_;

		// Token: 0x04003342 RID: 13122
		public const int CurrChoosedInfluenceFieldNumber = 13;

		// Token: 0x04003343 RID: 13123
		private int currChoosedInfluence_;

		// Token: 0x04003344 RID: 13124
		public const int IsInitFieldNumber = 9;

		// Token: 0x04003345 RID: 13125
		private bool isInit_;
	}
}
