using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C3E RID: 3134
	[NetMessage(EMessageId.PhantomBattleBvBLoadingNotify)]
	public sealed class PhantomBattleBvBLoadingNotify : IMessage<PhantomBattleBvBLoadingNotify>, IMessage, IEquatable<PhantomBattleBvBLoadingNotify>, IDeepCloneable<PhantomBattleBvBLoadingNotify>, IBufferMessage
	{
		// Token: 0x06010FDE RID: 69598 RVA: 0x0027C951 File Offset: 0x0027AB51
		[NullableContext(1)]
		public static PhantomBattleBvBLoadingNotify Create()
		{
			return new PhantomBattleBvBLoadingNotify();
		}

		// Token: 0x1700381A RID: 14362
		// (get) Token: 0x06010FDF RID: 69599 RVA: 0x0027C958 File Offset: 0x0027AB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700381B RID: 14363
		// (get) Token: 0x06010FE0 RID: 69600 RVA: 0x0027C95B File Offset: 0x0027AB5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBvBLoadingNotify.Descriptor;
			}
		}

		// Token: 0x06010FE1 RID: 69601 RVA: 0x0027C962 File Offset: 0x0027AB62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBLoadingNotify()
		{
		}

		// Token: 0x06010FE2 RID: 69602 RVA: 0x0027C980 File Offset: 0x0027AB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBLoadingNotify(PhantomBattleBvBLoadingNotify other) : this()
		{
			this.npcMonsterEntityIncId_ = other.npcMonsterEntityIncId_.Clone();
			this.playerMonsterEntityIncId_ = other.playerMonsterEntityIncId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010FE3 RID: 69603 RVA: 0x0027C9BB File Offset: 0x0027ABBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBvBLoadingNotify Clone()
		{
			return new PhantomBattleBvBLoadingNotify(this);
		}

		// Token: 0x1700381C RID: 14364
		// (get) Token: 0x06010FE4 RID: 69604 RVA: 0x0027C9C3 File Offset: 0x0027ABC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, long> NpcMonsterEntityIncId
		{
			get
			{
				return this.npcMonsterEntityIncId_;
			}
		}

		// Token: 0x1700381D RID: 14365
		// (get) Token: 0x06010FE5 RID: 69605 RVA: 0x0027C9CB File Offset: 0x0027ABCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, long> PlayerMonsterEntityIncId
		{
			get
			{
				return this.playerMonsterEntityIncId_;
			}
		}

		// Token: 0x06010FE6 RID: 69606 RVA: 0x0027C9D3 File Offset: 0x0027ABD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBvBLoadingNotify);
		}

		// Token: 0x06010FE7 RID: 69607 RVA: 0x0027C9E4 File Offset: 0x0027ABE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBvBLoadingNotify other)
		{
			return other != null && (other == this || (this.NpcMonsterEntityIncId.Equals(other.NpcMonsterEntityIncId) && this.PlayerMonsterEntityIncId.Equals(other.PlayerMonsterEntityIncId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010FE8 RID: 69608 RVA: 0x0027CA38 File Offset: 0x0027AC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.NpcMonsterEntityIncId.GetHashCode();
			num ^= this.PlayerMonsterEntityIncId.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010FE9 RID: 69609 RVA: 0x0027CA7A File Offset: 0x0027AC7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010FEA RID: 69610 RVA: 0x0027CA87 File Offset: 0x0027AC87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010FEB RID: 69611 RVA: 0x0027CA90 File Offset: 0x0027AC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerMonsterEntityIncId_.WriteTo(ref output, PhantomBattleBvBLoadingNotify._map_playerMonsterEntityIncId_codec);
			this.npcMonsterEntityIncId_.WriteTo(ref output, PhantomBattleBvBLoadingNotify._map_npcMonsterEntityIncId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010FEC RID: 69612 RVA: 0x0027CAC8 File Offset: 0x0027ACC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.npcMonsterEntityIncId_.CalculateSize(PhantomBattleBvBLoadingNotify._map_npcMonsterEntityIncId_codec);
			num += this.playerMonsterEntityIncId_.CalculateSize(PhantomBattleBvBLoadingNotify._map_playerMonsterEntityIncId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010FED RID: 69613 RVA: 0x0027CB14 File Offset: 0x0027AD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBvBLoadingNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.npcMonsterEntityIncId_.MergeFrom(other.npcMonsterEntityIncId_);
			this.playerMonsterEntityIncId_.MergeFrom(other.playerMonsterEntityIncId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010FEE RID: 69614 RVA: 0x0027CB53 File Offset: 0x0027AD53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010FEF RID: 69615 RVA: 0x0027CB5C File Offset: 0x0027AD5C
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
				if (num != 42U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.npcMonsterEntityIncId_.AddEntriesFrom(ref input, PhantomBattleBvBLoadingNotify._map_npcMonsterEntityIncId_codec);
					}
				}
				else
				{
					this.playerMonsterEntityIncId_.AddEntriesFrom(ref input, PhantomBattleBvBLoadingNotify._map_playerMonsterEntityIncId_codec);
				}
			}
		}

		// Token: 0x04006BA4 RID: 27556
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006BA5 RID: 27557
		public const int NpcMonsterEntityIncIdFieldNumber = 11;

		// Token: 0x04006BA6 RID: 27558
		private static readonly MapField<int, long>.Codec _map_npcMonsterEntityIncId_codec = new MapField<int, long>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt64(16U, 0L), 90U);

		// Token: 0x04006BA7 RID: 27559
		private readonly MapField<int, long> npcMonsterEntityIncId_ = new MapField<int, long>();

		// Token: 0x04006BA8 RID: 27560
		public const int PlayerMonsterEntityIncIdFieldNumber = 5;

		// Token: 0x04006BA9 RID: 27561
		private static readonly MapField<int, long>.Codec _map_playerMonsterEntityIncId_codec = new MapField<int, long>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt64(16U, 0L), 42U);

		// Token: 0x04006BAA RID: 27562
		private readonly MapField<int, long> playerMonsterEntityIncId_ = new MapField<int, long>();
	}
}
