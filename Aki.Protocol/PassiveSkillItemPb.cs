using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BC1 RID: 3009
	public sealed class PassiveSkillItemPb : IMessage<PassiveSkillItemPb>, IMessage, IEquatable<PassiveSkillItemPb>, IDeepCloneable<PassiveSkillItemPb>, IBufferMessage
	{
		// Token: 0x0601051F RID: 66847 RVA: 0x00261AAF File Offset: 0x0025FCAF
		[NullableContext(1)]
		public static PassiveSkillItemPb Create()
		{
			return new PassiveSkillItemPb();
		}

		// Token: 0x17003581 RID: 13697
		// (get) Token: 0x06010520 RID: 66848 RVA: 0x00261AB6 File Offset: 0x0025FCB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PassiveSkillItemPb> Parser
		{
			get
			{
				return PassiveSkillItemPb._parser;
			}
		}

		// Token: 0x17003582 RID: 13698
		// (get) Token: 0x06010521 RID: 66849 RVA: 0x00261ABD File Offset: 0x0025FCBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003583 RID: 13699
		// (get) Token: 0x06010522 RID: 66850 RVA: 0x00261AC0 File Offset: 0x0025FCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillItemPb.Descriptor;
			}
		}

		// Token: 0x06010523 RID: 66851 RVA: 0x00261AC7 File Offset: 0x0025FCC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillItemPb()
		{
		}

		// Token: 0x06010524 RID: 66852 RVA: 0x00261AD0 File Offset: 0x0025FCD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillItemPb(PassiveSkillItemPb other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010525 RID: 66853 RVA: 0x00261B1C File Offset: 0x0025FD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillItemPb Clone()
		{
			return new PassiveSkillItemPb(this);
		}

		// Token: 0x17003584 RID: 13700
		// (get) Token: 0x06010526 RID: 66854 RVA: 0x00261B24 File Offset: 0x0025FD24
		// (set) Token: 0x06010527 RID: 66855 RVA: 0x00261B2C File Offset: 0x0025FD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon CombatCommon
		{
			get
			{
				return this.combatCommon_;
			}
			set
			{
				this.combatCommon_ = value;
			}
		}

		// Token: 0x17003585 RID: 13701
		// (get) Token: 0x06010528 RID: 66856 RVA: 0x00261B35 File Offset: 0x0025FD35
		// (set) Token: 0x06010529 RID: 66857 RVA: 0x00261B3D File Offset: 0x0025FD3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x0601052A RID: 66858 RVA: 0x00261B46 File Offset: 0x0025FD46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillItemPb);
		}

		// Token: 0x0601052B RID: 66859 RVA: 0x00261B54 File Offset: 0x0025FD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillItemPb other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601052C RID: 66860 RVA: 0x00261BA4 File Offset: 0x0025FDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601052D RID: 66861 RVA: 0x00261BF9 File Offset: 0x0025FDF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601052E RID: 66862 RVA: 0x00261C06 File Offset: 0x0025FE06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601052F RID: 66863 RVA: 0x00261C10 File Offset: 0x0025FE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010530 RID: 66864 RVA: 0x00261C6C File Offset: 0x0025FE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010531 RID: 66865 RVA: 0x00261CC4 File Offset: 0x0025FEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PassiveSkillItemPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.combatCommon_ != null)
			{
				if (this.combatCommon_ == null)
				{
					this.CombatCommon = new CombatCommon();
				}
				this.CombatCommon.MergeFrom(other.CombatCommon);
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010532 RID: 66866 RVA: 0x00261D2C File Offset: 0x0025FF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010533 RID: 66867 RVA: 0x00261D38 File Offset: 0x0025FF38
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkillId = input.ReadInt64();
					}
				}
				else
				{
					if (this.combatCommon_ == null)
					{
						this.CombatCommon = new CombatCommon();
					}
					input.ReadMessage(this.CombatCommon);
				}
			}
		}

		// Token: 0x0400680B RID: 26635
		private static readonly MessageParser<PassiveSkillItemPb> _parser = new MessageParser<PassiveSkillItemPb>(() => new PassiveSkillItemPb());

		// Token: 0x0400680C RID: 26636
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400680D RID: 26637
		public const int CombatCommonFieldNumber = 1;

		// Token: 0x0400680E RID: 26638
		private CombatCommon combatCommon_;

		// Token: 0x0400680F RID: 26639
		public const int SkillIdFieldNumber = 2;

		// Token: 0x04006810 RID: 26640
		private long skillId_;
	}
}
