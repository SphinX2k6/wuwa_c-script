using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A44 RID: 2628
	[NetMessage(EMessageId.MotorFightRefreshBossPush)]
	public sealed class MotorFightRefreshBossPush : IMessage<MotorFightRefreshBossPush>, IMessage, IEquatable<MotorFightRefreshBossPush>, IDeepCloneable<MotorFightRefreshBossPush>, IBufferMessage
	{
		// Token: 0x0600E5A5 RID: 58789 RVA: 0x00219327 File Offset: 0x00217527
		[NullableContext(1)]
		public static MotorFightRefreshBossPush Create()
		{
			return new MotorFightRefreshBossPush();
		}

		// Token: 0x17002E8A RID: 11914
		// (get) Token: 0x0600E5A6 RID: 58790 RVA: 0x0021932E File Offset: 0x0021752E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E8B RID: 11915
		// (get) Token: 0x0600E5A7 RID: 58791 RVA: 0x00219331 File Offset: 0x00217531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRefreshBossPush.Descriptor;
			}
		}

		// Token: 0x0600E5A8 RID: 58792 RVA: 0x00219338 File Offset: 0x00217538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshBossPush()
		{
		}

		// Token: 0x0600E5A9 RID: 58793 RVA: 0x00219340 File Offset: 0x00217540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshBossPush(MotorFightRefreshBossPush other) : this()
		{
			this.subLevelIndex_ = other.subLevelIndex_;
			this.waveGroupIndex_ = other.waveGroupIndex_;
			this.refreshId_ = other.refreshId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E5AA RID: 58794 RVA: 0x0021937D File Offset: 0x0021757D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshBossPush Clone()
		{
			return new MotorFightRefreshBossPush(this);
		}

		// Token: 0x17002E8C RID: 11916
		// (get) Token: 0x0600E5AB RID: 58795 RVA: 0x00219385 File Offset: 0x00217585
		// (set) Token: 0x0600E5AC RID: 58796 RVA: 0x0021938D File Offset: 0x0021758D
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

		// Token: 0x17002E8D RID: 11917
		// (get) Token: 0x0600E5AD RID: 58797 RVA: 0x00219396 File Offset: 0x00217596
		// (set) Token: 0x0600E5AE RID: 58798 RVA: 0x0021939E File Offset: 0x0021759E
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

		// Token: 0x17002E8E RID: 11918
		// (get) Token: 0x0600E5AF RID: 58799 RVA: 0x002193A7 File Offset: 0x002175A7
		// (set) Token: 0x0600E5B0 RID: 58800 RVA: 0x002193AF File Offset: 0x002175AF
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

		// Token: 0x0600E5B1 RID: 58801 RVA: 0x002193B8 File Offset: 0x002175B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRefreshBossPush);
		}

		// Token: 0x0600E5B2 RID: 58802 RVA: 0x002193C8 File Offset: 0x002175C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRefreshBossPush other)
		{
			return other != null && (other == this || (this.SubLevelIndex == other.SubLevelIndex && this.WaveGroupIndex == other.WaveGroupIndex && this.RefreshId == other.RefreshId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E5B3 RID: 58803 RVA: 0x00219424 File Offset: 0x00217624
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

		// Token: 0x0600E5B4 RID: 58804 RVA: 0x00219495 File Offset: 0x00217695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E5B5 RID: 58805 RVA: 0x002194A2 File Offset: 0x002176A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E5B6 RID: 58806 RVA: 0x002194AC File Offset: 0x002176AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WaveGroupIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.WaveGroupIndex);
			}
			if (this.SubLevelIndex != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SubLevelIndex);
			}
			if (this.RefreshId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RefreshId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E5B7 RID: 58807 RVA: 0x00219524 File Offset: 0x00217724
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

		// Token: 0x0600E5B8 RID: 58808 RVA: 0x00219594 File Offset: 0x00217794
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

		// Token: 0x0600E5B9 RID: 58809 RVA: 0x002195F8 File Offset: 0x002177F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E5BA RID: 58810 RVA: 0x00219604 File Offset: 0x00217804
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
				if (num != 16U)
				{
					if (num != 40U)
					{
						if (num != 64U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RefreshId = input.ReadInt32();
						}
					}
					else
					{
						this.SubLevelIndex = input.ReadInt32();
					}
				}
				else
				{
					this.WaveGroupIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005E1D RID: 24093
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E1E RID: 24094
		public const int SubLevelIndexFieldNumber = 5;

		// Token: 0x04005E1F RID: 24095
		private int subLevelIndex_;

		// Token: 0x04005E20 RID: 24096
		public const int WaveGroupIndexFieldNumber = 2;

		// Token: 0x04005E21 RID: 24097
		private int waveGroupIndex_;

		// Token: 0x04005E22 RID: 24098
		public const int RefreshIdFieldNumber = 8;

		// Token: 0x04005E23 RID: 24099
		private int refreshId_;
	}
}
