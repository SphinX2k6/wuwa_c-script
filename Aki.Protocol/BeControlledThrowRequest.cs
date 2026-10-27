using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000191 RID: 401
	[NetMessage(EMessageId.BeControlledThrowRequest)]
	public sealed class BeControlledThrowRequest : IMessage<BeControlledThrowRequest>, IMessage, IEquatable<BeControlledThrowRequest>, IDeepCloneable<BeControlledThrowRequest>, IBufferMessage
	{
		// Token: 0x06002FD3 RID: 12243 RVA: 0x0007A545 File Offset: 0x00078745
		[NullableContext(1)]
		public static BeControlledThrowRequest Create()
		{
			return new BeControlledThrowRequest();
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06002FD4 RID: 12244 RVA: 0x0007A54C File Offset: 0x0007874C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06002FD5 RID: 12245 RVA: 0x0007A54F File Offset: 0x0007874F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledThrowRequest.Descriptor;
			}
		}

		// Token: 0x06002FD6 RID: 12246 RVA: 0x0007A556 File Offset: 0x00078756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledThrowRequest()
		{
		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x0007A55E File Offset: 0x0007875E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledThrowRequest(BeControlledThrowRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.throwType_ = other.throwType_;
			this.controlState_ = other.controlState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002FD8 RID: 12248 RVA: 0x0007A59B File Offset: 0x0007879B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledThrowRequest Clone()
		{
			return new BeControlledThrowRequest(this);
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06002FD9 RID: 12249 RVA: 0x0007A5A3 File Offset: 0x000787A3
		// (set) Token: 0x06002FDA RID: 12250 RVA: 0x0007A5AB File Offset: 0x000787AB
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

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06002FDB RID: 12251 RVA: 0x0007A5B4 File Offset: 0x000787B4
		// (set) Token: 0x06002FDC RID: 12252 RVA: 0x0007A5BC File Offset: 0x000787BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ThrowType
		{
			get
			{
				return this.throwType_;
			}
			set
			{
				this.throwType_ = value;
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06002FDD RID: 12253 RVA: 0x0007A5C5 File Offset: 0x000787C5
		// (set) Token: 0x06002FDE RID: 12254 RVA: 0x0007A5CD File Offset: 0x000787CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EControlState ControlState
		{
			get
			{
				return this.controlState_;
			}
			set
			{
				this.controlState_ = value;
			}
		}

		// Token: 0x06002FDF RID: 12255 RVA: 0x0007A5D6 File Offset: 0x000787D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledThrowRequest);
		}

		// Token: 0x06002FE0 RID: 12256 RVA: 0x0007A5E4 File Offset: 0x000787E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledThrowRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.ThrowType == other.ThrowType && this.ControlState == other.ControlState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002FE1 RID: 12257 RVA: 0x0007A640 File Offset: 0x00078840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.ThrowType != 0)
			{
				num ^= this.ThrowType.GetHashCode();
			}
			if (this.ControlState != EControlState.LetGo)
			{
				num ^= this.ControlState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002FE2 RID: 12258 RVA: 0x0007A6B7 File Offset: 0x000788B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002FE3 RID: 12259 RVA: 0x0007A6C4 File Offset: 0x000788C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002FE4 RID: 12260 RVA: 0x0007A6D0 File Offset: 0x000788D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ControlState != EControlState.LetGo)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ControlState);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this.ThrowType != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ThrowType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002FE5 RID: 12261 RVA: 0x0007A748 File Offset: 0x00078948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.ThrowType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ThrowType);
			}
			if (this.ControlState != EControlState.LetGo)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ControlState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002FE6 RID: 12262 RVA: 0x0007A7B8 File Offset: 0x000789B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeControlledThrowRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.ThrowType != 0)
			{
				this.ThrowType = other.ThrowType;
			}
			if (other.ControlState != EControlState.LetGo)
			{
				this.ControlState = other.ControlState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002FE7 RID: 12263 RVA: 0x0007A81C File Offset: 0x00078A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002FE8 RID: 12264 RVA: 0x0007A828 File Offset: 0x00078A28
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
					if (num != 80U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ThrowType = input.ReadInt32();
						}
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.ControlState = (EControlState)input.ReadEnum();
				}
			}
		}

		// Token: 0x040028C9 RID: 10441
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028CA RID: 10442
		public const int EntityIdFieldNumber = 10;

		// Token: 0x040028CB RID: 10443
		private long entityId_;

		// Token: 0x040028CC RID: 10444
		public const int ThrowTypeFieldNumber = 14;

		// Token: 0x040028CD RID: 10445
		private int throwType_;

		// Token: 0x040028CE RID: 10446
		public const int ControlStateFieldNumber = 4;

		// Token: 0x040028CF RID: 10447
		private EControlState controlState_;
	}
}
