using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C5D RID: 3165
	[NetMessage(EMessageId.PhantomBattleCardRoleTargetInfoRequest)]
	public sealed class PhantomBattleCardRoleTargetInfoRequest : IMessage<PhantomBattleCardRoleTargetInfoRequest>, IMessage, IEquatable<PhantomBattleCardRoleTargetInfoRequest>, IDeepCloneable<PhantomBattleCardRoleTargetInfoRequest>, IBufferMessage
	{
		// Token: 0x06011284 RID: 70276 RVA: 0x00282FE3 File Offset: 0x002811E3
		[NullableContext(1)]
		public static PhantomBattleCardRoleTargetInfoRequest Create()
		{
			return new PhantomBattleCardRoleTargetInfoRequest();
		}

		// Token: 0x170038B6 RID: 14518
		// (get) Token: 0x06011285 RID: 70277 RVA: 0x00282FEA File Offset: 0x002811EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038B7 RID: 14519
		// (get) Token: 0x06011286 RID: 70278 RVA: 0x00282FED File Offset: 0x002811ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardRoleTargetInfoRequest.Descriptor;
			}
		}

		// Token: 0x06011287 RID: 70279 RVA: 0x00282FF4 File Offset: 0x002811F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRoleTargetInfoRequest()
		{
		}

		// Token: 0x06011288 RID: 70280 RVA: 0x00282FFC File Offset: 0x002811FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRoleTargetInfoRequest(PhantomBattleCardRoleTargetInfoRequest other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011289 RID: 70281 RVA: 0x00283021 File Offset: 0x00281221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRoleTargetInfoRequest Clone()
		{
			return new PhantomBattleCardRoleTargetInfoRequest(this);
		}

		// Token: 0x170038B8 RID: 14520
		// (get) Token: 0x0601128A RID: 70282 RVA: 0x00283029 File Offset: 0x00281229
		// (set) Token: 0x0601128B RID: 70283 RVA: 0x00283031 File Offset: 0x00281231
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

		// Token: 0x0601128C RID: 70284 RVA: 0x0028303A File Offset: 0x0028123A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardRoleTargetInfoRequest);
		}

		// Token: 0x0601128D RID: 70285 RVA: 0x00283048 File Offset: 0x00281248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardRoleTargetInfoRequest other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601128E RID: 70286 RVA: 0x00283078 File Offset: 0x00281278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0601128F RID: 70287 RVA: 0x002830B7 File Offset: 0x002812B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011290 RID: 70288 RVA: 0x002830C4 File Offset: 0x002812C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011291 RID: 70289 RVA: 0x002830CD File Offset: 0x002812CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011292 RID: 70290 RVA: 0x00283100 File Offset: 0x00281300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06011293 RID: 70291 RVA: 0x0028313E File Offset: 0x0028133E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardRoleTargetInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011294 RID: 70292 RVA: 0x0028316F File Offset: 0x0028136F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011295 RID: 70293 RVA: 0x00283178 File Offset: 0x00281378
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkillId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006C91 RID: 27793
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C92 RID: 27794
		public const int SkillIdFieldNumber = 6;

		// Token: 0x04006C93 RID: 27795
		private int skillId_;
	}
}
