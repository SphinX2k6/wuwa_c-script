using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200089F RID: 2207
	[NetMessage(EMessageId.KurotatoRefineWeaponRequest)]
	public sealed class KurotatoRefineWeaponRequest : IMessage<KurotatoRefineWeaponRequest>, IMessage, IEquatable<KurotatoRefineWeaponRequest>, IDeepCloneable<KurotatoRefineWeaponRequest>, IBufferMessage
	{
		// Token: 0x0600C44D RID: 50253 RVA: 0x001D1764 File Offset: 0x001CF964
		[NullableContext(1)]
		public static KurotatoRefineWeaponRequest Create()
		{
			return new KurotatoRefineWeaponRequest();
		}

		// Token: 0x170027A7 RID: 10151
		// (get) Token: 0x0600C44E RID: 50254 RVA: 0x001D176B File Offset: 0x001CF96B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027A8 RID: 10152
		// (get) Token: 0x0600C44F RID: 50255 RVA: 0x001D176E File Offset: 0x001CF96E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoRefineWeaponRequest.Descriptor;
			}
		}

		// Token: 0x0600C450 RID: 50256 RVA: 0x001D1775 File Offset: 0x001CF975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRefineWeaponRequest()
		{
		}

		// Token: 0x0600C451 RID: 50257 RVA: 0x001D177D File Offset: 0x001CF97D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRefineWeaponRequest(KurotatoRefineWeaponRequest other) : this()
		{
			this.weaponIncId_ = other.weaponIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C452 RID: 50258 RVA: 0x001D17A2 File Offset: 0x001CF9A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRefineWeaponRequest Clone()
		{
			return new KurotatoRefineWeaponRequest(this);
		}

		// Token: 0x170027A9 RID: 10153
		// (get) Token: 0x0600C453 RID: 50259 RVA: 0x001D17AA File Offset: 0x001CF9AA
		// (set) Token: 0x0600C454 RID: 50260 RVA: 0x001D17B2 File Offset: 0x001CF9B2
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

		// Token: 0x0600C455 RID: 50261 RVA: 0x001D17BB File Offset: 0x001CF9BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoRefineWeaponRequest);
		}

		// Token: 0x0600C456 RID: 50262 RVA: 0x001D17C9 File Offset: 0x001CF9C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoRefineWeaponRequest other)
		{
			return other != null && (other == this || (this.WeaponIncId == other.WeaponIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C457 RID: 50263 RVA: 0x001D17F8 File Offset: 0x001CF9F8
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

		// Token: 0x0600C458 RID: 50264 RVA: 0x001D1837 File Offset: 0x001CFA37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C459 RID: 50265 RVA: 0x001D1844 File Offset: 0x001CFA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C45A RID: 50266 RVA: 0x001D184D File Offset: 0x001CFA4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeaponIncId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.WeaponIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C45B RID: 50267 RVA: 0x001D1880 File Offset: 0x001CFA80
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

		// Token: 0x0600C45C RID: 50268 RVA: 0x001D18BE File Offset: 0x001CFABE
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

		// Token: 0x0600C45D RID: 50269 RVA: 0x001D18EF File Offset: 0x001CFAEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C45E RID: 50270 RVA: 0x001D18F8 File Offset: 0x001CFAF8
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.WeaponIncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040054FC RID: 21756
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054FD RID: 21757
		public const int WeaponIncIdFieldNumber = 9;

		// Token: 0x040054FE RID: 21758
		private int weaponIncId_;
	}
}
