using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200038D RID: 909
	[NetMessage(EMessageId.DangoMonopolyDiceRequest)]
	public sealed class DangoMonopolyDiceRequest : IMessage<DangoMonopolyDiceRequest>, IMessage, IEquatable<DangoMonopolyDiceRequest>, IDeepCloneable<DangoMonopolyDiceRequest>, IBufferMessage
	{
		// Token: 0x06005A1C RID: 23068 RVA: 0x000DBB10 File Offset: 0x000D9D10
		[NullableContext(1)]
		public static DangoMonopolyDiceRequest Create()
		{
			return new DangoMonopolyDiceRequest();
		}

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x06005A1D RID: 23069 RVA: 0x000DBB17 File Offset: 0x000D9D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x06005A1E RID: 23070 RVA: 0x000DBB1A File Offset: 0x000D9D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyDiceRequest.Descriptor;
			}
		}

		// Token: 0x06005A1F RID: 23071 RVA: 0x000DBB21 File Offset: 0x000D9D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyDiceRequest()
		{
		}

		// Token: 0x06005A20 RID: 23072 RVA: 0x000DBB29 File Offset: 0x000D9D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyDiceRequest(DangoMonopolyDiceRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A21 RID: 23073 RVA: 0x000DBB4E File Offset: 0x000D9D4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyDiceRequest Clone()
		{
			return new DangoMonopolyDiceRequest(this);
		}

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x06005A22 RID: 23074 RVA: 0x000DBB56 File Offset: 0x000D9D56
		// (set) Token: 0x06005A23 RID: 23075 RVA: 0x000DBB5E File Offset: 0x000D9D5E
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

		// Token: 0x06005A24 RID: 23076 RVA: 0x000DBB67 File Offset: 0x000D9D67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyDiceRequest);
		}

		// Token: 0x06005A25 RID: 23077 RVA: 0x000DBB75 File Offset: 0x000D9D75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyDiceRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005A26 RID: 23078 RVA: 0x000DBBA4 File Offset: 0x000D9DA4
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

		// Token: 0x06005A27 RID: 23079 RVA: 0x000DBBE3 File Offset: 0x000D9DE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005A28 RID: 23080 RVA: 0x000DBBF0 File Offset: 0x000D9DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A29 RID: 23081 RVA: 0x000DBBF9 File Offset: 0x000D9DF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A2A RID: 23082 RVA: 0x000DBC2C File Offset: 0x000D9E2C
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

		// Token: 0x06005A2B RID: 23083 RVA: 0x000DBC6A File Offset: 0x000D9E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyDiceRequest other)
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

		// Token: 0x06005A2C RID: 23084 RVA: 0x000DBC9B File Offset: 0x000D9E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A2D RID: 23085 RVA: 0x000DBCA4 File Offset: 0x000D9EA4
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040035EE RID: 13806
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035EF RID: 13807
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x040035F0 RID: 13808
		private int activityId_;
	}
}
