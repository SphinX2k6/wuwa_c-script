using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000200 RID: 512
	[NetMessage(EMessageId.BuffEffectExecutePush)]
	public sealed class BuffEffectExecutePush : IMessage<BuffEffectExecutePush>, IMessage, IEquatable<BuffEffectExecutePush>, IDeepCloneable<BuffEffectExecutePush>, IBufferMessage
	{
		// Token: 0x060038F9 RID: 14585 RVA: 0x0008E90D File Offset: 0x0008CB0D
		[NullableContext(1)]
		public static BuffEffectExecutePush Create()
		{
			return new BuffEffectExecutePush();
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x060038FA RID: 14586 RVA: 0x0008E914 File Offset: 0x0008CB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x060038FB RID: 14587 RVA: 0x0008E917 File Offset: 0x0008CB17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffEffectExecutePush.Descriptor;
			}
		}

		// Token: 0x060038FC RID: 14588 RVA: 0x0008E91E File Offset: 0x0008CB1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectExecutePush()
		{
		}

		// Token: 0x060038FD RID: 14589 RVA: 0x0008E926 File Offset: 0x0008CB26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectExecutePush(BuffEffectExecutePush other) : this()
		{
			this.handleId_ = other.handleId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060038FE RID: 14590 RVA: 0x0008E957 File Offset: 0x0008CB57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectExecutePush Clone()
		{
			return new BuffEffectExecutePush(this);
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x060038FF RID: 14591 RVA: 0x0008E95F File Offset: 0x0008CB5F
		// (set) Token: 0x06003900 RID: 14592 RVA: 0x0008E967 File Offset: 0x0008CB67
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

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06003901 RID: 14593 RVA: 0x0008E970 File Offset: 0x0008CB70
		// (set) Token: 0x06003902 RID: 14594 RVA: 0x0008E978 File Offset: 0x0008CB78
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

		// Token: 0x06003903 RID: 14595 RVA: 0x0008E981 File Offset: 0x0008CB81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffEffectExecutePush);
		}

		// Token: 0x06003904 RID: 14596 RVA: 0x0008E98F File Offset: 0x0008CB8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffEffectExecutePush other)
		{
			return other != null && (other == this || (this.HandleId == other.HandleId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003905 RID: 14597 RVA: 0x0008E9D0 File Offset: 0x0008CBD0
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

		// Token: 0x06003906 RID: 14598 RVA: 0x0008EA28 File Offset: 0x0008CC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003907 RID: 14599 RVA: 0x0008EA35 File Offset: 0x0008CC35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003908 RID: 14600 RVA: 0x0008EA40 File Offset: 0x0008CC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HandleId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.HandleId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003909 RID: 14601 RVA: 0x0008EA9C File Offset: 0x0008CC9C
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

		// Token: 0x0600390A RID: 14602 RVA: 0x0008EAF4 File Offset: 0x0008CCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffEffectExecutePush other)
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

		// Token: 0x0600390B RID: 14603 RVA: 0x0008EB44 File Offset: 0x0008CD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600390C RID: 14604 RVA: 0x0008EB50 File Offset: 0x0008CD50
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
				if (num != 64U)
				{
					if (num != 88U)
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

		// Token: 0x04002BB2 RID: 11186
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BB3 RID: 11187
		public const int HandleIdFieldNumber = 8;

		// Token: 0x04002BB4 RID: 11188
		private int handleId_;

		// Token: 0x04002BB5 RID: 11189
		public const int IndexFieldNumber = 11;

		// Token: 0x04002BB6 RID: 11190
		private int index_;
	}
}
