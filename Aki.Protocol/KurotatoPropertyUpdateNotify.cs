using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008AB RID: 2219
	[NetMessage(EMessageId.KurotatoPropertyUpdateNotify)]
	public sealed class KurotatoPropertyUpdateNotify : IMessage<KurotatoPropertyUpdateNotify>, IMessage, IEquatable<KurotatoPropertyUpdateNotify>, IDeepCloneable<KurotatoPropertyUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600C50A RID: 50442 RVA: 0x001D2EB2 File Offset: 0x001D10B2
		[NullableContext(1)]
		public static KurotatoPropertyUpdateNotify Create()
		{
			return new KurotatoPropertyUpdateNotify();
		}

		// Token: 0x170027D4 RID: 10196
		// (get) Token: 0x0600C50B RID: 50443 RVA: 0x001D2EB9 File Offset: 0x001D10B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027D5 RID: 10197
		// (get) Token: 0x0600C50C RID: 50444 RVA: 0x001D2EBC File Offset: 0x001D10BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoPropertyUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600C50D RID: 50445 RVA: 0x001D2EC3 File Offset: 0x001D10C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoPropertyUpdateNotify()
		{
		}

		// Token: 0x0600C50E RID: 50446 RVA: 0x001D2EE1 File Offset: 0x001D10E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoPropertyUpdateNotify(KurotatoPropertyUpdateNotify other) : this()
		{
			this.propertyValues_ = other.propertyValues_.Clone();
			this.lockedPropertyValues_ = other.lockedPropertyValues_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C50F RID: 50447 RVA: 0x001D2F1C File Offset: 0x001D111C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoPropertyUpdateNotify Clone()
		{
			return new KurotatoPropertyUpdateNotify(this);
		}

		// Token: 0x170027D6 RID: 10198
		// (get) Token: 0x0600C510 RID: 50448 RVA: 0x001D2F24 File Offset: 0x001D1124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> PropertyValues
		{
			get
			{
				return this.propertyValues_;
			}
		}

		// Token: 0x170027D7 RID: 10199
		// (get) Token: 0x0600C511 RID: 50449 RVA: 0x001D2F2C File Offset: 0x001D112C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> LockedPropertyValues
		{
			get
			{
				return this.lockedPropertyValues_;
			}
		}

		// Token: 0x0600C512 RID: 50450 RVA: 0x001D2F34 File Offset: 0x001D1134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoPropertyUpdateNotify);
		}

		// Token: 0x0600C513 RID: 50451 RVA: 0x001D2F44 File Offset: 0x001D1144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoPropertyUpdateNotify other)
		{
			return other != null && (other == this || (this.PropertyValues.Equals(other.PropertyValues) && this.LockedPropertyValues.Equals(other.LockedPropertyValues) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C514 RID: 50452 RVA: 0x001D2F98 File Offset: 0x001D1198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.PropertyValues.GetHashCode();
			num ^= this.LockedPropertyValues.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C515 RID: 50453 RVA: 0x001D2FDA File Offset: 0x001D11DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C516 RID: 50454 RVA: 0x001D2FE7 File Offset: 0x001D11E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C517 RID: 50455 RVA: 0x001D2FF0 File Offset: 0x001D11F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.propertyValues_.WriteTo(ref output, KurotatoPropertyUpdateNotify._map_propertyValues_codec);
			this.lockedPropertyValues_.WriteTo(ref output, KurotatoPropertyUpdateNotify._map_lockedPropertyValues_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C518 RID: 50456 RVA: 0x001D3028 File Offset: 0x001D1228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.propertyValues_.CalculateSize(KurotatoPropertyUpdateNotify._map_propertyValues_codec);
			num += this.lockedPropertyValues_.CalculateSize(KurotatoPropertyUpdateNotify._map_lockedPropertyValues_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C519 RID: 50457 RVA: 0x001D3074 File Offset: 0x001D1274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoPropertyUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.propertyValues_.MergeFrom(other.propertyValues_);
			this.lockedPropertyValues_.MergeFrom(other.lockedPropertyValues_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C51A RID: 50458 RVA: 0x001D30B3 File Offset: 0x001D12B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C51B RID: 50459 RVA: 0x001D30BC File Offset: 0x001D12BC
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
				if (num != 10U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.lockedPropertyValues_.AddEntriesFrom(ref input, KurotatoPropertyUpdateNotify._map_lockedPropertyValues_codec);
					}
				}
				else
				{
					this.propertyValues_.AddEntriesFrom(ref input, KurotatoPropertyUpdateNotify._map_propertyValues_codec);
				}
			}
		}

		// Token: 0x040054DD RID: 21725
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054DE RID: 21726
		public const int PropertyValuesFieldNumber = 1;

		// Token: 0x040054DF RID: 21727
		private static readonly MapField<int, int>.Codec _map_propertyValues_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x040054E0 RID: 21728
		private readonly MapField<int, int> propertyValues_ = new MapField<int, int>();

		// Token: 0x040054E1 RID: 21729
		public const int LockedPropertyValuesFieldNumber = 9;

		// Token: 0x040054E2 RID: 21730
		private static readonly MapField<int, int>.Codec _map_lockedPropertyValues_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 74U);

		// Token: 0x040054E3 RID: 21731
		private readonly MapField<int, int> lockedPropertyValues_ = new MapField<int, int>();
	}
}
