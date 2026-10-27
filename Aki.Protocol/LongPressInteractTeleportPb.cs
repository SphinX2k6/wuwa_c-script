using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000950 RID: 2384
	public sealed class LongPressInteractTeleportPb : IMessage<LongPressInteractTeleportPb>, IMessage, IEquatable<LongPressInteractTeleportPb>, IDeepCloneable<LongPressInteractTeleportPb>, IBufferMessage
	{
		// Token: 0x0600D222 RID: 53794 RVA: 0x001EF843 File Offset: 0x001EDA43
		[NullableContext(1)]
		public static LongPressInteractTeleportPb Create()
		{
			return new LongPressInteractTeleportPb();
		}

		// Token: 0x17002A87 RID: 10887
		// (get) Token: 0x0600D223 RID: 53795 RVA: 0x001EF84A File Offset: 0x001EDA4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A88 RID: 10888
		// (get) Token: 0x0600D224 RID: 53796 RVA: 0x001EF84D File Offset: 0x001EDA4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LongPressInteractTeleportPb.Descriptor;
			}
		}

		// Token: 0x0600D225 RID: 53797 RVA: 0x001EF854 File Offset: 0x001EDA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongPressInteractTeleportPb()
		{
		}

		// Token: 0x0600D226 RID: 53798 RVA: 0x001EF85C File Offset: 0x001EDA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongPressInteractTeleportPb(LongPressInteractTeleportPb other) : this()
		{
			this.actionCtx_ = ((other.actionCtx_ != null) ? other.actionCtx_.Clone() : null);
			this.index_ = other.index_;
			this.streamingSourceConditionIndex_ = other.streamingSourceConditionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D227 RID: 53799 RVA: 0x001EF8B4 File Offset: 0x001EDAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongPressInteractTeleportPb Clone()
		{
			return new LongPressInteractTeleportPb(this);
		}

		// Token: 0x17002A89 RID: 10889
		// (get) Token: 0x0600D228 RID: 53800 RVA: 0x001EF8BC File Offset: 0x001EDABC
		// (set) Token: 0x0600D229 RID: 53801 RVA: 0x001EF8C4 File Offset: 0x001EDAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameCtxPb ActionCtx
		{
			get
			{
				return this.actionCtx_;
			}
			set
			{
				this.actionCtx_ = value;
			}
		}

		// Token: 0x17002A8A RID: 10890
		// (get) Token: 0x0600D22A RID: 53802 RVA: 0x001EF8CD File Offset: 0x001EDACD
		// (set) Token: 0x0600D22B RID: 53803 RVA: 0x001EF8D5 File Offset: 0x001EDAD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17002A8B RID: 10891
		// (get) Token: 0x0600D22C RID: 53804 RVA: 0x001EF8DE File Offset: 0x001EDADE
		// (set) Token: 0x0600D22D RID: 53805 RVA: 0x001EF8E6 File Offset: 0x001EDAE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StreamingSourceConditionIndex
		{
			get
			{
				return this.streamingSourceConditionIndex_;
			}
			set
			{
				this.streamingSourceConditionIndex_ = value;
			}
		}

		// Token: 0x0600D22E RID: 53806 RVA: 0x001EF8EF File Offset: 0x001EDAEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LongPressInteractTeleportPb);
		}

		// Token: 0x0600D22F RID: 53807 RVA: 0x001EF900 File Offset: 0x001EDB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LongPressInteractTeleportPb other)
		{
			return other != null && (other == this || (object.Equals(this.ActionCtx, other.ActionCtx) && this.Index == other.Index && this.StreamingSourceConditionIndex == other.StreamingSourceConditionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D230 RID: 53808 RVA: 0x001EF960 File Offset: 0x001EDB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.actionCtx_ != null)
			{
				num ^= this.ActionCtx.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.StreamingSourceConditionIndex != 0)
			{
				num ^= this.StreamingSourceConditionIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D231 RID: 53809 RVA: 0x001EF9CE File Offset: 0x001EDBCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D232 RID: 53810 RVA: 0x001EF9DB File Offset: 0x001EDBDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D233 RID: 53811 RVA: 0x001EF9E4 File Offset: 0x001EDBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.actionCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ActionCtx);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Index);
			}
			if (this.StreamingSourceConditionIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.StreamingSourceConditionIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D234 RID: 53812 RVA: 0x001EFA5C File Offset: 0x001EDC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.actionCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActionCtx);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.StreamingSourceConditionIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StreamingSourceConditionIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D235 RID: 53813 RVA: 0x001EFACC File Offset: 0x001EDCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LongPressInteractTeleportPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.actionCtx_ != null)
			{
				if (this.actionCtx_ == null)
				{
					this.ActionCtx = new GameCtxPb();
				}
				this.ActionCtx.MergeFrom(other.ActionCtx);
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.StreamingSourceConditionIndex != 0)
			{
				this.StreamingSourceConditionIndex = other.StreamingSourceConditionIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D236 RID: 53814 RVA: 0x001EFB48 File Offset: 0x001EDD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D237 RID: 53815 RVA: 0x001EFB54 File Offset: 0x001EDD54
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.StreamingSourceConditionIndex = input.ReadInt32();
						}
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					if (this.actionCtx_ == null)
					{
						this.ActionCtx = new GameCtxPb();
					}
					input.ReadMessage(this.ActionCtx);
				}
			}
		}

		// Token: 0x0400586D RID: 22637
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400586E RID: 22638
		public const int ActionCtxFieldNumber = 1;

		// Token: 0x0400586F RID: 22639
		private GameCtxPb actionCtx_;

		// Token: 0x04005870 RID: 22640
		public const int IndexFieldNumber = 2;

		// Token: 0x04005871 RID: 22641
		private int index_;

		// Token: 0x04005872 RID: 22642
		public const int StreamingSourceConditionIndexFieldNumber = 3;

		// Token: 0x04005873 RID: 22643
		private int streamingSourceConditionIndex_;
	}
}
