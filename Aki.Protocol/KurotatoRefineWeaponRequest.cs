using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008B0 RID: 2224
	[NetMessage(EMessageId.KurotatoRefineWeaponRequest)]
	public sealed class KurotatoRefineWeaponRequest : IMessage<KurotatoRefineWeaponRequest>, IMessage, IEquatable<KurotatoRefineWeaponRequest>, IDeepCloneable<KurotatoRefineWeaponRequest>, IBufferMessage
	{
		// Token: 0x0600C569 RID: 50537 RVA: 0x001D3A48 File Offset: 0x001D1C48
		[NullableContext(1)]
		public static KurotatoRefineWeaponRequest Create()
		{
			return new KurotatoRefineWeaponRequest();
		}

		// Token: 0x170027E6 RID: 10214
		// (get) Token: 0x0600C56A RID: 50538 RVA: 0x001D3A4F File Offset: 0x001D1C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027E7 RID: 10215
		// (get) Token: 0x0600C56B RID: 50539 RVA: 0x001D3A52 File Offset: 0x001D1C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoRefineWeaponRequest.Descriptor;
			}
		}

		// Token: 0x0600C56C RID: 50540 RVA: 0x001D3A59 File Offset: 0x001D1C59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRefineWeaponRequest()
		{
		}

		// Token: 0x0600C56D RID: 50541 RVA: 0x001D3A61 File Offset: 0x001D1C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRefineWeaponRequest(KurotatoRefineWeaponRequest other) : this()
		{
			this.weaponIncId_ = other.weaponIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C56E RID: 50542 RVA: 0x001D3A86 File Offset: 0x001D1C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRefineWeaponRequest Clone()
		{
			return new KurotatoRefineWeaponRequest(this);
		}

		// Token: 0x170027E8 RID: 10216
		// (get) Token: 0x0600C56F RID: 50543 RVA: 0x001D3A8E File Offset: 0x001D1C8E
		// (set) Token: 0x0600C570 RID: 50544 RVA: 0x001D3A96 File Offset: 0x001D1C96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponIncId
		{
			get
			{
				return this.weaponIncId_;
			}
			set
			{
				this.weaponIncId_ = value;
			}
		}

		// Token: 0x0600C571 RID: 50545 RVA: 0x001D3A9F File Offset: 0x001D1C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoRefineWeaponRequest);
		}

		// Token: 0x0600C572 RID: 50546 RVA: 0x001D3AAD File Offset: 0x001D1CAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoRefineWeaponRequest other)
		{
			return other != null && (other == this || (this.WeaponIncId == other.WeaponIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C573 RID: 50547 RVA: 0x001D3ADC File Offset: 0x001D1CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeaponIncId != 0)
			{
				num ^= this.WeaponIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C574 RID: 50548 RVA: 0x001D3B1B File Offset: 0x001D1D1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C575 RID: 50549 RVA: 0x001D3B28 File Offset: 0x001D1D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C576 RID: 50550 RVA: 0x001D3B31 File Offset: 0x001D1D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeaponIncId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.WeaponIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C577 RID: 50551 RVA: 0x001D3B64 File Offset: 0x001D1D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeaponIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C578 RID: 50552 RVA: 0x001D3BA2 File Offset: 0x001D1DA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoRefineWeaponRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeaponIncId != 0)
			{
				this.WeaponIncId = other.WeaponIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C579 RID: 50553 RVA: 0x001D3BD3 File Offset: 0x001D1DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C57A RID: 50554 RVA: 0x001D3BDC File Offset: 0x001D1DDC
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.WeaponIncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040054F5 RID: 21749
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054F6 RID: 21750
		public const int WeaponIncIdFieldNumber = 13;

		// Token: 0x040054F7 RID: 21751
		private int weaponIncId_;
	}
}
