using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000203 RID: 515
	[NetMessage(EMessageId.BuffEffectPush)]
	public sealed class BuffEffectPush : IMessage<BuffEffectPush>, IMessage, IEquatable<BuffEffectPush>, IDeepCloneable<BuffEffectPush>, IBufferMessage
	{
		// Token: 0x06003933 RID: 14643 RVA: 0x0008F079 File Offset: 0x0008D279
		[NullableContext(1)]
		public static BuffEffectPush Create()
		{
			return new BuffEffectPush();
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06003934 RID: 14644 RVA: 0x0008F080 File Offset: 0x0008D280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06003935 RID: 14645 RVA: 0x0008F083 File Offset: 0x0008D283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffEffectPush.Descriptor;
			}
		}

		// Token: 0x06003936 RID: 14646 RVA: 0x0008F08A File Offset: 0x0008D28A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectPush()
		{
		}

		// Token: 0x06003937 RID: 14647 RVA: 0x0008F092 File Offset: 0x0008D292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectPush(BuffEffectPush other) : this()
		{
			this.handleId_ = other.handleId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003938 RID: 14648 RVA: 0x0008F0C3 File Offset: 0x0008D2C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectPush Clone()
		{
			return new BuffEffectPush(this);
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06003939 RID: 14649 RVA: 0x0008F0CB File Offset: 0x0008D2CB
		// (set) Token: 0x0600393A RID: 14650 RVA: 0x0008F0D3 File Offset: 0x0008D2D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandleId
		{
			get
			{
				return this.handleId_;
			}
			set
			{
				this.handleId_ = value;
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x0600393B RID: 14651 RVA: 0x0008F0DC File Offset: 0x0008D2DC
		// (set) Token: 0x0600393C RID: 14652 RVA: 0x0008F0E4 File Offset: 0x0008D2E4
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

		// Token: 0x0600393D RID: 14653 RVA: 0x0008F0ED File Offset: 0x0008D2ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffEffectPush);
		}

		// Token: 0x0600393E RID: 14654 RVA: 0x0008F0FB File Offset: 0x0008D2FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffEffectPush other)
		{
			return other != null && (other == this || (this.HandleId == other.HandleId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600393F RID: 14655 RVA: 0x0008F13C File Offset: 0x0008D33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HandleId != 0)
			{
				num ^= this.HandleId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003940 RID: 14656 RVA: 0x0008F194 File Offset: 0x0008D394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003941 RID: 14657 RVA: 0x0008F1A1 File Offset: 0x0008D3A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003942 RID: 14658 RVA: 0x0008F1AC File Offset: 0x0008D3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HandleId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.HandleId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003943 RID: 14659 RVA: 0x0008F208 File Offset: 0x0008D408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HandleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandleId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003944 RID: 14660 RVA: 0x0008F260 File Offset: 0x0008D460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffEffectPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HandleId != 0)
			{
				this.HandleId = other.HandleId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003945 RID: 14661 RVA: 0x0008F2B0 File Offset: 0x0008D4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003946 RID: 14662 RVA: 0x0008F2BC File Offset: 0x0008D4BC
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.HandleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002BBF RID: 11199
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BC0 RID: 11200
		public const int HandleIdFieldNumber = 4;

		// Token: 0x04002BC1 RID: 11201
		private int handleId_;

		// Token: 0x04002BC2 RID: 11202
		public const int IndexFieldNumber = 14;

		// Token: 0x04002BC3 RID: 11203
		private int index_;
	}
}
