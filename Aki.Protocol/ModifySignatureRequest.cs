using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009DD RID: 2525
	[NetMessage(EMessageId.ModifySignatureRequest)]
	public sealed class ModifySignatureRequest : IMessage<ModifySignatureRequest>, IMessage, IEquatable<ModifySignatureRequest>, IDeepCloneable<ModifySignatureRequest>, IBufferMessage
	{
		// Token: 0x0600DD8D RID: 56717 RVA: 0x00208501 File Offset: 0x00206701
		[NullableContext(1)]
		public static ModifySignatureRequest Create()
		{
			return new ModifySignatureRequest();
		}

		// Token: 0x17002CE3 RID: 11491
		// (get) Token: 0x0600DD8E RID: 56718 RVA: 0x00208508 File Offset: 0x00206708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CE4 RID: 11492
		// (get) Token: 0x0600DD8F RID: 56719 RVA: 0x0020850B File Offset: 0x0020670B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModifySignatureRequest.Descriptor;
			}
		}

		// Token: 0x0600DD90 RID: 56720 RVA: 0x00208512 File Offset: 0x00206712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifySignatureRequest()
		{
		}

		// Token: 0x0600DD91 RID: 56721 RVA: 0x00208525 File Offset: 0x00206725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifySignatureRequest(ModifySignatureRequest other) : this()
		{
			this.signature_ = other.signature_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DD92 RID: 56722 RVA: 0x0020854A File Offset: 0x0020674A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifySignatureRequest Clone()
		{
			return new ModifySignatureRequest(this);
		}

		// Token: 0x17002CE5 RID: 11493
		// (get) Token: 0x0600DD93 RID: 56723 RVA: 0x00208552 File Offset: 0x00206752
		// (set) Token: 0x0600DD94 RID: 56724 RVA: 0x0020855A File Offset: 0x0020675A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Signature
		{
			get
			{
				return this.signature_;
			}
			set
			{
				this.signature_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600DD95 RID: 56725 RVA: 0x0020856D File Offset: 0x0020676D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModifySignatureRequest);
		}

		// Token: 0x0600DD96 RID: 56726 RVA: 0x0020857B File Offset: 0x0020677B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ModifySignatureRequest other)
		{
			return other != null && (other == this || (!(this.Signature != other.Signature) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DD97 RID: 56727 RVA: 0x002085B0 File Offset: 0x002067B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Signature.Length != 0)
			{
				num ^= this.Signature.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DD98 RID: 56728 RVA: 0x002085F1 File Offset: 0x002067F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DD99 RID: 56729 RVA: 0x002085FE File Offset: 0x002067FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DD9A RID: 56730 RVA: 0x00208607 File Offset: 0x00206807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Signature.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.Signature);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DD9B RID: 56731 RVA: 0x00208640 File Offset: 0x00206840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Signature.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Signature);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DD9C RID: 56732 RVA: 0x00208683 File Offset: 0x00206883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ModifySignatureRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Signature.Length != 0)
			{
				this.Signature = other.Signature;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DD9D RID: 56733 RVA: 0x002086B9 File Offset: 0x002068B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD9E RID: 56734 RVA: 0x002086C4 File Offset: 0x002068C4
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Signature = input.ReadString();
				}
			}
		}

		// Token: 0x04005BED RID: 23533
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BEE RID: 23534
		public const int SignatureFieldNumber = 14;

		// Token: 0x04005BEF RID: 23535
		private string signature_ = "";
	}
}
