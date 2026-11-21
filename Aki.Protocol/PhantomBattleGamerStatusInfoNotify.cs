using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C7E RID: 3198
	[NetMessage(EMessageId.PhantomBattleGamerStatusInfoNotify)]
	public sealed class PhantomBattleGamerStatusInfoNotify : IMessage<PhantomBattleGamerStatusInfoNotify>, IMessage, IEquatable<PhantomBattleGamerStatusInfoNotify>, IDeepCloneable<PhantomBattleGamerStatusInfoNotify>, IBufferMessage
	{
		// Token: 0x060115CA RID: 71114 RVA: 0x0028BEE2 File Offset: 0x0028A0E2
		[NullableContext(1)]
		public static PhantomBattleGamerStatusInfoNotify Create()
		{
			return new PhantomBattleGamerStatusInfoNotify();
		}

		// Token: 0x17003981 RID: 14721
		// (get) Token: 0x060115CB RID: 71115 RVA: 0x0028BEE9 File Offset: 0x0028A0E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003982 RID: 14722
		// (get) Token: 0x060115CC RID: 71116 RVA: 0x0028BEEC File Offset: 0x0028A0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleGamerStatusInfoNotify.Descriptor;
			}
		}

		// Token: 0x060115CD RID: 71117 RVA: 0x0028BEF3 File Offset: 0x0028A0F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGamerStatusInfoNotify()
		{
		}

		// Token: 0x060115CE RID: 71118 RVA: 0x0028BF06 File Offset: 0x0028A106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGamerStatusInfoNotify(PhantomBattleGamerStatusInfoNotify other) : this()
		{
			this.gamerIndex_ = other.gamerIndex_;
			this.battleStatus_ = other.battleStatus_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060115CF RID: 71119 RVA: 0x0028BF3C File Offset: 0x0028A13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGamerStatusInfoNotify Clone()
		{
			return new PhantomBattleGamerStatusInfoNotify(this);
		}

		// Token: 0x17003983 RID: 14723
		// (get) Token: 0x060115D0 RID: 71120 RVA: 0x0028BF44 File Offset: 0x0028A144
		// (set) Token: 0x060115D1 RID: 71121 RVA: 0x0028BF4C File Offset: 0x0028A14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GamerIndex
		{
			get
			{
				return this.gamerIndex_;
			}
			set
			{
				this.gamerIndex_ = value;
			}
		}

		// Token: 0x17003984 RID: 14724
		// (get) Token: 0x060115D2 RID: 71122 RVA: 0x0028BF55 File Offset: 0x0028A155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> BattleStatus
		{
			get
			{
				return this.battleStatus_;
			}
		}

		// Token: 0x060115D3 RID: 71123 RVA: 0x0028BF5D File Offset: 0x0028A15D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleGamerStatusInfoNotify);
		}

		// Token: 0x060115D4 RID: 71124 RVA: 0x0028BF6C File Offset: 0x0028A16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleGamerStatusInfoNotify other)
		{
			return other != null && (other == this || (this.GamerIndex == other.GamerIndex && this.BattleStatus.Equals(other.BattleStatus) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060115D5 RID: 71125 RVA: 0x0028BFBC File Offset: 0x0028A1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GamerIndex != 0)
			{
				num ^= this.GamerIndex.GetHashCode();
			}
			num ^= this.BattleStatus.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060115D6 RID: 71126 RVA: 0x0028C009 File Offset: 0x0028A209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060115D7 RID: 71127 RVA: 0x0028C016 File Offset: 0x0028A216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060115D8 RID: 71128 RVA: 0x0028C020 File Offset: 0x0028A220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GamerIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GamerIndex);
			}
			this.battleStatus_.WriteTo(ref output, PhantomBattleGamerStatusInfoNotify._map_battleStatus_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060115D9 RID: 71129 RVA: 0x0028C070 File Offset: 0x0028A270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GamerIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GamerIndex);
			}
			num += this.battleStatus_.CalculateSize(PhantomBattleGamerStatusInfoNotify._map_battleStatus_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060115DA RID: 71130 RVA: 0x0028C0C4 File Offset: 0x0028A2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleGamerStatusInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GamerIndex != 0)
			{
				this.GamerIndex = other.GamerIndex;
			}
			this.battleStatus_.MergeFrom(other.battleStatus_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060115DB RID: 71131 RVA: 0x0028C111 File Offset: 0x0028A311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060115DC RID: 71132 RVA: 0x0028C11C File Offset: 0x0028A31C
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
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.battleStatus_.AddEntriesFrom(ref input, PhantomBattleGamerStatusInfoNotify._map_battleStatus_codec);
					}
				}
				else
				{
					this.GamerIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006E1F RID: 28191
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E20 RID: 28192
		public const int GamerIndexFieldNumber = 1;

		// Token: 0x04006E21 RID: 28193
		private int gamerIndex_;

		// Token: 0x04006E22 RID: 28194
		public const int BattleStatusFieldNumber = 15;

		// Token: 0x04006E23 RID: 28195
		private static readonly MapField<int, int>.Codec _map_battleStatus_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 122U);

		// Token: 0x04006E24 RID: 28196
		private readonly MapField<int, int> battleStatus_ = new MapField<int, int>();
	}
}
