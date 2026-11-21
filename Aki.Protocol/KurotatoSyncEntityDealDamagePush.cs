using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008C3 RID: 2243
	[NetMessage(EMessageId.KurotatoSyncEntityDealDamagePush)]
	public sealed class KurotatoSyncEntityDealDamagePush : IMessage<KurotatoSyncEntityDealDamagePush>, IMessage, IEquatable<KurotatoSyncEntityDealDamagePush>, IDeepCloneable<KurotatoSyncEntityDealDamagePush>, IBufferMessage
	{
		// Token: 0x0600C718 RID: 50968 RVA: 0x001D787A File Offset: 0x001D5A7A
		[NullableContext(1)]
		public static KurotatoSyncEntityDealDamagePush Create()
		{
			return new KurotatoSyncEntityDealDamagePush();
		}

		// Token: 0x17002836 RID: 10294
		// (get) Token: 0x0600C719 RID: 50969 RVA: 0x001D7881 File Offset: 0x001D5A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002837 RID: 10295
		// (get) Token: 0x0600C71A RID: 50970 RVA: 0x001D7884 File Offset: 0x001D5A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoSyncEntityDealDamagePush.Descriptor;
			}
		}

		// Token: 0x0600C71B RID: 50971 RVA: 0x001D788B File Offset: 0x001D5A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSyncEntityDealDamagePush()
		{
		}

		// Token: 0x0600C71C RID: 50972 RVA: 0x001D789E File Offset: 0x001D5A9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSyncEntityDealDamagePush(KurotatoSyncEntityDealDamagePush other) : this()
		{
			this.entityDealDamages_ = other.entityDealDamages_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C71D RID: 50973 RVA: 0x001D78C8 File Offset: 0x001D5AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSyncEntityDealDamagePush Clone()
		{
			return new KurotatoSyncEntityDealDamagePush(this);
		}

		// Token: 0x17002838 RID: 10296
		// (get) Token: 0x0600C71E RID: 50974 RVA: 0x001D78D0 File Offset: 0x001D5AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<long, int> EntityDealDamages
		{
			get
			{
				return this.entityDealDamages_;
			}
		}

		// Token: 0x0600C71F RID: 50975 RVA: 0x001D78D8 File Offset: 0x001D5AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoSyncEntityDealDamagePush);
		}

		// Token: 0x0600C720 RID: 50976 RVA: 0x001D78E6 File Offset: 0x001D5AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoSyncEntityDealDamagePush other)
		{
			return other != null && (other == this || (this.EntityDealDamages.Equals(other.EntityDealDamages) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C721 RID: 50977 RVA: 0x001D791C File Offset: 0x001D5B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.EntityDealDamages.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C722 RID: 50978 RVA: 0x001D7950 File Offset: 0x001D5B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C723 RID: 50979 RVA: 0x001D795D File Offset: 0x001D5B5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C724 RID: 50980 RVA: 0x001D7966 File Offset: 0x001D5B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityDealDamages_.WriteTo(ref output, KurotatoSyncEntityDealDamagePush._map_entityDealDamages_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C725 RID: 50981 RVA: 0x001D7990 File Offset: 0x001D5B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityDealDamages_.CalculateSize(KurotatoSyncEntityDealDamagePush._map_entityDealDamages_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C726 RID: 50982 RVA: 0x001D79C9 File Offset: 0x001D5BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoSyncEntityDealDamagePush other)
		{
			if (other == null)
			{
				return;
			}
			this.entityDealDamages_.MergeFrom(other.entityDealDamages_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C727 RID: 50983 RVA: 0x001D79F7 File Offset: 0x001D5BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C728 RID: 50984 RVA: 0x001D7A00 File Offset: 0x001D5C00
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityDealDamages_.AddEntriesFrom(ref input, KurotatoSyncEntityDealDamagePush._map_entityDealDamages_codec);
				}
			}
		}

		// Token: 0x040055AC RID: 21932
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055AD RID: 21933
		public const int EntityDealDamagesFieldNumber = 7;

		// Token: 0x040055AE RID: 21934
		private static readonly MapField<long, int>.Codec _map_entityDealDamages_codec = new MapField<long, int>.Codec(FieldCodec.ForInt64(8U, 0L), FieldCodec.ForInt32(16U, 0), 58U);

		// Token: 0x040055AF RID: 21935
		private readonly MapField<long, int> entityDealDamages_ = new MapField<long, int>();
	}
}
