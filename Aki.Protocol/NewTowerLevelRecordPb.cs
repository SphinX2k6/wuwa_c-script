using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B37 RID: 2871
	public sealed class NewTowerLevelRecordPb : IMessage<NewTowerLevelRecordPb>, IMessage, IEquatable<NewTowerLevelRecordPb>, IDeepCloneable<NewTowerLevelRecordPb>, IBufferMessage
	{
		// Token: 0x0600F929 RID: 63785 RVA: 0x0024570B File Offset: 0x0024390B
		[NullableContext(1)]
		public static NewTowerLevelRecordPb Create()
		{
			return new NewTowerLevelRecordPb();
		}

		// Token: 0x170032CA RID: 13002
		// (get) Token: 0x0600F92A RID: 63786 RVA: 0x00245712 File Offset: 0x00243912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NewTowerLevelRecordPb> Parser
		{
			get
			{
				return NewTowerLevelRecordPb._parser;
			}
		}

		// Token: 0x170032CB RID: 13003
		// (get) Token: 0x0600F92B RID: 63787 RVA: 0x00245719 File Offset: 0x00243919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032CC RID: 13004
		// (get) Token: 0x0600F92C RID: 63788 RVA: 0x0024571C File Offset: 0x0024391C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerLevelRecordPb.Descriptor;
			}
		}

		// Token: 0x0600F92D RID: 63789 RVA: 0x00245723 File Offset: 0x00243923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerLevelRecordPb()
		{
		}

		// Token: 0x0600F92E RID: 63790 RVA: 0x00245736 File Offset: 0x00243936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerLevelRecordPb(NewTowerLevelRecordPb other) : this()
		{
			this.levelId_ = other.levelId_;
			this.newTowerTeamRecordPbs_ = other.newTowerTeamRecordPbs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F92F RID: 63791 RVA: 0x0024576C File Offset: 0x0024396C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerLevelRecordPb Clone()
		{
			return new NewTowerLevelRecordPb(this);
		}

		// Token: 0x170032CD RID: 13005
		// (get) Token: 0x0600F930 RID: 63792 RVA: 0x00245774 File Offset: 0x00243974
		// (set) Token: 0x0600F931 RID: 63793 RVA: 0x0024577C File Offset: 0x0024397C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x170032CE RID: 13006
		// (get) Token: 0x0600F932 RID: 63794 RVA: 0x00245785 File Offset: 0x00243985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewTowerTeamRecordPb> NewTowerTeamRecordPbs
		{
			get
			{
				return this.newTowerTeamRecordPbs_;
			}
		}

		// Token: 0x0600F933 RID: 63795 RVA: 0x0024578D File Offset: 0x0024398D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerLevelRecordPb);
		}

		// Token: 0x0600F934 RID: 63796 RVA: 0x0024579C File Offset: 0x0024399C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerLevelRecordPb other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.newTowerTeamRecordPbs_.Equals(other.newTowerTeamRecordPbs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F935 RID: 63797 RVA: 0x002457EC File Offset: 0x002439EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			num ^= this.newTowerTeamRecordPbs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F936 RID: 63798 RVA: 0x00245839 File Offset: 0x00243A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F937 RID: 63799 RVA: 0x00245846 File Offset: 0x00243A46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F938 RID: 63800 RVA: 0x00245850 File Offset: 0x00243A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			this.newTowerTeamRecordPbs_.WriteTo(ref output, NewTowerLevelRecordPb._repeated_newTowerTeamRecordPbs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F939 RID: 63801 RVA: 0x002458A0 File Offset: 0x00243AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			num += this.newTowerTeamRecordPbs_.CalculateSize(NewTowerLevelRecordPb._repeated_newTowerTeamRecordPbs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F93A RID: 63802 RVA: 0x002458F4 File Offset: 0x00243AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerLevelRecordPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			this.newTowerTeamRecordPbs_.Add(other.newTowerTeamRecordPbs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F93B RID: 63803 RVA: 0x00245941 File Offset: 0x00243B41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F93C RID: 63804 RVA: 0x0024594C File Offset: 0x00243B4C
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.newTowerTeamRecordPbs_.AddEntriesFrom(ref input, NewTowerLevelRecordPb._repeated_newTowerTeamRecordPbs_codec);
					}
				}
				else
				{
					this.LevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040063DC RID: 25564
		private static readonly MessageParser<NewTowerLevelRecordPb> _parser = new MessageParser<NewTowerLevelRecordPb>(() => new NewTowerLevelRecordPb());

		// Token: 0x040063DD RID: 25565
		private UnknownFieldSet _unknownFields;

		// Token: 0x040063DE RID: 25566
		public const int LevelIdFieldNumber = 1;

		// Token: 0x040063DF RID: 25567
		private int levelId_;

		// Token: 0x040063E0 RID: 25568
		public const int NewTowerTeamRecordPbsFieldNumber = 2;

		// Token: 0x040063E1 RID: 25569
		private static readonly FieldCodec<NewTowerTeamRecordPb> _repeated_newTowerTeamRecordPbs_codec = FieldCodec.ForMessage<NewTowerTeamRecordPb>(18U, NewTowerTeamRecordPb.Parser);

		// Token: 0x040063E2 RID: 25570
		private readonly RepeatedField<NewTowerTeamRecordPb> newTowerTeamRecordPbs_ = new RepeatedField<NewTowerTeamRecordPb>();
	}
}
