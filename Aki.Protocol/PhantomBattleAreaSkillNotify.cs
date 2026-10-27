using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C28 RID: 3112
	[NetMessage(EMessageId.PhantomBattleAreaSkillNotify)]
	public sealed class PhantomBattleAreaSkillNotify : IMessage<PhantomBattleAreaSkillNotify>, IMessage, IEquatable<PhantomBattleAreaSkillNotify>, IDeepCloneable<PhantomBattleAreaSkillNotify>, IBufferMessage
	{
		// Token: 0x06010E30 RID: 69168 RVA: 0x002793E5 File Offset: 0x002775E5
		[NullableContext(1)]
		public static PhantomBattleAreaSkillNotify Create()
		{
			return new PhantomBattleAreaSkillNotify();
		}

		// Token: 0x170037C6 RID: 14278
		// (get) Token: 0x06010E31 RID: 69169 RVA: 0x002793EC File Offset: 0x002775EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037C7 RID: 14279
		// (get) Token: 0x06010E32 RID: 69170 RVA: 0x002793EF File Offset: 0x002775EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleAreaSkillNotify.Descriptor;
			}
		}

		// Token: 0x06010E33 RID: 69171 RVA: 0x002793F6 File Offset: 0x002775F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAreaSkillNotify()
		{
		}

		// Token: 0x06010E34 RID: 69172 RVA: 0x002793FE File Offset: 0x002775FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAreaSkillNotify(PhantomBattleAreaSkillNotify other) : this()
		{
			this.phantomBattleSkillTriggerInfos_ = ((other.phantomBattleSkillTriggerInfos_ != null) ? other.phantomBattleSkillTriggerInfos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010E35 RID: 69173 RVA: 0x00279433 File Offset: 0x00277633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAreaSkillNotify Clone()
		{
			return new PhantomBattleAreaSkillNotify(this);
		}

		// Token: 0x170037C8 RID: 14280
		// (get) Token: 0x06010E36 RID: 69174 RVA: 0x0027943B File Offset: 0x0027763B
		// (set) Token: 0x06010E37 RID: 69175 RVA: 0x00279443 File Offset: 0x00277643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSkillTriggerInfo PhantomBattleSkillTriggerInfos
		{
			get
			{
				return this.phantomBattleSkillTriggerInfos_;
			}
			set
			{
				this.phantomBattleSkillTriggerInfos_ = value;
			}
		}

		// Token: 0x06010E38 RID: 69176 RVA: 0x0027944C File Offset: 0x0027764C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleAreaSkillNotify);
		}

		// Token: 0x06010E39 RID: 69177 RVA: 0x0027945A File Offset: 0x0027765A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleAreaSkillNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PhantomBattleSkillTriggerInfos, other.PhantomBattleSkillTriggerInfos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010E3A RID: 69178 RVA: 0x00279490 File Offset: 0x00277690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.phantomBattleSkillTriggerInfos_ != null)
			{
				num ^= this.PhantomBattleSkillTriggerInfos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010E3B RID: 69179 RVA: 0x002794CC File Offset: 0x002776CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010E3C RID: 69180 RVA: 0x002794D9 File Offset: 0x002776D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010E3D RID: 69181 RVA: 0x002794E2 File Offset: 0x002776E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.phantomBattleSkillTriggerInfos_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.PhantomBattleSkillTriggerInfos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010E3E RID: 69182 RVA: 0x00279514 File Offset: 0x00277714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.phantomBattleSkillTriggerInfos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleSkillTriggerInfos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010E3F RID: 69183 RVA: 0x00279554 File Offset: 0x00277754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleAreaSkillNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.phantomBattleSkillTriggerInfos_ != null)
			{
				if (this.phantomBattleSkillTriggerInfos_ == null)
				{
					this.PhantomBattleSkillTriggerInfos = new PhantomBattleSkillTriggerInfo();
				}
				this.PhantomBattleSkillTriggerInfos.MergeFrom(other.PhantomBattleSkillTriggerInfos);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010E40 RID: 69184 RVA: 0x002795A8 File Offset: 0x002777A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010E41 RID: 69185 RVA: 0x002795B4 File Offset: 0x002777B4
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.phantomBattleSkillTriggerInfos_ == null)
					{
						this.PhantomBattleSkillTriggerInfos = new PhantomBattleSkillTriggerInfo();
					}
					input.ReadMessage(this.PhantomBattleSkillTriggerInfos);
				}
			}
		}

		// Token: 0x04006B3A RID: 27450
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B3B RID: 27451
		public const int PhantomBattleSkillTriggerInfosFieldNumber = 15;

		// Token: 0x04006B3C RID: 27452
		private PhantomBattleSkillTriggerInfo phantomBattleSkillTriggerInfos_;
	}
}
