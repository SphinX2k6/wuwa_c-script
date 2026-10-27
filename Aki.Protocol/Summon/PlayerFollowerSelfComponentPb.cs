using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Summon
{
	// Token: 0x02001679 RID: 5753
	public sealed class PlayerFollowerSelfComponentPb : IMessage<PlayerFollowerSelfComponentPb>, IMessage, IEquatable<PlayerFollowerSelfComponentPb>, IDeepCloneable<PlayerFollowerSelfComponentPb>, IBufferMessage
	{
		// Token: 0x0601CB33 RID: 117555 RVA: 0x004247B1 File Offset: 0x004229B1
		[NullableContext(1)]
		public static PlayerFollowerSelfComponentPb Create()
		{
			return new PlayerFollowerSelfComponentPb();
		}

		// Token: 0x170060BA RID: 24762
		// (get) Token: 0x0601CB34 RID: 117556 RVA: 0x004247B8 File Offset: 0x004229B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060BB RID: 24763
		// (get) Token: 0x0601CB35 RID: 117557 RVA: 0x004247BB File Offset: 0x004229BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerFollowerSelfComponentPb.Descriptor;
			}
		}

		// Token: 0x0601CB36 RID: 117558 RVA: 0x004247C2 File Offset: 0x004229C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowerSelfComponentPb()
		{
		}

		// Token: 0x0601CB37 RID: 117559 RVA: 0x004247CA File Offset: 0x004229CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowerSelfComponentPb(PlayerFollowerSelfComponentPb other) : this()
		{
			this.playerEntityId_ = other.playerEntityId_;
			this.summonConfigId_ = other.summonConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CB38 RID: 117560 RVA: 0x004247FB File Offset: 0x004229FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowerSelfComponentPb Clone()
		{
			return new PlayerFollowerSelfComponentPb(this);
		}

		// Token: 0x170060BC RID: 24764
		// (get) Token: 0x0601CB39 RID: 117561 RVA: 0x00424803 File Offset: 0x00422A03
		// (set) Token: 0x0601CB3A RID: 117562 RVA: 0x0042480B File Offset: 0x00422A0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlayerEntityId
		{
			get
			{
				return this.playerEntityId_;
			}
			set
			{
				this.playerEntityId_ = value;
			}
		}

		// Token: 0x170060BD RID: 24765
		// (get) Token: 0x0601CB3B RID: 117563 RVA: 0x00424814 File Offset: 0x00422A14
		// (set) Token: 0x0601CB3C RID: 117564 RVA: 0x0042481C File Offset: 0x00422A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SummonConfigId
		{
			get
			{
				return this.summonConfigId_;
			}
			set
			{
				this.summonConfigId_ = value;
			}
		}

		// Token: 0x0601CB3D RID: 117565 RVA: 0x00424825 File Offset: 0x00422A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerFollowerSelfComponentPb);
		}

		// Token: 0x0601CB3E RID: 117566 RVA: 0x00424833 File Offset: 0x00422A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerFollowerSelfComponentPb other)
		{
			return other != null && (other == this || (this.PlayerEntityId == other.PlayerEntityId && this.SummonConfigId == other.SummonConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CB3F RID: 117567 RVA: 0x00424874 File Offset: 0x00422A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerEntityId != 0L)
			{
				num ^= this.PlayerEntityId.GetHashCode();
			}
			if (this.SummonConfigId != 0)
			{
				num ^= this.SummonConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CB40 RID: 117568 RVA: 0x004248CC File Offset: 0x00422ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CB41 RID: 117569 RVA: 0x004248D9 File Offset: 0x00422AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CB42 RID: 117570 RVA: 0x004248E4 File Offset: 0x00422AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.PlayerEntityId);
			}
			if (this.SummonConfigId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SummonConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CB43 RID: 117571 RVA: 0x0042493C File Offset: 0x00422B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PlayerEntityId);
			}
			if (this.SummonConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SummonConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CB44 RID: 117572 RVA: 0x00424994 File Offset: 0x00422B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerFollowerSelfComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerEntityId != 0L)
			{
				this.PlayerEntityId = other.PlayerEntityId;
			}
			if (other.SummonConfigId != 0)
			{
				this.SummonConfigId = other.SummonConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CB45 RID: 117573 RVA: 0x004249E4 File Offset: 0x00422BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CB46 RID: 117574 RVA: 0x004249F0 File Offset: 0x00422BF0
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SummonConfigId = input.ReadInt32();
					}
				}
				else
				{
					this.PlayerEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400C1DE RID: 49630
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C1DF RID: 49631
		public const int PlayerEntityIdFieldNumber = 1;

		// Token: 0x0400C1E0 RID: 49632
		private long playerEntityId_;

		// Token: 0x0400C1E1 RID: 49633
		public const int SummonConfigIdFieldNumber = 2;

		// Token: 0x0400C1E2 RID: 49634
		private int summonConfigId_;
	}
}
