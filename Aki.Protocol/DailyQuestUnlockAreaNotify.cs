using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200032C RID: 812
	[NetMessage(EMessageId.DailyQuestUnlockAreaNotify)]
	public sealed class DailyQuestUnlockAreaNotify : IMessage<DailyQuestUnlockAreaNotify>, IMessage, IEquatable<DailyQuestUnlockAreaNotify>, IDeepCloneable<DailyQuestUnlockAreaNotify>, IBufferMessage
	{
		// Token: 0x0600516B RID: 20843 RVA: 0x000C5F9C File Offset: 0x000C419C
		[NullableContext(1)]
		public static DailyQuestUnlockAreaNotify Create()
		{
			return new DailyQuestUnlockAreaNotify();
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x0600516C RID: 20844 RVA: 0x000C5FA3 File Offset: 0x000C41A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x0600516D RID: 20845 RVA: 0x000C5FA6 File Offset: 0x000C41A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyQuestUnlockAreaNotify.Descriptor;
			}
		}

		// Token: 0x0600516E RID: 20846 RVA: 0x000C5FAD File Offset: 0x000C41AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestUnlockAreaNotify()
		{
		}

		// Token: 0x0600516F RID: 20847 RVA: 0x000C5FCC File Offset: 0x000C41CC
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

		// Token: 0x06005170 RID: 20848 RVA: 0x000C6036 File Offset: 0x000C4236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestUnlockAreaNotify Clone()
		{
			return new DailyQuestUnlockAreaNotify(this);
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06005171 RID: 20849 RVA: 0x000C603E File Offset: 0x000C423E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockAreaIds
		{
			get
			{
				return this.unlockAreaIds_;
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06005172 RID: 20850 RVA: 0x000C6046 File Offset: 0x000C4246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockInfluenceIds
		{
			get
			{
				return this.unlockInfluenceIds_;
			}
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06005173 RID: 20851 RVA: 0x000C604E File Offset: 0x000C424E
		// (set) Token: 0x06005174 RID: 20852 RVA: 0x000C6056 File Offset: 0x000C4256
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

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06005175 RID: 20853 RVA: 0x000C605F File Offset: 0x000C425F
		// (set) Token: 0x06005176 RID: 20854 RVA: 0x000C6067 File Offset: 0x000C4267
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

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06005177 RID: 20855 RVA: 0x000C6070 File Offset: 0x000C4270
		// (set) Token: 0x06005178 RID: 20856 RVA: 0x000C6078 File Offset: 0x000C4278
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

		// Token: 0x06005179 RID: 20857 RVA: 0x000C6081 File Offset: 0x000C4281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyQuestUnlockAreaNotify);
		}

		// Token: 0x0600517A RID: 20858 RVA: 0x000C6090 File Offset: 0x000C4290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyQuestUnlockAreaNotify other)
		{
			return other != null && (other == this || (this.unlockAreaIds_.Equals(other.unlockAreaIds_) && this.unlockInfluenceIds_.Equals(other.unlockInfluenceIds_) && this.CurrChoosedArea == other.CurrChoosedArea && this.CurrChoosedInfluence == other.CurrChoosedInfluence && this.IsInit == other.IsInit && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600517B RID: 20859 RVA: 0x000C6114 File Offset: 0x000C4314
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

		// Token: 0x0600517C RID: 20860 RVA: 0x000C61A1 File Offset: 0x000C43A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600517D RID: 20861 RVA: 0x000C61AE File Offset: 0x000C43AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600517E RID: 20862 RVA: 0x000C61B8 File Offset: 0x000C43B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurrChoosedArea != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurrChoosedArea);
			}
			this.unlockInfluenceIds_.WriteTo(ref output, DailyQuestUnlockAreaNotify._repeated_unlockInfluenceIds_codec);
			if (this.CurrChoosedInfluence != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CurrChoosedInfluence);
			}
			this.unlockAreaIds_.WriteTo(ref output, DailyQuestUnlockAreaNotify._repeated_unlockAreaIds_codec);
			if (this.IsInit)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsInit);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600517F RID: 20863 RVA: 0x000C6250 File Offset: 0x000C4450
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

		// Token: 0x06005180 RID: 20864 RVA: 0x000C62D8 File Offset: 0x000C44D8
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

		// Token: 0x06005181 RID: 20865 RVA: 0x000C635E File Offset: 0x000C455E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005182 RID: 20866 RVA: 0x000C6368 File Offset: 0x000C4568
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
				if (num > 18U)
				{
					if (num <= 72U)
					{
						if (num == 24U)
						{
							this.CurrChoosedInfluence = input.ReadInt32();
							continue;
						}
						if (num != 72U)
						{
							goto IL_3C;
						}
					}
					else if (num != 74U)
					{
						if (num != 80U)
						{
							goto IL_3C;
						}
						this.IsInit = input.ReadBool();
						continue;
					}
					this.unlockAreaIds_.AddEntriesFrom(ref input, DailyQuestUnlockAreaNotify._repeated_unlockAreaIds_codec);
					continue;
				}
				if (num == 8U)
				{
					this.CurrChoosedArea = input.ReadInt32();
					continue;
				}
				if (num == 16U || num == 18U)
				{
					this.unlockInfluenceIds_.AddEntriesFrom(ref input, DailyQuestUnlockAreaNotify._repeated_unlockInfluenceIds_codec);
					continue;
				}
				IL_3C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040032A2 RID: 12962
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032A3 RID: 12963
		public const int UnlockAreaIdsFieldNumber = 9;

		// Token: 0x040032A4 RID: 12964
		private static readonly FieldCodec<int> _repeated_unlockAreaIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x040032A5 RID: 12965
		private readonly RepeatedField<int> unlockAreaIds_ = new RepeatedField<int>();

		// Token: 0x040032A6 RID: 12966
		public const int UnlockInfluenceIdsFieldNumber = 2;

		// Token: 0x040032A7 RID: 12967
		private static readonly FieldCodec<int> _repeated_unlockInfluenceIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040032A8 RID: 12968
		private readonly RepeatedField<int> unlockInfluenceIds_ = new RepeatedField<int>();

		// Token: 0x040032A9 RID: 12969
		public const int CurrChoosedAreaFieldNumber = 1;

		// Token: 0x040032AA RID: 12970
		private int currChoosedArea_;

		// Token: 0x040032AB RID: 12971
		public const int CurrChoosedInfluenceFieldNumber = 3;

		// Token: 0x040032AC RID: 12972
		private int currChoosedInfluence_;

		// Token: 0x040032AD RID: 12973
		public const int IsInitFieldNumber = 10;

		// Token: 0x040032AE RID: 12974
		private bool isInit_;
	}
}
