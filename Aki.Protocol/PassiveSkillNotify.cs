using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BC2 RID: 3010
	[NetMessage(EMessageId.PassiveSkillNotify)]
	public sealed class PassiveSkillNotify : IMessage<PassiveSkillNotify>, IMessage, IEquatable<PassiveSkillNotify>, IDeepCloneable<PassiveSkillNotify>, IBufferMessage
	{
		// Token: 0x06010535 RID: 66869 RVA: 0x00261DBF File Offset: 0x0025FFBF
		[NullableContext(1)]
		public static PassiveSkillNotify Create()
		{
			return new PassiveSkillNotify();
		}

		// Token: 0x17003586 RID: 13702
		// (get) Token: 0x06010536 RID: 66870 RVA: 0x00261DC6 File Offset: 0x0025FFC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003587 RID: 13703
		// (get) Token: 0x06010537 RID: 66871 RVA: 0x00261DC9 File Offset: 0x0025FFC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillNotify.Descriptor;
			}
		}

		// Token: 0x06010538 RID: 66872 RVA: 0x00261DD0 File Offset: 0x0025FFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillNotify()
		{
		}

		// Token: 0x06010539 RID: 66873 RVA: 0x00261DE3 File Offset: 0x0025FFE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillNotify(PassiveSkillNotify other) : this()
		{
			this.rolePassiveSkillInfoList_ = other.rolePassiveSkillInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601053A RID: 66874 RVA: 0x00261E0D File Offset: 0x0026000D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillNotify Clone()
		{
			return new PassiveSkillNotify(this);
		}

		// Token: 0x17003588 RID: 13704
		// (get) Token: 0x0601053B RID: 66875 RVA: 0x00261E15 File Offset: 0x00260015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RolePassiveSkillInfo> RolePassiveSkillInfoList
		{
			get
			{
				return this.rolePassiveSkillInfoList_;
			}
		}

		// Token: 0x0601053C RID: 66876 RVA: 0x00261E1D File Offset: 0x0026001D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillNotify);
		}

		// Token: 0x0601053D RID: 66877 RVA: 0x00261E2B File Offset: 0x0026002B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillNotify other)
		{
			return other != null && (other == this || (this.rolePassiveSkillInfoList_.Equals(other.rolePassiveSkillInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601053E RID: 66878 RVA: 0x00261E60 File Offset: 0x00260060
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

		// Token: 0x0601053F RID: 66879 RVA: 0x00261E94 File Offset: 0x00260094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010540 RID: 66880 RVA: 0x00261EA1 File Offset: 0x002600A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010541 RID: 66881 RVA: 0x00261EAA File Offset: 0x002600AA
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

		// Token: 0x06010542 RID: 66882 RVA: 0x00261ED4 File Offset: 0x002600D4
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

		// Token: 0x06010543 RID: 66883 RVA: 0x00261F0D File Offset: 0x0026010D
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

		// Token: 0x06010544 RID: 66884 RVA: 0x00261F3B File Offset: 0x0026013B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010545 RID: 66885 RVA: 0x00261F44 File Offset: 0x00260144
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rolePassiveSkillInfoList_.AddEntriesFrom(ref input, PassiveSkillNotify._repeated_rolePassiveSkillInfoList_codec);
				}
			}
		}

		// Token: 0x04006811 RID: 26641
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006812 RID: 26642
		public const int RolePassiveSkillInfoListFieldNumber = 1;

		// Token: 0x04006813 RID: 26643
		private static readonly FieldCodec<RolePassiveSkillInfo> _repeated_rolePassiveSkillInfoList_codec = FieldCodec.ForMessage<RolePassiveSkillInfo>(10U, RolePassiveSkillInfo.Parser);

		// Token: 0x04006814 RID: 26644
		private readonly RepeatedField<RolePassiveSkillInfo> rolePassiveSkillInfoList_ = new RepeatedField<RolePassiveSkillInfo>();
	}
}
