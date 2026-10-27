using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200034B RID: 843
	public sealed class DangoBrawlFightActionDeathInfo : IMessage<DangoBrawlFightActionDeathInfo>, IMessage, IEquatable<DangoBrawlFightActionDeathInfo>, IDeepCloneable<DangoBrawlFightActionDeathInfo>, IBufferMessage
	{
		// Token: 0x0600544F RID: 21583 RVA: 0x000CD815 File Offset: 0x000CBA15
		[NullableContext(1)]
		public static DangoBrawlFightActionDeathInfo Create()
		{
			return new DangoBrawlFightActionDeathInfo();
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x06005450 RID: 21584 RVA: 0x000CD81C File Offset: 0x000CBA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x06005451 RID: 21585 RVA: 0x000CD81F File Offset: 0x000CBA1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionDeathInfo.Descriptor;
			}
		}

		// Token: 0x06005452 RID: 21586 RVA: 0x000CD826 File Offset: 0x000CBA26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionDeathInfo()
		{
		}

		// Token: 0x06005453 RID: 21587 RVA: 0x000CD82E File Offset: 0x000CBA2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionDeathInfo(DangoBrawlFightActionDeathInfo other) : this()
		{
			this.targetFighterUId_ = other.targetFighterUId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005454 RID: 21588 RVA: 0x000CD853 File Offset: 0x000CBA53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionDeathInfo Clone()
		{
			return new DangoBrawlFightActionDeathInfo(this);
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06005455 RID: 21589 RVA: 0x000CD85B File Offset: 0x000CBA5B
		// (set) Token: 0x06005456 RID: 21590 RVA: 0x000CD863 File Offset: 0x000CBA63
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

		// Token: 0x06005457 RID: 21591 RVA: 0x000CD86C File Offset: 0x000CBA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionDeathInfo);
		}

		// Token: 0x06005458 RID: 21592 RVA: 0x000CD87A File Offset: 0x000CBA7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionDeathInfo other)
		{
			return other != null && (other == this || (this.TargetFighterUId == other.TargetFighterUId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005459 RID: 21593 RVA: 0x000CD8A8 File Offset: 0x000CBAA8
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

		// Token: 0x0600545A RID: 21594 RVA: 0x000CD8E7 File Offset: 0x000CBAE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600545B RID: 21595 RVA: 0x000CD8F4 File Offset: 0x000CBAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600545C RID: 21596 RVA: 0x000CD8FD File Offset: 0x000CBAFD
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

		// Token: 0x0600545D RID: 21597 RVA: 0x000CD930 File Offset: 0x000CBB30
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

		// Token: 0x0600545E RID: 21598 RVA: 0x000CD96E File Offset: 0x000CBB6E
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

		// Token: 0x0600545F RID: 21599 RVA: 0x000CD99F File Offset: 0x000CBB9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005460 RID: 21600 RVA: 0x000CD9A8 File Offset: 0x000CBBA8
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

		// Token: 0x040033C3 RID: 13251
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033C4 RID: 13252
		public const int TargetFighterUIdFieldNumber = 1;

		// Token: 0x040033C5 RID: 13253
		private int targetFighterUId_;
	}
}
