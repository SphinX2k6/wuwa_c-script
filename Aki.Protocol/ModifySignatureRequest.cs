using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009EE RID: 2542
	[NetMessage(EMessageId.ModifySignatureRequest)]
	public sealed class ModifySignatureRequest : IMessage<ModifySignatureRequest>, IMessage, IEquatable<ModifySignatureRequest>, IDeepCloneable<ModifySignatureRequest>, IBufferMessage
	{
		// Token: 0x0600DEA7 RID: 56999 RVA: 0x0020A6ED File Offset: 0x002088ED
		[NullableContext(1)]
		public static ModifySignatureRequest Create()
		{
			return new ModifySignatureRequest();
		}

		// Token: 0x17002D21 RID: 11553
		// (get) Token: 0x0600DEA8 RID: 57000 RVA: 0x0020A6F4 File Offset: 0x002088F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D22 RID: 11554
		// (get) Token: 0x0600DEA9 RID: 57001 RVA: 0x0020A6F7 File Offset: 0x002088F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModifySignatureRequest.Descriptor;
			}
		}

		// Token: 0x0600DEAA RID: 57002 RVA: 0x0020A6FE File Offset: 0x002088FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifySignatureRequest()
		{
		}

		// Token: 0x0600DEAB RID: 57003 RVA: 0x0020A711 File Offset: 0x00208911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifySignatureRequest(ModifySignatureRequest other) : this()
		{
			this.signature_ = other.signature_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DEAC RID: 57004 RVA: 0x0020A736 File Offset: 0x00208936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifySignatureRequest Clone()
		{
			return new ModifySignatureRequest(this);
		}

		// Token: 0x17002D23 RID: 11555
		// (get) Token: 0x0600DEAD RID: 57005 RVA: 0x0020A73E File Offset: 0x0020893E
		// (set) Token: 0x0600DEAE RID: 57006 RVA: 0x0020A746 File Offset: 0x00208946
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

		// Token: 0x0600DEAF RID: 57007 RVA: 0x0020A759 File Offset: 0x00208959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModifySignatureRequest);
		}

		// Token: 0x0600DEB0 RID: 57008 RVA: 0x0020A767 File Offset: 0x00208967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ModifySignatureRequest other)
		{
			return other != null && (other == this || (!(this.Signature != other.Signature) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DEB1 RID: 57009 RVA: 0x0020A79C File Offset: 0x0020899C
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

		// Token: 0x0600DEB2 RID: 57010 RVA: 0x0020A7DD File Offset: 0x002089DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DEB3 RID: 57011 RVA: 0x0020A7EA File Offset: 0x002089EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DEB4 RID: 57012 RVA: 0x0020A7F3 File Offset: 0x002089F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Signature.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Signature);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DEB5 RID: 57013 RVA: 0x0020A82C File Offset: 0x00208A2C
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

		// Token: 0x0600DEB6 RID: 57014 RVA: 0x0020A86F File Offset: 0x00208A6F
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

		// Token: 0x0600DEB7 RID: 57015 RVA: 0x0020A8A5 File Offset: 0x00208AA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DEB8 RID: 57016 RVA: 0x0020A8B0 File Offset: 0x00208AB0
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Signature = input.ReadString();
				}
			}
		}

		// Token: 0x04005BE4 RID: 23524
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BE5 RID: 23525
		public const int SignatureFieldNumber = 6;

		// Token: 0x04005BE6 RID: 23526
		private string signature_ = "";
	}
}
