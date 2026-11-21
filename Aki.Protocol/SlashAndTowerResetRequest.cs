using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200128B RID: 4747
	[NetMessage(EMessageId.SlashAndTowerResetRequest)]
	public sealed class SlashAndTowerResetRequest : IMessage<SlashAndTowerResetRequest>, IMessage, IEquatable<SlashAndTowerResetRequest>, IDeepCloneable<SlashAndTowerResetRequest>, IBufferMessage
	{
		// Token: 0x06019565 RID: 103781 RVA: 0x003B1F44 File Offset: 0x003B0144
		[NullableContext(1)]
		public static SlashAndTowerResetRequest Create()
		{
			return new SlashAndTowerResetRequest();
		}

		// Token: 0x170055B1 RID: 21937
		// (get) Token: 0x06019566 RID: 103782 RVA: 0x003B1F4B File Offset: 0x003B014B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055B2 RID: 21938
		// (get) Token: 0x06019567 RID: 103783 RVA: 0x003B1F4E File Offset: 0x003B014E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerResetRequest.Descriptor;
			}
		}

		// Token: 0x06019568 RID: 103784 RVA: 0x003B1F55 File Offset: 0x003B0155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerResetRequest()
		{
		}

		// Token: 0x06019569 RID: 103785 RVA: 0x003B1F5D File Offset: 0x003B015D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerResetRequest(SlashAndTowerResetRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601956A RID: 103786 RVA: 0x003B1F82 File Offset: 0x003B0182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerResetRequest Clone()
		{
			return new SlashAndTowerResetRequest(this);
		}

		// Token: 0x170055B3 RID: 21939
		// (get) Token: 0x0601956B RID: 103787 RVA: 0x003B1F8A File Offset: 0x003B018A
		// (set) Token: 0x0601956C RID: 103788 RVA: 0x003B1F92 File Offset: 0x003B0192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0601956D RID: 103789 RVA: 0x003B1F9B File Offset: 0x003B019B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerResetRequest);
		}

		// Token: 0x0601956E RID: 103790 RVA: 0x003B1FA9 File Offset: 0x003B01A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerResetRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601956F RID: 103791 RVA: 0x003B1FD8 File Offset: 0x003B01D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019570 RID: 103792 RVA: 0x003B2017 File Offset: 0x003B0217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019571 RID: 103793 RVA: 0x003B2024 File Offset: 0x003B0224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019572 RID: 103794 RVA: 0x003B202D File Offset: 0x003B022D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019573 RID: 103795 RVA: 0x003B2060 File Offset: 0x003B0260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019574 RID: 103796 RVA: 0x003B209E File Offset: 0x003B029E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashAndTowerResetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019575 RID: 103797 RVA: 0x003B20CF File Offset: 0x003B02CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019576 RID: 103798 RVA: 0x003B20D8 File Offset: 0x003B02D8
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
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040095E0 RID: 38368
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095E1 RID: 38369
		public const int IdFieldNumber = 9;

		// Token: 0x040095E2 RID: 38370
		private int id_;
	}
}
