using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200134C RID: 4940
	public sealed class TemporaryTeleportParam : IMessage<TemporaryTeleportParam>, IMessage, IEquatable<TemporaryTeleportParam>, IDeepCloneable<TemporaryTeleportParam>, IBufferMessage
	{
		// Token: 0x0601A3F4 RID: 107508 RVA: 0x003D0343 File Offset: 0x003CE543
		[NullableContext(1)]
		public static TemporaryTeleportParam Create()
		{
			return new TemporaryTeleportParam();
		}

		// Token: 0x1700588E RID: 22670
		// (get) Token: 0x0601A3F5 RID: 107509 RVA: 0x003D034A File Offset: 0x003CE54A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700588F RID: 22671
		// (get) Token: 0x0601A3F6 RID: 107510 RVA: 0x003D034D File Offset: 0x003CE54D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TemporaryTeleportParam.Descriptor;
			}
		}

		// Token: 0x0601A3F7 RID: 107511 RVA: 0x003D0354 File Offset: 0x003CE554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportParam()
		{
		}

		// Token: 0x0601A3F8 RID: 107512 RVA: 0x003D035C File Offset: 0x003CE55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportParam(TemporaryTeleportParam other) : this()
		{
			this.temporaryTeleportId_ = other.temporaryTeleportId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A3F9 RID: 107513 RVA: 0x003D0381 File Offset: 0x003CE581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportParam Clone()
		{
			return new TemporaryTeleportParam(this);
		}

		// Token: 0x17005890 RID: 22672
		// (get) Token: 0x0601A3FA RID: 107514 RVA: 0x003D0389 File Offset: 0x003CE589
		// (set) Token: 0x0601A3FB RID: 107515 RVA: 0x003D0391 File Offset: 0x003CE591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TemporaryTeleportId
		{
			get
			{
				return this.temporaryTeleportId_;
			}
			set
			{
				this.temporaryTeleportId_ = value;
			}
		}

		// Token: 0x0601A3FC RID: 107516 RVA: 0x003D039A File Offset: 0x003CE59A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TemporaryTeleportParam);
		}

		// Token: 0x0601A3FD RID: 107517 RVA: 0x003D03A8 File Offset: 0x003CE5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TemporaryTeleportParam other)
		{
			return other != null && (other == this || (this.TemporaryTeleportId == other.TemporaryTeleportId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A3FE RID: 107518 RVA: 0x003D03D8 File Offset: 0x003CE5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TemporaryTeleportId != 0L)
			{
				num ^= this.TemporaryTeleportId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A3FF RID: 107519 RVA: 0x003D0417 File Offset: 0x003CE617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A400 RID: 107520 RVA: 0x003D0424 File Offset: 0x003CE624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A401 RID: 107521 RVA: 0x003D042D File Offset: 0x003CE62D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TemporaryTeleportId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.TemporaryTeleportId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A402 RID: 107522 RVA: 0x003D0460 File Offset: 0x003CE660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TemporaryTeleportId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TemporaryTeleportId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A403 RID: 107523 RVA: 0x003D049E File Offset: 0x003CE69E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TemporaryTeleportParam other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TemporaryTeleportId != 0L)
			{
				this.TemporaryTeleportId = other.TemporaryTeleportId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A404 RID: 107524 RVA: 0x003D04CF File Offset: 0x003CE6CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A405 RID: 107525 RVA: 0x003D04D8 File Offset: 0x003CE6D8
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TemporaryTeleportId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400991F RID: 39199
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009920 RID: 39200
		public const int TemporaryTeleportIdFieldNumber = 1;

		// Token: 0x04009921 RID: 39201
		private long temporaryTeleportId_;
	}
}
