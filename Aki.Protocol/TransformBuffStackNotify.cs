using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200146A RID: 5226
	[NetMessage(EMessageId.TransformBuffStackNotify)]
	public sealed class TransformBuffStackNotify : IMessage<TransformBuffStackNotify>, IMessage, IEquatable<TransformBuffStackNotify>, IDeepCloneable<TransformBuffStackNotify>, IBufferMessage
	{
		// Token: 0x0601BBD6 RID: 113622 RVA: 0x00406FCA File Offset: 0x004051CA
		[NullableContext(1)]
		public static TransformBuffStackNotify Create()
		{
			return new TransformBuffStackNotify();
		}

		// Token: 0x17005DD5 RID: 24021
		// (get) Token: 0x0601BBD7 RID: 113623 RVA: 0x00406FD1 File Offset: 0x004051D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DD6 RID: 24022
		// (get) Token: 0x0601BBD8 RID: 113624 RVA: 0x00406FD4 File Offset: 0x004051D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransformBuffStackNotify.Descriptor;
			}
		}

		// Token: 0x0601BBD9 RID: 113625 RVA: 0x00406FDB File Offset: 0x004051DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransformBuffStackNotify()
		{
		}

		// Token: 0x0601BBDA RID: 113626 RVA: 0x00406FE3 File Offset: 0x004051E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransformBuffStackNotify(TransformBuffStackNotify other) : this()
		{
			this.buffHandle_ = other.buffHandle_;
			this.buffId_ = other.buffId_;
			this.stackLimit_ = other.stackLimit_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BBDB RID: 113627 RVA: 0x00407020 File Offset: 0x00405220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransformBuffStackNotify Clone()
		{
			return new TransformBuffStackNotify(this);
		}

		// Token: 0x17005DD7 RID: 24023
		// (get) Token: 0x0601BBDC RID: 113628 RVA: 0x00407028 File Offset: 0x00405228
		// (set) Token: 0x0601BBDD RID: 113629 RVA: 0x00407030 File Offset: 0x00405230
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

		// Token: 0x17005DD8 RID: 24024
		// (get) Token: 0x0601BBDE RID: 113630 RVA: 0x00407039 File Offset: 0x00405239
		// (set) Token: 0x0601BBDF RID: 113631 RVA: 0x00407041 File Offset: 0x00405241
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

		// Token: 0x17005DD9 RID: 24025
		// (get) Token: 0x0601BBE0 RID: 113632 RVA: 0x0040704A File Offset: 0x0040524A
		// (set) Token: 0x0601BBE1 RID: 113633 RVA: 0x00407052 File Offset: 0x00405252
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

		// Token: 0x0601BBE2 RID: 113634 RVA: 0x0040705B File Offset: 0x0040525B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransformBuffStackNotify);
		}

		// Token: 0x0601BBE3 RID: 113635 RVA: 0x0040706C File Offset: 0x0040526C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransformBuffStackNotify other)
		{
			return other != null && (other == this || (this.BuffHandle == other.BuffHandle && this.BuffId == other.BuffId && this.StackLimit == other.StackLimit && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BBE4 RID: 113636 RVA: 0x004070C8 File Offset: 0x004052C8
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

		// Token: 0x0601BBE5 RID: 113637 RVA: 0x00407139 File Offset: 0x00405339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BBE6 RID: 113638 RVA: 0x00407146 File Offset: 0x00405346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BBE7 RID: 113639 RVA: 0x00407150 File Offset: 0x00405350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffHandle != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.BuffHandle);
			}
			if (this.StackLimit != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.StackLimit);
			}
			if (this.BuffId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.BuffId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BBE8 RID: 113640 RVA: 0x004071C8 File Offset: 0x004053C8
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

		// Token: 0x0601BBE9 RID: 113641 RVA: 0x00407238 File Offset: 0x00405438
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

		// Token: 0x0601BBEA RID: 113642 RVA: 0x0040729C File Offset: 0x0040549C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BBEB RID: 113643 RVA: 0x004072A8 File Offset: 0x004054A8
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
				if (num != 32U)
				{
					if (num != 48U)
					{
						if (num != 96U)
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

		// Token: 0x0400A0EB RID: 41195
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0EC RID: 41196
		public const int BuffHandleFieldNumber = 4;

		// Token: 0x0400A0ED RID: 41197
		private long buffHandle_;

		// Token: 0x0400A0EE RID: 41198
		public const int BuffIdFieldNumber = 12;

		// Token: 0x0400A0EF RID: 41199
		private long buffId_;

		// Token: 0x0400A0F0 RID: 41200
		public const int StackLimitFieldNumber = 6;

		// Token: 0x0400A0F1 RID: 41201
		private int stackLimit_;
	}
}
