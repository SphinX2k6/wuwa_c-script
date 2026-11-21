using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200038C RID: 908
	public sealed class DangoMonopolyCtx : IMessage<DangoMonopolyCtx>, IMessage, IEquatable<DangoMonopolyCtx>, IDeepCloneable<DangoMonopolyCtx>, IBufferMessage
	{
		// Token: 0x06005A0A RID: 23050 RVA: 0x000DB939 File Offset: 0x000D9B39
		[NullableContext(1)]
		public static DangoMonopolyCtx Create()
		{
			return new DangoMonopolyCtx();
		}

		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x06005A0B RID: 23051 RVA: 0x000DB940 File Offset: 0x000D9B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x06005A0C RID: 23052 RVA: 0x000DB943 File Offset: 0x000D9B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyCtx.Descriptor;
			}
		}

		// Token: 0x06005A0D RID: 23053 RVA: 0x000DB94A File Offset: 0x000D9B4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyCtx()
		{
		}

		// Token: 0x06005A0E RID: 23054 RVA: 0x000DB952 File Offset: 0x000D9B52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyCtx(DangoMonopolyCtx other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A0F RID: 23055 RVA: 0x000DB977 File Offset: 0x000D9B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyCtx Clone()
		{
			return new DangoMonopolyCtx(this);
		}

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x06005A10 RID: 23056 RVA: 0x000DB97F File Offset: 0x000D9B7F
		// (set) Token: 0x06005A11 RID: 23057 RVA: 0x000DB987 File Offset: 0x000D9B87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x06005A12 RID: 23058 RVA: 0x000DB990 File Offset: 0x000D9B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyCtx);
		}

		// Token: 0x06005A13 RID: 23059 RVA: 0x000DB99E File Offset: 0x000D9B9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyCtx other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005A14 RID: 23060 RVA: 0x000DB9CC File Offset: 0x000D9BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005A15 RID: 23061 RVA: 0x000DBA0B File Offset: 0x000D9C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005A16 RID: 23062 RVA: 0x000DBA18 File Offset: 0x000D9C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A17 RID: 23063 RVA: 0x000DBA21 File Offset: 0x000D9C21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A18 RID: 23064 RVA: 0x000DBA54 File Offset: 0x000D9C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005A19 RID: 23065 RVA: 0x000DBA92 File Offset: 0x000D9C92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005A1A RID: 23066 RVA: 0x000DBAC3 File Offset: 0x000D9CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A1B RID: 23067 RVA: 0x000DBACC File Offset: 0x000D9CCC
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
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040035EB RID: 13803
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035EC RID: 13804
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x040035ED RID: 13805
		private int activityId_;
	}
}
