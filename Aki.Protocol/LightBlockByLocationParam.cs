using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000920 RID: 2336
	public sealed class LightBlockByLocationParam : IMessage<LightBlockByLocationParam>, IMessage, IEquatable<LightBlockByLocationParam>, IDeepCloneable<LightBlockByLocationParam>, IBufferMessage
	{
		// Token: 0x0600CE1A RID: 52762 RVA: 0x001E5DCD File Offset: 0x001E3FCD
		[NullableContext(1)]
		public static LightBlockByLocationParam Create()
		{
			return new LightBlockByLocationParam();
		}

		// Token: 0x170029A2 RID: 10658
		// (get) Token: 0x0600CE1B RID: 52763 RVA: 0x001E5DD4 File Offset: 0x001E3FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029A3 RID: 10659
		// (get) Token: 0x0600CE1C RID: 52764 RVA: 0x001E5DD7 File Offset: 0x001E3FD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LightBlockByLocationParam.Descriptor;
			}
		}

		// Token: 0x0600CE1D RID: 52765 RVA: 0x001E5DDE File Offset: 0x001E3FDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LightBlockByLocationParam()
		{
		}

		// Token: 0x0600CE1E RID: 52766 RVA: 0x001E5DE6 File Offset: 0x001E3FE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LightBlockByLocationParam(LightBlockByLocationParam other) : this()
		{
			this.gridIndex_ = other.gridIndex_;
			this.focusTime_ = other.focusTime_;
			this.backToPlayer_ = other.backToPlayer_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CE1F RID: 52767 RVA: 0x001E5E23 File Offset: 0x001E4023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LightBlockByLocationParam Clone()
		{
			return new LightBlockByLocationParam(this);
		}

		// Token: 0x170029A4 RID: 10660
		// (get) Token: 0x0600CE20 RID: 52768 RVA: 0x001E5E2B File Offset: 0x001E402B
		// (set) Token: 0x0600CE21 RID: 52769 RVA: 0x001E5E33 File Offset: 0x001E4033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GridIndex
		{
			get
			{
				return this.gridIndex_;
			}
			set
			{
				this.gridIndex_ = value;
			}
		}

		// Token: 0x170029A5 RID: 10661
		// (get) Token: 0x0600CE22 RID: 52770 RVA: 0x001E5E3C File Offset: 0x001E403C
		// (set) Token: 0x0600CE23 RID: 52771 RVA: 0x001E5E44 File Offset: 0x001E4044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FocusTime
		{
			get
			{
				return this.focusTime_;
			}
			set
			{
				this.focusTime_ = value;
			}
		}

		// Token: 0x170029A6 RID: 10662
		// (get) Token: 0x0600CE24 RID: 52772 RVA: 0x001E5E4D File Offset: 0x001E404D
		// (set) Token: 0x0600CE25 RID: 52773 RVA: 0x001E5E55 File Offset: 0x001E4055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool BackToPlayer
		{
			get
			{
				return this.backToPlayer_;
			}
			set
			{
				this.backToPlayer_ = value;
			}
		}

		// Token: 0x0600CE26 RID: 52774 RVA: 0x001E5E5E File Offset: 0x001E405E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LightBlockByLocationParam);
		}

		// Token: 0x0600CE27 RID: 52775 RVA: 0x001E5E6C File Offset: 0x001E406C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LightBlockByLocationParam other)
		{
			return other != null && (other == this || (this.GridIndex == other.GridIndex && this.FocusTime == other.FocusTime && this.BackToPlayer == other.BackToPlayer && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CE28 RID: 52776 RVA: 0x001E5EC8 File Offset: 0x001E40C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GridIndex != 0)
			{
				num ^= this.GridIndex.GetHashCode();
			}
			if (this.FocusTime != 0)
			{
				num ^= this.FocusTime.GetHashCode();
			}
			if (this.BackToPlayer)
			{
				num ^= this.BackToPlayer.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CE29 RID: 52777 RVA: 0x001E5F39 File Offset: 0x001E4139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CE2A RID: 52778 RVA: 0x001E5F46 File Offset: 0x001E4146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CE2B RID: 52779 RVA: 0x001E5F50 File Offset: 0x001E4150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GridIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GridIndex);
			}
			if (this.FocusTime != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FocusTime);
			}
			if (this.BackToPlayer)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.BackToPlayer);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CE2C RID: 52780 RVA: 0x001E5FC4 File Offset: 0x001E41C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GridIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GridIndex);
			}
			if (this.FocusTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FocusTime);
			}
			if (this.BackToPlayer)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CE2D RID: 52781 RVA: 0x001E6028 File Offset: 0x001E4228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LightBlockByLocationParam other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GridIndex != 0)
			{
				this.GridIndex = other.GridIndex;
			}
			if (other.FocusTime != 0)
			{
				this.FocusTime = other.FocusTime;
			}
			if (other.BackToPlayer)
			{
				this.BackToPlayer = other.BackToPlayer;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CE2E RID: 52782 RVA: 0x001E608C File Offset: 0x001E428C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CE2F RID: 52783 RVA: 0x001E6098 File Offset: 0x001E4298
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.BackToPlayer = input.ReadBool();
						}
					}
					else
					{
						this.FocusTime = input.ReadInt32();
					}
				}
				else
				{
					this.GridIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005725 RID: 22309
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005726 RID: 22310
		public const int GridIndexFieldNumber = 1;

		// Token: 0x04005727 RID: 22311
		private int gridIndex_;

		// Token: 0x04005728 RID: 22312
		public const int FocusTimeFieldNumber = 2;

		// Token: 0x04005729 RID: 22313
		private int focusTime_;

		// Token: 0x0400572A RID: 22314
		public const int BackToPlayerFieldNumber = 3;

		// Token: 0x0400572B RID: 22315
		private bool backToPlayer_;
	}
}
