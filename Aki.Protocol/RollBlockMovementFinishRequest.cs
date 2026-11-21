using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200111A RID: 4378
	[NetMessage(EMessageId.RollBlockMovementFinishRequest)]
	public sealed class RollBlockMovementFinishRequest : IMessage<RollBlockMovementFinishRequest>, IMessage, IEquatable<RollBlockMovementFinishRequest>, IDeepCloneable<RollBlockMovementFinishRequest>, IBufferMessage
	{
		// Token: 0x0601765C RID: 95836 RVA: 0x00367887 File Offset: 0x00365A87
		[NullableContext(1)]
		public static RollBlockMovementFinishRequest Create()
		{
			return new RollBlockMovementFinishRequest();
		}

		// Token: 0x17004EA0 RID: 20128
		// (get) Token: 0x0601765D RID: 95837 RVA: 0x0036788E File Offset: 0x00365A8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EA1 RID: 20129
		// (get) Token: 0x0601765E RID: 95838 RVA: 0x00367891 File Offset: 0x00365A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockMovementFinishRequest.Descriptor;
			}
		}

		// Token: 0x0601765F RID: 95839 RVA: 0x00367898 File Offset: 0x00365A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockMovementFinishRequest()
		{
		}

		// Token: 0x06017660 RID: 95840 RVA: 0x003678A0 File Offset: 0x00365AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockMovementFinishRequest(RollBlockMovementFinishRequest other) : this()
		{
			this.incId_ = other.incId_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017661 RID: 95841 RVA: 0x003678D1 File Offset: 0x00365AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockMovementFinishRequest Clone()
		{
			return new RollBlockMovementFinishRequest(this);
		}

		// Token: 0x17004EA2 RID: 20130
		// (get) Token: 0x06017662 RID: 95842 RVA: 0x003678D9 File Offset: 0x00365AD9
		// (set) Token: 0x06017663 RID: 95843 RVA: 0x003678E1 File Offset: 0x00365AE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17004EA3 RID: 20131
		// (get) Token: 0x06017664 RID: 95844 RVA: 0x003678EA File Offset: 0x00365AEA
		// (set) Token: 0x06017665 RID: 95845 RVA: 0x003678F2 File Offset: 0x00365AF2
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

		// Token: 0x06017666 RID: 95846 RVA: 0x003678FB File Offset: 0x00365AFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockMovementFinishRequest);
		}

		// Token: 0x06017667 RID: 95847 RVA: 0x00367909 File Offset: 0x00365B09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockMovementFinishRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017668 RID: 95848 RVA: 0x00367948 File Offset: 0x00365B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017669 RID: 95849 RVA: 0x003679A0 File Offset: 0x00365BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601766A RID: 95850 RVA: 0x003679AD File Offset: 0x00365BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601766B RID: 95851 RVA: 0x003679B8 File Offset: 0x00365BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601766C RID: 95852 RVA: 0x00367A14 File Offset: 0x00365C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601766D RID: 95853 RVA: 0x00367A6C File Offset: 0x00365C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockMovementFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601766E RID: 95854 RVA: 0x00367ABC File Offset: 0x00365CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601766F RID: 95855 RVA: 0x00367AC8 File Offset: 0x00365CC8
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
				if (num != 48U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IncId = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008BBF RID: 35775
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BC0 RID: 35776
		public const int IncIdFieldNumber = 12;

		// Token: 0x04008BC1 RID: 35777
		private int incId_;

		// Token: 0x04008BC2 RID: 35778
		public const int EntityIdFieldNumber = 6;

		// Token: 0x04008BC3 RID: 35779
		private long entityId_;
	}
}
