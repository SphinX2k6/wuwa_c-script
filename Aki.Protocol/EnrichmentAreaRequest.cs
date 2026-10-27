using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000449 RID: 1097
	[NetMessage(EMessageId.EnrichmentAreaRequest)]
	public sealed class EnrichmentAreaRequest : IMessage<EnrichmentAreaRequest>, IMessage, IEquatable<EnrichmentAreaRequest>, IDeepCloneable<EnrichmentAreaRequest>, IBufferMessage
	{
		// Token: 0x060068E5 RID: 26853 RVA: 0x000FBDAD File Offset: 0x000F9FAD
		[NullableContext(1)]
		public static EnrichmentAreaRequest Create()
		{
			return new EnrichmentAreaRequest();
		}

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x060068E6 RID: 26854 RVA: 0x000FBDB4 File Offset: 0x000F9FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x060068E7 RID: 26855 RVA: 0x000FBDB7 File Offset: 0x000F9FB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnrichmentAreaRequest.Descriptor;
			}
		}

		// Token: 0x060068E8 RID: 26856 RVA: 0x000FBDBE File Offset: 0x000F9FBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnrichmentAreaRequest()
		{
		}

		// Token: 0x060068E9 RID: 26857 RVA: 0x000FBDC6 File Offset: 0x000F9FC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnrichmentAreaRequest(EnrichmentAreaRequest other) : this()
		{
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060068EA RID: 26858 RVA: 0x000FBDEB File Offset: 0x000F9FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnrichmentAreaRequest Clone()
		{
			return new EnrichmentAreaRequest(this);
		}

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x060068EB RID: 26859 RVA: 0x000FBDF3 File Offset: 0x000F9FF3
		// (set) Token: 0x060068EC RID: 26860 RVA: 0x000FBDFB File Offset: 0x000F9FFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x060068ED RID: 26861 RVA: 0x000FBE04 File Offset: 0x000FA004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnrichmentAreaRequest);
		}

		// Token: 0x060068EE RID: 26862 RVA: 0x000FBE12 File Offset: 0x000FA012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnrichmentAreaRequest other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060068EF RID: 26863 RVA: 0x000FBE40 File Offset: 0x000FA040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060068F0 RID: 26864 RVA: 0x000FBE7F File Offset: 0x000FA07F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060068F1 RID: 26865 RVA: 0x000FBE8C File Offset: 0x000FA08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060068F2 RID: 26866 RVA: 0x000FBE95 File Offset: 0x000FA095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060068F3 RID: 26867 RVA: 0x000FBEC8 File Offset: 0x000FA0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060068F4 RID: 26868 RVA: 0x000FBF06 File Offset: 0x000FA106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnrichmentAreaRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060068F5 RID: 26869 RVA: 0x000FBF37 File Offset: 0x000FA137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060068F6 RID: 26870 RVA: 0x000FBF40 File Offset: 0x000FA140
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
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040039D6 RID: 14806
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039D7 RID: 14807
		public const int ItemIdFieldNumber = 10;

		// Token: 0x040039D8 RID: 14808
		private int itemId_;
	}
}
