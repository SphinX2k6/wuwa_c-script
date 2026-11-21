using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C4D RID: 3149
	[NetMessage(EMessageId.PhantomBattleCardRoleTargetInfoRequest)]
	public sealed class PhantomBattleCardRoleTargetInfoRequest : IMessage<PhantomBattleCardRoleTargetInfoRequest>, IMessage, IEquatable<PhantomBattleCardRoleTargetInfoRequest>, IDeepCloneable<PhantomBattleCardRoleTargetInfoRequest>, IBufferMessage
	{
		// Token: 0x06011184 RID: 70020 RVA: 0x00281273 File Offset: 0x0027F473
		[NullableContext(1)]
		public static PhantomBattleCardRoleTargetInfoRequest Create()
		{
			return new PhantomBattleCardRoleTargetInfoRequest();
		}

		// Token: 0x1700387F RID: 14463
		// (get) Token: 0x06011185 RID: 70021 RVA: 0x0028127A File Offset: 0x0027F47A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003880 RID: 14464
		// (get) Token: 0x06011186 RID: 70022 RVA: 0x0028127D File Offset: 0x0027F47D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardRoleTargetInfoRequest.Descriptor;
			}
		}

		// Token: 0x06011187 RID: 70023 RVA: 0x00281284 File Offset: 0x0027F484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRoleTargetInfoRequest()
		{
		}

		// Token: 0x06011188 RID: 70024 RVA: 0x0028128C File Offset: 0x0027F48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRoleTargetInfoRequest(PhantomBattleCardRoleTargetInfoRequest other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011189 RID: 70025 RVA: 0x002812B1 File Offset: 0x0027F4B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRoleTargetInfoRequest Clone()
		{
			return new PhantomBattleCardRoleTargetInfoRequest(this);
		}

		// Token: 0x17003881 RID: 14465
		// (get) Token: 0x0601118A RID: 70026 RVA: 0x002812B9 File Offset: 0x0027F4B9
		// (set) Token: 0x0601118B RID: 70027 RVA: 0x002812C1 File Offset: 0x0027F4C1
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

		// Token: 0x0601118C RID: 70028 RVA: 0x002812CA File Offset: 0x0027F4CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardRoleTargetInfoRequest);
		}

		// Token: 0x0601118D RID: 70029 RVA: 0x002812D8 File Offset: 0x0027F4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardRoleTargetInfoRequest other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601118E RID: 70030 RVA: 0x00281308 File Offset: 0x0027F508
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

		// Token: 0x0601118F RID: 70031 RVA: 0x00281347 File Offset: 0x0027F547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011190 RID: 70032 RVA: 0x00281354 File Offset: 0x0027F554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011191 RID: 70033 RVA: 0x0028135D File Offset: 0x0027F55D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011192 RID: 70034 RVA: 0x00281390 File Offset: 0x0027F590
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

		// Token: 0x06011193 RID: 70035 RVA: 0x002813CE File Offset: 0x0027F5CE
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

		// Token: 0x06011194 RID: 70036 RVA: 0x002813FF File Offset: 0x0027F5FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011195 RID: 70037 RVA: 0x00281408 File Offset: 0x0027F608
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkillId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006CA5 RID: 27813
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CA6 RID: 27814
		public const int SkillIdFieldNumber = 3;

		// Token: 0x04006CA7 RID: 27815
		private int skillId_;
	}
}
