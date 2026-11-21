using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000194 RID: 404
	[NetMessage(EMessageId.BeControlledThrowRequest)]
	public sealed class BeControlledThrowRequest : IMessage<BeControlledThrowRequest>, IMessage, IEquatable<BeControlledThrowRequest>, IDeepCloneable<BeControlledThrowRequest>, IBufferMessage
	{
		// Token: 0x0600304A RID: 12362 RVA: 0x0007B97D File Offset: 0x00079B7D
		[NullableContext(1)]
		public static BeControlledThrowRequest Create()
		{
			return new BeControlledThrowRequest();
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x0600304B RID: 12363 RVA: 0x0007B984 File Offset: 0x00079B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x0600304C RID: 12364 RVA: 0x0007B987 File Offset: 0x00079B87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledThrowRequest.Descriptor;
			}
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x0007B98E File Offset: 0x00079B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledThrowRequest()
		{
		}

		// Token: 0x0600304E RID: 12366 RVA: 0x0007B996 File Offset: 0x00079B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledThrowRequest(BeControlledThrowRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.throwType_ = other.throwType_;
			this.controlState_ = other.controlState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600304F RID: 12367 RVA: 0x0007B9D3 File Offset: 0x00079BD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledThrowRequest Clone()
		{
			return new BeControlledThrowRequest(this);
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06003050 RID: 12368 RVA: 0x0007B9DB File Offset: 0x00079BDB
		// (set) Token: 0x06003051 RID: 12369 RVA: 0x0007B9E3 File Offset: 0x00079BE3
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

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06003052 RID: 12370 RVA: 0x0007B9EC File Offset: 0x00079BEC
		// (set) Token: 0x06003053 RID: 12371 RVA: 0x0007B9F4 File Offset: 0x00079BF4
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

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06003054 RID: 12372 RVA: 0x0007B9FD File Offset: 0x00079BFD
		// (set) Token: 0x06003055 RID: 12373 RVA: 0x0007BA05 File Offset: 0x00079C05
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

		// Token: 0x06003056 RID: 12374 RVA: 0x0007BA0E File Offset: 0x00079C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledThrowRequest);
		}

		// Token: 0x06003057 RID: 12375 RVA: 0x0007BA1C File Offset: 0x00079C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledThrowRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.ThrowType == other.ThrowType && this.ControlState == other.ControlState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003058 RID: 12376 RVA: 0x0007BA78 File Offset: 0x00079C78
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

		// Token: 0x06003059 RID: 12377 RVA: 0x0007BAEF File Offset: 0x00079CEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600305A RID: 12378 RVA: 0x0007BAFC File Offset: 0x00079CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600305B RID: 12379 RVA: 0x0007BB08 File Offset: 0x00079D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ControlState != EControlState.LetGo)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ControlState);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.ThrowType != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ThrowType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600305C RID: 12380 RVA: 0x0007BB80 File Offset: 0x00079D80
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

		// Token: 0x0600305D RID: 12381 RVA: 0x0007BBF0 File Offset: 0x00079DF0
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

		// Token: 0x0600305E RID: 12382 RVA: 0x0007BC54 File Offset: 0x00079E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600305F RID: 12383 RVA: 0x0007BC60 File Offset: 0x00079E60
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
				if (num != 16U)
				{
					if (num != 40U)
					{
						if (num != 72U)
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

		// Token: 0x0400293D RID: 10557
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400293E RID: 10558
		public const int EntityIdFieldNumber = 5;

		// Token: 0x0400293F RID: 10559
		private long entityId_;

		// Token: 0x04002940 RID: 10560
		public const int ThrowTypeFieldNumber = 9;

		// Token: 0x04002941 RID: 10561
		private int throwType_;

		// Token: 0x04002942 RID: 10562
		public const int ControlStateFieldNumber = 2;

		// Token: 0x04002943 RID: 10563
		private EControlState controlState_;
	}
}
