using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BD2 RID: 3026
	[NetMessage(EMessageId.PassiveSkillNotify)]
	public sealed class PassiveSkillNotify : IMessage<PassiveSkillNotify>, IMessage, IEquatable<PassiveSkillNotify>, IDeepCloneable<PassiveSkillNotify>, IBufferMessage
	{
		// Token: 0x06010639 RID: 67129 RVA: 0x00263C7B File Offset: 0x00261E7B
		[NullableContext(1)]
		public static PassiveSkillNotify Create()
		{
			return new PassiveSkillNotify();
		}

		// Token: 0x170035BF RID: 13759
		// (get) Token: 0x0601063A RID: 67130 RVA: 0x00263C82 File Offset: 0x00261E82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035C0 RID: 13760
		// (get) Token: 0x0601063B RID: 67131 RVA: 0x00263C85 File Offset: 0x00261E85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillNotify.Descriptor;
			}
		}

		// Token: 0x0601063C RID: 67132 RVA: 0x00263C8C File Offset: 0x00261E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillNotify()
		{
		}

		// Token: 0x0601063D RID: 67133 RVA: 0x00263C9F File Offset: 0x00261E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillNotify(PassiveSkillNotify other) : this()
		{
			this.rolePassiveSkillInfoList_ = other.rolePassiveSkillInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601063E RID: 67134 RVA: 0x00263CC9 File Offset: 0x00261EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillNotify Clone()
		{
			return new PassiveSkillNotify(this);
		}

		// Token: 0x170035C1 RID: 13761
		// (get) Token: 0x0601063F RID: 67135 RVA: 0x00263CD1 File Offset: 0x00261ED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RolePassiveSkillInfo> RolePassiveSkillInfoList
		{
			get
			{
				return this.rolePassiveSkillInfoList_;
			}
		}

		// Token: 0x06010640 RID: 67136 RVA: 0x00263CD9 File Offset: 0x00261ED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillNotify);
		}

		// Token: 0x06010641 RID: 67137 RVA: 0x00263CE7 File Offset: 0x00261EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillNotify other)
		{
			return other != null && (other == this || (this.rolePassiveSkillInfoList_.Equals(other.rolePassiveSkillInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010642 RID: 67138 RVA: 0x00263D1C File Offset: 0x00261F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rolePassiveSkillInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010643 RID: 67139 RVA: 0x00263D50 File Offset: 0x00261F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010644 RID: 67140 RVA: 0x00263D5D File Offset: 0x00261F5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010645 RID: 67141 RVA: 0x00263D66 File Offset: 0x00261F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rolePassiveSkillInfoList_.WriteTo(ref output, PassiveSkillNotify._repeated_rolePassiveSkillInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010646 RID: 67142 RVA: 0x00263D90 File Offset: 0x00261F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rolePassiveSkillInfoList_.CalculateSize(PassiveSkillNotify._repeated_rolePassiveSkillInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010647 RID: 67143 RVA: 0x00263DC9 File Offset: 0x00261FC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PassiveSkillNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.rolePassiveSkillInfoList_.Add(other.rolePassiveSkillInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010648 RID: 67144 RVA: 0x00263DF7 File Offset: 0x00261FF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010649 RID: 67145 RVA: 0x00263E00 File Offset: 0x00262000
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rolePassiveSkillInfoList_.AddEntriesFrom(ref input, PassiveSkillNotify._repeated_rolePassiveSkillInfoList_codec);
				}
			}
		}

		// Token: 0x04006801 RID: 26625
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006802 RID: 26626
		public const int RolePassiveSkillInfoListFieldNumber = 4;

		// Token: 0x04006803 RID: 26627
		private static readonly FieldCodec<RolePassiveSkillInfo> _repeated_rolePassiveSkillInfoList_codec = FieldCodec.ForMessage<RolePassiveSkillInfo>(34U, RolePassiveSkillInfo.Parser);

		// Token: 0x04006804 RID: 26628
		private readonly RepeatedField<RolePassiveSkillInfo> rolePassiveSkillInfoList_ = new RepeatedField<RolePassiveSkillInfo>();
	}
}
