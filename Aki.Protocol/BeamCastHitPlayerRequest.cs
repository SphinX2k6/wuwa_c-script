using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000185 RID: 389
	[NetMessage(EMessageId.BeamCastHitPlayerRequest)]
	public sealed class BeamCastHitPlayerRequest : IMessage<BeamCastHitPlayerRequest>, IMessage, IEquatable<BeamCastHitPlayerRequest>, IDeepCloneable<BeamCastHitPlayerRequest>, IBufferMessage
	{
		// Token: 0x06002F20 RID: 12064 RVA: 0x000793E4 File Offset: 0x000775E4
		[NullableContext(1)]
		public static BeamCastHitPlayerRequest Create()
		{
			return new BeamCastHitPlayerRequest();
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06002F21 RID: 12065 RVA: 0x000793EB File Offset: 0x000775EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06002F22 RID: 12066 RVA: 0x000793EE File Offset: 0x000775EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeamCastHitPlayerRequest.Descriptor;
			}
		}

		// Token: 0x06002F23 RID: 12067 RVA: 0x000793F5 File Offset: 0x000775F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamCastHitPlayerRequest()
		{
		}

		// Token: 0x06002F24 RID: 12068 RVA: 0x000793FD File Offset: 0x000775FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamCastHitPlayerRequest(BeamCastHitPlayerRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x00079422 File Offset: 0x00077622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamCastHitPlayerRequest Clone()
		{
			return new BeamCastHitPlayerRequest(this);
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06002F26 RID: 12070 RVA: 0x0007942A File Offset: 0x0007762A
		// (set) Token: 0x06002F27 RID: 12071 RVA: 0x00079432 File Offset: 0x00077632
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

		// Token: 0x06002F28 RID: 12072 RVA: 0x0007943B File Offset: 0x0007763B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeamCastHitPlayerRequest);
		}

		// Token: 0x06002F29 RID: 12073 RVA: 0x00079449 File Offset: 0x00077649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeamCastHitPlayerRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002F2A RID: 12074 RVA: 0x00079478 File Offset: 0x00077678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06002F2B RID: 12075 RVA: 0x000794B7 File Offset: 0x000776B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002F2C RID: 12076 RVA: 0x000794C4 File Offset: 0x000776C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002F2D RID: 12077 RVA: 0x000794CD File Offset: 0x000776CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x06002F2E RID: 12078 RVA: 0x00079500 File Offset: 0x00077700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06002F2F RID: 12079 RVA: 0x0007953E File Offset: 0x0007773E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeamCastHitPlayerRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x0007956F File Offset: 0x0007776F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002F31 RID: 12081 RVA: 0x00079578 File Offset: 0x00077778
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040028F4 RID: 10484
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028F5 RID: 10485
		public const int EntityIdFieldNumber = 15;

		// Token: 0x040028F6 RID: 10486
		private long entityId_;
	}
}
