using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008D4 RID: 2260
	[NetMessage(EMessageId.KurotatoSyncEntityDealDamagePush)]
	public sealed class KurotatoSyncEntityDealDamagePush : IMessage<KurotatoSyncEntityDealDamagePush>, IMessage, IEquatable<KurotatoSyncEntityDealDamagePush>, IDeepCloneable<KurotatoSyncEntityDealDamagePush>, IBufferMessage
	{
		// Token: 0x0600C834 RID: 51252 RVA: 0x001D9B5E File Offset: 0x001D7D5E
		[NullableContext(1)]
		public static KurotatoSyncEntityDealDamagePush Create()
		{
			return new KurotatoSyncEntityDealDamagePush();
		}

		// Token: 0x17002875 RID: 10357
		// (get) Token: 0x0600C835 RID: 51253 RVA: 0x001D9B65 File Offset: 0x001D7D65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002876 RID: 10358
		// (get) Token: 0x0600C836 RID: 51254 RVA: 0x001D9B68 File Offset: 0x001D7D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoSyncEntityDealDamagePush.Descriptor;
			}
		}

		// Token: 0x0600C837 RID: 51255 RVA: 0x001D9B6F File Offset: 0x001D7D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSyncEntityDealDamagePush()
		{
		}

		// Token: 0x0600C838 RID: 51256 RVA: 0x001D9B82 File Offset: 0x001D7D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSyncEntityDealDamagePush(KurotatoSyncEntityDealDamagePush other) : this()
		{
			this.entityDealDamages_ = other.entityDealDamages_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C839 RID: 51257 RVA: 0x001D9BAC File Offset: 0x001D7DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSyncEntityDealDamagePush Clone()
		{
			return new KurotatoSyncEntityDealDamagePush(this);
		}

		// Token: 0x17002877 RID: 10359
		// (get) Token: 0x0600C83A RID: 51258 RVA: 0x001D9BB4 File Offset: 0x001D7DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<long, int> EntityDealDamages
		{
			get
			{
				return this.entityDealDamages_;
			}
		}

		// Token: 0x0600C83B RID: 51259 RVA: 0x001D9BBC File Offset: 0x001D7DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoSyncEntityDealDamagePush);
		}

		// Token: 0x0600C83C RID: 51260 RVA: 0x001D9BCA File Offset: 0x001D7DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoSyncEntityDealDamagePush other)
		{
			return other != null && (other == this || (this.EntityDealDamages.Equals(other.EntityDealDamages) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C83D RID: 51261 RVA: 0x001D9C00 File Offset: 0x001D7E00
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

		// Token: 0x0600C83E RID: 51262 RVA: 0x001D9C34 File Offset: 0x001D7E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C83F RID: 51263 RVA: 0x001D9C41 File Offset: 0x001D7E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C840 RID: 51264 RVA: 0x001D9C4A File Offset: 0x001D7E4A
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

		// Token: 0x0600C841 RID: 51265 RVA: 0x001D9C74 File Offset: 0x001D7E74
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

		// Token: 0x0600C842 RID: 51266 RVA: 0x001D9CAD File Offset: 0x001D7EAD
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

		// Token: 0x0600C843 RID: 51267 RVA: 0x001D9CDB File Offset: 0x001D7EDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C844 RID: 51268 RVA: 0x001D9CE4 File Offset: 0x001D7EE4
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityDealDamages_.AddEntriesFrom(ref input, KurotatoSyncEntityDealDamagePush._map_entityDealDamages_codec);
				}
			}
		}

		// Token: 0x040055A5 RID: 21925
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055A6 RID: 21926
		public const int EntityDealDamagesFieldNumber = 2;

		// Token: 0x040055A7 RID: 21927
		private static readonly MapField<long, int>.Codec _map_entityDealDamages_codec = new MapField<long, int>.Codec(FieldCodec.ForInt64(8U, 0L), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x040055A8 RID: 21928
		private readonly MapField<long, int> entityDealDamages_ = new MapField<long, int>();
	}
}
