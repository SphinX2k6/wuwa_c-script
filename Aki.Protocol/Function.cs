using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000679 RID: 1657
	public sealed class Function : IMessage<Function>, IMessage, IEquatable<Function>, IDeepCloneable<Function>, IBufferMessage
	{
		// Token: 0x060097D9 RID: 38873 RVA: 0x0016E189 File Offset: 0x0016C389
		[NullableContext(1)]
		public static Function Create()
		{
			return new Function();
		}

		// Token: 0x17001E40 RID: 7744
		// (get) Token: 0x060097DA RID: 38874 RVA: 0x0016E190 File Offset: 0x0016C390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Function> Parser
		{
			get
			{
				return Function._parser;
			}
		}

		// Token: 0x17001E41 RID: 7745
		// (get) Token: 0x060097DB RID: 38875 RVA: 0x0016E197 File Offset: 0x0016C397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E42 RID: 7746
		// (get) Token: 0x060097DC RID: 38876 RVA: 0x0016E19A File Offset: 0x0016C39A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Function.Descriptor;
			}
		}

		// Token: 0x060097DD RID: 38877 RVA: 0x0016E1A1 File Offset: 0x0016C3A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Function()
		{
		}

		// Token: 0x060097DE RID: 38878 RVA: 0x0016E1A9 File Offset: 0x0016C3A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Function(Function other) : this()
		{
			this.id_ = other.id_;
			this.flag_ = other.flag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060097DF RID: 38879 RVA: 0x0016E1DA File Offset: 0x0016C3DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Function Clone()
		{
			return new Function(this);
		}

		// Token: 0x17001E43 RID: 7747
		// (get) Token: 0x060097E0 RID: 38880 RVA: 0x0016E1E2 File Offset: 0x0016C3E2
		// (set) Token: 0x060097E1 RID: 38881 RVA: 0x0016E1EA File Offset: 0x0016C3EA
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

		// Token: 0x17001E44 RID: 7748
		// (get) Token: 0x060097E2 RID: 38882 RVA: 0x0016E1F3 File Offset: 0x0016C3F3
		// (set) Token: 0x060097E3 RID: 38883 RVA: 0x0016E1FB File Offset: 0x0016C3FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Flag
		{
			get
			{
				return this.flag_;
			}
			set
			{
				this.flag_ = value;
			}
		}

		// Token: 0x060097E4 RID: 38884 RVA: 0x0016E204 File Offset: 0x0016C404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Function);
		}

		// Token: 0x060097E5 RID: 38885 RVA: 0x0016E212 File Offset: 0x0016C412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Function other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Flag == other.Flag && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060097E6 RID: 38886 RVA: 0x0016E250 File Offset: 0x0016C450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Flag != 0)
			{
				num ^= this.Flag.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060097E7 RID: 38887 RVA: 0x0016E2A8 File Offset: 0x0016C4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060097E8 RID: 38888 RVA: 0x0016E2B5 File Offset: 0x0016C4B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060097E9 RID: 38889 RVA: 0x0016E2C0 File Offset: 0x0016C4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Flag != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Flag);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060097EA RID: 38890 RVA: 0x0016E318 File Offset: 0x0016C518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Flag != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Flag);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060097EB RID: 38891 RVA: 0x0016E370 File Offset: 0x0016C570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Function other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Flag != 0)
			{
				this.Flag = other.Flag;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060097EC RID: 38892 RVA: 0x0016E3C0 File Offset: 0x0016C5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060097ED RID: 38893 RVA: 0x0016E3CC File Offset: 0x0016C5CC
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
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Flag = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004819 RID: 18457
		private static readonly MessageParser<Function> _parser = new MessageParser<Function>(() => new Function());

		// Token: 0x0400481A RID: 18458
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400481B RID: 18459
		public const int IdFieldNumber = 1;

		// Token: 0x0400481C RID: 18460
		private int id_;

		// Token: 0x0400481D RID: 18461
		public const int FlagFieldNumber = 5;

		// Token: 0x0400481E RID: 18462
		private int flag_;
	}
}
