using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200089A RID: 2202
	[NetMessage(EMessageId.KurotatoPropertyUpdateNotify)]
	public sealed class KurotatoPropertyUpdateNotify : IMessage<KurotatoPropertyUpdateNotify>, IMessage, IEquatable<KurotatoPropertyUpdateNotify>, IDeepCloneable<KurotatoPropertyUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600C3EE RID: 50158 RVA: 0x001D0BD2 File Offset: 0x001CEDD2
		[NullableContext(1)]
		public static KurotatoPropertyUpdateNotify Create()
		{
			return new KurotatoPropertyUpdateNotify();
		}

		// Token: 0x17002795 RID: 10133
		// (get) Token: 0x0600C3EF RID: 50159 RVA: 0x001D0BD9 File Offset: 0x001CEDD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002796 RID: 10134
		// (get) Token: 0x0600C3F0 RID: 50160 RVA: 0x001D0BDC File Offset: 0x001CEDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoPropertyUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600C3F1 RID: 50161 RVA: 0x001D0BE3 File Offset: 0x001CEDE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoPropertyUpdateNotify()
		{
		}

		// Token: 0x0600C3F2 RID: 50162 RVA: 0x001D0C01 File Offset: 0x001CEE01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoPropertyUpdateNotify(KurotatoPropertyUpdateNotify other) : this()
		{
			this.propertyValues_ = other.propertyValues_.Clone();
			this.lockedPropertyValues_ = other.lockedPropertyValues_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C3F3 RID: 50163 RVA: 0x001D0C3C File Offset: 0x001CEE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoPropertyUpdateNotify Clone()
		{
			return new KurotatoPropertyUpdateNotify(this);
		}

		// Token: 0x17002797 RID: 10135
		// (get) Token: 0x0600C3F4 RID: 50164 RVA: 0x001D0C44 File Offset: 0x001CEE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> PropertyValues
		{
			get
			{
				return this.propertyValues_;
			}
		}

		// Token: 0x17002798 RID: 10136
		// (get) Token: 0x0600C3F5 RID: 50165 RVA: 0x001D0C4C File Offset: 0x001CEE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> LockedPropertyValues
		{
			get
			{
				return this.lockedPropertyValues_;
			}
		}

		// Token: 0x0600C3F6 RID: 50166 RVA: 0x001D0C54 File Offset: 0x001CEE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoPropertyUpdateNotify);
		}

		// Token: 0x0600C3F7 RID: 50167 RVA: 0x001D0C64 File Offset: 0x001CEE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoPropertyUpdateNotify other)
		{
			return other != null && (other == this || (this.PropertyValues.Equals(other.PropertyValues) && this.LockedPropertyValues.Equals(other.LockedPropertyValues) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C3F8 RID: 50168 RVA: 0x001D0CB8 File Offset: 0x001CEEB8
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

		// Token: 0x0600C3F9 RID: 50169 RVA: 0x001D0CFA File Offset: 0x001CEEFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C3FA RID: 50170 RVA: 0x001D0D07 File Offset: 0x001CEF07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C3FB RID: 50171 RVA: 0x001D0D10 File Offset: 0x001CEF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lockedPropertyValues_.WriteTo(ref output, KurotatoPropertyUpdateNotify._map_lockedPropertyValues_codec);
			this.propertyValues_.WriteTo(ref output, KurotatoPropertyUpdateNotify._map_propertyValues_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C3FC RID: 50172 RVA: 0x001D0D48 File Offset: 0x001CEF48
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

		// Token: 0x0600C3FD RID: 50173 RVA: 0x001D0D94 File Offset: 0x001CEF94
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

		// Token: 0x0600C3FE RID: 50174 RVA: 0x001D0DD3 File Offset: 0x001CEFD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C3FF RID: 50175 RVA: 0x001D0DDC File Offset: 0x001CEFDC
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
				if (num != 26U)
				{
					if (num != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.propertyValues_.AddEntriesFrom(ref input, KurotatoPropertyUpdateNotify._map_propertyValues_codec);
					}
				}
				else
				{
					this.lockedPropertyValues_.AddEntriesFrom(ref input, KurotatoPropertyUpdateNotify._map_lockedPropertyValues_codec);
				}
			}
		}

		// Token: 0x040054E4 RID: 21732
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054E5 RID: 21733
		public const int PropertyValuesFieldNumber = 4;

		// Token: 0x040054E6 RID: 21734
		private static readonly MapField<int, int>.Codec _map_propertyValues_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 34U);

		// Token: 0x040054E7 RID: 21735
		private readonly MapField<int, int> propertyValues_ = new MapField<int, int>();

		// Token: 0x040054E8 RID: 21736
		public const int LockedPropertyValuesFieldNumber = 3;

		// Token: 0x040054E9 RID: 21737
		private static readonly MapField<int, int>.Codec _map_lockedPropertyValues_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 26U);

		// Token: 0x040054EA RID: 21738
		private readonly MapField<int, int> lockedPropertyValues_ = new MapField<int, int>();
	}
}
