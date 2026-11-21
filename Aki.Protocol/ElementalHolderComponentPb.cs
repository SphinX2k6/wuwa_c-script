using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000417 RID: 1047
	public sealed class ElementalHolderComponentPb : IMessage<ElementalHolderComponentPb>, IMessage, IEquatable<ElementalHolderComponentPb>, IDeepCloneable<ElementalHolderComponentPb>, IBufferMessage
	{
		// Token: 0x0600651D RID: 25885 RVA: 0x000F3C3C File Offset: 0x000F1E3C
		[NullableContext(1)]
		public static ElementalHolderComponentPb Create()
		{
			return new ElementalHolderComponentPb();
		}

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x0600651E RID: 25886 RVA: 0x000F3C43 File Offset: 0x000F1E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x0600651F RID: 25887 RVA: 0x000F3C46 File Offset: 0x000F1E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ElementalHolderComponentPb.Descriptor;
			}
		}

		// Token: 0x06006520 RID: 25888 RVA: 0x000F3C4D File Offset: 0x000F1E4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElementalHolderComponentPb()
		{
		}

		// Token: 0x06006521 RID: 25889 RVA: 0x000F3C55 File Offset: 0x000F1E55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElementalHolderComponentPb(ElementalHolderComponentPb other) : this()
		{
			this.enable_ = other.enable_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006522 RID: 25890 RVA: 0x000F3C7A File Offset: 0x000F1E7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElementalHolderComponentPb Clone()
		{
			return new ElementalHolderComponentPb(this);
		}

		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x06006523 RID: 25891 RVA: 0x000F3C82 File Offset: 0x000F1E82
		// (set) Token: 0x06006524 RID: 25892 RVA: 0x000F3C8A File Offset: 0x000F1E8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Enable
		{
			get
			{
				return this.enable_;
			}
			set
			{
				this.enable_ = value;
			}
		}

		// Token: 0x06006525 RID: 25893 RVA: 0x000F3C93 File Offset: 0x000F1E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ElementalHolderComponentPb);
		}

		// Token: 0x06006526 RID: 25894 RVA: 0x000F3CA1 File Offset: 0x000F1EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ElementalHolderComponentPb other)
		{
			return other != null && (other == this || (this.Enable == other.Enable && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006527 RID: 25895 RVA: 0x000F3CD0 File Offset: 0x000F1ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Enable)
			{
				num ^= this.Enable.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006528 RID: 25896 RVA: 0x000F3D0F File Offset: 0x000F1F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006529 RID: 25897 RVA: 0x000F3D1C File Offset: 0x000F1F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600652A RID: 25898 RVA: 0x000F3D25 File Offset: 0x000F1F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Enable)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Enable);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600652B RID: 25899 RVA: 0x000F3D58 File Offset: 0x000F1F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Enable)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600652C RID: 25900 RVA: 0x000F3D8A File Offset: 0x000F1F8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ElementalHolderComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Enable)
			{
				this.Enable = other.Enable;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600652D RID: 25901 RVA: 0x000F3DBB File Offset: 0x000F1FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600652E RID: 25902 RVA: 0x000F3DC4 File Offset: 0x000F1FC4
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Enable = input.ReadBool();
				}
			}
		}

		// Token: 0x0400391F RID: 14623
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003920 RID: 14624
		public const int EnableFieldNumber = 1;

		// Token: 0x04003921 RID: 14625
		private bool enable_;
	}
}
