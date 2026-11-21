using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E27 RID: 3623
	[NetMessage(EMessageId.QuickHackRamVerifyPush)]
	public sealed class QuickHackRamVerifyPush : IMessage<QuickHackRamVerifyPush>, IMessage, IEquatable<QuickHackRamVerifyPush>, IDeepCloneable<QuickHackRamVerifyPush>, IBufferMessage
	{
		// Token: 0x060137A2 RID: 79778 RVA: 0x002D5044 File Offset: 0x002D3244
		[NullableContext(1)]
		public static QuickHackRamVerifyPush Create()
		{
			return new QuickHackRamVerifyPush();
		}

		// Token: 0x17004096 RID: 16534
		// (get) Token: 0x060137A3 RID: 79779 RVA: 0x002D504B File Offset: 0x002D324B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004097 RID: 16535
		// (get) Token: 0x060137A4 RID: 79780 RVA: 0x002D504E File Offset: 0x002D324E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuickHackRamVerifyPush.Descriptor;
			}
		}

		// Token: 0x060137A5 RID: 79781 RVA: 0x002D5055 File Offset: 0x002D3255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackRamVerifyPush()
		{
		}

		// Token: 0x060137A6 RID: 79782 RVA: 0x002D5068 File Offset: 0x002D3268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackRamVerifyPush(QuickHackRamVerifyPush other) : this()
		{
			this.deviceID_ = other.deviceID_;
			this.quickHackSkillIdList_ = other.quickHackSkillIdList_.Clone();
			this.openQuickHackPreMessageId_ = other.openQuickHackPreMessageId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060137A7 RID: 79783 RVA: 0x002D50B5 File Offset: 0x002D32B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuickHackRamVerifyPush Clone()
		{
			return new QuickHackRamVerifyPush(this);
		}

		// Token: 0x17004098 RID: 16536
		// (get) Token: 0x060137A8 RID: 79784 RVA: 0x002D50BD File Offset: 0x002D32BD
		// (set) Token: 0x060137A9 RID: 79785 RVA: 0x002D50C5 File Offset: 0x002D32C5
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

		// Token: 0x17004099 RID: 16537
		// (get) Token: 0x060137AA RID: 79786 RVA: 0x002D50CE File Offset: 0x002D32CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuickHackSkillIdList
		{
			get
			{
				return this.quickHackSkillIdList_;
			}
		}

		// Token: 0x1700409A RID: 16538
		// (get) Token: 0x060137AB RID: 79787 RVA: 0x002D50D6 File Offset: 0x002D32D6
		// (set) Token: 0x060137AC RID: 79788 RVA: 0x002D50DE File Offset: 0x002D32DE
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

		// Token: 0x060137AD RID: 79789 RVA: 0x002D50E7 File Offset: 0x002D32E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuickHackRamVerifyPush);
		}

		// Token: 0x060137AE RID: 79790 RVA: 0x002D50F8 File Offset: 0x002D32F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuickHackRamVerifyPush other)
		{
			return other != null && (other == this || (this.DeviceID == other.DeviceID && this.quickHackSkillIdList_.Equals(other.quickHackSkillIdList_) && this.OpenQuickHackPreMessageId == other.OpenQuickHackPreMessageId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060137AF RID: 79791 RVA: 0x002D5158 File Offset: 0x002D3358
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

		// Token: 0x060137B0 RID: 79792 RVA: 0x002D51BE File Offset: 0x002D33BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060137B1 RID: 79793 RVA: 0x002D51CB File Offset: 0x002D33CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060137B2 RID: 79794 RVA: 0x002D51D4 File Offset: 0x002D33D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.quickHackSkillIdList_.WriteTo(ref output, QuickHackRamVerifyPush._repeated_quickHackSkillIdList_codec);
			if (this.OpenQuickHackPreMessageId != 0L)
			{
				output.WriteRawTag(80);
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

		// Token: 0x060137B3 RID: 79795 RVA: 0x002D5240 File Offset: 0x002D3440
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

		// Token: 0x060137B4 RID: 79796 RVA: 0x002D52AC File Offset: 0x002D34AC
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

		// Token: 0x060137B5 RID: 79797 RVA: 0x002D530D File Offset: 0x002D350D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060137B6 RID: 79798 RVA: 0x002D5318 File Offset: 0x002D3518
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
				if (num <= 34U)
				{
					if (num == 32U || num == 34U)
					{
						this.quickHackSkillIdList_.AddEntriesFrom(ref input, QuickHackRamVerifyPush._repeated_quickHackSkillIdList_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
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

		// Token: 0x040077B7 RID: 30647
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077B8 RID: 30648
		public const int DeviceIDFieldNumber = 11;

		// Token: 0x040077B9 RID: 30649
		private int deviceID_;

		// Token: 0x040077BA RID: 30650
		public const int QuickHackSkillIdListFieldNumber = 4;

		// Token: 0x040077BB RID: 30651
		private static readonly FieldCodec<int> _repeated_quickHackSkillIdList_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040077BC RID: 30652
		private readonly RepeatedField<int> quickHackSkillIdList_ = new RepeatedField<int>();

		// Token: 0x040077BD RID: 30653
		public const int OpenQuickHackPreMessageIdFieldNumber = 10;

		// Token: 0x040077BE RID: 30654
		private long openQuickHackPreMessageId_;
	}
}
