using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000278 RID: 632
	[NetMessage(EMessageId.CharacterMoveToPointEndPush)]
	public sealed class CharacterMoveToPointEndPush : IMessage<CharacterMoveToPointEndPush>, IMessage, IEquatable<CharacterMoveToPointEndPush>, IDeepCloneable<CharacterMoveToPointEndPush>, IBufferMessage
	{
		// Token: 0x06004269 RID: 17001 RVA: 0x000A2EA2 File Offset: 0x000A10A2
		[NullableContext(1)]
		public static CharacterMoveToPointEndPush Create()
		{
			return new CharacterMoveToPointEndPush();
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x0600426A RID: 17002 RVA: 0x000A2EA9 File Offset: 0x000A10A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x0600426B RID: 17003 RVA: 0x000A2EAC File Offset: 0x000A10AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharacterMoveToPointEndPush.Descriptor;
			}
		}

		// Token: 0x0600426C RID: 17004 RVA: 0x000A2EB3 File Offset: 0x000A10B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterMoveToPointEndPush()
		{
		}

		// Token: 0x0600426D RID: 17005 RVA: 0x000A2EBB File Offset: 0x000A10BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterMoveToPointEndPush(CharacterMoveToPointEndPush other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isInterrupt_ = other.isInterrupt_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600426E RID: 17006 RVA: 0x000A2EEC File Offset: 0x000A10EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterMoveToPointEndPush Clone()
		{
			return new CharacterMoveToPointEndPush(this);
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x0600426F RID: 17007 RVA: 0x000A2EF4 File Offset: 0x000A10F4
		// (set) Token: 0x06004270 RID: 17008 RVA: 0x000A2EFC File Offset: 0x000A10FC
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

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06004271 RID: 17009 RVA: 0x000A2F05 File Offset: 0x000A1105
		// (set) Token: 0x06004272 RID: 17010 RVA: 0x000A2F0D File Offset: 0x000A110D
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

		// Token: 0x06004273 RID: 17011 RVA: 0x000A2F16 File Offset: 0x000A1116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharacterMoveToPointEndPush);
		}

		// Token: 0x06004274 RID: 17012 RVA: 0x000A2F24 File Offset: 0x000A1124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CharacterMoveToPointEndPush other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsInterrupt == other.IsInterrupt && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004275 RID: 17013 RVA: 0x000A2F64 File Offset: 0x000A1164
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

		// Token: 0x06004276 RID: 17014 RVA: 0x000A2FBC File Offset: 0x000A11BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004277 RID: 17015 RVA: 0x000A2FC9 File Offset: 0x000A11C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004278 RID: 17016 RVA: 0x000A2FD4 File Offset: 0x000A11D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsInterrupt)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsInterrupt);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004279 RID: 17017 RVA: 0x000A3030 File Offset: 0x000A1230
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

		// Token: 0x0600427A RID: 17018 RVA: 0x000A307C File Offset: 0x000A127C
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

		// Token: 0x0600427B RID: 17019 RVA: 0x000A30CC File Offset: 0x000A12CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600427C RID: 17020 RVA: 0x000A30D8 File Offset: 0x000A12D8
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
				if (num != 24U)
				{
					if (num != 40U)
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

		// Token: 0x04002E03 RID: 11779
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E04 RID: 11780
		public const int EntityIdFieldNumber = 5;

		// Token: 0x04002E05 RID: 11781
		private long entityId_;

		// Token: 0x04002E06 RID: 11782
		public const int IsInterruptFieldNumber = 3;

		// Token: 0x04002E07 RID: 11783
		private bool isInterrupt_;
	}
}
