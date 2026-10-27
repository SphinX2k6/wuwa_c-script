using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000255 RID: 597
	[NetMessage(EMessageId.ChangePhantomEquipGroupNameRequest)]
	public sealed class ChangePhantomEquipGroupNameRequest : IMessage<ChangePhantomEquipGroupNameRequest>, IMessage, IEquatable<ChangePhantomEquipGroupNameRequest>, IDeepCloneable<ChangePhantomEquipGroupNameRequest>, IBufferMessage
	{
		// Token: 0x06003F81 RID: 16257 RVA: 0x0009C381 File Offset: 0x0009A581
		[NullableContext(1)]
		public static ChangePhantomEquipGroupNameRequest Create()
		{
			return new ChangePhantomEquipGroupNameRequest();
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06003F82 RID: 16258 RVA: 0x0009C388 File Offset: 0x0009A588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06003F83 RID: 16259 RVA: 0x0009C38B File Offset: 0x0009A58B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangePhantomEquipGroupNameRequest.Descriptor;
			}
		}

		// Token: 0x06003F84 RID: 16260 RVA: 0x0009C392 File Offset: 0x0009A592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePhantomEquipGroupNameRequest()
		{
		}

		// Token: 0x06003F85 RID: 16261 RVA: 0x0009C3A5 File Offset: 0x0009A5A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePhantomEquipGroupNameRequest(ChangePhantomEquipGroupNameRequest other) : this()
		{
			this.index_ = other.index_;
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F86 RID: 16262 RVA: 0x0009C3D6 File Offset: 0x0009A5D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePhantomEquipGroupNameRequest Clone()
		{
			return new ChangePhantomEquipGroupNameRequest(this);
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06003F87 RID: 16263 RVA: 0x0009C3DE File Offset: 0x0009A5DE
		// (set) Token: 0x06003F88 RID: 16264 RVA: 0x0009C3E6 File Offset: 0x0009A5E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06003F89 RID: 16265 RVA: 0x0009C3EF File Offset: 0x0009A5EF
		// (set) Token: 0x06003F8A RID: 16266 RVA: 0x0009C3F7 File Offset: 0x0009A5F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06003F8B RID: 16267 RVA: 0x0009C40A File Offset: 0x0009A60A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangePhantomEquipGroupNameRequest);
		}

		// Token: 0x06003F8C RID: 16268 RVA: 0x0009C418 File Offset: 0x0009A618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangePhantomEquipGroupNameRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003F8D RID: 16269 RVA: 0x0009C468 File Offset: 0x0009A668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003F8E RID: 16270 RVA: 0x0009C4C2 File Offset: 0x0009A6C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003F8F RID: 16271 RVA: 0x0009C4CF File Offset: 0x0009A6CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F90 RID: 16272 RVA: 0x0009C4D8 File Offset: 0x0009A6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Index);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F91 RID: 16273 RVA: 0x0009C538 File Offset: 0x0009A738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x0009C594 File Offset: 0x0009A794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangePhantomEquipGroupNameRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x0009C5E9 File Offset: 0x0009A7E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F94 RID: 16276 RVA: 0x0009C5F4 File Offset: 0x0009A7F4
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
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002D23 RID: 11555
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D24 RID: 11556
		public const int IndexFieldNumber = 7;

		// Token: 0x04002D25 RID: 11557
		private int index_;

		// Token: 0x04002D26 RID: 11558
		public const int NameFieldNumber = 10;

		// Token: 0x04002D27 RID: 11559
		private string name_ = "";
	}
}
