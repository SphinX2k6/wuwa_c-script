using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A4A RID: 2634
	[NetMessage(EMessageId.MotorFightRefreshSubLevelNotify)]
	public sealed class MotorFightRefreshSubLevelNotify : IMessage<MotorFightRefreshSubLevelNotify>, IMessage, IEquatable<MotorFightRefreshSubLevelNotify>, IDeepCloneable<MotorFightRefreshSubLevelNotify>, IBufferMessage
	{
		// Token: 0x0600E61D RID: 58909 RVA: 0x0021A2A9 File Offset: 0x002184A9
		[NullableContext(1)]
		public static MotorFightRefreshSubLevelNotify Create()
		{
			return new MotorFightRefreshSubLevelNotify();
		}

		// Token: 0x17002EA2 RID: 11938
		// (get) Token: 0x0600E61E RID: 58910 RVA: 0x0021A2B0 File Offset: 0x002184B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EA3 RID: 11939
		// (get) Token: 0x0600E61F RID: 58911 RVA: 0x0021A2B3 File Offset: 0x002184B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRefreshSubLevelNotify.Descriptor;
			}
		}

		// Token: 0x0600E620 RID: 58912 RVA: 0x0021A2BA File Offset: 0x002184BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshSubLevelNotify()
		{
		}

		// Token: 0x0600E621 RID: 58913 RVA: 0x0021A2CD File Offset: 0x002184CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshSubLevelNotify(MotorFightRefreshSubLevelNotify other) : this()
		{
			this.subLevelIndex_ = other.subLevelIndex_;
			this.waveGroups_ = other.waveGroups_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E622 RID: 58914 RVA: 0x0021A303 File Offset: 0x00218503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshSubLevelNotify Clone()
		{
			return new MotorFightRefreshSubLevelNotify(this);
		}

		// Token: 0x17002EA4 RID: 11940
		// (get) Token: 0x0600E623 RID: 58915 RVA: 0x0021A30B File Offset: 0x0021850B
		// (set) Token: 0x0600E624 RID: 58916 RVA: 0x0021A313 File Offset: 0x00218513
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

		// Token: 0x17002EA5 RID: 11941
		// (get) Token: 0x0600E625 RID: 58917 RVA: 0x0021A31C File Offset: 0x0021851C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightWaveGroupPb> WaveGroups
		{
			get
			{
				return this.waveGroups_;
			}
		}

		// Token: 0x0600E626 RID: 58918 RVA: 0x0021A324 File Offset: 0x00218524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRefreshSubLevelNotify);
		}

		// Token: 0x0600E627 RID: 58919 RVA: 0x0021A334 File Offset: 0x00218534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRefreshSubLevelNotify other)
		{
			return other != null && (other == this || (this.SubLevelIndex == other.SubLevelIndex && this.waveGroups_.Equals(other.waveGroups_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E628 RID: 58920 RVA: 0x0021A384 File Offset: 0x00218584
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

		// Token: 0x0600E629 RID: 58921 RVA: 0x0021A3D1 File Offset: 0x002185D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E62A RID: 58922 RVA: 0x0021A3DE File Offset: 0x002185DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E62B RID: 58923 RVA: 0x0021A3E8 File Offset: 0x002185E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubLevelIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SubLevelIndex);
			}
			this.waveGroups_.WriteTo(ref output, MotorFightRefreshSubLevelNotify._repeated_waveGroups_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E62C RID: 58924 RVA: 0x0021A438 File Offset: 0x00218638
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

		// Token: 0x0600E62D RID: 58925 RVA: 0x0021A48C File Offset: 0x0021868C
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

		// Token: 0x0600E62E RID: 58926 RVA: 0x0021A4D9 File Offset: 0x002186D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E62F RID: 58927 RVA: 0x0021A4E4 File Offset: 0x002186E4
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
				if (num != 24U)
				{
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.waveGroups_.AddEntriesFrom(ref input, MotorFightRefreshSubLevelNotify._repeated_waveGroups_codec);
					}
				}
				else
				{
					this.SubLevelIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005E3C RID: 24124
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E3D RID: 24125
		public const int SubLevelIndexFieldNumber = 3;

		// Token: 0x04005E3E RID: 24126
		private int subLevelIndex_;

		// Token: 0x04005E3F RID: 24127
		public const int WaveGroupsFieldNumber = 6;

		// Token: 0x04005E40 RID: 24128
		private static readonly FieldCodec<MotorFightWaveGroupPb> _repeated_waveGroups_codec = FieldCodec.ForMessage<MotorFightWaveGroupPb>(50U, MotorFightWaveGroupPb.Parser);

		// Token: 0x04005E41 RID: 24129
		private readonly RepeatedField<MotorFightWaveGroupPb> waveGroups_ = new RepeatedField<MotorFightWaveGroupPb>();
	}
}
