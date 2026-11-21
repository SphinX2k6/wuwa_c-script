using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200017A RID: 378
	[NetMessage(EMessageId.BattlePassTaskResponse)]
	public sealed class BattlePassTaskResponse : IMessage<BattlePassTaskResponse>, IMessage, IEquatable<BattlePassTaskResponse>, IDeepCloneable<BattlePassTaskResponse>, IBufferMessage
	{
		// Token: 0x06002E48 RID: 11848 RVA: 0x00077896 File Offset: 0x00075A96
		[NullableContext(1)]
		public static BattlePassTaskResponse Create()
		{
			return new BattlePassTaskResponse();
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06002E49 RID: 11849 RVA: 0x0007789D File Offset: 0x00075A9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06002E4A RID: 11850 RVA: 0x000778A0 File Offset: 0x00075AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassTaskResponse.Descriptor;
			}
		}

		// Token: 0x06002E4B RID: 11851 RVA: 0x000778A7 File Offset: 0x00075AA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskResponse()
		{
		}

		// Token: 0x06002E4C RID: 11852 RVA: 0x000778BC File Offset: 0x00075ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskResponse(BattlePassTaskResponse other) : this()
		{
			this.dayEnd_ = other.dayEnd_;
			this.weekEnd_ = other.weekEnd_;
			this.tasks_ = other.tasks_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E4D RID: 11853 RVA: 0x00077915 File Offset: 0x00075B15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskResponse Clone()
		{
			return new BattlePassTaskResponse(this);
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06002E4E RID: 11854 RVA: 0x0007791D File Offset: 0x00075B1D
		// (set) Token: 0x06002E4F RID: 11855 RVA: 0x00077925 File Offset: 0x00075B25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DayEnd
		{
			get
			{
				return this.dayEnd_;
			}
			set
			{
				this.dayEnd_ = value;
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06002E50 RID: 11856 RVA: 0x0007792E File Offset: 0x00075B2E
		// (set) Token: 0x06002E51 RID: 11857 RVA: 0x00077936 File Offset: 0x00075B36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long WeekEnd
		{
			get
			{
				return this.weekEnd_;
			}
			set
			{
				this.weekEnd_ = value;
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06002E52 RID: 11858 RVA: 0x0007793F File Offset: 0x00075B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbBattlePassTask> Tasks
		{
			get
			{
				return this.tasks_;
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06002E53 RID: 11859 RVA: 0x00077947 File Offset: 0x00075B47
		// (set) Token: 0x06002E54 RID: 11860 RVA: 0x0007794F File Offset: 0x00075B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x06002E55 RID: 11861 RVA: 0x00077958 File Offset: 0x00075B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassTaskResponse);
		}

		// Token: 0x06002E56 RID: 11862 RVA: 0x00077968 File Offset: 0x00075B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassTaskResponse other)
		{
			return other != null && (other == this || (this.DayEnd == other.DayEnd && this.WeekEnd == other.WeekEnd && this.tasks_.Equals(other.tasks_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x000779D8 File Offset: 0x00075BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DayEnd != 0L)
			{
				num ^= this.DayEnd.GetHashCode();
			}
			if (this.WeekEnd != 0L)
			{
				num ^= this.WeekEnd.GetHashCode();
			}
			num ^= this.tasks_.GetHashCode();
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x00077A5D File Offset: 0x00075C5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x00077A6A File Offset: 0x00075C6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x00077A74 File Offset: 0x00075C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.tasks_.WriteTo(ref output, BattlePassTaskResponse._repeated_tasks_codec);
			if (this.WeekEnd != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.WeekEnd);
			}
			if (this.DayEnd != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.DayEnd);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E5B RID: 11867 RVA: 0x00077AFC File Offset: 0x00075CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DayEnd != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DayEnd);
			}
			if (this.WeekEnd != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.WeekEnd);
			}
			num += this.tasks_.CalculateSize(BattlePassTaskResponse._repeated_tasks_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x00077B80 File Offset: 0x00075D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassTaskResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DayEnd != 0L)
			{
				this.DayEnd = other.DayEnd;
			}
			if (other.WeekEnd != 0L)
			{
				this.WeekEnd = other.WeekEnd;
			}
			this.tasks_.Add(other.tasks_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x00077BF5 File Offset: 0x00075DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x00077C00 File Offset: 0x00075E00
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
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 18U)
					{
						this.tasks_.AddEntriesFrom(ref input, BattlePassTaskResponse._repeated_tasks_codec);
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.WeekEnd = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.DayEnd = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040028BD RID: 10429
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028BE RID: 10430
		public const int DayEndFieldNumber = 15;

		// Token: 0x040028BF RID: 10431
		private long dayEnd_;

		// Token: 0x040028C0 RID: 10432
		public const int WeekEndFieldNumber = 6;

		// Token: 0x040028C1 RID: 10433
		private long weekEnd_;

		// Token: 0x040028C2 RID: 10434
		public const int TasksFieldNumber = 2;

		// Token: 0x040028C3 RID: 10435
		private static readonly FieldCodec<PbBattlePassTask> _repeated_tasks_codec = FieldCodec.ForMessage<PbBattlePassTask>(18U, PbBattlePassTask.Parser);

		// Token: 0x040028C4 RID: 10436
		private readonly RepeatedField<PbBattlePassTask> tasks_ = new RepeatedField<PbBattlePassTask>();

		// Token: 0x040028C5 RID: 10437
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040028C6 RID: 10438
		private ErrorCode errorCode_;
	}
}
