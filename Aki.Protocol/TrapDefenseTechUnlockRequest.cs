using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014CB RID: 5323
	[NetMessage(EMessageId.TrapDefenseTechUnlockRequest)]
	public sealed class TrapDefenseTechUnlockRequest : IMessage<TrapDefenseTechUnlockRequest>, IMessage, IEquatable<TrapDefenseTechUnlockRequest>, IDeepCloneable<TrapDefenseTechUnlockRequest>, IBufferMessage
	{
		// Token: 0x0601C3CF RID: 115663 RVA: 0x00419474 File Offset: 0x00417674
		[NullableContext(1)]
		public static TrapDefenseTechUnlockRequest Create()
		{
			return new TrapDefenseTechUnlockRequest();
		}

		// Token: 0x17005F95 RID: 24469
		// (get) Token: 0x0601C3D0 RID: 115664 RVA: 0x0041947B File Offset: 0x0041767B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F96 RID: 24470
		// (get) Token: 0x0601C3D1 RID: 115665 RVA: 0x0041947E File Offset: 0x0041767E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseTechUnlockRequest.Descriptor;
			}
		}

		// Token: 0x0601C3D2 RID: 115666 RVA: 0x00419485 File Offset: 0x00417685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechUnlockRequest()
		{
		}

		// Token: 0x0601C3D3 RID: 115667 RVA: 0x0041948D File Offset: 0x0041768D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechUnlockRequest(TrapDefenseTechUnlockRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C3D4 RID: 115668 RVA: 0x004194B2 File Offset: 0x004176B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechUnlockRequest Clone()
		{
			return new TrapDefenseTechUnlockRequest(this);
		}

		// Token: 0x17005F97 RID: 24471
		// (get) Token: 0x0601C3D5 RID: 115669 RVA: 0x004194BA File Offset: 0x004176BA
		// (set) Token: 0x0601C3D6 RID: 115670 RVA: 0x004194C2 File Offset: 0x004176C2
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

		// Token: 0x0601C3D7 RID: 115671 RVA: 0x004194CB File Offset: 0x004176CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseTechUnlockRequest);
		}

		// Token: 0x0601C3D8 RID: 115672 RVA: 0x004194D9 File Offset: 0x004176D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseTechUnlockRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C3D9 RID: 115673 RVA: 0x00419508 File Offset: 0x00417708
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

		// Token: 0x0601C3DA RID: 115674 RVA: 0x00419547 File Offset: 0x00417747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C3DB RID: 115675 RVA: 0x00419554 File Offset: 0x00417754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C3DC RID: 115676 RVA: 0x0041955D File Offset: 0x0041775D
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

		// Token: 0x0601C3DD RID: 115677 RVA: 0x00419590 File Offset: 0x00417790
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

		// Token: 0x0601C3DE RID: 115678 RVA: 0x004195CE File Offset: 0x004177CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseTechUnlockRequest other)
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

		// Token: 0x0601C3DF RID: 115679 RVA: 0x004195FF File Offset: 0x004177FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C3E0 RID: 115680 RVA: 0x00419608 File Offset: 0x00417808
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

		// Token: 0x0400A346 RID: 41798
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A347 RID: 41799
		public const int IdFieldNumber = 9;

		// Token: 0x0400A348 RID: 41800
		private int id_;
	}
}
