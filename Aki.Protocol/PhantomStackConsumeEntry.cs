using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CF9 RID: 3321
	public sealed class PhantomStackConsumeEntry : IMessage<PhantomStackConsumeEntry>, IMessage, IEquatable<PhantomStackConsumeEntry>, IDeepCloneable<PhantomStackConsumeEntry>, IBufferMessage
	{
		// Token: 0x06011F89 RID: 73609 RVA: 0x002A0F8D File Offset: 0x0029F18D
		[NullableContext(1)]
		public static PhantomStackConsumeEntry Create()
		{
			return new PhantomStackConsumeEntry();
		}

		// Token: 0x17003B89 RID: 15241
		// (get) Token: 0x06011F8A RID: 73610 RVA: 0x002A0F94 File Offset: 0x0029F194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomStackConsumeEntry> Parser
		{
			get
			{
				return PhantomStackConsumeEntry._parser;
			}
		}

		// Token: 0x17003B8A RID: 15242
		// (get) Token: 0x06011F8B RID: 73611 RVA: 0x002A0F9B File Offset: 0x0029F19B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B8B RID: 15243
		// (get) Token: 0x06011F8C RID: 73612 RVA: 0x002A0F9E File Offset: 0x0029F19E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomStackConsumeEntry.Descriptor;
			}
		}

		// Token: 0x06011F8D RID: 73613 RVA: 0x002A0FA5 File Offset: 0x0029F1A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomStackConsumeEntry()
		{
		}

		// Token: 0x06011F8E RID: 73614 RVA: 0x002A0FAD File Offset: 0x0029F1AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomStackConsumeEntry(PhantomStackConsumeEntry other) : this()
		{
			this.incrId_ = other.incrId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011F8F RID: 73615 RVA: 0x002A0FDE File Offset: 0x0029F1DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomStackConsumeEntry Clone()
		{
			return new PhantomStackConsumeEntry(this);
		}

		// Token: 0x17003B8C RID: 15244
		// (get) Token: 0x06011F90 RID: 73616 RVA: 0x002A0FE6 File Offset: 0x0029F1E6
		// (set) Token: 0x06011F91 RID: 73617 RVA: 0x002A0FEE File Offset: 0x0029F1EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x17003B8D RID: 15245
		// (get) Token: 0x06011F92 RID: 73618 RVA: 0x002A0FF7 File Offset: 0x0029F1F7
		// (set) Token: 0x06011F93 RID: 73619 RVA: 0x002A0FFF File Offset: 0x0029F1FF
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

		// Token: 0x06011F94 RID: 73620 RVA: 0x002A1008 File Offset: 0x0029F208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomStackConsumeEntry);
		}

		// Token: 0x06011F95 RID: 73621 RVA: 0x002A1016 File Offset: 0x0029F216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomStackConsumeEntry other)
		{
			return other != null && (other == this || (this.IncrId == other.IncrId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011F96 RID: 73622 RVA: 0x002A1054 File Offset: 0x0029F254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011F97 RID: 73623 RVA: 0x002A10AC File Offset: 0x0029F2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011F98 RID: 73624 RVA: 0x002A10B9 File Offset: 0x0029F2B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011F99 RID: 73625 RVA: 0x002A10C4 File Offset: 0x0029F2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncrId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.IncrId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011F9A RID: 73626 RVA: 0x002A111C File Offset: 0x0029F31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011F9B RID: 73627 RVA: 0x002A1174 File Offset: 0x0029F374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomStackConsumeEntry other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011F9C RID: 73628 RVA: 0x002A11C4 File Offset: 0x0029F3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011F9D RID: 73629 RVA: 0x002A11D0 File Offset: 0x0029F3D0
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.IncrId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040070FE RID: 28926
		private static readonly MessageParser<PhantomStackConsumeEntry> _parser = new MessageParser<PhantomStackConsumeEntry>(() => new PhantomStackConsumeEntry());

		// Token: 0x040070FF RID: 28927
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007100 RID: 28928
		public const int IncrIdFieldNumber = 1;

		// Token: 0x04007101 RID: 28929
		private int incrId_;

		// Token: 0x04007102 RID: 28930
		public const int CountFieldNumber = 2;

		// Token: 0x04007103 RID: 28931
		private int count_;
	}
}
