using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001FE RID: 510
	[NetMessage(EMessageId.BuffEffectPush)]
	public sealed class BuffEffectPush : IMessage<BuffEffectPush>, IMessage, IEquatable<BuffEffectPush>, IDeepCloneable<BuffEffectPush>, IBufferMessage
	{
		// Token: 0x0600388E RID: 14478 RVA: 0x0008D469 File Offset: 0x0008B669
		[NullableContext(1)]
		public static BuffEffectPush Create()
		{
			return new BuffEffectPush();
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x0600388F RID: 14479 RVA: 0x0008D470 File Offset: 0x0008B670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06003890 RID: 14480 RVA: 0x0008D473 File Offset: 0x0008B673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffEffectPush.Descriptor;
			}
		}

		// Token: 0x06003891 RID: 14481 RVA: 0x0008D47A File Offset: 0x0008B67A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectPush()
		{
		}

		// Token: 0x06003892 RID: 14482 RVA: 0x0008D482 File Offset: 0x0008B682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectPush(BuffEffectPush other) : this()
		{
			this.handleId_ = other.handleId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003893 RID: 14483 RVA: 0x0008D4B3 File Offset: 0x0008B6B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectPush Clone()
		{
			return new BuffEffectPush(this);
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06003894 RID: 14484 RVA: 0x0008D4BB File Offset: 0x0008B6BB
		// (set) Token: 0x06003895 RID: 14485 RVA: 0x0008D4C3 File Offset: 0x0008B6C3
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

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06003896 RID: 14486 RVA: 0x0008D4CC File Offset: 0x0008B6CC
		// (set) Token: 0x06003897 RID: 14487 RVA: 0x0008D4D4 File Offset: 0x0008B6D4
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

		// Token: 0x06003898 RID: 14488 RVA: 0x0008D4DD File Offset: 0x0008B6DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffEffectPush);
		}

		// Token: 0x06003899 RID: 14489 RVA: 0x0008D4EB File Offset: 0x0008B6EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffEffectPush other)
		{
			return other != null && (other == this || (this.HandleId == other.HandleId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600389A RID: 14490 RVA: 0x0008D52C File Offset: 0x0008B72C
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

		// Token: 0x0600389B RID: 14491 RVA: 0x0008D584 File Offset: 0x0008B784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600389C RID: 14492 RVA: 0x0008D591 File Offset: 0x0008B791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600389D RID: 14493 RVA: 0x0008D59C File Offset: 0x0008B79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HandleId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.HandleId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600389E RID: 14494 RVA: 0x0008D5F8 File Offset: 0x0008B7F8
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

		// Token: 0x0600389F RID: 14495 RVA: 0x0008D650 File Offset: 0x0008B850
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

		// Token: 0x060038A0 RID: 14496 RVA: 0x0008D6A0 File Offset: 0x0008B8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x0008D6AC File Offset: 0x0008B8AC
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

		// Token: 0x04002B3D RID: 11069
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B3E RID: 11070
		public const int HandleIdFieldNumber = 7;

		// Token: 0x04002B3F RID: 11071
		private int handleId_;

		// Token: 0x04002B40 RID: 11072
		public const int IndexFieldNumber = 8;

		// Token: 0x04002B41 RID: 11073
		private int index_;
	}
}
