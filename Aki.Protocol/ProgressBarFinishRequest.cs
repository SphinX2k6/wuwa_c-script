using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DE8 RID: 3560
	[NetMessage(EMessageId.ProgressBarFinishRequest)]
	public sealed class ProgressBarFinishRequest : IMessage<ProgressBarFinishRequest>, IMessage, IEquatable<ProgressBarFinishRequest>, IDeepCloneable<ProgressBarFinishRequest>, IBufferMessage
	{
		// Token: 0x06013271 RID: 78449 RVA: 0x002CA392 File Offset: 0x002C8592
		[NullableContext(1)]
		public static ProgressBarFinishRequest Create()
		{
			return new ProgressBarFinishRequest();
		}

		// Token: 0x17003F8B RID: 16267
		// (get) Token: 0x06013272 RID: 78450 RVA: 0x002CA399 File Offset: 0x002C8599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F8C RID: 16268
		// (get) Token: 0x06013273 RID: 78451 RVA: 0x002CA39C File Offset: 0x002C859C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProgressBarFinishRequest.Descriptor;
			}
		}

		// Token: 0x06013274 RID: 78452 RVA: 0x002CA3A3 File Offset: 0x002C85A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProgressBarFinishRequest()
		{
		}

		// Token: 0x06013275 RID: 78453 RVA: 0x002CA3AB File Offset: 0x002C85AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProgressBarFinishRequest(ProgressBarFinishRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013276 RID: 78454 RVA: 0x002CA3D0 File Offset: 0x002C85D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProgressBarFinishRequest Clone()
		{
			return new ProgressBarFinishRequest(this);
		}

		// Token: 0x17003F8D RID: 16269
		// (get) Token: 0x06013277 RID: 78455 RVA: 0x002CA3D8 File Offset: 0x002C85D8
		// (set) Token: 0x06013278 RID: 78456 RVA: 0x002CA3E0 File Offset: 0x002C85E0
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

		// Token: 0x06013279 RID: 78457 RVA: 0x002CA3E9 File Offset: 0x002C85E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ProgressBarFinishRequest);
		}

		// Token: 0x0601327A RID: 78458 RVA: 0x002CA3F7 File Offset: 0x002C85F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ProgressBarFinishRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601327B RID: 78459 RVA: 0x002CA428 File Offset: 0x002C8628
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

		// Token: 0x0601327C RID: 78460 RVA: 0x002CA467 File Offset: 0x002C8667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601327D RID: 78461 RVA: 0x002CA474 File Offset: 0x002C8674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601327E RID: 78462 RVA: 0x002CA47D File Offset: 0x002C867D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601327F RID: 78463 RVA: 0x002CA4B0 File Offset: 0x002C86B0
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

		// Token: 0x06013280 RID: 78464 RVA: 0x002CA4EE File Offset: 0x002C86EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ProgressBarFinishRequest other)
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

		// Token: 0x06013281 RID: 78465 RVA: 0x002CA51F File Offset: 0x002C871F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013282 RID: 78466 RVA: 0x002CA528 File Offset: 0x002C8728
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007600 RID: 30208
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007601 RID: 30209
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04007602 RID: 30210
		private long entityId_;
	}
}
