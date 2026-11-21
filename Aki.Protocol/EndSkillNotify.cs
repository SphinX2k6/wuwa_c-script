using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200042A RID: 1066
	[NetMessage(EMessageId.EndSkillNotify)]
	public sealed class EndSkillNotify : IMessage<EndSkillNotify>, IMessage, IEquatable<EndSkillNotify>, IDeepCloneable<EndSkillNotify>, IBufferMessage
	{
		// Token: 0x060066A5 RID: 26277 RVA: 0x000F7028 File Offset: 0x000F5228
		[NullableContext(1)]
		public static EndSkillNotify Create()
		{
			return new EndSkillNotify();
		}

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x060066A6 RID: 26278 RVA: 0x000F702F File Offset: 0x000F522F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x060066A7 RID: 26279 RVA: 0x000F7032 File Offset: 0x000F5232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EndSkillNotify.Descriptor;
			}
		}

		// Token: 0x060066A8 RID: 26280 RVA: 0x000F7039 File Offset: 0x000F5239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillNotify()
		{
		}

		// Token: 0x060066A9 RID: 26281 RVA: 0x000F7044 File Offset: 0x000F5244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillNotify(EndSkillNotify other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.useSkillInfo_ = ((other.useSkillInfo_ != null) ? other.useSkillInfo_.Clone() : null);
			this.skillSingleId_ = other.skillSingleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060066AA RID: 26282 RVA: 0x000F70AC File Offset: 0x000F52AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillNotify Clone()
		{
			return new EndSkillNotify(this);
		}

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x060066AB RID: 26283 RVA: 0x000F70B4 File Offset: 0x000F52B4
		// (set) Token: 0x060066AC RID: 26284 RVA: 0x000F70BC File Offset: 0x000F52BC
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

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x060066AD RID: 26285 RVA: 0x000F70C5 File Offset: 0x000F52C5
		// (set) Token: 0x060066AE RID: 26286 RVA: 0x000F70CD File Offset: 0x000F52CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillInformation UseSkillInfo
		{
			get
			{
				return this.useSkillInfo_;
			}
			set
			{
				this.useSkillInfo_ = value;
			}
		}

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x060066AF RID: 26287 RVA: 0x000F70D6 File Offset: 0x000F52D6
		// (set) Token: 0x060066B0 RID: 26288 RVA: 0x000F70DE File Offset: 0x000F52DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillSingleId
		{
			get
			{
				return this.skillSingleId_;
			}
			set
			{
				this.skillSingleId_ = value;
			}
		}

		// Token: 0x060066B1 RID: 26289 RVA: 0x000F70E7 File Offset: 0x000F52E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EndSkillNotify);
		}

		// Token: 0x060066B2 RID: 26290 RVA: 0x000F70F8 File Offset: 0x000F52F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EndSkillNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.UseSkillInfo, other.UseSkillInfo) && this.SkillSingleId == other.SkillSingleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060066B3 RID: 26291 RVA: 0x000F715C File Offset: 0x000F535C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this.useSkillInfo_ != null)
			{
				num ^= this.UseSkillInfo.GetHashCode();
			}
			if (this.SkillSingleId != 0)
			{
				num ^= this.SkillSingleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060066B4 RID: 26292 RVA: 0x000F71C7 File Offset: 0x000F53C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060066B5 RID: 26293 RVA: 0x000F71D4 File Offset: 0x000F53D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060066B6 RID: 26294 RVA: 0x000F71E0 File Offset: 0x000F53E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.useSkillInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.UseSkillInfo);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.SkillSingleId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.SkillSingleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060066B7 RID: 26295 RVA: 0x000F7258 File Offset: 0x000F5458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this.useSkillInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UseSkillInfo);
			}
			if (this.SkillSingleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillSingleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060066B8 RID: 26296 RVA: 0x000F72C8 File Offset: 0x000F54C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EndSkillNotify other)
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
			if (other.useSkillInfo_ != null)
			{
				if (this.useSkillInfo_ == null)
				{
					this.UseSkillInfo = new UseSkillInformation();
				}
				this.UseSkillInfo.MergeFrom(other.UseSkillInfo);
			}
			if (other.SkillSingleId != 0)
			{
				this.SkillSingleId = other.SkillSingleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060066B9 RID: 26297 RVA: 0x000F735C File Offset: 0x000F555C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060066BA RID: 26298 RVA: 0x000F7368 File Offset: 0x000F5568
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
				if (num != 26U)
				{
					if (num != 58U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SkillSingleId = input.ReadInt32();
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
				else
				{
					if (this.useSkillInfo_ == null)
					{
						this.UseSkillInfo = new UseSkillInformation();
					}
					input.ReadMessage(this.UseSkillInfo);
				}
			}
		}

		// Token: 0x04003989 RID: 14729
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400398A RID: 14730
		public const int CombatCommonFieldNumber = 7;

		// Token: 0x0400398B RID: 14731
		private CombatCommon combatCommon_;

		// Token: 0x0400398C RID: 14732
		public const int UseSkillInfoFieldNumber = 3;

		// Token: 0x0400398D RID: 14733
		private UseSkillInformation useSkillInfo_;

		// Token: 0x0400398E RID: 14734
		public const int SkillSingleIdFieldNumber = 10;

		// Token: 0x0400398F RID: 14735
		private int skillSingleId_;
	}
}
