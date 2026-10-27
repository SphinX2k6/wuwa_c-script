using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E37 RID: 3639
	[NetMessage(EMessageId.QuickHackRamVerifyPush)]
	public sealed class QuickHackRamVerifyPush : IMessage<QuickHackRamVerifyPush>, IMessage, IEquatable<QuickHackRamVerifyPush>, IDeepCloneable<QuickHackRamVerifyPush>, IBufferMessage
	{
		// Token: 0x06013887 RID: 80007 RVA: 0x002D6704 File Offset: 0x002D4904
		[NullableContext(1)]
		public static QuickHackRamVerifyPush Create()
		{
			return new QuickHackRamVerifyPush();
		}

		// Token: 0x170040C0 RID: 16576
		// (get) Token: 0x06013888 RID: 80008 RVA: 0x002D670B File Offset: 0x002D490B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040C1 RID: 16577
		// (get) Token: 0x06013889 RID: 80009 RVA: 0x002D670E File Offset: 0x002D490E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuickHackRamVerifyPush.Descriptor;
			}
		}

		// Token: 0x0601388A RID: 80010 RVA: 0x002D6715 File Offset: 0x002D4915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackRamVerifyPush()
		{
		}

		// Token: 0x0601388B RID: 80011 RVA: 0x002D6728 File Offset: 0x002D4928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackRamVerifyPush(QuickHackRamVerifyPush other) : this()
		{
			this.deviceID_ = other.deviceID_;
			this.quickHackSkillIdList_ = other.quickHackSkillIdList_.Clone();
			this.openQuickHackPreMessageId_ = other.openQuickHackPreMessageId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601388C RID: 80012 RVA: 0x002D6775 File Offset: 0x002D4975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackRamVerifyPush Clone()
		{
			return new QuickHackRamVerifyPush(this);
		}

		// Token: 0x170040C2 RID: 16578
		// (get) Token: 0x0601388D RID: 80013 RVA: 0x002D677D File Offset: 0x002D497D
		// (set) Token: 0x0601388E RID: 80014 RVA: 0x002D6785 File Offset: 0x002D4985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DeviceID
		{
			get
			{
				return this.deviceID_;
			}
			set
			{
				this.deviceID_ = value;
			}
		}

		// Token: 0x170040C3 RID: 16579
		// (get) Token: 0x0601388F RID: 80015 RVA: 0x002D678E File Offset: 0x002D498E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuickHackSkillIdList
		{
			get
			{
				return this.quickHackSkillIdList_;
			}
		}

		// Token: 0x170040C4 RID: 16580
		// (get) Token: 0x06013890 RID: 80016 RVA: 0x002D6796 File Offset: 0x002D4996
		// (set) Token: 0x06013891 RID: 80017 RVA: 0x002D679E File Offset: 0x002D499E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long OpenQuickHackPreMessageId
		{
			get
			{
				return this.openQuickHackPreMessageId_;
			}
			set
			{
				this.openQuickHackPreMessageId_ = value;
			}
		}

		// Token: 0x06013892 RID: 80018 RVA: 0x002D67A7 File Offset: 0x002D49A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuickHackRamVerifyPush);
		}

		// Token: 0x06013893 RID: 80019 RVA: 0x002D67B8 File Offset: 0x002D49B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuickHackRamVerifyPush other)
		{
			return other != null && (other == this || (this.DeviceID == other.DeviceID && this.quickHackSkillIdList_.Equals(other.quickHackSkillIdList_) && this.OpenQuickHackPreMessageId == other.OpenQuickHackPreMessageId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013894 RID: 80020 RVA: 0x002D6818 File Offset: 0x002D4A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DeviceID != 0)
			{
				num ^= this.DeviceID.GetHashCode();
			}
			num ^= this.quickHackSkillIdList_.GetHashCode();
			if (this.OpenQuickHackPreMessageId != 0L)
			{
				num ^= this.OpenQuickHackPreMessageId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013895 RID: 80021 RVA: 0x002D687E File Offset: 0x002D4A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013896 RID: 80022 RVA: 0x002D688B File Offset: 0x002D4A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013897 RID: 80023 RVA: 0x002D6894 File Offset: 0x002D4A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.quickHackSkillIdList_.WriteTo(ref output, QuickHackRamVerifyPush._repeated_quickHackSkillIdList_codec);
			if (this.OpenQuickHackPreMessageId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.OpenQuickHackPreMessageId);
			}
			if (this.DeviceID != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.DeviceID);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013898 RID: 80024 RVA: 0x002D6900 File Offset: 0x002D4B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DeviceID != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DeviceID);
			}
			num += this.quickHackSkillIdList_.CalculateSize(QuickHackRamVerifyPush._repeated_quickHackSkillIdList_codec);
			if (this.OpenQuickHackPreMessageId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.OpenQuickHackPreMessageId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013899 RID: 80025 RVA: 0x002D696C File Offset: 0x002D4B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuickHackRamVerifyPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DeviceID != 0)
			{
				this.DeviceID = other.DeviceID;
			}
			this.quickHackSkillIdList_.Add(other.quickHackSkillIdList_);
			if (other.OpenQuickHackPreMessageId != 0L)
			{
				this.OpenQuickHackPreMessageId = other.OpenQuickHackPreMessageId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601389A RID: 80026 RVA: 0x002D69CD File Offset: 0x002D4BCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601389B RID: 80027 RVA: 0x002D69D8 File Offset: 0x002D4BD8
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
				if (num <= 50U)
				{
					if (num == 48U || num == 50U)
					{
						this.quickHackSkillIdList_.AddEntriesFrom(ref input, QuickHackRamVerifyPush._repeated_quickHackSkillIdList_codec);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.OpenQuickHackPreMessageId = input.ReadInt64();
						continue;
					}
					if (num == 88U)
					{
						this.DeviceID = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400778D RID: 30605
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400778E RID: 30606
		public const int DeviceIDFieldNumber = 11;

		// Token: 0x0400778F RID: 30607
		private int deviceID_;

		// Token: 0x04007790 RID: 30608
		public const int QuickHackSkillIdListFieldNumber = 6;

		// Token: 0x04007791 RID: 30609
		private static readonly FieldCodec<int> _repeated_quickHackSkillIdList_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04007792 RID: 30610
		private readonly RepeatedField<int> quickHackSkillIdList_ = new RepeatedField<int>();

		// Token: 0x04007793 RID: 30611
		public const int OpenQuickHackPreMessageIdFieldNumber = 8;

		// Token: 0x04007794 RID: 30612
		private long openQuickHackPreMessageId_;
	}
}
