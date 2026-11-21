using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000353 RID: 851
	public sealed class DangoBrawlFightActionDeathInfo : IMessage<DangoBrawlFightActionDeathInfo>, IMessage, IEquatable<DangoBrawlFightActionDeathInfo>, IDeepCloneable<DangoBrawlFightActionDeathInfo>, IBufferMessage
	{
		// Token: 0x0600553C RID: 21820 RVA: 0x000CFEA1 File Offset: 0x000CE0A1
		[NullableContext(1)]
		public static DangoBrawlFightActionDeathInfo Create()
		{
			return new DangoBrawlFightActionDeathInfo();
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x0600553D RID: 21821 RVA: 0x000CFEA8 File Offset: 0x000CE0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x0600553E RID: 21822 RVA: 0x000CFEAB File Offset: 0x000CE0AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionDeathInfo.Descriptor;
			}
		}

		// Token: 0x0600553F RID: 21823 RVA: 0x000CFEB2 File Offset: 0x000CE0B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionDeathInfo()
		{
		}

		// Token: 0x06005540 RID: 21824 RVA: 0x000CFEBA File Offset: 0x000CE0BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionDeathInfo(DangoBrawlFightActionDeathInfo other) : this()
		{
			this.targetFighterUId_ = other.targetFighterUId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005541 RID: 21825 RVA: 0x000CFEDF File Offset: 0x000CE0DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionDeathInfo Clone()
		{
			return new DangoBrawlFightActionDeathInfo(this);
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x06005542 RID: 21826 RVA: 0x000CFEE7 File Offset: 0x000CE0E7
		// (set) Token: 0x06005543 RID: 21827 RVA: 0x000CFEEF File Offset: 0x000CE0EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetFighterUId
		{
			get
			{
				return this.targetFighterUId_;
			}
			set
			{
				this.targetFighterUId_ = value;
			}
		}

		// Token: 0x06005544 RID: 21828 RVA: 0x000CFEF8 File Offset: 0x000CE0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionDeathInfo);
		}

		// Token: 0x06005545 RID: 21829 RVA: 0x000CFF06 File Offset: 0x000CE106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionDeathInfo other)
		{
			return other != null && (other == this || (this.TargetFighterUId == other.TargetFighterUId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005546 RID: 21830 RVA: 0x000CFF34 File Offset: 0x000CE134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetFighterUId != 0)
			{
				num ^= this.TargetFighterUId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005547 RID: 21831 RVA: 0x000CFF73 File Offset: 0x000CE173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005548 RID: 21832 RVA: 0x000CFF80 File Offset: 0x000CE180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005549 RID: 21833 RVA: 0x000CFF89 File Offset: 0x000CE189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetFighterUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TargetFighterUId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600554A RID: 21834 RVA: 0x000CFFBC File Offset: 0x000CE1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetFighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetFighterUId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600554B RID: 21835 RVA: 0x000CFFFA File Offset: 0x000CE1FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFightActionDeathInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetFighterUId != 0)
			{
				this.TargetFighterUId = other.TargetFighterUId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600554C RID: 21836 RVA: 0x000D002B File Offset: 0x000CE22B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600554D RID: 21837 RVA: 0x000D0034 File Offset: 0x000CE234
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
					this.TargetFighterUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400345F RID: 13407
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003460 RID: 13408
		public const int TargetFighterUIdFieldNumber = 1;

		// Token: 0x04003461 RID: 13409
		private int targetFighterUId_;
	}
}
