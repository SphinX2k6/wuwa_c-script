using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003E0 RID: 992
	[NetMessage(EMessageId.DiscardWeaponResponse)]
	public sealed class DiscardWeaponResponse : IMessage<DiscardWeaponResponse>, IMessage, IEquatable<DiscardWeaponResponse>, IDeepCloneable<DiscardWeaponResponse>, IBufferMessage
	{
		// Token: 0x0600607B RID: 24699 RVA: 0x000E94B3 File Offset: 0x000E76B3
		[NullableContext(1)]
		public static DiscardWeaponResponse Create()
		{
			return new DiscardWeaponResponse();
		}

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x0600607C RID: 24700 RVA: 0x000E94BA File Offset: 0x000E76BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x0600607D RID: 24701 RVA: 0x000E94BD File Offset: 0x000E76BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DiscardWeaponResponse.Descriptor;
			}
		}

		// Token: 0x0600607E RID: 24702 RVA: 0x000E94C4 File Offset: 0x000E76C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscardWeaponResponse()
		{
		}

		// Token: 0x0600607F RID: 24703 RVA: 0x000E94CC File Offset: 0x000E76CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscardWeaponResponse(DiscardWeaponResponse other) : this()
		{
			this.discardSucc_ = other.discardSucc_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006080 RID: 24704 RVA: 0x000E94F1 File Offset: 0x000E76F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscardWeaponResponse Clone()
		{
			return new DiscardWeaponResponse(this);
		}

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x06006081 RID: 24705 RVA: 0x000E94F9 File Offset: 0x000E76F9
		// (set) Token: 0x06006082 RID: 24706 RVA: 0x000E9501 File Offset: 0x000E7701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DiscardSucc
		{
			get
			{
				return this.discardSucc_;
			}
			set
			{
				this.discardSucc_ = value;
			}
		}

		// Token: 0x06006083 RID: 24707 RVA: 0x000E950A File Offset: 0x000E770A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DiscardWeaponResponse);
		}

		// Token: 0x06006084 RID: 24708 RVA: 0x000E9518 File Offset: 0x000E7718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DiscardWeaponResponse other)
		{
			return other != null && (other == this || (this.DiscardSucc == other.DiscardSucc && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006085 RID: 24709 RVA: 0x000E9548 File Offset: 0x000E7748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DiscardSucc)
			{
				num ^= this.DiscardSucc.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006086 RID: 24710 RVA: 0x000E9587 File Offset: 0x000E7787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006087 RID: 24711 RVA: 0x000E9594 File Offset: 0x000E7794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006088 RID: 24712 RVA: 0x000E959D File Offset: 0x000E779D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DiscardSucc)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.DiscardSucc);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006089 RID: 24713 RVA: 0x000E95D0 File Offset: 0x000E77D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DiscardSucc)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600608A RID: 24714 RVA: 0x000E9602 File Offset: 0x000E7802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DiscardWeaponResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DiscardSucc)
			{
				this.DiscardSucc = other.DiscardSucc;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600608B RID: 24715 RVA: 0x000E9633 File Offset: 0x000E7833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600608C RID: 24716 RVA: 0x000E963C File Offset: 0x000E783C
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
					this.DiscardSucc = input.ReadBool();
				}
			}
		}

		// Token: 0x04003764 RID: 14180
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003765 RID: 14181
		public const int DiscardSuccFieldNumber = 9;

		// Token: 0x04003766 RID: 14182
		private bool discardSucc_;
	}
}
