using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200027D RID: 637
	[NetMessage(EMessageId.CharacterMoveToPointEndPush)]
	public sealed class CharacterMoveToPointEndPush : IMessage<CharacterMoveToPointEndPush>, IMessage, IEquatable<CharacterMoveToPointEndPush>, IDeepCloneable<CharacterMoveToPointEndPush>, IBufferMessage
	{
		// Token: 0x06004310 RID: 17168 RVA: 0x000A4B6E File Offset: 0x000A2D6E
		[NullableContext(1)]
		public static CharacterMoveToPointEndPush Create()
		{
			return new CharacterMoveToPointEndPush();
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06004311 RID: 17169 RVA: 0x000A4B75 File Offset: 0x000A2D75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06004312 RID: 17170 RVA: 0x000A4B78 File Offset: 0x000A2D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharacterMoveToPointEndPush.Descriptor;
			}
		}

		// Token: 0x06004313 RID: 17171 RVA: 0x000A4B7F File Offset: 0x000A2D7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterMoveToPointEndPush()
		{
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x000A4B87 File Offset: 0x000A2D87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterMoveToPointEndPush(CharacterMoveToPointEndPush other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isInterrupt_ = other.isInterrupt_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004315 RID: 17173 RVA: 0x000A4BB8 File Offset: 0x000A2DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterMoveToPointEndPush Clone()
		{
			return new CharacterMoveToPointEndPush(this);
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06004316 RID: 17174 RVA: 0x000A4BC0 File Offset: 0x000A2DC0
		// (set) Token: 0x06004317 RID: 17175 RVA: 0x000A4BC8 File Offset: 0x000A2DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06004318 RID: 17176 RVA: 0x000A4BD1 File Offset: 0x000A2DD1
		// (set) Token: 0x06004319 RID: 17177 RVA: 0x000A4BD9 File Offset: 0x000A2DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsInterrupt
		{
			get
			{
				return this.isInterrupt_;
			}
			set
			{
				this.isInterrupt_ = value;
			}
		}

		// Token: 0x0600431A RID: 17178 RVA: 0x000A4BE2 File Offset: 0x000A2DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharacterMoveToPointEndPush);
		}

		// Token: 0x0600431B RID: 17179 RVA: 0x000A4BF0 File Offset: 0x000A2DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CharacterMoveToPointEndPush other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsInterrupt == other.IsInterrupt && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600431C RID: 17180 RVA: 0x000A4C30 File Offset: 0x000A2E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsInterrupt)
			{
				num ^= this.IsInterrupt.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600431D RID: 17181 RVA: 0x000A4C88 File Offset: 0x000A2E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600431E RID: 17182 RVA: 0x000A4C95 File Offset: 0x000A2E95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600431F RID: 17183 RVA: 0x000A4CA0 File Offset: 0x000A2EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsInterrupt)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsInterrupt);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004320 RID: 17184 RVA: 0x000A4CFC File Offset: 0x000A2EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.IsInterrupt)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004321 RID: 17185 RVA: 0x000A4D48 File Offset: 0x000A2F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CharacterMoveToPointEndPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsInterrupt)
			{
				this.IsInterrupt = other.IsInterrupt;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004322 RID: 17186 RVA: 0x000A4D98 File Offset: 0x000A2F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004323 RID: 17187 RVA: 0x000A4DA4 File Offset: 0x000A2FA4
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
				if (num != 112U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.IsInterrupt = input.ReadBool();
				}
			}
		}

		// Token: 0x04002E87 RID: 11911
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E88 RID: 11912
		public const int EntityIdFieldNumber = 15;

		// Token: 0x04002E89 RID: 11913
		private long entityId_;

		// Token: 0x04002E8A RID: 11914
		public const int IsInterruptFieldNumber = 14;

		// Token: 0x04002E8B RID: 11915
		private bool isInterrupt_;
	}
}
