using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000282 RID: 642
	[NetMessage(EMessageId.CheckGearRequest)]
	public sealed class CheckGearRequest : IMessage<CheckGearRequest>, IMessage, IEquatable<CheckGearRequest>, IDeepCloneable<CheckGearRequest>, IBufferMessage
	{
		// Token: 0x06004344 RID: 17220 RVA: 0x000A5093 File Offset: 0x000A3293
		[NullableContext(1)]
		public static CheckGearRequest Create()
		{
			return new CheckGearRequest();
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06004345 RID: 17221 RVA: 0x000A509A File Offset: 0x000A329A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06004346 RID: 17222 RVA: 0x000A509D File Offset: 0x000A329D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CheckGearRequest.Descriptor;
			}
		}

		// Token: 0x06004347 RID: 17223 RVA: 0x000A50A4 File Offset: 0x000A32A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckGearRequest()
		{
		}

		// Token: 0x06004348 RID: 17224 RVA: 0x000A50AC File Offset: 0x000A32AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckGearRequest(CheckGearRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004349 RID: 17225 RVA: 0x000A50D1 File Offset: 0x000A32D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckGearRequest Clone()
		{
			return new CheckGearRequest(this);
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x0600434A RID: 17226 RVA: 0x000A50D9 File Offset: 0x000A32D9
		// (set) Token: 0x0600434B RID: 17227 RVA: 0x000A50E1 File Offset: 0x000A32E1
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

		// Token: 0x0600434C RID: 17228 RVA: 0x000A50EA File Offset: 0x000A32EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CheckGearRequest);
		}

		// Token: 0x0600434D RID: 17229 RVA: 0x000A50F8 File Offset: 0x000A32F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CheckGearRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600434E RID: 17230 RVA: 0x000A5128 File Offset: 0x000A3328
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

		// Token: 0x0600434F RID: 17231 RVA: 0x000A5167 File Offset: 0x000A3367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004350 RID: 17232 RVA: 0x000A5174 File Offset: 0x000A3374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004351 RID: 17233 RVA: 0x000A517D File Offset: 0x000A337D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004352 RID: 17234 RVA: 0x000A51B0 File Offset: 0x000A33B0
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

		// Token: 0x06004353 RID: 17235 RVA: 0x000A51EE File Offset: 0x000A33EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CheckGearRequest other)
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

		// Token: 0x06004354 RID: 17236 RVA: 0x000A521F File Offset: 0x000A341F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004355 RID: 17237 RVA: 0x000A5228 File Offset: 0x000A3428
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002E4D RID: 11853
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E4E RID: 11854
		public const int EntityIdFieldNumber = 3;

		// Token: 0x04002E4F RID: 11855
		private long entityId_;
	}
}
