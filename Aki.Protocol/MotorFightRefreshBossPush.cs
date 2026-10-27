using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A55 RID: 2645
	[NetMessage(EMessageId.MotorFightRefreshBossPush)]
	public sealed class MotorFightRefreshBossPush : IMessage<MotorFightRefreshBossPush>, IMessage, IEquatable<MotorFightRefreshBossPush>, IDeepCloneable<MotorFightRefreshBossPush>, IBufferMessage
	{
		// Token: 0x0600E6BF RID: 59071 RVA: 0x0021B51B File Offset: 0x0021971B
		[NullableContext(1)]
		public static MotorFightRefreshBossPush Create()
		{
			return new MotorFightRefreshBossPush();
		}

		// Token: 0x17002EC8 RID: 11976
		// (get) Token: 0x0600E6C0 RID: 59072 RVA: 0x0021B522 File Offset: 0x00219722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EC9 RID: 11977
		// (get) Token: 0x0600E6C1 RID: 59073 RVA: 0x0021B525 File Offset: 0x00219725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRefreshBossPush.Descriptor;
			}
		}

		// Token: 0x0600E6C2 RID: 59074 RVA: 0x0021B52C File Offset: 0x0021972C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshBossPush()
		{
		}

		// Token: 0x0600E6C3 RID: 59075 RVA: 0x0021B534 File Offset: 0x00219734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshBossPush(MotorFightRefreshBossPush other) : this()
		{
			this.subLevelIndex_ = other.subLevelIndex_;
			this.waveGroupIndex_ = other.waveGroupIndex_;
			this.refreshId_ = other.refreshId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E6C4 RID: 59076 RVA: 0x0021B571 File Offset: 0x00219771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshBossPush Clone()
		{
			return new MotorFightRefreshBossPush(this);
		}

		// Token: 0x17002ECA RID: 11978
		// (get) Token: 0x0600E6C5 RID: 59077 RVA: 0x0021B579 File Offset: 0x00219779
		// (set) Token: 0x0600E6C6 RID: 59078 RVA: 0x0021B581 File Offset: 0x00219781
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

		// Token: 0x17002ECB RID: 11979
		// (get) Token: 0x0600E6C7 RID: 59079 RVA: 0x0021B58A File Offset: 0x0021978A
		// (set) Token: 0x0600E6C8 RID: 59080 RVA: 0x0021B592 File Offset: 0x00219792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaveGroupIndex
		{
			get
			{
				return this.waveGroupIndex_;
			}
			set
			{
				this.waveGroupIndex_ = value;
			}
		}

		// Token: 0x17002ECC RID: 11980
		// (get) Token: 0x0600E6C9 RID: 59081 RVA: 0x0021B59B File Offset: 0x0021979B
		// (set) Token: 0x0600E6CA RID: 59082 RVA: 0x0021B5A3 File Offset: 0x002197A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RefreshId
		{
			get
			{
				return this.refreshId_;
			}
			set
			{
				this.refreshId_ = value;
			}
		}

		// Token: 0x0600E6CB RID: 59083 RVA: 0x0021B5AC File Offset: 0x002197AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRefreshBossPush);
		}

		// Token: 0x0600E6CC RID: 59084 RVA: 0x0021B5BC File Offset: 0x002197BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRefreshBossPush other)
		{
			return other != null && (other == this || (this.SubLevelIndex == other.SubLevelIndex && this.WaveGroupIndex == other.WaveGroupIndex && this.RefreshId == other.RefreshId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E6CD RID: 59085 RVA: 0x0021B618 File Offset: 0x00219818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubLevelIndex != 0)
			{
				num ^= this.SubLevelIndex.GetHashCode();
			}
			if (this.WaveGroupIndex != 0)
			{
				num ^= this.WaveGroupIndex.GetHashCode();
			}
			if (this.RefreshId != 0)
			{
				num ^= this.RefreshId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E6CE RID: 59086 RVA: 0x0021B689 File Offset: 0x00219889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E6CF RID: 59087 RVA: 0x0021B696 File Offset: 0x00219896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E6D0 RID: 59088 RVA: 0x0021B6A0 File Offset: 0x002198A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WaveGroupIndex != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.WaveGroupIndex);
			}
			if (this.RefreshId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RefreshId);
			}
			if (this.SubLevelIndex != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.SubLevelIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E6D1 RID: 59089 RVA: 0x0021B718 File Offset: 0x00219918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubLevelIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubLevelIndex);
			}
			if (this.WaveGroupIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaveGroupIndex);
			}
			if (this.RefreshId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RefreshId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E6D2 RID: 59090 RVA: 0x0021B788 File Offset: 0x00219988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightRefreshBossPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubLevelIndex != 0)
			{
				this.SubLevelIndex = other.SubLevelIndex;
			}
			if (other.WaveGroupIndex != 0)
			{
				this.WaveGroupIndex = other.WaveGroupIndex;
			}
			if (other.RefreshId != 0)
			{
				this.RefreshId = other.RefreshId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E6D3 RID: 59091 RVA: 0x0021B7EC File Offset: 0x002199EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E6D4 RID: 59092 RVA: 0x0021B7F8 File Offset: 0x002199F8
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
					if (num != 72U)
					{
						if (num != 120U)
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
						this.RefreshId = input.ReadInt32();
					}
				}
				else
				{
					this.WaveGroupIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005E14 RID: 24084
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E15 RID: 24085
		public const int SubLevelIndexFieldNumber = 15;

		// Token: 0x04005E16 RID: 24086
		private int subLevelIndex_;

		// Token: 0x04005E17 RID: 24087
		public const int WaveGroupIndexFieldNumber = 6;

		// Token: 0x04005E18 RID: 24088
		private int waveGroupIndex_;

		// Token: 0x04005E19 RID: 24089
		public const int RefreshIdFieldNumber = 9;

		// Token: 0x04005E1A RID: 24090
		private int refreshId_;
	}
}
