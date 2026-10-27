using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011CF RID: 4559
	[NetMessage(EMessageId.SetFanNumberOfTurnsRequest)]
	public sealed class SetFanNumberOfTurnsRequest : IMessage<SetFanNumberOfTurnsRequest>, IMessage, IEquatable<SetFanNumberOfTurnsRequest>, IDeepCloneable<SetFanNumberOfTurnsRequest>, IBufferMessage
	{
		// Token: 0x06018510 RID: 99600 RVA: 0x00389D0D File Offset: 0x00387F0D
		[NullableContext(1)]
		public static SetFanNumberOfTurnsRequest Create()
		{
			return new SetFanNumberOfTurnsRequest();
		}

		// Token: 0x170051E5 RID: 20965
		// (get) Token: 0x06018511 RID: 99601 RVA: 0x00389D14 File Offset: 0x00387F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051E6 RID: 20966
		// (get) Token: 0x06018512 RID: 99602 RVA: 0x00389D17 File Offset: 0x00387F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetFanNumberOfTurnsRequest.Descriptor;
			}
		}

		// Token: 0x06018513 RID: 99603 RVA: 0x00389D1E File Offset: 0x00387F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFanNumberOfTurnsRequest()
		{
		}

		// Token: 0x06018514 RID: 99604 RVA: 0x00389D26 File Offset: 0x00387F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFanNumberOfTurnsRequest(SetFanNumberOfTurnsRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.numberOfTurns_ = other.numberOfTurns_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018515 RID: 99605 RVA: 0x00389D57 File Offset: 0x00387F57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFanNumberOfTurnsRequest Clone()
		{
			return new SetFanNumberOfTurnsRequest(this);
		}

		// Token: 0x170051E7 RID: 20967
		// (get) Token: 0x06018516 RID: 99606 RVA: 0x00389D5F File Offset: 0x00387F5F
		// (set) Token: 0x06018517 RID: 99607 RVA: 0x00389D67 File Offset: 0x00387F67
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

		// Token: 0x170051E8 RID: 20968
		// (get) Token: 0x06018518 RID: 99608 RVA: 0x00389D70 File Offset: 0x00387F70
		// (set) Token: 0x06018519 RID: 99609 RVA: 0x00389D78 File Offset: 0x00387F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NumberOfTurns
		{
			get
			{
				return this.numberOfTurns_;
			}
			set
			{
				this.numberOfTurns_ = value;
			}
		}

		// Token: 0x0601851A RID: 99610 RVA: 0x00389D81 File Offset: 0x00387F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetFanNumberOfTurnsRequest);
		}

		// Token: 0x0601851B RID: 99611 RVA: 0x00389D8F File Offset: 0x00387F8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetFanNumberOfTurnsRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.NumberOfTurns == other.NumberOfTurns && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601851C RID: 99612 RVA: 0x00389DD0 File Offset: 0x00387FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.NumberOfTurns != 0)
			{
				num ^= this.NumberOfTurns.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601851D RID: 99613 RVA: 0x00389E28 File Offset: 0x00388028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601851E RID: 99614 RVA: 0x00389E35 File Offset: 0x00388035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601851F RID: 99615 RVA: 0x00389E40 File Offset: 0x00388040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NumberOfTurns != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.NumberOfTurns);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018520 RID: 99616 RVA: 0x00389E98 File Offset: 0x00388098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.NumberOfTurns != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NumberOfTurns);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018521 RID: 99617 RVA: 0x00389EF0 File Offset: 0x003880F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetFanNumberOfTurnsRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.NumberOfTurns != 0)
			{
				this.NumberOfTurns = other.NumberOfTurns;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018522 RID: 99618 RVA: 0x00389F40 File Offset: 0x00388140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018523 RID: 99619 RVA: 0x00389F4C File Offset: 0x0038814C
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
					if (num != 80U)
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
					this.NumberOfTurns = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008FFF RID: 36863
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009000 RID: 36864
		public const int EntityIdFieldNumber = 10;

		// Token: 0x04009001 RID: 36865
		private long entityId_;

		// Token: 0x04009002 RID: 36866
		public const int NumberOfTurnsFieldNumber = 1;

		// Token: 0x04009003 RID: 36867
		private int numberOfTurns_;
	}
}
