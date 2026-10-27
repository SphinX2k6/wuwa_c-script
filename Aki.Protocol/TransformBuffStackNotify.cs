using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013F7 RID: 5111
	[NetMessage(EMessageId.TransformBuffStackNotify)]
	public sealed class TransformBuffStackNotify : IMessage<TransformBuffStackNotify>, IMessage, IEquatable<TransformBuffStackNotify>, IDeepCloneable<TransformBuffStackNotify>, IBufferMessage
	{
		// Token: 0x0601B14B RID: 110923 RVA: 0x003EBCF6 File Offset: 0x003E9EF6
		[NullableContext(1)]
		public static TransformBuffStackNotify Create()
		{
			return new TransformBuffStackNotify();
		}

		// Token: 0x17005B40 RID: 23360
		// (get) Token: 0x0601B14C RID: 110924 RVA: 0x003EBCFD File Offset: 0x003E9EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B41 RID: 23361
		// (get) Token: 0x0601B14D RID: 110925 RVA: 0x003EBD00 File Offset: 0x003E9F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransformBuffStackNotify.Descriptor;
			}
		}

		// Token: 0x0601B14E RID: 110926 RVA: 0x003EBD07 File Offset: 0x003E9F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransformBuffStackNotify()
		{
		}

		// Token: 0x0601B14F RID: 110927 RVA: 0x003EBD0F File Offset: 0x003E9F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransformBuffStackNotify(TransformBuffStackNotify other) : this()
		{
			this.buffHandle_ = other.buffHandle_;
			this.buffId_ = other.buffId_;
			this.stackLimit_ = other.stackLimit_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B150 RID: 110928 RVA: 0x003EBD4C File Offset: 0x003E9F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransformBuffStackNotify Clone()
		{
			return new TransformBuffStackNotify(this);
		}

		// Token: 0x17005B42 RID: 23362
		// (get) Token: 0x0601B151 RID: 110929 RVA: 0x003EBD54 File Offset: 0x003E9F54
		// (set) Token: 0x0601B152 RID: 110930 RVA: 0x003EBD5C File Offset: 0x003E9F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BuffHandle
		{
			get
			{
				return this.buffHandle_;
			}
			set
			{
				this.buffHandle_ = value;
			}
		}

		// Token: 0x17005B43 RID: 23363
		// (get) Token: 0x0601B153 RID: 110931 RVA: 0x003EBD65 File Offset: 0x003E9F65
		// (set) Token: 0x0601B154 RID: 110932 RVA: 0x003EBD6D File Offset: 0x003E9F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BuffId
		{
			get
			{
				return this.buffId_;
			}
			set
			{
				this.buffId_ = value;
			}
		}

		// Token: 0x17005B44 RID: 23364
		// (get) Token: 0x0601B155 RID: 110933 RVA: 0x003EBD76 File Offset: 0x003E9F76
		// (set) Token: 0x0601B156 RID: 110934 RVA: 0x003EBD7E File Offset: 0x003E9F7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StackLimit
		{
			get
			{
				return this.stackLimit_;
			}
			set
			{
				this.stackLimit_ = value;
			}
		}

		// Token: 0x0601B157 RID: 110935 RVA: 0x003EBD87 File Offset: 0x003E9F87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransformBuffStackNotify);
		}

		// Token: 0x0601B158 RID: 110936 RVA: 0x003EBD98 File Offset: 0x003E9F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransformBuffStackNotify other)
		{
			return other != null && (other == this || (this.BuffHandle == other.BuffHandle && this.BuffId == other.BuffId && this.StackLimit == other.StackLimit && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B159 RID: 110937 RVA: 0x003EBDF4 File Offset: 0x003E9FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffHandle != 0L)
			{
				num ^= this.BuffHandle.GetHashCode();
			}
			if (this.BuffId != 0L)
			{
				num ^= this.BuffId.GetHashCode();
			}
			if (this.StackLimit != 0)
			{
				num ^= this.StackLimit.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B15A RID: 110938 RVA: 0x003EBE65 File Offset: 0x003EA065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B15B RID: 110939 RVA: 0x003EBE72 File Offset: 0x003EA072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B15C RID: 110940 RVA: 0x003EBE7C File Offset: 0x003EA07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffHandle != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.BuffHandle);
			}
			if (this.StackLimit != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.StackLimit);
			}
			if (this.BuffId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.BuffId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B15D RID: 110941 RVA: 0x003EBEF4 File Offset: 0x003EA0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffHandle != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BuffHandle);
			}
			if (this.BuffId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BuffId);
			}
			if (this.StackLimit != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StackLimit);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B15E RID: 110942 RVA: 0x003EBF64 File Offset: 0x003EA164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TransformBuffStackNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffHandle != 0L)
			{
				this.BuffHandle = other.BuffHandle;
			}
			if (other.BuffId != 0L)
			{
				this.BuffId = other.BuffId;
			}
			if (other.StackLimit != 0)
			{
				this.StackLimit = other.StackLimit;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B15F RID: 110943 RVA: 0x003EBFC8 File Offset: 0x003EA1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B160 RID: 110944 RVA: 0x003EBFD4 File Offset: 0x003EA1D4
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
					if (num != 64U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.BuffId = input.ReadInt64();
						}
					}
					else
					{
						this.StackLimit = input.ReadInt32();
					}
				}
				else
				{
					this.BuffHandle = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009CA4 RID: 40100
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CA5 RID: 40101
		public const int BuffHandleFieldNumber = 7;

		// Token: 0x04009CA6 RID: 40102
		private long buffHandle_;

		// Token: 0x04009CA7 RID: 40103
		public const int BuffIdFieldNumber = 15;

		// Token: 0x04009CA8 RID: 40104
		private long buffId_;

		// Token: 0x04009CA9 RID: 40105
		public const int StackLimitFieldNumber = 8;

		// Token: 0x04009CAA RID: 40106
		private int stackLimit_;
	}
}
