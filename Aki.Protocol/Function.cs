using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000665 RID: 1637
	public sealed class Function : IMessage<Function>, IMessage, IEquatable<Function>, IDeepCloneable<Function>, IBufferMessage
	{
		// Token: 0x06009683 RID: 38531 RVA: 0x0016B755 File Offset: 0x00169955
		[NullableContext(1)]
		public static Function Create()
		{
			return new Function();
		}

		// Token: 0x17001DF6 RID: 7670
		// (get) Token: 0x06009684 RID: 38532 RVA: 0x0016B75C File Offset: 0x0016995C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Function> Parser
		{
			get
			{
				return Function._parser;
			}
		}

		// Token: 0x17001DF7 RID: 7671
		// (get) Token: 0x06009685 RID: 38533 RVA: 0x0016B763 File Offset: 0x00169963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DF8 RID: 7672
		// (get) Token: 0x06009686 RID: 38534 RVA: 0x0016B766 File Offset: 0x00169966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Function.Descriptor;
			}
		}

		// Token: 0x06009687 RID: 38535 RVA: 0x0016B76D File Offset: 0x0016996D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Function()
		{
		}

		// Token: 0x06009688 RID: 38536 RVA: 0x0016B775 File Offset: 0x00169975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Function(Function other) : this()
		{
			this.id_ = other.id_;
			this.flag_ = other.flag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009689 RID: 38537 RVA: 0x0016B7A6 File Offset: 0x001699A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Function Clone()
		{
			return new Function(this);
		}

		// Token: 0x17001DF9 RID: 7673
		// (get) Token: 0x0600968A RID: 38538 RVA: 0x0016B7AE File Offset: 0x001699AE
		// (set) Token: 0x0600968B RID: 38539 RVA: 0x0016B7B6 File Offset: 0x001699B6
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

		// Token: 0x17001DFA RID: 7674
		// (get) Token: 0x0600968C RID: 38540 RVA: 0x0016B7BF File Offset: 0x001699BF
		// (set) Token: 0x0600968D RID: 38541 RVA: 0x0016B7C7 File Offset: 0x001699C7
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

		// Token: 0x0600968E RID: 38542 RVA: 0x0016B7D0 File Offset: 0x001699D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Function);
		}

		// Token: 0x0600968F RID: 38543 RVA: 0x0016B7DE File Offset: 0x001699DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Function other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Flag == other.Flag && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009690 RID: 38544 RVA: 0x0016B81C File Offset: 0x00169A1C
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

		// Token: 0x06009691 RID: 38545 RVA: 0x0016B874 File Offset: 0x00169A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009692 RID: 38546 RVA: 0x0016B881 File Offset: 0x00169A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009693 RID: 38547 RVA: 0x0016B88C File Offset: 0x00169A8C
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

		// Token: 0x06009694 RID: 38548 RVA: 0x0016B8E4 File Offset: 0x00169AE4
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

		// Token: 0x06009695 RID: 38549 RVA: 0x0016B93C File Offset: 0x00169B3C
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

		// Token: 0x06009696 RID: 38550 RVA: 0x0016B98C File Offset: 0x00169B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009697 RID: 38551 RVA: 0x0016B998 File Offset: 0x00169B98
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

		// Token: 0x04004812 RID: 18450
		private static readonly MessageParser<Function> _parser = new MessageParser<Function>(() => new Function());

		// Token: 0x04004813 RID: 18451
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004814 RID: 18452
		public const int IdFieldNumber = 1;

		// Token: 0x04004815 RID: 18453
		private int id_;

		// Token: 0x04004816 RID: 18454
		public const int FlagFieldNumber = 5;

		// Token: 0x04004817 RID: 18455
		private int flag_;
	}
}
