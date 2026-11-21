using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008CD RID: 2253
	public sealed class KurotatoWeaponPanelPbData : IMessage<KurotatoWeaponPanelPbData>, IMessage, IEquatable<KurotatoWeaponPanelPbData>, IDeepCloneable<KurotatoWeaponPanelPbData>, IBufferMessage
	{
		// Token: 0x0600C7D2 RID: 51154 RVA: 0x001D8F78 File Offset: 0x001D7178
		[NullableContext(1)]
		public static KurotatoWeaponPanelPbData Create()
		{
			return new KurotatoWeaponPanelPbData();
		}

		// Token: 0x17002858 RID: 10328
		// (get) Token: 0x0600C7D3 RID: 51155 RVA: 0x001D8F7F File Offset: 0x001D717F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002859 RID: 10329
		// (get) Token: 0x0600C7D4 RID: 51156 RVA: 0x001D8F82 File Offset: 0x001D7182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoWeaponPanelPbData.Descriptor;
			}
		}

		// Token: 0x0600C7D5 RID: 51157 RVA: 0x001D8F89 File Offset: 0x001D7189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponPanelPbData()
		{
		}

		// Token: 0x0600C7D6 RID: 51158 RVA: 0x001D8F9C File Offset: 0x001D719C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponPanelPbData(KurotatoWeaponPanelPbData other) : this()
		{
			this.weaponPbDatas_ = other.weaponPbDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C7D7 RID: 51159 RVA: 0x001D8FC6 File Offset: 0x001D71C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponPanelPbData Clone()
		{
			return new KurotatoWeaponPanelPbData(this);
		}

		// Token: 0x1700285A RID: 10330
		// (get) Token: 0x0600C7D8 RID: 51160 RVA: 0x001D8FCE File Offset: 0x001D71CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KurotatoWeaponPbData> WeaponPbDatas
		{
			get
			{
				return this.weaponPbDatas_;
			}
		}

		// Token: 0x0600C7D9 RID: 51161 RVA: 0x001D8FD6 File Offset: 0x001D71D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoWeaponPanelPbData);
		}

		// Token: 0x0600C7DA RID: 51162 RVA: 0x001D8FE4 File Offset: 0x001D71E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoWeaponPanelPbData other)
		{
			return other != null && (other == this || (this.weaponPbDatas_.Equals(other.weaponPbDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C7DB RID: 51163 RVA: 0x001D9018 File Offset: 0x001D7218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.weaponPbDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C7DC RID: 51164 RVA: 0x001D904C File Offset: 0x001D724C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C7DD RID: 51165 RVA: 0x001D9059 File Offset: 0x001D7259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C7DE RID: 51166 RVA: 0x001D9062 File Offset: 0x001D7262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.weaponPbDatas_.WriteTo(ref output, KurotatoWeaponPanelPbData._repeated_weaponPbDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C7DF RID: 51167 RVA: 0x001D908C File Offset: 0x001D728C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.weaponPbDatas_.CalculateSize(KurotatoWeaponPanelPbData._repeated_weaponPbDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C7E0 RID: 51168 RVA: 0x001D90C5 File Offset: 0x001D72C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoWeaponPanelPbData other)
		{
			if (other == null)
			{
				return;
			}
			this.weaponPbDatas_.Add(other.weaponPbDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C7E1 RID: 51169 RVA: 0x001D90F3 File Offset: 0x001D72F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C7E2 RID: 51170 RVA: 0x001D90FC File Offset: 0x001D72FC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.weaponPbDatas_.AddEntriesFrom(ref input, KurotatoWeaponPanelPbData._repeated_weaponPbDatas_codec);
				}
			}
		}

		// Token: 0x040055D6 RID: 21974
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055D7 RID: 21975
		public const int WeaponPbDatasFieldNumber = 1;

		// Token: 0x040055D8 RID: 21976
		private static readonly FieldCodec<KurotatoWeaponPbData> _repeated_weaponPbDatas_codec = FieldCodec.ForMessage<KurotatoWeaponPbData>(10U, KurotatoWeaponPbData.Parser);

		// Token: 0x040055D9 RID: 21977
		private readonly RepeatedField<KurotatoWeaponPbData> weaponPbDatas_ = new RepeatedField<KurotatoWeaponPbData>();
	}
}
