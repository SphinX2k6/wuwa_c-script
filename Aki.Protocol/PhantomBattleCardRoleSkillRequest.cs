using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C5B RID: 3163
	[NetMessage(EMessageId.PhantomBattleCardRoleSkillRequest)]
	public sealed class PhantomBattleCardRoleSkillRequest : IMessage<PhantomBattleCardRoleSkillRequest>, IMessage, IEquatable<PhantomBattleCardRoleSkillRequest>, IDeepCloneable<PhantomBattleCardRoleSkillRequest>, IBufferMessage
	{
		// Token: 0x0601125C RID: 70236 RVA: 0x00282A41 File Offset: 0x00280C41
		[NullableContext(1)]
		public static PhantomBattleCardRoleSkillRequest Create()
		{
			return new PhantomBattleCardRoleSkillRequest();
		}

		// Token: 0x170038AE RID: 14510
		// (get) Token: 0x0601125D RID: 70237 RVA: 0x00282A48 File Offset: 0x00280C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038AF RID: 14511
		// (get) Token: 0x0601125E RID: 70238 RVA: 0x00282A4B File Offset: 0x00280C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardRoleSkillRequest.Descriptor;
			}
		}

		// Token: 0x0601125F RID: 70239 RVA: 0x00282A52 File Offset: 0x00280C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRoleSkillRequest()
		{
		}

		// Token: 0x06011260 RID: 70240 RVA: 0x00282A65 File Offset: 0x00280C65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRoleSkillRequest(PhantomBattleCardRoleSkillRequest other) : this()
		{
			this.skillId_ = other.skillId_;
			this.selectFighterUId_ = other.selectFighterUId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011261 RID: 70241 RVA: 0x00282A9B File Offset: 0x00280C9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRoleSkillRequest Clone()
		{
			return new PhantomBattleCardRoleSkillRequest(this);
		}

		// Token: 0x170038B0 RID: 14512
		// (get) Token: 0x06011262 RID: 70242 RVA: 0x00282AA3 File Offset: 0x00280CA3
		// (set) Token: 0x06011263 RID: 70243 RVA: 0x00282AAB File Offset: 0x00280CAB
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

		// Token: 0x170038B1 RID: 14513
		// (get) Token: 0x06011264 RID: 70244 RVA: 0x00282AB4 File Offset: 0x00280CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectFighterUId
		{
			get
			{
				return this.selectFighterUId_;
			}
		}

		// Token: 0x06011265 RID: 70245 RVA: 0x00282ABC File Offset: 0x00280CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardRoleSkillRequest);
		}

		// Token: 0x06011266 RID: 70246 RVA: 0x00282ACC File Offset: 0x00280CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardRoleSkillRequest other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.selectFighterUId_.Equals(other.selectFighterUId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011267 RID: 70247 RVA: 0x00282B1C File Offset: 0x00280D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			num ^= this.selectFighterUId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011268 RID: 70248 RVA: 0x00282B69 File Offset: 0x00280D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011269 RID: 70249 RVA: 0x00282B76 File Offset: 0x00280D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601126A RID: 70250 RVA: 0x00282B80 File Offset: 0x00280D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.selectFighterUId_.WriteTo(ref output, PhantomBattleCardRoleSkillRequest._repeated_selectFighterUId_codec);
			if (this.SkillId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601126B RID: 70251 RVA: 0x00282BD0 File Offset: 0x00280DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			num += this.selectFighterUId_.CalculateSize(PhantomBattleCardRoleSkillRequest._repeated_selectFighterUId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601126C RID: 70252 RVA: 0x00282C24 File Offset: 0x00280E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardRoleSkillRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			this.selectFighterUId_.Add(other.selectFighterUId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601126D RID: 70253 RVA: 0x00282C71 File Offset: 0x00280E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601126E RID: 70254 RVA: 0x00282C7C File Offset: 0x00280E7C
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
				if (num != 32U && num != 34U)
				{
					if (num != 64U)
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
					this.selectFighterUId_.AddEntriesFrom(ref input, PhantomBattleCardRoleSkillRequest._repeated_selectFighterUId_codec);
				}
			}
		}

		// Token: 0x04006C86 RID: 27782
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C87 RID: 27783
		public const int SkillIdFieldNumber = 8;

		// Token: 0x04006C88 RID: 27784
		private int skillId_;

		// Token: 0x04006C89 RID: 27785
		public const int SelectFighterUIdFieldNumber = 4;

		// Token: 0x04006C8A RID: 27786
		private static readonly FieldCodec<int> _repeated_selectFighterUId_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04006C8B RID: 27787
		private readonly RepeatedField<int> selectFighterUId_ = new RepeatedField<int>();
	}
}
