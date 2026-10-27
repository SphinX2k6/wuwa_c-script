using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200042D RID: 1069
	[NetMessage(EMessageId.ElementalAbilityUpdateNotify)]
	public sealed class ElementalAbilityUpdateNotify : IMessage<ElementalAbilityUpdateNotify>, IMessage, IEquatable<ElementalAbilityUpdateNotify>, IDeepCloneable<ElementalAbilityUpdateNotify>, IBufferMessage
	{
		// Token: 0x06006699 RID: 26265 RVA: 0x000F6AE3 File Offset: 0x000F4CE3
		[NullableContext(1)]
		public static ElementalAbilityUpdateNotify Create()
		{
			return new ElementalAbilityUpdateNotify();
		}

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x0600669A RID: 26266 RVA: 0x000F6AEA File Offset: 0x000F4CEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x0600669B RID: 26267 RVA: 0x000F6AED File Offset: 0x000F4CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ElementalAbilityUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600669C RID: 26268 RVA: 0x000F6AF4 File Offset: 0x000F4CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElementalAbilityUpdateNotify()
		{
		}

		// Token: 0x0600669D RID: 26269 RVA: 0x000F6B07 File Offset: 0x000F4D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElementalAbilityUpdateNotify(ElementalAbilityUpdateNotify other) : this()
		{
			this.entityIncId_ = other.entityIncId_;
			this.elementalType_ = other.elementalType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600669E RID: 26270 RVA: 0x000F6B38 File Offset: 0x000F4D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElementalAbilityUpdateNotify Clone()
		{
			return new ElementalAbilityUpdateNotify(this);
		}

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x0600669F RID: 26271 RVA: 0x000F6B40 File Offset: 0x000F4D40
		// (set) Token: 0x060066A0 RID: 26272 RVA: 0x000F6B48 File Offset: 0x000F4D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityIncId
		{
			get
			{
				return this.entityIncId_;
			}
			set
			{
				this.entityIncId_ = value;
			}
		}

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x060066A1 RID: 26273 RVA: 0x000F6B51 File Offset: 0x000F4D51
		// (set) Token: 0x060066A2 RID: 26274 RVA: 0x000F6B59 File Offset: 0x000F4D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ElementalType
		{
			get
			{
				return this.elementalType_;
			}
			set
			{
				this.elementalType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060066A3 RID: 26275 RVA: 0x000F6B6C File Offset: 0x000F4D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ElementalAbilityUpdateNotify);
		}

		// Token: 0x060066A4 RID: 26276 RVA: 0x000F6B7C File Offset: 0x000F4D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ElementalAbilityUpdateNotify other)
		{
			return other != null && (other == this || (this.EntityIncId == other.EntityIncId && !(this.ElementalType != other.ElementalType) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060066A5 RID: 26277 RVA: 0x000F6BCC File Offset: 0x000F4DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityIncId != 0L)
			{
				num ^= this.EntityIncId.GetHashCode();
			}
			if (this.ElementalType.Length != 0)
			{
				num ^= this.ElementalType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060066A6 RID: 26278 RVA: 0x000F6C26 File Offset: 0x000F4E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060066A7 RID: 26279 RVA: 0x000F6C33 File Offset: 0x000F4E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060066A8 RID: 26280 RVA: 0x000F6C3C File Offset: 0x000F4E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ElementalType.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.ElementalType);
			}
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060066A9 RID: 26281 RVA: 0x000F6C9C File Offset: 0x000F4E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityIncId);
			}
			if (this.ElementalType.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ElementalType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060066AA RID: 26282 RVA: 0x000F6CF8 File Offset: 0x000F4EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ElementalAbilityUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityIncId != 0L)
			{
				this.EntityIncId = other.EntityIncId;
			}
			if (other.ElementalType.Length != 0)
			{
				this.ElementalType = other.ElementalType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060066AB RID: 26283 RVA: 0x000F6D4D File Offset: 0x000F4F4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060066AC RID: 26284 RVA: 0x000F6D58 File Offset: 0x000F4F58
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
				if (num != 34U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityIncId = input.ReadInt64();
					}
				}
				else
				{
					this.ElementalType = input.ReadString();
				}
			}
		}

		// Token: 0x0400392D RID: 14637
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400392E RID: 14638
		public const int EntityIncIdFieldNumber = 15;

		// Token: 0x0400392F RID: 14639
		private long entityIncId_;

		// Token: 0x04003930 RID: 14640
		public const int ElementalTypeFieldNumber = 4;

		// Token: 0x04003931 RID: 14641
		private string elementalType_ = "";
	}
}
