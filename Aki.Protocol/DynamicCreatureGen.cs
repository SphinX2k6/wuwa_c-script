using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000403 RID: 1027
	public sealed class DynamicCreatureGen : IMessage<DynamicCreatureGen>, IMessage, IEquatable<DynamicCreatureGen>, IDeepCloneable<DynamicCreatureGen>, IBufferMessage
	{
		// Token: 0x06006356 RID: 25430 RVA: 0x000EEF0F File Offset: 0x000ED10F
		[NullableContext(1)]
		public static DynamicCreatureGen Create()
		{
			return new DynamicCreatureGen();
		}

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x06006357 RID: 25431 RVA: 0x000EEF16 File Offset: 0x000ED116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x06006358 RID: 25432 RVA: 0x000EEF19 File Offset: 0x000ED119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DynamicCreatureGen.Descriptor;
			}
		}

		// Token: 0x06006359 RID: 25433 RVA: 0x000EEF20 File Offset: 0x000ED120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicCreatureGen()
		{
		}

		// Token: 0x0600635A RID: 25434 RVA: 0x000EEF28 File Offset: 0x000ED128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicCreatureGen(DynamicCreatureGen other) : this()
		{
			this.creatureGenID_ = other.creatureGenID_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600635B RID: 25435 RVA: 0x000EEF4D File Offset: 0x000ED14D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicCreatureGen Clone()
		{
			return new DynamicCreatureGen(this);
		}

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x0600635C RID: 25436 RVA: 0x000EEF55 File Offset: 0x000ED155
		// (set) Token: 0x0600635D RID: 25437 RVA: 0x000EEF5D File Offset: 0x000ED15D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CreatureGenID
		{
			get
			{
				return this.creatureGenID_;
			}
			set
			{
				this.creatureGenID_ = value;
			}
		}

		// Token: 0x0600635E RID: 25438 RVA: 0x000EEF66 File Offset: 0x000ED166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DynamicCreatureGen);
		}

		// Token: 0x0600635F RID: 25439 RVA: 0x000EEF74 File Offset: 0x000ED174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DynamicCreatureGen other)
		{
			return other != null && (other == this || (this.CreatureGenID == other.CreatureGenID && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006360 RID: 25440 RVA: 0x000EEFA4 File Offset: 0x000ED1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CreatureGenID != 0L)
			{
				num ^= this.CreatureGenID.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006361 RID: 25441 RVA: 0x000EEFE3 File Offset: 0x000ED1E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006362 RID: 25442 RVA: 0x000EEFF0 File Offset: 0x000ED1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006363 RID: 25443 RVA: 0x000EEFF9 File Offset: 0x000ED1F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CreatureGenID != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.CreatureGenID);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006364 RID: 25444 RVA: 0x000EF02C File Offset: 0x000ED22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CreatureGenID != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CreatureGenID);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006365 RID: 25445 RVA: 0x000EF06A File Offset: 0x000ED26A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DynamicCreatureGen other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CreatureGenID != 0L)
			{
				this.CreatureGenID = other.CreatureGenID;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006366 RID: 25446 RVA: 0x000EF09B File Offset: 0x000ED29B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006367 RID: 25447 RVA: 0x000EF0A4 File Offset: 0x000ED2A4
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
					this.CreatureGenID = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003868 RID: 14440
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003869 RID: 14441
		public const int CreatureGenIDFieldNumber = 1;

		// Token: 0x0400386A RID: 14442
		private long creatureGenID_;
	}
}
