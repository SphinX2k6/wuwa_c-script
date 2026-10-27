using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D09 RID: 3337
	public sealed class PhantomStackConsumeEntry : IMessage<PhantomStackConsumeEntry>, IMessage, IEquatable<PhantomStackConsumeEntry>, IDeepCloneable<PhantomStackConsumeEntry>, IBufferMessage
	{
		// Token: 0x06012085 RID: 73861 RVA: 0x002A2BB1 File Offset: 0x002A0DB1
		[NullableContext(1)]
		public static PhantomStackConsumeEntry Create()
		{
			return new PhantomStackConsumeEntry();
		}

		// Token: 0x17003BBE RID: 15294
		// (get) Token: 0x06012086 RID: 73862 RVA: 0x002A2BB8 File Offset: 0x002A0DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomStackConsumeEntry> Parser
		{
			get
			{
				return PhantomStackConsumeEntry._parser;
			}
		}

		// Token: 0x17003BBF RID: 15295
		// (get) Token: 0x06012087 RID: 73863 RVA: 0x002A2BBF File Offset: 0x002A0DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BC0 RID: 15296
		// (get) Token: 0x06012088 RID: 73864 RVA: 0x002A2BC2 File Offset: 0x002A0DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomStackConsumeEntry.Descriptor;
			}
		}

		// Token: 0x06012089 RID: 73865 RVA: 0x002A2BC9 File Offset: 0x002A0DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomStackConsumeEntry()
		{
		}

		// Token: 0x0601208A RID: 73866 RVA: 0x002A2BD1 File Offset: 0x002A0DD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomStackConsumeEntry(PhantomStackConsumeEntry other) : this()
		{
			this.incrId_ = other.incrId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601208B RID: 73867 RVA: 0x002A2C02 File Offset: 0x002A0E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomStackConsumeEntry Clone()
		{
			return new PhantomStackConsumeEntry(this);
		}

		// Token: 0x17003BC1 RID: 15297
		// (get) Token: 0x0601208C RID: 73868 RVA: 0x002A2C0A File Offset: 0x002A0E0A
		// (set) Token: 0x0601208D RID: 73869 RVA: 0x002A2C12 File Offset: 0x002A0E12
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

		// Token: 0x17003BC2 RID: 15298
		// (get) Token: 0x0601208E RID: 73870 RVA: 0x002A2C1B File Offset: 0x002A0E1B
		// (set) Token: 0x0601208F RID: 73871 RVA: 0x002A2C23 File Offset: 0x002A0E23
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

		// Token: 0x06012090 RID: 73872 RVA: 0x002A2C2C File Offset: 0x002A0E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomStackConsumeEntry);
		}

		// Token: 0x06012091 RID: 73873 RVA: 0x002A2C3A File Offset: 0x002A0E3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomStackConsumeEntry other)
		{
			return other != null && (other == this || (this.IncrId == other.IncrId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012092 RID: 73874 RVA: 0x002A2C78 File Offset: 0x002A0E78
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

		// Token: 0x06012093 RID: 73875 RVA: 0x002A2CD0 File Offset: 0x002A0ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012094 RID: 73876 RVA: 0x002A2CDD File Offset: 0x002A0EDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012095 RID: 73877 RVA: 0x002A2CE8 File Offset: 0x002A0EE8
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

		// Token: 0x06012096 RID: 73878 RVA: 0x002A2D40 File Offset: 0x002A0F40
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

		// Token: 0x06012097 RID: 73879 RVA: 0x002A2D98 File Offset: 0x002A0F98
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

		// Token: 0x06012098 RID: 73880 RVA: 0x002A2DE8 File Offset: 0x002A0FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012099 RID: 73881 RVA: 0x002A2DF4 File Offset: 0x002A0FF4
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

		// Token: 0x040070E6 RID: 28902
		private static readonly MessageParser<PhantomStackConsumeEntry> _parser = new MessageParser<PhantomStackConsumeEntry>(() => new PhantomStackConsumeEntry());

		// Token: 0x040070E7 RID: 28903
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070E8 RID: 28904
		public const int IncrIdFieldNumber = 1;

		// Token: 0x040070E9 RID: 28905
		private int incrId_;

		// Token: 0x040070EA RID: 28906
		public const int CountFieldNumber = 2;

		// Token: 0x040070EB RID: 28907
		private int count_;
	}
}
