using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009DB RID: 2523
	[NetMessage(EMessageId.ModifyNameRequest)]
	public sealed class ModifyNameRequest : IMessage<ModifyNameRequest>, IMessage, IEquatable<ModifyNameRequest>, IDeepCloneable<ModifyNameRequest>, IBufferMessage
	{
		// Token: 0x0600DD63 RID: 56675 RVA: 0x00207EA8 File Offset: 0x002060A8
		[NullableContext(1)]
		public static ModifyNameRequest Create()
		{
			return new ModifyNameRequest();
		}

		// Token: 0x17002CDA RID: 11482
		// (get) Token: 0x0600DD64 RID: 56676 RVA: 0x00207EAF File Offset: 0x002060AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CDB RID: 11483
		// (get) Token: 0x0600DD65 RID: 56677 RVA: 0x00207EB2 File Offset: 0x002060B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModifyNameRequest.Descriptor;
			}
		}

		// Token: 0x0600DD66 RID: 56678 RVA: 0x00207EB9 File Offset: 0x002060B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyNameRequest()
		{
		}

		// Token: 0x0600DD67 RID: 56679 RVA: 0x00207ECC File Offset: 0x002060CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyNameRequest(ModifyNameRequest other) : this()
		{
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DD68 RID: 56680 RVA: 0x00207EF1 File Offset: 0x002060F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyNameRequest Clone()
		{
			return new ModifyNameRequest(this);
		}

		// Token: 0x17002CDC RID: 11484
		// (get) Token: 0x0600DD69 RID: 56681 RVA: 0x00207EF9 File Offset: 0x002060F9
		// (set) Token: 0x0600DD6A RID: 56682 RVA: 0x00207F01 File Offset: 0x00206101
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

		// Token: 0x0600DD6B RID: 56683 RVA: 0x00207F14 File Offset: 0x00206114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModifyNameRequest);
		}

		// Token: 0x0600DD6C RID: 56684 RVA: 0x00207F22 File Offset: 0x00206122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ModifyNameRequest other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DD6D RID: 56685 RVA: 0x00207F58 File Offset: 0x00206158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600DD6E RID: 56686 RVA: 0x00207F99 File Offset: 0x00206199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DD6F RID: 56687 RVA: 0x00207FA6 File Offset: 0x002061A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DD70 RID: 56688 RVA: 0x00207FAF File Offset: 0x002061AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DD71 RID: 56689 RVA: 0x00207FE8 File Offset: 0x002061E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600DD72 RID: 56690 RVA: 0x0020802B File Offset: 0x0020622B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ModifyNameRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DD73 RID: 56691 RVA: 0x00208061 File Offset: 0x00206261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD74 RID: 56692 RVA: 0x0020806C File Offset: 0x0020626C
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x04005BE1 RID: 23521
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BE2 RID: 23522
		public const int NameFieldNumber = 4;

		// Token: 0x04005BE3 RID: 23523
		private string name_ = "";
	}
}
