using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200137C RID: 4988
	[NetMessage(EMessageId.SynthesisItemRequest)]
	public sealed class SynthesisItemRequest : IMessage<SynthesisItemRequest>, IMessage, IEquatable<SynthesisItemRequest>, IDeepCloneable<SynthesisItemRequest>, IBufferMessage
	{
		// Token: 0x0601A8EE RID: 108782 RVA: 0x003DE86E File Offset: 0x003DCA6E
		[NullableContext(1)]
		public static SynthesisItemRequest Create()
		{
			return new SynthesisItemRequest();
		}

		// Token: 0x170059E8 RID: 23016
		// (get) Token: 0x0601A8EF RID: 108783 RVA: 0x003DE875 File Offset: 0x003DCA75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059E9 RID: 23017
		// (get) Token: 0x0601A8F0 RID: 108784 RVA: 0x003DE878 File Offset: 0x003DCA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SynthesisItemRequest.Descriptor;
			}
		}

		// Token: 0x0601A8F1 RID: 108785 RVA: 0x003DE87F File Offset: 0x003DCA7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisItemRequest()
		{
		}

		// Token: 0x0601A8F2 RID: 108786 RVA: 0x003DE888 File Offset: 0x003DCA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisItemRequest(SynthesisItemRequest other) : this()
		{
			this.id_ = other.id_;
			this.roleId_ = other.roleId_;
			this.count_ = other.count_;
			this.interactEntityId_ = other.interactEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A8F3 RID: 108787 RVA: 0x003DE8DC File Offset: 0x003DCADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisItemRequest Clone()
		{
			return new SynthesisItemRequest(this);
		}

		// Token: 0x170059EA RID: 23018
		// (get) Token: 0x0601A8F4 RID: 108788 RVA: 0x003DE8E4 File Offset: 0x003DCAE4
		// (set) Token: 0x0601A8F5 RID: 108789 RVA: 0x003DE8EC File Offset: 0x003DCAEC
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

		// Token: 0x170059EB RID: 23019
		// (get) Token: 0x0601A8F6 RID: 108790 RVA: 0x003DE8F5 File Offset: 0x003DCAF5
		// (set) Token: 0x0601A8F7 RID: 108791 RVA: 0x003DE8FD File Offset: 0x003DCAFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x170059EC RID: 23020
		// (get) Token: 0x0601A8F8 RID: 108792 RVA: 0x003DE906 File Offset: 0x003DCB06
		// (set) Token: 0x0601A8F9 RID: 108793 RVA: 0x003DE90E File Offset: 0x003DCB0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x170059ED RID: 23021
		// (get) Token: 0x0601A8FA RID: 108794 RVA: 0x003DE917 File Offset: 0x003DCB17
		// (set) Token: 0x0601A8FB RID: 108795 RVA: 0x003DE91F File Offset: 0x003DCB1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long InteractEntityId
		{
			get
			{
				return this.interactEntityId_;
			}
			set
			{
				this.interactEntityId_ = value;
			}
		}

		// Token: 0x0601A8FC RID: 108796 RVA: 0x003DE928 File Offset: 0x003DCB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SynthesisItemRequest);
		}

		// Token: 0x0601A8FD RID: 108797 RVA: 0x003DE938 File Offset: 0x003DCB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SynthesisItemRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.RoleId == other.RoleId && this.Count == other.Count && this.InteractEntityId == other.InteractEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A8FE RID: 108798 RVA: 0x003DE9A4 File Offset: 0x003DCBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.InteractEntityId != 0L)
			{
				num ^= this.InteractEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A8FF RID: 108799 RVA: 0x003DEA2E File Offset: 0x003DCC2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A900 RID: 108800 RVA: 0x003DEA3B File Offset: 0x003DCC3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A901 RID: 108801 RVA: 0x003DEA44 File Offset: 0x003DCC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.RoleId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Count);
			}
			if (this.InteractEntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.InteractEntityId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A902 RID: 108802 RVA: 0x003DEAD8 File Offset: 0x003DCCD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.InteractEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InteractEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A903 RID: 108803 RVA: 0x003DEB60 File Offset: 0x003DCD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SynthesisItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.InteractEntityId != 0L)
			{
				this.InteractEntityId = other.InteractEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A904 RID: 108804 RVA: 0x003DEBD8 File Offset: 0x003DCDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A905 RID: 108805 RVA: 0x003DEBE4 File Offset: 0x003DCDE4
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
				if (num <= 96U)
				{
					if (num == 88U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.Count = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.InteractEntityId = input.ReadInt64();
						continue;
					}
					if (num == 112U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009BA9 RID: 39849
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BAA RID: 39850
		public const int IdFieldNumber = 14;

		// Token: 0x04009BAB RID: 39851
		private int id_;

		// Token: 0x04009BAC RID: 39852
		public const int RoleIdFieldNumber = 11;

		// Token: 0x04009BAD RID: 39853
		private int roleId_;

		// Token: 0x04009BAE RID: 39854
		public const int CountFieldNumber = 12;

		// Token: 0x04009BAF RID: 39855
		private int count_;

		// Token: 0x04009BB0 RID: 39856
		public const int InteractEntityIdFieldNumber = 13;

		// Token: 0x04009BB1 RID: 39857
		private long interactEntityId_;
	}
}
