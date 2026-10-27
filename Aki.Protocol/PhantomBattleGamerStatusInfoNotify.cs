using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C8E RID: 3214
	[NetMessage(EMessageId.PhantomBattleGamerStatusInfoNotify)]
	public sealed class PhantomBattleGamerStatusInfoNotify : IMessage<PhantomBattleGamerStatusInfoNotify>, IMessage, IEquatable<PhantomBattleGamerStatusInfoNotify>, IDeepCloneable<PhantomBattleGamerStatusInfoNotify>, IBufferMessage
	{
		// Token: 0x060116CA RID: 71370 RVA: 0x0028DC4E File Offset: 0x0028BE4E
		[NullableContext(1)]
		public static PhantomBattleGamerStatusInfoNotify Create()
		{
			return new PhantomBattleGamerStatusInfoNotify();
		}

		// Token: 0x170039B8 RID: 14776
		// (get) Token: 0x060116CB RID: 71371 RVA: 0x0028DC55 File Offset: 0x0028BE55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039B9 RID: 14777
		// (get) Token: 0x060116CC RID: 71372 RVA: 0x0028DC58 File Offset: 0x0028BE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleGamerStatusInfoNotify.Descriptor;
			}
		}

		// Token: 0x060116CD RID: 71373 RVA: 0x0028DC5F File Offset: 0x0028BE5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGamerStatusInfoNotify()
		{
		}

		// Token: 0x060116CE RID: 71374 RVA: 0x0028DC72 File Offset: 0x0028BE72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGamerStatusInfoNotify(PhantomBattleGamerStatusInfoNotify other) : this()
		{
			this.gamerIndex_ = other.gamerIndex_;
			this.battleStatus_ = other.battleStatus_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060116CF RID: 71375 RVA: 0x0028DCA8 File Offset: 0x0028BEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGamerStatusInfoNotify Clone()
		{
			return new PhantomBattleGamerStatusInfoNotify(this);
		}

		// Token: 0x170039BA RID: 14778
		// (get) Token: 0x060116D0 RID: 71376 RVA: 0x0028DCB0 File Offset: 0x0028BEB0
		// (set) Token: 0x060116D1 RID: 71377 RVA: 0x0028DCB8 File Offset: 0x0028BEB8
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

		// Token: 0x170039BB RID: 14779
		// (get) Token: 0x060116D2 RID: 71378 RVA: 0x0028DCC1 File Offset: 0x0028BEC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> BattleStatus
		{
			get
			{
				return this.battleStatus_;
			}
		}

		// Token: 0x060116D3 RID: 71379 RVA: 0x0028DCC9 File Offset: 0x0028BEC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleGamerStatusInfoNotify);
		}

		// Token: 0x060116D4 RID: 71380 RVA: 0x0028DCD8 File Offset: 0x0028BED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleGamerStatusInfoNotify other)
		{
			return other != null && (other == this || (this.GamerIndex == other.GamerIndex && this.BattleStatus.Equals(other.BattleStatus) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060116D5 RID: 71381 RVA: 0x0028DD28 File Offset: 0x0028BF28
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

		// Token: 0x060116D6 RID: 71382 RVA: 0x0028DD75 File Offset: 0x0028BF75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060116D7 RID: 71383 RVA: 0x0028DD82 File Offset: 0x0028BF82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060116D8 RID: 71384 RVA: 0x0028DD8C File Offset: 0x0028BF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GamerIndex != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.GamerIndex);
			}
			this.battleStatus_.WriteTo(ref output, PhantomBattleGamerStatusInfoNotify._map_battleStatus_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060116D9 RID: 71385 RVA: 0x0028DDDC File Offset: 0x0028BFDC
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

		// Token: 0x060116DA RID: 71386 RVA: 0x0028DE30 File Offset: 0x0028C030
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

		// Token: 0x060116DB RID: 71387 RVA: 0x0028DE7D File Offset: 0x0028C07D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060116DC RID: 71388 RVA: 0x0028DE88 File Offset: 0x0028C088
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
				if (num != 56U)
				{
					if (num != 114U)
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

		// Token: 0x04006E0B RID: 28171
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E0C RID: 28172
		public const int GamerIndexFieldNumber = 7;

		// Token: 0x04006E0D RID: 28173
		private int gamerIndex_;

		// Token: 0x04006E0E RID: 28174
		public const int BattleStatusFieldNumber = 14;

		// Token: 0x04006E0F RID: 28175
		private static readonly MapField<int, int>.Codec _map_battleStatus_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 114U);

		// Token: 0x04006E10 RID: 28176
		private readonly MapField<int, int> battleStatus_ = new MapField<int, int>();
	}
}
