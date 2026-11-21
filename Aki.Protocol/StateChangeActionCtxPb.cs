using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001300 RID: 4864
	public sealed class StateChangeActionCtxPb : IMessage<StateChangeActionCtxPb>, IMessage, IEquatable<StateChangeActionCtxPb>, IDeepCloneable<StateChangeActionCtxPb>, IBufferMessage
	{
		// Token: 0x06019F20 RID: 106272 RVA: 0x003C8870 File Offset: 0x003C6A70
		[NullableContext(1)]
		public static StateChangeActionCtxPb Create()
		{
			return new StateChangeActionCtxPb();
		}

		// Token: 0x170057DE RID: 22494
		// (get) Token: 0x06019F21 RID: 106273 RVA: 0x003C8877 File Offset: 0x003C6A77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057DF RID: 22495
		// (get) Token: 0x06019F22 RID: 106274 RVA: 0x003C887A File Offset: 0x003C6A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StateChangeActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06019F23 RID: 106275 RVA: 0x003C8881 File Offset: 0x003C6A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StateChangeActionCtxPb()
		{
		}

		// Token: 0x06019F24 RID: 106276 RVA: 0x003C888C File Offset: 0x003C6A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StateChangeActionCtxPb(StateChangeActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.stateIndex_ = other.stateIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019F25 RID: 106277 RVA: 0x003C88D8 File Offset: 0x003C6AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StateChangeActionCtxPb Clone()
		{
			return new StateChangeActionCtxPb(this);
		}

		// Token: 0x170057E0 RID: 22496
		// (get) Token: 0x06019F26 RID: 106278 RVA: 0x003C88E0 File Offset: 0x003C6AE0
		// (set) Token: 0x06019F27 RID: 106279 RVA: 0x003C88E8 File Offset: 0x003C6AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCtxPb EntityCtx
		{
			get
			{
				return this.entityCtx_;
			}
			set
			{
				this.entityCtx_ = value;
			}
		}

		// Token: 0x170057E1 RID: 22497
		// (get) Token: 0x06019F28 RID: 106280 RVA: 0x003C88F1 File Offset: 0x003C6AF1
		// (set) Token: 0x06019F29 RID: 106281 RVA: 0x003C88F9 File Offset: 0x003C6AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StateIndex
		{
			get
			{
				return this.stateIndex_;
			}
			set
			{
				this.stateIndex_ = value;
			}
		}

		// Token: 0x06019F2A RID: 106282 RVA: 0x003C8902 File Offset: 0x003C6B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StateChangeActionCtxPb);
		}

		// Token: 0x06019F2B RID: 106283 RVA: 0x003C8910 File Offset: 0x003C6B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StateChangeActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.StateIndex == other.StateIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019F2C RID: 106284 RVA: 0x003C8960 File Offset: 0x003C6B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this.StateIndex != 0)
			{
				num ^= this.StateIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019F2D RID: 106285 RVA: 0x003C89B5 File Offset: 0x003C6BB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019F2E RID: 106286 RVA: 0x003C89C2 File Offset: 0x003C6BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019F2F RID: 106287 RVA: 0x003C89CC File Offset: 0x003C6BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.StateIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.StateIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019F30 RID: 106288 RVA: 0x003C8A28 File Offset: 0x003C6C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this.StateIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StateIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019F31 RID: 106289 RVA: 0x003C8A80 File Offset: 0x003C6C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StateChangeActionCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.entityCtx_ != null)
			{
				if (this.entityCtx_ == null)
				{
					this.EntityCtx = new EntityCtxPb();
				}
				this.EntityCtx.MergeFrom(other.EntityCtx);
			}
			if (other.StateIndex != 0)
			{
				this.StateIndex = other.StateIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019F32 RID: 106290 RVA: 0x003C8AE8 File Offset: 0x003C6CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019F33 RID: 106291 RVA: 0x003C8AF4 File Offset: 0x003C6CF4
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.StateIndex = input.ReadInt32();
					}
				}
				else
				{
					if (this.entityCtx_ == null)
					{
						this.EntityCtx = new EntityCtxPb();
					}
					input.ReadMessage(this.EntityCtx);
				}
			}
		}

		// Token: 0x040098EE RID: 39150
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098EF RID: 39151
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x040098F0 RID: 39152
		private EntityCtxPb entityCtx_;

		// Token: 0x040098F1 RID: 39153
		public const int StateIndexFieldNumber = 2;

		// Token: 0x040098F2 RID: 39154
		private int stateIndex_;
	}
}
