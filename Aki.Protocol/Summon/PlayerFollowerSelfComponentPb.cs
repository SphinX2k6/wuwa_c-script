using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Summon
{
	// Token: 0x020016F5 RID: 5877
	public sealed class PlayerFollowerSelfComponentPb : IMessage<PlayerFollowerSelfComponentPb>, IMessage, IEquatable<PlayerFollowerSelfComponentPb>, IDeepCloneable<PlayerFollowerSelfComponentPb>, IBufferMessage
	{
		// Token: 0x0601D5FE RID: 120318 RVA: 0x004403D1 File Offset: 0x0043E5D1
		[NullableContext(1)]
		public static PlayerFollowerSelfComponentPb Create()
		{
			return new PlayerFollowerSelfComponentPb();
		}

		// Token: 0x1700635D RID: 25437
		// (get) Token: 0x0601D5FF RID: 120319 RVA: 0x004403D8 File Offset: 0x0043E5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700635E RID: 25438
		// (get) Token: 0x0601D600 RID: 120320 RVA: 0x004403DB File Offset: 0x0043E5DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerFollowerSelfComponentPb.Descriptor;
			}
		}

		// Token: 0x0601D601 RID: 120321 RVA: 0x004403E2 File Offset: 0x0043E5E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowerSelfComponentPb()
		{
		}

		// Token: 0x0601D602 RID: 120322 RVA: 0x004403EA File Offset: 0x0043E5EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowerSelfComponentPb(PlayerFollowerSelfComponentPb other) : this()
		{
			this.playerEntityId_ = other.playerEntityId_;
			this.summonConfigId_ = other.summonConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D603 RID: 120323 RVA: 0x0044041B File Offset: 0x0043E61B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowerSelfComponentPb Clone()
		{
			return new PlayerFollowerSelfComponentPb(this);
		}

		// Token: 0x1700635F RID: 25439
		// (get) Token: 0x0601D604 RID: 120324 RVA: 0x00440423 File Offset: 0x0043E623
		// (set) Token: 0x0601D605 RID: 120325 RVA: 0x0044042B File Offset: 0x0043E62B
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

		// Token: 0x17006360 RID: 25440
		// (get) Token: 0x0601D606 RID: 120326 RVA: 0x00440434 File Offset: 0x0043E634
		// (set) Token: 0x0601D607 RID: 120327 RVA: 0x0044043C File Offset: 0x0043E63C
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

		// Token: 0x0601D608 RID: 120328 RVA: 0x00440445 File Offset: 0x0043E645
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerFollowerSelfComponentPb);
		}

		// Token: 0x0601D609 RID: 120329 RVA: 0x00440453 File Offset: 0x0043E653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerFollowerSelfComponentPb other)
		{
			return other != null && (other == this || (this.PlayerEntityId == other.PlayerEntityId && this.SummonConfigId == other.SummonConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D60A RID: 120330 RVA: 0x00440494 File Offset: 0x0043E694
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

		// Token: 0x0601D60B RID: 120331 RVA: 0x004404EC File Offset: 0x0043E6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D60C RID: 120332 RVA: 0x004404F9 File Offset: 0x0043E6F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D60D RID: 120333 RVA: 0x00440504 File Offset: 0x0043E704
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

		// Token: 0x0601D60E RID: 120334 RVA: 0x0044055C File Offset: 0x0043E75C
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

		// Token: 0x0601D60F RID: 120335 RVA: 0x004405B4 File Offset: 0x0043E7B4
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

		// Token: 0x0601D610 RID: 120336 RVA: 0x00440604 File Offset: 0x0043E804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D611 RID: 120337 RVA: 0x00440610 File Offset: 0x0043E810
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

		// Token: 0x0400C707 RID: 50951
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C708 RID: 50952
		public const int PlayerEntityIdFieldNumber = 1;

		// Token: 0x0400C709 RID: 50953
		private long playerEntityId_;

		// Token: 0x0400C70A RID: 50954
		public const int SummonConfigIdFieldNumber = 2;

		// Token: 0x0400C70B RID: 50955
		private int summonConfigId_;
	}
}
