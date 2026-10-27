using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A5B RID: 2651
	[NetMessage(EMessageId.MotorFightRefreshSubLevelNotify)]
	public sealed class MotorFightRefreshSubLevelNotify : IMessage<MotorFightRefreshSubLevelNotify>, IMessage, IEquatable<MotorFightRefreshSubLevelNotify>, IDeepCloneable<MotorFightRefreshSubLevelNotify>, IBufferMessage
	{
		// Token: 0x0600E737 RID: 59191 RVA: 0x0021C49D File Offset: 0x0021A69D
		[NullableContext(1)]
		public static MotorFightRefreshSubLevelNotify Create()
		{
			return new MotorFightRefreshSubLevelNotify();
		}

		// Token: 0x17002EE0 RID: 12000
		// (get) Token: 0x0600E738 RID: 59192 RVA: 0x0021C4A4 File Offset: 0x0021A6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EE1 RID: 12001
		// (get) Token: 0x0600E739 RID: 59193 RVA: 0x0021C4A7 File Offset: 0x0021A6A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRefreshSubLevelNotify.Descriptor;
			}
		}

		// Token: 0x0600E73A RID: 59194 RVA: 0x0021C4AE File Offset: 0x0021A6AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshSubLevelNotify()
		{
		}

		// Token: 0x0600E73B RID: 59195 RVA: 0x0021C4C1 File Offset: 0x0021A6C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshSubLevelNotify(MotorFightRefreshSubLevelNotify other) : this()
		{
			this.subLevelIndex_ = other.subLevelIndex_;
			this.waveGroups_ = other.waveGroups_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E73C RID: 59196 RVA: 0x0021C4F7 File Offset: 0x0021A6F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshSubLevelNotify Clone()
		{
			return new MotorFightRefreshSubLevelNotify(this);
		}

		// Token: 0x17002EE2 RID: 12002
		// (get) Token: 0x0600E73D RID: 59197 RVA: 0x0021C4FF File Offset: 0x0021A6FF
		// (set) Token: 0x0600E73E RID: 59198 RVA: 0x0021C507 File Offset: 0x0021A707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubLevelIndex
		{
			get
			{
				return this.subLevelIndex_;
			}
			set
			{
				this.subLevelIndex_ = value;
			}
		}

		// Token: 0x17002EE3 RID: 12003
		// (get) Token: 0x0600E73F RID: 59199 RVA: 0x0021C510 File Offset: 0x0021A710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightWaveGroupPb> WaveGroups
		{
			get
			{
				return this.waveGroups_;
			}
		}

		// Token: 0x0600E740 RID: 59200 RVA: 0x0021C518 File Offset: 0x0021A718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRefreshSubLevelNotify);
		}

		// Token: 0x0600E741 RID: 59201 RVA: 0x0021C528 File Offset: 0x0021A728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRefreshSubLevelNotify other)
		{
			return other != null && (other == this || (this.SubLevelIndex == other.SubLevelIndex && this.waveGroups_.Equals(other.waveGroups_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E742 RID: 59202 RVA: 0x0021C578 File Offset: 0x0021A778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubLevelIndex != 0)
			{
				num ^= this.SubLevelIndex.GetHashCode();
			}
			num ^= this.waveGroups_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E743 RID: 59203 RVA: 0x0021C5C5 File Offset: 0x0021A7C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E744 RID: 59204 RVA: 0x0021C5D2 File Offset: 0x0021A7D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E745 RID: 59205 RVA: 0x0021C5DC File Offset: 0x0021A7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.waveGroups_.WriteTo(ref output, MotorFightRefreshSubLevelNotify._repeated_waveGroups_codec);
			if (this.SubLevelIndex != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SubLevelIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E746 RID: 59206 RVA: 0x0021C62C File Offset: 0x0021A82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubLevelIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubLevelIndex);
			}
			num += this.waveGroups_.CalculateSize(MotorFightRefreshSubLevelNotify._repeated_waveGroups_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E747 RID: 59207 RVA: 0x0021C680 File Offset: 0x0021A880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightRefreshSubLevelNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubLevelIndex != 0)
			{
				this.SubLevelIndex = other.SubLevelIndex;
			}
			this.waveGroups_.Add(other.waveGroups_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E748 RID: 59208 RVA: 0x0021C6CD File Offset: 0x0021A8CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E749 RID: 59209 RVA: 0x0021C6D8 File Offset: 0x0021A8D8
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
				if (num != 26U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SubLevelIndex = input.ReadInt32();
					}
				}
				else
				{
					this.waveGroups_.AddEntriesFrom(ref input, MotorFightRefreshSubLevelNotify._repeated_waveGroups_codec);
				}
			}
		}

		// Token: 0x04005E33 RID: 24115
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E34 RID: 24116
		public const int SubLevelIndexFieldNumber = 7;

		// Token: 0x04005E35 RID: 24117
		private int subLevelIndex_;

		// Token: 0x04005E36 RID: 24118
		public const int WaveGroupsFieldNumber = 3;

		// Token: 0x04005E37 RID: 24119
		private static readonly FieldCodec<MotorFightWaveGroupPb> _repeated_waveGroups_codec = FieldCodec.ForMessage<MotorFightWaveGroupPb>(26U, MotorFightWaveGroupPb.Parser);

		// Token: 0x04005E38 RID: 24120
		private readonly RepeatedField<MotorFightWaveGroupPb> waveGroups_ = new RepeatedField<MotorFightWaveGroupPb>();
	}
}
