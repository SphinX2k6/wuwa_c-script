using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000980 RID: 2432
	[NetMessage(EMessageId.MapRemoveAllMarkRequest)]
	public sealed class MapRemoveAllMarkRequest : IMessage<MapRemoveAllMarkRequest>, IMessage, IEquatable<MapRemoveAllMarkRequest>, IDeepCloneable<MapRemoveAllMarkRequest>, IBufferMessage
	{
		// Token: 0x0600D624 RID: 54820 RVA: 0x001F8521 File Offset: 0x001F6721
		[NullableContext(1)]
		public static MapRemoveAllMarkRequest Create()
		{
			return new MapRemoveAllMarkRequest();
		}

		// Token: 0x17002B58 RID: 11096
		// (get) Token: 0x0600D625 RID: 54821 RVA: 0x001F8528 File Offset: 0x001F6728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B59 RID: 11097
		// (get) Token: 0x0600D626 RID: 54822 RVA: 0x001F852B File Offset: 0x001F672B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapRemoveAllMarkRequest.Descriptor;
			}
		}

		// Token: 0x0600D627 RID: 54823 RVA: 0x001F8532 File Offset: 0x001F6732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapRemoveAllMarkRequest()
		{
		}

		// Token: 0x0600D628 RID: 54824 RVA: 0x001F853A File Offset: 0x001F673A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapRemoveAllMarkRequest(MapRemoveAllMarkRequest other) : this()
		{
			this.markType_ = other.markType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D629 RID: 54825 RVA: 0x001F855F File Offset: 0x001F675F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapRemoveAllMarkRequest Clone()
		{
			return new MapRemoveAllMarkRequest(this);
		}

		// Token: 0x17002B5A RID: 11098
		// (get) Token: 0x0600D62A RID: 54826 RVA: 0x001F8567 File Offset: 0x001F6767
		// (set) Token: 0x0600D62B RID: 54827 RVA: 0x001F856F File Offset: 0x001F676F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkType
		{
			get
			{
				return this.markType_;
			}
			set
			{
				this.markType_ = value;
			}
		}

		// Token: 0x0600D62C RID: 54828 RVA: 0x001F8578 File Offset: 0x001F6778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapRemoveAllMarkRequest);
		}

		// Token: 0x0600D62D RID: 54829 RVA: 0x001F8586 File Offset: 0x001F6786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapRemoveAllMarkRequest other)
		{
			return other != null && (other == this || (this.MarkType == other.MarkType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D62E RID: 54830 RVA: 0x001F85B4 File Offset: 0x001F67B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MarkType != 0)
			{
				num ^= this.MarkType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D62F RID: 54831 RVA: 0x001F85F3 File Offset: 0x001F67F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D630 RID: 54832 RVA: 0x001F8600 File Offset: 0x001F6800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D631 RID: 54833 RVA: 0x001F8609 File Offset: 0x001F6809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MarkType != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.MarkType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D632 RID: 54834 RVA: 0x001F863C File Offset: 0x001F683C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MarkType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D633 RID: 54835 RVA: 0x001F867A File Offset: 0x001F687A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapRemoveAllMarkRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MarkType != 0)
			{
				this.MarkType = other.MarkType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D634 RID: 54836 RVA: 0x001F86AB File Offset: 0x001F68AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D635 RID: 54837 RVA: 0x001F86B4 File Offset: 0x001F68B4
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MarkType = input.ReadInt32();
				}
			}
		}

		// Token: 0x040059E8 RID: 23016
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059E9 RID: 23017
		public const int MarkTypeFieldNumber = 7;

		// Token: 0x040059EA RID: 23018
		private int markType_;
	}
}
