using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008DE RID: 2270
	public sealed class KurotatoWeaponPanelPbData : IMessage<KurotatoWeaponPanelPbData>, IMessage, IEquatable<KurotatoWeaponPanelPbData>, IDeepCloneable<KurotatoWeaponPanelPbData>, IBufferMessage
	{
		// Token: 0x0600C8EE RID: 51438 RVA: 0x001DB254 File Offset: 0x001D9454
		[NullableContext(1)]
		public static KurotatoWeaponPanelPbData Create()
		{
			return new KurotatoWeaponPanelPbData();
		}

		// Token: 0x17002897 RID: 10391
		// (get) Token: 0x0600C8EF RID: 51439 RVA: 0x001DB25B File Offset: 0x001D945B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002898 RID: 10392
		// (get) Token: 0x0600C8F0 RID: 51440 RVA: 0x001DB25E File Offset: 0x001D945E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoWeaponPanelPbData.Descriptor;
			}
		}

		// Token: 0x0600C8F1 RID: 51441 RVA: 0x001DB265 File Offset: 0x001D9465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponPanelPbData()
		{
		}

		// Token: 0x0600C8F2 RID: 51442 RVA: 0x001DB278 File Offset: 0x001D9478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponPanelPbData(KurotatoWeaponPanelPbData other) : this()
		{
			this.weaponPbDatas_ = other.weaponPbDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C8F3 RID: 51443 RVA: 0x001DB2A2 File Offset: 0x001D94A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponPanelPbData Clone()
		{
			return new KurotatoWeaponPanelPbData(this);
		}

		// Token: 0x17002899 RID: 10393
		// (get) Token: 0x0600C8F4 RID: 51444 RVA: 0x001DB2AA File Offset: 0x001D94AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KurotatoWeaponPbData> WeaponPbDatas
		{
			get
			{
				return this.weaponPbDatas_;
			}
		}

		// Token: 0x0600C8F5 RID: 51445 RVA: 0x001DB2B2 File Offset: 0x001D94B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoWeaponPanelPbData);
		}

		// Token: 0x0600C8F6 RID: 51446 RVA: 0x001DB2C0 File Offset: 0x001D94C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoWeaponPanelPbData other)
		{
			return other != null && (other == this || (this.weaponPbDatas_.Equals(other.weaponPbDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C8F7 RID: 51447 RVA: 0x001DB2F4 File Offset: 0x001D94F4
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

		// Token: 0x0600C8F8 RID: 51448 RVA: 0x001DB328 File Offset: 0x001D9528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C8F9 RID: 51449 RVA: 0x001DB335 File Offset: 0x001D9535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C8FA RID: 51450 RVA: 0x001DB33E File Offset: 0x001D953E
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

		// Token: 0x0600C8FB RID: 51451 RVA: 0x001DB368 File Offset: 0x001D9568
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

		// Token: 0x0600C8FC RID: 51452 RVA: 0x001DB3A1 File Offset: 0x001D95A1
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

		// Token: 0x0600C8FD RID: 51453 RVA: 0x001DB3CF File Offset: 0x001D95CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C8FE RID: 51454 RVA: 0x001DB3D8 File Offset: 0x001D95D8
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

		// Token: 0x040055CF RID: 21967
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055D0 RID: 21968
		public const int WeaponPbDatasFieldNumber = 1;

		// Token: 0x040055D1 RID: 21969
		private static readonly FieldCodec<KurotatoWeaponPbData> _repeated_weaponPbDatas_codec = FieldCodec.ForMessage<KurotatoWeaponPbData>(10U, KurotatoWeaponPbData.Parser);

		// Token: 0x040055D2 RID: 21970
		private readonly RepeatedField<KurotatoWeaponPbData> weaponPbDatas_ = new RepeatedField<KurotatoWeaponPbData>();
	}
}
