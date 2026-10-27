using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001173 RID: 4467
	[NetMessage(EMessageId.SceneItemSetPosSenderNotify)]
	public sealed class SceneItemSetPosSenderNotify : IMessage<SceneItemSetPosSenderNotify>, IMessage, IEquatable<SceneItemSetPosSenderNotify>, IDeepCloneable<SceneItemSetPosSenderNotify>, IBufferMessage
	{
		// Token: 0x06017D05 RID: 97541 RVA: 0x003758D1 File Offset: 0x00373AD1
		[NullableContext(1)]
		public static SceneItemSetPosSenderNotify Create()
		{
			return new SceneItemSetPosSenderNotify();
		}

		// Token: 0x17004FFF RID: 20479
		// (get) Token: 0x06017D06 RID: 97542 RVA: 0x003758D8 File Offset: 0x00373AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005000 RID: 20480
		// (get) Token: 0x06017D07 RID: 97543 RVA: 0x003758DB File Offset: 0x00373ADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemSetPosSenderNotify.Descriptor;
			}
		}

		// Token: 0x06017D08 RID: 97544 RVA: 0x003758E2 File Offset: 0x00373AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSetPosSenderNotify()
		{
		}

		// Token: 0x06017D09 RID: 97545 RVA: 0x003758EA File Offset: 0x00373AEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSetPosSenderNotify(SceneItemSetPosSenderNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.posSender_ = other.posSender_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017D0A RID: 97546 RVA: 0x0037591B File Offset: 0x00373B1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSetPosSenderNotify Clone()
		{
			return new SceneItemSetPosSenderNotify(this);
		}

		// Token: 0x17005001 RID: 20481
		// (get) Token: 0x06017D0B RID: 97547 RVA: 0x00375923 File Offset: 0x00373B23
		// (set) Token: 0x06017D0C RID: 97548 RVA: 0x0037592B File Offset: 0x00373B2B
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

		// Token: 0x17005002 RID: 20482
		// (get) Token: 0x06017D0D RID: 97549 RVA: 0x00375934 File Offset: 0x00373B34
		// (set) Token: 0x06017D0E RID: 97550 RVA: 0x0037593C File Offset: 0x00373B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PosSender
		{
			get
			{
				return this.posSender_;
			}
			set
			{
				this.posSender_ = value;
			}
		}

		// Token: 0x06017D0F RID: 97551 RVA: 0x00375945 File Offset: 0x00373B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemSetPosSenderNotify);
		}

		// Token: 0x06017D10 RID: 97552 RVA: 0x00375953 File Offset: 0x00373B53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemSetPosSenderNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.PosSender == other.PosSender && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017D11 RID: 97553 RVA: 0x00375994 File Offset: 0x00373B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.PosSender != 0)
			{
				num ^= this.PosSender.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017D12 RID: 97554 RVA: 0x003759EC File Offset: 0x00373BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017D13 RID: 97555 RVA: 0x003759F9 File Offset: 0x00373BF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017D14 RID: 97556 RVA: 0x00375A04 File Offset: 0x00373C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PosSender != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PosSender);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017D15 RID: 97557 RVA: 0x00375A60 File Offset: 0x00373C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.PosSender != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PosSender);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017D16 RID: 97558 RVA: 0x00375AB8 File Offset: 0x00373CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemSetPosSenderNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.PosSender != 0)
			{
				this.PosSender = other.PosSender;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017D17 RID: 97559 RVA: 0x00375B08 File Offset: 0x00373D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017D18 RID: 97560 RVA: 0x00375B14 File Offset: 0x00373D14
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
					if (num != 96U)
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
					this.PosSender = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008D3A RID: 36154
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D3B RID: 36155
		public const int EntityIdFieldNumber = 12;

		// Token: 0x04008D3C RID: 36156
		private long entityId_;

		// Token: 0x04008D3D RID: 36157
		public const int PosSenderFieldNumber = 8;

		// Token: 0x04008D3E RID: 36158
		private int posSender_;
	}
}
