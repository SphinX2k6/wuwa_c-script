using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004B2 RID: 1202
	[NetMessage(EMessageId.EntityPosAbnormalResponse)]
	public sealed class EntityPosAbnormalResponse : IMessage<EntityPosAbnormalResponse>, IMessage, IEquatable<EntityPosAbnormalResponse>, IDeepCloneable<EntityPosAbnormalResponse>, IBufferMessage
	{
		// Token: 0x06007294 RID: 29332 RVA: 0x00119398 File Offset: 0x00117598
		[NullableContext(1)]
		public static EntityPosAbnormalResponse Create()
		{
			return new EntityPosAbnormalResponse();
		}

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x06007295 RID: 29333 RVA: 0x0011939F File Offset: 0x0011759F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x06007296 RID: 29334 RVA: 0x001193A2 File Offset: 0x001175A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPosAbnormalResponse.Descriptor;
			}
		}

		// Token: 0x06007297 RID: 29335 RVA: 0x001193A9 File Offset: 0x001175A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPosAbnormalResponse()
		{
		}

		// Token: 0x06007298 RID: 29336 RVA: 0x001193B1 File Offset: 0x001175B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPosAbnormalResponse(EntityPosAbnormalResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007299 RID: 29337 RVA: 0x001193D6 File Offset: 0x001175D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPosAbnormalResponse Clone()
		{
			return new EntityPosAbnormalResponse(this);
		}

		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x0600729A RID: 29338 RVA: 0x001193DE File Offset: 0x001175DE
		// (set) Token: 0x0600729B RID: 29339 RVA: 0x001193E6 File Offset: 0x001175E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x0600729C RID: 29340 RVA: 0x001193EF File Offset: 0x001175EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPosAbnormalResponse);
		}

		// Token: 0x0600729D RID: 29341 RVA: 0x001193FD File Offset: 0x001175FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPosAbnormalResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600729E RID: 29342 RVA: 0x0011942C File Offset: 0x0011762C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600729F RID: 29343 RVA: 0x00119471 File Offset: 0x00117671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060072A0 RID: 29344 RVA: 0x0011947E File Offset: 0x0011767E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060072A1 RID: 29345 RVA: 0x00119487 File Offset: 0x00117687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060072A2 RID: 29346 RVA: 0x001194BC File Offset: 0x001176BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060072A3 RID: 29347 RVA: 0x001194FA File Offset: 0x001176FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityPosAbnormalResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060072A4 RID: 29348 RVA: 0x0011952B File Offset: 0x0011772B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060072A5 RID: 29349 RVA: 0x00119534 File Offset: 0x00117734
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003CEE RID: 15598
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CEF RID: 15599
		public const int CodeFieldNumber = 6;

		// Token: 0x04003CF0 RID: 15600
		private ErrorCode code_;
	}
}
