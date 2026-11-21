using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200141C RID: 5148
	[NetMessage(EMessageId.TowerDefenceRandListRequest)]
	public sealed class TowerDefenceRandListRequest : IMessage<TowerDefenceRandListRequest>, IMessage, IEquatable<TowerDefenceRandListRequest>, IDeepCloneable<TowerDefenceRandListRequest>, IBufferMessage
	{
		// Token: 0x0601B5D2 RID: 112082 RVA: 0x003FAB64 File Offset: 0x003F8D64
		[NullableContext(1)]
		public static TowerDefenceRandListRequest Create()
		{
			return new TowerDefenceRandListRequest();
		}

		// Token: 0x17005CA3 RID: 23715
		// (get) Token: 0x0601B5D3 RID: 112083 RVA: 0x003FAB6B File Offset: 0x003F8D6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CA4 RID: 23716
		// (get) Token: 0x0601B5D4 RID: 112084 RVA: 0x003FAB6E File Offset: 0x003F8D6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceRandListRequest.Descriptor;
			}
		}

		// Token: 0x0601B5D5 RID: 112085 RVA: 0x003FAB75 File Offset: 0x003F8D75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRandListRequest()
		{
		}

		// Token: 0x0601B5D6 RID: 112086 RVA: 0x003FAB7D File Offset: 0x003F8D7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRandListRequest(TowerDefenceRandListRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B5D7 RID: 112087 RVA: 0x003FABA2 File Offset: 0x003F8DA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRandListRequest Clone()
		{
			return new TowerDefenceRandListRequest(this);
		}

		// Token: 0x17005CA5 RID: 23717
		// (get) Token: 0x0601B5D8 RID: 112088 RVA: 0x003FABAA File Offset: 0x003F8DAA
		// (set) Token: 0x0601B5D9 RID: 112089 RVA: 0x003FABB2 File Offset: 0x003F8DB2
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

		// Token: 0x0601B5DA RID: 112090 RVA: 0x003FABBB File Offset: 0x003F8DBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceRandListRequest);
		}

		// Token: 0x0601B5DB RID: 112091 RVA: 0x003FABC9 File Offset: 0x003F8DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceRandListRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B5DC RID: 112092 RVA: 0x003FABF8 File Offset: 0x003F8DF8
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

		// Token: 0x0601B5DD RID: 112093 RVA: 0x003FAC37 File Offset: 0x003F8E37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B5DE RID: 112094 RVA: 0x003FAC44 File Offset: 0x003F8E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B5DF RID: 112095 RVA: 0x003FAC4D File Offset: 0x003F8E4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B5E0 RID: 112096 RVA: 0x003FAC80 File Offset: 0x003F8E80
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

		// Token: 0x0601B5E1 RID: 112097 RVA: 0x003FACBE File Offset: 0x003F8EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceRandListRequest other)
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

		// Token: 0x0601B5E2 RID: 112098 RVA: 0x003FACEF File Offset: 0x003F8EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B5E3 RID: 112099 RVA: 0x003FACF8 File Offset: 0x003F8EF8
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009F62 RID: 40802
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F63 RID: 40803
		public const int IdFieldNumber = 15;

		// Token: 0x04009F64 RID: 40804
		private int id_;
	}
}
