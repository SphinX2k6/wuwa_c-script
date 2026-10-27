using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200146B RID: 5227
	public sealed class TriggerComponentPb : IMessage<TriggerComponentPb>, IMessage, IEquatable<TriggerComponentPb>, IDeepCloneable<TriggerComponentPb>, IBufferMessage
	{
		// Token: 0x0601BAC7 RID: 113351 RVA: 0x0040155D File Offset: 0x003FF75D
		[NullableContext(1)]
		public static TriggerComponentPb Create()
		{
			return new TriggerComponentPb();
		}

		// Token: 0x17005D53 RID: 23891
		// (get) Token: 0x0601BAC8 RID: 113352 RVA: 0x00401564 File Offset: 0x003FF764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D54 RID: 23892
		// (get) Token: 0x0601BAC9 RID: 113353 RVA: 0x00401567 File Offset: 0x003FF767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TriggerComponentPb.Descriptor;
			}
		}

		// Token: 0x0601BACA RID: 113354 RVA: 0x0040156E File Offset: 0x003FF76E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerComponentPb()
		{
		}

		// Token: 0x0601BACB RID: 113355 RVA: 0x00401576 File Offset: 0x003FF776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerComponentPb(TriggerComponentPb other) : this()
		{
			this.triggerCount_ = other.triggerCount_;
			this.exitTriggerCount_ = other.exitTriggerCount_;
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BACC RID: 113356 RVA: 0x004015B3 File Offset: 0x003FF7B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerComponentPb Clone()
		{
			return new TriggerComponentPb(this);
		}

		// Token: 0x17005D55 RID: 23893
		// (get) Token: 0x0601BACD RID: 113357 RVA: 0x004015BB File Offset: 0x003FF7BB
		// (set) Token: 0x0601BACE RID: 113358 RVA: 0x004015C3 File Offset: 0x003FF7C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TriggerCount
		{
			get
			{
				return this.triggerCount_;
			}
			set
			{
				this.triggerCount_ = value;
			}
		}

		// Token: 0x17005D56 RID: 23894
		// (get) Token: 0x0601BACF RID: 113359 RVA: 0x004015CC File Offset: 0x003FF7CC
		// (set) Token: 0x0601BAD0 RID: 113360 RVA: 0x004015D4 File Offset: 0x003FF7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExitTriggerCount
		{
			get
			{
				return this.exitTriggerCount_;
			}
			set
			{
				this.exitTriggerCount_ = value;
			}
		}

		// Token: 0x17005D57 RID: 23895
		// (get) Token: 0x0601BAD1 RID: 113361 RVA: 0x004015DD File Offset: 0x003FF7DD
		// (set) Token: 0x0601BAD2 RID: 113362 RVA: 0x004015E5 File Offset: 0x003FF7E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ContextId
		{
			get
			{
				return this.contextId_;
			}
			set
			{
				this.contextId_ = value;
			}
		}

		// Token: 0x0601BAD3 RID: 113363 RVA: 0x004015EE File Offset: 0x003FF7EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TriggerComponentPb);
		}

		// Token: 0x0601BAD4 RID: 113364 RVA: 0x004015FC File Offset: 0x003FF7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TriggerComponentPb other)
		{
			return other != null && (other == this || (this.TriggerCount == other.TriggerCount && this.ExitTriggerCount == other.ExitTriggerCount && this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BAD5 RID: 113365 RVA: 0x00401658 File Offset: 0x003FF858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TriggerCount != 0)
			{
				num ^= this.TriggerCount.GetHashCode();
			}
			if (this.ExitTriggerCount != 0)
			{
				num ^= this.ExitTriggerCount.GetHashCode();
			}
			if (this.ContextId != 0L)
			{
				num ^= this.ContextId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BAD6 RID: 113366 RVA: 0x004016C9 File Offset: 0x003FF8C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BAD7 RID: 113367 RVA: 0x004016D6 File Offset: 0x003FF8D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BAD8 RID: 113368 RVA: 0x004016E0 File Offset: 0x003FF8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TriggerCount != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TriggerCount);
			}
			if (this.ExitTriggerCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ExitTriggerCount);
			}
			if (this.ContextId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BAD9 RID: 113369 RVA: 0x00401754 File Offset: 0x003FF954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TriggerCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TriggerCount);
			}
			if (this.ExitTriggerCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExitTriggerCount);
			}
			if (this.ContextId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BADA RID: 113370 RVA: 0x004017C4 File Offset: 0x003FF9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TriggerComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TriggerCount != 0)
			{
				this.TriggerCount = other.TriggerCount;
			}
			if (other.ExitTriggerCount != 0)
			{
				this.ExitTriggerCount = other.ExitTriggerCount;
			}
			if (other.ContextId != 0L)
			{
				this.ContextId = other.ContextId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BADB RID: 113371 RVA: 0x00401828 File Offset: 0x003FFA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BADC RID: 113372 RVA: 0x00401834 File Offset: 0x003FFA34
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ContextId = input.ReadInt64();
						}
					}
					else
					{
						this.ExitTriggerCount = input.ReadInt32();
					}
				}
				else
				{
					this.TriggerCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009F75 RID: 40821
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F76 RID: 40822
		public const int TriggerCountFieldNumber = 1;

		// Token: 0x04009F77 RID: 40823
		private int triggerCount_;

		// Token: 0x04009F78 RID: 40824
		public const int ExitTriggerCountFieldNumber = 2;

		// Token: 0x04009F79 RID: 40825
		private int exitTriggerCount_;

		// Token: 0x04009F7A RID: 40826
		public const int ContextIdFieldNumber = 3;

		// Token: 0x04009F7B RID: 40827
		private long contextId_;
	}
}
