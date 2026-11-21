using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003C9 RID: 969
	[NetMessage(EMessageId.DiscardWeaponResponse)]
	public sealed class DiscardWeaponResponse : IMessage<DiscardWeaponResponse>, IMessage, IEquatable<DiscardWeaponResponse>, IDeepCloneable<DiscardWeaponResponse>, IBufferMessage
	{
		// Token: 0x06005EEB RID: 24299 RVA: 0x000E6333 File Offset: 0x000E4533
		[NullableContext(1)]
		public static DiscardWeaponResponse Create()
		{
			return new DiscardWeaponResponse();
		}

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x06005EEC RID: 24300 RVA: 0x000E633A File Offset: 0x000E453A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x06005EED RID: 24301 RVA: 0x000E633D File Offset: 0x000E453D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DiscardWeaponResponse.Descriptor;
			}
		}

		// Token: 0x06005EEE RID: 24302 RVA: 0x000E6344 File Offset: 0x000E4544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscardWeaponResponse()
		{
		}

		// Token: 0x06005EEF RID: 24303 RVA: 0x000E634C File Offset: 0x000E454C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscardWeaponResponse(DiscardWeaponResponse other) : this()
		{
			this.discardSucc_ = other.discardSucc_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005EF0 RID: 24304 RVA: 0x000E6371 File Offset: 0x000E4571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscardWeaponResponse Clone()
		{
			return new DiscardWeaponResponse(this);
		}

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x06005EF1 RID: 24305 RVA: 0x000E6379 File Offset: 0x000E4579
		// (set) Token: 0x06005EF2 RID: 24306 RVA: 0x000E6381 File Offset: 0x000E4581
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

		// Token: 0x06005EF3 RID: 24307 RVA: 0x000E638A File Offset: 0x000E458A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DiscardWeaponResponse);
		}

		// Token: 0x06005EF4 RID: 24308 RVA: 0x000E6398 File Offset: 0x000E4598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DiscardWeaponResponse other)
		{
			return other != null && (other == this || (this.DiscardSucc == other.DiscardSucc && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005EF5 RID: 24309 RVA: 0x000E63C8 File Offset: 0x000E45C8
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

		// Token: 0x06005EF6 RID: 24310 RVA: 0x000E6407 File Offset: 0x000E4607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005EF7 RID: 24311 RVA: 0x000E6414 File Offset: 0x000E4614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005EF8 RID: 24312 RVA: 0x000E641D File Offset: 0x000E461D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DiscardSucc)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.DiscardSucc);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005EF9 RID: 24313 RVA: 0x000E6450 File Offset: 0x000E4650
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

		// Token: 0x06005EFA RID: 24314 RVA: 0x000E6482 File Offset: 0x000E4682
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

		// Token: 0x06005EFB RID: 24315 RVA: 0x000E64B3 File Offset: 0x000E46B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005EFC RID: 24316 RVA: 0x000E64BC File Offset: 0x000E46BC
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DiscardSucc = input.ReadBool();
				}
			}
		}

		// Token: 0x04003751 RID: 14161
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003752 RID: 14162
		public const int DiscardSuccFieldNumber = 10;

		// Token: 0x04003753 RID: 14163
		private bool discardSucc_;
	}
}
