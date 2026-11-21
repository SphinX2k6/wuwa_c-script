using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C55 RID: 3157
	[NetMessage(EMessageId.PhantomBattleCardTargetInfoRequest)]
	public sealed class PhantomBattleCardTargetInfoRequest : IMessage<PhantomBattleCardTargetInfoRequest>, IMessage, IEquatable<PhantomBattleCardTargetInfoRequest>, IDeepCloneable<PhantomBattleCardTargetInfoRequest>, IBufferMessage
	{
		// Token: 0x06011232 RID: 70194 RVA: 0x00282BDC File Offset: 0x00280DDC
		[NullableContext(1)]
		public static PhantomBattleCardTargetInfoRequest Create()
		{
			return new PhantomBattleCardTargetInfoRequest();
		}

		// Token: 0x170038A6 RID: 14502
		// (get) Token: 0x06011233 RID: 70195 RVA: 0x00282BE3 File Offset: 0x00280DE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038A7 RID: 14503
		// (get) Token: 0x06011234 RID: 70196 RVA: 0x00282BE6 File Offset: 0x00280DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardTargetInfoRequest.Descriptor;
			}
		}

		// Token: 0x06011235 RID: 70197 RVA: 0x00282BED File Offset: 0x00280DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardTargetInfoRequest()
		{
		}

		// Token: 0x06011236 RID: 70198 RVA: 0x00282BF5 File Offset: 0x00280DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardTargetInfoRequest(PhantomBattleCardTargetInfoRequest other) : this()
		{
			this.cardUId_ = other.cardUId_;
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011237 RID: 70199 RVA: 0x00282C26 File Offset: 0x00280E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardTargetInfoRequest Clone()
		{
			return new PhantomBattleCardTargetInfoRequest(this);
		}

		// Token: 0x170038A8 RID: 14504
		// (get) Token: 0x06011238 RID: 70200 RVA: 0x00282C2E File Offset: 0x00280E2E
		// (set) Token: 0x06011239 RID: 70201 RVA: 0x00282C36 File Offset: 0x00280E36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardUId
		{
			get
			{
				return this.cardUId_;
			}
			set
			{
				this.cardUId_ = value;
			}
		}

		// Token: 0x170038A9 RID: 14505
		// (get) Token: 0x0601123A RID: 70202 RVA: 0x00282C3F File Offset: 0x00280E3F
		// (set) Token: 0x0601123B RID: 70203 RVA: 0x00282C47 File Offset: 0x00280E47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
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

		// Token: 0x0601123C RID: 70204 RVA: 0x00282C50 File Offset: 0x00280E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardTargetInfoRequest);
		}

		// Token: 0x0601123D RID: 70205 RVA: 0x00282C5E File Offset: 0x00280E5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardTargetInfoRequest other)
		{
			return other != null && (other == this || (this.CardUId == other.CardUId && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601123E RID: 70206 RVA: 0x00282C9C File Offset: 0x00280E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CardUId != 0)
			{
				num ^= this.CardUId.GetHashCode();
			}
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601123F RID: 70207 RVA: 0x00282CF4 File Offset: 0x00280EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011240 RID: 70208 RVA: 0x00282D01 File Offset: 0x00280F01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011241 RID: 70209 RVA: 0x00282D0C File Offset: 0x00280F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardUId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CardUId);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011242 RID: 70210 RVA: 0x00282D68 File Offset: 0x00280F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardUId);
			}
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011243 RID: 70211 RVA: 0x00282DC0 File Offset: 0x00280FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardTargetInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CardUId != 0)
			{
				this.CardUId = other.CardUId;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011244 RID: 70212 RVA: 0x00282E10 File Offset: 0x00281010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011245 RID: 70213 RVA: 0x00282E1C File Offset: 0x0028101C
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
				if (num != 32U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkillId = input.ReadInt32();
					}
				}
				else
				{
					this.CardUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006CDF RID: 27871
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CE0 RID: 27872
		public const int CardUIdFieldNumber = 4;

		// Token: 0x04006CE1 RID: 27873
		private int cardUId_;

		// Token: 0x04006CE2 RID: 27874
		public const int SkillIdFieldNumber = 14;

		// Token: 0x04006CE3 RID: 27875
		private int skillId_;
	}
}
