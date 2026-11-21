using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000050 RID: 80
	[NetMessage(EMessageId.AccessForceClosedAreaNotify)]
	public sealed class AccessForceClosedAreaNotify : IMessage<AccessForceClosedAreaNotify>, IMessage, IEquatable<AccessForceClosedAreaNotify>, IDeepCloneable<AccessForceClosedAreaNotify>, IBufferMessage
	{
		// Token: 0x06001500 RID: 5376 RVA: 0x00038071 File Offset: 0x00036271
		[NullableContext(1)]
		public static AccessForceClosedAreaNotify Create()
		{
			return new AccessForceClosedAreaNotify();
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06001501 RID: 5377 RVA: 0x00038078 File Offset: 0x00036278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x0003807B File Offset: 0x0003627B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccessForceClosedAreaNotify.Descriptor;
			}
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00038082 File Offset: 0x00036282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessForceClosedAreaNotify()
		{
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x0003808C File Offset: 0x0003628C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessForceClosedAreaNotify(AccessForceClosedAreaNotify other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this.isEnter_ = other.isEnter_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x000380E0 File Offset: 0x000362E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessForceClosedAreaNotify Clone()
		{
			return new AccessForceClosedAreaNotify(this);
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x000380E8 File Offset: 0x000362E8
		// (set) Token: 0x06001507 RID: 5383 RVA: 0x000380F0 File Offset: 0x000362F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeOwnerId
		{
			get
			{
				return this.treeOwnerId_;
			}
			set
			{
				this.treeOwnerId_ = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x000380F9 File Offset: 0x000362F9
		// (set) Token: 0x06001509 RID: 5385 RVA: 0x00038101 File Offset: 0x00036301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TreeIncId
		{
			get
			{
				return this.treeIncId_;
			}
			set
			{
				this.treeIncId_ = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x0003810A File Offset: 0x0003630A
		// (set) Token: 0x0600150B RID: 5387 RVA: 0x00038112 File Offset: 0x00036312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NodeId
		{
			get
			{
				return this.nodeId_;
			}
			set
			{
				this.nodeId_ = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600150C RID: 5388 RVA: 0x0003811B File Offset: 0x0003631B
		// (set) Token: 0x0600150D RID: 5389 RVA: 0x00038123 File Offset: 0x00036323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEnter
		{
			get
			{
				return this.isEnter_;
			}
			set
			{
				this.isEnter_ = value;
			}
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x0003812C File Offset: 0x0003632C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccessForceClosedAreaNotify);
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x0003813C File Offset: 0x0003633C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AccessForceClosedAreaNotify other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.IsEnter == other.IsEnter && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x000381A8 File Offset: 0x000363A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeOwnerId != 0)
			{
				num ^= this.TreeOwnerId.GetHashCode();
			}
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
			}
			if (this.NodeId != 0)
			{
				num ^= this.NodeId.GetHashCode();
			}
			if (this.IsEnter)
			{
				num ^= this.IsEnter.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x00038232 File Offset: 0x00036432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x0003823F File Offset: 0x0003643F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x00038248 File Offset: 0x00036448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.IsEnter)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsEnter);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.NodeId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x000382D8 File Offset: 0x000364D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeOwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
			}
			if (this.NodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NodeId);
			}
			if (this.IsEnter)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x00038354 File Offset: 0x00036554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AccessForceClosedAreaNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeOwnerId != 0)
			{
				this.TreeOwnerId = other.TreeOwnerId;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
			}
			if (other.NodeId != 0)
			{
				this.NodeId = other.NodeId;
			}
			if (other.IsEnter)
			{
				this.IsEnter = other.IsEnter;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x000383CC File Offset: 0x000365CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x000383D8 File Offset: 0x000365D8
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.IsEnter = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040020CF RID: 8399
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020D0 RID: 8400
		public const int TreeOwnerIdFieldNumber = 1;

		// Token: 0x040020D1 RID: 8401
		private int treeOwnerId_;

		// Token: 0x040020D2 RID: 8402
		public const int TreeIncIdFieldNumber = 5;

		// Token: 0x040020D3 RID: 8403
		private long treeIncId_;

		// Token: 0x040020D4 RID: 8404
		public const int NodeIdFieldNumber = 4;

		// Token: 0x040020D5 RID: 8405
		private int nodeId_;

		// Token: 0x040020D6 RID: 8406
		public const int IsEnterFieldNumber = 2;

		// Token: 0x040020D7 RID: 8407
		private bool isEnter_;
	}
}
